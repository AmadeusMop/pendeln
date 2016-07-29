Public Class Messwerte

    Private Sub Messwerte_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim accel As Decimal
        Dim speed As Decimal
        Dim auslenk As Decimal
        Dim lastIndex As Integer

        lastIndex = Math.Min(frmStart.zeit, frmStart.alphaa.Length) - 2

        If lastIndex >= 0 Then

            accel = frmStart.alphaa(lastIndex)
            speed = frmStart.alphas(lastIndex)
            auslenk = frmStart.alphawa(lastIndex)
        Else
            accel = 0
            speed = 0
            auslenk = 0
        End If


        boxAccel.Text = accel
        boxSpeed.Text = speed
        boxAuslenk.Text = auslenk
        boxTime.Text = String.Format("{0:N1}", frmStart.zeit / 10.0)
    End Sub
End Class