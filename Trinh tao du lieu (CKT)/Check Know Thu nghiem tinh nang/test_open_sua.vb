Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Public Class test_open_sua
    Dim data_base As String = 0
    Dim position As String
    Dim baner As String

    '  Dim FILE_NAME As Integer = pathfile.Text



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadk()
        data.Visible = False
        Me.Enabled = False
    End Sub
    Sub loadk()
        If My.Computer.FileSystem.FileExists(pathfile.Text) Then
            '  MsgBox("File found.")

            Using sr As New StreamReader(pathfile.Text)
                Dim line As String
                ' Read the stream to a string and write the string to the console.
                line = sr.ReadToEnd()
                data.Text = decode(line)
            End Using
            data.SelectionStart = data.Text.Length
            data.ScrollToCaret()
            data.Refresh()
        Else
            '  MsgBox("File not found.")
            Dim path As String = pathfile.Text

            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(path)

            ' Add text to the file.
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("")
            fs.Write(info, 0, info.Length)
            fs.Close()

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_them.Click
        checkcauhoi()
    End Sub
    Sub addd()

        data.Text = data.Text + " <" + numsv.Text + "> " + "<cauhoi>" + cauhoi.Text + "</cauhoi>" + " <ketqua>" + dapan.Text + "</ketqua>" + "</" + numsv.Text + ">"
        data.SelectionStart = data.Text.Length
        data.ScrollToCaret()
        data.Refresh()
        numsv.Text = numsv.Text + 1
        cauhoi.Text = ""
        dapan.Text = ""
        '  If ck1.Enabled = True Then
        If System.IO.File.Exists(pathfile.Text) = True Then

            Dim objWriter As New System.IO.StreamWriter(pathfile.Text)
            encode(data.Text)
            objWriter.Write(encode(data.Text))
            objWriter.Close()
            ' MessageBox.Show("Text written to file")
        Else
            MsgBox("Không tìm thấy tệp dữ liệu, có vẻ bạn đã xoá nó?", vbInformation, "Báo lỗi")
        End If

        lb_sts.Text = "Đã thêm câu hỏi!"
        '  End If
    End Sub
    Private Function encode(data As String) As String
        data = data.Replace("<", "A1A5").Replace(">", "_2_7").Replace("tacgia", "_01rtfg_-_dg.__d-gdg").Replace("about", "_..rt)(dfdf)_----")
        data = data.Replace("â", "_x50_").Replace("ă", "_x22_").Replace("ấ", "_x25_").Replace("ằ", "_x29_").Replace("á", "_x23_").Replace("à", "_x211_").Replace("ạ", "_x2._").Replace("ô", "_121_aaass_").Replace("ậ", "5912556.8").Replace("ự", "_89123245_").Replace("ử", "_113114115_").Replace("ê", "_YYYXXX__").Replace("ớ", "_986_1532_2019_")
        data = data.Replace("pass", "_x2905_").Replace("ketqua", "_pass_15x_091_").Replace("select", "_0x001520_").Replace("cauhoi", "_anti_vs_xem_")
        data = data.Replace("nh", "_<3_").Replace("qu", "_<2_").Replace("th", "_<o_").Replace("kh", "_<i_").Replace("ngh", "_<p_").Replace("ch", "_<s_").Replace("tr", "_<u_")
        Return data
    End Function
    Private Function decode(data As String) As String
        data = data.Replace("A1A5", "<").Replace("_2_7", ">").Replace("_01rtfg_-_dg.__d-gdg", "tacgia").Replace("_..rt)(dfdf)_----", "about")
        data = data.Replace("_x50_", "â").Replace("_x22_", "ă").Replace("_x25_", "ấ").Replace("_x29_", "ằ").Replace("_x23_", "á").Replace("_x211_", "à").Replace("_x2._", "ạ").Replace("_121_aaass_", "ô").Replace("5912556.8", "ậ").Replace("_89123245_", "ự").Replace("_113114115_", "ử").Replace("_YYYXXX__", "ê").Replace("_986_1532_2019_", "ớ")
        data = data.Replace("_x2905_", "pass").Replace("_pass_15x_091_", "ketqua").Replace("_0x001520_", "select").Replace("_anti_vs_xem_", "cauhoi")
        data = data.Replace("_<3_", "nh").Replace("_<2_", "qu").Replace("_<o_", "th").Replace("_<i_", "kh").Replace("_<p_", "ngh").Replace("_<s_", "ch").Replace("_<u_", "tr")
        Return data
    End Function
    Sub checkcauhoi()
        If cauhoi.Text.Length < 5 Or dapan.Text.Length < 5 Then
            MsgBox("Câu hỏi hoặc đáp án quá ngắn!")
        Else
            addd()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)


        If System.IO.File.Exists(pathfile.Text) = True Then

            Dim objWriter As New System.IO.StreamWriter(pathfile.Text)

            objWriter.Write(data.Text)
            objWriter.Close()
            ' MessageBox.Show("Text written to file")
        Else
            MsgBox("Không tìm thấy tệp dữ liệu, có vẻ bạn đã xoá nó?", vbInformation, "Báo lỗi")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        numsv.Text = numsv.Text + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bt_reset.Click
        cauhoi.Clear()
        dapan.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles bt_del.Click
        If System.IO.File.Exists(pathfile.Text) = True Then
            Kill(pathfile.Text)
            data.Text = ""
        Else

        End If
    End Sub

    Private Sub tm1_Tick(sender As Object, e As EventArgs) Handles tm1.Tick
        data_base = data_base + 1
        position = InStr(data.Text, "<" + data_base + ">")
        If position = 0 Then
            numsv.Text = data_base
            Me.Enabled = True
            tm1.Stop()

        End If
    End Sub

    Private Sub bt_sur_Click(sender As Object, e As EventArgs) Handles bt_sur.Click

        If numsv.Text <= data_base Then

        Else
            numsv.Text = numsv.Text - 1
        End If
    End Sub

    Private Sub bt_tracnghiem_Click(sender As Object, e As EventArgs) Handles bt_tracnghiem.Click
        tracnghiem.Show()
        Me.Hide()
    End Sub

    Private Sub editv1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub dapan_TextChanged(sender As Object, e As EventArgs) Handles dapan.TextChanged

    End Sub

    Private Sub dapan_KeyDown(sender As Object, e As KeyEventArgs) Handles dapan.KeyDown
        If ck1.Checked = True Then
            If e.KeyCode = Keys.Enter Then
                checkcauhoi()
            End If
        End If
    End Sub

    Private Sub cauhoi_TextChanged(sender As Object, e As EventArgs) Handles cauhoi.TextChanged
        lb_sts.Text = ""
    End Sub
End Class