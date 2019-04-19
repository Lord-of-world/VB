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
        s = Trim(s)
        Do While InStr(s, "  ") <> 0
            s = Replace(s, "  ", " ")
        Loop
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
        Do Until EOF(1)
            s = LineInput(1)
            k = 0
            For i = 1 To Len(s)
                If Mid(s, i, 1) = "." Then k = k + 1
            Next
            If k > kbuf Then kbuf = k : sbuf = s
        Loop
        tb.Text = sbuf
    End Sub
End Module
