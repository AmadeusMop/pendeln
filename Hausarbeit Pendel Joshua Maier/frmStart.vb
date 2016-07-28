Public Class frmStart
    Public WinkelAuslenk As Decimal                 'Definition öffentlicher Variablen für 2D Pendel
    Public r As Decimal
    Public l As Decimal

    Public g As Decimal
    Public WinkelSpeed As Decimal
    Public WinkelAccel As Decimal


    Private Sub cmdPendel2D_Click(sender As Object, e As EventArgs) Handles cmdPendel2D.Click       'cmd=click

        If frmPendel.Visible = True Then        'Wenn frmPendel (2D) angezeigt, dann "versteckt" der Klick das Fenster wieder
            frmPendel.Hide()
        Else
            frmPendel.Show()                    'Wenn frmPendel (2D) nicht angezeigt, öffnet er Klick das Fenster
        End If

    End Sub

    Private Sub cmdPendel3D_Click(sender As Object, e As EventArgs) Handles cmdPendel3D.Click       'cmd=click

        If frmPendel3D.Visible = True Then      'Dasselbe wie oben, nur für das 3D Pendel
            frmPendel3D.Hide()
        Else
            frmPendel3D.Show()
        End If

    End Sub



    Private Sub cmdStartStop_Click(sender As Object, e As EventArgs) Handles cmdStartStop.Click
        If Timer1.Enabled = False Then                              'Start / Stop. Timer jeweils umschalten
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub cmdEinstellungen_Click(sender As Object, e As EventArgs) Handles cmdEinstellungen.Click
        If Timer1.Enabled = False Then
            frmEinstellungen.Show()
            For Each ctl In Me.Controls
                If TypeOf ctl Is Button Then
                    DirectCast(ctl, Button).Enabled = False
                End If
            Next
        Else
            Timer1.Enabled = False
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'r = 10
        'l = 1
        'g = 9.81




        WinkelAccel = -g / l * Math.Sin(WinkelAuslenk) - WinkelSpeed * 0.1 * 1.9
        WinkelSpeed = WinkelSpeed + WinkelAccel * 0.1
        WinkelAuslenk = WinkelAuslenk + WinkelSpeed * 0.1


        Refresh()
        frmPendel.Refresh()
        frmPendel3D.Refresh()




    End Sub

    'Private Sub lblTimer_Click(sender As Object, e As EventArgs) Handles lblTimer.Click

    'End Sub


    
    
End Class