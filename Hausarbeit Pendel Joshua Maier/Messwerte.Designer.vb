<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messwerte
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
        Me.lblAccel = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblAuslenk = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAccel
        '
        Me.lblAccel.AutoSize = True
        Me.lblAccel.Location = New System.Drawing.Point(22, 25)
        Me.lblAccel.Name = "lblAccel"
        Me.lblAccel.Size = New System.Drawing.Size(83, 13)
        Me.lblAccel.TabIndex = 0
        Me.lblAccel.Text = "Beschleunigung"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(22, 62)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(85, 13)
        Me.lblSpeed.TabIndex = 1
        Me.lblSpeed.Text = "Geschwindigkeit"
        '
        'lblAuslenk
        '
        Me.lblAuslenk.AutoSize = True
        Me.lblAuslenk.Location = New System.Drawing.Point(22, 101)
        Me.lblAuslenk.Name = "lblAuslenk"
        Me.lblAuslenk.Size = New System.Drawing.Size(63, 13)
        Me.lblAuslenk.TabIndex = 2
        Me.lblAuslenk.Text = "Auslenkung"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(22, 138)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(25, 13)
        Me.lbltime.TabIndex = 3
        Me.lbltime.Text = "Zeit"
        '
        'Messwerte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 198)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lblAuslenk)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblAccel)
        Me.Name = "Messwerte"
        Me.Text = "Messwerte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAccel As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblAuslenk As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
End Class
