Public Class Form1
    Dim g As Graphics
    Dim x, y, h, n, i, j As Integer
    Private Sub БабочкаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles БабочкаToolStripMenuItem.Click
        pb.Refresh()
        n = Val(InputBox("Введите количество строк"))
        h = pb.ClientSize.Height \ n
        y = 0
        For i = 1 To n
            x = 0
            For j = 1 To n
                If (i + j) Mod 2 = 0 Then
                    Бабочка(x, y, h, pb)
                End If
                x = x + h
            Next
            y = y + h
        Next
    End Sub

    Private Sub ОчиститьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОчиститьToolStripMenuItem.Click
        pb.Refresh()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub
End Class
