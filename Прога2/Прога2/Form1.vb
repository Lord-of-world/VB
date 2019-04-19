Public Class Form1
    Private Sub vvod(ByRef n As Integer,
                     ByRef a(,) As Integer)
        Dim i, j As Integer
        Do
            n = Val(InputBox("Введите N"))
        Loop Until n > 0

        ReDim a(n - 1, n - 1)
        For i = 0 To n - 1
            For j = 0 To n - 1
                a(i, j) = Val(InputBox("Вводите числа"))
            Next
        Next
    End Sub
    Private Sub vivod(ByVal n As Integer,
                      ByVal a(,) As Integer,
                      ByRef lb As ListBox)
        Dim i, j As Integer, s As String
        lb.Items.Clear()
        For i = 0 To n - 1
            s = ""
            For j = 0 To n - 1
                s = s + Str(a(i, j)) + vbTab
            Next
            lb.Items.Add(s)
        Next
    End Sub
    Private Sub max(ByVal n As Integer, ByRef a(,) As Integer)
        Dim i, j, max As Integer
        For i = 0 To n - 1
            max = a(i, 0)
            For j = 1 To n - 1
                If max < a(i, j) Then max = a(i, j)
            Next
            a(i, i) = a(i, i) * max
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, a(,) As Integer
        vvod(n, a)
        vivod(n, a, ListBox1)
        max(n, a)
        vivod(n, a, listbox2)
    End Sub
End Class
