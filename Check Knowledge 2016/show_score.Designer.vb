<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class show_score
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(show_score))
        Me.p1 = New System.Windows.Forms.PictureBox()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.lb_diem_int = New System.Windows.Forms.Label()
        Me.int_score = New System.Windows.Forms.Timer(Me.components)
        Me.txt_get = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_end = New System.Windows.Forms.Label()
        Me.bt_next2 = New System.Windows.Forms.Button()
        Me.bt_next = New System.Windows.Forms.Button()
        Me.auto_ans = New System.Windows.Forms.Timer(Me.components)
        CType(Me.p1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.Aqua
        Me.p1.Location = New System.Drawing.Point(2, 1)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(515, 38)
        Me.p1.TabIndex = 0
        Me.p1.TabStop = False
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.Location = New System.Drawing.Point(178, 60)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(170, 25)
        Me.lb1.TabIndex = 1
        Me.lb1.Text = "ĐIỂM CỦA BẠN"
        '
        'lb_diem_int
        '
        Me.lb_diem_int.AutoSize = True
        Me.lb_diem_int.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_diem_int.Location = New System.Drawing.Point(212, 101)
        Me.lb_diem_int.Name = "lb_diem_int"
        Me.lb_diem_int.Size = New System.Drawing.Size(92, 45)
        Me.lb_diem_int.TabIndex = 2
        Me.lb_diem_int.Text = "006"
        Me.lb_diem_int.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'int_score
        '
        Me.int_score.Enabled = True
        Me.int_score.Interval = 60
        '
        'txt_get
        '
        Me.txt_get.AutoSize = True
        Me.txt_get.Location = New System.Drawing.Point(12, 54)
        Me.txt_get.Name = "txt_get"
        Me.txt_get.Size = New System.Drawing.Size(39, 13)
        Me.txt_get.TabIndex = 3
        Me.txt_get.Text = "txt_get"
        Me.txt_get.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hệ thống chấm điểm CKN"
        '
        'lb_end
        '
        Me.lb_end.AutoSize = True
        Me.lb_end.BackColor = System.Drawing.Color.White
        Me.lb_end.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_end.Location = New System.Drawing.Point(487, 9)
        Me.lb_end.Name = "lb_end"
        Me.lb_end.Size = New System.Drawing.Size(20, 19)
        Me.lb_end.TabIndex = 5
        Me.lb_end.Text = "X"
        '
        'bt_next2
        '
        Me.bt_next2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_next2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_next2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_next2.Location = New System.Drawing.Point(417, 168)
        Me.bt_next2.Name = "bt_next2"
        Me.bt_next2.Size = New System.Drawing.Size(90, 54)
        Me.bt_next2.TabIndex = 7
        Me.bt_next2.Text = "&Tiếp tục"
        Me.bt_next2.UseVisualStyleBackColor = False
        '
        'bt_next
        '
        Me.bt_next.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.bt_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_next.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_next.Location = New System.Drawing.Point(12, 168)
        Me.bt_next.Name = "bt_next"
        Me.bt_next.Size = New System.Drawing.Size(90, 54)
        Me.bt_next.TabIndex = 6
        Me.bt_next.Text = "&Làm lại"
        Me.bt_next.UseVisualStyleBackColor = False
        '
        'auto_ans
        '
        Me.auto_ans.Interval = 1200
        '
        'show_score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(519, 234)
        Me.Controls.Add(Me.bt_next2)
        Me.Controls.Add(Me.bt_next)
        Me.Controls.Add(Me.lb_end)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_get)
        Me.Controls.Add(Me.lb_diem_int)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.p1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "show_score"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông báo"
        Me.TopMost = True
        CType(Me.p1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents p1 As PictureBox
    Friend WithEvents lb1 As Label
    Friend WithEvents lb_diem_int As Label
    Friend WithEvents int_score As Timer
    Friend WithEvents txt_get As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_end As Label
    Friend WithEvents bt_next As Button
    Friend WithEvents bt_next2 As Button
    Friend WithEvents auto_ans As Timer
End Class
