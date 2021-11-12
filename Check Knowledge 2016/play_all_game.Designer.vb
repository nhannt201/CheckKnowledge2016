<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class play_all_program
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(play_all_program))
        Me.miniform = New System.Windows.Forms.Label()
        Me.thoat = New System.Windows.Forms.Label()
        Me.traloi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_ds = New System.Windows.Forms.Label()
        Me.diemso = New System.Windows.Forms.ListBox()
        Me.lb_kienthuc = New System.Windows.Forms.Label()
        Me.hoi = New System.Windows.Forms.TextBox()
        Me.an = New System.Windows.Forms.TextBox()
        Me.addan = New System.Windows.Forms.TextBox()
        Me.addhoi = New System.Windows.Forms.TextBox()
        Me.tl2 = New System.Windows.Forms.TextBox()
        Me.xuli = New System.Windows.Forms.TextBox()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.sostt2 = New System.Windows.Forms.TextBox()
        Me.dapanchuan = New System.Windows.Forms.TextBox()
        Me.lv_class = New System.Windows.Forms.Label()
        Me.get_id_max = New System.Windows.Forms.Label()
        Me.txt_get_class = New System.Windows.Forms.Label()
        Me.txt_auto_next = New System.Windows.Forms.Label()
        Me.txt_tongdiem = New System.Windows.Forms.Label()
        Me.txt_socauhoi = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bt_st = New System.Windows.Forms.Button()
        Me.traloitam = New System.Windows.Forms.TextBox()
        Me.dapantam = New System.Windows.Forms.TextBox()
        Me.lb_st = New System.Windows.Forms.Label()
        Me.luachonkq = New System.Windows.Forms.Panel()
        Me.dpd = New System.Windows.Forms.RadioButton()
        Me.dpc = New System.Windows.Forms.RadioButton()
        Me.dpb = New System.Windows.Forms.RadioButton()
        Me.dpa = New System.Windows.Forms.RadioButton()
        Me.lb_lc = New System.Windows.Forms.Label()
        Me.alboudata = New System.Windows.Forms.Label()
        Me.auto_next = New System.Windows.Forms.Timer(Me.components)
        Me.lb_reset = New System.Windows.Forms.Label()
        Me.lb_num = New System.Windows.Forms.Label()
        Me.lb_giay = New System.Windows.Forms.Label()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.dapannguyen = New System.Windows.Forms.TextBox()
        Me.gb_tk = New System.Windows.Forms.GroupBox()
        Me.tong2 = New System.Windows.Forms.Label()
        Me.tong1 = New System.Windows.Forms.Label()
        Me.nhan2 = New System.Windows.Forms.Label()
        Me.nhan1 = New System.Windows.Forms.Label()
        Me.maxfr = New System.Windows.Forms.CheckBox()
        Me.daymanhinh = New System.Windows.Forms.Timer(Me.components)
        Me.auto_fullscreen = New System.Windows.Forms.Timer(Me.components)
        Me.phongto = New System.Windows.Forms.Label()
        Me.cauhoi = New System.Windows.Forms.TextBox()
        Me.dapan_khisai = New System.Windows.Forms.TextBox()
        Me.cauhoi_khisai = New System.Windows.Forms.TextBox()
        Me.luachonkq.SuspendLayout()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tk.SuspendLayout()
        Me.SuspendLayout()
        '
        'miniform
        '
        Me.miniform.AutoSize = True
        Me.miniform.BackColor = System.Drawing.Color.DodgerBlue
        Me.miniform.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miniform.ForeColor = System.Drawing.Color.White
        Me.miniform.Location = New System.Drawing.Point(964, 5)
        Me.miniform.Name = "miniform"
        Me.miniform.Size = New System.Drawing.Size(15, 20)
        Me.miniform.TabIndex = 5
        Me.miniform.Text = "-"
        '
        'thoat
        '
        Me.thoat.AutoSize = True
        Me.thoat.BackColor = System.Drawing.Color.Brown
        Me.thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thoat.ForeColor = System.Drawing.Color.White
        Me.thoat.Location = New System.Drawing.Point(1010, 5)
        Me.thoat.Name = "thoat"
        Me.thoat.Size = New System.Drawing.Size(21, 20)
        Me.thoat.TabIndex = 4
        Me.thoat.Text = "X"
        '
        'traloi
        '
        Me.traloi.BackColor = System.Drawing.Color.White
        Me.traloi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.traloi.Location = New System.Drawing.Point(23, 355)
        Me.traloi.Multiline = True
        Me.traloi.Name = "traloi"
        Me.traloi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.traloi.Size = New System.Drawing.Size(645, 108)
        Me.traloi.TabIndex = 6
        Me.traloi.Text = resources.GetString("traloi.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Câu hỏi:"
        '
        'lb_ds
        '
        Me.lb_ds.AutoSize = True
        Me.lb_ds.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lb_ds.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ds.Location = New System.Drawing.Point(849, 45)
        Me.lb_ds.Name = "lb_ds"
        Me.lb_ds.Size = New System.Drawing.Size(139, 33)
        Me.lb_ds.TabIndex = 8
        Me.lb_ds.Text = "Điểm số:"
        '
        'diemso
        '
        Me.diemso.BackColor = System.Drawing.Color.White
        Me.diemso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.diemso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diemso.FormattingEnabled = True
        Me.diemso.ItemHeight = 20
        Me.diemso.Location = New System.Drawing.Point(805, 93)
        Me.diemso.Name = "diemso"
        Me.diemso.Size = New System.Drawing.Size(209, 240)
        Me.diemso.TabIndex = 9
        '
        'lb_kienthuc
        '
        Me.lb_kienthuc.AutoSize = True
        Me.lb_kienthuc.BackColor = System.Drawing.Color.White
        Me.lb_kienthuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_kienthuc.Location = New System.Drawing.Point(12, 3)
        Me.lb_kienthuc.Name = "lb_kienthuc"
        Me.lb_kienthuc.Size = New System.Drawing.Size(341, 24)
        Me.lb_kienthuc.TabIndex = 11
        Me.lb_kienthuc.Text = "Check Knowledge - Kiểm tra kiến thức -"
        '
        'hoi
        '
        Me.hoi.Location = New System.Drawing.Point(788, 228)
        Me.hoi.Multiline = True
        Me.hoi.Name = "hoi"
        Me.hoi.Size = New System.Drawing.Size(16, 21)
        Me.hoi.TabIndex = 13
        Me.hoi.Text = "<01> <cauhoi>i love you</cauhoi> <ketqua>toi yeu ban</ketqua> </01><02> <cauhoi>i" &
    " love you</cauhoi> <ketqua>toi yeu ban</ketqua> </02>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.hoi.Visible = False
        '
        'an
        '
        Me.an.Location = New System.Drawing.Point(840, 461)
        Me.an.Name = "an"
        Me.an.Size = New System.Drawing.Size(24, 20)
        Me.an.TabIndex = 14
        Me.an.Visible = False
        '
        'addan
        '
        Me.addan.Location = New System.Drawing.Point(899, 460)
        Me.addan.Name = "addan"
        Me.addan.Size = New System.Drawing.Size(24, 20)
        Me.addan.TabIndex = 16
        Me.addan.Visible = False
        '
        'addhoi
        '
        Me.addhoi.Location = New System.Drawing.Point(869, 459)
        Me.addhoi.Name = "addhoi"
        Me.addhoi.Size = New System.Drawing.Size(24, 20)
        Me.addhoi.TabIndex = 15
        Me.addhoi.Visible = False
        '
        'tl2
        '
        Me.tl2.Location = New System.Drawing.Point(964, 461)
        Me.tl2.Name = "tl2"
        Me.tl2.Size = New System.Drawing.Size(24, 20)
        Me.tl2.TabIndex = 18
        Me.tl2.Visible = False
        '
        'xuli
        '
        Me.xuli.Location = New System.Drawing.Point(929, 461)
        Me.xuli.Multiline = True
        Me.xuli.Name = "xuli"
        Me.xuli.Size = New System.Drawing.Size(29, 19)
        Me.xuli.TabIndex = 17
        Me.xuli.Visible = False
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(673, 357)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(99, 50)
        Me.bt1.TabIndex = 19
        Me.bt1.Text = "&Trả lời"
        Me.bt1.UseVisualStyleBackColor = False
        '
        'bt2
        '
        Me.bt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt2.Location = New System.Drawing.Point(674, 413)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(99, 50)
        Me.bt2.TabIndex = 20
        Me.bt2.Text = "&Bỏ qua"
        Me.bt2.UseVisualStyleBackColor = False
        '
        'sostt2
        '
        Me.sostt2.Location = New System.Drawing.Point(994, 461)
        Me.sostt2.Name = "sostt2"
        Me.sostt2.Size = New System.Drawing.Size(24, 20)
        Me.sostt2.TabIndex = 21
        Me.sostt2.Visible = False
        '
        'dapanchuan
        '
        Me.dapanchuan.BackColor = System.Drawing.Color.White
        Me.dapanchuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dapanchuan.Location = New System.Drawing.Point(994, 461)
        Me.dapanchuan.Multiline = True
        Me.dapanchuan.Name = "dapanchuan"
        Me.dapanchuan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dapanchuan.Size = New System.Drawing.Size(37, 18)
        Me.dapanchuan.TabIndex = 22
        Me.dapanchuan.Visible = False
        '
        'lv_class
        '
        Me.lv_class.AutoSize = True
        Me.lv_class.BackColor = System.Drawing.Color.White
        Me.lv_class.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_class.Location = New System.Drawing.Point(347, 3)
        Me.lv_class.Name = "lv_class"
        Me.lv_class.Size = New System.Drawing.Size(57, 24)
        Me.lv_class.TabIndex = 23
        Me.lv_class.Text = "Lớp 6"
        '
        'get_id_max
        '
        Me.get_id_max.AutoSize = True
        Me.get_id_max.Location = New System.Drawing.Point(673, 45)
        Me.get_id_max.Name = "get_id_max"
        Me.get_id_max.Size = New System.Drawing.Size(78, 13)
        Me.get_id_max.TabIndex = 24
        Me.get_id_max.Text = "txt_get_max_id"
        Me.get_id_max.Visible = False
        '
        'txt_get_class
        '
        Me.txt_get_class.AutoSize = True
        Me.txt_get_class.Location = New System.Drawing.Point(673, 61)
        Me.txt_get_class.Name = "txt_get_class"
        Me.txt_get_class.Size = New System.Drawing.Size(69, 13)
        Me.txt_get_class.TabIndex = 25
        Me.txt_get_class.Text = "txt_get_class"
        Me.txt_get_class.Visible = False
        '
        'txt_auto_next
        '
        Me.txt_auto_next.AutoSize = True
        Me.txt_auto_next.Location = New System.Drawing.Point(673, 78)
        Me.txt_auto_next.Name = "txt_auto_next"
        Me.txt_auto_next.Size = New System.Drawing.Size(71, 13)
        Me.txt_auto_next.TabIndex = 26
        Me.txt_auto_next.Text = "txt_auto_next"
        Me.txt_auto_next.Visible = False
        '
        'txt_tongdiem
        '
        Me.txt_tongdiem.AutoSize = True
        Me.txt_tongdiem.Location = New System.Drawing.Point(562, 45)
        Me.txt_tongdiem.Name = "txt_tongdiem"
        Me.txt_tongdiem.Size = New System.Drawing.Size(67, 13)
        Me.txt_tongdiem.TabIndex = 27
        Me.txt_tongdiem.Text = "txt_tongdiem"
        Me.txt_tongdiem.Visible = False
        '
        'txt_socauhoi
        '
        Me.txt_socauhoi.AutoSize = True
        Me.txt_socauhoi.Location = New System.Drawing.Point(562, 61)
        Me.txt_socauhoi.Name = "txt_socauhoi"
        Me.txt_socauhoi.Size = New System.Drawing.Size(67, 13)
        Me.txt_socauhoi.TabIndex = 28
        Me.txt_socauhoi.Text = "txt_socauhoi"
        Me.txt_socauhoi.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(562, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "txt_..."
        Me.Label6.Visible = False
        '
        'bt_st
        '
        Me.bt_st.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_st.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_st.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_st.Location = New System.Drawing.Point(805, 419)
        Me.bt_st.Name = "bt_st"
        Me.bt_st.Size = New System.Drawing.Size(209, 50)
        Me.bt_st.TabIndex = 30
        Me.bt_st.Text = "&Quay lại && Thống kê"
        Me.bt_st.UseVisualStyleBackColor = False
        '
        'traloitam
        '
        Me.traloitam.Location = New System.Drawing.Point(788, 463)
        Me.traloitam.Name = "traloitam"
        Me.traloitam.Size = New System.Drawing.Size(24, 20)
        Me.traloitam.TabIndex = 31
        Me.traloitam.Visible = False
        '
        'dapantam
        '
        Me.dapantam.Location = New System.Drawing.Point(760, 469)
        Me.dapantam.Name = "dapantam"
        Me.dapantam.Size = New System.Drawing.Size(24, 20)
        Me.dapantam.TabIndex = 32
        Me.dapantam.Visible = False
        '
        'lb_st
        '
        Me.lb_st.AutoSize = True
        Me.lb_st.BackColor = System.Drawing.Color.LightSlateGray
        Me.lb_st.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_st.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_st.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_st.ForeColor = System.Drawing.Color.White
        Me.lb_st.Location = New System.Drawing.Point(890, 5)
        Me.lb_st.Name = "lb_st"
        Me.lb_st.Size = New System.Drawing.Size(68, 22)
        Me.lb_st.TabIndex = 33
        Me.lb_st.Text = "Bật âm"
        '
        'luachonkq
        '
        Me.luachonkq.BackColor = System.Drawing.Color.White
        Me.luachonkq.Controls.Add(Me.dpd)
        Me.luachonkq.Controls.Add(Me.dpc)
        Me.luachonkq.Controls.Add(Me.dpb)
        Me.luachonkq.Controls.Add(Me.dpa)
        Me.luachonkq.Controls.Add(Me.lb_lc)
        Me.luachonkq.Location = New System.Drawing.Point(25, 355)
        Me.luachonkq.Name = "luachonkq"
        Me.luachonkq.Size = New System.Drawing.Size(642, 108)
        Me.luachonkq.TabIndex = 34
        Me.luachonkq.Visible = False
        '
        'dpd
        '
        Me.dpd.AutoSize = True
        Me.dpd.Location = New System.Drawing.Point(474, 58)
        Me.dpd.Name = "dpd"
        Me.dpd.Size = New System.Drawing.Size(61, 17)
        Me.dpd.TabIndex = 4
        Me.dpd.TabStop = True
        Me.dpd.Text = "Chọn D"
        Me.dpd.UseVisualStyleBackColor = True
        '
        'dpc
        '
        Me.dpc.AutoSize = True
        Me.dpc.Location = New System.Drawing.Point(326, 58)
        Me.dpc.Name = "dpc"
        Me.dpc.Size = New System.Drawing.Size(60, 17)
        Me.dpc.TabIndex = 3
        Me.dpc.TabStop = True
        Me.dpc.Text = "Chọn C"
        Me.dpc.UseVisualStyleBackColor = True
        '
        'dpb
        '
        Me.dpb.AutoSize = True
        Me.dpb.Location = New System.Drawing.Point(182, 58)
        Me.dpb.Name = "dpb"
        Me.dpb.Size = New System.Drawing.Size(60, 17)
        Me.dpb.TabIndex = 2
        Me.dpb.TabStop = True
        Me.dpb.Text = "Chọn B"
        Me.dpb.UseVisualStyleBackColor = True
        '
        'dpa
        '
        Me.dpa.AutoSize = True
        Me.dpa.Location = New System.Drawing.Point(43, 58)
        Me.dpa.Name = "dpa"
        Me.dpa.Size = New System.Drawing.Size(60, 17)
        Me.dpa.TabIndex = 1
        Me.dpa.TabStop = True
        Me.dpa.Text = "Chọn A"
        Me.dpa.UseVisualStyleBackColor = True
        '
        'lb_lc
        '
        Me.lb_lc.AutoSize = True
        Me.lb_lc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_lc.Location = New System.Drawing.Point(10, 12)
        Me.lb_lc.Name = "lb_lc"
        Me.lb_lc.Size = New System.Drawing.Size(175, 16)
        Me.lb_lc.TabIndex = 0
        Me.lb_lc.Text = "Lựa chọn đáp án của bạn:"
        '
        'alboudata
        '
        Me.alboudata.AutoSize = True
        Me.alboudata.BackColor = System.Drawing.Color.Gray
        Me.alboudata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alboudata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.alboudata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alboudata.ForeColor = System.Drawing.Color.White
        Me.alboudata.Location = New System.Drawing.Point(740, 5)
        Me.alboudata.Name = "alboudata"
        Me.alboudata.Size = New System.Drawing.Size(144, 22)
        Me.alboudata.TabIndex = 35
        Me.alboudata.Text = "Thông tin dữ liệu"
        '
        'auto_next
        '
        Me.auto_next.Interval = 1000
        '
        'lb_reset
        '
        Me.lb_reset.AutoSize = True
        Me.lb_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lb_reset.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_reset.Location = New System.Drawing.Point(594, 36)
        Me.lb_reset.Name = "lb_reset"
        Me.lb_reset.Size = New System.Drawing.Size(190, 25)
        Me.lb_reset.TabIndex = 36
        Me.lb_reset.Text = "Thời gian còn lại:"
        Me.lb_reset.Visible = False
        '
        'lb_num
        '
        Me.lb_num.AutoSize = True
        Me.lb_num.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lb_num.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_num.Location = New System.Drawing.Point(654, 64)
        Me.lb_num.Name = "lb_num"
        Me.lb_num.Size = New System.Drawing.Size(38, 25)
        Me.lb_num.TabIndex = 37
        Me.lb_num.Text = "60"
        Me.lb_num.Visible = False
        '
        'lb_giay
        '
        Me.lb_giay.AutoSize = True
        Me.lb_giay.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lb_giay.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_giay.Location = New System.Drawing.Point(698, 62)
        Me.lb_giay.Name = "lb_giay"
        Me.lb_giay.Size = New System.Drawing.Size(56, 25)
        Me.lb_giay.TabIndex = 38
        Me.lb_giay.Text = "giây"
        Me.lb_giay.Visible = False
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pb2.Location = New System.Drawing.Point(12, 343)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(772, 138)
        Me.pb2.TabIndex = 3
        Me.pb2.TabStop = False
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pb3.Location = New System.Drawing.Point(790, 30)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(241, 451)
        Me.pb3.TabIndex = 2
        Me.pb3.TabStop = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pb1.Location = New System.Drawing.Point(12, 30)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(772, 307)
        Me.pb1.TabIndex = 1
        Me.pb1.TabStop = False
        '
        'dapannguyen
        '
        Me.dapannguyen.Location = New System.Drawing.Point(730, 469)
        Me.dapannguyen.Name = "dapannguyen"
        Me.dapannguyen.Size = New System.Drawing.Size(24, 20)
        Me.dapannguyen.TabIndex = 39
        Me.dapannguyen.Visible = False
        '
        'gb_tk
        '
        Me.gb_tk.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gb_tk.Controls.Add(Me.tong2)
        Me.gb_tk.Controls.Add(Me.tong1)
        Me.gb_tk.Controls.Add(Me.nhan2)
        Me.gb_tk.Controls.Add(Me.nhan1)
        Me.gb_tk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_tk.Location = New System.Drawing.Point(805, 339)
        Me.gb_tk.Name = "gb_tk"
        Me.gb_tk.Size = New System.Drawing.Size(209, 74)
        Me.gb_tk.TabIndex = 40
        Me.gb_tk.TabStop = False
        Me.gb_tk.Text = "Thống kê"
        '
        'tong2
        '
        Me.tong2.AutoSize = True
        Me.tong2.Location = New System.Drawing.Point(137, 44)
        Me.tong2.Name = "tong2"
        Me.tong2.Size = New System.Drawing.Size(16, 16)
        Me.tong2.TabIndex = 3
        Me.tong2.Text = "0"
        Me.tong2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tong1
        '
        Me.tong1.AutoSize = True
        Me.tong1.Location = New System.Drawing.Point(137, 16)
        Me.tong1.Name = "tong1"
        Me.tong1.Size = New System.Drawing.Size(16, 16)
        Me.tong1.TabIndex = 2
        Me.tong1.Text = "0"
        Me.tong1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nhan2
        '
        Me.nhan2.AutoSize = True
        Me.nhan2.Location = New System.Drawing.Point(16, 44)
        Me.nhan2.Name = "nhan2"
        Me.nhan2.Size = New System.Drawing.Size(116, 16)
        Me.nhan2.TabIndex = 1
        Me.nhan2.Text = "Điểm trung bình:"
        '
        'nhan1
        '
        Me.nhan1.AutoSize = True
        Me.nhan1.Location = New System.Drawing.Point(16, 19)
        Me.nhan1.Name = "nhan1"
        Me.nhan1.Size = New System.Drawing.Size(73, 16)
        Me.nhan1.TabIndex = 0
        Me.nhan1.Text = "Đã trả lời:"
        '
        'maxfr
        '
        Me.maxfr.AutoSize = True
        Me.maxfr.Location = New System.Drawing.Point(570, 7)
        Me.maxfr.Name = "maxfr"
        Me.maxfr.Size = New System.Drawing.Size(97, 17)
        Me.maxfr.TabIndex = 42
        Me.maxfr.Text = "Toàn màn hình"
        Me.maxfr.UseVisualStyleBackColor = True
        Me.maxfr.Visible = False
        '
        'daymanhinh
        '
        Me.daymanhinh.Enabled = True
        Me.daymanhinh.Interval = 5000
        '
        'auto_fullscreen
        '
        Me.auto_fullscreen.Enabled = True
        Me.auto_fullscreen.Interval = 2000
        '
        'phongto
        '
        Me.phongto.AutoSize = True
        Me.phongto.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.phongto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phongto.ForeColor = System.Drawing.Color.White
        Me.phongto.Location = New System.Drawing.Point(984, 5)
        Me.phongto.Name = "phongto"
        Me.phongto.Size = New System.Drawing.Size(20, 20)
        Me.phongto.TabIndex = 43
        Me.phongto.Text = "□"
        '
        'cauhoi
        '
        Me.cauhoi.BackColor = System.Drawing.Color.White
        Me.cauhoi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cauhoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cauhoi.Location = New System.Drawing.Point(38, 94)
        Me.cauhoi.Multiline = True
        Me.cauhoi.Name = "cauhoi"
        Me.cauhoi.ReadOnly = True
        Me.cauhoi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cauhoi.Size = New System.Drawing.Size(735, 228)
        Me.cauhoi.TabIndex = 12
        Me.cauhoi.Text = resources.GetString("cauhoi.Text")
        '
        'dapan_khisai
        '
        Me.dapan_khisai.Location = New System.Drawing.Point(643, 469)
        Me.dapan_khisai.Name = "dapan_khisai"
        Me.dapan_khisai.Size = New System.Drawing.Size(24, 20)
        Me.dapan_khisai.TabIndex = 44
        Me.dapan_khisai.Visible = False
        '
        'cauhoi_khisai
        '
        Me.cauhoi_khisai.Location = New System.Drawing.Point(599, 469)
        Me.cauhoi_khisai.Name = "cauhoi_khisai"
        Me.cauhoi_khisai.Size = New System.Drawing.Size(24, 20)
        Me.cauhoi_khisai.TabIndex = 45
        Me.cauhoi_khisai.Visible = False
        '
        'play_all_program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1043, 493)
        Me.Controls.Add(Me.cauhoi_khisai)
        Me.Controls.Add(Me.dapan_khisai)
        Me.Controls.Add(Me.phongto)
        Me.Controls.Add(Me.maxfr)
        Me.Controls.Add(Me.gb_tk)
        Me.Controls.Add(Me.dapannguyen)
        Me.Controls.Add(Me.lb_giay)
        Me.Controls.Add(Me.lb_num)
        Me.Controls.Add(Me.lb_reset)
        Me.Controls.Add(Me.alboudata)
        Me.Controls.Add(Me.luachonkq)
        Me.Controls.Add(Me.lb_st)
        Me.Controls.Add(Me.dapantam)
        Me.Controls.Add(Me.traloitam)
        Me.Controls.Add(Me.bt_st)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_socauhoi)
        Me.Controls.Add(Me.txt_tongdiem)
        Me.Controls.Add(Me.txt_auto_next)
        Me.Controls.Add(Me.txt_get_class)
        Me.Controls.Add(Me.get_id_max)
        Me.Controls.Add(Me.lv_class)
        Me.Controls.Add(Me.dapanchuan)
        Me.Controls.Add(Me.sostt2)
        Me.Controls.Add(Me.bt2)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.tl2)
        Me.Controls.Add(Me.xuli)
        Me.Controls.Add(Me.addan)
        Me.Controls.Add(Me.addhoi)
        Me.Controls.Add(Me.an)
        Me.Controls.Add(Me.hoi)
        Me.Controls.Add(Me.cauhoi)
        Me.Controls.Add(Me.lb_kienthuc)
        Me.Controls.Add(Me.diemso)
        Me.Controls.Add(Me.lb_ds)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.traloi)
        Me.Controls.Add(Me.miniform)
        Me.Controls.Add(Me.thoat)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.pb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "play_all_program"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trình kiểm tra kiến thức"
        Me.TopMost = True
        Me.luachonkq.ResumeLayout(False)
        Me.luachonkq.PerformLayout()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tk.ResumeLayout(False)
        Me.gb_tk.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents pb3 As System.Windows.Forms.PictureBox
    Friend WithEvents pb2 As System.Windows.Forms.PictureBox
    Friend WithEvents miniform As System.Windows.Forms.Label
    Friend WithEvents thoat As System.Windows.Forms.Label
    Friend WithEvents traloi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_ds As System.Windows.Forms.Label
    Friend WithEvents diemso As System.Windows.Forms.ListBox
    Friend WithEvents lb_kienthuc As System.Windows.Forms.Label
    Friend WithEvents hoi As TextBox
    Friend WithEvents an As TextBox
    Friend WithEvents addan As TextBox
    Friend WithEvents addhoi As TextBox
    Friend WithEvents tl2 As TextBox
    Friend WithEvents xuli As TextBox
    Friend WithEvents bt1 As Button
    Friend WithEvents bt2 As Button
    Friend WithEvents sostt2 As TextBox
    Friend WithEvents dapanchuan As TextBox
    Friend WithEvents lv_class As Label
    Friend WithEvents get_id_max As Label
    Friend WithEvents txt_get_class As Label
    Friend WithEvents txt_auto_next As Label
    Friend WithEvents txt_tongdiem As Label
    Friend WithEvents txt_socauhoi As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bt_st As Button
    Friend WithEvents traloitam As TextBox
    Friend WithEvents dapantam As TextBox
    Friend WithEvents lb_st As Label
    Friend WithEvents luachonkq As Panel
    Friend WithEvents dpd As RadioButton
    Friend WithEvents dpc As RadioButton
    Friend WithEvents dpb As RadioButton
    Friend WithEvents dpa As RadioButton
    Friend WithEvents lb_lc As Label
    Friend WithEvents alboudata As Label
    Friend WithEvents auto_next As Timer
    Friend WithEvents lb_reset As Label
    Friend WithEvents lb_num As Label
    Friend WithEvents lb_giay As Label
    Friend WithEvents dapannguyen As TextBox
    Friend WithEvents gb_tk As GroupBox
    Friend WithEvents tong2 As Label
    Friend WithEvents tong1 As Label
    Friend WithEvents nhan2 As Label
    Friend WithEvents nhan1 As Label
    Friend WithEvents maxfr As CheckBox
    Friend WithEvents daymanhinh As Timer
    Friend WithEvents auto_fullscreen As Timer
    Friend WithEvents phongto As Label
    Friend WithEvents cauhoi As TextBox
    Friend WithEvents dapan_khisai As TextBox
    Friend WithEvents cauhoi_khisai As TextBox
End Class
