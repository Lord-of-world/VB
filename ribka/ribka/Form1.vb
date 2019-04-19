Public Class Form1
    Private Sub vvod(ByRef n As Integer,
                     ByRef m As Integer,
                     ByRef a(,) As Integer)
        Dim i, j As Integer
        Do
            n = Val(InputBox("Введите N"))
        Loop Until n > 0
        Do
            m = Val(InputBox("Введите M"))
        Loop Until m > 0
        ReDim a(n - 1, m - 1)
        For i = 0 To n - 1
            For j = 0 To m - 1
                a(i, j) = Val(InputBox("Вводите числа"))
            Next
        Next
    End Sub
    Private Sub vivod(ByVal n As Integer,
                      ByVal m As Integer,
                      ByVal a(,) As Integer,
                      ByRef lb As ListBox)
        Dim i, j As Integer, s As String
        lb.Items.Clear()
        For i = 0 To n - 1
            s = ""
            For j = 0 To m - 1
                s = s + Str(a(i, j)) + vbTab
            Next
            lb.Items.Add(s)
        Next
    End Sub
    Private Sub max(ByVal n As Integer,
                    ByVal m As Integer,
                    ByVal a(,) As Integer,
                    ByRef b() As Integer)
        Dim i, j, max As Integer
        ReDim b(n)
        For i = 0 To n - 1
            max = a(i, 0)
            For j = 1 To m - 1
                If max < a(i, j) Then max = a(i, j)
            Next
            b(i) = max
        Next
    End Sub
    Private Sub vivod2(ByVal n As Integer,
                       ByVal b() As Integer,
                       ByRef tb As TextBox)
        Dim i As Integer, s As String
        s = ""
        For i = 0 To n - 1
            s = s + Str(b(i)) + vbTab
        Next
        tb.Text = s
    End Sub
    Private Sub sort(ByVal n As Integer,
                     ByRef b() As Integer)
        Dim otsort As Boolean, buf, i As Integer
        Do
            otsort = True
            For i = 0 To n - 2
                If b(i) > b(i + 1) Then
                    otsort = False
                    buf = b(i)
                    b(i) = b(i + 1)
                    b(i + 1) = buf
                End If
            Next
        Loop Until otsort = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, m, a(,), b() As Integer
        vvod(n, m, a)
        vivod(n, m, a, ListBox1)
        max(n, m, a, b)
        vivod2(n, b, TextBox1)
        sort(n, b)
        vivod2(n, b, TextBox2)
    End Sub
End Class
