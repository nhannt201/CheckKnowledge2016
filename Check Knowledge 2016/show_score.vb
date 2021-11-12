Imports System.Text.RegularExpressions

Public Class show_score
    Dim score_max As String = 8000
    Dim score_min As String = 0
    Dim consocu As String = 0
    ' Dim diemks As String = 0
    ' Dim get_the_score As New Label
    '  Private X As Integer


    Private Sub show_score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PostAction(51)
        play_all_program.Enabled = False
        If play_all_program.txt_auto_next.Text = "yes" Then
            ' play_all_program.txt_auto_next.Text = "yes"
            'ck_1.Checked = True
            auto_ans.Start()
        Else
            ' ck_1.Checked = False

        End If
        reset_next_time()
    End Sub
    Sub reset_next_time()
        play_all_program.auto_next.Stop()
        play_all_program.lb_num.Text = "60"
    End Sub
    Private Sub int_score_Tick(sender As Object, e As EventArgs) Handles int_score.Tick
        score_min = score_min + 1
        If score_min >= score_max Then
            If Len(txt_get.Text) = 2 Then
                lb_diem_int.Text = "0" & txt_get.Text

            ElseIf Len(txt_get.Text) = 1 Then
                lb_diem_int.Text = "00" & txt_get.Text
            Else
                '   diemks = txt_get.Text
                lb_diem_int.Text = txt_get.Text
                '  MsgBox(diemks)
            End If

            'score_to_show
            int_score.Stop()
        Else
            lb_diem_int.Text = Int(100 * Rnd()) * 10
        End If
    End Sub



    Private Sub lb_end_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_end.MouseMove
        lb_end.BackColor = Color.Red
    End Sub



    Private Sub p1_MouseMove(sender As Object, e As MouseEventArgs) Handles p1.MouseMove
        lb_end.BackColor = Color.White
    End Sub

    Private Sub bt_next_Click(sender As Object, e As EventArgs) Handles bt_next2.Click
        next_ans()
    End Sub

    Sub next_ans()
        PostAction(52)
        If My.Settings.st3 = "turn_on" Then
            If txt_get.Text <= 30 Then
                dapanshow.Show()
            End If
        Else
            play_all_program.TopMost = True
            Me.TopMost = False
        End If
        ' If play_all_program.tong2.Text = "NaN" Then
        '  Else
        ' play_all_program.tong1.Text = (Math.Round(Val((Val(txt_get.Text)) / 1000), 1) * 1000)
        ' play_all_program.tong2.Text = Math.Round(Val(play_all_program.tong1.Text / play_all_program.txt_socauhoi.Text))
        '  End If
        play_all_program.diemso.Items.Add(txt_get.Text)
         play_all_program.txt_socauhoi.Text = play_all_program.txt_socauhoi.Text + 1
        play_all_program.txt_tongdiem.Text = play_all_program.txt_tongdiem.Text + (Math.Round(Val((Val(txt_get.Text)) / 1000), 1) * 1000)
        play_all_program.tong1.Text = play_all_program.txt_socauhoi.Text
        play_all_program.tong2.Text = Math.Round(Val(play_all_program.txt_tongdiem.Text / play_all_program.txt_socauhoi.Text), 1)
        'bat dau lay cau hoi moi
        If My.Settings.st3 = "turn_on" Then
            If txt_get.Text <= 30 Then
            Else
                auto_send_get()
            End If
        Else
            auto_send_get()
        End If


    End Sub
    'cai chinh ma bi lo xiu
    Sub autoget2()
        'so ngau nhien
        Dim conso As String = Int((play_all_program.get_id_max.Text * Rnd()))
        'kiem tra trung lam lai
        ' If txt_tam.Text = conso Then
        ' If conso >= play_all_program.get_id_max.Text Then
        'conso = conso - 1
        'ElseIf conso < (play_all_program.get_id_max.Text) Then
        'conso = conso + 1
        'Else
        ' conso = Int((play_all_program.get_id_max.Text * Rnd()))
        '   End If
        ' txt_tam.Text = conso
        ' End If
        'kiem tra it lap lai xiu
        '  If conso = consocu Then
        ' conso = Int((play_all_program.get_id_max.Text * Rnd()))
        ' Else
        ' consocu = conso
        ' End If
        'lay cau hoi
        Dim lst1, lst2 As New List(Of Integer)
        lst1 = FindStringLoc(play_all_program.hoi.Text, "<" + conso + ">")
        lst2 = FindStringLoc(play_all_program.hoi.Text, "</" + conso + ">")
        play_all_program.cauhoi.Text = ""
        play_all_program.sostt2.Text = conso
        For i As Integer = 0 To lst1.Count - 1
            If i + 1 <= lst1.Count - 1 Then
                play_all_program.cauhoi.Text &= play_all_program.hoi.Text.Substring(lst1(i) + 0, lst2(i) - lst1(i) - 0) & vbNewLine
            Else
                play_all_program.cauhoi.Text &= play_all_program.hoi.Text.Substring(lst1(i) + 0, lst2(i) - lst1(i) - 0)
            End If
        Next
        play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "<" + conso + ">", "")
        play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "</" + conso + ">", "")
        ' class6.cauhoi.Text = Replace(class6.cauhoi.Text, "<cauhoi>", "")
        ' class6.cauhoi.Text = Replace(class6.cauhoi.Text, "</cauhoi>", "")
        play_all_program.xuli.Text = play_all_program.cauhoi.Text
        'cai ham dung cai xuli da doi xuong duoi
        'lay ket qua
        Dim lst3, lst4 As New List(Of Integer)
        lst3 = FindStringLoc(play_all_program.cauhoi.Text, "<ketqua>")
        lst4 = FindStringLoc(play_all_program.cauhoi.Text, "</ketqua>")
        play_all_program.dapanchuan.Text = ""
        play_all_program.traloi.Text = ""
        For i As Integer = 0 To lst3.Count - 1
            If i + 1 <= lst3.Count - 1 Then
                play_all_program.dapanchuan.Text &= play_all_program.cauhoi.Text.Substring(lst3(i) + 0, lst4(i) - lst3(i) - 0) & vbNewLine
            Else
                play_all_program.dapanchuan.Text &= play_all_program.cauhoi.Text.Substring(lst3(i) + 0, lst4(i) - lst3(i) - 0)
            End If
        Next
        'lay cau hoi trong
        Dim lst5, lst6 As New List(Of Integer)
        lst5 = FindStringLoc(play_all_program.xuli.Text, "<cauhoi>")
        lst6 = FindStringLoc(play_all_program.xuli.Text, "</cauhoi>")
        play_all_program.cauhoi.Text = ""
        For i As Integer = 0 To lst3.Count - 1
            If i + 1 <= lst3.Count - 1 Then
                play_all_program.cauhoi.Text &= play_all_program.xuli.Text.Substring(lst5(i) + 0, lst6(i) - lst5(i) - 0) & vbNewLine
            Else
                play_all_program.cauhoi.Text &= play_all_program.xuli.Text.Substring(lst5(i) + 0, lst6(i) - lst5(i) - 0)
            End If
        Next
        play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "<cauhoi>", "")
        play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "</cauhoi>", "")
        play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "<ketqua>", "")
        play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "</ketqua>", "")
        'phan kiem tra trac nghiem
        If play_all_program.xuli.Text.Contains("<type>trn_abc</type>") Then
            play_all_program.luachonkq.Visible = True
            play_all_program.traloi.Enabled = False
            laydapan("select1")
            laydapan("select2")
            laydapan("select3")
            laydapan("select4")
            'Phuong thuc lay kq cu chuyen thanh laydapan()
            '   MsgBox("hien thu co chay lenh cho nay hay khong")
            '  Dim dap1 As Match = Regex.Match(play_all_program.xuli.Text, "<select1>(.*?)</select1\>")
            '  Dim dap2 As Match = Regex.Match(play_all_program.xuli.Text, "<select2>(.*?)</select2\>")
            '  Dim dap3 As Match = Regex.Match(play_all_program.xuli.Text, "<select3>(.*?)</select3\>")
            '  Dim dap4 As Match = Regex.Match(play_all_program.xuli.Text, "<select4>(.*?)</select4\>")

            '  If (dap1.Success) Then
            'play_all_program.cauhoi.Text = play_all_program.cauhoi.Text & vbNewLine & "A." & (dap1.Groups(1).Value)
            'End If
        Else
            play_all_program.luachonkq.Visible = False
            play_all_program.traloi.Enabled = True
            'lam moi lua chon ket qua
            resetAllControls(play_all_program)
        End If
        'ket thuc lay cau hoi moi
        resetAllControls(play_all_program)
        Me.Hide()
        Me.Close()
        'kiem tra cau hoi trong
        If play_all_program.cauhoi.Text.Length < 2 Then
            play_all_program.traloi.Enabled = False
            play_all_program.traloi.Text = "Nhấn Bỏ qua để sang câu hỏi kế tiếp"
            '   thongke.lb_tong.Text = thongke.lb_tong.Text - 1
        Else
            play_all_program.traloi.Enabled = True
            play_all_program.traloi.Clear()
        End If
        autonext()
    End Sub
    'TEST
    Sub auto_send_get()
        Dim conso As String = Int((play_all_program.get_id_max.Text * Rnd()))
        '   Dim conso As String = Int((conso2 * Rnd()))
        Dim lst1 As String = SplitString(play_all_program.hoi.Text, "<" + conso + ">", "</" + conso + ">")
        ' play_all_program.cauhoi.Text = ""
        play_all_program.sostt2.Text = conso
        play_all_program.cauhoi.Text = lst1
        play_all_program.xuli.Text = play_all_program.cauhoi.Text
        Dim lst2 As String = SplitString(lst1, "<ketqua>", "</ketqua>")
        ' play_all_program.dapanchuan.Text = ""
        play_all_program.traloi.Text = ""
        play_all_program.dapanchuan.Text = lst2
        play_all_program.dapannguyen.Text = lst2
        ' play_all_program.dapan_khisai.Text =
        'CHeck dap an sang form chinh
        If lst2 = "A" Then
            play_all_program.dapan_khisai.Text = SplitString(lst1, "<select1>", "</select1>")
        ElseIf lst2 = "B" Then
            play_all_program.dapan_khisai.Text = SplitString(lst1, "<select2>", "</select2>")
        ElseIf lst2 = "C" Then
            play_all_program.dapan_khisai.Text = SplitString(lst1, "<select3>", "</select3>")
        ElseIf lst2 = "D" Then
            play_all_program.dapan_khisai.Text = SplitString(lst1, "<select4>", "</select4>")
        End If
        Dim lst3 As String = SplitString(lst1, "<cauhoi>", "</cauhoi>")
        '  play_all_program.dapanchuan.Text = ""
        play_all_program.traloi.Text = ""
        ' play_all_program.cauhoi.Text = ""
        play_all_program.cauhoi.Text = lst3
        'phan kiem tra trac nghiem
        If play_all_program.xuli.Text.Contains("<type>trn_abc</type>") Then
            play_all_program.luachonkq.Visible = True
            play_all_program.traloi.Enabled = False
            laydapan("select1")
            laydapan("select2")
            laydapan("select3")
            laydapan("select4")
            resetAllControls(play_all_program)
            play_all_program.dapantam.Text = ""
            play_all_program.traloitam.Text = ""
            Me.Hide()
            Me.Close()
        Else
            play_all_program.luachonkq.Visible = False
            play_all_program.traloi.Enabled = True
            resetAllControls(play_all_program)
            play_all_program.dapantam.Text = ""
            play_all_program.traloitam.Text = ""
            Me.Hide()
            Me.Close()
        End If
        resetAllControls(play_all_program)
        play_all_program.dapantam.Text = ""
        play_all_program.traloitam.Text = ""
        play_all_program.Enabled = True
        play_all_program.Show()
        '  play_all_program.TopMost = True
        autonext()
        Me.Hide()
        Me.Close()

        ' MsgBox(play_all_program.dapanchuan.Text)
        '    play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "<ketqua>", "")
        '  play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "</ketqua>", "")
    End Sub

    'END TEST
    Sub autonext()
        If My.Settings.st3 = "turn_on" Then
            'auto_next.Start()
            If My.Settings.st2 = "turn_on" Then
                If txt_get.Text <= 30 Then
                    play_all_program.auto_next.Stop()
                    '  play_all_program.Enabled = False
                Else
                    play_all_program.auto_next.Start()
                End If
            Else
                If txt_get.Text <= 30 Then
                    play_all_program.auto_next.Stop()
                    '  play_all_program.Enabled = False
                Else
                    play_all_program.auto_next.Start()
                End If
            End If
            '   lb_reset.Visible = True
            ' lb_num.Visible = True
        Else
            If My.Settings.st2 = "turn_on" Then
                play_all_program.auto_next.Start()
            End If
        End If
        '    play_all_program.TopMost = True
    End Sub


    Private Sub lb_end_Click(sender As Object, e As EventArgs) Handles lb_end.Click
        PostAction(54)
        play_all_program.Enabled = True
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub bt_reset_Click(sender As Object, e As EventArgs) Handles bt_next.Click
        PostAction(53)
        play_all_program.traloi.Text = ""
        play_all_program.Enabled = True
        resetAllControls(play_all_program)
        Me.Hide()
        Me.Close()
    End Sub


    Private Sub resetAllControls(ByVal container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
                'bat cai nay neu muon reser toan bo textbox
                ' ElseIf TypeOf ctrl Is TextBox Then
                '     DirectCast(ctrl, TextBox).Clear()
            End If
            If ctrl.Controls.Count > 0 Then
                resetAllControls(ctrl)
            End If
        Next
    End Sub

    Private Sub auto_ans_Tick(sender As Object, e As EventArgs) Handles auto_ans.Tick
        next_ans()
        play_all_program.dapantam.Text = ""
        play_all_program.traloitam.Text = ""
        If My.Settings.st3 = "turn_on" Then

        Else
            play_all_program.TopMost = True
        End If
        auto_ans.Stop()
        Me.Hide()
        Me.Close()

    End Sub

    Private Sub show_score_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)

    End Sub
End Class