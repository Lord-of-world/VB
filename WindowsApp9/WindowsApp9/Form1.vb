Public Class Form1
    Dim fn As String
    Private Sub СозданиеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СозданиеToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        fn = SaveFileDialog1.FileName
        Создание(fn)
    End Sub
    Private Sub ОткрытиеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытиеToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Открытие(fn, ListBox1)
    End Sub
    Private Sub НетСтипендииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НетСтипендииToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        НетСтипендии(fn, ListBox2)
    End Sub
    Private Sub УдалениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалениеToolStripMenuItem.Click
        If fn = "" Then
            OpenFileDialog1.ShowDialog()
            fn = OpenFileDialog1.FileName
        End If
        Dim avgStip As Single = СредняяСтипендия(fn)
        Удаление(fn, avgStip)
        Открытие(fn, ListBox3)
    End Sub
    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub
End Class
