Module Module1
    Public g As Graphics

    Public Sub ship(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer)
        Dim k1 As New SolidBrush(Color.Cyan)
        Dim k2 As New SolidBrush(Color.Coral)
        Dim p As New Pen(Color.Black)
        Dim dno(3) As PointF
        Dim parus(2) As PointF
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
        parus(0).X = x + h / 2
        parus(0).Y = y + 4 * h / 6
        parus(1).X = x + 2 * h / 3
        parus(1).Y = y + 5 * h / 12
        parus(2).X = x + h / 2
        parus(2).Y = y + h / 6
        g.FillPolygon(k2, parus)
        g.DrawPolygon(p, parus)
    End Sub
End Module
