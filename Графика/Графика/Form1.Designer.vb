<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.РисованиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СолнышкоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СолнышкоToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.МассивСолнышекToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СпиральСолнышекToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КорабликToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КорабликToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.МассивКорабликовToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СпиральКорабликовToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДомикToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДомикToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.МассивДомиковToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СпиральДомиковToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДействияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СолнышкоToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.КорабликToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДомикToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОчиститьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РисованиеToolStripMenuItem, Me.ДействияToolStripMenuItem, Me.ОчиститьToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1178, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'РисованиеToolStripMenuItem
        '
        Me.РисованиеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СолнышкоToolStripMenuItem, Me.КорабликToolStripMenuItem, Me.ДомикToolStripMenuItem})
        Me.РисованиеToolStripMenuItem.Name = "РисованиеToolStripMenuItem"
        Me.РисованиеToolStripMenuItem.Size = New System.Drawing.Size(111, 29)
        Me.РисованиеToolStripMenuItem.Text = "Рисование"
        '
        'СолнышкоToolStripMenuItem
        '
        Me.СолнышкоToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СолнышкоToolStripMenuItem1, Me.МассивСолнышекToolStripMenuItem, Me.СпиральСолнышекToolStripMenuItem})
        Me.СолнышкоToolStripMenuItem.Name = "СолнышкоToolStripMenuItem"
        Me.СолнышкоToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.СолнышкоToolStripMenuItem.Text = "Солнышко"
        '
        'СолнышкоToolStripMenuItem1
        '
        Me.СолнышкоToolStripMenuItem1.Name = "СолнышкоToolStripMenuItem1"
        Me.СолнышкоToolStripMenuItem1.Size = New System.Drawing.Size(253, 30)
        Me.СолнышкоToolStripMenuItem1.Text = "Солнышко"
        '
        'МассивСолнышекToolStripMenuItem
        '
        Me.МассивСолнышекToolStripMenuItem.Name = "МассивСолнышекToolStripMenuItem"
        Me.МассивСолнышекToolStripMenuItem.Size = New System.Drawing.Size(253, 30)
        Me.МассивСолнышекToolStripMenuItem.Text = "Массив Солнышек"
        '
        'СпиральСолнышекToolStripMenuItem
        '
        Me.СпиральСолнышекToolStripMenuItem.Name = "СпиральСолнышекToolStripMenuItem"
        Me.СпиральСолнышекToolStripMenuItem.Size = New System.Drawing.Size(253, 30)
        Me.СпиральСолнышекToolStripMenuItem.Text = "Спираль солнышек"
        '
        'КорабликToolStripMenuItem
        '
        Me.КорабликToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КорабликToolStripMenuItem1, Me.МассивКорабликовToolStripMenuItem, Me.СпиральКорабликовToolStripMenuItem})
        Me.КорабликToolStripMenuItem.Name = "КорабликToolStripMenuItem"
        Me.КорабликToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.КорабликToolStripMenuItem.Text = "Кораблик"
        '
        'КорабликToolStripMenuItem1
        '
        Me.КорабликToolStripMenuItem1.Name = "КорабликToolStripMenuItem1"
        Me.КорабликToolStripMenuItem1.Size = New System.Drawing.Size(270, 30)
        Me.КорабликToolStripMenuItem1.Text = "Кораблик"
        '
        'МассивКорабликовToolStripMenuItem
        '
        Me.МассивКорабликовToolStripMenuItem.Name = "МассивКорабликовToolStripMenuItem"
        Me.МассивКорабликовToolStripMenuItem.Size = New System.Drawing.Size(270, 30)
        Me.МассивКорабликовToolStripMenuItem.Text = "Массив Корабликов"
        '
        'СпиральКорабликовToolStripMenuItem
        '
        Me.СпиральКорабликовToolStripMenuItem.Name = "СпиральКорабликовToolStripMenuItem"
        Me.СпиральКорабликовToolStripMenuItem.Size = New System.Drawing.Size(270, 30)
        Me.СпиральКорабликовToolStripMenuItem.Text = "Спираль Корабликов"
        '
        'ДомикToolStripMenuItem
        '
        Me.ДомикToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДомикToolStripMenuItem1, Me.МассивДомиковToolStripMenuItem, Me.СпиральДомиковToolStripMenuItem})
        Me.ДомикToolStripMenuItem.Name = "ДомикToolStripMenuItem"
        Me.ДомикToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ДомикToolStripMenuItem.Text = "Домик"
        '
        'ДомикToolStripMenuItem1
        '
        Me.ДомикToolStripMenuItem1.Name = "ДомикToolStripMenuItem1"
        Me.ДомикToolStripMenuItem1.Size = New System.Drawing.Size(246, 30)
        Me.ДомикToolStripMenuItem1.Text = "Домик"
        '
        'МассивДомиковToolStripMenuItem
        '
        Me.МассивДомиковToolStripMenuItem.Name = "МассивДомиковToolStripMenuItem"
        Me.МассивДомиковToolStripMenuItem.Size = New System.Drawing.Size(246, 30)
        Me.МассивДомиковToolStripMenuItem.Text = "Массив Домиков"
        '
        'СпиральДомиковToolStripMenuItem
        '
        Me.СпиральДомиковToolStripMenuItem.Name = "СпиральДомиковToolStripMenuItem"
        Me.СпиральДомиковToolStripMenuItem.Size = New System.Drawing.Size(246, 30)
        Me.СпиральДомиковToolStripMenuItem.Text = "Спираль Домиков"
        '
        'ДействияToolStripMenuItem
        '
        Me.ДействияToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СолнышкоToolStripMenuItem2, Me.КорабликToolStripMenuItem2, Me.ДомикToolStripMenuItem2})
        Me.ДействияToolStripMenuItem.Name = "ДействияToolStripMenuItem"
        Me.ДействияToolStripMenuItem.Size = New System.Drawing.Size(99, 29)
        Me.ДействияToolStripMenuItem.Text = "Действия"
        '
        'СолнышкоToolStripMenuItem2
        '
        Me.СолнышкоToolStripMenuItem2.Name = "СолнышкоToolStripMenuItem2"
        Me.СолнышкоToolStripMenuItem2.Size = New System.Drawing.Size(184, 30)
        Me.СолнышкоToolStripMenuItem2.Text = "Солнышко"
        '
        'КорабликToolStripMenuItem2
        '
        Me.КорабликToolStripMenuItem2.Name = "КорабликToolStripMenuItem2"
        Me.КорабликToolStripMenuItem2.Size = New System.Drawing.Size(184, 30)
        Me.КорабликToolStripMenuItem2.Text = "Кораблик"
        '
        'ДомикToolStripMenuItem2
        '
        Me.ДомикToolStripMenuItem2.Name = "ДомикToolStripMenuItem2"
        Me.ДомикToolStripMenuItem2.Size = New System.Drawing.Size(184, 30)
        Me.ДомикToolStripMenuItem2.Text = "Домик"
        '
        'ОчиститьToolStripMenuItem
        '
        Me.ОчиститьToolStripMenuItem.Name = "ОчиститьToolStripMenuItem"
        Me.ОчиститьToolStripMenuItem.Size = New System.Drawing.Size(99, 29)
        Me.ОчиститьToolStripMenuItem.Text = "Очистить"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(12, 36)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(1154, 566)
        Me.PB.TabIndex = 1
        Me.PB.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 631)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents РисованиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СолнышкоToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СолнышкоToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents МассивСолнышекToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СпиральСолнышекToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КорабликToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КорабликToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents МассивКорабликовToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СпиральКорабликовToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДомикToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДомикToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents МассивДомиковToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СпиральДомиковToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОчиститьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДействияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СолнышкоToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents КорабликToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ДомикToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PB As PictureBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Timer1 As Timer
End Class
