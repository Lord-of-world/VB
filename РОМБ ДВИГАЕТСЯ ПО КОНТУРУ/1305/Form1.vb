Public Class Form1
    Dim g As Graphics, n, i As Integer
    Dim T() As PointF = {New PointF(0, 40), New PointF(40, 0), New PointF(80, 40), New PointF(40, 80)}

    Private Sub РомбикToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РомбикToolStripMenuItem.Click
        g = PB.CreateGraphics
        n = UBound(T)
        Ромб()
        Timer1.Enabled = True
    End Sub

    Private Sub ОчиститьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОчиститьToolStripMenuItem.Click
        PB.Refresh()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub
    Private Sub Ромб()
        Dim k As New SolidBrush(Color.BlueViolet)
        Dim p As New Pen(Color.Black, 2)
        g.FillPolygon(k, T)
        g.DrawPolygon(p, T)
    End Sub

    Private Sub Движение1()
        For i = 0 To n
            T(i).X = T(i).X + 5
        Next
    End Sub

    Private Sub Движение2()
        For i = 0 To n
            T(i).Y = T(i).Y + 5
        Next
    End Sub

    Private Sub Движение3()
        For i = 0 To n
            T(i).X = T(i).X - 5
        Next
    End Sub

    Private Sub Движение4()
        For i = 0 To n
            T(i).Y = T(i).Y - 5
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PB.Refresh()
        Движение1()
        Ромб()
        If T(2).X > PB.Width - 10 Then Timer1.Enabled = False : Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PB.Refresh()
        Движение2()
        Ромб()
        If T(3).Y > PB.Height - 10 Then Timer2.Enabled = False : Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PB.Refresh()
        Движение3()
        Ромб()
        If T(0).X = 0 Then Timer3.Enabled = False : Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PB.Refresh()
        Движение4()
        Ромб()
        If T(1).Y = 0 Then Timer4.Enabled = False : Timer1.Enabled = True
    End Sub
End Class
