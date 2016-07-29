<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.gfxTimer.Interval = 20
        '
        'cmdStartStop
        '
        Me.cmdStartStop.Enabled = False
        Me.cmdStartStop.Location = New System.Drawing.Point(207, 349)
        Me.cmdStartStop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdStartStop.Name = "cmdStartStop"
        Me.cmdStartStop.Size = New System.Drawing.Size(112, 35)
        Me.cmdStartStop.TabIndex = 1
        Me.cmdStartStop.Text = "Start / Stop"
        Me.cmdStartStop.UseVisualStyleBackColor = True
        '
        'lblStartÜberschrift
        '
        Me.lblStartÜberschrift.AutoSize = True
        Me.lblStartÜberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartÜberschrift.Location = New System.Drawing.Point(111, 48)
        Me.lblStartÜberschrift.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartÜberschrift.Name = "lblStartÜberschrift"
        Me.lblStartÜberschrift.Size = New System.Drawing.Size(299, 29)
        Me.lblStartÜberschrift.TabIndex = 2
        Me.lblStartÜberschrift.Text = "VB Pendel Joshua Maier"
        '
        'cmdEinstellungen
        '
        Me.cmdEinstellungen.Location = New System.Drawing.Point(147, 119)
        Me.cmdEinstellungen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdEinstellungen.Name = "cmdEinstellungen"
        Me.cmdEinstellungen.Size = New System.Drawing.Size(231, 35)
        Me.cmdEinstellungen.TabIndex = 3
        Me.cmdEinstellungen.Text = "Einstellungen / Vorgaben"
        Me.cmdEinstellungen.UseVisualStyleBackColor = True
        '
        'cmdPendel2D
        '
        Me.cmdPendel2D.Enabled = False
        Me.cmdPendel2D.Location = New System.Drawing.Point(116, 209)
        Me.cmdPendel2D.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdPendel2D.Name = "cmdPendel2D"
        Me.cmdPendel2D.Size = New System.Drawing.Size(112, 35)
        Me.cmdPendel2D.TabIndex = 4
        Me.cmdPendel2D.Text = "Pendel 2D"
        Me.cmdPendel2D.UseVisualStyleBackColor = True
        '
        'cmdPendel3D
        '
        Me.cmdPendel3D.Enabled = False
        Me.cmdPendel3D.Location = New System.Drawing.Point(116, 254)
        Me.cmdPendel3D.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdPendel3D.Name = "cmdPendel3D"
        Me.cmdPendel3D.Size = New System.Drawing.Size(112, 35)
        Me.cmdPendel3D.TabIndex = 5
        Me.cmdPendel3D.Text = "Pendel 3D"
        Me.cmdPendel3D.UseVisualStyleBackColor = True
        '
        'cmdDiagramm
        '
        Me.cmdDiagramm.Location = New System.Drawing.Point(298, 209)
        Me.cmdDiagramm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdDiagramm.Name = "cmdDiagramm"
        Me.cmdDiagramm.Size = New System.Drawing.Size(112, 35)
        Me.cmdDiagramm.TabIndex = 6
        Me.cmdDiagramm.Text = "Diagramm"
        Me.cmdDiagramm.UseVisualStyleBackColor = True
        '
        'cmdMesswerte
        '
        Me.cmdMesswerte.Location = New System.Drawing.Point(298, 254)
        Me.cmdMesswerte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdMesswerte.Name = "cmdMesswerte"
        Me.cmdMesswerte.Size = New System.Drawing.Size(112, 35)
        Me.cmdMesswerte.TabIndex = 7
        Me.cmdMesswerte.Text = "Messwerte"
        Me.cmdMesswerte.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 457)
        Me.Controls.Add(Me.cmdMesswerte)
        Me.Controls.Add(Me.cmdDiagramm)
        Me.Controls.Add(Me.cmdPendel3D)
        Me.Controls.Add(Me.cmdPendel2D)
        Me.Controls.Add(Me.cmdEinstellungen)
        Me.Controls.Add(Me.lblStartÜberschrift)
        Me.Controls.Add(Me.cmdStartStop)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
