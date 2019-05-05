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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.РисованиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СолнышкоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СолнышкоToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.МассивСолнышекToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КругСолнышекToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КорабликToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КорабликToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.МассивКорабликовToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КругКорабликовToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДомикToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДомикToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.МассивДомиковToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КругДомиковToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОчиститьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.РисованиеToolStripMenuItem, Me.ОчиститьToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1101, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 29)
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
        Me.СолнышкоToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СолнышкоToolStripMenuItem1, Me.МассивСолнышекToolStripMenuItem, Me.КругСолнышекToolStripMenuItem})
        Me.СолнышкоToolStripMenuItem.Name = "СолнышкоToolStripMenuItem"
        Me.СолнышкоToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.СолнышкоToolStripMenuItem.Text = "Солнышко"
        '
        'СолнышкоToolStripMenuItem1
        '
        Me.СолнышкоToolStripMenuItem1.Name = "СолнышкоToolStripMenuItem1"
        Me.СолнышкоToolStripMenuItem1.Size = New System.Drawing.Size(256, 30)
        Me.СолнышкоToolStripMenuItem1.Text = "Солнышко"
        '
        'МассивСолнышекToolStripMenuItem
        '
        Me.МассивСолнышекToolStripMenuItem.Name = "МассивСолнышекToolStripMenuItem"
        Me.МассивСолнышекToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.МассивСолнышекToolStripMenuItem.Text = "Массив Солнышек"
        '
        'КругСолнышекToolStripMenuItem
        '
        Me.КругСолнышекToolStripMenuItem.Name = "КругСолнышекToolStripMenuItem"
        Me.КругСолнышекToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.КругСолнышекToolStripMenuItem.Text = "Спираль Солнышек"
        '
        'КорабликToolStripMenuItem
        '
        Me.КорабликToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КорабликToolStripMenuItem1, Me.МассивКорабликовToolStripMenuItem, Me.КругКорабликовToolStripMenuItem})
        Me.КорабликToolStripMenuItem.Name = "КорабликToolStripMenuItem"
        Me.КорабликToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.КорабликToolStripMenuItem.Text = "Кораблик"
        '
        'КорабликToolStripMenuItem1
        '
        Me.КорабликToolStripMenuItem1.Name = "КорабликToolStripMenuItem1"
        Me.КорабликToolStripMenuItem1.Size = New System.Drawing.Size(261, 30)
        Me.КорабликToolStripMenuItem1.Text = "Кораблик"
        '
        'МассивКорабликовToolStripMenuItem
        '
        Me.МассивКорабликовToolStripMenuItem.Name = "МассивКорабликовToolStripMenuItem"
        Me.МассивКорабликовToolStripMenuItem.Size = New System.Drawing.Size(261, 30)
        Me.МассивКорабликовToolStripMenuItem.Text = "Массив корабликов"
        '
        'КругКорабликовToolStripMenuItem
        '
        Me.КругКорабликовToolStripMenuItem.Name = "КругКорабликовToolStripMenuItem"
        Me.КругКорабликовToolStripMenuItem.Size = New System.Drawing.Size(269, 30)
        Me.КругКорабликовToolStripMenuItem.Text = "Спираль корабликов"
        '
        'ДомикToolStripMenuItem
        '
        Me.ДомикToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДомикToolStripMenuItem1, Me.МассивДомиковToolStripMenuItem, Me.КругДомиковToolStripMenuItem})
        Me.ДомикToolStripMenuItem.Name = "ДомикToolStripMenuItem"
        Me.ДомикToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ДомикToolStripMenuItem.Text = "Домик"
        '
        'ДомикToolStripMenuItem1
        '
        Me.ДомикToolStripMenuItem1.Name = "ДомикToolStripMenuItem1"
        Me.ДомикToolStripMenuItem1.Size = New System.Drawing.Size(236, 30)
        Me.ДомикToolStripMenuItem1.Text = "Домик"
        '
        'МассивДомиковToolStripMenuItem
        '
        Me.МассивДомиковToolStripMenuItem.Name = "МассивДомиковToolStripMenuItem"
        Me.МассивДомиковToolStripMenuItem.Size = New System.Drawing.Size(236, 30)
        Me.МассивДомиковToolStripMenuItem.Text = "Массив домиков"
        '
        'КругДомиковToolStripMenuItem
        '
        Me.КругДомиковToolStripMenuItem.Name = "КругДомиковToolStripMenuItem"
        Me.КругДомиковToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.КругДомиковToolStripMenuItem.Text = "Спираль домиков"
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
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(12, 36)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(1077, 534)
        Me.pb.TabIndex = 1
        Me.pb.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 582)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents РисованиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОчиститьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pb As PictureBox
    Friend WithEvents СолнышкоToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СолнышкоToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents МассивСолнышекToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КругСолнышекToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КорабликToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КорабликToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents МассивКорабликовToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КругКорабликовToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДомикToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДомикToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents МассивДомиковToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КругДомиковToolStripMenuItem As ToolStripMenuItem
End Class
