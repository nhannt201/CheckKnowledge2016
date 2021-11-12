Imports System.Text.RegularExpressions


Public Class play_all_program
    Dim dapan_selct As String = 0
    Dim diemtamthoi As Integer
    Dim consocu As String = 0
    Dim showdapan As String = False
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim check_fullscreen As String = False
    Dim soundk As String = "2"
    Dim ss1 As String = "Lớp 6"
    Dim ss2 As String = "Lớp 7"
    Dim ss3 As String = "Lớp 8"
    Dim ss4 As String = "Lớp 9"
    Dim ss5 As String = "Lớp 10"
    Dim ss6 As String = "Lớp 11"
    Dim ss7 As String = "Lớp 12"
    Dim ss8 As String = "Tuỳ chọn"
    Dim s1 As String = "data1"
    Dim s2 As String = "data2"
    Dim s3 As String = "data3"
    Dim s4 As String = "data4"
    Dim s5 As String = "data5"
    Dim s6 As String = "data6"
    Dim s7 As String = "data7"
    Dim s8 As String = "data8"


    ' Dim score_to_show As New Label
    Private Sub miniform_Click(sender As Object, e As EventArgs) Handles miniform.Click
        Me.WindowState = FormWindowState.Minimized
        PostAction(37)
    End Sub

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        PostAction(40)
        ' End
        upload_sv.Show()
        upload_sv.Hide()
        Me.Hide()
    End Sub

    Private Sub thoat_MouseMove(sender As Object, e As MouseEventArgs) Handles thoat.MouseMove
        thoat.BackColor = Color.Brown
    End Sub

    Private Sub miniform_MouseMove(sender As Object, e As MouseEventArgs) Handles miniform.MouseMove
        miniform.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub class6_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        thoat.BackColor = Color.Red
        miniform.BackColor = Color.DodgerBlue
        lb_st.BackColor = Color.LightSlateGray
        alboudata.BackColor = Color.Gray
        phongto.BackColor = Color.DeepSkyBlue
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub class6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PostAction(33)
            Me.daymanhinh.Enabled = True
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterScreen
            'phan chinh fullscreen
            Me.alboudata.Anchor =
           AnchorStyles.Right _
           Or AnchorStyles.Top
            Me.lb_st.Anchor =
           AnchorStyles.Right _
           Or AnchorStyles.Top
            Me.miniform.Anchor =
           AnchorStyles.Right _
           Or AnchorStyles.Top
            Me.phongto.Anchor =
           AnchorStyles.Right _
           Or AnchorStyles.Top
            Me.thoat.Anchor =
           AnchorStyles.Right _
           Or AnchorStyles.Top
            Me.pb3.Anchor =
           AnchorStyles.Top _
            Or AnchorStyles.Right _
            Or AnchorStyles.Bottom
            Me.lb_ds.Anchor =
           AnchorStyles.Top _
            Or AnchorStyles.Right _
            Or AnchorStyles.Bottom
            Me.diemso.Anchor =
           AnchorStyles.Top _
            Or AnchorStyles.Right _
            Or AnchorStyles.Bottom
            Me.gb_tk.Anchor =
            AnchorStyles.Right _
          Or AnchorStyles.Bottom
            Me.bt_st.Anchor =
             AnchorStyles.Right _
            Or AnchorStyles.Bottom
            Me.pb1.Anchor =
           AnchorStyles.Top _
            Or AnchorStyles.Bottom _
            Or AnchorStyles.Left _
        Or AnchorStyles.Right
            Me.lb_reset.Anchor =
           AnchorStyles.Top _
        Or AnchorStyles.Right
            Me.lb_num.Anchor =
           AnchorStyles.Top _
        Or AnchorStyles.Right
            Me.lb_giay.Anchor =
           AnchorStyles.Top _
        Or AnchorStyles.Right
            Me.cauhoi.Anchor =
           AnchorStyles.Top _
            Or AnchorStyles.Bottom _
             Or AnchorStyles.Left _
        Or AnchorStyles.Right
            Me.pb2.Anchor =
          AnchorStyles.Bottom _
        Or AnchorStyles.Left _
        Or AnchorStyles.Right
            Me.luachonkq.Anchor =
          AnchorStyles.Bottom _
             Or AnchorStyles.Left _
        Or AnchorStyles.Right
            Me.bt1.Anchor =
          AnchorStyles.Bottom _
        Or AnchorStyles.Right
            Me.bt2.Anchor =
          AnchorStyles.Bottom _
        Or AnchorStyles.Right
            Me.traloi.Anchor =
          AnchorStyles.Bottom _
            Or AnchorStyles.Left _
        Or AnchorStyles.Right
            'Ket thuc chinh full
            class_echo(txt_get_class.Text)
            '  My.Computer.Audio.Play(Application.StartupPath & "\Sound\sound_bg.wav", AudioPlayMode.BackgroundLoop)
            txt_socauhoi.Text = 0
            txt_tongdiem.Text = 0
            tong1.Text = "0"
            tong2.Text = "0"
            theme2.Close()
            find_max_id.Close()
            show_score.Close()
            'Khai bao dapan
            dapan_khisai.Multiline = True
            '  dapanshow.Close()

            If My.Settings.st4 = "turn_on" Then
                My.Computer.Audio.Stop()
                lb_st.Text = "Tắt âm"
                soundk = "1"
            ElseIf My.Settings.st4 = "turn_off" Then
                My.Computer.Audio.Play(Application.StartupPath & "\Sound\sound_bg.wav", AudioPlayMode.BackgroundLoop)
                lb_st.Text = "Bật âm"
                soundk = "2"
            End If
            If My.Settings.st2 = "turn_on" Then
                auto_next.Start()
                lb_reset.Visible = True
                lb_num.Visible = True
                lb_giay.Visible = True
            End If
            If My.Settings.st3 = "turn_on" Then
                showdapan = True
            End If
        Catch

        End Try
    End Sub

    Sub class_echo(ops As String)
        If ops = s1 Then
            lv_class.Text = ss1
        ElseIf ops = s2 Then
            lv_class.Text = ss2
            '   hoi.Text = hoi2.Text
        ElseIf ops = s3 Then
            lv_class.Text = ss3
            '   hoi.Text = hoi3.Text
        ElseIf ops = s4 Then
            lv_class.Text = ss4
            '    hoi.Text = hoi4.Text
        ElseIf ops = s5 Then
            lv_class.Text = ss5
            '   hoi.Text = hoi5.Text
        ElseIf ops = s6 Then
            lv_class.Text = ss6
            '  hoi.Text = hoi6.Text
        ElseIf ops = s7 Then
            lv_class.Text = ss7
            ' hoi.Text = hoi7.Text
        ElseIf ops = s8 Then
            lv_class.Text = ss8
            ' hoi.Text = hoi8.Text
        End If
    End Sub









    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt1.Click

        clicktraloi()
    End Sub

    Sub clicktraloi()
        PostAction(46)
        dapanshow.Hide()
        dapantam.Text = RemoveCharacter(LTrim(RTrim(dapanchuan.Text)))
        If cauhoi.Text.Length < 2 Then
            boqua()
        Else
            If luachonkq .Visible = True Then
                '  luachonkq.Visible = True
                If dpa.Checked = False And dpb.Checked = False And dpc.Checked = False And dpd.Checked = False Then
                    auto_next.Stop()
                    '   If traloi.Visible = True Then
                    ' tralois()
                    'Else
                    MsgBox("Vui lòng chọn một đáp án!", vbInformation, "Báo lỗi")
                    If My.Settings.st2 = "turn_on" Then
                        resetauto_next()
                    End If
                    '  End If
                    auto_next.Start()
                Else
                    If dpa.Checked = True Then
                        dapan_selct = "A"
                    End If
                    If dpb.Checked = True Then
                        dapan_selct = "B"
                    End If
                    If dpc.Checked = True Then
                        dapan_selct = "C"
                    End If
                    If dpd.Checked = True Then
                        dapan_selct = "D"
                    End If

                    If dapan_selct = dapantam.Text Then
                        show_score.txt_get.Text = "100"
                        show_score.Show()
                        ' Me.TopMost = False
                        thongke.lb_tong.Text = thongke.lb_tong.Text + 1
                        thongke.lb_trentb.Text = thongke.lb_trentb.Text + 1
                        thongke.lb_diemnv.Text = thongke.lb_diemnv.Text + 100
                        '  tong1.Text = tong1.Text + 100
                        xuongdong()
                        Me.Enabled = False
                    Else
                        show_score.txt_get.Text = "0"
                        show_score.Show()
                        If showdapan = True Then
                            ' Me.TopMost = False

                            If hoi.Text.Contains("<t_uD_R>_er_or_e-12_599_</t_uD_R>") Then
                                dapanshow.txt_data.Text = "(Dữ liệu không cho phép bạn xem đáp án)"
                            Else
                                'cauhoi_khisai.Text.Length > 15 And 
                                If dapan_khisai.Text.Length < 2 Then
                                    '  dapanshow.txt_data.Text = cauhoi_khisai.Text & vbNewLine & "Đáp án đúng là " & dapantam.Text & ". " & vbNewLine & dapan_khisai.Text
                                    dapanshow.txt_data.Text = "Đáp án đúng là " & dapantam.Text & ". " & vbNewLine & dapan_khisai.Text
                                Else
                                    dapanshow.txt_data.Text = "Đáp án đúng là " & dapantam.Text & ". " & vbNewLine & dapan_khisai.Text
                                End If
                            End If
                        End If
                        thongke.lb_tong.Text = thongke.lb_tong.Text + 1
                        thongke.lb_duoitb.Text = thongke.lb_duoitb.Text + 1
                        ' thongke.lb_diemnv.Text = thongke.lb_diemnv.Text + 1
                        xuongdong()
                        Me.Enabled = False
                    End If
                End If
            Else
                '  MsgBox(dapanchuan.Text)
                'test nho xoa cai nay nhe
                'traloi.Text = dapanchuan.Text
                'end test
                tralois()

            End If
        End If
    End Sub

    Sub tralois()
        ' traloi.Text = Regex.Match(traloi.Text, "<1>.*</1>").ToString()
        '  traloi.Text = hoi.Text
        'loai bo ki tu cach2 :  Dim cleanString As String = Regex.Replace(yourString, "[^A-Za-z0-9\-/]", "")
        If traloi.Text.Length < 1 Or traloi.Text = " " Then
            auto_next.Stop()
            MsgBox("Bạn chưa nhập câu trả lời!", vbInformation, "Báo lỗi")
            If My.Settings.st2 = "turn_on" Then
                resetauto_next()
            End If
            auto_next.Start()
        ElseIf traloi.Text.Length <= 5 Then
            auto_next.Stop()
            MsgBox("Câu trả lời của bạn quá ngắn!", vbInformation, "Báo lỗi")
            If My.Settings.st2 = "turn_on" Then
                resetauto_next()
            End If
            auto_next.Start()
        Else
            If My.Settings.st3 = "turn_on" Then

            Else
                show_score.TopMost = True
            End If
            thongke.lb_tong.Text = thongke.lb_tong.Text + 1
            ' dapannguyen.Text = dapanchuan.Text
            dapanchuan.Text = RemoveCharacter(LTrim(RTrim(dapanchuan.Text)))
            traloi.Text = RemoveCharacter(LTrim(RTrim(traloi.Text)))
            ' traloi.Text = Regex.Match(traloi.Text, "<" + sostt2.Text + ">.*</" + sostt2.Text + ">").ToString()
            'dapantam traloitam con du
            diemtamthoi = (giongnhau(LCase(traloi.Text), LCase(dapanchuan.Text)))
            ' MsgBox(diemtamthoi & " " & traloi.Text & " - " & dapanchuan.Text)
            ' Dim kqluachon As Integer
            If diemtamthoi <= 30 Then
                diemtamthoi = 0
                If showdapan = True Then
                    '   Me.TopMost = False
                    If hoi.Text.Contains("<t_uD_R>_er_or_e-12_599_</t_uD_R>") Then
                        dapanshow.txt_data.Text = "(Dữ liệu không cho phép bạn xem đáp án)"
                    Else
                        If dapan_khisai.Text.Length < 2 Then
                            'dapannguyen
                            dapanshow.txt_data.Text = dapan_khisai.Text
                        Else
                            '  If cauhoi_khisai.Text.Length > 15 Then
                            ' dapanshow.txt_data.Text = cauhoi_khisai.Text & dapan_khisai.Text
                            '  Else
                            dapanshow.txt_data.Text = dapan_khisai.Text
                            ' End If

                        End If


                    End If
                End If
                '    thongke.lb_diemnv.Text = thongke.lb_diemnv.Text + diemtamthoi
            ElseIf diemtamthoi >= 100 Then
                ' If traloi.Text.Length < dapanchuan.Text.Length - 20 Then
                ' diemtamthoi = ((dapanchuan.Text.Length - 20) + traloi.Text.Length) / 2
                'Else
                diemtamthoi = 100
                '   thongke.lb_diemnv.Text = thongke.lb_diemnv.Text + diemtamthoi
            End If
            show_score.txt_get.Text = diemtamthoi 'Math.Round(Val(diemtamthoi), 1)
            '  tong1.Text = tong1.Text + diemtamthoi
            '   MsgBox(diemtamthoi)
            If diemtamthoi >= 50 Then
                thongke.lb_diemnv.Text = thongke.lb_diemnv.Text + diemtamthoi
                thongke.lb_trentb.Text = thongke.lb_trentb.Text + 1
            ElseIf diemtamthoi < 50 Then
                thongke.lb_diemnv.Text = thongke.lb_diemnv.Text + diemtamthoi
                thongke.lb_duoitb.Text = thongke.lb_duoitb.Text + 1
            End If
            show_score.txt_get.Text = Math.Round(Val(diemtamthoi), 1)
            My.Settings.sotam = Math.Round(Val(diemtamthoi), 1)
            ' MsgBox(show_score.txt_get.Text)
            '   kqluachon = MsgBox("Bạn nhận được " & Math.Round(diemtamthoi, 1) & " điểm." & vbNewLine & "Nhấn 'Yes' để tiếp tục, nhấn 'No' để thử lại", vbYesNo + vbInformation, "Chấm điểm")

            xuongdong()
            thongke.lb_tong.Text = txt_socauhoi.Text + 1
            show_score.Show()
            Me.Enabled = False
        End If

    End Sub
    Sub xuongdong()
        Try
            diemso.TopIndex = diemso.Items.Count - 1
        Catch

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        PostAction(47)
        boqua()
    End Sub
    Sub reset_next_time()
        'Me.auto_next.Stop()
        Me.lb_num.Text = "60"
    End Sub
    Sub boqua()
        'traloi.Text = tl2.Text
        '  diemso.Items.Add(diemtamthoi)
        'bat dau lay cau hoi moi
        'so ngau nhien
        resetAllControls(Me)
        Dim conso As String = Int((get_id_max.Text * Rnd()))
        'kiem tra it lap lai xiu
        If conso = consocu Then
            conso = Int((get_id_max.Text * Rnd()))
        Else
            consocu = conso
        End If
        'lay cau hoi tu sub moi TEST
        auto_send_get()
        'kiem tra cau hoi trong
        If cauhoi.Text.Length < 2 Then
            traloi.Enabled = False
            traloi.Text = "Nhấn Bỏ qua để sang câu hỏi kế tiếp"
            '  thongke.lb_tong.Text = thongke.lb_tong.Text - 1
        Else
            traloi.Enabled = True
            traloi.Clear()
        End If
        'ket thuc lay cau hoi moi
        reset_next_time()
    End Sub
    Sub boquacauhoicu()
        'lay cau hoi
        'goi dim cho co thoi
        Dim conso As String = 0
        Dim lst1, lst2 As New List(Of Integer)
        lst1 = FindStringLoc(Me.hoi.Text, "<" + conso + ">")
        lst2 = FindStringLoc(Me.hoi.Text, "</" + conso + ">")
        Me.cauhoi.Text = ""
        Me.sostt2.Text = conso
        For i As Integer = 0 To lst1.Count - 1
            If i + 1 <= lst1.Count - 1 Then
                Me.cauhoi.Text &= Me.hoi.Text.Substring(lst1(i) + 0, lst2(i) - lst1(i) - 0) & vbNewLine
            Else
                Me.cauhoi.Text &= Me.hoi.Text.Substring(lst1(i) + 0, lst2(i) - lst1(i) - 0)
            End If
        Next
        cauhoi.Text = Replace(cauhoi.Text, "<" + conso + ">", "")
        cauhoi.Text = Replace(cauhoi.Text, "</" + conso + ">", "")
        ' class6.cauhoi.Text = Replace(class6.cauhoi.Text, "<cauhoi>", "")
        ' class6.cauhoi.Text = Replace(class6.cauhoi.Text, "</cauhoi>", "")
        xuli.Text = cauhoi.Text
        'lay ket qua
        Dim lst3, lst4 As New List(Of Integer)
        lst3 = FindStringLoc(Me.cauhoi.Text, "<ketqua>")
        lst4 = FindStringLoc(Me.cauhoi.Text, "</ketqua>")
        Me.dapanchuan.Text = ""
        Me.traloi.Text = ""
        For i As Integer = 0 To lst3.Count - 1
            If i + 1 <= lst3.Count - 1 Then
                Me.dapanchuan.Text &= Me.cauhoi.Text.Substring(lst3(i) + 0, lst4(i) - lst3(i) - 0) & vbNewLine
            Else
                Me.dapanchuan.Text &= Me.cauhoi.Text.Substring(lst3(i) + 0, lst4(i) - lst3(i) - 0)
            End If
        Next
        'lay cau hoi trong
        Dim lst5, lst6 As New List(Of Integer)
        lst5 = FindStringLoc(Me.xuli.Text, "<cauhoi>")
        lst6 = FindStringLoc(Me.xuli.Text, "</cauhoi>")
        Me.cauhoi.Text = ""
        For i As Integer = 0 To lst3.Count - 1
            If i + 1 <= lst3.Count - 1 Then
                Me.cauhoi.Text &= Me.xuli.Text.Substring(lst5(i) + 0, lst6(i) - lst5(i) - 0) & vbNewLine
            Else
                Me.cauhoi.Text &= Me.xuli.Text.Substring(lst5(i) + 0, lst6(i) - lst5(i) - 0)
            End If
        Next
        Me.cauhoi.Text = Replace(Me.cauhoi.Text, "<cauhoi>", "")
        Me.cauhoi.Text = Replace(Me.cauhoi.Text, "</cauhoi>", "")
        'phan kiem tra trac nghiem
        If xuli.Text.Contains("<type>trn_abc</type>") Then
            luachonkq.Visible = True
            traloi.Enabled = False
            laydapan("select1")
            laydapan("select2")
            laydapan("select3")
            laydapan("select4")

        Else
            luachonkq.Visible = False
            traloi.Enabled = True
            'lam moi lua chon ket qua
            resetAllControls(Me)
        End If
        Me.dapanchuan.Text = Replace(Me.dapanchuan.Text, "<ketqua>", "")
        Me.dapanchuan.Text = Replace(Me.dapanchuan.Text, "</ketqua>", "")
    End Sub
    'TEST
    Sub auto_send_get()
        Dim conso As String = Int((Me.get_id_max.Text * Rnd()))
        '   Dim conso As String = Int((conso2 * Rnd()))
        Dim lst1 As String = SplitString(Me.hoi.Text, "<" + conso + ">", "</" + conso + ">")
        ' play_all_program.cauhoi.Text = ""
        Me.sostt2.Text = conso
        Me.cauhoi.Text = lst1
        Me.xuli.Text = Me.cauhoi.Text
        Dim lst2 As String = SplitString(lst1, "<ketqua>", "</ketqua>")
        ' play_all_program.dapanchuan.Text = ""
        Me.traloi.Text = ""
        Me.dapanchuan.Text = lst2
        '  dapannguyen.Text = lst2
        cauhoi_khisai.Clear()
        cauhoi_khisai.Text = SplitString(lst1, "<cauhoi>", "</cauhoi>")
        If lst2 = "A" Then
            dapan_khisai.Text = SplitString(lst1, "<select1>", "</select1>")
        ElseIf lst2 = "B" Then
            dapan_khisai.Text = SplitString(lst1, "<select2>", "</select2>")
        ElseIf lst2 = "C" Then
            dapan_khisai.Text = SplitString(lst1, "<select3>", "</select3>")
        ElseIf lst2 = "D" Then
            dapan_khisai.Text = SplitString(lst1, "<select4>", "</select4>")
        Else
            If SplitString(lst1, "<ketqua>", "</ketqua>").Contains("-") Then
                dapan_khisai.Text = SplitString(lst1, "<cauhoi>", "</cauhoi>") & vbNewLine & "Đáp án: " & vbNewLine & SplitString(lst1, "<ketqua>", "</ketqua>")
            Else
                dapan_khisai.Text = SplitString(lst1, "<cauhoi>", "</cauhoi>") & vbNewLine & "Đáp án: " & SplitString(lst1, "<ketqua>", "</ketqua>")

            End If

        End If
        ' dapan_khisai.Text = SplitString()

        Dim lst3 As String = SplitString(lst1, "<cauhoi>", "</cauhoi>")
        '  play_all_program.dapanchuan.Text = ""
        Me.traloi.Text = ""
        ' play_all_program.cauhoi.Text = ""
        Me.cauhoi.Text = lst3
        'phan kiem tra trac nghiem
        If Me.xuli.Text.Contains("<type>trn_abc</type>") Then
            Me.luachonkq.Visible = True
            Me.traloi.Enabled = False
            laydapan("select1")
            laydapan("select2")
            laydapan("select3")
            laydapan("select4")
            resetAllControls(Me)

        Else
            Me.luachonkq.Visible = False
            Me.traloi.Enabled = True
            ' resetAllControls(play_all_program)
        End If
        '  resetAllControls(play_all_program)
        ' autonext()
        ' MsgBox(play_all_program.dapanchuan.Text)
        '    play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "<ketqua>", "")
        '  play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "</ketqua>", "")
    End Sub

    Sub laydapan(oks As String)
        Dim kqquatra As Match = Regex.Match(xuli.Text, "<" & oks & ">(.*?)</" & oks & "\>")
        If kqquatra.Success Then
            If oks = "select4" Then
                cauhoi.Text = cauhoi.Text & vbNewLine & "D." & (kqquatra.Groups(1).Value)
                dpd.Visible = True
            ElseIf oks = "select3" Then
                cauhoi.Text = cauhoi.Text & vbNewLine & "C." & (kqquatra.Groups(1).Value)
                dpc.Visible = True
            ElseIf oks = "select2" Then
                cauhoi.Text = cauhoi.Text & vbNewLine & "B." & (kqquatra.Groups(1).Value)
                dpb.Visible = True
            ElseIf oks = "select1" Then
                cauhoi.Text = cauhoi.Text & vbNewLine & "A." & (kqquatra.Groups(1).Value)
                dpa.Visible = True
            End If

        Else
            If oks = "select4" Then
                dpd.Visible = False
            ElseIf oks = "select3" Then
                dpc.Visible = False
            ElseIf oks = "select2" Then
                dpb.Visible = False
            ElseIf oks = "select1" Then
                dpa.Visible = False
            End If
        End If
    End Sub
    Private Sub resetAllControls(ByVal container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
            End If
            If ctrl.Controls.Count > 0 Then
                resetAllControls(ctrl)
            End If
        Next
    End Sub
    'ham khai ra cua các lay cau hoi
    Function FindStringLoc(rootstring As String, s As String) As List(Of Integer)
        Dim lst As New List(Of Integer)
        For i As Integer = 0 To rootstring.Length - s.Length
            If rootstring.Substring(i, s.Length).ToLower = s.ToLower Then
                lst.Add(i)
            End If
        Next
        Return lst
    End Function
    Private Function giongnhau(ByVal xau1$, ByVal xau2$) As String
        Dim x1() As String = xau1.Split(" ")
        Dim x2() As String = xau2.Split(" ")
        Dim x$ = ""
        Dim i% = -1
        Dim j As Integer
        Do : i = i + 1
            For j = 0 To UBound(x1)
                If x2(i) = x1(j) Then
                    x = x & x2(i) & " "
                    x1(j) = ""
                End If
            Next
        Loop Until i = UBound(x2)
        Dim t() As String = x.Trim.Split(" ")
        'giongnhau = "Các từ của xâu 1 (" & xau1 & ") có trong xâu 2 (" & xau2 & ") là '" & x.Trim() & Chr(10) & "Như vậy xâu 1 giống xâu 2 là " & ((UBound(t) + 1) / (UBound(x2) + 1)) * 100 & "%."

        If x.Trim().Length < 1 Then
            giongnhau = 0
        Else
            giongnhau = ((UBound(t) + 1) / (UBound(x2) + 1)) * 100
        End If
        ' MsgBox(xau1 & " - " & xau2)
    End Function

    Private Sub bt1_MouseMove(sender As Object, e As MouseEventArgs) Handles bt1.MouseMove
        ' bt1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub bt2_MouseMove(sender As Object, e As MouseEventArgs) Handles bt2.MouseMove
        ' bt2.BackColor = Color.WhiteSmoke
    End Sub





    Private Sub traloi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles traloi.KeyPress
        '   If (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or Asc(e.KeyChar) = 8 Then
        ' e.Handled = False
        '  Else
        '   e.Handled = True
        '   End If
    End Sub

    Function RemoveCharacter(ByVal stringToCleanUp)
        Dim characterToRemove As String = ""
        characterToRemove = Chr(34) + "#$%&'()*+,-./\~:?=<>_"
        Dim firstThree As Char() = characterToRemove.Take(16).ToArray()
        For index = 1 To firstThree.Length - 1
            stringToCleanUp = stringToCleanUp.ToString.Replace(firstThree(index), "")
        Next
        Return stringToCleanUp
    End Function

    Private Sub bt_st_Click(sender As Object, e As EventArgs) Handles bt_st.Click
        PostAction(50)
        auto_next.Stop()
        Dim diemvs As String = Math.Round(Val(txt_tongdiem.Text / txt_socauhoi.Text), 1)
        If diemvs = "NaN" Then
            '   Application.Exit()
            '   Process.Start(Application.ExecutablePath)
            ' System.Windows.Forms.Application.Restart() 'khoi dong lai
            Dim frk = New load1
            frk.Show()
            My.Computer.Audio.Stop()
            Me.Hide()
            theme2.Enabled = True
            find_max_id.Close()
            Me.Close()

        Else
            thongke.lb_tram.Text = diemvs & " điểm"
            thongke.lb_chuc.Text = (diemvs / 10) & " điểm"
            thongke.Show()
            Me.Enabled = False
            '  MsgBox("Điểm trung bình của bạn là: " & (diemvs) & " điểm" & vbNewLine & "Tương đương với " & (diemvs / 10) & "điểm")
            '  Application.Exit()
            '     Process.Start(Application.ExecutablePath)
            'System.Windows.Forms.Application.Restart() ' khoi dong lai


        End If
    End Sub

    Private Sub traloi_KeyDown(sender As Object, e As KeyEventArgs) Handles traloi.KeyDown
        If e.KeyCode = Keys.Enter Then
            tralois()
        End If
    End Sub

    Private Sub lb_st_Click(sender As Object, e As EventArgs) Handles lb_st.Click
        If soundk = "1" Then
            My.Computer.Audio.Play(Application.StartupPath & "\Sound\sound_bg.wav", AudioPlayMode.BackgroundLoop)
            lb_st.Text = "Bật âm"
            soundk = "2"
            PostAction(35)
        ElseIf soundk = "2" Then
            My.Computer.Audio.Stop()
            lb_st.Text = "Tắt âm"
            soundk = "1"
            PostAction(36)
        End If
    End Sub

    Private Sub lb_st_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_st.MouseMove
        lb_st.BackColor = Color.SlateGray
    End Sub


    Private Sub alboudata_MouseMove(sender As Object, e As MouseEventArgs) Handles alboudata.MouseMove
        alboudata.BackColor = Color.DimGray
    End Sub

    Private Sub auto_next_Tick(sender As Object, e As EventArgs) Handles auto_next.Tick
        lb_num.Text = lb_num.Text - 1
        If lb_num.Text <= 0 Then
            clicktraloi()

        Else

        End If

    End Sub
    Sub resetauto_next()
        lb_num.Text = "60"
    End Sub

    Private Sub alboudata_Click(sender As Object, e As EventArgs) Handles alboudata.Click
        PostAction(34)
        Dim tacgia As String = "" '= SplitString(hoi.Text, "<tacgia>", "</tacgia>")
        Dim tacgia2 As Match = Regex.Match(hoi.Text, "<tacgia>(.*?)</tacgia\>")
        Dim ghichu As String = SplitString(hoi.Text, "<ghichu>", "</ghichu>")
        ' Dim ghichu2 As Match = Regex.Match(hoi.Text, "<about>(.*?)</about\>")
        '   If ghichu2.Success Then
        'ghichu = (ghichu2.Groups(1).Value)
        'MsgBox((ghichu2.Groups(1).Value))
        ' End If

        If tacgia2.Success Then
            tacgia = (tacgia2.Groups(1).Value)
        End If
        If tacgia.Length < 2 Then
            tacgia = "(Không rõ)"
        End If
        ' MsgBox("Thông tin dữ liệu " & vbNewLine & "Tác giả: " & tacgia & vbNewLine & "Ghi chú kèm theo: " & vbNewLine & ghichu, vbInformation, "Thông Tin Dữ Liệu")
        infodata.txt_tg.Text = tacgia
        infodata.txt_ghichu.Text = ghichu
        infodata.Show()
    End Sub
    Public Function SplitString(ByVal mainString As String, ByVal BeginString As String, ByVal EndString As String) As String
        Dim i_s As Integer : i_s = InStr(mainString, BeginString)
        Dim i_e As Integer : i_e = InStr(mainString, EndString)
        On Error Resume Next
        If i_s <> -1 And i_e <> -1 Then
            Dim s As String

            s = Mid(mainString, i_s + Len(BeginString), i_e - i_s - Len(BeginString))
            SplitString = s
            If s.Length = 0 Then
                SplitString = "(Không rõ)"
            End If

        Else
            SplitString = "(Không rõ)"
        End If
    End Function



    Private Sub dpa_KeyDown(sender As Object, e As KeyEventArgs) Handles dpa.KeyDown
        If e.KeyCode = Keys.Enter Then
            clicktraloi()
        End If
    End Sub
    Private Sub dpb_KeyDown(sender As Object, e As KeyEventArgs) Handles dpb.KeyDown
        If e.KeyCode = Keys.Enter Then
            clicktraloi()
        End If
    End Sub
    Private Sub dpc_KeyDown(sender As Object, e As KeyEventArgs) Handles dpc.KeyDown
        If e.KeyCode = Keys.Enter Then
            clicktraloi()
        End If
    End Sub
    Private Sub dpd_KeyDown(sender As Object, e As KeyEventArgs) Handles dpd.KeyDown
        If e.KeyCode = Keys.Enter Then
            clicktraloi()
        End If
    End Sub

    Private Sub play_all_program_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
        Me.Refresh()
    End Sub

    Private Sub play_all_program_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub play_all_program_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
           ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub maxfr_CheckedChanged(sender As Object, e As EventArgs) Handles maxfr.CheckedChanged
        If (maxfr.Checked) Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            Me.TopMost = True
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterScreen
            '    Me.TopMost = False
        End If
    End Sub

    Private Sub daymanhinh_Tick(sender As Object, e As EventArgs) Handles daymanhinh.Tick
        'kiemtra cai dat fullscreen
        If My.Settings.fullscreen = "turn_on" Then
            maxfr.Checked = True
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            Me.TopMost = True
        Else
            maxfr.Checked = False
        End If
        daymanhinh.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles auto_fullscreen.Tick
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Normal
        auto_fullscreen.Stop()
    End Sub

    Private Sub phongto_Click(sender As Object, e As EventArgs) Handles phongto.Click
        If check_fullscreen = False Then
            maxfr.Checked = True
            check_fullscreen = True
            PostAction(38)
        Else
            maxfr.Checked = False
            check_fullscreen = False
            PostAction(39)
        End If

    End Sub

    Private Sub phongto_MouseMove(sender As Object, e As MouseEventArgs) Handles phongto.MouseMove
        phongto.BackColor = Color.LightSkyBlue 'LightSkyBlue
    End Sub

    Private Sub pb3_Click(sender As Object, e As EventArgs) Handles pb3.Click

    End Sub

    Private Sub pb3_MouseMove(sender As Object, e As MouseEventArgs) Handles pb3.MouseMove

    End Sub

    Private Sub dpa_CheckedChanged(sender As Object, e As EventArgs) Handles dpa.CheckedChanged
        PostAction(42)

    End Sub

    Private Sub traloi_TextChanged(sender As Object, e As EventArgs) Handles traloi.TextChanged
        'PostAction(41)
    End Sub

    Private Sub dpb_CheckedChanged(sender As Object, e As EventArgs) Handles dpb.CheckedChanged
        PostAction(43)

    End Sub

    Private Sub dpc_CheckedChanged(sender As Object, e As EventArgs) Handles dpc.CheckedChanged
        PostAction(44)

    End Sub

    Private Sub dpd_CheckedChanged(sender As Object, e As EventArgs) Handles dpd.CheckedChanged
        PostAction(45)

    End Sub

    Private Sub cauhoi_TextChanged(sender As Object, e As EventArgs) Handles cauhoi.TextChanged
        PostAction(48)
    End Sub

    Private Sub diemso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles diemso.SelectedIndexChanged
        PostAction(49)
    End Sub

    Private Sub lb_num_Click(sender As Object, e As EventArgs) Handles lb_num.Click
        PostAction(72)
    End Sub
End Class