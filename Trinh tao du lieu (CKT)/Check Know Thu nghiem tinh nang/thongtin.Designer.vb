<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class thongtin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(thongtin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_share = New System.Windows.Forms.Button()
        Me.ck_ok = New System.Windows.Forms.CheckBox()
        Me.txt_mat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ghichu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.bt_new = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_share)
        Me.GroupBox1.Controls.Add(Me.ck_ok)
        Me.GroupBox1.Controls.Add(Me.txt_mat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_ghichu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_tg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin"
        '
        'bt_share
        '
        Me.bt_share.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_share.Location = New System.Drawing.Point(-26, 142)
        Me.bt_share.Name = "bt_share"
        Me.bt_share.Size = New System.Drawing.Size(109, 46)
        Me.bt_share.TabIndex = 4
        Me.bt_share.Text = "&Chia sẻ dữ liệu"
        Me.bt_share.UseVisualStyleBackColor = True
        Me.bt_share.Visible = False
        '
        'ck_ok
        '
        Me.ck_ok.AutoSize = True
        Me.ck_ok.Checked = True
        Me.ck_ok.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ck_ok.Location = New System.Drawing.Point(84, 194)
        Me.ck_ok.Name = "ck_ok"
        Me.ck_ok.Size = New System.Drawing.Size(222, 17)
        Me.ck_ok.TabIndex = 8
        Me.ck_ok.Text = "Cho phép xem đáp án khi trả lời sai"
        Me.ck_ok.UseVisualStyleBackColor = True
        Me.ck_ok.Visible = False
        '
        'txt_mat
        '
        Me.txt_mat.Location = New System.Drawing.Point(84, 75)
        Me.txt_mat.MaxLength = 300
        Me.txt_mat.Name = "txt_mat"
        Me.txt_mat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_mat.Size = New System.Drawing.Size(254, 21)
        Me.txt_mat.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mã bảo mật:"
        '
        'txt_ghichu
        '
        Me.txt_ghichu.Location = New System.Drawing.Point(84, 102)
        Me.txt_ghichu.MaxLength = 800
        Me.txt_ghichu.Multiline = True
        Me.txt_ghichu.Name = "txt_ghichu"
        Me.txt_ghichu.Size = New System.Drawing.Size(254, 86)
        Me.txt_ghichu.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ghi chú:"
        '
        'txt_tg
        '
        Me.txt_tg.Location = New System.Drawing.Point(84, 48)
        Me.txt_tg.MaxLength = 300
        Me.txt_tg.Name = "txt_tg"
        Me.txt_tg.Size = New System.Drawing.Size(254, 21)
        Me.txt_tg.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên tác giả:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(84, 22)
        Me.txt_name.MaxLength = 300
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(254, 21)
        Me.txt_name.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên dữ liệu:"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.Location = New System.Drawing.Point(26, 9)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(315, 24)
        Me.lb1.TabIndex = 1
        Me.lb1.Text = "Trình soạn trắc nghiệm && tự luận"
        '
        'bt_new
        '
        Me.bt_new.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_new.Location = New System.Drawing.Point(230, 238)
        Me.bt_new.Name = "bt_new"
        Me.bt_new.Size = New System.Drawing.Size(120, 46)
        Me.bt_new.TabIndex = 2
        Me.bt_new.Text = "&Tạo dữ liệu mới"
        Me.bt_new.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(96, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 46)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Chỉnh sửa dữ liệu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'thongtin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 291)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bt_new)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "thongtin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Trình biên soạn trắc nghiệm - CKT "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_ghichu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_tg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb1 As Label
    Friend WithEvents bt_new As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_mat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ck_ok As CheckBox
    Friend WithEvents bt_share As Button
End Class
