Module Module1
    Dim g As Graphics
    Public Sub sun(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer, ByVal pb As PictureBox)
        Dim k As New SolidBrush(Color.Yellow)
        Dim p As New Pen(Color.Orange, 2)
        g = pb.CreateGraphics
        g.FillEllipse(k, x, y, h, h)
        g.DrawEllipse(p, x, y, h, h)
    End Sub
End Module
