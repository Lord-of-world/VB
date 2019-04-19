Imports System.Math

Module Module1
    Structure Point
        Public x, y As Integer

        Public Sub ВводСтруктуры()
            x = InputBox("Введите координату X")
            y = InputBox("Введите координату Y")
        End Sub
        Public Function Строка() As String
            Строка = Str(x) + vbTab + Str(y)
        End Function
        Public Function Length() As Single
            Length = Sqrt(x ^ 2 + y ^ 2)
        End Function
    End Structure

    Public Sub input(ByRef n As Integer, ByRef p() As Point)
        Dim i As Integer
        Do
            n = Val(InputBox("Введите количество точек"))
        Loop Until n > 0
        ReDim p(n - 1)
        For i = 0 To n - 1
            p(i).ВводСтруктуры()
        Next
    End Sub

    Public Sub Output(ByVal n As Integer, ByVal p() As Point, ByRef lb As ListBox)
        Dim i As Integer
        lb.Items.Clear()
        For i = 0 To n - 1
            lb.Items.Add(p(i).Строка())
        Next
    End Sub

    Public Function Rad(ByVal n As Integer, ByVal p() As Point, ByVal r As Single) As Integer
        Dim i As Integer
        Rad = 0
        For i = 0 To n - 1
            If p(i).Length() < r Then Rad = Rad + 1
        Next
    End Function

    Public Sub otsort(ByVal n As Integer, ByRef p() As Point)
        Dim i As Integer
        Dim flag As Boolean
        Dim buf As Point
        Do
            flag = True
            For i = 0 To n - 2
                If p(i).Length() > p(i + 1).Length() Then
                    flag = False
                    buf = p(i)
                    p(i) = p(i + 1)
                    p(i + 1) = buf
                End If
            Next
        Loop Until flag = True
    End Sub

    Public Sub Newmas(ByVal n As Integer, ByVal p() As Point, ByRef m As Integer, ByRef p2() As Point)
        Dim i As Integer
        Dim k As Single
        m = 0
        k = 0
        For i = 0 To n - 1
            k = k + p(i).Length()
        Next
        k = k / n
        For i = 0 To n - 1
            If p(i).Length() < k Then
                ReDim Preserve p2(m)
                p2(m) = p(i)
                m = m + 1
            End If
        Next
    End Sub
End Module
