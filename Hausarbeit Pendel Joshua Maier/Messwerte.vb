Public Class Messwerte
    Private Sub Messwerte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Messwerte_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim accel As Decimal
        Dim speed As Decimal
        Dim auslenk As Decimal
        Dim lastIndex As Integer

        lastIndex = Math.Min(Math.Max(0, frmStart.n - 1), 99)

        accel = frmStart.alphaa(lastIndex)
        speed = frmStart.alphas(lastIndex)
        auslenk = frmStart.alphawa(lastIndex)

        boxAccel.Text = accel
        boxSpeed.Text = speed
        boxAuslenk.Text = auslenk
        boxTime.Text = String.Format("{0:N1}", frmStart.zeit / 10.0)
    End Sub
End Class