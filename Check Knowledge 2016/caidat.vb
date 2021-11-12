Public Class caidat
    Private Sub ck_1_CheckedChanged(sender As Object, e As EventArgs) Handles ck_1.CheckedChanged
        If ck_1.Checked = True Then
            play_all_program.txt_auto_next.Text = "yes"
            PostAction(6)
        Else
            play_all_program.txt_auto_next.Text = "no"
            PostAction(7)
        End If
    End Sub
    Private Sub ck_2_CheckedChanged(sender As Object, e As EventArgs) Handles ck_2.CheckedChanged
        If ck_2.Checked = True Then
            PostAction(8)
        Else
            PostAction(9)
        End If
    End Sub
    Private Sub ck_3_CheckedChanged(sender As Object, e As EventArgs) Handles ck_3.CheckedChanged
        If ck_3.Checked = True Then
            PostAction(10)
        Else
            PostAction(11)
        End If
    End Sub
    Private Sub ck_4_CheckedChanged(sender As Object, e As EventArgs) Handles ck_4.CheckedChanged
        If ck_4.Checked = True Then
            PostAction(12)
        Else
            PostAction(13)
        End If
    End Sub
    Private Sub ck_5_CheckedChanged(sender As Object, e As EventArgs) Handles ck_5.CheckedChanged
        If ck_5.Checked = True Then
            PostAction(14)
        Else
            PostAction(15)
        End If
    End Sub
    Private Sub bt_ok_Click(sender As Object, e As EventArgs) Handles bt_ok.Click
        If ck_1.Checked = True Then
            My.Settings.st1 = "turn_on"
            My.Settings.Save()
        Else
            My.Settings.st1 = "turn_off"
            My.Settings.Save()
        End If
        If ck_2.Checked = True Then
            My.Settings.st2 = "turn_on"
            My.Settings.Save()
        Else
            My.Settings.st2 = "turn_off"
            My.Settings.Save()
        End If
        If ck_3.Checked = True Then
            My.Settings.st3 = "turn_on"
            My.Settings.Save()
        Else
            My.Settings.st3 = "turn_off"
            My.Settings.Save()
        End If
        If ck_4.Checked = True Then
            My.Settings.st4 = "turn_on"
            My.Settings.Save()
        Else
            My.Settings.st4 = "turn_off"
            My.Settings.Save()
        End If
        If ck_5.Checked = True Then
            My.Settings.fullscreen = "turn_on"
            play_all_program.daymanhinh.Enabled = True
            My.Settings.Save()
        Else
            My.Settings.fullscreen = "turn_off"
            play_all_program.daymanhinh.Enabled = False
            My.Settings.Save()
        End If
        PostAction(5)
        theme2.Enabled = True
        theme2.Show()
        Me.Hide()
    End Sub

    Private Sub bt_canel_Click(sender As Object, e As EventArgs) Handles bt_canel.Click
        theme2.Enabled = True
        theme2.Show()
        PostAction(4)
        ' ck_1.Checked = False
        '  ck_2.Checked = False
        '  ck_3.Checked = False
        Me.Hide()
    End Sub


    Private Sub caidat_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub caidat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_csdl.Text = "Phiên bản CSDL: " & My.Settings.update
    End Sub


End Class