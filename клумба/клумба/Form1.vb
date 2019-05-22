Public Class Form1
    Dim g As Graphics
    Dim x, xc, y, yc, i, n, grad, r, h, rad As Single

    Private Sub КлумбаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КлумбаToolStripMenuItem.Click
        PB.Refresh()
        Do
            n = Val(InputBox("Введите количество цветков в клумбе"))
        Loop Until n > 0
        x = 0 : y = 0
        grad = 2 * Math.PI / n
        xc = PB.ClientSize.Width \ 2
        yc = PB.ClientSize.Height \ 2
        h = PB.ClientSize.Height \ 8
        rad = 0
        r = PB.ClientSize.Height \ 3
        For i = 1 To n
            x = xc + r * Math.Cos(rad)
            y = yc + r * Math.Sin(rad)
            Цветок()
            rad = rad + grad
        Next
    End Sub

    Private Sub ОчиститьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОчиститьToolStripMenuItem.Click
        PB.Refresh()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub

    Public Sub Цветок()
        Dim k As New SolidBrush(Color.Yellow)
        Dim p As New Pen(Color.Orange, 1)
        Dim p1 As New Pen(Color.Green, 1)
        g = PB.CreateGraphics
        g.DrawLine(p1, x, y + h \ 2, x, y + 100)
        g.FillEllipse(k, x - h, y - h, h, h)
        g.DrawEllipse(p, x - h, y - h, h, h)
        g.FillEllipse(k, x, y - h, h, h)
        g.DrawEllipse(p, x, y - h, h, h)
        g.FillEllipse(k, x, y, h, h)
        g.DrawEllipse(p, x, y, h, h)
        g.FillEllipse(k, x - h, y, h, h)
        g.DrawEllipse(p, x - h, y, h, h)
        g.DrawLine(p1, x, y + h \ 2, x, y + 100)
    End Sub
End Class
