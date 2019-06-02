Public Class Form1
    Dim g As Graphics
    Dim x3, y3, i, h As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        g = Me.CreateGraphics
        h = Me.ClientSize.Height
        Dim heart(10) As PointF
        heart(0).X = x3 + 6 * h / 80
        heart(0).Y = y3 + 12 * h / 80
        heart(1).X = x3 + 12 * h / 80
        heart(1).Y = y3 + 6 * h / 80
        heart(2).X = x3 + 12 * h / 80
        heart(2).Y = y3 + 2 * h / 80
        heart(3).X = x3 + 10 * h / 80
        heart(3).Y = y3 + 1 * h / 80
        heart(4).X = x3 + 8 * h / 80
        heart(4).Y = y3 + 1 * h / 80
        heart(5).X = x3 + 6 * h / 80
        heart(5).Y = y3 + 2 * h / 80
        heart(6).X = x3 + 4 * h / 80
        heart(6).Y = y3 + 1 * h / 80
        heart(7).X = x3 + 2 * h / 80
        heart(7).Y = y3 + 1 * h / 80
        heart(8).X = x3 + 1 * h / 80
        heart(8).Y = y3 + 2 * h / 80
        heart(9).X = x3 + 1 * h / 80
        heart(9).Y = y3 + 6* h / 80

        g.FillPolygon(Brushes.Red, heart)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
