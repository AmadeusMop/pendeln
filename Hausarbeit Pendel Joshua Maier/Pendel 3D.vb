Public Class frmPendel3D

    Public Breite As Decimal            'Definition Variablen für Breite, Höhe, Tiefe des Quaders
    Public Hoehe As Decimal             'Variables for width, height, depth of cupoid (in that order)
    Public Tiefe As Decimal

    Dim WinkelDrehx As Decimal          'Drehwinkel um x und y Achsen und Pendel(=z)
    Dim WinkelDrehy As Decimal          'Variables for turning angle around x,y,z axes (z being the one that will display the "swing" of the pendulum in the end)
    Dim WinkelDrehz As Decimal

    Dim xNull(11) As Decimal            'Definition Arrays(Datenfelder) für Nullpunte x,y,z der Quaderecken
    Dim yNull(11) As Decimal            'Arrays for the 8 vertices of the cuboid in the original position (null=zero)
    Dim zNull(11) As Decimal

    Dim xDrehx(11) As Decimal           'Dreh Array xDreh yDreh in 3er Blöcken wie oben (um x,y,z; Arrays)
    Dim xDrehy(11) As Decimal           'Arrays for later multiplication of the vertices with the rotation matrix
    Dim xDrehz(11) As Decimal

    Dim yDrehx(11) As Decimal           '^
    Dim yDrehy(11) As Decimal
    Dim yDrehz(11) As Decimal

    Dim zDrehx(11) As Decimal           '^
    Dim zDrehy(11) As Decimal
    Dim zDrehz(11) As Decimal


    Dim xzeichnen(11) As Decimal        'Definition Arrays(Datenfelder) für mögliche Länge des gezeichneten Strichs
    Dim yzeichnen(11) As Decimal        'Arrays for painting the edges

    Dim xAufhaengung3D As Decimal       'Definition der Variablen für Aufhängungspunkt
    Dim yAufhaengung3D As Decimal       'variables for suspension bracket

    Dim p As New Pen(Color.Black, 1)    'Definition p als Pen=Stift; pen for cupoid

    Dim koordlinie As New Pen(Color.Red, 0.5)           'pen for painting coordinate system


    Dim WinkelPendel As Decimal


    Private Sub frmPendel3D_Load(sender As Object, e As EventArgs) Handles Me.Load
        DoubleBuffered = True
        Me.Width = 450                      'Weite und Höhe des Fensters
        Me.Height = 550                     'width & height of the window

        xAufhaengung3D = Me.Width / 2       'Definition des Aufhängungspunktes
        yAufhaengung3D = Me.Height / 2      'definition of the location of suspension


    End Sub


    Private Sub frmPendel3D_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        WinkelPendel = frmStart.WinkelAuslenk               'Wert für Auslenkwinkel aus frmPendel holen
        'Winkel=angle; Auslenk=amplitude; says that angle of pendulum equals amplitude/"angle" of frmPendel (=thus they are swinging "parallely", right?)

        'Punkte des Quaders von vorne oben links rundzählend nach hinten unten links sind 0,1,2,3 ; 4,5,6,7
        'definition of vertices of cuboid based on the arrays:

        For Each i In {0, 3, 4, 7}          'Punkte links(left)
            xNull(i) = -Breite / 2          'Breite (x) wird von Mitte aufgespannt, Breite links
        Next

        For Each i In {1, 2, 5, 6}          'Punkte rechts(right)
            xNull(i) = Breite / 2           'Breite rechts
        Next

        For Each i In {0, 1, 2, 3}          'Punkte oben(top)
            yNull(i) = 0                    'Oben=Nullpunkt, y Richtung wird nach unten aufgespannt (aber positiv)
        Next

        For Each i In {4, 5, 6, 7}          'Punkte unten(bottom)
            yNull(i) = Hoehe                'Nach unten aufgespannte y Richtung = Hoehe
        Next

        For Each i In {2, 3, 6, 7}          'Punkte hinten(back)
            zNull(i) = -Tiefe / 2           'Tiefe (z) wird auch aus der Mitte heraus aufgespannt, Tiefe nach hinten
        Next

        For Each i In {0, 1, 4, 5}          'Punkte vorne(front)
            zNull(i) = Tiefe / 2            'Tiefe nach vorne
        Next


        'Drehen(y)/Kippen(x)/Pendeln(z) durch Multiplikation JEDES Eckpunktes im 3D Raum mit der Rotationsmatrix für x, y, z
        'Matrizenmultiplikation/Vektor*Matrix: Zeile mal Spalte.
        'Arrays für Quadereckpunkte (aufgespalten auf x,y,z) werden für Multiplikation verwendet.   (x y z) * (1  0   0
        '                                                                                                      0 sin -cos 
        '                                                                                                      0 cos  sin)
        '                                                                                           = (a b c); Spalte a (bspw): x*1+y*0+z*0


        'Multiplication of vertices (split in x,y,z coordinates) with rotation matrices                  spalte=column  bspw=for example


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
            xzeichnen(i) = xNull(i) + xAufhaengung3D            'zeichnen=paint; painting cupoid
            yzeichnen(i) = yNull(i) + yAufhaengung3D
        Next

        For Each i In {1, 3, 4}
            e.Graphics.DrawLine(p, xzeichnen(0), yzeichnen(0), xzeichnen(i), yzeichnen(i))
        Next

        For Each i In {1, 3, 6}
            e.Graphics.DrawLine(p, xzeichnen(2), yzeichnen(2), xzeichnen(i), yzeichnen(i))
        Next

        For Each i In {4, 6, 1}
            e.Graphics.DrawLine(p, xzeichnen(5), yzeichnen(5), xzeichnen(i), yzeichnen(i))
        Next

        For Each i In {6, 4, 3}
            e.Graphics.DrawLine(p, xzeichnen(7), yzeichnen(7), xzeichnen(i), yzeichnen(i))
        Next

    End Sub


End Class