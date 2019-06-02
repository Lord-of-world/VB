Module Module1
    Public g As Graphics
    Public w, h, x, y, x1, y1, x2, y2, i, n As Integer
    Public f, z, x3, y3, xc, yc, k, xc1, yc1 As Single

    Public Sub background(ByVal w As Integer, ByVal h As Integer)
        Dim pero As New Pen(Color.Orange)
        g.FillRectangle(Brushes.Blue, 0, 0, w, h)
        g.FillRectangle(Brushes.Green, 0, 2 * h \ 3, w, h \ 3)
        g.DrawLine(pero, 4 * h \ 20, 0, 4 * h \ 20, 8 * h \ 20)
        g.DrawLine(pero, h \ 20, h \ 20, 7 * h \ 20, 7 * h \ 20)
        g.DrawLine(pero, 7 * h \ 20, h \ 20, h \ 20, 7 * h \ 20)
        g.DrawLine(pero, 0, 4 * h \ 20, 8 * h \ 20, 4 * h \ 20)
        g.FillEllipse(Brushes.Gold, 2 * h \ 20, 2 * h \ 20, 4 * h \ 20, 4 * h \ 20)
        g.DrawEllipse(pero, 2 * h \ 20, 2 * h \ 20, 4 * h \ 20, 4 * h \ 20)
        g.FillRectangle(Brushes.Brown, 13 * w \ 20, 9 * h \ 20, 2 * w \ 20, 10 * h \ 20)
        g.FillEllipse(Brushes.Green, 10 * w \ 20, 8 * h \ 20, 4 * w \ 20, 4 * h \ 20)
        g.FillEllipse(Brushes.Green, 14 * w \ 20, 8 * h \ 20, 4 * w \ 20, 4 * h \ 20)
        g.FillEllipse(Brushes.Green, 11 * w \ 20, 5 * h \ 20, 6 * w \ 20, 6 * h \ 20)
        g.FillEllipse(Brushes.Black, 13.25 * w \ 20, 14 * h \ 20, 1.5 * w \ 20, 2.5 * h \ 20)
    End Sub

    Public Sub squirell1()
        Dim bel(19) As PointF
        bel(0).X = x1 + 13 * h / 180
        bel(0).Y = y1 + 20 * h / 180
        bel(1).X = x1 + 8 * h / 180
        bel(1).Y = y1 + 20 * h / 180
        bel(2).X = x1 + 5 * h / 180
        bel(2).Y = y1 + 17 * h / 180
        bel(3).X = x1 + 4 * h / 180
        bel(3).Y = y1 + 12 * h / 180
        bel(4).X = x1 + 1 * h / 180
        bel(4).Y = y1 + 13 * h / 180
        bel(5).X = x1 + 0 * h / 180
        bel(5).Y = y1 + 10 * h / 180
        bel(6).X = x1 + 1 * h / 180
        bel(6).Y = y1 + 8 * h / 180
        bel(7).X = x1 + 5 * h / 180
        bel(7).Y = y1 + 8 * h / 180
        bel(8).X = x1 + 9 * h / 180
        bel(8).Y = y1 + 12 * h / 180
        bel(9).X = x1 + 8 * h / 180
        bel(9).Y = y1 + 15 * h / 180
        bel(10).X = x1 + 10 * h / 180
        bel(10).Y = y1 + 15 * h / 180
        bel(11).X = x1 + 11 * h / 180
        bel(11).Y = y1 + 13 * h / 180
        bel(12).X = x1 + 10 * h / 180
        bel(12).Y = y1 + 8 * h / 180
        bel(13).X = x1 + 11 * h / 180
        bel(13).Y = y1 + 6 * h / 180
        bel(14).X = x1 + 12 * h / 180
        bel(14).Y = y1 + 8 * h / 180
        bel(15).X = x1 + 15 * h / 180
        bel(15).Y = y1 + 8 * h / 180
        bel(16).X = x1 + 17 * h / 180
        bel(16).Y = y1 + 10 * h / 180
        bel(17).X = x1 + 14 * h / 180
        bel(17).Y = y1 + 15 * h / 180
        bel(18).X = x1 + 17 * h / 180
        bel(18).Y = y1 + 15 * h / 180
        bel(19).X = x1 + 12 * h / 180
        bel(19).Y = y1 + 18 * h / 180
        g.FillPolygon(Brushes.OrangeRed, bel)
    End Sub

    Public Sub squirell2(ByRef belka() As PointF)
        ReDim belka(19)
        belka(0).X = x2 + 7 * h / 300
        belka(0).Y = y2 + 20 * h / 300
        belka(1).X = x2 + 12 * h / 300
        belka(1).Y = y2 + 20 * h / 300
        belka(2).X = x2 + 15 * h / 300
        belka(2).Y = y2 + 17 * h / 300
        belka(3).X = x2 + 16 * h / 300
        belka(3).Y = y2 + 12 * h / 300
        belka(4).X = x2 + 19 * h / 300
        belka(4).Y = y2 + 13 * h / 300
        belka(5).X = x2 + 20 * h / 300
        belka(5).Y = y2 + 10 * h / 300
        belka(6).X = x2 + 19 * h / 300
        belka(6).Y = y2 + 8 * h / 300
        belka(7).X = x2 + 15 * h / 300
        belka(7).Y = y2 + 8 * h / 300
        belka(8).X = x2 + 11 * h / 300
        belka(8).Y = y2 + 12 * h / 300
        belka(9).X = x2 + 12 * h / 300
        belka(9).Y = y2 + 15 * h / 300
        belka(10).X = x2 + 10 * h / 300
        belka(10).Y = y2 + 15 * h / 300
        belka(11).X = x2 + 9 * h / 300
        belka(11).Y = y2 + 13 * h / 300
        belka(12).X = x2 + 10 * h / 300
        belka(12).Y = y2 + 8 * h / 300
        belka(13).X = x2 + 9 * h / 300
        belka(13).Y = y2 + 6 * h / 300
        belka(14).X = x2 + 8 * h / 300
        belka(14).Y = y2 + 8 * h / 300
        belka(15).X = x2 + 5 * h / 300
        belka(15).Y = y2 + 8 * h / 300
        belka(16).X = x2 + 3 * h / 300
        belka(16).Y = y2 + 10 * h / 300
        belka(17).X = x2 + 6 * h / 300
        belka(17).Y = y2 + 15 * h / 300
        belka(18).X = x2 + 3 * h / 300
        belka(18).Y = y2 + 15 * h / 300
        belka(19).X = x2 + 8 * h / 300
        belka(19).Y = y2 + 18 * h / 300
    End Sub

    Public Sub Вторая_белка(ByVal bel() As PointF)
        g.FillPolygon(Brushes.OrangeRed, bel)
    End Sub

    Public Sub Движение1(ByRef x1 As Integer, ByRef y1 As Integer)
        x1 = x1 + 4
    End Sub

    Public Sub Движение2(ByRef x1 As Integer, ByRef y1 As Integer)
        y1 = y1 - 4
    End Sub

    Public Sub Масштабирование(ByRef bel() As PointF)
        k = 1.01
        n = n + 1
        For i = 0 To UBound(bel)
            bel(i).X = bel(i).X * k + xc1 * (1 - k)
            bel(i).Y = bel(i).Y * k + yc1 * (1 - k)
        Next
    End Sub

    Public Sub Сердце(ByRef heart() As PointF)
        ReDim Preserve heart(9)
        heart(0).X = x3 + 7 * h / 40
        heart(0).Y = y3 + 13 * h / 40
        heart(1).X = x3 + 13 * h / 40
        heart(1).Y = y3 + 7 * h / 40
        heart(2).X = x3 + 13 * h / 40
        heart(2).Y = y3 + 3 * h / 40
        heart(3).X = x3 + 11 * h / 40
        heart(3).Y = y3 + 1 * h / 40
        heart(4).X = x3 + 9 * h / 40
        heart(4).Y = y3 + 1 * h / 40
        heart(5).X = x3 + 7 * h / 40
        heart(5).Y = y3 + 3 * h / 40
        heart(6).X = x3 + 5 * h / 40
        heart(6).Y = y3 + 1 * h / 40
        heart(7).X = x3 + 3 * h / 40
        heart(7).Y = y3 + 1 * h / 40
        heart(8).X = x3 + 1 * h / 40
        heart(8).Y = y3 + 3 * h / 40
        heart(9).X = x3 + 1 * h / 40
        heart(9).Y = y3 + 7 * h / 40
        g.FillPolygon(Brushes.Red, heart)
    End Sub

    Public Sub Рисование_сердца(ByVal serd() As PointF)
        g.FillPolygon(Brushes.Red, serd)
    End Sub

    Public Sub Вращение(ByRef serd() As PointF)
        f = -0.2
        For i = 0 To UBound(serd)
            z = serd(i).X
            serd(i).X = xc + (serd(i).X - xc) * Math.Cos(f) + (serd(i).Y - yc) * Math.Sin(f)
            serd(i).Y = yc + (serd(i).Y - yc) * Math.Cos(f) - (z - xc) * Math.Sin(f)
        Next
    End Sub
End Module
