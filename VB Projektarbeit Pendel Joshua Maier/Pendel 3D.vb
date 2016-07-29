Public Class frmPendel3D

    Private Sub frmPendel3D_Load(sender As Object, e As EventArgs) Handles Me.Load
        DoubleBuffered = True
        Me.Width = 500                      'Weite und Höhe des Fensters
        Me.Height = 550

        xAufhaengung3D = Me.Width / 2       'Definition des Aufhängungspunktes
        yAufhaengung3D = Me.Height / 2


    End Sub

    Public Breite As Integer                            'Definition Variablen für Breite, Höhe, Tiefe des Quaders
    Public Hoehe As Integer
    Public Tiefe As Integer

    Dim WinkelDrehx As Decimal                          'Drehwinkel um x und y Achsen und Pendel(=z)
    Dim WinkelDrehy As Decimal
    Dim WinkelDrehz As Decimal

    Dim xNull(11) As Decimal                            'Definition Arrays(Datenfelder) für Nullpunte x,y,z der Quaderecken
    Dim yNull(11) As Decimal
    Dim zNull(11) As Decimal

    Dim xDrehx(11) As Decimal                           'Dreh Array xDreh yDreh in 3er Blöcken wie oben (um x,y,z; Arrays)
    Dim xDrehy(11) As Decimal
    Dim xDrehz(11) As Decimal

    Dim yDrehx(11) As Decimal                           '^
    Dim yDrehy(11) As Decimal
    Dim yDrehz(11) As Decimal

    Dim zDrehx(11) As Decimal                           '^(Pendeln)
    Dim zDrehy(11) As Decimal
    Dim zDrehz(11) As Decimal


    Dim xzeichnen(11) As Decimal                        'Definition Arrays(Datenfelder) für mögliche Länge des gezeichneten Strichs
    Dim yzeichnen(11) As Decimal

    Dim xAufhaengung3D As Decimal                       'Definition der Variablen für Aufhängungspunkt
    Dim yAufhaengung3D As Decimal

    Dim p As New Pen(Color.Black, 2)                    'Definition p als Pen=Stift für Linien der Kanten.

    Dim koordlinie As New Pen(Color.Red, 0.5)           'Stift zum Zeichnen des Koordinatensystems



    Private Sub frmPendel3D_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        WinkelDrehz = frmStart.WinkelAuslenk               'Wert für Auslenkwinkel aus frmPendel holen


        'Punkte des Quaders von vorne oben links rundzählend nach hinten unten links sind 0,1,2,3 ; 4,5,6,7


        For Each i In {0, 3, 4, 7}          'Punkte links
            xNull(i) = -Breite / 2          'Breite (x) wird von Mitte aufgespannt, Breite links
        Next

        For Each i In {1, 2, 5, 6}          'Punkte rechts
            xNull(i) = Breite / 2           'Breite rechts
        Next

        For Each i In {0, 1, 2, 3}          'Punkte oben
            yNull(i) = 0                    'Oben=Nullpunkt, y Richtung wird nach unten aufgespannt (aber positiv)
        Next

        For Each i In {4, 5, 6, 7}          'Punkte unten
            yNull(i) = Hoehe                'Nach unten aufgespannte y Richtung = Hoehe
        Next

        For Each i In {2, 3, 6, 7}          'Punkte hinten
            zNull(i) = -Tiefe / 2           'Tiefe (z) wird auch aus der Mitte heraus aufgespannt, Tiefe nach hinten
        Next

        For Each i In {0, 1, 4, 5}          'Punkte vorne
            zNull(i) = Tiefe / 2            'Tiefe nach vorne
        Next


        'Drehen(y)/Kippen(x)/Pendeln(z) durch Multiplikation JEDES Eckpunktes im 3D Raum mit der Rotationsmatrix für x, y, z
        'Matrizenmultiplikation bzw. Vektor*Matrix: Zeile mal Spalte.
        'Arrays für Quadereckpunkte (Eckpunkte aufgespalten in x,y,z) werden für Multiplikation verwendet.Z.B.:  (x y z) * (1  0   0
        '                                                                                                        0 sin -cos 
        '                                                                                                        0 cos  sin)
        '                                                                                            = (a b c); Spalte a (bspw): x*1+y*0+z*0





        'x:

        For i = 0 To 7
            xDrehx(i) = xNull(i)                                        'Wenn um x Achse gedreht wird, verändern sich die x Werte nicht (irrelevant)
            yDrehx(i) = yNull(i) * Math.Cos(WinkelDrehx) + zNull(i) * Math.Sin(WinkelDrehx)
            zDrehx(i) = -yNull(i) * Math.Sin(WinkelDrehx) + zNull(i) * Math.Cos(WinkelDrehx)
        Next

        'y:

        For i = 0 To 7
            xDrehy(i) = xDrehx(i) * Math.Cos(WinkelDrehy) + zDrehx(i) * Math.Sin(WinkelDrehy)
            yDrehy(i) = yDrehx(i)
            zDrehy(i) = -xDrehx(i) * Math.Sin(WinkelDrehy) + zDrehx(i) * Math.Cos(WinkelDrehy)
        Next

        'z:

        For i = 0 To 7
            xDrehz(i) = xDrehy(i) * Math.Cos(WinkelDrehz) + yDrehx(i) * Math.Sin(WinkelDrehz)
            yDrehz(i) = -xDrehy(i) * Math.Sin(WinkelDrehz) + yDrehy(i) * Math.Cos(WinkelDrehz)
            zDrehz(i) = zDrehy(i)
        Next





        For i = 0 To 7
            xzeichnen(i) = xAufhaengung3D + xDrehz(i)
            yzeichnen(i) = yAufhaengung3D + yDrehz(i)
        Next

        For Each i In {1, 3, 4}
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality                          'Weichere, "flüssigere" Linien / Kantenglättung
            e.Graphics.DrawLine(p, xzeichnen(0), yzeichnen(0), xzeichnen(i), yzeichnen(i))          'Zeichnen der Kanten von oben vorne links nach rechts, hinten, unten ( 0 zu 1, 3, 4)
        Next

        For Each i In {1, 3, 6}
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            e.Graphics.DrawLine(p, xzeichnen(2), yzeichnen(2), xzeichnen(i), yzeichnen(i))          'Zeichnen der Kanten von oben hinten rechts nach links, vorne, unten (2 zu 3, 1, 6)
        Next

        For Each i In {4, 6, 1}
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            e.Graphics.DrawLine(p, xzeichnen(5), yzeichnen(5), xzeichnen(i), yzeichnen(i))          'Zeichnen der Kanten von vorne unten rechts nach links, hinten, oben (5 zu 4, 6, 1)
        Next

        For Each i In {6, 4, 3}
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            e.Graphics.DrawLine(p, xzeichnen(7), yzeichnen(7), xzeichnen(i), yzeichnen(i))          'Zeichnen der Kanten von hinten unten links nach vorne, rechts, oben (7 zu 4, 6, 3)
        Next

        For i = 0 To 7
            e.Graphics.FillEllipse(Brushes.Black, xzeichnen(1) - 2, yzeichnen(1) - 2, 4, 4)         'Zeichnen der Eckpunkte (0, 1, 2, 3, 4, 5, 6, 7)
        Next



        If chkKoordinatensystem.Checked Then                                                             'Wenn Checkbox "Koordinatensystem anzeigen" angeklickt ist, wird Folgendes berechnet:
            xNull(8) = yNull(8) = 0                                                                             'Der Urpsrung
            xNull(9) = 50                                                                                       'Endpunkt der x-Achse
            yNull(9) = 0                                                                                        'Ist bei der Koordinaten xNull(9) = 50 und yNull(9) = 0
            xNull(10) = 0                                                                                       'Endpunkt der y-Achse
            yNull(10) = -50                                                                                     'Ist bei den Koordinaten xNull(10) = 0 und yNull(10) = -50
            xNull(11) = -28                                                                                     'Endpunkt der z-Achse
            yNull(11) = 28                                                                                      'Ist bei den Koordinaten xNull(11) = -28 und yNull(11) = 28
            For i = 8 To 11
                xzeichnen(i) = xAufhaengung3D + xNull(i)                                                        'In Abhängigkeit von der Aufhängung rechnen
                yzeichnen(i) = yAufhaengung3D + yNull(i)
            Next
            For i = 8 To 11
                koordlinie.EndCap = Drawing2D.LineCap.ArrowAnchor                                               'Ende der Koordinatenlinie soll Pfeil sein
                e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality                                  'Kantenglättung
                e.Graphics.DrawLine(koordlinie, xzeichnen(8), yzeichnen(8), xzeichnen(i), yzeichnen(i))         'Zeichnen der Linien des Koordinatensystems (koordlinie = Stift)
            Next


        End If



    End Sub

    'Buttons für die Drehungen nach oben, unten, links, rechts um jeweils 0.1 pro Click

    'Oben:

    Private Sub cmdOben_Click(sender As Object, e As EventArgs) Handles cmdOben.Click
        WinkelDrehx = WinkelDrehx + 0.1
    End Sub

    'Unten

    Private Sub cmdUnten_Click(sender As Object, e As EventArgs) Handles cmdUnten.Click
        WinkelDrehx = WinkelDrehx - 0.1
    End Sub

    'Links

    Private Sub cmdLinks_Click(sender As Object, e As EventArgs) Handles cmdLinks.Click
        WinkelDrehy = WinkelDrehy - 0.1
    End Sub

    'Rechts

    Private Sub cmdRechts_Click(sender As Object, e As EventArgs) Handles cmdRechts.Click
        WinkelDrehy = WinkelDrehy + 0.1
    End Sub

    'Funktionalitaet des Reset Buttons:

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        WinkelDrehx = 0
        WinkelDrehy = 0
    End Sub

End Class