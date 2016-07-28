Public Class frmStart


    Public g As Decimal
    Public r As Decimal
    Public l As Decimal



    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles Me.Load
        DoubleBuffered = True
        Me.Left = 500
        Me.Top = 10
        Me.Width = 400
        Me.Height = 345
        Me.gfxTimer.Start()                                                                     'Explanation to gfxTimer
    End Sub

    Private Sub cmdPendel2D_Click(sender As Object, e As EventArgs) Handles cmdPendel2D.Click
        If frmPendel.Visible = True Then        'Wenn frmPendel (2D) angezeigt, dann "versteckt" der Klick das Fenster wieder
            frmPendel.Hide()
        Else
            frmPendel.Show()                    'Wenn frmPendel (2D) nicht angezeigt, öffnet der Klick das Fenster
        End If
    End Sub

    Private Sub cmdPendel3D_Click(sender As Object, e As EventArgs) Handles cmdPendel3D.Click
        If frmPendel3D.Visible = True Then      'Dasselbe wie oben, nur für das 3D Pendel
            frmPendel3D.Hide()
        Else
            frmPendel3D.Show()
        End If
    End Sub

    Private Sub cmdStartStop_Click(sender As Object, e As EventArgs) Handles cmdStartStop.Click
        If physTimer.Enabled = False Then                              'Start / Stop. Timer jeweils umschalten
            physTimer.Enabled = True
        Else
            physTimer.Enabled = False
        End If
    End Sub

    Private Sub cmddiagramm_Click(sender As Object, e As EventArgs) Handles cmddiagramm.Click
        If frmDiagramm.Visible = False Then
            frmDiagramm.Show()
        Else
            frmDiagramm.Hide()

        End If



    End Sub

    Private Sub cmdEinstellungen_Click(sender As Object, e As EventArgs) Handles cmdEinstellungen.Click
        If physTimer.Enabled = False Then
            frmEinstellungen.Show()
            For Each ctl In Me.Controls
                If TypeOf ctl Is Button Then
                    DirectCast(ctl, Button).Enabled = False
                End If
            Next
        Else
            physTimer.Enabled = False
        End If
    End Sub



    Public WinkelAccel As Decimal
    Public WinkelSpeed As Decimal
    Public WinkelAuslenk As Decimal

    Public n As Decimal

    Public alphawa(100) As Decimal            '-> 101 Positionen!     
    Public alphas(100) As Decimal
    Public alphaa(100) As Decimal

    Public Zoom As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles physTimer.Tick

        WinkelAccel = -g / l * Math.Sin(WinkelAuslenk) - WinkelSpeed * 0.1 * 1.9
        WinkelSpeed = WinkelSpeed + WinkelAccel * 0.1
        WinkelAuslenk = WinkelAuslenk + WinkelSpeed * 0.1


        If n < 100 Then
            alphaa(n) = WinkelAccel
            alphas(n) = WinkelSpeed
            alphawa(n) = WinkelAuslenk

            n = n + 1
        Else

            For i = 0 To 99
                alphaa(i) = alphaa(i + 1)
                alphaa(100) = WinkelAccel
                alphas(i) = alphas(i + 1)
                alphas(100) = WinkelSpeed
                alphawa(i) = alphawa(i + 1)
                alphawa(100) = WinkelAuslenk
            Next
        End If


        'Refresh()
        'frmDiagramm.Refresh()
        'frmPendel.Refresh()
        'frmPendel3D.Refresh()



    End Sub

    Private Sub gfxTimer_Tick(sender As Object, e As EventArgs) Handles gfxTimer.Tick
        Refresh()
        frmDiagramm.Refresh()
        frmPendel.Refresh()
        frmPendel3D.Refresh()



    End Sub



End Class