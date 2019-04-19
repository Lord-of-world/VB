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
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СоздатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РаспечататьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЧтотоЕщёToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИЕщёToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.НовыйФайл4МестаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ЧтотоЕщёToolStripMenuItem, Me.ИЕщёToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоздатьToolStripMenuItem, Me.РаспечататьToolStripMenuItem, Me.НовыйФайл4МестаToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'СоздатьToolStripMenuItem
        '
        Me.СоздатьToolStripMenuItem.Name = "СоздатьToolStripMenuItem"
        Me.СоздатьToolStripMenuItem.Size = New System.Drawing.Size(193, 30)
        Me.СоздатьToolStripMenuItem.Text = "Создать"
        '
        'РаспечататьToolStripMenuItem
        '
        Me.РаспечататьToolStripMenuItem.Name = "РаспечататьToolStripMenuItem"
        Me.РаспечататьToolStripMenuItem.Size = New System.Drawing.Size(193, 30)
        Me.РаспечататьToolStripMenuItem.Text = "Распечатать"
        '
        'ЧтотоЕщёToolStripMenuItem
        '
        Me.ЧтотоЕщёToolStripMenuItem.Name = "ЧтотоЕщёToolStripMenuItem"
        Me.ЧтотоЕщёToolStripMenuItem.Size = New System.Drawing.Size(115, 29)
        Me.ЧтотоЕщёToolStripMenuItem.Text = "Общий вес"
        '
        'ИЕщёToolStripMenuItem
        '
        Me.ИЕщёToolStripMenuItem.Name = "ИЕщёToolStripMenuItem"
        Me.ИЕщёToolStripMenuItem.Size = New System.Drawing.Size(124, 29)
        Me.ИЕщёToolStripMenuItem.Text = "Сортировка"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(8, 182)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(636, 424)
        Me.ListBox1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(632, 26)
        Me.TextBox1.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(650, 182)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(636, 424)
        Me.ListBox2.TabIndex = 3
        '
        'НовыйФайл4МестаToolStripMenuItem
        '
        Me.НовыйФайл4МестаToolStripMenuItem.Name = "НовыйФайл4МестаToolStripMenuItem"
        Me.НовыйФайл4МестаToolStripMenuItem.Size = New System.Drawing.Size(264, 30)
        Me.НовыйФайл4МестаToolStripMenuItem.Text = "Новый файл 4 места"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 625)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
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
    Friend WithEvents ЧтотоЕщёToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ИЕщёToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents СоздатьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РаспечататьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents НовыйФайл4МестаToolStripMenuItem As ToolStripMenuItem
End Class
