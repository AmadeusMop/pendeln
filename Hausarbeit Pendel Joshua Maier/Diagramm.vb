Public Class frmDiagramm

    Private Sub Diagramm_Load(sender As Object, e As EventArgs) Handles Me.Load     'Bestimmung von Standard-Werten beim Laden des Fensters
        DoubleBuffered = True                                                       'Zur Vermeidung des Flackerns
        Me.Left = 10                                                                '10 Einheiten vom linken Bildschirmrand entfernt
        Me.Top = 10                                                                 '10 Einheiten vom oberen Bildschirmrand entfernt
        Me.Width = 650                                                              'Breite = 650 Einheiten
        Me.Height = 600                                                             'Hoehe = 600 Einheiten
        Me.HoeheDiagramm = Height - 200
        auto_scale(False)
    End Sub


    Dim xUrsprungx As Integer                       'Ursprung x-Achse x Koordinate
    Dim xUrsprungy As Integer                       '   "         "   y Koordinate
    Dim HoeheDiagramm As Decimal                    'Hoehe des Diagramms
    Dim BreiteDiagramm As Decimal                   'Breite/Laenge des Diagramms 

    Dim Umrandung As New Pen(Color.Black, 2)        'Stift für Rand
    Dim xAchse As New Pen(Color.Black, 1)           'Stift für x-Achse

    Dim x0 As Decimal
    Dim x1 As Decimal
    Dim dx As Decimal                               'What's dx?
    Dim yAuslenkung0 As Decimal
    Dim yAuslenkung1 As Decimal
    Dim ySpeed0 As Decimal
    Dim ySpeed1 As Decimal
    Dim yAccel0 As Decimal
    Dim yAccel1 As Decimal

    Dim sinAuslenkung As New Pen(Color.Red, 2)
    Dim sinSpeed As New Pen(Color.Blue, 2)
    Dim sinAccel As New Pen(Color.Green, 2)
    Dim alphamax As Decimal

    Dim zoom As Decimal

    Private Sub frmDiagramm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        HoeheDiagramm = Me.Height - 200
        BreiteDiagramm = Me.Width - 20
        xUrsprungx = 10
        xUrsprungy = 150

        auto_scale(True)

        dx = BreiteDiagramm / 100

        With e.Graphics
            .DrawRectangle(Umrandung, xUrsprungx, xUrsprungy, BreiteDiagramm, HoeheDiagramm)
            .FillRectangle(Brushes.White, xUrsprungx, xUrsprungy, BreiteDiagramm, HoeheDiagramm)
            .DrawLine(xAchse, xUrsprungx, xUrsprungy + HoeheDiagramm / 2, xUrsprungx + BreiteDiagramm, xUrsprungy + HoeheDiagramm / 2)
        End With

        For i = 1 To Math.Min(frmStart.zeit - 2, 100)
            x0 = xUrsprungx + (i - 1) * dx
            x1 = x0 + dx

            yAccel0 = xUrsprungy - frmStart.alphaa(i - 1) * zoom
            yAccel1 = xUrsprungy - frmStart.alphaa(i) * zoom

            ySpeed0 = xUrsprungy - frmStart.alphas(i - 1) * zoom
            ySpeed1 = xUrsprungy - frmStart.alphas(i) * zoom

            yAuslenkung0 = xUrsprungy - frmStart.alphawa(i - 1) * zoom
            yAuslenkung1 = xUrsprungy - frmStart.alphawa(i) * zoom



            If optlinie.Checked Then

                If chkAccel.Checked Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.DrawLine(sinAccel, x0, yAccel0, x1, yAccel1)
                End If

                If chkSpeed.Checked Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.DrawLine(sinSpeed, x0, ySpeed0, x1, ySpeed1)
                End If

                If chkAuslenkung.Checked Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.DrawLine(sinAuslenkung, x0, yAuslenkung0, x1, yAuslenkung1)
                End If

            Else

                If chkAccel.Checked Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.FillEllipse(Brushes.Green, x0 - 2, yAccel0 - 2, 4, 4)
                End If

                If chkSpeed.Checked Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.FillEllipse(Brushes.Blue, x0 - 2, ySpeed0 - 2, 4, 4)
                End If

                If chkAuslenkung.Checked Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.FillEllipse(Brushes.Red, x0 - 2, yAuslenkung0 - 2, 4, 4)
                End If
            End If
        Next

    End Sub

    Private Sub cmdzoomin_Click(sender As Object, e As EventArgs) Handles cmdzoomin.Click
        zoom = zoom * 2
    End Sub

    Private Sub cmdzoomout_Click(sender As Object, e As EventArgs) Handles cmdzoomout.Click
        zoom = zoom / 2
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        zoom = 1.0
    End Sub

    Public Sub auto_scale(onlyIfBoundsExceeded As Boolean)
        'Autoscale sets the scale factor to be equal to (half of graph height) / (magnitude of the data point with the highest magnitude).
        'Therefore, that data point will have a height equal to half the graph height, which means it and all smaller data points
        '(that is, all data points) will fit neatly inside the graph.

        Dim scaleVal As Decimal
        Dim tmpZoom As Decimal

        scaleVal = {
            frmStart.alphaa.Max(), -frmStart.alphaa.Min(),
            frmStart.alphas.Max(), -frmStart.alphas.Min(),
            frmStart.alphawa.Max(), -frmStart.alphawa.Min()
        }.Max()

        If scaleVal > 0 Then                                    'to avoid zero-division
            tmpZoom = HoeheDiagramm / (2 * scaleVal)

            If onlyIfBoundsExceeded Then
                'autoscale only when the data exceeds the bounds of the graph
                zoom = Math.Min(zoom, tmpZoom)
            Else
                zoom = tmpZoom
            End If
        Else
            zoom = 1.0
        End If
    End Sub

    Public Sub cmdautoscale_Click(sender As Object, e As EventArgs) Handles cmdautoscale.Click
        auto_scale(False)
    End Sub
End Class