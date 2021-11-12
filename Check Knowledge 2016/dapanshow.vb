Public Class dapanshow
    Private Sub bt_ok_Click(sender As Object, e As EventArgs) Handles bt_ok.Click
        okes()
        auto_send_get()
    End Sub
    Sub okes()
        PostAction(60)
        txt_data.Clear()
        play_all_program.Enabled = True
        play_all_program.TopMost = True
        If My.Settings.st2 = "turn_on" Then
            play_all_program.auto_next.Start()
        End If
        Me.Hide()

    End Sub
    Private Sub txt_data_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_data.KeyDown
        If e.KeyCode = Keys.Enter Then
            okes()
        End If
    End Sub

    Private Sub dapanshow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PostAction(58)
        play_all_program.Enabled = False
        If txt_data.Text.Length < 2 Then
            txt_data.Clear()
            Me.Hide()
        End If
        If My.Settings.st2 = "turn_on" Then
            play_all_program.auto_next.Stop()
        End If
    End Sub

    Private Sub dapanshow_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)

    End Sub

    Private Sub txt_data_TextChanged(sender As Object, e As EventArgs) Handles txt_data.TextChanged
        PostAction(59)
    End Sub
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
                play_all_program.auto_next.Start()
            End If
        Else

            play_all_program.auto_next.Start()

        End If
        '   lb_reset.Visible = True
        ' lb_num.Visible = True

        If My.Settings.st2 = "turn_on" Then
                play_all_program.auto_next.Start()
            End If

        '    play_all_program.TopMost = True
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
End Class