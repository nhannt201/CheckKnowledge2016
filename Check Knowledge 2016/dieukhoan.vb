Public Class dieukhoan
    Private Sub dieukhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  If My.Settings.allow_internet = "ko" Then
        'Me.Show()
        '  ElseIf My.Settings.allow_internet = "co" Then
        ' Me.Hide()
        ' StartAI(Environment.MachineName)
        '  Dim show111a As New load1
        '     show111a.Show()
        ' End If
    End Sub

    Private Sub btok_Click(sender As Object, e As EventArgs) Handles btok.Click
        StartAI(Environment.MachineName)
        My.Settings.allow_internet = "co"
        My.Settings.Save()
        Dim show111a As New load1
        show111a.Show()
    End Sub
End Class