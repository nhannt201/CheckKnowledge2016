<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lib_online
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lib_online))
        Me.pn_1 = New System.Windows.Forms.Panel()
        Me.lb_dw = New System.Windows.Forms.Label()
        Me.title_fr = New System.Windows.Forms.Label()
        Me.listonline = New System.Windows.Forms.ListBox()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_q = New System.Windows.Forms.TextBox()
        Me.bt_q = New System.Windows.Forms.Button()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.bt_back = New System.Windows.Forms.Button()
        Me.bt_open = New System.Windows.Forms.Button()
        Me.bt_del = New System.Windows.Forms.Button()
        Me.lst_down = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_dw = New System.Windows.Forms.Button()
        Me.cbx = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pn_1.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pn_1
        '
        Me.pn_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pn_1.Controls.Add(Me.lb_dw)
        Me.pn_1.Controls.Add(Me.title_fr)
        Me.pn_1.Location = New System.Drawing.Point(0, -1)
        Me.pn_1.Name = "pn_1"
        Me.pn_1.Size = New System.Drawing.Size(826, 42)
        Me.pn_1.TabIndex = 0
        '
        'lb_dw
        '
        Me.lb_dw.AutoSize = True
        Me.lb_dw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dw.ForeColor = System.Drawing.Color.White
        Me.lb_dw.Location = New System.Drawing.Point(338, 17)
        Me.lb_dw.Name = "lb_dw"
        Me.lb_dw.Size = New System.Drawing.Size(95, 16)
        Me.lb_dw.TabIndex = 1
        Me.lb_dw.Text = "Đang tải về..."
        Me.lb_dw.Visible = False
        '
        'title_fr
        '
        Me.title_fr.AutoSize = True
        Me.title_fr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_fr.ForeColor = System.Drawing.Color.White
        Me.title_fr.Location = New System.Drawing.Point(25, 10)
        Me.title_fr.Name = "title_fr"
        Me.title_fr.Size = New System.Drawing.Size(318, 25)
        Me.title_fr.TabIndex = 0
        Me.title_fr.Text = "Thư viện kiến thức trực tuyến"
        '
        'listonline
        '
        Me.listonline.FormattingEnabled = True
        Me.listonline.HorizontalScrollbar = True
        Me.listonline.Location = New System.Drawing.Point(8, 19)
        Me.listonline.Name = "listonline"
        Me.listonline.ScrollAlwaysVisible = True
        Me.listonline.Size = New System.Drawing.Size(388, 134)
        Me.listonline.TabIndex = 1
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(8, 236)
        Me.txt_mota.Multiline = True
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.ReadOnly = True
        Me.txt_mota.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_mota.Size = New System.Drawing.Size(389, 54)
        Me.txt_mota.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Thông tin dữ liệu"
        '
        'txt_q
        '
        Me.txt_q.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_q.Location = New System.Drawing.Point(8, 185)
        Me.txt_q.Multiline = True
        Me.txt_q.Name = "txt_q"
        Me.txt_q.Size = New System.Drawing.Size(245, 29)
        Me.txt_q.TabIndex = 5
        '
        'bt_q
        '
        Me.bt_q.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_q.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_q.Location = New System.Drawing.Point(259, 185)
        Me.bt_q.Name = "bt_q"
        Me.bt_q.Size = New System.Drawing.Size(72, 29)
        Me.bt_q.TabIndex = 6
        Me.bt_q.Text = "&Tìm kiếm"
        Me.bt_q.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.bt_back)
        Me.gb1.Controls.Add(Me.bt_open)
        Me.gb1.Controls.Add(Me.bt_del)
        Me.gb1.Controls.Add(Me.lst_down)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Location = New System.Drawing.Point(420, 54)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(385, 299)
        Me.gb1.TabIndex = 7
        Me.gb1.TabStop = False
        Me.gb1.Text = "Dữ liệu đã tải"
        '
        'bt_back
        '
        Me.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_back.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_back.Location = New System.Drawing.Point(274, 246)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(105, 39)
        Me.bt_back.TabIndex = 11
        Me.bt_back.Text = "&Quay lại"
        Me.bt_back.UseVisualStyleBackColor = True
        '
        'bt_open
        '
        Me.bt_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_open.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_open.Location = New System.Drawing.Point(139, 246)
        Me.bt_open.Name = "bt_open"
        Me.bt_open.Size = New System.Drawing.Size(129, 39)
        Me.bt_open.TabIndex = 10
        Me.bt_open.Text = "&Mở dữ liệu đã chọn"
        Me.bt_open.UseVisualStyleBackColor = True
        '
        'bt_del
        '
        Me.bt_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_del.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_del.Location = New System.Drawing.Point(6, 246)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.Size = New System.Drawing.Size(127, 39)
        Me.bt_del.TabIndex = 9
        Me.bt_del.Text = "&Xóa dữ liệu đã chọn"
        Me.bt_del.UseVisualStyleBackColor = True
        '
        'lst_down
        '
        Me.lst_down.FormattingEnabled = True
        Me.lst_down.HorizontalScrollbar = True
        Me.lst_down.Location = New System.Drawing.Point(6, 41)
        Me.lst_down.Name = "lst_down"
        Me.lst_down.ScrollAlwaysVisible = True
        Me.lst_down.Size = New System.Drawing.Size(373, 199)
        Me.lst_down.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Thư mục lưu mặc định: /Download/"
        '
        'bt_dw
        '
        Me.bt_dw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_dw.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_dw.Location = New System.Drawing.Point(337, 185)
        Me.bt_dw.Name = "bt_dw"
        Me.bt_dw.Size = New System.Drawing.Size(59, 29)
        Me.bt_dw.TabIndex = 8
        Me.bt_dw.Text = "&Tải về"
        Me.bt_dw.UseVisualStyleBackColor = True
        '
        'cbx
        '
        Me.cbx.FormattingEnabled = True
        Me.cbx.Location = New System.Drawing.Point(86, 158)
        Me.cbx.Name = "cbx"
        Me.cbx.Size = New System.Drawing.Size(310, 21)
        Me.cbx.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.listonline)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_mota)
        Me.GroupBox1.Controls.Add(Me.cbx)
        Me.GroupBox1.Controls.Add(Me.txt_q)
        Me.GroupBox1.Controls.Add(Me.bt_dw)
        Me.GroupBox1.Controls.Add(Me.bt_q)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 300)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dữ liệu trực tuyến"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Chủ đề (Môn):"
        '
        'lib_online
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(823, 366)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.pn_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lib_online"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thư viện kiến thức trực tuyến"
        Me.pn_1.ResumeLayout(False)
        Me.pn_1.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_1 As Panel
    Friend WithEvents title_fr As Label
    Friend WithEvents listonline As ListBox
    Friend WithEvents txt_mota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_q As TextBox
    Friend WithEvents bt_q As Button
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_down As ListBox
    Friend WithEvents bt_dw As Button
    Friend WithEvents bt_del As Button
    Friend WithEvents bt_open As Button
    Friend WithEvents lb_dw As Label
    Friend WithEvents bt_back As Button
    Friend WithEvents cbx As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
End Class
