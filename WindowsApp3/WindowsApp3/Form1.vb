
Public Class Form1
    Function induk(ByVal n As Integer, ByVal a() As Integer) As Boolean
        Dim i As Integer
        induk = True
        For i = 0 To n - 1
            Do While a(i) > a(i + 1)
                induk = False
                Exit Function
            Loop
        Next
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(), n, i As Integer
        Do
            n = Val(InputBox(""))
        Loop Until n > 0
        ReDim a(n - 1)
        For i = 0 To n - 1
            a(i) = Val(InputBox(""))
        Next
    End Sub
End Class
