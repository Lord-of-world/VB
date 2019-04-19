Module Module1
    Structure Пассажир
        Public fam As String
        Public kol As Integer
        Public ves As Integer
        Public Sub ВводПассажира()
            fam = InputBox("Введите фамилию пассажира")
            kol = Val(InputBox("Введите количество мест багажа"))
            ves = Val(InputBox("Введите общий вес багажа"))
        End Sub
        Public Function Строка() As String
            Строка = fam + vbTab + Str(kol) + vbTab + Str(ves)
        End Function
        Public Function СреднийВес() As Single
            СреднийВес = ves / kol
        End Function
    End Structure
    Public Sub Создание(ByVal fn As String)
        Dim ps As Пассажир, i, n As Integer
        FileOpen(1, fn, OpenMode.Random,,, 40)
        Do
            n = Val(InputBox("Введите количество пассажиров"))
        Loop Until n > 0
        For i = 1 To n
            ps.ВводПассажира()
            FilePut(1, ps)
        Next
        FileClose()
    End Sub
    Public Sub Печать(ByVal fn As String, ByRef lb As ListBox)
        Dim ps As Пассажир, i, n As Integer
        lb.Items.Clear()
        FileOpen(1, fn, OpenMode.Random,,, 40)
        n = LOF(1) / 40 + 1
        For i = 1 To n
            FileGet(1, ps)
            lb.Items.Add(ps.Строка)
        Next
        FileClose()
    End Sub
    Public Function ОбщийВес(ByVal fn As String) As Integer
        Dim ps As Пассажир, i, n As Integer
        FileOpen(1, fn, OpenMode.Random,,, 40)
        n = LOF(1) / 40 + 1
        For i = 1 To n
            FileGet(1, ps)
            ОбщийВес = ОбщийВес + ps.ves
        Next
        FileClose()
    End Function
    Public Sub Сортировка(ByVal fn As String)
        Dim ps1, ps2 As Пассажир, i, n As Integer, sort As Boolean
        FileOpen(1, fn, OpenMode.Random,,, 40)
        n = LOF(1) / 40 + 1
        Do
            sort = True
            For i = 1 To n - 1
                FileGet(1, ps1, i)
                FileGet(1, ps2, i + 1)
                If ps1.СреднийВес > ps2.СреднийВес Then
                    FilePut(1, ps2, i)
                    FilePut(1, ps1, i + 1)
                    sort = False
                End If
            Next
        Loop Until sort = True
        FileClose()
    End Sub
End Module
