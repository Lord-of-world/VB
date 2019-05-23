Public Class Form1
    Dim g As Graphics
    Dim x, y, i, j, n, h As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Refresh()
        Do
            n = Val(InputBox("Введите количество бабочек в массиве"))
        Loop Until n > 0
        h = Me.ClientSize.Height \ n
        y = 0
        For i = 1 To n
            x = 0
            For j = 1 To n
                If i >= j Then Бабочка()
                x = x + h
            Next
            y = y + h
        Next
    End Sub
    Public Sub Бабочка()
        Dim k As New SolidBrush(Color.Black)
        Dim p As New Pen(Color.Black, 2)
        g = Me.CreateGraphics
        g.FillEllipse(k, x + h \ 3, y + h \ 3, h \ 3, 2 * h \ 3)
        g.FillPie(k, x - h \ 3 + 2, y + h \ 3, 2 * h \ 3 - 2, 2 * h \ 3, 270, 180)
        g.FillPie(k, x + 2 * h \ 3, y + h \ 3, 2 * h \ 3 - 2, 2 * h \ 3, 90, 180)
        g.DrawLine(p, x + h \ 3, y, x + h \ 2, y + h \ 3)
        g.DrawLine(p, x + 2 * h \ 3, y, x + h \ 2, y + h \ 3)
    End Sub
End Class
