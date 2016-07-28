Public Class frmDiagramm

    Private Sub Diagramm_Load(sender As Object, e As EventArgs) Handles Me.Load     'Bestimmung der Position und Größe des Fensters beim Anklicken von "Diagramm" in der Start Form
        DoubleBuffered = True
        Me.Left = 10
        Me.Top = 10
        Me.Width = 650
        Me.Height = 600
    End Sub


    Dim xUrsprungx As Integer                       'Ursprung x-Achse x Koordinate                  Ursprung = origin
    Dim xUrsprungy As Integer                       '   "         "   y Koordinate                  
    Dim HoeheDiagramm As Decimal                    'Hoehe des Diagramms                            height of diagram
    Dim BreiteDiagramm As Decimal                   'Breite/Laenge des Diagramms                    width/length (in x direction) of diagramm

    Dim Umrandung As New Pen(Color.Black, 2)        'Stift für Rand (pen for painting edges of diagram)
    Dim xAchse As New Pen(Color.Black, 1)           'Stift für x-Achse (pen for x axis)

    Dim x0 As Decimal
    Dim x1 As Decimal
    Dim yAuslenkung0 As Decimal                     'Auslenkung = amplitude
    Dim yAuslenkung1 As Decimal
    Dim ySpeed0 As Decimal
    Dim ySpeed1 As Decimal
    Dim yAccel0 As Decimal
    Dim yAccel1 As Decimal

    Dim sinAuslenkung As New Pen(Color.Red, 2)
    Dim sinSpeed As New Pen(Color.Blue, 2)
    Dim sinAccel As New Pen(Color.Green, 2)
    Dim alphamax As Decimal

    
    
    Private Sub frmDiagramm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        HoeheDiagramm = Me.Height - 200
        BreiteDiagramm = Me.Width - 20
        xUrsprungx = 10
        xUrsprungy = 350
        

        With e.Graphics
            .DrawRectangle(Umrandung, xUrsprungx, xUrsprungy - HoeheDiagramm / 2, BreiteDiagramm, HoeheDiagramm)
            .FillRectangle(Brushes.White, xUrsprungx, xUrsprungy - HoeheDiagramm / 2, BreiteDiagramm, HoeheDiagramm)
            .DrawLine(xAchse, xUrsprungx, xUrsprungy, xUrsprungx + BreiteDiagramm, xUrsprungy)
        End With

        For i = 1 To frmStart.n - 1
            x0 = xUrsprungx + (i - 1) * BreiteDiagramm / 100
            x1 = xUrsprungx + (i) * BreiteDiagramm / 100

            yAccel0 = xUrsprungy - frmStart.alphaa(i - 1) * frmStart.Zoom
            yAccel1 = xUrsprungy - frmStart.alphaa(i) * frmStart.Zoom

            ySpeed0 = xUrsprungy - frmStart.alphas(i - 1) * frmStart.Zoom
            ySpeed1 = xUrsprungy - frmStart.alphas(i) * frmStart.Zoom

            yAuslenkung0 = xUrsprungy - frmStart.alphawa(i - 1) * frmStart.Zoom
            yAuslenkung1 = xUrsprungy - frmStart.alphawa(i) * frmStart.Zoom



            If optlinie.Checked = True Then                                                 'optlinie check box for chosing to show line instead of dots (see form)

                If chkAccel.Checked = True Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.DrawLine(sinAuslenkung, x0, yAccel0, x1, yAccel1)
                End If

                If chkSpeed.Checked = True Then
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    e.Graphics.DrawLine(sinAuslenkung, x0, ySpeed0, x1, ySpeed1)
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
   

End Class