Imports System.ComponentModel

Public Class find_edit

    Private m_iMessage As Integer
    Private Shared WM_QUERYENDSESSION As Integer = &H11 'this is a logoff, shutdown, or reboot
    Private Shared WM_FORMCONTROLMENU As Integer = 16 'form closed via form control menu
    Dim num_find As String = 0
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        m_iMessage = m.Msg

        ' If this is WM_QUERYENDSESSION, the closing event should be fired in the base WndProc
        MyBase.WndProc(m)

    End Sub 'WndProc
    Private Sub bt_find_Click(sender As Object, e As EventArgs) Handles bt_find.Click
        find()
    End Sub
    Sub find()
        '  If Str.Contains("TOP") = True Then
        '   MsgBox("The string Contains() 'TOP' ")
        '    Else
        '  MsgBox("The String does not Contains() 'TOP'")
        '   End If
        num_find = 0
        lst_kq.Items.Clear()
        lb_kq.Text = ""
        trinhedit.lst_cauhoi.SelectedIndex = -1
        Dim num0 As Byte
        For num0 = 0 To trinhedit.lst_cauhoi.Items.Count.ToString - 1
            trinhedit.lst_cauhoi.SelectedIndex = num0
            Dim text_de As String = StrConv(trinhedit.txt_hoi.Text, 2)
            Dim txt_dp As String = StrConv(trinhedit.txt_dap.Text, 2)
            Dim tn_1 As String = StrConv(trinhedit.slct1.Text, 2)
            Dim tn_2 As String = StrConv(trinhedit.slct2.Text, 2)
            Dim tn_3 As String = StrConv(trinhedit.slct3.Text, 2)
            Dim tn_4 As String = StrConv(trinhedit.slct4.Text, 2)
            Dim find_txt As String = StrConv(txt_find.Text, 2)
            If ck2.Checked = True Then
                If txt_dp.Contains(find_txt) = True Or tn_1.Contains(find_txt) = True Or tn_2.Contains(find_txt) = True Or tn_3.Contains(find_txt) = True Or tn_4.Contains(find_txt) = True Then
                    lst_kq.Items.Add(trinhedit.lst_cauhoi.Text)
                    num_find = num_find + 1
                End If
            ElseIf ck1.Checked = True Then
                If text_de.Contains(find_txt) = True Then
                    lst_kq.Items.Add(trinhedit.lst_cauhoi.Text)
                    num_find = num_find + 1
                End If
            ElseIf ck3.Checked = True Then
                If text_de.Contains(find_txt) = True Or txt_dp.Contains(find_txt) = True Or tn_1.Contains(find_txt) = True Or tn_2.Contains(find_txt) = True Or tn_3.Contains(find_txt) = True Or tn_4.Contains(find_txt) = True Then
                    lst_kq.Items.Add(trinhedit.lst_cauhoi.Text)
                    num_find = num_find + 1
                End If
            End If
        Next
        lb_kq.Text = "Tìm thấy " + num_find + " kết quả từ " + trinhedit.lst_cauhoi.Items.Count.ToString + " câu hỏi!"
        If num_find > 0 Then
            lst_kq.Enabled = True
            lb_goiy.Visible = True
            bt_edit.Enabled = True
        Else
            lst_kq.Enabled = False
            lb_goiy.Visible = False
            bt_edit.Enabled = False
        End If
    End Sub
    Sub rp_quest()
        trinhedit.data.Text = trinhedit.data.Text.Replace(trinhedit.cauhoi.Text, "<cauhoi>" & trinhedit.txt_hoi.Text & "</cauhoi>" & "<ketqua>" & trinhedit.txt_dap.Text & "</ketqua>")
    End Sub
    Sub rpall()
        '  If Str.Contains("TOP") = True Then
        '   MsgBox("The string Contains() 'TOP' ")
        '    Else
        '  MsgBox("The String does not Contains() 'TOP'")
        '   End If
        num_find = 0
        lst_kq.Items.Clear()
        lb_kq.Text = ""
        trinhedit.lst_cauhoi.SelectedIndex = -1
        Dim num0 As Byte
        For num0 = 0 To trinhedit.lst_cauhoi.Items.Count.ToString - 1
            trinhedit.lst_cauhoi.SelectedIndex = num0
            Dim text_de As String = StrConv(trinhedit.txt_hoi.Text, 2)
            Dim txt_dp As String = StrConv(trinhedit.txt_dap.Text, 2)
            Dim tn_1 As String = StrConv(trinhedit.slct1.Text, 2)
            Dim tn_2 As String = StrConv(trinhedit.slct2.Text, 2)
            Dim tn_3 As String = StrConv(trinhedit.slct3.Text, 2)
            Dim tn_4 As String = StrConv(trinhedit.slct4.Text, 2)
            Dim find_txt As String = StrConv(txt_find.Text, 2)
            Dim rp_txt As String = StrConv(txt_rp.Text, 2)
            If ck2.Checked = True Then
                If txt_dp.Contains(find_txt) = True Or tn_1.Contains(find_txt) = True Or tn_2.Contains(find_txt) = True Or tn_3.Contains(find_txt) = True Or tn_4.Contains(find_txt) = True Then
                    lst_kq.Items.Add(trinhedit.lst_cauhoi.Text)
                    num_find = num_find + 1
                    'UppercaseFirstLetter and Replace Answer
                    trinhedit.txt_dap.Text = UppercaseFirstLetter(txt_dp.Replace(find_txt, rp_txt))
                    trinhedit.slct1.Text = UppercaseFirstLetter(tn_1.Replace(find_txt, rp_txt))
                    trinhedit.slct2.Text = UppercaseFirstLetter(tn_2.Replace(find_txt, rp_txt))
                    trinhedit.slct3.Text = UppercaseFirstLetter(tn_3.Replace(find_txt, rp_txt))
                    trinhedit.slct4.Text = UppercaseFirstLetter(tn_4.Replace(find_txt, rp_txt))
                    rp_quest()
                End If
            ElseIf ck1.Checked = True Then
                If text_de.Contains(find_txt) = True Then
                    lst_kq.Items.Add(trinhedit.lst_cauhoi.Text)
                    num_find = num_find + 1
                    'UppercaseFirstLetter and Replace Question
                    trinhedit.txt_hoi.Text = UppercaseFirstLetter(text_de.Replace(find_txt, rp_txt))
                    rp_quest()
                End If
            ElseIf ck3.Checked = True Then
                If text_de.Contains(find_txt) = True Or txt_dp.Contains(find_txt) = True Or tn_1.Contains(find_txt) = True Or tn_2.Contains(find_txt) = True Or tn_3.Contains(find_txt) = True Or tn_4.Contains(find_txt) = True Then
                    lst_kq.Items.Add(trinhedit.lst_cauhoi.Text)
                    num_find = num_find + 1
                    'UppercaseFirstLetter and Replace All
                    trinhedit.txt_hoi.Text = UppercaseFirstLetter(text_de.Replace(find_txt, rp_txt))
                    trinhedit.txt_dap.Text = UppercaseFirstLetter(txt_dp.Replace(find_txt, rp_txt))
                    trinhedit.slct1.Text = UppercaseFirstLetter(tn_1.Replace(find_txt, rp_txt))
                    trinhedit.slct2.Text = UppercaseFirstLetter(tn_2.Replace(find_txt, rp_txt))
                    trinhedit.slct3.Text = UppercaseFirstLetter(tn_3.Replace(find_txt, rp_txt))
                    trinhedit.slct4.Text = UppercaseFirstLetter(tn_4.Replace(find_txt, rp_txt))
                    rp_quest()
                End If
            End If
        Next
        lb_kq.Text = "Tìm thấy " + num_find + " kết quả từ " + trinhedit.lst_cauhoi.Items.Count.ToString + " câu hỏi!"
        If num_find > 0 Then
            lst_kq.Enabled = True
            lb_goiy.Visible = True
            bt_edit.Enabled = True
        Else
            lst_kq.Enabled = False
            lb_goiy.Visible = False
            bt_edit.Enabled = False
        End If

        MsgBox("Đã thay thế tất cả!" + vbNewLine + "Tắt trình thay thế, sau đó nhấn Ctrl + S để lưu!", vbInformation, "Thông báo")
    End Sub
    Private Sub find_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub find_edit_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If m_iMessage = WM_FORMCONTROLMENU Then
            trinhedit.Enabled = True
            trinhedit.bt_show.Visible = False
        End If
    End Sub

    Private Sub lst_kq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_kq.SelectedIndexChanged
        bt_edit.Enabled = True
        selectkq()
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        If Not lst_kq.SelectedItem IsNot Nothing Then
            MsgBox("Bạn chưa chọn kết quả tìm kiếm nào!", vbInformation, "Cảnh báo!")
        Else
            clicksua()
        End If
    End Sub
    Sub clicksua()
        ' Me.TopMost = True
        Dim tachnum As String = ""
        tachnum = lst_kq.Text.Replace("Câu hỏi ", "").Trim
        trinhedit.lst_cauhoi.SelectedIndex = tachnum - 1
        trinhedit.Enabled = True
        Me.Hide()
        trinhedit.bt_show.Visible = True
        '  Me.Opacity = 0.75
    End Sub
    Private Sub theodoian_Tick(sender As Object, e As EventArgs) Handles theodoian.Tick

    End Sub

    Private Sub find_edit_Click(sender As Object, e As EventArgs) Handles Me.Click
        '  Me.Opacity = 100%
    End Sub


    Private Sub find_tab_MouseMove(sender As Object, e As MouseEventArgs) Handles find_tab.MouseMove

    End Sub

    Private Sub tab_list_MouseClick(sender As Object, e As MouseEventArgs) Handles tab_list.MouseClick
        If tab_list.SelectedIndex = 0 Then
            Me.Text = "Tìm kiếm - Trình sửa dữ liệu"
        ElseIf tab_list.SelectedIndex = 1 Then
            Me.Text = "Thay thế - Trình sửa dữ liệu"
        End If
    End Sub

    Private Sub txt_find_TextChanged(sender As Object, e As EventArgs) Handles txt_find.TextChanged

    End Sub

    Private Sub txt_find_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_find.KeyDown
        If e.KeyCode = Keys.Enter Then
            find()
        End If
    End Sub

    Private Sub lst_kq_Click(sender As Object, e As EventArgs) Handles lst_kq.Click
        selectkq()
    End Sub
    Sub selectkq()
        Dim tachnum As String = ""
        tachnum = lst_kq.Text.Replace("Câu hỏi ", "").Trim
        '  If trinhedit.lst_cauhoi.SelectedIndex >= 0 Then
        'trinhedit.lst_cauhoi.SelectedIndex = tachnum - 1
        ' Else
        trinhedit.lst_cauhoi.SelectedIndex = tachnum - 1
        ' End If
        '  MsgBox(tachnum)
    End Sub

    Private Sub lst_kq_DoubleClick(sender As Object, e As EventArgs) Handles lst_kq.DoubleClick
        clicksua()
    End Sub

    Private Sub ck2_Click(sender As Object, e As EventArgs) Handles ck2.Click
        ck1.Checked = False
        ck2.Checked = True
        ck3.Checked = False
    End Sub

    Private Sub ck1_Click(sender As Object, e As EventArgs) Handles ck1.Click
        ck2.Checked = False
        ck1.Checked = True
        ck3.Checked = False
    End Sub

    Private Sub ck3_Click(sender As Object, e As EventArgs) Handles ck3.Click
        ck1.Checked = False
        ck2.Checked = False
        ck3.Checked = True
    End Sub

    Private Sub bt_rp_all_Click(sender As Object, e As EventArgs) Handles bt_rp_all.Click
        rpall()
    End Sub

    Private Sub bt_rp_Click(sender As Object, e As EventArgs) Handles bt_rp.Click
        ' num_find = 0
        '  lst_kq.Items.Clear()
        ' lb_kq.Text = ""
        If trinhedit.lst_cauhoi.SelectedIndex >= -1 Then
            ' trinhedit.lst_cauhoi.SelectedIndex = num0
            Dim text_de As String = StrConv(trinhedit.txt_hoi.Text, 2)
            Dim txt_dp As String = StrConv(trinhedit.txt_dap.Text, 2)
            Dim tn_1 As String = StrConv(trinhedit.slct1.Text, 2)
            Dim tn_2 As String = StrConv(trinhedit.slct2.Text, 2)
            Dim tn_3 As String = StrConv(trinhedit.slct3.Text, 2)
            Dim tn_4 As String = StrConv(trinhedit.slct4.Text, 2)
            Dim find_txt As String = StrConv(txt_find.Text, 2)
            Dim rp_txt As String = StrConv(txt_rp.Text, 2)
            If ck2.Checked = True Then
                If txt_dp.Contains(find_txt) = True Or tn_1.Contains(find_txt) = True Or tn_2.Contains(find_txt) = True Or tn_3.Contains(find_txt) = True Or tn_4.Contains(find_txt) = True Then
                    lst_kq.Items.Add(trinhedit.lst_cauhoi.Text)
                    num_find = num_find + 1
                    'UppercaseFirstLetter and Replace Answer
                    trinhedit.txt_dap.Text = UppercaseFirstLetter(txt_dp.Replace(find_txt, rp_txt))
                    trinhedit.slct1.Text = UppercaseFirstLetter(tn_1.Replace(find_txt, rp_txt))
                    trinhedit.slct2.Text = UppercaseFirstLetter(tn_2.Replace(find_txt, rp_txt))
                    trinhedit.slct3.Text = UppercaseFirstLetter(tn_3.Replace(find_txt, rp_txt))
                    trinhedit.slct4.Text = UppercaseFirstLetter(tn_4.Replace(find_txt, rp_txt))
                    rp_quest()
                End If
            ElseIf ck1.Checked = True Then
                If text_de.Contains(find_txt) = True Then
                    lst_kq.Items.Add(trinhedit.lst_cauhoi.Text)
                    num_find = num_find + 1
                    'UppercaseFirstLetter and Replace Question
                    trinhedit.txt_hoi.Text = UppercaseFirstLetter(text_de.Replace(find_txt, rp_txt))
                    rp_quest()
                End If
            ElseIf ck3.Checked = True Then
                If text_de.Contains(find_txt) = True Or txt_dp.Contains(find_txt) = True Or tn_1.Contains(find_txt) = True Or tn_2.Contains(find_txt) = True Or tn_3.Contains(find_txt) = True Or tn_4.Contains(find_txt) = True Then
                    lst_kq.Items.Add(trinhedit.lst_cauhoi.Text)
                    num_find = num_find + 1
                    'UppercaseFirstLetter and Replace All
                    trinhedit.txt_hoi.Text = UppercaseFirstLetter(text_de.Replace(find_txt, rp_txt))
                    trinhedit.txt_dap.Text = UppercaseFirstLetter(txt_dp.Replace(find_txt, rp_txt))
                    trinhedit.slct1.Text = UppercaseFirstLetter(tn_1.Replace(find_txt, rp_txt))
                    trinhedit.slct2.Text = UppercaseFirstLetter(tn_2.Replace(find_txt, rp_txt))
                    trinhedit.slct3.Text = UppercaseFirstLetter(tn_3.Replace(find_txt, rp_txt))
                    trinhedit.slct4.Text = UppercaseFirstLetter(tn_4.Replace(find_txt, rp_txt))
                    rp_quest()
                End If
            End If

            If num_find > 0 Then
                lst_kq.Enabled = True
                lb_goiy.Visible = True
                bt_edit.Enabled = True
            Else
                lst_kq.Enabled = False
                lb_goiy.Visible = False
                bt_edit.Enabled = False
            End If
            MsgBox("Đã thay thế trên câu hỏi được chọn!")
        Else
            MsgBox("Chưa câu hỏi nào được chọn để thay thế!")
        End If
    End Sub

    Private Sub rp_tab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ck1_CheckedChanged(sender As Object, e As EventArgs) Handles ck1.CheckedChanged

    End Sub
End Class