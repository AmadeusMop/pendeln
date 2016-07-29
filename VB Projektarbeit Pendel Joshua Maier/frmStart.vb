﻿Public Class frmStart
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles Me.Load
        DoubleBuffered = True
        Me.Left = 500
        Me.Top = 10
        Me.Width = 400
        Me.Height = 345
        Me.zeit = 0
        Me.gfxTimer.Start()                                                                     'Explanation to gfxTimer
    End Sub

    Public g As Decimal
    Public r As Decimal
    Public l As Decimal

    Public WinkelAccel As Decimal
    Public WinkelSpeed As Decimal
    Public WinkelAuslenk As Decimal

    Public reibung As Decimal
    Public zeit As Integer

    Public alphawa(100) As Decimal            '-> 101 Positionen!     
    Public alphas(100) As Decimal
    Public alphaa(100) As Decimal





    Private Sub cmdPendel2D_Click(sender As Object, e As EventArgs) Handles cmdPendel2D.Click
        If frmPendel.Visible Then        'Wenn frmPendel (2D) angezeigt, dann "versteckt" der Klick das Fenster wieder
            frmPendel.Hide()
        Else
            frmPendel.Show()                    'Wenn frmPendel (2D) nicht angezeigt, öffnet der Klick das Fenster
        End If
    End Sub

    Private Sub cmdPendel3D_Click(sender As Object, e As EventArgs) Handles cmdPendel3D.Click
        If frmPendel3D.Visible Then      'Dasselbe wie oben, nur für das 3D Pendel
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

    Private Sub cmddiagramm_Click(sender As Object, e As EventArgs) Handles cmdDiagramm.Click
        If frmDiagramm.Visible = False Then
            frmDiagramm.Show()
        Else
            frmDiagramm.Hide()

        End If
    End Sub

    Private Sub cmdMesswerte_Click(sender As Object, e As EventArgs) Handles cmdMesswerte.Click
        If Messwerte.Visible = False Then
            Messwerte.Show()
        Else
            Messwerte.Hide()

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



   

    Private Sub physTimer_Tick(sender As Object, e As EventArgs) Handles physTimer.Tick

        WinkelAccel = -g / l * Math.Sin(WinkelAuslenk) - WinkelSpeed * 0.1 * reibung
        WinkelSpeed = WinkelSpeed + WinkelAccel * 0.1
        WinkelAuslenk = WinkelAuslenk + WinkelSpeed * 0.1

        If zeit <= 100 Then
            alphaa(zeit) = WinkelAccel
            alphas(zeit) = WinkelSpeed
            alphawa(zeit) = WinkelAuslenk
        Else
            For i = 0 To 99
                alphaa(i) = alphaa(i + 1)
                alphas(i) = alphas(i + 1)
                alphawa(i) = alphawa(i + 1)
            Next

            alphaa(100) = WinkelAccel
            alphas(100) = WinkelSpeed
            alphawa(100) = WinkelAuslenk
        End If

        zeit = zeit + 1

    End Sub

    Private Sub gfxTimer_Tick(sender As Object, e As EventArgs) Handles gfxTimer.Tick
        Refresh()
        frmDiagramm.Refresh()
        frmPendel.Refresh()
        frmPendel3D.Refresh()
        Messwerte.Refresh()


    End Sub



End Class