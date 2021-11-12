Public Class thongke
    Private Sub bt_next_Click(sender As Object, e As EventArgs) Handles bt_next.Click
        PostAction(56)
        Dim frk = New load1
        frk.Show()
        My.Computer.Audio.Stop()
        theme2.Enabled = True
        find_max_id.Close()
        play_all_program.Close()
        Me.Close()
    End Sub


    Private Sub thongke_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)

    End Sub

    Private Sub thongke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PostAction(55)
    End Sub

    Private Sub lb_tong_Click(sender As Object, e As EventArgs) Handles lb_tong.Click
        PostAction(73)
    End Sub

    Private Sub lb_trentb_Click(sender As Object, e As EventArgs) Handles lb_trentb.Click
        PostAction(74)
    End Sub

    Private Sub lb_duoitb_Click(sender As Object, e As EventArgs) Handles lb_duoitb.Click
        PostAction(75)
    End Sub

    Private Sub lb_diemnv_Click(sender As Object, e As EventArgs) Handles lb_diemnv.Click
        PostAction(76)
    End Sub

    Private Sub lb_tram_Click(sender As Object, e As EventArgs) Handles lb_tram.Click
        PostAction(77)
    End Sub

    Private Sub lb_chuc_Click(sender As Object, e As EventArgs) Handles lb_chuc.Click
        PostAction(78)
    End Sub
End Class