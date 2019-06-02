Public Class Form1
    Dim g As Graphics
    Dim x, y, h, i, n As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do
            n = Val(InputBox("Введите количество корабликов"))
        Loop Until (n > 0)
        Me.Refresh()
        y = 0
        h = Me.ClientSize.Height \ n
        For i = 1 To n
            x = 0
            For j = 1 To n
                If (i = 1) Or (i = n) Or (j = 1) Or (j = n) Then Ship()
                x = x + h
            Next
            y = y + h
        Next
    End Sub
    Public Sub Ship()
        Dim k1 As New SolidBrush(Color.Cyan)
        Dim k2 As New SolidBrush(Color.Coral)
        Dim p As New Pen(Color.Black)
        Dim dno(3) As PointF
        g = Me.CreateGraphics
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
        g.FillPie(k2, x + h \ 3, y + h \ 6, h \ 3, h \ 2, 90, 180)
        g.DrawPie(p, x + h \ 3, y + h \ 6, h \ 3, h \ 2, 90, 180)
    End Sub

End Class
