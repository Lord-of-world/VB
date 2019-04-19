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
        Me.BtnGO = New System.Windows.Forms.Button()
        Me.Lb1 = New System.Windows.Forms.ListBox()
        Me.Tb1 = New System.Windows.Forms.TextBox()
        Me.Lb2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnGO
        '
        Me.BtnGO.Location = New System.Drawing.Point(550, 48)
        Me.BtnGO.Name = "BtnGO"
        Me.BtnGO.Size = New System.Drawing.Size(238, 324)
        Me.BtnGO.TabIndex = 0
        Me.BtnGO.Text = "ПОЕХАЛИ!"
        Me.BtnGO.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.FormattingEnabled = True
        Me.Lb1.ItemHeight = 20
        Me.Lb1.Location = New System.Drawing.Point(12, 48)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(237, 324)
        Me.Lb1.TabIndex = 1
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(266, 48)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(237, 26)
        Me.Tb1.TabIndex = 2
        '
        'Lb2
        '
        Me.Lb2.FormattingEnabled = True
        Me.Lb2.ItemHeight = 20
        Me.Lb2.Location = New System.Drawing.Point(266, 88)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(237, 284)
        Me.Lb2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.BtnGO)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGO As Button
    Friend WithEvents Lb1 As ListBox
    Friend WithEvents Tb1 As TextBox
    Friend WithEvents Lb2 As ListBox
End Class
