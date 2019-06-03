Public Class Form1
    Dim g As Graphics
    Dim x, x1, y, y1, h, w, n, i As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        g = Me.CreateGraphics
        w = Me.ClientSize.Width
        h = Me.ClientSize.Height / 4
        x = w - h
        y1 = 2 * h
        Do
            n = Val(InputBox("Введите количество ёлок"))
        Loop Until n > 0
        Рисованиеёлок()
        car()
        Timer1.Enabled = True
    End Sub

    Public Sub Рисованиеёлок()
        For i = 1 To n
            tree()
            x = x - h
        Next
    End Sub
    Public Sub tree()
        Dim k1 As New SolidBrush(Color.Green)
        Dim k2 As New SolidBrush(Color.Brown)
        Dim p As New Pen(Color.Black)
        Dim elka(10) As PointF
        elka(0).X = x + 10 * h / 20
        elka(0).Y = y
        elka(1).X = x + 14 * h / 20
        elka(1).Y = y + 4 * h / 20
        elka(2).X = x + 12 * h / 20
        elka(2).Y = y + 4 * h / 20
        elka(3).X = x + 16 * h / 20
        elka(3).Y = y + 11 * h / 20
        elka(4).X = x + 12 * h / 20
        elka(4).Y = y + 11 * h / 20
        elka(5).X = x + 17 * h / 20
        elka(5).Y = y + 16 * h / 20
        elka(6).X = x + 3 * h / 20
        elka(6).Y = y + 16 * h / 20
        elka(7).X = x + 8 * h / 20
        elka(7).Y = y + 11 * h / 20
        elka(8).X = x + 4 * h / 20
        elka(8).Y = y + 11 * h / 20
        elka(9).X = x + 8 * h / 20
        elka(9).Y = y + 4 * h / 20
        elka(10).X = x + 6 * h / 20
        elka(10).Y = y + 4 * h / 20
        g.FillPolygon(k1, elka)
        g.DrawPolygon(p, elka)
        g.FillRectangle(k2, x + 8 * h \ 20, y + 16 * h \ 20, 4 * h \ 20, 4 * h \ 20)
        g.DrawRectangle(p, x + 8 * h \ 20, y + 16 * h \ 20, 4 * h \ 20, 4 * h \ 20)
    End Sub

    Public Sub car()
        Dim k1 As New SolidBrush(Color.Red)
        Dim k2 As New SolidBrush(Color.Gray)
        Dim p As New Pen(Color.Black)
        Dim mashina(7) As PointF
        mashina(0).X = x1
        mashina(0).Y = y1 + 16 * h / 20
        mashina(1).X = x1
        mashina(1).Y = y1 + 12 * h / 20
        mashina(2).X = x1 + 4 * h / 20
        mashina(2).Y = y1 + 12 * h / 20
        mashina(3).X = x1 + 7 * h / 20
        mashina(3).Y = y1 + 8 * h / 20
        mashina(4).X = x1 + 13 * h / 20
        mashina(4).Y = y1 + 8 * h / 20
        mashina(5).X = x1 + 16 * h / 20
        mashina(5).Y = y1 + 12 * h / 20
        mashina(6).X = x1 + 20 * h / 20
        mashina(6).Y = y1 + 12 * h / 20
        mashina(7).X = x1 + 20 * h / 20
        mashina(7).Y = y1 + 16 * h / 20
        g.FillPolygon(k1, mashina)
        g.DrawPolygon(p, mashina)
        g.FillEllipse(k2, x1 + 3 * h \ 20, y1 + 16 * h \ 20, 4 * h \ 20, 4 * h \ 20)
        g.DrawEllipse(p, x1 + 3 * h \ 20, y1 + 16 * h \ 20, 4 * h \ 20, 4 * h \ 20)
        g.FillEllipse(k2, x1 + 13 * h \ 20, y1 + 16 * h \ 20, 4 * h \ 20, 4 * h \ 20)
        g.DrawEllipse(p, x1 + 13 * h \ 20, y1 + 16 * h \ 20, 4 * h \ 20, 4 * h \ 20)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = w - h
        x1 = x1 + 4
        Me.Refresh()
        Рисованиеёлок()
        car()
        If x1 > (w - h) Then Timer1.Enabled = False : Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        x = w - h
        x1 = x1 - 4
        Me.Refresh()
        Рисованиеёлок()
        car()
        If x1 = 0 Then Timer2.Enabled = False : Timer1.Enabled = True
    End Sub
End Class
