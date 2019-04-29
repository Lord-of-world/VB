Module Module1
    Public Sub sun(ByVal x As Integer, ByVal y As Integer, ByVal h As Integer)
        Dim x1, y1 As Integer
        Dim g As Graphics
        g = Form1.CreateGraphics
        Dim pero As New Pen(Color.Black)
        g.DrawEllipse(pero, x + 10, y + 10, h - (h \ 4), h - (h \ 4))
        g.FillEllipse(Brushes.Yellow, x + 10, y + 10, h - (h \ 4) - 1, h - (h \ 4) - 1)
    End Sub
End Module
