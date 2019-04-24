Public Class Form1
    Dim fn As String
    Private Sub ПечатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПечатьToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb1)
    End Sub

    Private Sub НовыйФайлToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НовыйФайлToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb1)
        Новый(fn)
        Печать(fn + "1", lb1)
    End Sub

    Private Sub СуммаЧиселToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СуммаЧиселToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb1)
        lb1.Items.Add(Str(Сумма(fn)))
    End Sub

    Private Sub ДлинноеСловоToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДлинноеСловоToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb1)
        lb1.Items.Add(Слово(fn))
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub

    Private Sub ИдеалToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИдеалToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Идеал(fn)
    End Sub
End Class
