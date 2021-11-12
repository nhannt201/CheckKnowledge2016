Public Class home

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
       
    End Sub

  

    Private Sub b1_MouseMove(sender As Object, e As MouseEventArgs) Handles b1.MouseMove
        b1.Image = My.Resources.hg1
    End Sub
    Private Sub b2_MouseMove(sender As Object, e As MouseEventArgs) Handles b2.MouseMove
        b2.Image = My.Resources.hg1
    End Sub
    Private Sub b3_MouseMove(sender As Object, e As MouseEventArgs) Handles b3.MouseMove
        b3.Image = My.Resources.hg1
    End Sub
    Private Sub b4_MouseMove(sender As Object, e As MouseEventArgs) Handles b4.MouseMove
        b4.Image = My.Resources.hg1
    End Sub

    Private Sub home_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
       
    End Sub
End Class