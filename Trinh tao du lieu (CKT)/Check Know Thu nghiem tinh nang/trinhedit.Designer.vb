<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class trinhedit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trinhedit))
        Me.grb1 = New System.Windows.Forms.GroupBox()
        Me.txt_num_next = New System.Windows.Forms.TextBox()
        Me.left_n = New System.Windows.Forms.Button()
        Me.right_n = New System.Windows.Forms.Button()
        Me.lst_cauhoi = New System.Windows.Forms.ListBox()
        Me.pathfile = New System.Windows.Forms.Label()
        Me.gothoi = New System.Windows.Forms.Timer(Me.components)
        Me.data = New System.Windows.Forms.TextBox()
        Me.tm_gettitle = New System.Windows.Forms.Timer(Me.components)
        Me.cauhoi = New System.Windows.Forms.TextBox()
        Me.grb2 = New System.Windows.Forms.GroupBox()
        Me.grb4 = New System.Windows.Forms.GroupBox()
        Me.lb4 = New System.Windows.Forms.Label()
        Me.txt_dap = New System.Windows.Forms.TextBox()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.lb5 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.dapantn = New System.Windows.Forms.ComboBox()
        Me.slct4 = New System.Windows.Forms.TextBox()
        Me.slct3 = New System.Windows.Forms.TextBox()
        Me.slct1 = New System.Windows.Forms.TextBox()
        Me.slct2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_hoi = New System.Windows.Forms.TextBox()
        Me.menu_edit = New System.Windows.Forms.MenuStrip()
        Me.TệpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TệpMớiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LưuLạiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChỉnhSửaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LàmMớiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.timkiem_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.thaythe_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.undo_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.undo_all = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmÔTrắcNghiệmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.xoacauhoi_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CôngCụToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemAddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.xuat_word = New System.Windows.Forms.ToolStripMenuItem()
        Me.TùyChỉnhXuấtWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bt_show = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.xam_note = New System.Windows.Forms.TextBox()
        Me.lb_sts = New System.Windows.Forms.Label()
        Me.grb1.SuspendLayout()
        Me.grb2.SuspendLayout()
        Me.grb4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.menu_edit.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb1
        '
        Me.grb1.Controls.Add(Me.txt_num_next)
        Me.grb1.Controls.Add(Me.left_n)
        Me.grb1.Controls.Add(Me.right_n)
        Me.grb1.Controls.Add(Me.lst_cauhoi)
        Me.grb1.Location = New System.Drawing.Point(10, 30)
        Me.grb1.Name = "grb1"
        Me.grb1.Size = New System.Drawing.Size(101, 380)
        Me.grb1.TabIndex = 23
        Me.grb1.TabStop = False
        Me.grb1.Text = "Câu hỏi của bạn"
        '
        'txt_num_next
        '
        Me.txt_num_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_next.Location = New System.Drawing.Point(30, 18)
        Me.txt_num_next.Name = "txt_num_next"
        Me.txt_num_next.Size = New System.Drawing.Size(41, 22)
        Me.txt_num_next.TabIndex = 33
        Me.txt_num_next.Text = "0"
        Me.txt_num_next.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'left_n
        '
        Me.left_n.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.left_n.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.left_n.Location = New System.Drawing.Point(6, 19)
        Me.left_n.Name = "left_n"
        Me.left_n.Size = New System.Drawing.Size(18, 21)
        Me.left_n.TabIndex = 25
        Me.left_n.Text = "<"
        Me.left_n.UseVisualStyleBackColor = True
        '
        'right_n
        '
        Me.right_n.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.right_n.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.right_n.Location = New System.Drawing.Point(77, 19)
        Me.right_n.Name = "right_n"
        Me.right_n.Size = New System.Drawing.Size(18, 21)
        Me.right_n.TabIndex = 10
        Me.right_n.Text = ">"
        Me.right_n.UseVisualStyleBackColor = True
        '
        'lst_cauhoi
        '
        Me.lst_cauhoi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_cauhoi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_cauhoi.FormattingEnabled = True
        Me.lst_cauhoi.Location = New System.Drawing.Point(6, 45)
        Me.lst_cauhoi.Name = "lst_cauhoi"
        Me.lst_cauhoi.Size = New System.Drawing.Size(89, 325)
        Me.lst_cauhoi.TabIndex = 24
        '
        'pathfile
        '
        Me.pathfile.AutoSize = True
        Me.pathfile.Location = New System.Drawing.Point(614, 14)
        Me.pathfile.Name = "pathfile"
        Me.pathfile.Size = New System.Drawing.Size(28, 13)
        Me.pathfile.TabIndex = 24
        Me.pathfile.Text = "path"
        Me.pathfile.Visible = False
        '
        'gothoi
        '
        Me.gothoi.Interval = 10
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(283, 19)
        Me.data.Multiline = True
        Me.data.Name = "data"
        Me.data.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.data.Size = New System.Drawing.Size(35, 23)
        Me.data.TabIndex = 25
        Me.data.Visible = False
        '
        'tm_gettitle
        '
        Me.tm_gettitle.Interval = 1
        '
        'cauhoi
        '
        Me.cauhoi.Location = New System.Drawing.Point(520, 19)
        Me.cauhoi.Multiline = True
        Me.cauhoi.Name = "cauhoi"
        Me.cauhoi.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.cauhoi.Size = New System.Drawing.Size(54, 23)
        Me.cauhoi.TabIndex = 26
        Me.cauhoi.Visible = False
        '
        'grb2
        '
        Me.grb2.Controls.Add(Me.grb4)
        Me.grb2.Controls.Add(Me.GroupBox3)
        Me.grb2.Location = New System.Drawing.Point(117, 48)
        Me.grb2.Name = "grb2"
        Me.grb2.Size = New System.Drawing.Size(614, 362)
        Me.grb2.TabIndex = 27
        Me.grb2.TabStop = False
        Me.grb2.Text = "Dữ liệu chỉnh sửa"
        '
        'grb4
        '
        Me.grb4.Controls.Add(Me.lb4)
        Me.grb4.Controls.Add(Me.txt_dap)
        Me.grb4.Controls.Add(Me.lb3)
        Me.grb4.Controls.Add(Me.lb5)
        Me.grb4.Controls.Add(Me.lb2)
        Me.grb4.Controls.Add(Me.lb1)
        Me.grb4.Controls.Add(Me.dapantn)
        Me.grb4.Controls.Add(Me.slct4)
        Me.grb4.Controls.Add(Me.slct3)
        Me.grb4.Controls.Add(Me.slct1)
        Me.grb4.Controls.Add(Me.slct2)
        Me.grb4.Location = New System.Drawing.Point(6, 179)
        Me.grb4.Name = "grb4"
        Me.grb4.Size = New System.Drawing.Size(602, 173)
        Me.grb4.TabIndex = 9
        Me.grb4.TabStop = False
        Me.grb4.Text = "Đáp án"
        '
        'lb4
        '
        Me.lb4.AutoSize = True
        Me.lb4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb4.Location = New System.Drawing.Point(13, 106)
        Me.lb4.Name = "lb4"
        Me.lb4.Size = New System.Drawing.Size(41, 13)
        Me.lb4.TabIndex = 37
        Me.lb4.Text = "Câu C:"
        Me.lb4.Visible = False
        '
        'txt_dap
        '
        Me.txt_dap.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dap.Location = New System.Drawing.Point(6, 14)
        Me.txt_dap.Multiline = True
        Me.txt_dap.Name = "txt_dap"
        Me.txt_dap.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_dap.Size = New System.Drawing.Size(590, 153)
        Me.txt_dap.TabIndex = 7
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb3.Location = New System.Drawing.Point(13, 79)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(41, 13)
        Me.lb3.TabIndex = 36
        Me.lb3.Text = "Câu B:"
        Me.lb3.Visible = False
        '
        'lb5
        '
        Me.lb5.AutoSize = True
        Me.lb5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb5.Location = New System.Drawing.Point(13, 137)
        Me.lb5.Name = "lb5"
        Me.lb5.Size = New System.Drawing.Size(42, 13)
        Me.lb5.TabIndex = 36
        Me.lb5.Text = "Câu D:"
        Me.lb5.Visible = False
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb2.Location = New System.Drawing.Point(13, 50)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(42, 13)
        Me.lb2.TabIndex = 35
        Me.lb2.Text = "Câu A:"
        Me.lb2.Visible = False
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.Location = New System.Drawing.Point(16, 24)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(38, 13)
        Me.lb1.TabIndex = 34
        Me.lb1.Text = "Chọn:"
        Me.lb1.Visible = False
        '
        'dapantn
        '
        Me.dapantn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dapantn.ForeColor = System.Drawing.Color.Blue
        Me.dapantn.FormattingEnabled = True
        Me.dapantn.Location = New System.Drawing.Point(60, 16)
        Me.dapantn.MaxDropDownItems = 5
        Me.dapantn.MaxLength = 1
        Me.dapantn.Name = "dapantn"
        Me.dapantn.Size = New System.Drawing.Size(114, 24)
        Me.dapantn.TabIndex = 33
        Me.dapantn.Visible = False
        '
        'slct4
        '
        Me.slct4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slct4.Location = New System.Drawing.Point(60, 130)
        Me.slct4.MaxLength = 5000
        Me.slct4.Name = "slct4"
        Me.slct4.Size = New System.Drawing.Size(520, 23)
        Me.slct4.TabIndex = 32
        Me.slct4.Visible = False
        '
        'slct3
        '
        Me.slct3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slct3.Location = New System.Drawing.Point(60, 101)
        Me.slct3.MaxLength = 5000
        Me.slct3.Name = "slct3"
        Me.slct3.Size = New System.Drawing.Size(520, 23)
        Me.slct3.TabIndex = 31
        Me.slct3.Visible = False
        '
        'slct1
        '
        Me.slct1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slct1.Location = New System.Drawing.Point(60, 43)
        Me.slct1.MaxLength = 5000
        Me.slct1.Name = "slct1"
        Me.slct1.Size = New System.Drawing.Size(520, 23)
        Me.slct1.TabIndex = 29
        Me.slct1.Visible = False
        '
        'slct2
        '
        Me.slct2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slct2.Location = New System.Drawing.Point(60, 72)
        Me.slct2.MaxLength = 5000
        Me.slct2.Name = "slct2"
        Me.slct2.Size = New System.Drawing.Size(520, 23)
        Me.slct2.TabIndex = 30
        Me.slct2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_hoi)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(602, 154)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Câu hỏi"
        '
        'txt_hoi
        '
        Me.txt_hoi.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hoi.Location = New System.Drawing.Point(6, 19)
        Me.txt_hoi.Multiline = True
        Me.txt_hoi.Name = "txt_hoi"
        Me.txt_hoi.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_hoi.Size = New System.Drawing.Size(590, 129)
        Me.txt_hoi.TabIndex = 5
        '
        'menu_edit
        '
        Me.menu_edit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TệpToolStripMenuItem, Me.ChỉnhSửaToolStripMenuItem, Me.CôngCụToolStripMenuItem})
        Me.menu_edit.Location = New System.Drawing.Point(0, 0)
        Me.menu_edit.Name = "menu_edit"
        Me.menu_edit.Size = New System.Drawing.Size(743, 24)
        Me.menu_edit.TabIndex = 28
        Me.menu_edit.Text = "MenuStrip1"
        '
        'TệpToolStripMenuItem
        '
        Me.TệpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TệpMớiToolStripMenuItem, Me.LưuLạiToolStripMenuItem, Me.ToolStripSeparator1, Me.ThoátToolStripMenuItem})
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
        'LưuLạiToolStripMenuItem
        '
        Me.LưuLạiToolStripMenuItem.Name = "LưuLạiToolStripMenuItem"
        Me.LưuLạiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.LưuLạiToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.LưuLạiToolStripMenuItem.Text = "&Lưu lại"
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
        Me.ChỉnhSửaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LàmMớiToolStripMenuItem, Me.ToolStripSeparator2, Me.timkiem_menu, Me.thaythe_menu, Me.ToolStripSeparator3, Me.undo_menu, Me.undo_all, Me.ThêmÔTrắcNghiệmToolStripMenuItem, Me.xoacauhoi_menu})
        Me.ChỉnhSửaToolStripMenuItem.Name = "ChỉnhSửaToolStripMenuItem"
        Me.ChỉnhSửaToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ChỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa"
        '
        'LàmMớiToolStripMenuItem
        '
        Me.LàmMớiToolStripMenuItem.Name = "LàmMớiToolStripMenuItem"
        Me.LàmMớiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.LàmMớiToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.LàmMớiToolStripMenuItem.Text = "&Làm mới"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(204, 6)
        '
        'timkiem_menu
        '
        Me.timkiem_menu.Name = "timkiem_menu"
        Me.timkiem_menu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.timkiem_menu.Size = New System.Drawing.Size(207, 22)
        Me.timkiem_menu.Text = "&Tìm kiếm"
        '
        'thaythe_menu
        '
        Me.thaythe_menu.Name = "thaythe_menu"
        Me.thaythe_menu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.thaythe_menu.Size = New System.Drawing.Size(207, 22)
        Me.thaythe_menu.Text = "&Thay thế"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(204, 6)
        '
        'undo_menu
        '
        Me.undo_menu.Name = "undo_menu"
        Me.undo_menu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.undo_menu.Size = New System.Drawing.Size(207, 22)
        Me.undo_menu.Text = "&Hoàn tác câu hỏi"
        '
        'undo_all
        '
        Me.undo_all.Name = "undo_all"
        Me.undo_all.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.undo_all.Size = New System.Drawing.Size(207, 22)
        Me.undo_all.Text = "Hoàn tác tất cả"
        '
        'ThêmÔTrắcNghiệmToolStripMenuItem
        '
        Me.ThêmÔTrắcNghiệmToolStripMenuItem.Enabled = False
        Me.ThêmÔTrắcNghiệmToolStripMenuItem.Name = "ThêmÔTrắcNghiệmToolStripMenuItem"
        Me.ThêmÔTrắcNghiệmToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.ThêmÔTrắcNghiệmToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ThêmÔTrắcNghiệmToolStripMenuItem.Text = "Thêm ô trắc nghiệm"
        '
        'xoacauhoi_menu
        '
        Me.xoacauhoi_menu.Name = "xoacauhoi_menu"
        Me.xoacauhoi_menu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.xoacauhoi_menu.Size = New System.Drawing.Size(207, 22)
        Me.xoacauhoi_menu.Text = "Xóa câu hỏi"
        '
        'CôngCụToolStripMenuItem
        '
        Me.CôngCụToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemAddToolStripMenuItem, Me.ToolStripSeparator4, Me.xuat_word, Me.TùyChỉnhXuấtWordToolStripMenuItem})
        Me.CôngCụToolStripMenuItem.Name = "CôngCụToolStripMenuItem"
        Me.CôngCụToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CôngCụToolStripMenuItem.Text = "Công cụ"
        '
        'ThemAddToolStripMenuItem
        '
        Me.ThemAddToolStripMenuItem.Name = "ThemAddToolStripMenuItem"
        Me.ThemAddToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ThemAddToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ThemAddToolStripMenuItem.Text = "&Thêm câu hỏi và trắc nghiệm"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(245, 6)
        '
        'xuat_word
        '
        Me.xuat_word.Name = "xuat_word"
        Me.xuat_word.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.xuat_word.Size = New System.Drawing.Size(248, 22)
        Me.xuat_word.Text = "&Xuất ra file Word"
        '
        'TùyChỉnhXuấtWordToolStripMenuItem
        '
        Me.TùyChỉnhXuấtWordToolStripMenuItem.Name = "TùyChỉnhXuấtWordToolStripMenuItem"
        Me.TùyChỉnhXuấtWordToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.TùyChỉnhXuấtWordToolStripMenuItem.Text = "&Tùy chỉnh xuất Word"
        '
        'bt_show
        '
        Me.bt_show.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_show.Location = New System.Drawing.Point(636, 0)
        Me.bt_show.Name = "bt_show"
        Me.bt_show.Size = New System.Drawing.Size(107, 24)
        Me.bt_show.TabIndex = 29
        Me.bt_show.Text = "&Mở cửa sổ"
        Me.bt_show.UseVisualStyleBackColor = True
        Me.bt_show.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(415, 27)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(35, 23)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.Visible = False
        '
        'xam_note
        '
        Me.xam_note.Location = New System.Drawing.Point(482, 23)
        Me.xam_note.Name = "xam_note"
        Me.xam_note.Size = New System.Drawing.Size(12, 20)
        Me.xam_note.TabIndex = 31
        Me.xam_note.Visible = False
        '
        'lb_sts
        '
        Me.lb_sts.AutoSize = True
        Me.lb_sts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sts.Location = New System.Drawing.Point(12, 413)
        Me.lb_sts.Name = "lb_sts"
        Me.lb_sts.Size = New System.Drawing.Size(105, 16)
        Me.lb_sts.TabIndex = 32
        Me.lb_sts.Text = "Tình trạng: Mới"
        '
        'trinhedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 438)
        Me.Controls.Add(Me.lb_sts)
        Me.Controls.Add(Me.xam_note)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bt_show)
        Me.Controls.Add(Me.grb2)
        Me.Controls.Add(Me.cauhoi)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.pathfile)
        Me.Controls.Add(Me.grb1)
        Me.Controls.Add(Me.menu_edit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu_edit
        Me.MaximizeBox = False
        Me.Name = "trinhedit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trình chỉnh sửa dữ liệu"
        Me.grb1.ResumeLayout(False)
        Me.grb1.PerformLayout()
        Me.grb2.ResumeLayout(False)
        Me.grb4.ResumeLayout(False)
        Me.grb4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.menu_edit.ResumeLayout(False)
        Me.menu_edit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb1 As GroupBox
    Friend WithEvents lst_cauhoi As ListBox
    Friend WithEvents pathfile As Label
    Friend WithEvents gothoi As Timer
    Friend WithEvents data As TextBox
    Friend WithEvents tm_gettitle As Timer
    Friend WithEvents cauhoi As TextBox
    Friend WithEvents grb2 As GroupBox
    Friend WithEvents txt_dap As TextBox
    Friend WithEvents txt_hoi As TextBox
    Friend WithEvents menu_edit As MenuStrip
    Friend WithEvents TệpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TệpMớiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChỉnhSửaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LàmMớiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CôngCụToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemAddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LưuLạiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grb4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dapantn As ComboBox
    Friend WithEvents slct4 As TextBox
    Friend WithEvents slct3 As TextBox
    Friend WithEvents slct1 As TextBox
    Friend WithEvents slct2 As TextBox
    Friend WithEvents lb1 As Label
    Friend WithEvents lb4 As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents lb5 As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents timkiem_menu As ToolStripMenuItem
    Friend WithEvents thaythe_menu As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents undo_menu As ToolStripMenuItem
    Friend WithEvents bt_show As Button
    Friend WithEvents undo_all As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents xuat_word As ToolStripMenuItem
    Friend WithEvents xam_note As TextBox
    Friend WithEvents ThêmÔTrắcNghiệmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TùyChỉnhXuấtWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents xoacauhoi_menu As ToolStripMenuItem
    Friend WithEvents lb_sts As Label
    Friend WithEvents txt_num_next As TextBox
    Friend WithEvents left_n As Button
    Friend WithEvents right_n As Button
End Class
