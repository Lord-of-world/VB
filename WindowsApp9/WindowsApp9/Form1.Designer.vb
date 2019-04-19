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
        Me.СозданиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НетСтипендииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СозданиеToolStripMenuItem, Me.ОткрытиеToolStripMenuItem, Me.НетСтипендииToolStripMenuItem, Me.УдалениеToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1149, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'СозданиеToolStripMenuItem
        '
        Me.СозданиеToolStripMenuItem.Name = "СозданиеToolStripMenuItem"
        Me.СозданиеToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.СозданиеToolStripMenuItem.Text = "Создание"
        '
        'ОткрытиеToolStripMenuItem
        '
        Me.ОткрытиеToolStripMenuItem.Name = "ОткрытиеToolStripMenuItem"
        Me.ОткрытиеToolStripMenuItem.Size = New System.Drawing.Size(104, 29)
        Me.ОткрытиеToolStripMenuItem.Text = "Открытие"
        '
        'НетСтипендииToolStripMenuItem
        '
        Me.НетСтипендииToolStripMenuItem.Name = "НетСтипендииToolStripMenuItem"
        Me.НетСтипендииToolStripMenuItem.Size = New System.Drawing.Size(140, 29)
        Me.НетСтипендииToolStripMenuItem.Text = "НетСтипендии"
        '
        'УдалениеToolStripMenuItem
        '
        Me.УдалениеToolStripMenuItem.Name = "УдалениеToolStripMenuItem"
        Me.УдалениеToolStripMenuItem.Size = New System.Drawing.Size(100, 29)
        Me.УдалениеToolStripMenuItem.Text = "Удаление"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(76, 29)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(39, 249)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(343, 264)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(411, 249)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(343, 264)
        Me.ListBox2.TabIndex = 2
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(780, 249)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(343, 264)
        Me.ListBox3.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 633)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
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
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents СозданиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НетСтипендииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents УдалениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
End Class
