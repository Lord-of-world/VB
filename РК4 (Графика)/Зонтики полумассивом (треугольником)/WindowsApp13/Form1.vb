Public Class Form1
    Dim g As Graphics
    Dim x, y, i, j, n, h As Single
    Private Sub МассивЗонтиковToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МассивЗонтиковToolStripMenuItem.Click
        PB.Refresh()
        Do
            n = Val(InputBox("Введите количество зонтиков в массиве"))
        Loop Until n > 0
        h = PB.ClientSize.Height \ n
        y = 0
        For i = 1 To n
            x = 0
            For j = 1 To n
                If i >= j Then Зонтик()
                x = x + h
            Next
            y = y + h
        Next
    End Sub

    Private Sub ОчиститьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВвввввввввввввваааааааааToolStripMenuItem.Click
        PB.Refresh()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub
    Public Sub Зонтик()
        Dim k As New SolidBrush(Color.Yellow)
        Dim p As New Pen(Color.Orange, 2)
        Dim p1 As New Pen(Color.Green, 3)
        g = PB.CreateGraphics
        g.FillPie(k, x, y, h - 10, h, 180, 180)
        g.DrawPie(p, x, y, h - 10, h, 180, 180)
        g.DrawLine(p1, x + (h - 10) \ 2, y + h \ 2, x + (h - 10) \ 2, y + h - h \ 5)
        g.DrawArc(p1, x + (h - 10) \ 2 - h \ 5, y + h - h \ 5 - h \ 9, h \ 5, h \ 5, 0, 180)
    End Sub
End Class
