﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ОткрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактированиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИдеальныйФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПАЛИНДРОМЫToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоискToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.МаксПредлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.lb2 = New System.Windows.Forms.ListBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.РедактированиеToolStripMenuItem, Me.ПоискToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1533, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ОткрытьToolStripMenuItem
        '
        Me.ОткрытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem"
        Me.ОткрытьToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ОткрытьToolStripMenuItem.Text = "Открыть"
        '
        'РедактированиеToolStripMenuItem
        '
        Me.РедактированиеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИдеальныйФайлToolStripMenuItem, Me.ПАЛИНДРОМЫToolStripMenuItem})
        Me.РедактированиеToolStripMenuItem.Name = "РедактированиеToolStripMenuItem"
        Me.РедактированиеToolStripMenuItem.Size = New System.Drawing.Size(158, 29)
        Me.РедактированиеToolStripMenuItem.Text = "Редактирование"
        '
        'ИдеальныйФайлToolStripMenuItem
        '
        Me.ИдеальныйФайлToolStripMenuItem.Name = "ИдеальныйФайлToolStripMenuItem"
        Me.ИдеальныйФайлToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ИдеальныйФайлToolStripMenuItem.Text = "Идеальный файл"
        '
        'ПАЛИНДРОМЫToolStripMenuItem
        '
        Me.ПАЛИНДРОМЫToolStripMenuItem.Name = "ПАЛИНДРОМЫToolStripMenuItem"
        Me.ПАЛИНДРОМЫToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ПАЛИНДРОМЫToolStripMenuItem.Text = "ПАЛИНДРОМЫ"
        '
        'ПоискToolStripMenuItem
        '
        Me.ПоискToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.МаксПредлToolStripMenuItem})
        Me.ПоискToolStripMenuItem.Name = "ПоискToolStripMenuItem"
        Me.ПоискToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
        Me.ПоискToolStripMenuItem.Text = "Поиск"
        '
        'МаксПредлToolStripMenuItem
        '
        Me.МаксПредлToolStripMenuItem.Name = "МаксПредлToolStripMenuItem"
        Me.МаксПредлToolStripMenuItem.Size = New System.Drawing.Size(200, 30)
        Me.МаксПредлToolStripMenuItem.Text = "Макс. предл."
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
        'lb1
        '
        Me.lb1.FormattingEnabled = True
        Me.lb1.ItemHeight = 20
        Me.lb1.Location = New System.Drawing.Point(12, 80)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(1397, 344)
        Me.lb1.TabIndex = 1
        '
        'lb2
        '
        Me.lb2.FormattingEnabled = True
        Me.lb2.ItemHeight = 20
        Me.lb2.Location = New System.Drawing.Point(12, 440)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(1397, 344)
        Me.lb2.TabIndex = 2
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(419, 47)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(739, 26)
        Me.tb.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1533, 789)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.lb2)
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

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РедактированиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПАЛИНДРОМЫToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПоискToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents МаксПредлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lb1 As ListBox
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lb2 As ListBox
    Friend WithEvents ИдеальныйФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tb As TextBox
End Class
