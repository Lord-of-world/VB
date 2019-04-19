Module Module1
    Dim s As String
    Public Sub Печать(ByVal fn As String, ByRef lb As ListBox)
        Dim i As Integer
        lb.Items.Clear()
        FileOpen(1, fn, OpenMode.Input)
        Do Until EOF(1)
            lb.Items.Add(LineInput(1))
        Loop
        FileClose()
    End Sub
End Module
