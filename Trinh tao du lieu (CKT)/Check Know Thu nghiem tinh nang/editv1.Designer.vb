<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editv1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editv1))
        Me.numsv = New System.Windows.Forms.TextBox()
        Me.cauhoi = New System.Windows.Forms.TextBox()
        Me.dapan = New System.Windows.Forms.TextBox()
        Me.data = New System.Windows.Forms.TextBox()
        Me.bt_them = New System.Windows.Forms.Button()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.bt_sur = New System.Windows.Forms.Button()
        Me.ofile = New System.Windows.Forms.OpenFileDialog()
        Me.pathfile = New System.Windows.Forms.Label()
        Me.lb_sts = New System.Windows.Forms.Label()
        Me.sota = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TệpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TệpMớiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChỉnhSửaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DọnDẹpCácÔToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XóaDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TruyCậpTrìnhSửaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CôngCụToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TạoTrắcNghiệmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmCâuHỏiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'numsv
        '
        Me.numsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numsv.Location = New System.Drawing.Point(482, 9)
        Me.numsv.Multiline = True
        Me.numsv.Name = "numsv"
        Me.numsv.Size = New System.Drawing.Size(65, 30)
        Me.numsv.TabIndex = 3
        Me.numsv.Text = "-1"
        Me.numsv.Visible = False
        '
        'cauhoi
        '
        Me.cauhoi.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cauhoi.Location = New System.Drawing.Point(9, 19)
        Me.cauhoi.Multiline = True
        Me.cauhoi.Name = "cauhoi"
        Me.cauhoi.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.cauhoi.Size = New System.Drawing.Size(652, 58)
        Me.cauhoi.TabIndex = 4
        '
        'dapan
        '
        Me.dapan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dapan.Location = New System.Drawing.Point(9, 19)
        Me.dapan.Multiline = True
        Me.dapan.Name = "dapan"
        Me.dapan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.dapan.Size = New System.Drawing.Size(652, 82)
        Me.dapan.TabIndex = 5
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(12, 290)
        Me.data.Multiline = True
        Me.data.Name = "data"
        Me.data.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.data.Size = New System.Drawing.Size(849, 119)
        Me.data.TabIndex = 6
        Me.data.Visible = False
        '
        'bt_them
        '
        Me.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_them.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_them.Location = New System.Drawing.Point(565, 248)
        Me.bt_them.Name = "bt_them"
        Me.bt_them.Size = New System.Drawing.Size(127, 31)
        Me.bt_them.TabIndex = 8
        Me.bt_them.Text = "Thêm câu hỏi"
        Me.bt_them.UseVisualStyleBackColor = True
        '
        'bt_add
        '
        Me.bt_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add.Location = New System.Drawing.Point(553, 9)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(30, 30)
        Me.bt_add.TabIndex = 10
        Me.bt_add.Text = "+"
        Me.bt_add.UseVisualStyleBackColor = True
        Me.bt_add.Visible = False
        '
        'tm1
        '
        Me.tm1.Enabled = True
        Me.tm1.Interval = 10
        '
        'bt_sur
        '
        Me.bt_sur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_sur.Location = New System.Drawing.Point(589, 9)
        Me.bt_sur.Name = "bt_sur"
        Me.bt_sur.Size = New System.Drawing.Size(30, 30)
        Me.bt_sur.TabIndex = 14
        Me.bt_sur.Text = "-"
        Me.bt_sur.UseVisualStyleBackColor = True
        Me.bt_sur.Visible = False
        '
        'ofile
        '
        Me.ofile.FileName = "*.txt"
        '
        'pathfile
        '
        Me.pathfile.AutoSize = True
        Me.pathfile.Location = New System.Drawing.Point(635, 29)
        Me.pathfile.Name = "pathfile"
        Me.pathfile.Size = New System.Drawing.Size(28, 13)
        Me.pathfile.TabIndex = 15
        Me.pathfile.Text = "path"
        Me.pathfile.Visible = False
        '
        'lb_sts
        '
        Me.lb_sts.AutoSize = True
        Me.lb_sts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sts.Location = New System.Drawing.Point(21, 255)
        Me.lb_sts.Name = "lb_sts"
        Me.lb_sts.Size = New System.Drawing.Size(70, 16)
        Me.lb_sts.TabIndex = 18
        Me.lb_sts.Text = "thongbao"
        '
        'sota
        '
        Me.sota.AutoSize = True
        Me.sota.Location = New System.Drawing.Point(635, 9)
        Me.sota.Name = "sota"
        Me.sota.Size = New System.Drawing.Size(27, 13)
        Me.sota.TabIndex = 21
        Me.sota.Text = "sota"
        Me.sota.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TệpToolStripMenuItem, Me.ChỉnhSửaToolStripMenuItem, Me.CôngCụToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(704, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "menu_add"
        '
        'TệpToolStripMenuItem
        '
        Me.TệpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TệpMớiToolStripMenuItem, Me.ToolStripSeparator1, Me.ThoátToolStripMenuItem})
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
        Me.ChỉnhSửaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DọnDẹpCácÔToolStripMenuItem, Me.XóaDataToolStripMenuItem, Me.TruyCậpTrìnhSửaToolStripMenuItem})
        Me.ChỉnhSửaToolStripMenuItem.Name = "ChỉnhSửaToolStripMenuItem"
        Me.ChỉnhSửaToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ChỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa"
        '
        'DọnDẹpCácÔToolStripMenuItem
        '
        Me.DọnDẹpCácÔToolStripMenuItem.Name = "DọnDẹpCácÔToolStripMenuItem"
        Me.DọnDẹpCácÔToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.DọnDẹpCácÔToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DọnDẹpCácÔToolStripMenuItem.Text = "&Dọn dẹp các ô"
        '
        'XóaDataToolStripMenuItem
        '
        Me.XóaDataToolStripMenuItem.Name = "XóaDataToolStripMenuItem"
        Me.XóaDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.XóaDataToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.XóaDataToolStripMenuItem.Text = "&Xóa data"
        '
        'TruyCậpTrìnhSửaToolStripMenuItem
        '
        Me.TruyCậpTrìnhSửaToolStripMenuItem.Name = "TruyCậpTrìnhSửaToolStripMenuItem"
        Me.TruyCậpTrìnhSửaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.TruyCậpTrìnhSửaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.TruyCậpTrìnhSửaToolStripMenuItem.Text = "&Truy cập trình sửa"
        '
        'CôngCụToolStripMenuItem
        '
        Me.CôngCụToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TạoTrắcNghiệmToolStripMenuItem, Me.ThêmCâuHỏiToolStripMenuItem})
        Me.CôngCụToolStripMenuItem.Name = "CôngCụToolStripMenuItem"
        Me.CôngCụToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CôngCụToolStripMenuItem.Text = "Công cụ"
        '
        'TạoTrắcNghiệmToolStripMenuItem
        '
        Me.TạoTrắcNghiệmToolStripMenuItem.Name = "TạoTrắcNghiệmToolStripMenuItem"
        Me.TạoTrắcNghiệmToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.TạoTrắcNghiệmToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TạoTrắcNghiệmToolStripMenuItem.Text = "Tạo trắc nghiệm"
        '
        'ThêmCâuHỏiToolStripMenuItem
        '
        Me.ThêmCâuHỏiToolStripMenuItem.Name = "ThêmCâuHỏiToolStripMenuItem"
        Me.ThêmCâuHỏiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ThêmCâuHỏiToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ThêmCâuHỏiToolStripMenuItem.Text = "Thêm câu hỏi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cauhoi)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 97)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Câu hỏi"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dapan)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(677, 113)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Đáp án"
        '
        'editv1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 285)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.sota)
        Me.Controls.Add(Me.lb_sts)
        Me.Controls.Add(Me.pathfile)
        Me.Controls.Add(Me.bt_sur)
        Me.Controls.Add(Me.bt_add)
        Me.Controls.Add(Me.bt_them)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.numsv)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "editv1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trình tạo dữ liệu - Tạo câu hỏi tự luận - Thêm Data"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numsv As System.Windows.Forms.TextBox
    Friend WithEvents cauhoi As System.Windows.Forms.TextBox
    Friend WithEvents dapan As System.Windows.Forms.TextBox
    Friend WithEvents data As System.Windows.Forms.TextBox
    Friend WithEvents bt_them As System.Windows.Forms.Button
    Friend WithEvents bt_add As System.Windows.Forms.Button
    Friend WithEvents tm1 As Timer
    Friend WithEvents bt_sur As Button
    Friend WithEvents ofile As OpenFileDialog
    Friend WithEvents pathfile As Label
    Friend WithEvents lb_sts As Label
    Friend WithEvents sota As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TệpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TệpMớiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChỉnhSửaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DọnDẹpCácÔToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XóaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CôngCụToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TạoTrắcNghiệmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ThêmCâuHỏiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TruyCậpTrìnhSửaToolStripMenuItem As ToolStripMenuItem
End Class
