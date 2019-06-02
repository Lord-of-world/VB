Public Class Form1
    Dim T() As PointF = {New PointF(50, 50), New PointF(200, 200), New PointF(50, 200)}
    Dim n As Integer
    Dim g As Graphics

    Private Sub Рисунок()
        Dim p As New Pen(Color.Blue)
        Dim k As New SolidBrush(Color.Fuchsia)
        g.FillPolygon(k, T)
        g.DrawPolygon(p, T)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        g = Me.CreateGraphics
        n = UBound(T)
        Рисунок()
        Timer1.Enabled = True
    End Sub

    Private Sub Вращение()
        Dim i As Integer
        Dim z, f, xc, yc As Single
        f = 0.2
        xc = 75
        yc = 150
        For i = 0 To n
            z = T(i).X
            T(i).X = xc + (T(i).X - xc) * Math.Cos(f) + (T(i).Y - yc) * Math.Sin(f)
            T(i).Y = yc + (T(i).Y - yc) * Math.Cos(f) - (z - xc) * Math.Sin(f)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Refresh()
        Вращение()
        Рисунок()
    End Sub
End Class
