<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СоздатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактированиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПросмотретьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СортироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоОчкамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоКомандамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоФИОToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтстающихToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КомандуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьСтудентовToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lb = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.РедактированиеToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1198, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоздатьToolStripMenuItem, Me.ПросмотретьToolStripMenuItem, Me.УдалитьToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'СоздатьToolStripMenuItem
        '
        Me.СоздатьToolStripMenuItem.Name = "СоздатьToolStripMenuItem"
        Me.СоздатьToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.СоздатьToolStripMenuItem.Text = "Создать"
        '
        'РедактированиеToolStripMenuItem
        '
        Me.РедактированиеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СортироватьToolStripMenuItem, Me.УдалитьToolStripMenuItem1, Me.ДобавитьСтудентовToolStripMenuItem})
        Me.РедактированиеToolStripMenuItem.Name = "РедактированиеToolStripMenuItem"
        Me.РедактированиеToolStripMenuItem.Size = New System.Drawing.Size(158, 29)
        Me.РедактированиеToolStripMenuItem.Text = "Редактирование"
        '
        'ПросмотретьToolStripMenuItem
        '
        Me.ПросмотретьToolStripMenuItem.Name = "ПросмотретьToolStripMenuItem"
        Me.ПросмотретьToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ПросмотретьToolStripMenuItem.Text = "Просмотреть"
        '
        'УдалитьToolStripMenuItem
        '
        Me.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem"
        Me.УдалитьToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.УдалитьToolStripMenuItem.Text = "Удалить"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'СортироватьToolStripMenuItem
        '
        Me.СортироватьToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПоОчкамToolStripMenuItem, Me.ПоКомандамToolStripMenuItem, Me.ПоФИОToolStripMenuItem, Me.ПоToolStripMenuItem})
        Me.СортироватьToolStripMenuItem.Name = "СортироватьToolStripMenuItem"
        Me.СортироватьToolStripMenuItem.Size = New System.Drawing.Size(260, 30)
        Me.СортироватьToolStripMenuItem.Text = "Сортировать по"
        '
        'ПоОчкамToolStripMenuItem
        '
        Me.ПоОчкамToolStripMenuItem.Name = "ПоОчкамToolStripMenuItem"
        Me.ПоОчкамToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ПоОчкамToolStripMenuItem.Text = "Очкам"
        '
        'ПоКомандамToolStripMenuItem
        '
        Me.ПоКомандамToolStripMenuItem.Name = "ПоКомандамToolStripMenuItem"
        Me.ПоКомандамToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ПоКомандамToolStripMenuItem.Text = "Командам"
        '
        'ПоФИОToolStripMenuItem
        '
        Me.ПоФИОToolStripMenuItem.Name = "ПоФИОToolStripMenuItem"
        Me.ПоФИОToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ПоФИОToolStripMenuItem.Text = "ФИО"
        '
        'ПоToolStripMenuItem
        '
        Me.ПоToolStripMenuItem.Name = "ПоToolStripMenuItem"
        Me.ПоToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ПоToolStripMenuItem.Text = "Позиции"
        '
        'УдалитьToolStripMenuItem1
        '
        Me.УдалитьToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОтстающихToolStripMenuItem, Me.КомандуToolStripMenuItem})
        Me.УдалитьToolStripMenuItem1.Name = "УдалитьToolStripMenuItem1"
        Me.УдалитьToolStripMenuItem1.Size = New System.Drawing.Size(260, 30)
        Me.УдалитьToolStripMenuItem1.Text = "Удалить"
        '
        'ОтстающихToolStripMenuItem
        '
        Me.ОтстающихToolStripMenuItem.Name = "ОтстающихToolStripMenuItem"
        Me.ОтстающихToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ОтстающихToolStripMenuItem.Text = "Отстающих"
        '
        'КомандуToolStripMenuItem
        '
        Me.КомандуToolStripMenuItem.Name = "КомандуToolStripMenuItem"
        Me.КомандуToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.КомандуToolStripMenuItem.Text = "Команду"
        '
        'ДобавитьСтудентовToolStripMenuItem
        '
        Me.ДобавитьСтудентовToolStripMenuItem.Name = "ДобавитьСтудентовToolStripMenuItem"
        Me.ДобавитьСтудентовToolStripMenuItem.Size = New System.Drawing.Size(260, 30)
        Me.ДобавитьСтудентовToolStripMenuItem.Text = "Добавить студентов"
        '
        'lb
        '
        Me.lb.FormattingEnabled = True
        Me.lb.ItemHeight = 20
        Me.lb.Location = New System.Drawing.Point(32, 67)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(971, 524)
        Me.lb.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 629)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СоздатьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РедактированиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ПросмотретьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents УдалитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СортироватьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПоОчкамToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПоКомандамToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПоФИОToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПоToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents УдалитьToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ОтстающихToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КомандуToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьСтудентовToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lb As ListBox
End Class
