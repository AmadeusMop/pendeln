<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPendel3D
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
        Me.cmdOben = New System.Windows.Forms.Button()
        Me.cmdLinks = New System.Windows.Forms.Button()
        Me.cmdUnten = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdRechts = New System.Windows.Forms.Button()
        Me.chkKoordinatensystem = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdOben
        '
        Me.cmdOben.Location = New System.Drawing.Point(132, 26)
        Me.cmdOben.Name = "cmdOben"
        Me.cmdOben.Size = New System.Drawing.Size(75, 23)
        Me.cmdOben.TabIndex = 0
        Me.cmdOben.Text = "Oben"
        Me.cmdOben.UseVisualStyleBackColor = True
        '
        'cmdLinks
        '
        Me.cmdLinks.Location = New System.Drawing.Point(51, 55)
        Me.cmdLinks.Name = "cmdLinks"
        Me.cmdLinks.Size = New System.Drawing.Size(75, 23)
        Me.cmdLinks.TabIndex = 1
        Me.cmdLinks.Text = "Links"
        Me.cmdLinks.UseVisualStyleBackColor = True
        '
        'cmdUnten
        '
        Me.cmdUnten.Location = New System.Drawing.Point(132, 84)
        Me.cmdUnten.Name = "cmdUnten"
        Me.cmdUnten.Size = New System.Drawing.Size(75, 23)
        Me.cmdUnten.TabIndex = 2
        Me.cmdUnten.Text = "Unten"
        Me.cmdUnten.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(132, 55)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 3
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdRechts
        '
        Me.cmdRechts.Location = New System.Drawing.Point(213, 55)
        Me.cmdRechts.Name = "cmdRechts"
        Me.cmdRechts.Size = New System.Drawing.Size(75, 23)
        Me.cmdRechts.TabIndex = 4
        Me.cmdRechts.Text = "Rechts"
        Me.cmdRechts.UseVisualStyleBackColor = True
        '
        'chkKoordinatensystem
        '
        Me.chkKoordinatensystem.AutoSize = True
        Me.chkKoordinatensystem.Location = New System.Drawing.Point(90, 113)
        Me.chkKoordinatensystem.Name = "chkKoordinatensystem"
        Me.chkKoordinatensystem.Size = New System.Drawing.Size(161, 17)
        Me.chkKoordinatensystem.TabIndex = 5
        Me.chkKoordinatensystem.Text = "Koordinatensystem anzeigen"
        Me.chkKoordinatensystem.UseVisualStyleBackColor = True
        '
        'frmPendel3D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 318)
        Me.Controls.Add(Me.chkKoordinatensystem)
        Me.Controls.Add(Me.cmdRechts)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdUnten)
        Me.Controls.Add(Me.cmdLinks)
        Me.Controls.Add(Me.cmdOben)
        Me.Name = "frmPendel3D"
        Me.Text = "Pendel_3D"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOben As System.Windows.Forms.Button
    Friend WithEvents cmdLinks As System.Windows.Forms.Button
    Friend WithEvents cmdUnten As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdRechts As System.Windows.Forms.Button
    Friend WithEvents chkKoordinatensystem As System.Windows.Forms.CheckBox
End Class
