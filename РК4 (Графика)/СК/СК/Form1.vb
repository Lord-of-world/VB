Public Class Form1
    Dim g As Graphics
    Dim x, y, h, i, j As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        g = Me.CreateGraphics
        h = Me.ClientSize.Height / 10
        Me.Refresh()
        For i = 1 To 10
            x = 0
            For j = 1 To 10
                Гриб()
                x = x + h
            Next
            y = y + h
        Next
    End Sub

    Public Sub Гриб()
        Dim k1 As New SolidBrush(Color.Brown)
        Dim k2 As New SolidBrush(Color.Bisque)
        Dim p As New Pen(Color.Black)
        g.FillEllipse(k1, x + h \ 3, y + h \ 3, h \ 3, 2 * h \ 3 - 5)
        g.DrawEllipse(p, x + h \ 3, y + h \ 3, h \ 3, 2 * h \ 3 - 5)
        g.FillPie(k2, x + 2, y, h - 4, h, 180, 180)
        g.DrawPie(p, x + 2, y, h - 4, h, 180, 180)
    End Sub
End Class
