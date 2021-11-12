<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class caidat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(caidat))
        Me.lb_set = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ck_5 = New System.Windows.Forms.CheckBox()
        Me.ck_4 = New System.Windows.Forms.CheckBox()
        Me.ck_3 = New System.Windows.Forms.CheckBox()
        Me.ck_2 = New System.Windows.Forms.CheckBox()
        Me.ck_1 = New System.Windows.Forms.CheckBox()
        Me.bt_ok = New System.Windows.Forms.Button()
        Me.bt_canel = New System.Windows.Forms.Button()
        Me.p1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tg = New System.Windows.Forms.Label()
        Me.txt_ghichu = New System.Windows.Forms.TextBox()
        Me.lb_csdl = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_set
        '
        Me.lb_set.AutoSize = True
        Me.lb_set.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lb_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_set.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_set.ForeColor = System.Drawing.Color.White
        Me.lb_set.Location = New System.Drawing.Point(12, 9)
        Me.lb_set.Name = "lb_set"
        Me.lb_set.Size = New System.Drawing.Size(128, 39)
        Me.lb_set.TabIndex = 1
        Me.lb_set.Text = "Cài đặt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ck_5)
        Me.GroupBox1.Controls.Add(Me.ck_4)
        Me.GroupBox1.Controls.Add(Me.ck_3)
        Me.GroupBox1.Controls.Add(Me.ck_2)
        Me.GroupBox1.Controls.Add(Me.ck_1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 208)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thiết lập"
        '
        'ck_5
        '
        Me.ck_5.AutoSize = True
        Me.ck_5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_5.Location = New System.Drawing.Point(32, 157)
        Me.ck_5.Name = "ck_5"
        Me.ck_5.Size = New System.Drawing.Size(149, 23)
        Me.ck_5.TabIndex = 13
        Me.ck_5.Text = "Toàn màn hình"
        Me.ck_5.UseVisualStyleBackColor = True
        '
        'ck_4
        '
        Me.ck_4.AutoSize = True
        Me.ck_4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_4.Location = New System.Drawing.Point(32, 128)
        Me.ck_4.Name = "ck_4"
        Me.ck_4.Size = New System.Drawing.Size(138, 23)
        Me.ck_4.TabIndex = 12
        Me.ck_4.Text = "Tắt âm thanh"
        Me.ck_4.UseVisualStyleBackColor = True
        '
        'ck_3
        '
        Me.ck_3.AutoSize = True
        Me.ck_3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_3.Location = New System.Drawing.Point(32, 96)
        Me.ck_3.Name = "ck_3"
        Me.ck_3.Size = New System.Drawing.Size(237, 23)
        Me.ck_3.TabIndex = 11
        Me.ck_3.Text = "Hiện đáp án khi trả lời sai"
        Me.ck_3.UseVisualStyleBackColor = True
        '
        'ck_2
        '
        Me.ck_2.AutoSize = True
        Me.ck_2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_2.Location = New System.Drawing.Point(32, 67)
        Me.ck_2.Name = "ck_2"
        Me.ck_2.Size = New System.Drawing.Size(278, 23)
        Me.ck_2.TabIndex = 10
        Me.ck_2.Text = "Tự động trả lời câu hỏi sau 60s"
        Me.ck_2.UseVisualStyleBackColor = True
        '
        'ck_1
        '
        Me.ck_1.AutoSize = True
        Me.ck_1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_1.Location = New System.Drawing.Point(32, 38)
        Me.ck_1.Name = "ck_1"
        Me.ck_1.Size = New System.Drawing.Size(263, 23)
        Me.ck_1.TabIndex = 9
        Me.ck_1.Text = "Tự động sang câu hỏi kế tiếp"
        Me.ck_1.UseVisualStyleBackColor = True
        '
        'bt_ok
        '
        Me.bt_ok.BackColor = System.Drawing.Color.Aquamarine
        Me.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ok.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ok.Location = New System.Drawing.Point(158, 163)
        Me.bt_ok.Name = "bt_ok"
        Me.bt_ok.Size = New System.Drawing.Size(77, 39)
        Me.bt_ok.TabIndex = 4
        Me.bt_ok.Text = "&Lưu"
        Me.bt_ok.UseVisualStyleBackColor = False
        '
        'bt_canel
        '
        Me.bt_canel.BackColor = System.Drawing.Color.Aquamarine
        Me.bt_canel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_canel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_canel.Location = New System.Drawing.Point(241, 163)
        Me.bt_canel.Name = "bt_canel"
        Me.bt_canel.Size = New System.Drawing.Size(91, 39)
        Me.bt_canel.TabIndex = 3
        Me.bt_canel.Text = "&Trở Về"
        Me.bt_canel.UseVisualStyleBackColor = False
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.p1.Location = New System.Drawing.Point(1, 2)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(747, 57)
        Me.p1.TabIndex = 0
        Me.p1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(569, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Thông tin"
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.lb_csdl)
        Me.gb2.Controls.Add(Me.Label4)
        Me.gb2.Controls.Add(Me.Label3)
        Me.gb2.Controls.Add(Me.Label2)
        Me.gb2.Controls.Add(Me.bt_canel)
        Me.gb2.Controls.Add(Me.bt_ok)
        Me.gb2.Controls.Add(Me.tg)
        Me.gb2.Controls.Add(Me.txt_ghichu)
        Me.gb2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb2.Location = New System.Drawing.Point(393, 65)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(345, 208)
        Me.gb2.TabIndex = 7
        Me.gb2.TabStop = False
        Me.gb2.Text = "Giới thiệu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Sản phẩm dự thi: Tri thức trẻ vì giáo dục"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Liên hệ tác giả: trungnhan21.12@gmail.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Phiên bản client: 1.0.0"
        '
        'tg
        '
        Me.tg.AutoSize = True
        Me.tg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tg.Location = New System.Drawing.Point(11, 72)
        Me.tg.Name = "tg"
        Me.tg.Size = New System.Drawing.Size(172, 16)
        Me.tg.TabIndex = 9
        Me.tg.Text = "Tác giả: Nguyễn Trung Nhẫn"
        '
        'txt_ghichu
        '
        Me.txt_ghichu.BackColor = System.Drawing.Color.White
        Me.txt_ghichu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ghichu.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ghichu.Location = New System.Drawing.Point(15, 28)
        Me.txt_ghichu.Multiline = True
        Me.txt_ghichu.Name = "txt_ghichu"
        Me.txt_ghichu.ReadOnly = True
        Me.txt_ghichu.Size = New System.Drawing.Size(324, 41)
        Me.txt_ghichu.TabIndex = 8
        Me.txt_ghichu.Text = "Check Knowledge là phần mềm tạo các bài kiểm tra giúp cải thiện kiến thức!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lb_csdl
        '
        Me.lb_csdl.AutoSize = True
        Me.lb_csdl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_csdl.Location = New System.Drawing.Point(153, 92)
        Me.lb_csdl.Name = "lb_csdl"
        Me.lb_csdl.Size = New System.Drawing.Size(136, 16)
        Me.lb_csdl.TabIndex = 13
        Me.lb_csdl.Text = "Phiên bản CSDL: 1.0.0"
        '
        'caidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 285)
        Me.Controls.Add(Me.gb2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lb_set)
        Me.Controls.Add(Me.p1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "caidat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cài đặt"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents p1 As PictureBox
    Friend WithEvents lb_set As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bt_ok As Button
    Friend WithEvents ck_2 As CheckBox
    Friend WithEvents ck_1 As CheckBox
    Friend WithEvents ck_3 As CheckBox
    Friend WithEvents bt_canel As Button
    Friend WithEvents ck_4 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gb2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tg As Label
    Friend WithEvents txt_ghichu As TextBox
    Friend WithEvents ck_5 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_csdl As Label
End Class
