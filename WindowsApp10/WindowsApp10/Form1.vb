Public Class Form1
    Dim fn As String
    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb1)
    End Sub

    Private Sub ИдеальныйФайлToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИдеальныйФайлToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb1)
        ИдеальныйФайл(fn)
        Печать(fn, lb2)
    End Sub

    Private Sub МаксПредлToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МаксПредлToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        МаксПредл(fn, tb)
    End Sub

    Private Sub ПАЛИНДРОМЫToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПАЛИНДРОМЫToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb1)
        Палиндромы(fn)
        Печать(fn, lb2)
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        end
    End Sub


End Class
