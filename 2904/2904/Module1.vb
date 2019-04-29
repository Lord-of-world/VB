Module Module1
    Dim g As Drawing.Graphics
    Public Sub lodka(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer)
        Dim kist As New SolidBrush(Color.Blue)
        Dim x1, y1 As Integer
        g = Form1.CreateGraphics
        Dim dno(3) As PointF
        dno(0).X = x + h \ 4
        dno(0).Y = y + h
        dno(1).X = x
        dno(1).Y = y + (h \ 3) * 2
        dno(2).X = x + h
        dno(2).Y = y + (h \ 3) * 2
        dno(3).X = x + (h \ 4) * 3
        dno(3).Y = y + h
        g.FillPolygon(kist, dno)
        x1 = x + h \ 4 : y1 = y
        g.FillPie(Brushes.Red, x1, y1, h \ 2, (h \ 3) * 2, 90, 180)
    End Sub
End Module
