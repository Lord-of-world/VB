Public Class Form1
    Private Sub Button_GO_Click(HAPPY As Object, NEW_YEAR As EventArgs) Handles Button_GO.Click
        Do
            If Format(Now, "dd.MM.yyyy HH:mm:ss") = Format("01.01.2019 00:00:00") Then
                MsgBox("                Желаю этот Новый год
                Отметить ярко и красиво,
                Пусть всем он радость принесет,
                Как можно больше позитива!

                Пускай на сессиях удача
                Сопровождает вас всегда,
                Чтоб все Вы слова «пересдача»
                Не знали в жизни никогда!")
            End If
        Loop Until Format(Now, "dd.MM.yyyy HH:mm:ss") = Format("01.01.2019 00:00:00")
    End Sub
End Class
