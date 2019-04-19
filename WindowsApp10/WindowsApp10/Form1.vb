Public Class Form1
    Dim fn As String
    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        fn = OpenFileDialog1.FileName
        Печать(fn, lb1)
    End Sub
End Class
