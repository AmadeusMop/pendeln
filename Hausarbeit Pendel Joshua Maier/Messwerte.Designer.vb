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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.boxAccel = New System.Windows.Forms.TextBox()
        Me.boxSpeed = New System.Windows.Forms.TextBox()
        Me.boxAuslenk = New System.Windows.Forms.TextBox()
        Me.boxTime = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAccel
        '
        Me.lblAccel.AutoSize = True
        Me.lblAccel.Location = New System.Drawing.Point(33, 38)
        Me.lblAccel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccel.Name = "lblAccel"
        Me.lblAccel.Size = New System.Drawing.Size(123, 20)
        Me.lblAccel.TabIndex = 0
        Me.lblAccel.Text = "Beschleunigung"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(33, 95)
        Me.lblSpeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(125, 20)
        Me.lblSpeed.TabIndex = 1
        Me.lblSpeed.Text = "Geschwindigkeit"
        '
        'lblAuslenk
        '
        Me.lblAuslenk.AutoSize = True
        Me.lblAuslenk.Location = New System.Drawing.Point(33, 155)
        Me.lblAuslenk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAuslenk.Name = "lblAuslenk"
        Me.lblAuslenk.Size = New System.Drawing.Size(93, 20)
        Me.lblAuslenk.TabIndex = 2
        Me.lblAuslenk.Text = "Auslenkung"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(33, 212)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(36, 20)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "Zeit"
        '
        'boxAccel
        '
        Me.boxAccel.Location = New System.Drawing.Point(37, 66)
        Me.boxAccel.Name = "boxAccel"
        Me.boxAccel.ReadOnly = True
        Me.boxAccel.Size = New System.Drawing.Size(119, 26)
        Me.boxAccel.TabIndex = 4
        '
        'boxSpeed
        '
        Me.boxSpeed.Location = New System.Drawing.Point(37, 118)
        Me.boxSpeed.Name = "boxSpeed"
        Me.boxSpeed.ReadOnly = True
        Me.boxSpeed.Size = New System.Drawing.Size(119, 26)
        Me.boxSpeed.TabIndex = 5
        '
        'boxAuslenk
        '
        Me.boxAuslenk.Location = New System.Drawing.Point(37, 178)
        Me.boxAuslenk.Name = "boxAuslenk"
        Me.boxAuslenk.ReadOnly = True
        Me.boxAuslenk.Size = New System.Drawing.Size(119, 26)
        Me.boxAuslenk.TabIndex = 6
        '
        'boxTime
        '
        Me.boxTime.Location = New System.Drawing.Point(37, 235)
        Me.boxTime.Name = "boxTime"
        Me.boxTime.ReadOnly = True
        Me.boxTime.Size = New System.Drawing.Size(119, 26)
        Me.boxTime.TabIndex = 7
        '
        'Messwerte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 305)
        Me.Controls.Add(Me.boxTime)
        Me.Controls.Add(Me.boxAuslenk)
        Me.Controls.Add(Me.boxSpeed)
        Me.Controls.Add(Me.boxAccel)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblAuslenk)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblAccel)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Messwerte"
        Me.Text = "Messwerte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAccel As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblAuslenk As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label

    Friend WithEvents boxAccel As TextBox
    Friend WithEvents boxSpeed As TextBox
    Friend WithEvents boxAuslenk As TextBox
    Friend WithEvents boxTime As TextBox
End Class
