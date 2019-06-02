Public Class Form1
    Dim h, w, x, y As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        g = Me.CreateGraphics
        h = Me.ClientSize.Height / 2
        w = Me.ClientSize.Width
        y = h / 2
        ship(x, y, h)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 4
        Me.Refresh()
        ship(x, y, h)
        If x > (w - h) Then Timer1.Enabled = False : Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        x = x - 4
        Me.Refresh()
        ship(x, y, h)
        If x = 0 Then Timer2.Enabled = False : Timer1.Enabled = True
    End Sub
End Class
