Module Module1
    Dim s As String
    Public Sub Идеал(ByVal fn As String)
        FileOpen(1, fn, OpenMode.Input)
        FileOpen(2, fn + "1", OpenMode.Output)
        Do Until EOF(1)
            s = LineInput(1)
            Do While InStr(s, "  ") <> 0
                s = Replace(s, "  ", " ")
            Loop
            s = Trim(s)
            If Len(s) > 0 Then PrintLine(2, s)
        Loop
        FileClose()
        Kill(fn)
        Rename(fn + "1", fn)
    End Sub
    Public Sub Печать(ByVal fn As String, ByRef lb As ListBox)
        lb.Items.Clear()
        FileOpen(1, fn, OpenMode.Input)
        Do Until EOF(1)
            s = LineInput(1)
            lb.Items.Add(s)
        Loop
        FileClose()
    End Sub
    Public Function Сумма(ByVal fn As String) As Integer
        Dim k, i As Integer, mas() As String
        FileOpen(1, fn, OpenMode.Input)
        Do Until EOF(1)
            s = LineInput(1)
            mas = Split(s)
            For i = 0 To UBound(mas)
                If Trim(Str(Val(mas(i)))) = mas(i) Then k = k + mas(i)
            Next
        Loop
        FileClose()
        Return k
    End Function
    Public Function Слово(ByVal fn As String) As String
        Dim k, i, b As Integer, mas(), buf As String
        FileOpen(1, fn, OpenMode.Input)
        k = Val(InputBox("Введите номер строки"))
        b = 0
        Do Until EOF(1)
            s = LineInput(1)
            i = i + 1
            If i = k Then
                mas = Split(s)
                For i = 0 To UBound(mas)
                    If Len(mas(i)) > b Then b = Len(mas(i)) : buf = mas(i)
                Next
            End If
        Loop
        FileClose()
        Return buf
    End Function
    Public Sub Новый(ByVal fn As String)
        Dim slovo As String
        FileOpen(1, fn, OpenMode.Input)
        FileOpen(2, fn + "1", OpenMode.Output)
        slovo = InputBox("Введите слово")
        Do Until EOF(1)
            s = LineInput(1)
            If InStr(s, slovo) > 0 Then PrintLine(2, s)
        Loop
        FileClose()
    End Sub
End Module
