<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiagramm
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
        Me.cmdautoscale = New System.Windows.Forms.Button()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.cmdzoomout = New System.Windows.Forms.Button()
        Me.cmdzoomin = New System.Windows.Forms.Button()
        Me.chkAccel = New System.Windows.Forms.CheckBox()
        Me.chkSpeed = New System.Windows.Forms.CheckBox()
        Me.chkAuslenkung = New System.Windows.Forms.CheckBox()
        Me.optpunkte = New System.Windows.Forms.RadioButton()
        Me.optlinie = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cmdautoscale
        '
        Me.cmdautoscale.Location = New System.Drawing.Point(70, 42)
        Me.cmdautoscale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdautoscale.Name = "cmdautoscale"
        Me.cmdautoscale.Size = New System.Drawing.Size(112, 35)
        Me.cmdautoscale.TabIndex = 0
        Me.cmdautoscale.Text = "Autoscale"
        Me.cmdautoscale.UseVisualStyleBackColor = True
        '
        'cmdreset
        '
        Me.cmdreset.Location = New System.Drawing.Point(412, 40)
        Me.cmdreset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(112, 35)
        Me.cmdreset.TabIndex = 1
        Me.cmdreset.Text = "Reset"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'cmdzoomout
        '
        Me.cmdzoomout.Location = New System.Drawing.Point(291, 40)
        Me.cmdzoomout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdzoomout.Name = "cmdzoomout"
        Me.cmdzoomout.Size = New System.Drawing.Size(112, 35)
        Me.cmdzoomout.TabIndex = 2
        Me.cmdzoomout.Text = "Zoom out"
        Me.cmdzoomout.UseVisualStyleBackColor = True
        '
        'cmdzoomin
        '
        Me.cmdzoomin.Location = New System.Drawing.Point(534, 40)
        Me.cmdzoomin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdzoomin.Name = "cmdzoomin"
        Me.cmdzoomin.Size = New System.Drawing.Size(112, 35)
        Me.cmdzoomin.TabIndex = 4
        Me.cmdzoomin.Text = "Zoom in"
        Me.cmdzoomin.UseVisualStyleBackColor = True
        '
        'chkAccel
        '
        Me.chkAccel.AutoSize = True
        Me.chkAccel.Checked = True
        Me.chkAccel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAccel.Location = New System.Drawing.Point(207, 86)
        Me.chkAccel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkAccel.Name = "chkAccel"
        Me.chkAccel.Size = New System.Drawing.Size(149, 24)
        Me.chkAccel.TabIndex = 5
        Me.chkAccel.Text = "Beschleunigung"
        Me.chkAccel.UseVisualStyleBackColor = True
        '
        'chkSpeed
        '
        Me.chkSpeed.AutoSize = True
        Me.chkSpeed.Location = New System.Drawing.Point(369, 85)
        Me.chkSpeed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSpeed.Name = "chkSpeed"
        Me.chkSpeed.Size = New System.Drawing.Size(151, 24)
        Me.chkSpeed.TabIndex = 6
        Me.chkSpeed.Text = "Geschwindigkeit"
        Me.chkSpeed.UseVisualStyleBackColor = True
        '
        'chkAuslenkung
        '
        Me.chkAuslenkung.AutoSize = True
        Me.chkAuslenkung.Location = New System.Drawing.Point(534, 85)
        Me.chkAuslenkung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkAuslenkung.Name = "chkAuslenkung"
        Me.chkAuslenkung.Size = New System.Drawing.Size(119, 24)
        Me.chkAuslenkung.TabIndex = 7
        Me.chkAuslenkung.Text = "Auslenkung"
        Me.chkAuslenkung.UseVisualStyleBackColor = True
        '
        'optpunkte
        '
        Me.optpunkte.AutoSize = True
        Me.optpunkte.Checked = True
        Me.optpunkte.Location = New System.Drawing.Point(70, 86)
        Me.optpunkte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optpunkte.Name = "optpunkte"
        Me.optpunkte.Size = New System.Drawing.Size(84, 24)
        Me.optpunkte.TabIndex = 8
        Me.optpunkte.TabStop = True
        Me.optpunkte.Text = "Punkte"
        Me.optpunkte.UseVisualStyleBackColor = True
        '
        'optlinie
        '
        Me.optlinie.AutoSize = True
        Me.optlinie.Location = New System.Drawing.Point(70, 123)
        Me.optlinie.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optlinie.Name = "optlinie"
        Me.optlinie.Size = New System.Drawing.Size(67, 24)
        Me.optlinie.TabIndex = 9
        Me.optlinie.Text = "Linie"
        Me.optlinie.UseVisualStyleBackColor = True
        '
        'frmDiagramm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 546)
        Me.Controls.Add(Me.optlinie)
        Me.Controls.Add(Me.optpunkte)
        Me.Controls.Add(Me.chkAuslenkung)
        Me.Controls.Add(Me.chkSpeed)
        Me.Controls.Add(Me.chkAccel)
        Me.Controls.Add(Me.cmdzoomin)
        Me.Controls.Add(Me.cmdzoomout)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.cmdautoscale)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmDiagramm"
        Me.Text = "Diagramm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdautoscale As System.Windows.Forms.Button
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents cmdzoomout As System.Windows.Forms.Button
    Friend WithEvents cmdzoomin As System.Windows.Forms.Button
    Friend WithEvents chkAccel As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpeed As System.Windows.Forms.CheckBox
    Friend WithEvents chkAuslenkung As System.Windows.Forms.CheckBox
    Friend WithEvents optpunkte As System.Windows.Forms.RadioButton
    Friend WithEvents optlinie As System.Windows.Forms.RadioButton
End Class
