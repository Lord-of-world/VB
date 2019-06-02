Public Class Form1
    Dim serd() As PointF, bel() As PointF

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        g = Me.CreateGraphics
        h = Me.ClientSize.Height
        w = Me.ClientSize.Width
        background(w, h)
        squirell1()
        x2 = 13.6 * w / 20
        y2 = 14.55 * h / 20
        x3 = 2.5 * w / 10
        y3 = 2 * h / 10
        xc = 2.5 * w / 10 + 7 * h / 40
        yc = 2 * h / 10 + 7 * h / 40
        xc1 = 14 * w / 20
        yc1 = 15.25 * h / 20
        Сердце(serd)
        squirell2(bel)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        y1 = 65 * h / 80
        Движение1(x1, y1)
        Me.Refresh()
        background(w, h)
        squirell1()
        If x1 > 12.4 * w / 20 Then Timer1.Enabled = False : Timer2.Enabled = True
        End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Движение2(x1, y1)
        Me.Refresh()
        background(w, h)
        squirell1()
        If y1 < 14.3 * h / 20 Then Timer2.Enabled = False : Timer3.Enabled = True
        End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Масштабирование(bel)
        Me.Refresh()
        background(w, h)
        squirell1()
        Вторая_белка(bel)
        If n > 50 Then Timer3.Enabled = False : Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Вращение(serd)
        Me.Refresh()
        background(w, h)
        squirell1()
        Вторая_белка(bel)
        Рисование_сердца(serd)
    End Sub
End Class
