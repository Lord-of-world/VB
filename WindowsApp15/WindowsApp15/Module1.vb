Module Module1
    Public g As Graphics

    Public Sub juk(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer)
        Dim k1 As New SolidBrush(Color.Red)
        Dim p As New Pen(Color.Black)
        g.FillEllipse(k1, x + h \ 12, y + h \ 3, h \ 5, h)
        g.DrawEllipse(p, x + h \ 12, y + h \ 3, h \ 5, h)
        g.DrawLine(p, x + 17 * h \ 90, y + h \ 3, x + 17 * h \ 60, y)
        g.DrawLine(p, x + 17 * h \ 95, y + h \ 3, x + h \ 12, y)
    End Sub
End Module
