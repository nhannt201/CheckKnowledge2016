Public Class infodata
    Private Sub bt_ok_Click(sender As Object, e As EventArgs) Handles bt_ok.Click
        PostAction(62)
        Me.Hide()
        txt_ghichu.Clear()
        txt_tg.Clear()
        play_all_program.Show()
    End Sub


    Private Sub infodata_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)

    End Sub

    Private Sub infodata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PostAction(61)
    End Sub
End Class