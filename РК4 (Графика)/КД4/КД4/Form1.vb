Public Class Form1
    Dim g As Graphics, i As Integer
    Dim T() As PointF = {New PointF(0, 20),
        New PointF(20, 0),
        New PointF(40, 0),
        New PointF(60, 20),
        New PointF(60, 40),
        New PointF(40, 60),
        New PointF(20, 60),
        New PointF(0, 40)}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        g = Me.CreateGraphics
        Восьмиугольник()
        Timer1.Enabled = True
    End Sub

    Private Sub Восьмиугольник()
        Dim p As New Pen(Color.Black)
        g.DrawPolygon(p, T)
    End Sub

    Private Sub Движение1()
        For i = 0 To 7
            T(i).X = T(i).X + 5
        Next
    End Sub

    Private Sub Движение2()
        For i = 0 To 7
            T(i).Y = T(i).Y + 5
        Next
    End Sub

    Private Sub Движение3()
        For i = 0 To 7
            T(i).X = T(i).X - 5
        Next
    End Sub

    Private Sub Движение4()
        For i = 0 To 7
            T(i).Y = T(i).Y - 5
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Refresh()
        Движение1()
        Восьмиугольник()
        If T(3).X > Me.Width - 20 Then Timer1.Enabled = False : Timer2.Enabled = True

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Refresh()
        Движение2()
        Восьмиугольник()
        If T(5).Y > Me.Height - 45 Then Timer2.Enabled = False : Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Refresh()
        Движение3()
        Восьмиугольник()
        If T(0).X = 0 Then Timer3.Enabled = False : Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Me.Refresh()
        Движение4()
        Восьмиугольник()
        If T(1).Y = 0 Then Timer4.Enabled = False : Timer1.Enabled = True
    End Sub
End Class
