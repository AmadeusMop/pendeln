Public Class frmDiagramm

    Private Sub Diagramm_Load(sender As Object, e As EventArgs) Handles Me.Load     'Bestimmung der Position und Größe des Fensters beim Anklicken von "Diagramm" in der Start Form
        DoubleBuffered = True
        Me.Left = 10
        Me.Top = 10
        Me.Width = 650
        Me.Height = 600

        Me.zoom = 1.0
    End Sub


    Dim xUrsprungx As Integer                       'Ursprung x-Achse x Koordinate
    Dim xUrsprungy As Integer                       '   "         "   y Koordinate
    Dim HoeheDiagramm As Decimal                    'Hoehe des Diagramms
    Dim BreiteDiagramm As Decimal                   'Breite/Laenge des Diagramms 

    Dim Umrandung As New Pen(Color.Black, 2)        'Stift für Rand
    Dim xAchse As New Pen(Color.Black, 1)           'Stift für x-Achse

    Dim x0 As Decimal
    Dim x1 As Decimal
    Dim dx As Decimal
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
        xUrsprungy = 350

        dx = BreiteDiagramm / 100

        With e.Graphics
            .DrawRectangle(Umrandung, xUrsprungx, xUrsprungy - HoeheDiagramm / 2, BreiteDiagramm, HoeheDiagramm)
            .FillRectangle(Brushes.White, xUrsprungx, xUrsprungy - HoeheDiagramm / 2, BreiteDiagramm, HoeheDiagramm)
            .DrawLine(xAchse, xUrsprungx, xUrsprungy, xUrsprungx + BreiteDiagramm, xUrsprungy)
        End With

        For i = Math.Max(1, frmStart.n - 101) To frmStart.n - 1
            x0 = xUrsprungx + (i - 1) * dx
            x1 = x0 + dx

            yAccel0 = xUrsprungy - frmStart.alphaa(i - 1) * zoom
            yAccel1 = xUrsprungy - frmStart.alphaa(i) * zoom

            ySpeed0 = xUrsprungy - frmStart.alphas(i - 1) * zoom
            ySpeed1 = xUrsprungy - frmStart.alphas(i) * zoom

            yAuslenkung0 = xUrsprungy - frmStart.alphawa(i - 1) * zoom
            yAuslenkung1 = xUrsprungy - frmStart.alphawa(i) * zoom



            If optlinie.Checked = True Then

                If chkAccel.Checked = True Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.DrawLine(sinAccel, x0, yAccel0, x1, yAccel1)
                End If

                If chkSpeed.Checked = True Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.DrawLine(sinSpeed, x0, ySpeed0, x1, ySpeed1)
                End If

                If chkAuslenkung.Checked = True Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.DrawLine(sinAuslenkung, x0, yAuslenkung0, x1, yAuslenkung1)
                End If

            Else

                If chkAccel.Checked = True Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.FillEllipse(Brushes.Green, x0 - 2, yAccel0 - 2, 4, 4)
                End If

                If chkSpeed.Checked = True Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.FillEllipse(Brushes.Blue, x0 - 2, ySpeed0 - 2, 4, 4)
                End If

                If chkAuslenkung.Checked = True Then
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

    Private Sub cmdautoscale_Click(sender As Object, e As EventArgs) Handles cmdautoscale.Click
        zoom = 1.0
    End Sub
End Class