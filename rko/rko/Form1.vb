Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stud(), stud2() As student
        Dim n, k As Integer
        Dim grup As String
        Form2.Show()
        input(n, stud)
        Output(n, stud, Lb1)
        tb1.Text = Str(kolotl(n, stud))
        sort(n, stud)
        Output(n, stud, lb2)
        grup = InputBox("Введите искомую группу")
        group(n, stud, grup, k, stud2)
        Output(k, stud2, Form2.lb3)
    End Sub
End Class
