Public Class frmEinstellungen

    Private Sub cmdEinstellspeich_Click(sender As Object, e As EventArgs) Handles cmdEinstellspeich.Click

        Dim a As Boolean = True                                         'Boolsche Var. zur Prüfung der Gültigkeit von Eingaben
        txtWinkelMax.BackColor = Color.White                            'Hintergrundfarbe txtbox bei korrekter Eingabe und Start wieder auf weiß

        Try                                                             'Überprüfung Gültigkeit der Eingabe für Winkel Auslenkung
            frmStart.WinkelAuslenk = txtWinkelMax.Text                      'Prüfung der Variablen-Definition
        Catch ex As Exception                                               'nicht gültig
            a = False                                                       'dann Boolsche Variable auf FALSE
            txtWinkelMax.BackColor = Color.Red                                  'und Hintergrundfarbe auf rot
        End Try

        Try
            frmStart.l = txtl.Text                                      'Überprüfung Gültigkeit der Eingabe der Fadenlänge
        Catch ex As Exception
            a = False
            txtl.BackColor = Color.Red
        End Try

        Try
            frmStart.r = txtr.Text                                      'Überprüfung Gültigkeit der Eingabe für den Kugelradius
        Catch ex As Exception
            a = False
            txtr.BackColor = Color.Red

        End Try

        Select Case cmbStandort.SelectedIndex                                   'Zuweisung Werte für Fallbeschleunigung
            Case 0                                                              'Merkur
                frmStart.g = 3.7
            Case 1                                                              'Venus
                frmStart.g = 8.87
            Case 2                                                              'Erde
                frmStart.g = 9.81
            Case 3                                                              'Mond
                frmStart.g = 1.6
            Case 4                                                              'Mars
                frmStart.g = 3.71
            Case 5                                                              'Jupiter
                frmStart.g = 23.12
            Case 6                                                              'Saturn
                frmStart.g = 8.96
            Case 7                                                              'Uranus
                frmStart.g = 8.69
            Case 8                                                              'Neptun
                frmStart.g = 11
            Case 9                                                              'Pluto
                frmStart.g = 0.72

        End Select

        frmPendel3D.Breite = cmbBreite.Text                         'Erlangen der auswählbaren Werte für Breite, Höhe, Tiefe für das 3D Pendel
        frmPendel3D.Hoehe = cmbHoehe.Text
        frmPendel3D.Tiefe = cmbTiefe.Text


        If a = True Then                                                            ' ? Alles ok ?
            frmStart.WinkelAuslenk = frmStart.WinkelAuslenk * Math.PI / 180                 'ja, dann ° --> Bogenmaß und Wert
            Me.Hide()
            For Each ctl In frmStart.Controls
                If TypeOf ctl Is Button Then
                    DirectCast(ctl, Button).Enabled = True
                End If
            Next
        Else : MessageBox.Show("Ungültige Eingabe-! Verwenden Sie nur Zahlen!")         'nein, dann Fehlermeldung
        End If


    End Sub

    Private Sub frmEinstellungen_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbStandort.SelectedIndex = 2

        Me.Top = 450
    End Sub



    'Private Sub lblPhyVor_Click(sender As Object, e As EventArgs) Handles lblPhyVor.Click

    'End Sub


End Class
