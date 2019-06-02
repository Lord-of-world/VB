Public Class Form1
    Dim h, w, x, y As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        g = Me.CreateGraphics
        h = Me.ClientSize.Height
        w = Me.ClientSize.Width
        y = h - 4 * h / 15
        juk(x, y, h / 5)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 4
        y = h - 4 * h / 15 - (h * x) / w
        Me.Refresh()
        juk(x, y, h / 5)
        If y < 10 Then Timer1.Enabled = False
    End Sub
End Class
