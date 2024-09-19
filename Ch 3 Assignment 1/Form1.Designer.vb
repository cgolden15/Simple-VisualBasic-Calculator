<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.subBtn = New System.Windows.Forms.Button()
        Me.multBtn = New System.Windows.Forms.Button()
        Me.numOne = New System.Windows.Forms.TextBox()
        Me.numTwo = New System.Windows.Forms.TextBox()
        Me.formula = New System.Windows.Forms.TextBox()
        Me.result = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(330, 12)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(120, 114)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'subBtn
        '
        Me.subBtn.Location = New System.Drawing.Point(330, 143)
        Me.subBtn.Name = "subBtn"
        Me.subBtn.Size = New System.Drawing.Size(120, 114)
        Me.subBtn.TabIndex = 1
        Me.subBtn.Text = "Subtract"
        Me.subBtn.UseVisualStyleBackColor = True
        '
        'multBtn
        '
        Me.multBtn.Location = New System.Drawing.Point(330, 281)
        Me.multBtn.Name = "multBtn"
        Me.multBtn.Size = New System.Drawing.Size(120, 114)
        Me.multBtn.TabIndex = 2
        Me.multBtn.Text = "Multiply"
        Me.multBtn.UseVisualStyleBackColor = True
        '
        'numOne
        '
        Me.numOne.Location = New System.Drawing.Point(108, 106)
        Me.numOne.Name = "numOne"
        Me.numOne.Size = New System.Drawing.Size(56, 20)
        Me.numOne.TabIndex = 3
        '
        'numTwo
        '
        Me.numTwo.Location = New System.Drawing.Point(108, 191)
        Me.numTwo.Name = "numTwo"
        Me.numTwo.Size = New System.Drawing.Size(56, 20)
        Me.numTwo.TabIndex = 4
        '
        'formula
        '
        Me.formula.Enabled = False
        Me.formula.Location = New System.Drawing.Point(29, 303)
        Me.formula.Name = "formula"
        Me.formula.Size = New System.Drawing.Size(226, 20)
        Me.formula.TabIndex = 5
        '
        'result
        '
        Me.result.Enabled = False
        Me.result.Location = New System.Drawing.Point(29, 357)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(226, 20)
        Me.result.TabIndex = 6
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(68, 87)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(135, 13)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "First Number:"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(68, 172)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(135, 13)
        Me.TextBox6.TabIndex = 8
        Me.TextBox6.Text = "Second Number:"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(68, 284)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(135, 13)
        Me.TextBox7.TabIndex = 9
        Me.TextBox7.Text = "Formula & Result:"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(68, 338)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(135, 13)
        Me.TextBox8.TabIndex = 10
        Me.TextBox8.Text = "Result:"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(465, 416)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.formula)
        Me.Controls.Add(Me.numTwo)
        Me.Controls.Add(Me.numOne)
        Me.Controls.Add(Me.multBtn)
        Me.Controls.Add(Me.subBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents subBtn As Button
    Friend WithEvents multBtn As Button
    Friend WithEvents numOne As TextBox
    Friend WithEvents numTwo As TextBox
    Friend WithEvents formula As TextBox
    Friend WithEvents result As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
End Class
