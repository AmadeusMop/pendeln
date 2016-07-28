<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEinstellungen
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
        Me.cmdEinstellspeich = New System.Windows.Forms.Button()
        Me.lblWinkelAuslenk = New System.Windows.Forms.Label()
        Me.txtWinkelMax = New System.Windows.Forms.TextBox()
        Me.lblEinstellungenÜberschrift = New System.Windows.Forms.Label()
        Me.lblPhyVor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbll = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.txtl = New System.Windows.Forms.TextBox()
        Me.txtr = New System.Windows.Forms.TextBox()
        Me.lblPlanet = New System.Windows.Forms.Label()
        Me.cmbStandort = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBreite = New System.Windows.Forms.Label()
        Me.lblHoehe = New System.Windows.Forms.Label()
        Me.lblTiefe = New System.Windows.Forms.Label()
        Me.cmbBreite = New System.Windows.Forms.ComboBox()
        Me.cmbHoehe = New System.Windows.Forms.ComboBox()
        Me.cmbTiefe = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdEinstellspeich
        '
        Me.cmdEinstellspeich.Location = New System.Drawing.Point(176, 486)
        Me.cmdEinstellspeich.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEinstellspeich.Name = "cmdEinstellspeich"
        Me.cmdEinstellspeich.Size = New System.Drawing.Size(100, 28)
        Me.cmdEinstellspeich.TabIndex = 0
        Me.cmdEinstellspeich.Text = "Speichern"
        Me.cmdEinstellspeich.UseVisualStyleBackColor = True
        '
        'lblWinkelAuslenk
        '
        Me.lblWinkelAuslenk.AutoSize = True
        Me.lblWinkelAuslenk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinkelAuslenk.Location = New System.Drawing.Point(16, 111)
        Me.lblWinkelAuslenk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWinkelAuslenk.Name = "lblWinkelAuslenk"
        Me.lblWinkelAuslenk.Size = New System.Drawing.Size(142, 16)
        Me.lblWinkelAuslenk.TabIndex = 1
        Me.lblWinkelAuslenk.Text = "Winkel Auslenkung in °"
        '
        'txtWinkelMax
        '
        Me.txtWinkelMax.Location = New System.Drawing.Point(284, 107)
        Me.txtWinkelMax.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWinkelMax.Name = "txtWinkelMax"
        Me.txtWinkelMax.Size = New System.Drawing.Size(132, 22)
        Me.txtWinkelMax.TabIndex = 2
        Me.txtWinkelMax.Text = "45"
        '
        'lblEinstellungenÜberschrift
        '
        Me.lblEinstellungenÜberschrift.AutoSize = True
        Me.lblEinstellungenÜberschrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEinstellungenÜberschrift.Location = New System.Drawing.Point(61, 32)
        Me.lblEinstellungenÜberschrift.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEinstellungenÜberschrift.Name = "lblEinstellungenÜberschrift"
        Me.lblEinstellungenÜberschrift.Size = New System.Drawing.Size(248, 24)
        Me.lblEinstellungenÜberschrift.TabIndex = 3
        Me.lblEinstellungenÜberschrift.Text = "Einstellungen / Vorgaben"
        '
        'lblPhyVor
        '
        Me.lblPhyVor.AutoSize = True
        Me.lblPhyVor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhyVor.Location = New System.Drawing.Point(16, 75)
        Me.lblPhyVor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhyVor.Name = "lblPhyVor"
        Me.lblPhyVor.Size = New System.Drawing.Size(199, 20)
        Me.lblPhyVor.TabIndex = 4
        Me.lblPhyVor.Text = "Physikalische Vorgaben"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 185)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pendel 2D"
        '
        'lbll
        '
        Me.lbll.AutoSize = True
        Me.lbll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbll.Location = New System.Drawing.Point(16, 226)
        Me.lbll.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbll.Name = "lbll"
        Me.lbll.Size = New System.Drawing.Size(108, 16)
        Me.lbll.TabIndex = 6
        Me.lbll.Text = "Fadenlänge in m"
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr.Location = New System.Drawing.Point(16, 261)
        Me.lblr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(113, 16)
        Me.lblr.TabIndex = 7
        Me.lblr.Text = "Kugelradius in cm"
        '
        'txtl
        '
        Me.txtl.Location = New System.Drawing.Point(284, 219)
        Me.txtl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtl.Name = "txtl"
        Me.txtl.Size = New System.Drawing.Size(132, 22)
        Me.txtl.TabIndex = 8
        Me.txtl.Text = "1"
        '
        'txtr
        '
        Me.txtr.Location = New System.Drawing.Point(284, 251)
        Me.txtr.Margin = New System.Windows.Forms.Padding(4)
        Me.txtr.Name = "txtr"
        Me.txtr.Size = New System.Drawing.Size(132, 22)
        Me.txtr.TabIndex = 9
        Me.txtr.Text = "15"
        '
        'lblPlanet
        '
        Me.lblPlanet.AutoSize = True
        Me.lblPlanet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanet.Location = New System.Drawing.Point(16, 143)
        Me.lblPlanet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlanet.Name = "lblPlanet"
        Me.lblPlanet.Size = New System.Drawing.Size(46, 16)
        Me.lblPlanet.TabIndex = 10
        Me.lblPlanet.Text = "Planet"
        '
        'cmbStandort
        '
        Me.cmbStandort.FormattingEnabled = True
        Me.cmbStandort.Items.AddRange(New Object() {"Merkur", "Venus", "Erde", "Mond", "Mars", "Jupiter", "Saturn", "Uranus", "Neptun", "Pluto"})
        Me.cmbStandort.Location = New System.Drawing.Point(256, 139)
        Me.cmbStandort.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStandort.Name = "cmbStandort"
        Me.cmbStandort.Size = New System.Drawing.Size(160, 24)
        Me.cmbStandort.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 306)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Pendel 3D"
        '
        'lblBreite
        '
        Me.lblBreite.AutoSize = True
        Me.lblBreite.Location = New System.Drawing.Point(17, 353)
        Me.lblBreite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBreite.Name = "lblBreite"
        Me.lblBreite.Size = New System.Drawing.Size(43, 16)
        Me.lblBreite.TabIndex = 13
        Me.lblBreite.Text = "Breite"
        '
        'lblHoehe
        '
        Me.lblHoehe.AutoSize = True
        Me.lblHoehe.Location = New System.Drawing.Point(17, 398)
        Me.lblHoehe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoehe.Name = "lblHoehe"
        Me.lblHoehe.Size = New System.Drawing.Size(41, 16)
        Me.lblHoehe.TabIndex = 14
        Me.lblHoehe.Text = "Höhe"
        '
        'lblTiefe
        '
        Me.lblTiefe.AutoSize = True
        Me.lblTiefe.Location = New System.Drawing.Point(17, 439)
        Me.lblTiefe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiefe.Name = "lblTiefe"
        Me.lblTiefe.Size = New System.Drawing.Size(39, 16)
        Me.lblTiefe.TabIndex = 15
        Me.lblTiefe.Text = "Tiefe"
        '
        'cmbBreite
        '
        Me.cmbBreite.FormattingEnabled = True
        Me.cmbBreite.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "60", "70", "80", "90", "100"})
        Me.cmbBreite.Location = New System.Drawing.Point(284, 347)
        Me.cmbBreite.Name = "cmbBreite"
        Me.cmbBreite.Size = New System.Drawing.Size(121, 24)
        Me.cmbBreite.TabIndex = 16
        Me.cmbBreite.Text = "40"
        '
        'cmbHoehe
        '
        Me.cmbHoehe.FormattingEnabled = True
        Me.cmbHoehe.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "120", "140", "160", "180", "200"})
        Me.cmbHoehe.Location = New System.Drawing.Point(284, 392)
        Me.cmbHoehe.Name = "cmbHoehe"
        Me.cmbHoehe.Size = New System.Drawing.Size(121, 24)
        Me.cmbHoehe.TabIndex = 17
        Me.cmbHoehe.Text = "140"
        '
        'cmbTiefe
        '
        Me.cmbTiefe.FormattingEnabled = True
        Me.cmbTiefe.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "60", "70", "80", "90", "100"})
        Me.cmbTiefe.Location = New System.Drawing.Point(284, 433)
        Me.cmbTiefe.Name = "cmbTiefe"
        Me.cmbTiefe.Size = New System.Drawing.Size(121, 24)
        Me.cmbTiefe.TabIndex = 18
        Me.cmbTiefe.Text = "40"
        '
        'frmEinstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 528)
        Me.Controls.Add(Me.cmbTiefe)
        Me.Controls.Add(Me.cmbHoehe)
        Me.Controls.Add(Me.cmbBreite)
        Me.Controls.Add(Me.lblTiefe)
        Me.Controls.Add(Me.lblHoehe)
        Me.Controls.Add(Me.lblBreite)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbStandort)
        Me.Controls.Add(Me.lblPlanet)
        Me.Controls.Add(Me.txtr)
        Me.Controls.Add(Me.txtl)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.lbll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPhyVor)
        Me.Controls.Add(Me.lblEinstellungenÜberschrift)
        Me.Controls.Add(Me.txtWinkelMax)
        Me.Controls.Add(Me.lblWinkelAuslenk)
        Me.Controls.Add(Me.cmdEinstellspeich)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEinstellungen"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEinstellspeich As System.Windows.Forms.Button
    Friend WithEvents lblWinkelAuslenk As System.Windows.Forms.Label
    Friend WithEvents txtWinkelMax As System.Windows.Forms.TextBox
    Friend WithEvents lblEinstellungenÜberschrift As System.Windows.Forms.Label
    Friend WithEvents lblPhyVor As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbll As System.Windows.Forms.Label
    Friend WithEvents lblr As System.Windows.Forms.Label
    Friend WithEvents txtl As System.Windows.Forms.TextBox
    Friend WithEvents txtr As System.Windows.Forms.TextBox
    Friend WithEvents lblPlanet As System.Windows.Forms.Label
    Friend WithEvents cmbStandort As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBreite As System.Windows.Forms.Label
    Friend WithEvents lblHoehe As System.Windows.Forms.Label
    Friend WithEvents lblTiefe As System.Windows.Forms.Label
    Friend WithEvents cmbBreite As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoehe As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTiefe As System.Windows.Forms.ComboBox

End Class
