Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Public Class trinhedit
    Private m_iMessage As Integer
    Private Shared WM_QUERYENDSESSION As Integer = &H11 'this is a logoff, shutdown, or reboot
    Private Shared WM_FORMCONTROLMENU As Integer = 16 'form closed via form control menu
    'Of form
    Dim data_base As String = 0
    '  Dim listgia As New ListBox
    Dim position As String
    Dim dapan1, dapan2, dapan3, dapan4 As String
    Dim tnkia As String = 0
    Dim luutamdata As New TextBox
    Dim cauhoi_dapantam As New TextBox
    Dim id_cahuhoi As String
    Dim check_add_tn As String
    Dim luu_bandau As New TextBox
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        m_iMessage = m.Msg

        ' If this is WM_QUERYENDSESSION, the closing event should be fired in the base WndProc
        MyBase.WndProc(m)

    End Sub 'WndProc


    '   Dim text_tam As New TextBox
    Private Sub trinhedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txt_dap.Text.Trim.Length = 0 And txt_hoi.Text.Trim.Length = 0 Then
            LưuLạiToolStripMenuItem.Enabled = False
            undo_menu.Enabled = False
            undo_all.Enabled = False
            txt_dap.Enabled = False
            txt_hoi.Enabled = False
        End If
        luu_bandau.Multiline = True
        luu_bandau.ScrollBars = ScrollBars.Both
        luutamdata.Multiline = True
        luutamdata.ScrollBars = ScrollBars.Both
        cauhoi_dapantam.Multiline = True
        cauhoi_dapantam.ScrollBars = ScrollBars.Both
        loadk()
        ' Me.Hide()
        luu_bandau.Text = data.Text
        Me.Enabled = False
    End Sub
    Sub checkcauhoi()
        If txt_dap.Text.Trim.Replace(" ", "").Length = 1 Then
            checktracnghiem()
        ElseIf txt_hoi.Text.Replace(" ", "").Length < 5 Or txt_dap.Text.Replace(" ", "").Length < 5 Then
            MsgBox("Câu hỏi hoặc đáp án quá ngắn!")
        Else
            addd()
        End If
    End Sub
    Sub checktracnghiem()
        If txt_hoi.Text.Replace(" ", "").Length < 5 Then
            MsgBox("Câu hỏi quá ngắn!", vbInformation, "Báo lỗi")
        ElseIf slct4.Visible = False Then
            check_add_tn = 3
            If slct3.Text.Trim.Length = 0 Then
                MsgBox("Đáp án C của bạn không được toàn dấu cách hoặc bỏ trống!", vbInformation, "Báo lỗi")
            Else
                add_tn()
            End If

        ElseIf slct3.Visible = False Then
            check_add_tn = 2
            If slct2.Text.Trim.Length = 0 Then
                MsgBox("Đáp án B của bạn không được toàn dấu cách hoặc bỏ trống!", vbInformation, "Báo lỗi")
            Else
                add_tn()
            End If

            'ElseIf slct4.Text.Trim.Length = 0 And dapantn.Text = "C" Or dapantn.Text = "B" Or dapantn.Text = "A" Then
            '    slct4.Visible = False
            '  lb5.Visible = False
            '   add_tn()
            '  ElseIf slct3.Text.Trim.Length = 0 And dapantn.Text = "B" Or dapantn.Text = "A" Then
            '    slct3.Visible = False
            '    lb4.Visible = False
            '   add_tn()
        ElseIf slct4.Text.Replace(" ", "").Length = 0 And slct4.Visible = True Then
            MsgBox("Đáp án D của bạn không được toàn dấu cách hoặc bỏ trống!", vbInformation, "Báo lỗi")
        ElseIf slct3.Text.Replace(" ", "").Length = 0 And slct3.Visible = True Then
            MsgBox("Đáp án C của bạn không được toàn dấu cách hoặc bỏ trống!", vbInformation, "Báo lỗi")
        ElseIf slct2.Text.Replace(" ", "").Length = 0 And slct2.Visible = True Then
            MsgBox("Đáp án B của bạn không được toàn dấu cách hoặc bỏ trống!", vbInformation, "Báo lỗi")
        ElseIf slct1.Text.Replace(" ", "").Length = 0 And slct1.Visible = True Then
            MsgBox("Đáp án A của bạn không được toàn dấucách hoặc bỏ trống!", vbInformation, "Báo lỗi")
        Else
            add_tn()
        End If
    End Sub
    Sub addd()
        data.Text = data.Text.Replace(cauhoi.Text, "<cauhoi>" & txt_hoi.Text & "</cauhoi>" & "<ketqua>" & txt_dap.Text & "</ketqua>")

        '  If ck1.Enabled = True Then
        If System.IO.File.Exists(pathfile.Text) = True Then

            Dim objWriter As New System.IO.StreamWriter(pathfile.Text)
            encode(data.Text)
            objWriter.Write(encode(data.Text))
            objWriter.Close()
            ' MessageBox.Show("Text written to file")
        Else
            MsgBox("Không tìm thấy tệp dữ liệu, có vẻ bạn đã xoá nó?", vbInformation, "Báo lỗi")
        End If
        'MsgBox("Đã lưu câu hỏi!", vbInformation, "Thông báo")
        lb_sts.Text = "Tình trạng: Đã lưu dữ liệu!"
        '  End If
    End Sub
    Sub add_tn()

        If check_add_tn = 4 Then
            data.Text = data.Text.Replace(cauhoi.Text, "<type>trn_abc</type><cauhoi>" & txt_hoi.Text & "</cauhoi>" & "<ketqua>" & dapantn.Text & "</ketqua>" & "<select1>" & slct1.Text & "</select1><select2>" & slct2.Text & "</select2><select3>" & slct3.Text & "</select3><select4>" & slct4.Text & "</select4>")
        ElseIf check_add_tn = 3 Then
            data.Text = data.Text.Replace(cauhoi.Text, "<type>trn_abc</type><cauhoi>" & txt_hoi.Text & "</cauhoi>" & "<ketqua>" & dapantn.Text & "</ketqua>" & "<select1>" & slct1.Text & "</select1><select2>" & slct2.Text & "</select2><select3>" & slct3.Text & "</select3>")
        ElseIf check_add_tn = 2 Then
            data.Text = data.Text.Replace(cauhoi.Text, "<type>trn_abc</type><cauhoi>" & txt_hoi.Text & "</cauhoi>" & "<ketqua>" & dapantn.Text & "</ketqua>" & "<select1>" & slct1.Text & "</select1><select2>" & slct2.Text & "</select2>")
        ElseIf check_add_tn = 1 Then
            data.Text = data.Text.Replace(cauhoi.Text, "<type>trn_abc</type><cauhoi>" & txt_hoi.Text & "</cauhoi>" & "<ketqua>" & dapantn.Text & "</ketqua>" & "<select1>" & slct1.Text & "</select1>")
        End If

        '  If ck1.Enabled = True Then
        If System.IO.File.Exists(pathfile.Text) = True Then

            Dim objWriter As New System.IO.StreamWriter(pathfile.Text)
            encode(data.Text)
            objWriter.Write(encode(data.Text))
            objWriter.Close()
            ' MessageBox.Show("Text written to file")
        Else
            MsgBox("Không tìm thấy tệp dữ liệu, có vẻ bạn đã xoá nó?", vbInformation, "Báo lỗi")
        End If
        ' Dim sadadad As String = (lst_cauhoi.SelectedIndex + 1)
        lst_cauhoi.SelectedIndex = (id_cahuhoi) - 1
        ' MsgBox("Đã lưu trắc nghiệm!", vbInformation, "Thông báo")
        lb_sts.Text = "Tình trạng: Đã lưu dữ liệu!"
        '  End If

    End Sub

    Sub loadk()
        If My.Computer.FileSystem.FileExists(pathfile.Text) Then
            '  MsgBox("File found.")

            Using sr As New StreamReader(pathfile.Text)
                Dim line As String
                ' Read the stream to a string and write the string to the console.
                line = sr.ReadToEnd()
                data.Text = decode(line)
                luutamdata.Text = decode(line)
                '   cauhoi.Text = data.Text
                If InStr(data.Text, "<pass>") > 0 Then
                    Dim checkpass As String = SplitString(data.Text, "<pass>", "</pass>")
                    '  Dim bkav As Byte() = Convert.FromBase64String(checkpass)
                    gothoi.Stop()
                    ' System.Text.Encoding.UTF8.GetString(bkav)
                    If checkpass = "x12515x185x125x1765x12055x11065x15x11535x1755x12415x11825x165x1315x1505x12525x11755" Then
                        gothoi.Start()
                    Else
                        xacnhan.Show()
                        xacnhan.passk.Text = checkpass
                        Me.Hide()
                        ' Me.Enabled = False
                    End If
                Else
                    Try
                        gothoi.Start()
                        thongtin.Show()
                        ' MsgBox("Tập tin dữ liệu không hợp lệ!" & vbNewLine & "Chương trình sẽ đóng sau thông báo này!", vbInformation, "Báo lỗi")

                        '  Me.Close()

                    Catch
                        End
                    End Try
                End If

            End Using
            ' data.SelectionStart = data.Text.Length
            '   data.ScrollToCaret()
            '  data.Refresh()
        Else
            '  MsgBox("File not found.")
            Dim path As String = pathfile.Text

            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(path)

            ' Add text to the file.
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("")
            fs.Write(info, 0, info.Length)
            fs.Close()

        End If
    End Sub

    Private Sub gothoi_Tick(sender As Object, e As EventArgs) Handles gothoi.Tick
        data_base = data_base + 1
        position = InStr(data.Text, "<" + data_base + ">")
        If position = 0 Then
            lst_cauhoi.Items.Add("Câu hỏi " & data_base)
            ' listgia.Items.Add(data_base)
            Me.Enabled = True
            If lst_cauhoi.Items.Count > 0 Then
                lst_cauhoi.SelectedIndex = 0
                '  txt_hoi.Text = data.Text
            End If
            gothoi.Stop()
        Else
            lst_cauhoi.Items.Add("Câu hỏi " & data_base)
            ' listgia.Items.Add(data_base)
        End If
        word_tuychon.txt_num.Text = lst_cauhoi.Items.Count
    End Sub

    Private Sub lst_cauhoi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_cauhoi.SelectedIndexChanged
        If lst_cauhoi.SelectedIndex >= 0 Then
            txt_hoi.Enabled = True
            txt_dap.Enabled = True
            undo_menu.Enabled = True
            undo_all.Enabled = True
            LưuLạiToolStripMenuItem.Enabled = True
            'something is selected
            id_cahuhoi = lst_cauhoi.SelectedIndex + 1
            'Sao qua txt_num_next
            txt_num_next.Text = id_cahuhoi
            undo_menu.Text = "Hoàn tác câu " & id_cahuhoi
            xoacauhoi_menu.Text = "Xóa câu hỏi " & id_cahuhoi
            lb_sts.Text = "Tình trạng: Đang chọn và sửa câu hỏi " & id_cahuhoi
            cauhoi.Text = SplitString(data.Text, "<" & lst_cauhoi.SelectedIndex & ">", "</" & lst_cauhoi.SelectedIndex & ">")
            'sao luu cau hoi tam
            cauhoi_dapantam.Text = SplitString(luu_bandau.Text, "<" & lst_cauhoi.SelectedIndex & ">", "</" & lst_cauhoi.SelectedIndex & ">")
            Me.Text = lst_cauhoi.Text & ": " & SplitString(cauhoi.Text, "<cauhoi>", "</cauhoi>")
            If Me.Text.Length = 0 Then
                Me.Text = "Trình chỉnh sửa dữ liệu"
            End If
            dapantn.Items.Clear()
            txt_hoi.Text = SplitString(cauhoi.Text, "<cauhoi>", "</cauhoi>")
            txt_dap.Text = SplitString(cauhoi.Text, "<ketqua>", "</ketqua>")
            ' txt_hoi.Text = cauhoi.Text
            If txt_dap.Text.Length = 0 Then
                txt_dap.Enabled = False
                txt_dap.Text = "Bạn không thể sửa đổi câu hỏi này, vì:" & vbNewLine & "-  Câu hỏi này không có hoặc dữ liệu rỗng" & vbNewLine & "-  Bạn đang mở một tệp không tạo ra từ trình tạo dữ liệu"
                LưuLạiToolStripMenuItem.Enabled = False
                '  ThemAddToolStripMenuItem.Enabled = False
            ElseIf txt_dap.Text.Length = 1 Then
                tnkia = 1
                txt_dap.Visible = False
                dapantn.Visible = True
                dapantn.Items.Add(txt_dap.Text)
                dapantn.SelectedIndex = dapantn.FindStringExact(txt_dap.Text)
                ThêmÔTrắcNghiệmToolStripMenuItem.Enabled = True
                If cauhoi.Text.Contains("<select4>") Then 'Chon lua 4
                    'Label Name
                    lb1.Visible = True
                    lb2.Visible = True
                    lb3.Visible = True
                    lb4.Visible = True
                    lb5.Visible = True
                    check_add_tn = 4
                    'Dap an Items
                    If txt_dap.Text = "A" Then
                        dapantn.Items.Add("B")
                        dapantn.Items.Add("C")
                        dapantn.Items.Add("D")
                    ElseIf txt_dap.Text = "B" Then
                        dapantn.Items.Add("A")
                        dapantn.Items.Add("C")
                        dapantn.Items.Add("D")
                    ElseIf txt_dap.Text = "C" Then
                        dapantn.Items.Add("A")
                        dapantn.Items.Add("B")
                        dapantn.Items.Add("D")
                    ElseIf txt_dap.Text = "D" Then
                        dapantn.Items.Add("A")
                        dapantn.Items.Add("B")
                        dapantn.Items.Add("C")
                    End If
                    'Dap an KQ
                    dapan4 = SplitString(cauhoi.Text, "<select4>", "</select4>")
                    slct4.Visible = True
                    slct4.Text = dapan4
                    dapan3 = SplitString(cauhoi.Text, "<select3>", "</select3>")
                    slct3.Visible = True
                    slct3.Text = dapan3
                    dapan2 = SplitString(cauhoi.Text, "<select2>", "</select2>")
                    slct2.Visible = True
                    slct2.Text = dapan2
                    dapan1 = SplitString(cauhoi.Text, "<select1>", "</select1>")
                    slct1.Visible = True
                    slct1.Text = dapan1
                ElseIf cauhoi.Text.Contains("<select3>") Then 'Chon lua 3
                    'Label Name
                    lb1.Visible = True
                    lb2.Visible = True
                    lb3.Visible = True
                    lb4.Visible = True
                    lb5.Visible = False
                    check_add_tn = 3
                    'Dap an Items
                    If txt_dap.Text = "A" Then
                        dapantn.Items.Add("B")
                        dapantn.Items.Add("C")
                    ElseIf txt_dap.Text = "B" Then
                        dapantn.Items.Add("A")
                        dapantn.Items.Add("C")
                    ElseIf txt_dap.Text = "C" Then
                        dapantn.Items.Add("A")
                        dapantn.Items.Add("B")
                    End If
                    'Dap an KQ
                    dapan3 = SplitString(cauhoi.Text, "<select3>", "</select3>")
                    slct3.Visible = True
                    slct3.Text = dapan3
                    dapan2 = SplitString(cauhoi.Text, "<select2>", "</select2>")
                    slct2.Visible = True
                    slct2.Text = dapan2
                    dapan1 = SplitString(cauhoi.Text, "<select1>", "</select1>")
                    slct1.Visible = True
                    slct1.Text = dapan1
                    slct4.Visible = False
                ElseIf cauhoi.Text.Contains("<select2>") Then
                    'Label Name
                    lb1.Visible = True
                    lb2.Visible = True
                    lb3.Visible = True
                    lb4.Visible = False
                    lb5.Visible = False
                    check_add_tn = 2
                    'Dap an Items
                    If txt_dap.Text = "A" Then
                        dapantn.Items.Add("B")
                    ElseIf txt_dap.Text = "B" Then
                        dapantn.Items.Add("A")
                    End If
                    'Dap an KQ
                    dapan2 = SplitString(cauhoi.Text, "<select2>", "</select2>")
                    slct2.Visible = True
                    slct2.Text = dapan2
                    dapan1 = SplitString(cauhoi.Text, "<select1>", "</select1>")
                    slct1.Visible = True
                    slct1.Text = dapan1
                    slct4.Visible = False
                    slct3.Visible = False
                ElseIf cauhoi.Text.Contains("<select1>") Then
                    'Label Name
                    lb1.Visible = True
                    lb2.Visible = True
                    lb3.Visible = False
                    lb4.Visible = False
                    lb5.Visible = False
                    check_add_tn = 1
                    'Dap an
                    dapan1 = SplitString(cauhoi.Text, "<select1>", "</select1>")
                    slct1.Visible = True
                    slct1.Text = dapan1
                    slct4.Visible = False
                    slct3.Visible = False
                    slct2.Visible = False
                End If
            Else
                txt_dap.Visible = True
                dapantn.Items.Clear()
                dapantn.Visible = False
                slct1.Visible = False
                slct2.Visible = False
                slct3.Visible = False
                slct4.Visible = False
                slct1.Clear()
                slct2.Clear()
                slct3.Clear()
                slct4.Clear()
                lb1.Visible = False
                lb2.Visible = False
                lb3.Visible = False
                lb4.Visible = False
                lb5.Visible = False
                tnkia = 0
                txt_dap.Enabled = True
                LưuLạiToolStripMenuItem.Enabled = True
                ThemAddToolStripMenuItem.Enabled = True
                ThêmÔTrắcNghiệmToolStripMenuItem.Enabled = False
            End If
            ' MsgBox(lst_cauhoi.SelectedIndex)
            ' Dim kps As Regex = Regex.Match(data.Text, "<></\>")
        Else
            'Nothing is
        End If
    End Sub



    Private Sub bt_save_Click(sender As Object, e As EventArgs)
        checkcauhoi()
    End Sub



    Private Sub LàmMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LàmMớiToolStripMenuItem.Click
        txt_dap.Clear()
        txt_hoi.Clear()
        slct1.Clear()
        slct2.Clear()
        slct3.Clear()
        slct4.Clear()
        ' MsgBox("Đã làm mới!", vbInformation, "Báo cáo")
        lb_sts.Text = "Tình trạng: Đã làm mới!"
        Me.Text = "Trình chỉnh sửa dữ liệu"
    End Sub

    Private Sub TệpMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TệpMớiToolStripMenuItem.Click
        If data.Text = luutamdata.Text Then
            Dim homek As New thongtin
            homek.Show()
            Me.Hide()
        Else
            CustomMessageBox.CustomMsgBox(New String() {"Lưu", "Không lưu", "Hủy bỏ"})
            Dim result As Integer = MessageBox.Show("Dữ liệu của bạn chưa được lưu, bạn có chắc muốn thoát chứ?",
           "Cảnh báo!",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button3)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.Yes Then
                checkcauhoi()
                Dim homek As New thongtin
                homek.Show()
                Me.Hide()
            ElseIf result = DialogResult.No Then
                Dim homek As New thongtin
                homek.Show()
                Me.Hide()
            End If
        End If


    End Sub

    Private Sub The5ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim homek As New thongtin
        homek.Show()
        Me.Hide()
    End Sub

    Private Sub The5ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ThemAddToolStripMenuItem.Click
        editv1.pathfile.Text = pathfile.Text
        editv1.numsv.Text = data_base
        editv1.sota.Text = "true"
        editv1.Show()
        Me.Close()
    End Sub

    Private Sub dapantn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dapantn.SelectedIndexChanged

    End Sub

    Private Sub LưuLạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LưuLạiToolStripMenuItem.Click
        checkcauhoi()
        check_add_tn = 0
        luutamdata.Text = data.Text
    End Sub

    Private Sub slct2_TextChanged(sender As Object, e As EventArgs) Handles slct2.TextChanged

    End Sub

    Private Sub slct3_TextChanged(sender As Object, e As EventArgs) Handles slct3.TextChanged

    End Sub

    Private Sub timkiem_menu_Click(sender As Object, e As EventArgs) Handles timkiem_menu.Click

        find_edit.Show()
        bt_show.Visible = False
        lb_sts.Text = "Tình trạng: Tìm kiếm"
        find_edit.Text = "Tìm kiếm - Trình sửa dữ liệu"
        find_edit.tab_list.TabPages.Item(0).Text = "Tìm kiếm"
        find_edit.txt_rp.Visible = False
        find_edit.bt_rp.Visible = False
        find_edit.bt_rp_all.Visible = False
        Me.Enabled = False
    End Sub

    Private Sub bt_show_Click(sender As Object, e As EventArgs) Handles bt_show.Click
        find_edit.Show()
        bt_show.Visible = False
    End Sub

    Private Sub thaythe_menu_Click(sender As Object, e As EventArgs) Handles thaythe_menu.Click

        find_edit.Show()
        bt_show.Visible = False
        lb_sts.Text = "Tình trạng: Thay thế"
        find_edit.Text = "Thay thế - Trình sửa dữ liệu"
        find_edit.tab_list.TabPages.Item(0).Text = "Thay thế"
        find_edit.txt_rp.Visible = True
        find_edit.bt_rp.Visible = True
        find_edit.bt_rp_all.Visible = True
        Me.Enabled = False
    End Sub



    Private Sub bt_add_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        If data.Text = luutamdata.Text Then
            End
        Else
            CustomMessageBox.CustomMsgBox(New String() {"Lưu", "Thoát", "Hủy bỏ"})
            Dim result As Integer = MessageBox.Show("Dữ liệu của bạn chưa được lưu, bạn có chắc muốn thoát chứ?",
           "Cảnh báo!",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button3)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.Yes Then
                checkcauhoi()
                End
            ElseIf result = DialogResult.No Then
                End
            End If
        End If
    End Sub

    Private Sub undo_all_Click(sender As Object, e As EventArgs) Handles undo_all.Click
        data.Text = luu_bandau.Text
        lst_cauhoi.Refresh()
        If lst_cauhoi.Items.Count > 0 Then
            lst_cauhoi.SelectedIndex = 0
        End If
        ' MsgBox("Đã hoàn tác tất cả!", vbInformation, "Thông báo")
        lb_sts.Text = "Tình trạng: Đã hoàn tác tất cả! "
    End Sub

    Private Sub undo_menu_Click(sender As Object, e As EventArgs) Handles undo_menu.Click
        undo_cauhoi()
        '  MsgBox("Đã khôi phục câu " + id_cahuhoi + "!", vbInformation, "Thông báo")
        lb_sts.Text = "Tình trạng: " & "Đã khôi phục câu " + id_cahuhoi + "!"
    End Sub
    Sub undo_cauhoi()
        Me.Text = lst_cauhoi.Text & ":" & SplitString(cauhoi_dapantam.Text, "<cauhoi>", "</cauhoi>")
        If Me.Text.Length = 0 Then
            Me.Text = "Trình chỉnh sửa dữ liệu"
        End If
        dapantn.Items.Clear()
        txt_hoi.Text = SplitString(cauhoi_dapantam.Text, "<cauhoi>", "</cauhoi>")
        txt_dap.Text = SplitString(cauhoi_dapantam.Text, "<ketqua>", "</ketqua>")
        ' txt_hoi.Text = cauhoi.Text
        If txt_dap.Text.Length = 0 Then
            txt_dap.Enabled = False
            txt_dap.Text = "Bạn không thể sửa đổi câu hỏi này, vì:" & vbNewLine & "-  Câu hỏi này không có hoặc dữ liệu rỗng" & vbNewLine & "-  Bạn đang mở một tệp không tạo ra từ trình tạo dữ liệu"
            LưuLạiToolStripMenuItem.Enabled = False
            '  ThemAddToolStripMenuItem.Enabled = False
        ElseIf txt_dap.Text.Length = 1 Then
            tnkia = 1
            txt_dap.Visible = False
            dapantn.Visible = True
            dapantn.Items.Add(txt_dap.Text)
            dapantn.SelectedIndex = dapantn.FindStringExact(txt_dap.Text)
            If cauhoi_dapantam.Text.Contains("<select4>") Then 'Chon lua 4
                'Label Name
                lb1.Visible = True
                lb2.Visible = True
                lb3.Visible = True
                lb4.Visible = True
                lb5.Visible = True
                'Dap an Items
                If txt_dap.Text = "A" Then
                    dapantn.Items.Add("B")
                    dapantn.Items.Add("C")
                    dapantn.Items.Add("D")
                ElseIf txt_dap.Text = "B" Then
                    dapantn.Items.Add("A")
                    dapantn.Items.Add("C")
                    dapantn.Items.Add("D")
                ElseIf txt_dap.Text = "C" Then
                    dapantn.Items.Add("A")
                    dapantn.Items.Add("B")
                    dapantn.Items.Add("D")
                ElseIf txt_dap.Text = "D" Then
                    dapantn.Items.Add("A")
                    dapantn.Items.Add("B")
                    dapantn.Items.Add("C")
                End If
                'Dap an KQ
                dapan4 = SplitString(cauhoi_dapantam.Text, "<select4>", "</select4>")
                slct4.Visible = True
                slct4.Text = dapan4
                dapan3 = SplitString(cauhoi_dapantam.Text, "<select3>", "</select3>")
                slct3.Visible = True
                slct3.Text = dapan3
                dapan2 = SplitString(cauhoi_dapantam.Text, "<select2>", "</select2>")
                slct2.Visible = True
                slct2.Text = dapan2
                dapan1 = SplitString(cauhoi_dapantam.Text, "<select1>", "</select1>")
                slct1.Visible = True
                slct1.Text = dapan1
            ElseIf cauhoi_dapantam.Text.Contains("<select3>") Then 'Chon lua 3
                'Label Name
                lb1.Visible = True
                lb2.Visible = True
                lb3.Visible = True
                lb4.Visible = True
                lb5.Visible = False
                'Dap an Items
                If txt_dap.Text = "A" Then
                    dapantn.Items.Add("B")
                    dapantn.Items.Add("C")
                ElseIf txt_dap.Text = "B" Then
                    dapantn.Items.Add("A")
                    dapantn.Items.Add("C")
                ElseIf txt_dap.Text = "C" Then
                    dapantn.Items.Add("A")
                    dapantn.Items.Add("B")
                End If
                'Dap an KQ
                dapan3 = SplitString(cauhoi_dapantam.Text, "<select3>", "</select3>")
                slct3.Visible = True
                slct3.Text = dapan3
                dapan2 = SplitString(cauhoi_dapantam.Text, "<select2>", "</select2>")
                slct2.Visible = True
                slct2.Text = dapan2
                dapan1 = SplitString(cauhoi_dapantam.Text, "<select1>", "</select1>")
                slct1.Visible = True
                slct1.Text = dapan1
                slct4.Visible = False
            ElseIf cauhoi_dapantam.Text.Contains("<select2>") Then
                'Label Name
                lb1.Visible = True
                lb2.Visible = True
                lb3.Visible = True
                lb4.Visible = False
                lb5.Visible = False
                'Dap an Items
                If txt_dap.Text = "A" Then
                    dapantn.Items.Add("B")
                ElseIf txt_dap.Text = "B" Then
                    dapantn.Items.Add("A")
                End If
                'Dap an KQ
                dapan2 = SplitString(cauhoi_dapantam.Text, "<select2>", "</select2>")
                slct2.Visible = True
                slct2.Text = dapan2
                dapan1 = SplitString(cauhoi_dapantam.Text, "<select1>", "</select1>")
                slct1.Visible = True
                slct1.Text = dapan1
                slct4.Visible = False
                slct3.Visible = False
            ElseIf cauhoi.Text.Contains("<select1>") Then
                'Label Name
                lb1.Visible = True
                lb2.Visible = True
                lb3.Visible = False
                lb4.Visible = False
                lb5.Visible = False
                'Dap an
                dapan1 = SplitString(cauhoi_dapantam.Text, "<select1>", "</select1>")
                slct1.Visible = True
                slct1.Text = dapan1
                slct4.Visible = False
                slct3.Visible = False
                slct2.Visible = False
            End If
        Else
            txt_dap.Visible = True
            dapantn.Items.Clear()
            dapantn.Visible = False
            slct1.Visible = False
            slct2.Visible = False
            slct3.Visible = False
            slct4.Visible = False
            slct1.Clear()
            slct2.Clear()
            slct3.Clear()
            slct4.Clear()
            lb1.Visible = False
            lb2.Visible = False
            lb3.Visible = False
            lb4.Visible = False
            lb5.Visible = False
            tnkia = 0
            txt_dap.Enabled = True
            LưuLạiToolStripMenuItem.Enabled = True
            ThemAddToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub xuat_word_Click(sender As Object, e As EventArgs) Handles xuat_word.Click
        ' If IsWordRunning() = True Then
        '  MsgBox("Tiến trình Word đang chạy...")
        ' Else
        lb_sts.Text = "Tình trạng: Xuất file Word..."
        Dim xuatwordfs As New word_file
        xuatwordfs.Show()
        xam_note.Text = "1"
        Me.Enabled = False
        Me.Hide()
        ' End If

    End Sub

    Private Sub ThêmÔTrắcNghiệmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmÔTrắcNghiệmToolStripMenuItem.Click
        If check_add_tn = 2 Then
            lb_sts.Text = "Tình trạng: Đã thêm ô câu hỏi!"
            slct3.Visible = True
            lb4.Visible = True
            slct3.Clear()
            dapantn.Items.Add("C")
            check_add_tn = 3
            'check_dapan(3)
        ElseIf check_add_tn = 3 Then
            slct4.Clear()
            slct4.Visible = True
            lb5.Visible = True
            dapantn.Items.Add("D")
            lb_sts.Text = "Tình trạng: Đã thêm ô câu hỏi!"
            check_add_tn = 4
            '  check_dapan(4)
            ThêmÔTrắcNghiệmToolStripMenuItem.Enabled = False
        ElseIf check_add_tn = 1 Then
            slct2.Visible = True
            lb3.Visible = True
            slct2.Clear()
            dapantn.Items.Add("B")
            lb_sts.Text = "Tình trạng: Đã thêm ô câu hỏi!"
            check_add_tn = 2
            ' check_dapan(2)
        ElseIf slct4.Visible = True Then
            MsgBox("Bạn chỉ có thể thêm tối đa 4 đáp án trắc nghiệm!", vbInformation, "Thông tin")
            lb_sts.Text = "Tình trạng: Bạn chỉ có thể thêm tối đa 4 đáp án trắc nghiệm!"
            ThêmÔTrắcNghiệmToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub TùyChỉnhXuấtWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TùyChỉnhXuấtWordToolStripMenuItem.Click
        word_tuychon.Show()
        Me.Enabled = False
    End Sub

    Private Sub xoacauhoi_menu_Click(sender As Object, e As EventArgs) Handles xoacauhoi_menu.Click
        CustomMessageBox.CustomMsgBox(New String() {"Có", "Không"})
        Dim result As Integer = MessageBox.Show("Bạn có thật sự muốn xóa câu hỏi " & id_cahuhoi & " chứ?" & vbNewLine & "Sau khi xóa bạn sẽ không thể khôi phục!",
       "Cảnh báo!",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            delete_cauhoi(id_cahuhoi)
        ElseIf result = DialogResult.No Then

        End If
    End Sub

    Sub delete_cauhoi(num_del As String)
        Dim xoatamthoi As String = SplitString(data.Text, "<" & id_cahuhoi - 1 & ">", "</" & id_cahuhoi - 1 & ">")
        'Xoa luon cau hoi roi luu luon!
        data.Text = data.Text.Replace("<" & id_cahuhoi - 1 & ">" & xoatamthoi & "</" & id_cahuhoi - 1 & ">", "")
        'MsgBox ("")
        lst_cauhoi.SelectedIndex = id_cahuhoi - 1
        lst_cauhoi.Items.Remove(lst_cauhoi.SelectedItem)
        sapxeplai_list()
    End Sub

    Sub sapxeplai_list()
        '    Me.Enabled = False
        'Qua trinh status
        Me.Hide()
        ' Me.Text = "Đang sắp lại danh sách câu hỏi... Vui lòng đợi trong giây lát!"
        '  menu_edit.Enabled = False
        ' lst_cauhoi.Enabled = False
        ' txt_dap.Visible = True
        '  txt_dap.Enabled = False
        ' txt_hoi.Enabled = False

        ' saplaicauhoi.Show()
        'Bat dau sap xep
        Dim luutamlist_a As New ListBox
        For numkki As Integer = 0 To lst_cauhoi.Items.Count - 1
            lst_cauhoi.SelectedIndex = numkki
            Dim numphaitru As String = lst_cauhoi.SelectedItem.ToString.ToLower.Replace("câu hỏi ", "").Trim
            numphaitru = numphaitru - 1
            luutamlist_a.Items.Add(numphaitru)
        Next numkki
        Dim luutamtext_a As New TextBox
        luutamtext_a.Multiline = True
        lst_cauhoi.Items.Clear()
        Dim pass_cu As String = "<pass>" & SplitString(data.Text, "<pass>", "</pass>") & "</pass>"
        Dim about_cu As String = "<about>" & SplitString(data.Text, "<about>", "</about>") & "</about>"
        luutamtext_a.Text = luutamtext_a.Text & pass_cu & about_cu
        For num_new_lst As Integer = 0 To luutamlist_a.Items.Count - 1
            luutamlist_a.SelectedIndex = num_new_lst
            '  MsgBox(luutamlist_a.SelectedItem.ToString)
            Dim so_cauht As String = luutamlist_a.SelectedItem.ToString

            'luuam_datat.Multiline = True
            Dim num_start As String = "<" & num_new_lst & ">"
            Dim num_end As String = "</" & num_new_lst & ">"
            Dim cauhoitam_b As New TextBox
            cauhoitam_b.Multiline = True
            cauhoitam_b.Text = SplitString(data.Text, "<" & so_cauht & ">", "</" & so_cauht & ">")

            luutamtext_a.Text = luutamtext_a.Text & num_start & cauhoitam_b.Text & num_end
            lst_cauhoi.Items.Add("Câu hỏi " & num_new_lst + 1)
        Next num_new_lst
        'Sao luu qua data.txt roi don sach se
        data.Text = luutamtext_a.Text
        luutamdata.Text = luutamtext_a.Text
        luu_bandau.Text = luutamtext_a.Text
        cauhoi_dapantam.Clear()
        dapantn.Items.Clear()
        'Don du lieu sap xep
        luutamlist_a.Items.Clear()
        luutamtext_a.Clear()
        ' luutamdata.Clear()

        'Khoi phuc status
        '  menu_edit.Enabled = True
        '  lst_cauhoi.Enabled = True
        '  txt_dap.Visible = False
        ' txt_dap.Enabled = True
        ' txt_hoi.Enabled = True
        '  saplaicauhoi.Close()
        If lst_cauhoi.Items.Count > 0 Then
            lst_cauhoi.SelectedIndex = 0
        End If
        'Me.Enabled = True
        'Luu sao khi sap xep
        checkcauhoi()
        lb_sts.Text = lb_sts.Text & " - Đã sắp xếp lại danh sách câu hỏi!"
        Me.Show()
    End Sub
    Private Sub dapantn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dapantn.KeyPress
        e.Handled = True
    End Sub

    Private Sub right_n_Click(sender As Object, e As EventArgs) Handles right_n.Click
        txt_num_next.Text += 1
        If txt_num_next.Text - 1 = lst_cauhoi.Items.Count Then
            txt_num_next.Text -= 1
            right_n.Enabled = False
            left_n.Enabled = True
        Else
            lst_cauhoi.SelectedIndex = txt_num_next.Text - 1
            left_n.Enabled = True
        End If
    End Sub

    Private Sub left_n_Click(sender As Object, e As EventArgs) Handles left_n.Click
        txt_num_next.Text -= 1
        If txt_num_next.Text = 0 Then
            txt_num_next.Text += 1
            left_n.Enabled = False
            right_n.Enabled = True
        Else
            lst_cauhoi.SelectedIndex = txt_num_next.Text - 1
            right_n.Enabled = True
        End If
    End Sub

    Private Sub txt_num_next_TextChanged(sender As Object, e As EventArgs) Handles txt_num_next.TextChanged

    End Sub

    Private Sub trinhedit_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

    End Sub

    Private Sub trinhedit_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If m_iMessage = WM_FORMCONTROLMENU Then
            If data.Text = luutamdata.Text Then

            Else
                end_thoat(e)
            End If
        End If
    End Sub

    Sub end_thoat(e As CancelEventArgs)
        ' MsgBox("Dữ liệu của bạn chưa được lưu, bạn có chắc muốn thoát?", vbInformation, "Cảnh báo!")
        CustomMessageBox.CustomMsgBox(New String() {"Lưu", "Thoát", "Hủy bỏ"})
        Dim result As Integer = MessageBox.Show("Dữ liệu của bạn chưa được lưu, bạn có chắc muốn thoát chứ?",
       "Cảnh báo!",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then
            e.Cancel = True
        ElseIf result = DialogResult.Yes Then
            checkcauhoi()
            End
        ElseIf result = DialogResult.No Then
            End
        End If
    End Sub
    Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function
    Private Sub txt_num_next_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_next.KeyDown
        If e.KeyCode = Keys.Enter Then
            '    MessageBox.Show("Enter key pressed")
            If txt_num_next.Text >= lst_cauhoi.Items.Count + 1 Then
                txt_num_next.Text = lst_cauhoi.Items.Count
                lst_cauhoi.SelectedIndex = lst_cauhoi.Items.Count - 1
            ElseIf txt_num_next.Text <= 0 Then
                txt_num_next.Text = lst_cauhoi.Items.Count
                lst_cauhoi.SelectedIndex = 0
            Else
                lst_cauhoi.SelectedIndex = txt_num_next.Text - 1
            End If
        End If
    End Sub

    Private Sub txt_num_next_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num_next.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub
End Class