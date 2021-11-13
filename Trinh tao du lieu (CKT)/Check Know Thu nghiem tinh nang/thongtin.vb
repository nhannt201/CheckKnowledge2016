Imports System.Text
Imports System.Security.Cryptography
Public Class thongtin


    Private Sub thongtin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'name ko qua 300, tg not 300, ghichu = 800
        xacnhan.Close()
        trinhedit.Close()
    End Sub

    Private Sub bt_new_Click(sender As Object, e As EventArgs) Handles bt_new.Click
        Dim kts As String = ""
        If txt_name.Text.Length < 1 Then
            txt_name.Text = "Dulieumoi"
        End If
        If txt_tg.Text.Length < 2 Then
            txt_tg.Text = "(Không có)"
        End If
        If txt_ghichu.Text.Length < 2 Then
            txt_ghichu.Text = "(Không có)"
        End If
        If txt_mat.Text.Length < 1 Then
            txt_mat.Text = "2k1"
        End If
        If ck_ok.Checked = False Then
            kts = "_er_or_e-12_599_"
        End If
        Dim s As New SaveFileDialog
        s.Title = "Lưu dữ liệu"
        s.FileName = txt_name.Text
        s.Filter = "Tập tin dữ liệu CKT|*.ckt"
        ' s.CheckFileExists = "Tệp này đã tồn tại, bạn có muốn thay thế?"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim w As New IO.StreamWriter(s.FileName)
            Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(txt_mat.Text)
            txt_mat.Text = Convert.ToBase64String(byt)
            w.WriteLine(encode("<pass>" & MD5Hash(txt_mat.Text) & "</pass><about><tacgia>" & txt_tg.Text & "</tacgia><ghichu>" & txt_ghichu.Text & "</ghichu></about><t_uD_R>" & kts & "</t_uD_R>"))
            w.Close()
            editv1.pathfile.Text = s.FileName
            editv1.Show()
            Me.Hide()
            '  MsgBox("File saved")
        Else
            txt_name.Clear()
            txt_tg.Clear()
            txt_mat.Clear()
            txt_ghichu.Clear()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s As New OpenFileDialog
        s.Title = "Mở dữ liệu"
        s.FileName = txt_name.Text
        s.Filter = "Tệp dữ liệu CKT|*.ckt"
        If s.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim newedit As New trinhedit
            trinhedit.pathfile.Text = s.FileName
            trinhedit.Show()
            '   trinhedit.gothoi.Start()
            Me.Hide()
        End If
    End Sub
    Function MD5Hash(ByVal password As String)
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim result As Byte()
        result = md5.ComputeHash(Encoding.ASCII.GetBytes(password))

        Dim strBuilder As New StringBuilder()

        For i As Integer = 0 To result.Length - 1
            strBuilder.Append(result(i).ToString("x1.5"))
        Next

        Return strBuilder.ToString()
    End Function

    Private Sub bt_share_Click(sender As Object, e As EventArgs) Handles bt_share.Click
        Dim s As New OpenFileDialog
        s.Title = "Chia sẻ dữ liệu"
        s.FileName = txt_name.Text
        s.Filter = "Tệp dữ liệu CKT|*.ckt"
        If s.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim wins As New win_share
            wins.txt_path.Text = s.FileName
            wins.Show()
            '   trinhedit.gothoi.Start()
            'Me.Hide()
        End If
    End Sub
End Class