Public Class baoloi
    Private Sub baoloi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PostAction(57)
        Dim cngang As String = Me.Width
        Dim cdai As String = Me.Height
        lb_er.Top = cdai / 2 - 200
        lb_er.Left = cngang / 2 - 200
        lb_ror.Left = cngang / 2 - 600
        lb_ror.Top = cdai / 2 - 30
        '   bt_close.Left = cngang / 2 - 20
        '   bt_close.Top = cdai / 2 - 50
        My.Computer.Audio.Stop()
    End Sub



    Private Sub end_pr_Tick_1(sender As Object, e As EventArgs) Handles end_pr.Tick
        End
    End Sub
End Class