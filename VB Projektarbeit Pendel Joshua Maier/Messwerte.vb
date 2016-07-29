Public Class Messwerte

    Private Sub Messwerte_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        boxAccel.Text = frmStart.WinkelAccel
        boxSpeed.Text = frmStart.WinkelSpeed
        boxAuslenk.Text = frmStart.WinkelAuslenk
        boxTime.Text = String.Format("{0:N1}", frmStart.zeit / 10.0)
    End Sub
End Class