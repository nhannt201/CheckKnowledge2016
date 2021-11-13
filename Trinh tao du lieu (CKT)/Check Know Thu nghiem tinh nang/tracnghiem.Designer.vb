<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tracnghiem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tracnghiem))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.slct4 = New System.Windows.Forms.TextBox()
        Me.slct3 = New System.Windows.Forms.TextBox()
        Me.slct2 = New System.Windows.Forms.TextBox()
        Me.slct1 = New System.Windows.Forms.TextBox()
        Me.dpd = New System.Windows.Forms.RadioButton()
        Me.dpa = New System.Windows.Forms.RadioButton()
        Me.dpc = New System.Windows.Forms.RadioButton()
        Me.dpb = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cauhoi = New System.Windows.Forms.TextBox()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.lb_sts = New System.Windows.Forms.Label()
        Me.TệpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TệpMớiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuayLạiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChỉnhSửaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LàmMớiKhungNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VàoTrìnhChỉnhSửaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CôngCụToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TạoCâuHỏiTựLuậnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmCâuHỏiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.bt_add)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 310)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nơi tạo dữ liệu"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.slct4)
        Me.GroupBox3.Controls.Add(Me.slct3)
        Me.GroupBox3.Controls.Add(Me.slct2)
        Me.GroupBox3.Controls.Add(Me.slct1)
        Me.GroupBox3.Controls.Add(Me.dpd)
        Me.GroupBox3.Controls.Add(Me.dpa)
        Me.GroupBox3.Controls.Add(Me.dpc)
        Me.GroupBox3.Controls.Add(Me.dpb)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(786, 145)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Đáp án"
        '
        'slct4
        '
        Me.slct4.Enabled = False
        Me.slct4.Location = New System.Drawing.Point(93, 109)
        Me.slct4.MaxLength = 5000
        Me.slct4.Name = "slct4"
        Me.slct4.Size = New System.Drawing.Size(687, 23)
        Me.slct4.TabIndex = 8
        '
        'slct3
        '
        Me.slct3.Enabled = False
        Me.slct3.Location = New System.Drawing.Point(93, 80)
        Me.slct3.MaxLength = 5000
        Me.slct3.Name = "slct3"
        Me.slct3.Size = New System.Drawing.Size(687, 23)
        Me.slct3.TabIndex = 7
        '
        'slct2
        '
        Me.slct2.Enabled = False
        Me.slct2.Location = New System.Drawing.Point(93, 51)
        Me.slct2.MaxLength = 5000
        Me.slct2.Name = "slct2"
        Me.slct2.Size = New System.Drawing.Size(687, 23)
        Me.slct2.TabIndex = 6
        '
        'slct1
        '
        Me.slct1.Location = New System.Drawing.Point(93, 22)
        Me.slct1.MaxLength = 5000
        Me.slct1.Name = "slct1"
        Me.slct1.Size = New System.Drawing.Size(687, 23)
        Me.slct1.TabIndex = 5
        '
        'dpd
        '
        Me.dpd.AutoSize = True
        Me.dpd.Enabled = False
        Me.dpd.Location = New System.Drawing.Point(16, 112)
        Me.dpd.Name = "dpd"
        Me.dpd.Size = New System.Drawing.Size(75, 20)
        Me.dpd.TabIndex = 4
        Me.dpd.TabStop = True
        Me.dpd.Text = "Chọn D."
        Me.dpd.UseVisualStyleBackColor = True
        '
        'dpa
        '
        Me.dpa.AutoSize = True
        Me.dpa.Enabled = False
        Me.dpa.Location = New System.Drawing.Point(16, 28)
        Me.dpa.Name = "dpa"
        Me.dpa.Size = New System.Drawing.Size(76, 20)
        Me.dpa.TabIndex = 1
        Me.dpa.TabStop = True
        Me.dpa.Text = "Chọn A."
        Me.dpa.UseVisualStyleBackColor = True
        '
        'dpc
        '
        Me.dpc.AutoSize = True
        Me.dpc.Enabled = False
        Me.dpc.Location = New System.Drawing.Point(15, 83)
        Me.dpc.Name = "dpc"
        Me.dpc.Size = New System.Drawing.Size(74, 20)
        Me.dpc.TabIndex = 3
        Me.dpc.TabStop = True
        Me.dpc.Text = "Chọn C."
        Me.dpc.UseVisualStyleBackColor = True
        '
        'dpb
        '
        Me.dpb.AutoSize = True
        Me.dpb.Enabled = False
        Me.dpb.Location = New System.Drawing.Point(16, 54)
        Me.dpb.Name = "dpb"
        Me.dpb.Size = New System.Drawing.Size(74, 20)
        Me.dpb.TabIndex = 2
        Me.dpb.TabStop = True
        Me.dpb.Text = "Chọn B."
        Me.dpb.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cauhoi)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 88)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Câu hỏi"
        '
        'cauhoi
        '
        Me.cauhoi.Location = New System.Drawing.Point(15, 22)
        Me.cauhoi.MaxLength = 10000
        Me.cauhoi.Multiline = True
        Me.cauhoi.Name = "cauhoi"
        Me.cauhoi.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.cauhoi.Size = New System.Drawing.Size(771, 56)
        Me.cauhoi.TabIndex = 0
        '
        'bt_add
        '
        Me.bt_add.BackColor = System.Drawing.Color.White
        Me.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_add.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add.Location = New System.Drawing.Point(15, 268)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(786, 32)
        Me.bt_add.TabIndex = 3
        Me.bt_add.Text = "&Thêm câu hỏi"
        Me.bt_add.UseVisualStyleBackColor = False
        '
        'lb_sts
        '
        Me.lb_sts.AutoSize = True
        Me.lb_sts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sts.Location = New System.Drawing.Point(24, 332)
        Me.lb_sts.Name = "lb_sts"
        Me.lb_sts.Size = New System.Drawing.Size(0, 16)
        Me.lb_sts.TabIndex = 6
        '
        'TệpToolStripMenuItem
        '
        Me.TệpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TệpMớiToolStripMenuItem, Me.QuayLạiToolStripMenuItem, Me.ToolStripSeparator1, Me.ThoátToolStripMenuItem})
        Me.TệpToolStripMenuItem.Name = "TệpToolStripMenuItem"
        Me.TệpToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.TệpToolStripMenuItem.Text = "Tệp"
        '
        'TệpMớiToolStripMenuItem
        '
        Me.TệpMớiToolStripMenuItem.Name = "TệpMớiToolStripMenuItem"
        Me.TệpMớiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.TệpMớiToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TệpMớiToolStripMenuItem.Text = "&Tệp mới"
        '
        'QuayLạiToolStripMenuItem
        '
        Me.QuayLạiToolStripMenuItem.Name = "QuayLạiToolStripMenuItem"
        Me.QuayLạiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.QuayLạiToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.QuayLạiToolStripMenuItem.Text = "&Quay lại"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ThoátToolStripMenuItem.Text = "&Thoát"
        '
        'ChỉnhSửaToolStripMenuItem
        '
        Me.ChỉnhSửaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LàmMớiKhungNhậpToolStripMenuItem, Me.VàoTrìnhChỉnhSửaToolStripMenuItem})
        Me.ChỉnhSửaToolStripMenuItem.Name = "ChỉnhSửaToolStripMenuItem"
        Me.ChỉnhSửaToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ChỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa"
        '
        'LàmMớiKhungNhậpToolStripMenuItem
        '
        Me.LàmMớiKhungNhậpToolStripMenuItem.Name = "LàmMớiKhungNhậpToolStripMenuItem"
        Me.LàmMớiKhungNhậpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.LàmMớiKhungNhậpToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.LàmMớiKhungNhậpToolStripMenuItem.Text = "&Làm mới khung nhập"
        '
        'VàoTrìnhChỉnhSửaToolStripMenuItem
        '
        Me.VàoTrìnhChỉnhSửaToolStripMenuItem.Name = "VàoTrìnhChỉnhSửaToolStripMenuItem"
        Me.VàoTrìnhChỉnhSửaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.VàoTrìnhChỉnhSửaToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.VàoTrìnhChỉnhSửaToolStripMenuItem.Text = "&Truy cập trình sửa"
        '
        'CôngCụToolStripMenuItem
        '
        Me.CôngCụToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TạoCâuHỏiTựLuậnToolStripMenuItem, Me.ThêmCâuHỏiToolStripMenuItem})
        Me.CôngCụToolStripMenuItem.Name = "CôngCụToolStripMenuItem"
        Me.CôngCụToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CôngCụToolStripMenuItem.Text = "Công cụ"
        '
        'TạoCâuHỏiTựLuậnToolStripMenuItem
        '
        Me.TạoCâuHỏiTựLuậnToolStripMenuItem.Name = "TạoCâuHỏiTựLuậnToolStripMenuItem"
        Me.TạoCâuHỏiTựLuậnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.TạoCâuHỏiTựLuậnToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.TạoCâuHỏiTựLuậnToolStripMenuItem.Text = "&Tạo câu hỏi tự luận"
        '
        'ThêmCâuHỏiToolStripMenuItem
        '
        Me.ThêmCâuHỏiToolStripMenuItem.Name = "ThêmCâuHỏiToolStripMenuItem"
        Me.ThêmCâuHỏiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ThêmCâuHỏiToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ThêmCâuHỏiToolStripMenuItem.Text = "Thêm câu hỏi"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TệpToolStripMenuItem, Me.ChỉnhSửaToolStripMenuItem, Me.CôngCụToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(845, 24)
        Me.MenuStrip2.TabIndex = 9
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'tracnghiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 353)
        Me.Controls.Add(Me.lb_sts)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "tracnghiem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trình tạo trắc nghiệm - Thêm Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cauhoi As TextBox
    Friend WithEvents dpd As RadioButton
    Friend WithEvents dpc As RadioButton
    Friend WithEvents dpb As RadioButton
    Friend WithEvents dpa As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents slct4 As TextBox
    Friend WithEvents slct3 As TextBox
    Friend WithEvents slct2 As TextBox
    Friend WithEvents slct1 As TextBox
    Friend WithEvents bt_add As Button
    Friend WithEvents lb_sts As Label
    Friend WithEvents TệpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TệpMớiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuayLạiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChỉnhSửaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LàmMớiKhungNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CôngCụToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TạoCâuHỏiTựLuậnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ThêmCâuHỏiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VàoTrìnhChỉnhSửaToolStripMenuItem As ToolStripMenuItem
End Class
