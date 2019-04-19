Public Class Form1
    Dim fn As String
    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub

    Private Sub СоздатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СоздатьToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        fn = SaveFileDialog1.FileName
        Создание(fn)
        Печать(fn, ListBox1)
    End Sub

    Private Sub РаспечататьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РаспечататьToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, ListBox1)
    End Sub

    Private Sub ОбщийВесToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЧтотоЕщёToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        TextBox1.Text = Str(ОбщийВес(fn))
    End Sub

    Private Sub СортировкаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИЕщёToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Сортировка(fn)
        Печать(fn, ListBox2)
    End Sub

    Private Sub НовыйФайл4МестаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НовыйФайл4МестаToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName

    End Sub
End Class
