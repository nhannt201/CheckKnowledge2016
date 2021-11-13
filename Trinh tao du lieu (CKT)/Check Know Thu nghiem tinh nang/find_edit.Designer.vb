<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class find_edit
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
        Me.tab_list = New System.Windows.Forms.TabControl()
        Me.find_tab = New System.Windows.Forms.TabPage()
        Me.bt_rp_all = New System.Windows.Forms.Button()
        Me.bt_rp = New System.Windows.Forms.Button()
        Me.txt_rp = New System.Windows.Forms.TextBox()
        Me.lb_goiy = New System.Windows.Forms.Label()
        Me.ck3 = New System.Windows.Forms.CheckBox()
        Me.ck2 = New System.Windows.Forms.CheckBox()
        Me.ck1 = New System.Windows.Forms.CheckBox()
        Me.bt_edit = New System.Windows.Forms.Button()
        Me.lst_kq = New System.Windows.Forms.ListBox()
        Me.lb_kq = New System.Windows.Forms.Label()
        Me.bt_find = New System.Windows.Forms.Button()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.theodoian = New System.Windows.Forms.Timer(Me.components)
        Me.tab_list.SuspendLayout()
        Me.find_tab.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_list
        '
        Me.tab_list.Controls.Add(Me.find_tab)
        Me.tab_list.Location = New System.Drawing.Point(0, -2)
        Me.tab_list.Name = "tab_list"
        Me.tab_list.SelectedIndex = 0
        Me.tab_list.Size = New System.Drawing.Size(410, 302)
        Me.tab_list.TabIndex = 0
        '
        'find_tab
        '
        Me.find_tab.Controls.Add(Me.bt_rp_all)
        Me.find_tab.Controls.Add(Me.bt_rp)
        Me.find_tab.Controls.Add(Me.txt_rp)
        Me.find_tab.Controls.Add(Me.lb_goiy)
        Me.find_tab.Controls.Add(Me.ck3)
        Me.find_tab.Controls.Add(Me.ck2)
        Me.find_tab.Controls.Add(Me.ck1)
        Me.find_tab.Controls.Add(Me.bt_edit)
        Me.find_tab.Controls.Add(Me.lst_kq)
        Me.find_tab.Controls.Add(Me.lb_kq)
        Me.find_tab.Controls.Add(Me.bt_find)
        Me.find_tab.Controls.Add(Me.txt_find)
        Me.find_tab.Controls.Add(Me.Label1)
        Me.find_tab.Location = New System.Drawing.Point(4, 22)
        Me.find_tab.Name = "find_tab"
        Me.find_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.find_tab.Size = New System.Drawing.Size(402, 276)
        Me.find_tab.TabIndex = 0
        Me.find_tab.Text = "Tìm kiếm"
        Me.find_tab.UseVisualStyleBackColor = True
        '
        'bt_rp_all
        '
        Me.bt_rp_all.Location = New System.Drawing.Point(306, 64)
        Me.bt_rp_all.Name = "bt_rp_all"
        Me.bt_rp_all.Size = New System.Drawing.Size(83, 22)
        Me.bt_rp_all.TabIndex = 12
        Me.bt_rp_all.Text = "&Thay thế hết"
        Me.bt_rp_all.UseVisualStyleBackColor = True
        '
        'bt_rp
        '
        Me.bt_rp.Location = New System.Drawing.Point(306, 38)
        Me.bt_rp.Name = "bt_rp"
        Me.bt_rp.Size = New System.Drawing.Size(83, 22)
        Me.bt_rp.TabIndex = 11
        Me.bt_rp.Text = "&Thay thế"
        Me.bt_rp.UseVisualStyleBackColor = True
        '
        'txt_rp
        '
        Me.txt_rp.Location = New System.Drawing.Point(52, 39)
        Me.txt_rp.MaxLength = 5000
        Me.txt_rp.Name = "txt_rp"
        Me.txt_rp.Size = New System.Drawing.Size(252, 20)
        Me.txt_rp.TabIndex = 10
        '
        'lb_goiy
        '
        Me.lb_goiy.AutoSize = True
        Me.lb_goiy.Location = New System.Drawing.Point(49, 244)
        Me.lb_goiy.Name = "lb_goiy"
        Me.lb_goiy.Size = New System.Drawing.Size(170, 13)
        Me.lb_goiy.TabIndex = 9
        Me.lb_goiy.Text = "Nhấn đúp chuột sửa câu hỏi hoặc"
        Me.lb_goiy.Visible = False
        '
        'ck3
        '
        Me.ck3.AutoSize = True
        Me.ck3.Location = New System.Drawing.Point(309, 145)
        Me.ck3.Name = "ck3"
        Me.ck3.Size = New System.Drawing.Size(56, 17)
        Me.ck3.TabIndex = 8
        Me.ck3.Text = "Cả hai"
        Me.ck3.UseVisualStyleBackColor = True
        '
        'ck2
        '
        Me.ck2.AutoSize = True
        Me.ck2.Location = New System.Drawing.Point(310, 122)
        Me.ck2.Name = "ck2"
        Me.ck2.Size = New System.Drawing.Size(78, 17)
        Me.ck2.TabIndex = 7
        Me.ck2.Text = "Chỉ đáp án"
        Me.ck2.UseVisualStyleBackColor = True
        '
        'ck1
        '
        Me.ck1.AutoSize = True
        Me.ck1.Checked = True
        Me.ck1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ck1.Location = New System.Drawing.Point(310, 99)
        Me.ck1.Name = "ck1"
        Me.ck1.Size = New System.Drawing.Size(79, 17)
        Me.ck1.TabIndex = 6
        Me.ck1.Text = "Chỉ câu hỏi"
        Me.ck1.UseVisualStyleBackColor = True
        '
        'bt_edit
        '
        Me.bt_edit.Enabled = False
        Me.bt_edit.Location = New System.Drawing.Point(225, 239)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(79, 22)
        Me.bt_edit.TabIndex = 5
        Me.bt_edit.Text = "&Sửa câu hỏi"
        Me.bt_edit.UseVisualStyleBackColor = True
        '
        'lst_kq
        '
        Me.lst_kq.Enabled = False
        Me.lst_kq.FormattingEnabled = True
        Me.lst_kq.Location = New System.Drawing.Point(52, 99)
        Me.lst_kq.Name = "lst_kq"
        Me.lst_kq.Size = New System.Drawing.Size(252, 134)
        Me.lst_kq.TabIndex = 4
        '
        'lb_kq
        '
        Me.lb_kq.AutoSize = True
        Me.lb_kq.Location = New System.Drawing.Point(49, 73)
        Me.lb_kq.Name = "lb_kq"
        Me.lb_kq.Size = New System.Drawing.Size(132, 13)
        Me.lb_kq.TabIndex = 3
        Me.lb_kq.Text = "Bạn chưa tìm kết quả nào!"
        '
        'bt_find
        '
        Me.bt_find.Location = New System.Drawing.Point(306, 12)
        Me.bt_find.Name = "bt_find"
        Me.bt_find.Size = New System.Drawing.Size(83, 22)
        Me.bt_find.TabIndex = 2
        Me.bt_find.Text = "&Tìm"
        Me.bt_find.UseVisualStyleBackColor = True
        '
        'txt_find
        '
        Me.txt_find.Location = New System.Drawing.Point(52, 13)
        Me.txt_find.MaxLength = 5000
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(252, 20)
        Me.txt_find.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Tìm gì:"
        '
        'theodoian
        '
        Me.theodoian.Enabled = True
        Me.theodoian.Interval = 1000
        '
        'find_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 299)
        Me.Controls.Add(Me.tab_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "find_edit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm  - Trình sửa dữ liệu"
        Me.tab_list.ResumeLayout(False)
        Me.find_tab.ResumeLayout(False)
        Me.find_tab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_list As TabControl
    Friend WithEvents find_tab As TabPage
    Friend WithEvents bt_find As Button
    Friend WithEvents txt_find As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_kq As Label
    Friend WithEvents lst_kq As ListBox
    Friend WithEvents bt_edit As Button
    Friend WithEvents theodoian As Timer
    Friend WithEvents ck3 As CheckBox
    Friend WithEvents ck2 As CheckBox
    Friend WithEvents ck1 As CheckBox
    Friend WithEvents lb_goiy As Label
    Friend WithEvents bt_rp_all As Button
    Friend WithEvents bt_rp As Button
    Friend WithEvents txt_rp As TextBox
End Class
