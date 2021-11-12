Public Class upload_sv
    Private Sub upload_sv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.Network.IsAvailable Then
            tm1.Start()
        Else
            End
        End If

    End Sub

    Private Sub tm1_Tick(sender As Object, e As EventArgs) Handles tm1.Tick
        Me.Enabled = False
        UpSV()
        End
    End Sub
End Class