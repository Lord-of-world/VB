Module Module1
    Dim i, n As Integer
    Dim st, st1, st2 As Студент
    Dim sort As Boolean
    Public Structure Студент
        Public FIO As String
        Public team As String
        Public position As Integer
        Public scores As Integer

        Public Sub ВводСтруктуры()
            FIO = InputBox("Введите ФИО студента")
            team = InputBox("Введите команду студента")
            scores = Val(InputBox("Введите очки команды"))
            position = Val(InputBox("Введите место команды"))
        End Sub
        Public Function Строка()
            Строка = LSet(FIO, 50) + LSet(team, 30) + LSet(scores, 7) + LSet(position, 3)
        End Function
    End Structure

    Public Sub Создание(ByVal fn As String)
        FileOpen(1, fn, OpenMode.Random,,, 90)
        Do
            n = Val(InputBox("Введите количество студентов"))
        Loop Until n > 0
        For i = 1 To n
            st.ВводСтруктуры()
            FilePut(1, st)
        Next
        FileClose()
    End Sub
    Public Sub Печать(ByVal fn As String, ByRef lb As ListBox)
        FileOpen(1, fn, OpenMode.Random,,, 90)
        n = LOF(1) / 90 + 1
        lb.Items.Clear()
        For i = 1 To n
            FileGet(1, st)
            lb.Items.Add(st.Строка)
        Next
        FileClose()
    End Sub
    Public Sub Сортировать_по_очкам(ByVal fn As String)
        FileOpen(1, fn, OpenMode.Random,,, 90)
        n = LOF(1) / 90 + 1
        Do
            sort = True
            For i = 1 To n - 1
                FileGet(1, st1, i)
                FileGet(1, st2, i + 1)
                If st1.scores < st2.scores Then
                    FilePut(1, st2, i)
                    FilePut(1, st1, i + 1)
                    sort = False
                End If
            Next
        Loop Until sort = True
        FileClose()
    End Sub
    Public Sub Сортировать_по_командам(ByVal fn As String)
        FileOpen(1, fn, OpenMode.Random,,, 90)
        n = LOF(1) / 90 + 1
        Do
            sort = True
            For i = 1 To n - 1
                FileGet(1, st1, i)
                FileGet(1, st2, i + 1)
                If st1.team > st2.team Then
                    FilePut(1, st2, i)
                    FilePut(1, st1, i + 1)
                    sort = False
                End If
            Next
        Loop Until sort = True
        FileClose()
    End Sub
    Public Sub Сортировать_по_ФИО(ByVal fn As String)
        FileOpen(1, fn, OpenMode.Random,,, 90)
        n = LOF(1) / 90 + 1
        Do
            sort = True
            For i = 1 To n - 1
                FileGet(1, st1, i)
                FileGet(1, st2, i + 1)
                If st1.FIO > st2.FIO Then
                    FilePut(1, st2, i)
                    FilePut(1, st1, i + 1)
                    sort = False
                End If
            Next
        Loop Until sort = True
        FileClose()
    End Sub
    Public Sub Сортировать_по_позиции(ByVal fn As String)
        FileOpen(1, fn, OpenMode.Random,,, 90)
        n = LOF(1) / 90 + 1
        Do
            sort = True
            For i = 1 To n - 1
                FileGet(1, st1, i)
                FileGet(1, st2, i + 1)
                If st1.position > st2.position Then
                    FilePut(1, st2, i)
                    FilePut(1, st1, i + 1)
                    sort = False
                End If
            Next
        Loop Until sort = True
        FileClose()
    End Sub
    Public Sub Добавить(ByVal fn As String)
        Dim k As Integer
        FileOpen(1, fn, OpenMode.Random,,, 90)
        n = LOF(1) / 90 + 1
        Do
            k = Val(InputBox("Сколько студентов нужно добавить?"))
        Loop Until k > 0
        For i = 1 To k
            st.ВводСтруктуры()
            FilePut(1, st, n + i)
        Next
        FileClose()
    End Sub
    Public Sub Удалить_команду(ByVal fn As String)
        FileOpen(1, fn, OpenMode.Random,,, 90)
        FileOpen(2, fn + "1", OpenMode.Random,,, 90)
        Dim s As String
        s = InputBox("Введите команду, которую хотите удалить")
        n = LOF(1) / 90 + 1
        For i = 1 To n
            FileGet(1, st)
            If st.team <> s Then FilePut(2, st)
        Next
        FileClose()
        Kill(fn)
        Rename(fn + "1", fn)
    End Sub
End Module
