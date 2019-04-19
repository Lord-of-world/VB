Module Module1
    Public Structure Ведомость
        Public НомерГруппы As Integer
        Public НомерЗачётки As Integer
        Public Стипендия As Integer
        Public Sub ВводСтруктуры()
            НомерГруппы = Val(InputBox("Введите номер группы"))
            НомерЗачётки = Val(InputBox("Введите номер зачётки"))
            Стипендия = Val(InputBox("Введите стипендию"))
        End Sub
        Public Function Строка() As String
            Строка = Str(НомерГруппы) + " " + Str(НомерЗачётки) + " " + Str(Стипендия)
        End Function
    End Structure
    Public Sub Создание(ByVal fn As String)
        Dim n, i As Integer
        Dim Ved As Ведомость
        FileOpen(1, fn, OpenMode.Random,,, 100)
        n = Val(InputBox("Введите кол-во элеменов ведомости"))
        For i = 1 To n
            Ved.ВводСтруктуры()
            FilePut(1, Ved)
        Next
        FileClose()
    End Sub
    Public Sub Открытие(ByVal fn As String, ByRef ListBox1 As ListBox)
        Dim Ved As Ведомость
        Dim n As Integer
        ListBox1.Items.Clear()
        FileOpen(1, fn, OpenMode.Random,,, 100)
        n = (LOF(1) / 100) + 1
        For i = 1 To n
            FileGet(1, Ved)
            ListBox1.Items.Add(Ved.Строка)
        Next
        FileClose()
    End Sub
    Public Sub НетСтипендии(ByVal fn As String, ByRef ListBox2 As ListBox)
        Dim Ved As Ведомость
        Dim n As Integer
        ListBox2.Items.Clear()
        FileOpen(1, fn, OpenMode.Random,,, 100)
        n = (LOF(1) / 100) + 1
        For i = 1 To n
            FileGet(1, Ved)
            If Ved.Стипендия = 0 Then
                ListBox2.Items.Add(Ved.НомерЗачётки)
            End If
        Next
        FileClose()

    End Sub
    Public Function СредняяСтипендия(ByVal fn As String) As Single
        Dim Ved As Ведомость
        Dim n As Integer
        Dim SRC, S As Single
        FileOpen(1, fn, OpenMode.Random,,, 100)
        n = (LOF(1) / 100) + 1
        S = 0
        For i = 1 To n
            FileGet(1, Ved)
            S = S + Ved.Стипендия
        Next
        SRC = S / n
        FileClose(1)
        Return SRC

    End Function
    Public Sub Удаление(ByVal fn As String, ByVal src As Single)
        Dim Ved As Ведомость
        Dim n As Integer
        Dim fn1 As String
        'FileClose()
        FileOpen(3, fn, OpenMode.Random,,, 100)
        n = (LOF(3) / 100) + 1
        fn1 = fn + "1"
        FileOpen(2, fn1, OpenMode.Random,,, 100)
        For i = 1 To n
            FileGet(3, Ved)
            If Ved.Стипендия >= SRC Then
                FilePut(2, Ved)
            End If
        Next
        FileClose()
        Kill(fn)
        Rename(fn1, fn)
    End Sub
End Module
