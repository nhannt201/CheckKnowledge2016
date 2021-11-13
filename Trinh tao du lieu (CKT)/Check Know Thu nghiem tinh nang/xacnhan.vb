Imports System.Text
Imports System.Security.Cryptography
Public Class xacnhan
    Dim Cfdsfd_Xx5_x100X5553x As String
    Private Sub bt_ok_Click(sender As Object, e As EventArgs) Handles bt_ok.Click
        sendok()
    End Sub
    Sub sendok()
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(txt_pk.Text)
        Cfdsfd_Xx5_x100X5553x = MD5Hash(Convert.ToBase64String(byt))
        If Cfdsfd_Xx5_x100X5553x = passk.Text Then
            trinhedit.Show()
            trinhedit.Enabled = True
            trinhedit.gothoi.Start()
            Me.Hide()
        Else
            MsgBox("Mã bảo mật không đúng!", vbInformation, "Báo lỗi")
        End If
    End Sub
    Private Sub xacnhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trinhedit.Hide()
        trinhedit.Enabled = False
    End Sub

    Private Sub bt_cel_Click(sender As Object, e As EventArgs) Handles bt_cel.Click
        thongtin.Show()
        'trinhedit.Enabled = True
        trinhedit.Dispose()
        Me.Hide()
    End Sub

    Private Sub txt_pk_TextChanged(sender As Object, e As EventArgs) Handles txt_pk.TextChanged

    End Sub

    Private Sub txt_pk_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_pk.KeyUp
        If e.KeyCode = Keys.Enter Then
            sendok()
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


End Class