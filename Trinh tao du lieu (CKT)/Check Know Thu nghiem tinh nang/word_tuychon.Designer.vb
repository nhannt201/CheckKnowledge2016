<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class word_tuychon
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ck_2 = New System.Windows.Forms.CheckBox()
        Me.ck_1 = New System.Windows.Forms.CheckBox()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ck_2)
        Me.GroupBox1.Controls.Add(Me.ck_1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tùy chỉnh"
        '
        'ck_2
        '
        Me.ck_2.AutoSize = True
        Me.ck_2.Location = New System.Drawing.Point(23, 60)
        Me.ck_2.Name = "ck_2"
        Me.ck_2.Size = New System.Drawing.Size(103, 17)
        Me.ck_2.TabIndex = 3
        Me.ck_2.Text = "Giới hạn câu hỏi"
        Me.ck_2.UseVisualStyleBackColor = True
        '
        'ck_1
        '
        Me.ck_1.AutoSize = True
        Me.ck_1.Location = New System.Drawing.Point(23, 31)
        Me.ck_1.Name = "ck_1"
        Me.ck_1.Size = New System.Drawing.Size(86, 17)
        Me.ck_1.TabIndex = 0
        Me.ck_1.Text = "Trộn câu hỏi"
        Me.ck_1.UseVisualStyleBackColor = True
        '
        'txt_num
        '
        Me.txt_num.Enabled = False
        Me.txt_num.Location = New System.Drawing.Point(69, 27)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(178, 20)
        Me.txt_num.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Số câu:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_num)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(174, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 59)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Khung chỉnh"
        '
        'bt1
        '
        Me.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(174, 79)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(262, 27)
        Me.bt1.TabIndex = 6
        Me.bt1.Text = "&Lưu và xuất tệp"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'word_tuychon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 119)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "word_tuychon"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tùy chỉnh xuất Word"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ck_2 As CheckBox
    Friend WithEvents ck_1 As CheckBox
    Friend WithEvents txt_num As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents bt1 As Button
End Class
