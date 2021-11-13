<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test_open_sua
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(test_open_sua))
        Me.px1 = New System.Windows.Forms.PictureBox()
        Me.lb_sts = New System.Windows.Forms.Label()
        Me.ck1 = New System.Windows.Forms.CheckBox()
        Me.bt_tracnghiem = New System.Windows.Forms.Button()
        Me.pathfile = New System.Windows.Forms.Label()
        Me.ofile = New System.Windows.Forms.OpenFileDialog()
        Me.bt_sur = New System.Windows.Forms.Button()
        Me.tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_del = New System.Windows.Forms.Button()
        Me.bt_reset = New System.Windows.Forms.Button()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.bt_them = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.TextBox()
        Me.dapan = New System.Windows.Forms.TextBox()
        Me.cauhoi = New System.Windows.Forms.TextBox()
        Me.numsv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.px1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'px1
        '
        Me.px1.BackColor = System.Drawing.Color.Blue
        Me.px1.Location = New System.Drawing.Point(15, 38)
        Me.px1.Name = "px1"
        Me.px1.Size = New System.Drawing.Size(229, 5)
        Me.px1.TabIndex = 38
        Me.px1.TabStop = False
        '
        'lb_sts
        '
        Me.lb_sts.AutoSize = True
        Me.lb_sts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sts.Location = New System.Drawing.Point(286, 45)
        Me.lb_sts.Name = "lb_sts"
        Me.lb_sts.Size = New System.Drawing.Size(0, 16)
        Me.lb_sts.TabIndex = 37
        '
        'ck1
        '
        Me.ck1.AutoSize = True
        Me.ck1.Location = New System.Drawing.Point(12, 328)
        Me.ck1.Name = "ck1"
        Me.ck1.Size = New System.Drawing.Size(139, 30)
        Me.ck1.TabIndex = 36
        Me.ck1.Text = "Thêm câu hỏi khi Enter " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tại ô đáp án"
        Me.ck1.UseVisualStyleBackColor = True
        '
        'bt_tracnghiem
        '
        Me.bt_tracnghiem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tracnghiem.Location = New System.Drawing.Point(169, 325)
        Me.bt_tracnghiem.Name = "bt_tracnghiem"
        Me.bt_tracnghiem.Size = New System.Drawing.Size(117, 31)
        Me.bt_tracnghiem.TabIndex = 35
        Me.bt_tracnghiem.Text = "Tạo trắc nghiệm"
        Me.bt_tracnghiem.UseVisualStyleBackColor = True
        '
        'pathfile
        '
        Me.pathfile.AutoSize = True
        Me.pathfile.Location = New System.Drawing.Point(565, 48)
        Me.pathfile.Name = "pathfile"
        Me.pathfile.Size = New System.Drawing.Size(28, 13)
        Me.pathfile.TabIndex = 34
        Me.pathfile.Text = "path"
        Me.pathfile.Visible = False
        '
        'ofile
        '
        Me.ofile.FileName = "*.txt"
        '
        'bt_sur
        '
        Me.bt_sur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_sur.Location = New System.Drawing.Point(210, 10)
        Me.bt_sur.Name = "bt_sur"
        Me.bt_sur.Size = New System.Drawing.Size(30, 30)
        Me.bt_sur.TabIndex = 33
        Me.bt_sur.Text = "-"
        Me.bt_sur.UseVisualStyleBackColor = True
        Me.bt_sur.Visible = False
        '
        'tm1
        '
        Me.tm1.Enabled = True
        Me.tm1.Interval = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 25)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Trình tạo câu hỏi"
        '
        'bt_del
        '
        Me.bt_del.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_del.Location = New System.Drawing.Point(424, 325)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.Size = New System.Drawing.Size(136, 31)
        Me.bt_del.TabIndex = 32
        Me.bt_del.Text = "Xoá data"
        Me.bt_del.UseVisualStyleBackColor = True
        '
        'bt_reset
        '
        Me.bt_reset.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_reset.Location = New System.Drawing.Point(292, 325)
        Me.bt_reset.Name = "bt_reset"
        Me.bt_reset.Size = New System.Drawing.Size(126, 31)
        Me.bt_reset.TabIndex = 31
        Me.bt_reset.Text = "Dọn dẹp các ô"
        Me.bt_reset.UseVisualStyleBackColor = True
        '
        'bt_add
        '
        Me.bt_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add.Location = New System.Drawing.Point(125, 17)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(30, 30)
        Me.bt_add.TabIndex = 30
        Me.bt_add.Text = "+"
        Me.bt_add.UseVisualStyleBackColor = True
        Me.bt_add.Visible = False
        '
        'bt_them
        '
        Me.bt_them.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_them.Location = New System.Drawing.Point(568, 325)
        Me.bt_them.Name = "bt_them"
        Me.bt_them.Size = New System.Drawing.Size(127, 31)
        Me.bt_them.TabIndex = 29
        Me.bt_them.Text = "Thêm câu hỏi"
        Me.bt_them.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Data"
        Me.Label4.Visible = False
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(12, 331)
        Me.data.Multiline = True
        Me.data.Name = "data"
        Me.data.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.data.Size = New System.Drawing.Size(849, 119)
        Me.data.TabIndex = 27
        Me.data.Visible = False
        '
        'dapan
        '
        Me.dapan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dapan.Location = New System.Drawing.Point(12, 204)
        Me.dapan.Multiline = True
        Me.dapan.Name = "dapan"
        Me.dapan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.dapan.Size = New System.Drawing.Size(680, 115)
        Me.dapan.TabIndex = 26
        '
        'cauhoi
        '
        Me.cauhoi.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cauhoi.Location = New System.Drawing.Point(12, 67)
        Me.cauhoi.Multiline = True
        Me.cauhoi.Name = "cauhoi"
        Me.cauhoi.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.cauhoi.Size = New System.Drawing.Size(680, 115)
        Me.cauhoi.TabIndex = 25
        '
        'numsv
        '
        Me.numsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numsv.Location = New System.Drawing.Point(54, 17)
        Me.numsv.Multiline = True
        Me.numsv.Name = "numsv"
        Me.numsv.Size = New System.Drawing.Size(65, 30)
        Me.numsv.TabIndex = 24
        Me.numsv.Text = "-1"
        Me.numsv.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Đáp án"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Câu hỏi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Mã số"
        Me.Label1.Visible = False
        '
        'open_sua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 366)
        Me.Controls.Add(Me.px1)
        Me.Controls.Add(Me.lb_sts)
        Me.Controls.Add(Me.ck1)
        Me.Controls.Add(Me.bt_tracnghiem)
        Me.Controls.Add(Me.pathfile)
        Me.Controls.Add(Me.bt_sur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_del)
        Me.Controls.Add(Me.bt_reset)
        Me.Controls.Add(Me.bt_add)
        Me.Controls.Add(Me.bt_them)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.dapan)
        Me.Controls.Add(Me.cauhoi)
        Me.Controls.Add(Me.numsv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "open_sua"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trình sửa dữ liệu"
        CType(Me.px1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents px1 As PictureBox
    Friend WithEvents lb_sts As Label
    Friend WithEvents ck1 As CheckBox
    Friend WithEvents bt_tracnghiem As Button
    Friend WithEvents pathfile As Label
    Friend WithEvents ofile As OpenFileDialog
    Friend WithEvents bt_sur As Button
    Friend WithEvents tm1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_del As Button
    Friend WithEvents bt_reset As Button
    Friend WithEvents bt_add As Button
    Friend WithEvents bt_them As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents data As TextBox
    Friend WithEvents dapan As TextBox
    Friend WithEvents cauhoi As TextBox
    Friend WithEvents numsv As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
