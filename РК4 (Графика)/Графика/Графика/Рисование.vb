Module Рисование
    Dim g As Graphics

    Public Sub sun(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer, ByVal pb As PictureBox)
        Dim k As New SolidBrush(Color.Yellow)
        Dim p As New Pen(Color.Orange, 2)
        g = pb.CreateGraphics
        g.FillEllipse(k, x, y, h, h)
        g.DrawEllipse(p, x, y, h, h)
    End Sub

    Public Sub ship(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer, ByVal pb As PictureBox)
        Dim k1 As New SolidBrush(Color.Cyan)
        Dim k2 As New SolidBrush(Color.Coral)
        Dim p As New Pen(Color.Black)
        Dim dno(3) As PointF
        g = pb.CreateGraphics
        dno(0).X = x + h / 3
        dno(0).Y = y + 5 * h / 6
        dno(1).X = x + 2 * h / 3
        dno(1).Y = y + 5 * h / 6
        dno(2).X = x + 5 * h / 6
        dno(2).Y = y + 4 * h / 6
        dno(3).X = x + h / 6
        dno(3).Y = y + 4 * h / 6
        g.FillPolygon(k1, dno)
        g.DrawPolygon(p, dno)
        g.FillPie(k2, x + h \ 3, y + h \ 6, h \ 3, h \ 2, 270, 180)
        g.DrawPie(p, x + h \ 3, y + h \ 6, h \ 3, h \ 2, 270, 180)
    End Sub

    Public Sub house(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer, ByVal pb As PictureBox)
        Dim p As New Pen(Color.Black)
        Dim k1 As New SolidBrush(Color.DarkGoldenrod)
        Dim k2 As New SolidBrush(Color.Coral)
        Dim dom(3), door(3), winda(3), roof(2) As PointF
        g = pb.CreateGraphics
        dom(0).X = x + h / 10
        dom(0).Y = y + 2 * h / 5
        dom(1).X = x + h / 10
        dom(1).Y = y + 9 * h / 10
        dom(2).X = x + 9 * h / 10
        dom(2).Y = y + 9 * h / 10
        dom(3).X = x + 9 * h / 10
        dom(3).Y = y + 2 * h / 5

        roof(0).X = x + h / 10
        roof(0).Y = y + 2 * h / 5
        roof(1).X = x + h / 2
        roof(1).Y = y + h / 10
        roof(2).X = x + 9 * h / 10
        roof(2).Y = y + 2 * h / 5

        door(0).X = x + h / 5
        door(0).Y = y + 9 * h / 10
        door(1).X = x + h / 5
        door(1).Y = y + h / 2
        door(2).X = x + 2 * h / 5
        door(2).Y = y + h / 2
        door(3).X = x + 2 * h / 5
        door(3).Y = y + 9 * h / 10

        winda(0).X = x + 3 * h / 5
        winda(0).Y = y + h / 2
        winda(1).X = x + 4 * h / 5
        winda(1).Y = y + h / 2
        winda(2).X = x + 4 * h / 5
        winda(2).Y = y + 7 * h / 10
        winda(3).X = x + 3 * h / 5
        winda(3).Y = y + 7 * h / 10

        g.FillPolygon(k2, dom)
        g.DrawPolygon(p, dom)

        g.FillPolygon(k1, roof)
        g.DrawPolygon(p, roof)

        g.FillPolygon(k1, door)
        g.DrawPolygon(p, door)

        g.FillPolygon(k1, winda)
        g.DrawPolygon(p, winda)
        g.DrawLine(p, x + 3 * h \ 5, y + 3 * h \ 5, x + 4 * h \ 5, y + 3 * h \ 5)
        g.DrawLine(p, x + 7 * h \ 10, y + h \ 2, x + 7 * h \ 10, y + 7 * h \ 10)

        g.FillEllipse(k2, x + 6.5 * h \ 30, y + 21 * h \ 30, h \ 30, h \ 30)
        g.DrawEllipse(p, x + 6.5 * h \ 30, y + 21 * h \ 30, h \ 30, h \ 30)
    End Sub
End Module
