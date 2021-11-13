
Public Class win_share
    Dim path123 As New TextBox
    Dim numk As String

    Private Sub kt_1_CheckedChanged(sender As Object, e As EventArgs) Handles kt_1.CheckedChanged
        If kt_1.Checked = True Then
            If cmb.Text = "Chủ đề dữ liệu" Then
                MsgBox("Vui lòng chọn chủ đề dữ liệu!")
                kt_1.Checked = False
            Else
                kt_2.Checked = False
                autoshare()
            End If
        End If
    End Sub
    Sub autoshare()
        Dim infoReader As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(txt_path.Text)
        If (infoReader.Length) > 10000000 Then
            MsgBox("Quá trình tải lên bị hủy vì tệp chia sẻ quá 10MB!", vbInformation, "Cảnh báo!!")
            Me.Hide()
        Else
            cmb.Enabled = False
            kt_1.Visible = False
            kt_2.Visible = False
            txt_wait.Visible = True
            If cmb.Text = "Toán" Then
                numk = 1
            ElseIf cmb.Text = "Sinh Học" Then
                numk = 2
            ElseIf cmb.Text = "Hóa Học" Then
                numk = 3
            ElseIf cmb.Text = "Tin Học" Then
                numk = 4
            ElseIf cmb.Text = "Công Nghệ" Then
                numk = 5
            ElseIf cmb.Text = "Tiếng Anh" Then
                numk = 6
            ElseIf cmb.Text = "Vật Lí" Then
                numk = 7
            ElseIf cmb.Text = "Ngữ Văn" Then
                numk = 8
            ElseIf cmb.Text = "Lịch Sử" Then
                numk = 9
            ElseIf cmb.Text = "Địa Lí" Then
                numk = 10
            ElseIf cmb.Text = "Giáo Dục Công Dân" Then
                numk = 11
            ElseIf cmb.Text = "Thể Dục" Then
                numk = 12
            ElseIf cmb.Text = "Giáo Dục Quốc Phòng" Then
                numk = 13
            ElseIf cmb.Text = "Âm Nhạc - Mỹ Thuật" Then
                numk = 14
            ElseIf cmb.Text = "Khác" Then
                numk = 15
            End If
            My.Computer.Network.UploadFile(txt_path.Text, "http://build.luutru360.com/share-data-online?name_col=" & numk, "", "", True, 5000)
            MsgBox("Tải lên hoàn tất! Vui lòng chờ đến khi dữ liệu được cập nhật!")
            Me.Hide()
        End If
    End Sub
    Private Sub kt_2_CheckedChanged(sender As Object, e As EventArgs) Handles kt_2.CheckedChanged
        If kt_2.Checked = True Then
            kt_1.Checked = False
            MsgBox("Quá trình tải lên bị hủy vì bạn không đồng ý với một số điều khoản của chúng tôi!", vbInformation, "Cảnh báo!!")
            Me.Hide()
        End If
    End Sub

    Private Sub win_share_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb.Items.Add("Toán")
        cmb.Items.Add("Sinh Học")
        cmb.Items.Add("Hóa Học")
        cmb.Items.Add("Tin Học")
        cmb.Items.Add("Công Nghệ")
        cmb.Items.Add("Tiếng Anh")
        cmb.Items.Add("Vật Lí")
        cmb.Items.Add("Ngữ Văn")
        cmb.Items.Add("Lịch Sử")
        cmb.Items.Add("Địa Lí")
        cmb.Items.Add("Giáo Dục Công Dân")
        cmb.Items.Add("Thể Dục")
        cmb.Items.Add("Giáo Dục Quốc Phòng")
        cmb.Items.Add("Âm Nhạc - Mỹ Thuật")
        cmb.Items.Add("Khác")
        ' cmb.SelectedIndex = 1
    End Sub

    Private Sub cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb.SelectedIndexChanged

    End Sub

    Private Sub cmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb.KeyPress
        e.Handled = True
    End Sub
End Class