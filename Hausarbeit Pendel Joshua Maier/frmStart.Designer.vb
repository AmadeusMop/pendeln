﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.physTimer = New System.Windows.Forms.Timer(Me.components)
        Me.gfxTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cmdStartStop = New System.Windows.Forms.Button()
        Me.lblStartÜberschrift = New System.Windows.Forms.Label()
        Me.cmdEinstellungen = New System.Windows.Forms.Button()
        Me.cmdPendel2D = New System.Windows.Forms.Button()
        Me.cmdPendel3D = New System.Windows.Forms.Button()
        Me.cmdDiagramm = New System.Windows.Forms.Button()
        Me.cmdMesswerte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'physTimer
        '
        '
        'gfxTimer
        '
        Me.gfxTimer.Interval = 10
        '
        'cmdStartStop
        '
        Me.cmdStartStop.Enabled = False
        Me.cmdStartStop.Location = New System.Drawing.Point(138, 227)
        Me.cmdStartStop.Name = "cmdStartStop"
        Me.cmdStartStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStartStop.TabIndex = 1
        Me.cmdStartStop.Text = "Start / Stop"
        Me.cmdStartStop.UseVisualStyleBackColor = True
        '
        'lblStartÜberschrift
        '
        Me.lblStartÜberschrift.AutoSize = True
        Me.lblStartÜberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartÜberschrift.Location = New System.Drawing.Point(74, 31)
        Me.lblStartÜberschrift.Name = "lblStartÜberschrift"
        Me.lblStartÜberschrift.Size = New System.Drawing.Size(205, 20)
        Me.lblStartÜberschrift.TabIndex = 2
        Me.lblStartÜberschrift.Text = "VB Pendel Joshua Maier"
        '
        'cmdEinstellungen
        '
        Me.cmdEinstellungen.Location = New System.Drawing.Point(98, 77)
        Me.cmdEinstellungen.Name = "cmdEinstellungen"
        Me.cmdEinstellungen.Size = New System.Drawing.Size(154, 23)
        Me.cmdEinstellungen.TabIndex = 3
        Me.cmdEinstellungen.Text = "Einstellungen / Vorgaben"
        Me.cmdEinstellungen.UseVisualStyleBackColor = True
        '
        'cmdPendel2D
        '
        Me.cmdPendel2D.Enabled = False
        Me.cmdPendel2D.Location = New System.Drawing.Point(77, 136)
        Me.cmdPendel2D.Name = "cmdPendel2D"
        Me.cmdPendel2D.Size = New System.Drawing.Size(75, 23)
        Me.cmdPendel2D.TabIndex = 4
        Me.cmdPendel2D.Text = "Pendel 2D"
        Me.cmdPendel2D.UseVisualStyleBackColor = True
        '
        'cmdPendel3D
        '
        Me.cmdPendel3D.Enabled = False
        Me.cmdPendel3D.Location = New System.Drawing.Point(77, 165)
        Me.cmdPendel3D.Name = "cmdPendel3D"
        Me.cmdPendel3D.Size = New System.Drawing.Size(75, 23)
        Me.cmdPendel3D.TabIndex = 5
        Me.cmdPendel3D.Text = "Pendel 3D"
        Me.cmdPendel3D.UseVisualStyleBackColor = True
        '
        'cmdDiagramm
        '
        Me.cmdDiagramm.Enabled = False
        Me.cmdDiagramm.Location = New System.Drawing.Point(199, 136)
        Me.cmdDiagramm.Name = "cmdDiagramm"
        Me.cmdDiagramm.Size = New System.Drawing.Size(75, 23)
        Me.cmdDiagramm.TabIndex = 6
        Me.cmdDiagramm.Text = "Diagramm"
        Me.cmdDiagramm.UseVisualStyleBackColor = True
        '
        'cmdMesswerte
        '
        Me.cmdMesswerte.Enabled = False
        Me.cmdMesswerte.Location = New System.Drawing.Point(199, 165)
        Me.cmdMesswerte.Name = "cmdMesswerte"
        Me.cmdMesswerte.Size = New System.Drawing.Size(75, 23)
        Me.cmdMesswerte.TabIndex = 7
        Me.cmdMesswerte.Text = "Messwerte"
        Me.cmdMesswerte.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 297)
        Me.Controls.Add(Me.cmdMesswerte)
        Me.Controls.Add(Me.cmdDiagramm)
        Me.Controls.Add(Me.cmdPendel3D)
        Me.Controls.Add(Me.cmdPendel2D)
        Me.Controls.Add(Me.cmdEinstellungen)
        Me.Controls.Add(Me.lblStartÜberschrift)
        Me.Controls.Add(Me.cmdStartStop)
        Me.Name = "frmStart"
        Me.Text = "Start"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents physTimer As System.Windows.Forms.Timer
    Friend WithEvents gfxTimer As System.Windows.Forms.Timer
    Friend WithEvents cmdStartStop As System.Windows.Forms.Button
    Friend WithEvents lblStartÜberschrift As System.Windows.Forms.Label
    Friend WithEvents cmdEinstellungen As System.Windows.Forms.Button
    Friend WithEvents cmdPendel2D As System.Windows.Forms.Button
    Friend WithEvents cmdPendel3D As System.Windows.Forms.Button
    Friend WithEvents cmdDiagramm As System.Windows.Forms.Button
    Friend WithEvents cmdMesswerte As System.Windows.Forms.Button
End Class
