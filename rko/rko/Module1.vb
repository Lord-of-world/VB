Module Module1
    Structure student
        Public fam As String
        Public gr As String
        Public mark() As Integer

        Public Sub ВводСтруктуры()
            Dim i As Integer
            fam = InputBox("Введите фамилию студента")
            gr = InputBox("Введите группу студента")
            ReDim mark(2)
            For i = 0 To 2
                mark(i) = Val(InputBox("Вводите оценки студента"))
            Next
        End Sub

        Public Function otl() As Boolean
            Dim i As Integer
            otl = True
            For i = 0 To 2
                If mark(i) <> 5 Then otl = False
            Next
            Return otl
        End Function
        Public Function ВыводСтруктуры() As String
            Dim s As String
            s = fam + vbTab + gr
            For i = 0 To 2
                s = s + vbTab + Str(mark(i))
            Next
            Return s
        End Function
    End Structure

    Public Sub input(ByRef n As Integer, ByRef stud() As student)
        Dim i As Integer
        Do
            n = Val(InputBox("Введите количество студентов"))
        Loop Until n > 0
        ReDim stud(n - 1)
        For i = 0 To n - 1
            stud(i).ВводСтруктуры()
        Next
    End Sub

    Public Sub Output(ByVal n As Integer, ByVal stud() As student, ByRef lb As ListBox)
        Dim i As Integer
        lb.Items.Clear()
        For i = 0 To n - 1
            lb.Items.Add(stud(i).ВыводСтруктуры())
        Next
    End Sub

    Public Function kolotl(ByVal n As Integer, ByVal stud() As student) As Integer
        Dim i As Integer
        For i = 0 To n - 1
            If stud(i).otl() = True Then kolotl = kolotl + 1
        Next
    End Function

    Public Sub sort(ByVal n As Integer, ByRef stud() As student)
        Dim i As Integer
        Dim buf As student
        Dim otsort As Boolean
        Do
            otsort = True
            For i = 0 To n - 2
                If stud(i).fam > stud(i + 1).fam Then
                    otsort = False
                    buf = stud(i)
                    stud(i) = stud(i + 1)
                    stud(i + 1) = buf
                End If
            Next
        Loop Until otsort = True
    End Sub

    Public Sub group(ByVal n As Integer, ByVal stud() As student, ByVal grup As String, ByRef k As Integer, ByRef stud2() As student)
        Dim i As Integer
        k = 0
        For i = 0 To n - 1
            If stud(i).gr = grup Then
                ReDim Preserve stud2(k)
                stud2(k) = stud(i)
                k = k + 1
            End If
        Next
    End Sub
End Module
