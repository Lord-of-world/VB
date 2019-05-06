Module Module1
    Dim g As Graphics
    Public Sub Бабочка(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer, ByVal pb As PictureBox)
        Dim k1 As New SolidBrush(Color.Yellow)
        Dim k2 As New SolidBrush(Color.Olive)
        Dim fly(3) As PointF
        g = pb.CreateGraphics
        fly(0).X = x + 5
        fly(1).X = x + h - 5
        fly(2).X = x + h - 5
        fly(3).X = x + 5
        fly(0).Y = y + 5
        fly(1).Y = y + h - 5
        fly(2).Y = y + 5
        fly(3).Y = y + h - 5
        g.FillPolygon(k1, fly)
        g.FillEllipse(k2, x + h \ 2 - h \ 20, y + 10, h \ 10, h - 20)
    End Sub
End Module
