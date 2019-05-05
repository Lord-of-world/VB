Public Class Form1
    Dim g As Graphics
    Dim x, xc, y, yc, h, n, i, j, grad, rad, r As Single
    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub
    Private Sub ОчиститьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОчиститьToolStripMenuItem.Click
        pb.Image = Nothing
    End Sub
    Public Sub СолнышкоToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles СолнышкоToolStripMenuItem1.Click
        h = pb.ClientSize.Height
        x = 0 : y = 0
        sun(x, y, h, pb)
    End Sub
    Private Sub МассивСолнышекToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МассивСолнышекToolStripMenuItem.Click
        n = Val(InputBox("Введите количество строк"))
        y = 0
        h = pb.ClientSize.Height \ n
        For i = 1 To n
            x = 0
            For j = 1 To n
                sun(x, y, h - 5, pb)
                x = x + h
            Next
            y = y + h
        Next
    End Sub
    Private Sub СпиральСолнышекToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КругСолнышекToolStripMenuItem.Click
        n = Val(InputBox("Введите количество Солнышек"))
        x = 0 : y = 0
        grad = 2 * Math.PI / n
        xc = pb.ClientSize.Width \ 2
        yc = pb.ClientSize.Height \ 2
        r = 1
        h = pb.ClientSize.Height \ 8
        rad = 0
        For i = 1 To 3 * n
            x = xc + r * Math.Cos(rad)
            y = yc + r * Math.Sin(rad)
            r = r + 50 / n
            sun(x, y, h, pb)
            rad = rad + grad
        Next
    End Sub

    Private Sub КорабликToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles КорабликToolStripMenuItem1.Click

    End Sub

    Private Sub МассивКорабликовToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МассивКорабликовToolStripMenuItem.Click

    End Sub

    Private Sub СпиральКорабликовToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КругКорабликовToolStripMenuItem.Click

    End Sub

    Private Sub ДомикToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ДомикToolStripMenuItem1.Click

    End Sub

    Private Sub МассивДомиковToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МассивДомиковToolStripMenuItem.Click

    End Sub

    Private Sub СпиральДомиковToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КругДомиковToolStripMenuItem.Click

    End Sub
End Class
