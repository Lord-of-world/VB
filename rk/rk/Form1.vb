Imports System.Math


Public Class Form1
    Private Sub BtnGO_Click(sender As Object, e As EventArgs) Handles BtnGO.Click
        Dim n, m As Integer
        Dim r As Single
        Dim p(), p2() As Point
        Form2.Show()
        input(n, p)
        Output(n, p, Lb1)
        r = Val(InputBox("Введите радиус"))
        Tb1.Text = Str(Rad(n, p, r))
        otsort(n, p)
        Output(n, p, Lb2)
        Newmas(n, p, m, p2)
        Output(m, p2, Form2.Lb3)

    End Sub
End Class
