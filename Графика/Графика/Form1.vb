Public Class Form1
    Dim g As Graphics
    Dim x, x1, xc, y, y1, yc, h, hf, n, k, i, j, grad, rad, r, komp, sd, km As Single

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + sd
        komp = komp + (hf * km - hf)
        y = h / 4 + (h / 4 - komp) * Math.Sin(x * Math.PI / 180)
        y = y * km + (1 - km) * y
        hf = hf * km
        PB.Refresh()
        sun(x, y, hf, PB)
        If x > PB.ClientSize.Width - hf - 10 Then Timer1.Enabled = False
    End Sub

    Private Sub СолнышкоToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles СолнышкоToolStripMenuItem1.Click
        PB.Refresh()
        h = PB.ClientSize.Height
        x = 0 : y = 0
        sun(x, y, h, PB)
    End Sub

    Private Sub МассивСолнышекToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МассивСолнышекToolStripMenuItem.Click
        Do
            n = Val(InputBox("Введите количество строк"))
        Loop Until (n > 0) And (n < 101)
        PB.Refresh()
        y = 0
        h = PB.ClientSize.Height \ n
        For i = 1 To n
            x = 0
            For j = 1 To n
                sun(x, y, h - 5, PB)
                x = x + h
            Next
            y = y + h
        Next
    End Sub

    Private Sub СпиральСолнышекToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СпиральСолнышекToolStripMenuItem.Click
        Do
            n = Val(InputBox("Введите количество Солнышек в круге"))
        Loop Until (n > 0) And (n < 1001)
        Do
            k = Val(InputBox("Введите количество кругов"))
        Loop Until (k > 0) And (k < 101)
        PB.Refresh()
        x = 0 : y = 0
        grad = 2 * Math.PI / n
        xc = PB.ClientSize.Width \ 2
        yc = PB.ClientSize.Height \ 2
        r = 1
        h = PB.ClientSize.Height \ 8
        rad = 0
        For i = 1 To k * n
            x = xc + r * Math.Cos(rad)
            y = yc + r * Math.Sin(rad)
            r = r + 50 / n
            sun(x, y, h, PB)
            rad = rad + grad
        Next
    End Sub

    Private Sub КорабликToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles КорабликToolStripMenuItem1.Click
        PB.Refresh()
        h = PB.ClientSize.Height
        x = 0 : y = 0
        ship(x, y, h, PB)
    End Sub

    Private Sub МассивКорабликовToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МассивКорабликовToolStripMenuItem.Click
        Do
            n = Val(InputBox("Введите количество строк"))
        Loop Until (n > 0) And (n < 46)
        PB.Refresh()
        y = 0
        h = PB.ClientSize.Height \ n
        For i = 1 To n
            x = 0
            For j = 1 To n
                ship(x, y, h - 5, PB)
                x = x + h
            Next
            y = y + h
        Next
    End Sub

    Private Sub СпиральКорабликовToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СпиральКорабликовToolStripMenuItem.Click
        Do
            n = Val(InputBox("Введите количество Корабликов в круге"))
        Loop Until (n > 0) And (n < 1001)
        Do
            k = Val(InputBox("Введите количество кругов"))
        Loop Until (k > 0) And (k < 101)
        PB.Refresh()
        x = 0 : y = 0
        grad = 2 * Math.PI / n
        xc = PB.ClientSize.Width \ 2
        yc = PB.ClientSize.Height \ 2
        r = 1
        h = PB.ClientSize.Height \ 8
        rad = 0
        For i = 1 To k * n
            x = xc + r * Math.Cos(rad)
            y = yc + r * Math.Sin(rad)
            r = r + 50 / n
            ship(x, y, h, PB)
            rad = rad + grad
        Next
    End Sub

    Private Sub ДомикToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ДомикToolStripMenuItem1.Click
        PB.Refresh()
        h = PB.ClientSize.Height
        x = 0 : y = 0
        house(x, y, h, PB)
    End Sub

    Private Sub МассивДомиковToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МассивДомиковToolStripMenuItem.Click
        Do
            n = Val(InputBox("Введите количество строк"))
        Loop Until (n > 0) And (n < 46)
        PB.Refresh()
        y = 0
        h = PB.ClientSize.Height \ n
        For i = 1 To n
            x = 0
            For j = 1 To n
                house(x, y, h - 5, PB)
                x = x + h
            Next
            y = y + h
        Next
    End Sub

    Private Sub СпиральДомиковToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СпиральДомиковToolStripMenuItem.Click
        Do
            n = Val(InputBox("Введите количество Корабликов в круге"))
        Loop Until (n > 0) And (n < 1001)
        Do
            k = Val(InputBox("Введите количество кругов"))
        Loop Until (k > 0) And (k < 101)
        PB.Refresh()
        x = 0 : y = 0
        grad = 2 * Math.PI / n
        xc = PB.ClientSize.Width \ 2
        yc = PB.ClientSize.Height \ 2
        r = 1
        h = PB.ClientSize.Height \ 8
        rad = 0
        For i = 1 To k * n
            x = xc + r * Math.Cos(rad)
            y = yc + r * Math.Sin(rad)
            r = r + 50 / n
            house(x, y, h, PB)
            rad = rad + grad
        Next
    End Sub

    Private Sub СолнышкоToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles СолнышкоToolStripMenuItem2.Click
        PB.Refresh()
        xc = 0 : yc = 0
        x = 0 : y = 0
        h = PB.ClientSize.Height
        Do
            sd = Val(InputBox("Введите шаг движения в пикселях",, 4))
        Loop Until sd >= 0
        Do
            km = Val(InputBox("!!! от 0.9 до 1.1 !!!", "Введите коэффицент масштабирования", 1))
        Loop Until (km > 0.89999) And (km < 1.10001)
        hf = h / 2
        Timer1.Enabled = True
    End Sub

    Private Sub КорабликToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles КорабликToolStripMenuItem2.Click

    End Sub

    Private Sub ДомикToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ДомикToolStripMenuItem2.Click

    End Sub

    Private Sub ОчиститьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОчиститьToolStripMenuItem.Click
        PB.Refresh()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub

End Class