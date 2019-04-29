Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, h, i, j, n As Integer
        Dim g As Graphics = Me.CreateGraphics
        Dim kist As New SolidBrush(Me.BackColor)
        g.FillRectangle(kist, 0, 0, Me.ClientSize.Width, Me.ClientSize.Height)
        n = Val(InputBox("Введите количество рядов"))
        h = Me.ClientSize.Height \ n
        y = 0
        For i = 1 To n
            x = 0
            For j = 1 To n
                sun(x, y, h)
                x = x + h
            Next
            y = y + h
        Next
    End Sub
End Class
