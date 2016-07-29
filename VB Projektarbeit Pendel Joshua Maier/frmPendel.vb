Public Class frmPendel


    Private Sub frmPendel_Load(sender As Object, e As EventArgs) Handles Me.Load

        DoubleBuffered = True
        Me.Top = 200
        Me.Left = 500
        Me.Width = 400
        Me.Height = 400

    End Sub

    Private Sub frmPendel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Me.Paint

        Dim xAufhäng As Integer
        Dim yAufhäng As Integer
        Dim xPosK As Integer
        Dim yPosK As Integer
        Dim p As New Pen(Color.DarkGray, 2.5)

        xAufhäng = Me.Width / 2
        yAufhäng = 20

        xPosK = xAufhäng + 150 * Math.Sin(frmStart.WinkelAuslenk) * frmStart.l
        yPosK = yAufhäng + 150 * Math.Cos(frmStart.WinkelAuslenk) * frmStart.l

        With e.Graphics
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            .DrawLine(p, xAufhäng, yAufhäng, xPosK, yPosK)
            .FillEllipse(Brushes.DarkBlue, xAufhäng - frmStart.r, yAufhäng - frmStart.r, frmStart.r * 2, frmStart.r * 2)
            .FillEllipse(Brushes.Black, xPosK - 15, yPosK - 15, 30, 30)

        End With


    End Sub

End Class