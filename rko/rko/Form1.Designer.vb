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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lb1 = New System.Windows.Forms.ListBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.lb2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1045, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 331)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ПОЕХАЛИ!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.FormattingEnabled = True
        Me.Lb1.ItemHeight = 20
        Me.Lb1.Location = New System.Drawing.Point(60, 53)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(590, 404)
        Me.Lb1.TabIndex = 1
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(716, 75)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(245, 26)
        Me.tb1.TabIndex = 2
        '
        'lb2
        '
        Me.lb2.FormattingEnabled = True
        Me.lb2.ItemHeight = 20
        Me.lb2.Location = New System.Drawing.Point(733, 131)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(238, 324)
        Me.lb2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 550)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Lb1 As ListBox
    Friend WithEvents tb1 As TextBox
    Friend WithEvents lb2 As ListBox
End Class
