Public Class Form1
    Dim fn As String
    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb1)
    End Sub

    Private Sub УдалениеСтрокToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалениеСтрокToolStripMenuItem.Click

    End Sub

    Private Sub ПАЛИНДРОМЫToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПАЛИНДРОМЫToolStripMenuItem.Click

    End Sub

    Private Sub МаксПредлToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МаксПредлToolStripMenuItem.Click

    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        End
    End Sub
End Class
