<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class win_share
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(win_share))
        Me.txt_dkup = New System.Windows.Forms.TextBox()
        Me.lb_dieukhoan = New System.Windows.Forms.Label()
        Me.kt_1 = New System.Windows.Forms.CheckBox()
        Me.kt_2 = New System.Windows.Forms.CheckBox()
        Me.txt_wait = New System.Windows.Forms.Label()
        Me.txt_path = New System.Windows.Forms.Label()
        Me.cmb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pb_line = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_line, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_dkup
        '
        Me.txt_dkup.BackColor = System.Drawing.Color.White
        Me.txt_dkup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dkup.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txt_dkup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dkup.Location = New System.Drawing.Point(12, 85)
        Me.txt_dkup.Multiline = True
        Me.txt_dkup.Name = "txt_dkup"
        Me.txt_dkup.ReadOnly = True
        Me.txt_dkup.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_dkup.Size = New System.Drawing.Size(516, 113)
        Me.txt_dkup.TabIndex = 0
        Me.txt_dkup.Text = resources.GetString("txt_dkup.Text")
        '
        'lb_dieukhoan
        '
        Me.lb_dieukhoan.AutoSize = True
        Me.lb_dieukhoan.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dieukhoan.Location = New System.Drawing.Point(150, 24)
        Me.lb_dieukhoan.Name = "lb_dieukhoan"
        Me.lb_dieukhoan.Size = New System.Drawing.Size(337, 23)
        Me.lb_dieukhoan.TabIndex = 1
        Me.lb_dieukhoan.Text = "Điều khoản dịch vụ chia sẻ dữ liệu"
        '
        'kt_1
        '
        Me.kt_1.AutoSize = True
        Me.kt_1.Location = New System.Drawing.Point(12, 242)
        Me.kt_1.Name = "kt_1"
        Me.kt_1.Size = New System.Drawing.Size(249, 17)
        Me.kt_1.TabIndex = 2
        Me.kt_1.Text = "Tôi đã đọc và đồng ý với các điều khoản trên."
        Me.kt_1.UseVisualStyleBackColor = True
        '
        'kt_2
        '
        Me.kt_2.AutoSize = True
        Me.kt_2.Location = New System.Drawing.Point(12, 265)
        Me.kt_2.Name = "kt_2"
        Me.kt_2.Size = New System.Drawing.Size(282, 17)
        Me.kt_2.TabIndex = 3
        Me.kt_2.Text = "Tôi đã đọc và không đồng ý với các điều khoản trên."
        Me.kt_2.UseVisualStyleBackColor = True
        '
        'txt_wait
        '
        Me.txt_wait.AutoSize = True
        Me.txt_wait.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_wait.Location = New System.Drawing.Point(130, 251)
        Me.txt_wait.Name = "txt_wait"
        Me.txt_wait.Size = New System.Drawing.Size(284, 16)
        Me.txt_wait.TabIndex = 4
        Me.txt_wait.Text = "Vui lòng chờ, dữ liệu của bạn được tải lên..."
        Me.txt_wait.Visible = False
        '
        'txt_path
        '
        Me.txt_path.AutoSize = True
        Me.txt_path.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_path.Location = New System.Drawing.Point(220, 267)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(54, 16)
        Me.txt_path.TabIndex = 5
        Me.txt_path.Text = "Address"
        Me.txt_path.Visible = False
        '
        'cmb
        '
        Me.cmb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb.FormattingEnabled = True
        Me.cmb.Location = New System.Drawing.Point(66, 215)
        Me.cmb.Name = "cmb"
        Me.cmb.Size = New System.Drawing.Size(174, 22)
        Me.cmb.TabIndex = 6
        Me.cmb.Text = "Chủ đề dữ liệu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Chủ đề:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'pb_line
        '
        Me.pb_line.BackColor = System.Drawing.Color.Black
        Me.pb_line.Location = New System.Drawing.Point(133, 7)
        Me.pb_line.Name = "pb_line"
        Me.pb_line.Size = New System.Drawing.Size(1, 71)
        Me.pb_line.TabIndex = 10
        Me.pb_line.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Chấp nhận điều khoản dưới đây để bắt đầu chia sẻ dữ liệu!"
        '
        'win_share
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 294)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_line)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.txt_wait)
        Me.Controls.Add(Me.kt_2)
        Me.Controls.Add(Me.kt_1)
        Me.Controls.Add(Me.lb_dieukhoan)
        Me.Controls.Add(Me.txt_dkup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "win_share"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chia sẻ dữ liệu"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_line, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_dkup As TextBox
    Friend WithEvents lb_dieukhoan As Label
    Friend WithEvents kt_1 As CheckBox
    Friend WithEvents kt_2 As CheckBox
    Friend WithEvents txt_wait As Label
    Friend WithEvents txt_path As Label
    Friend WithEvents cmb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pb_line As PictureBox
    Friend WithEvents Label1 As Label
End Class
