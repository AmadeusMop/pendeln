﻿Public Class frmStart


    Public g As Decimal
    Public r As Decimal
    Public l As Decimal



    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles Me.Load
        DoubleBuffered = True
        Me.Left = 500
        Me.Top = 10
        Me.Width = 400
        Me.Height = 345
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
        If Timer1.Enabled = False Then                              'Start / Stop. Timer jeweils umschalten
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub cmddiagramm_Click(sender As Object, e As EventArgs) Handles cmddiagramm.Click
        If frmDiagramm.Visible = False Then
            frmDiagramm.Show()
            Zoom = 100
        Else
            frmDiagramm.Hide()

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



    Public WinkelAccel As Decimal               'Winkel=angle; acceleration, speed, amplitude
    Public WinkelSpeed As Decimal
    Public WinkelAuslenk As Decimal

    Public n As Decimal                         'See frmStart at bottom, there n is set to 0, in order for it to start there

    Public alphawa(100) As Decimal              'alphawa = alphaamplitude  
    Public alphas(100) As Decimal               'alphas = alphaspeed
    Public alphaa(100) As Decimal               'alphaa = alphaaccel

    Public Zoom As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

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


        Refresh()
        frmPendel.Refresh()
        frmPendel3D.Refresh()



    End Sub



End Class