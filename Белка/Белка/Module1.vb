Module Module1
    Public g As Graphics
    Public x1, y1, w, h As Single
    Dim bel() As PointF = {
        New PointF(x1 + 3 * h \ 30, y1 + 9 * h \ 10), New PointF(x1 + 2 * w, y1 + 9 * h \ 10),
    New PointF(), New PointF()}
    'New PointF(), New PointF(),
    'New PointF(), New PointF(),
    'New PointF(), New PointF(),
    'New PointF(), New PointF(),
    'New PointF(), New PointF(),
    'New PointF(), New PointF(),
    'New PointF(), New PointF(),
    'New PointF(), New PointF()}
    Public Sub Белка(ByVal h As Single)
        g.FillPolygon(Brushes.Red, bel)
    End Sub
End Module
