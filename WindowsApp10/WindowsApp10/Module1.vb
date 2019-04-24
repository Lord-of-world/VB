Module Module1
    Dim s As String, i As Integer
    Public Sub Печать(ByVal fn As String, ByRef lb As ListBox)
        lb.Items.Clear()
        FileOpen(1, fn, OpenMode.Input)
        Do Until EOF(1)
            s = LineInput(1)
            lb.Items.Add(s)
        Loop
        FileClose()
    End Sub
    Public Function Ideal(ByVal s As String) As String
        Do While InStr(s, "  ") <> 0
            s = Replace(s, "  ", " ")
        Loop
        s = Trim(s)
        Return s
    End Function
    Public Sub ИдеальныйФайл(ByVal fn As String)
        FileOpen(1, fn, OpenMode.Input)
        FileOpen(2, fn + "1", OpenMode.Output)
        Do Until EOF(1)
            s = LineInput(1)
            s = Ideal(s)
            If Len(s) > 0 Then PrintLine(2, s)
        Loop
        FileClose()
        Kill(fn)
        Rename(fn + "1", fn)
    End Sub
    Public Sub МаксПредл(ByVal fn As String, ByRef tb As TextBox)
        Dim k, kbuf As Integer, sbuf As String
        FileOpen(1, fn, OpenMode.Input)
        tb.Text = ""
        sbuf = ""
        Do Until EOF(1)
            s = LineInput(1)
            k = 0
            For i = 1 To Len(s)
                If Mid(s, i, 1) = "." Then k = k + 1
            Next
            If k > kbuf Then kbuf = k : sbuf = s
        Loop
        tb.Text = sbuf
        FileClose()
    End Sub
    Public Sub Палиндромы(ByVal fn As String)
        Dim ms(), buf As String
        FileOpen(1, fn, OpenMode.Input)
        FileOpen(2, fn + "1", OpenMode.Output)
        Do Until EOF(1)
            s = LineInput(1)
            ms = Split(s)
            For i = 0 To UBound(ms)
                buf = ""
                If InStr(ms(i), ".") > 0 Then buf = "." : ms(i) = Replace(ms(i), ".", "")
                If UCase(ms(i)) = StrReverse(UCase(ms(i))) Then
                    ms(i) = UCase(ms(i))
                End If
                ms(i) = ms(i) + buf
            Next
            s = Join(ms)
            PrintLine(2, s)
        Loop
        FileClose()
        Kill(fn)
        Rename(fn + "1", fn)
    End Sub
End Module
