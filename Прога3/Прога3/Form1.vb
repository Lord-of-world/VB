Public Class Form1
    Private Sub vvod(ByRef n As Integer, ByRef t() As String)
        Dim i As Integer
        Do
            n = Val(InputBox("Введите количество строк"))
        Loop Until n > 0
        ReDim t(n - 1)
        For i = 0 To n - 1
            t(i) = InputBox("Строка текста")
        Next
    End Sub
    Private Sub vivod(ByVal n As Integer, ByVal t() As String, ByRef lst As ListBox)
        Dim i As Integer
        lst.Items.Clear()
        For i = 0 To n - 1
            lst.Items.Add(t(i))
        Next
    End Sub
    Private Sub ideal(ByVal n As Integer, ByRef t() As String)
        Dim i As Integer
        For i = 0 To n - 1
            t(i) = Replace(t(i), ".", "")
            t(i) = Trim(t(i))
            Do While InStr(t(i), "  ") <> 0
                t(i) = Replace(t(i), "  ", " ")
            Loop
        Next
    End Sub
    Private Function kol(ByVal s As String) As Integer
        Dim masslov() As String
        masslov = Split(s)
        Return UBound(masslov)
    End Function
    Private Sub zamena(ByRef s As String)
        Dim masslov(), p As String
        masslov = Split(s)
        p = masslov(0)
        masslov(0) = masslov(UBound(masslov))
        masslov(UBound(masslov)) = p
        s = Join(masslov)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, k As Integer, t() As String
        vvod(n, t)
        vivod(n, t, ListBox1)
        ideal(n, t)
        For i = 0 To n - 1
            k = kol(t(i)) + 1
            If k > 1 Then
                zamena(t(i))
                ListBox2.Items.Add(k)
            Else
                ListBox2.Items.Add(k)
            End If
        Next
        vivod(n, t, ListBox3)
    End Sub
End Class
