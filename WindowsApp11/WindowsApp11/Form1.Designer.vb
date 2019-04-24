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
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПечатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НовыйФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоискToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СуммаЧиселToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДлинноеСловоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИдеалToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.FormattingEnabled = True
        Me.lb1.ItemHeight = 20
        Me.lb1.Location = New System.Drawing.Point(22, 115)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(756, 404)
        Me.lb1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ПоискToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПечатьToolStripMenuItem, Me.НовыйФайлToolStripMenuItem, Me.ИдеалToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ПечатьToolStripMenuItem
        '
        Me.ПечатьToolStripMenuItem.Name = "ПечатьToolStripMenuItem"
        Me.ПечатьToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ПечатьToolStripMenuItem.Text = "Печать"
        '
        'НовыйФайлToolStripMenuItem
        '
        Me.НовыйФайлToolStripMenuItem.Name = "НовыйФайлToolStripMenuItem"
        Me.НовыйФайлToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.НовыйФайлToolStripMenuItem.Text = "Новый файл"
        '
        'ПоискToolStripMenuItem
        '
        Me.ПоискToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СуммаЧиселToolStripMenuItem, Me.ДлинноеСловоToolStripMenuItem})
        Me.ПоискToolStripMenuItem.Name = "ПоискToolStripMenuItem"
        Me.ПоискToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
        Me.ПоискToolStripMenuItem.Text = "Поиск"
        '
        'СуммаЧиселToolStripMenuItem
        '
        Me.СуммаЧиселToolStripMenuItem.Name = "СуммаЧиселToolStripMenuItem"
        Me.СуммаЧиселToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.СуммаЧиселToolStripMenuItem.Text = "Сумма чисел"
        '
        'ДлинноеСловоToolStripMenuItem
        '
        Me.ДлинноеСловоToolStripMenuItem.Name = "ДлинноеСловоToolStripMenuItem"
        Me.ДлинноеСловоToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ДлинноеСловоToolStripMenuItem.Text = "Длинное слово"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'ИдеалToolStripMenuItem
        '
        Me.ИдеалToolStripMenuItem.Name = "ИдеалToolStripMenuItem"
        Me.ИдеалToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ИдеалToolStripMenuItem.Text = "Идеал"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(992, 560)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb1 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПечатьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НовыйФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПоискToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СуммаЧиселToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДлинноеСловоToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ИдеалToolStripMenuItem As ToolStripMenuItem
End Class
