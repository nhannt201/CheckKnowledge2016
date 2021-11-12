Public Class chonpath
    Private Sub bt_next_Click(sender As Object, e As EventArgs) Handles bt_next.Click
        PostAction(30)
        Me.Hide()
        theme2.Enabled = True
        theme2.TopMost = True
        theme2.Enabled = True
        theme2.Show()
    End Sub
    Private Sub chonpath_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub
    Sub load_open()
        PostAction(31)
        Dim s As New OpenFileDialog
        s.Title = "Mở dữ liệu"
        s.FileName = "Tệp của bạn"
        s.Filter = "Tệp dữ liệu CKT|*.ckt"
        If s.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            find_max_id.pathk.Text = s.FileName
            show_me_all("tudo")
            Me.Hide()
        End If
    End Sub

    Sub show_me_all(rd As String)
        play_all_program.txt_get_class.Text = rd
        Me.Enabled = False
        find_max_id.Show()
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        load_open()
    End Sub


    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        PostAction(32)
        Dim new_tv As New lib_online
        new_tv.Show()
        theme2.Close()
        Me.Close()
    End Sub

    Private Sub chonpath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   StartAI(212)
        If My.Computer.Network.IsAvailable Then
            bt2.Enabled = True
            PostAction(29)
        Else
            bt2.Enabled = False
        End If

    End Sub

End Class