Public Class Form1
    Dim fn As String
    Private Sub СоздатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СоздатьToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        fn = SaveFileDialog1.FileName
        Создание(fn)
    End Sub
    Private Sub ПросмотретьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПросмотретьToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb)
    End Sub
    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub
    Private Sub УдалитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Kill(fn)
    End Sub
    Private Sub ПоОчкамToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПоОчкамToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Сортировать_по_очкам(fn)
    End Sub
    Private Sub ПоКомандамToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПоКомандамToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Сортировать_по_командам(fn)
    End Sub
    Private Sub ПоФИОToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПоФИОToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Сортировать_по_ФИО(fn)
    End Sub
    Private Sub ПоToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПоToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Сортировать_по_позиции(fn)
    End Sub

    Private Sub ДобавитьСтудентовToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьСтудентовToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Добавить(fn)
    End Sub

    Private Sub КомандуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КомандуToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Удалить_команду(fn)
    End Sub
End Class
