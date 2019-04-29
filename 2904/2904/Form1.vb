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
                lodka(x, y, h)
                x = x + h
            Next
            y = y + h
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x, y, h, n, i, r, xc, yc As Single
        Dim ug, dug As Single
        Dim g As Graphics
        g = Me.CreateGraphics
        Dim kist As New SolidBrush(Me.BackColor)
        g.FillRectangle(kist, 0, 0, Me.ClientSize.Width, Me.ClientSize.Height)
        n = Val(InputBox("Введите количество фигур"))
        dug = 2 * Math.PI / n
        ug = 0
        xc = Me.ClientSize.Width \ 2
        yc = Me.ClientSize.Height \ 2
        r = Me.ClientSize.Width \ 4
        h = Me.ClientSize.Height \ 8
        For i = 1 To n
            x = xc + r * Math.Cos(ug)
            y = yc + r * Math.Sin(ug)
            lodka(x, y, h)
            ug = ug + dug
        Next
    End Sub
End Class
