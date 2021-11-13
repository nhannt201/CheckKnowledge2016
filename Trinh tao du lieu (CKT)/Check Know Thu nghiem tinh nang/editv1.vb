Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Public Class editv1
    Dim data_base As String = -1
    Dim position As String
    Dim baner As String
    '  Dim FILE_NAME As Integer = pathfile.Text

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadk()
        data.Visible = False
        '   trinhedit.Close()
        '  thongtin.Close()
        lb_sts.Text = ""
        Me.Enabled = False
    End Sub
    Sub loadk()
        If My.Computer.FileSystem.FileExists(pathfile.Text) Then
            '  MsgBox("File found.")

            Using sr As New StreamReader(pathfile.Text)
                Dim line As String
                ' Read the stream to a string and write the string to the console.
                line = sr.ReadToEnd()
                data.Text = line
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
        cauhoi.Clear()
        dapan.Clear()

        '  If ck1.Enabled = True Then
        If System.IO.File.Exists(pathfile.Text) = True Then

            Dim objWriter As New System.IO.StreamWriter(pathfile.Text)
            encode(data.Text)
            objWriter.Write(encode(data.Text))
            objWriter.Close()
            ' MessageBox.Show("Text written to file")
        Else
            MsgBox("Không tìm thấy tệp đã tạo, có vẻ bạn đã xoá nó rồi?", vbInformation, "Báo lỗi")
        End If
        lb_sts.Visible = True
        lb_sts.Text = "Tình trạng: Đã thêm câu hỏi!"
        '  End If
    End Sub

    Sub checkcauhoi()
        cauhoi.Text.Trim()
        dapan.Text.Trim()
        If cauhoi.Text.Replace(" ", "").Length < 5 Or dapan.Text.Replace(" ", "").Length < 5 Then
            MsgBox("Câu hỏi hoặc đáp án quá ngắn!" & vbNewLine & "Vui lòng nhập dữ liệu đầy đủ!", vbInformation, "Cảnh báo!!")
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




    Private Sub tm1_Tick(sender As Object, e As EventArgs) Handles tm1.Tick
        If sota.Text = "true" Then
            Me.Enabled = True
            '  numsv.Text = numsv.Text - 1
            ' Me.Text = (numsv.Text)

            tm1.Stop()
        Else
            data_base = data_base + 1
            position = InStr(data.Text, "<" + data_base + ">")
            If position = 0 Then
                numsv.Text = data_base
                Me.Enabled = True
                ' Me.Text = (numsv.Text)
                tm1.Stop()

            End If
        End If

    End Sub

    Private Sub bt_sur_Click(sender As Object, e As EventArgs) Handles bt_sur.Click

        If numsv.Text <= data_base Then

        Else
            numsv.Text = numsv.Text - 1
        End If
    End Sub


    Private Sub editv1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub



    Private Sub cauhoi_TextChanged(sender As Object, e As EventArgs) Handles cauhoi.TextChanged
        lb_sts.Text = "Tình trạng: Đang nhập câu hỏi...."
    End Sub


    Private Sub XóaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaDataToolStripMenuItem.Click
        If System.IO.File.Exists(pathfile.Text) = True Then
            Kill(pathfile.Text)
            data.Text = ""
        Else

        End If
    End Sub

    Private Sub DọnDẹpCácÔToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DọnDẹpCácÔToolStripMenuItem.Click
        cauhoi.Clear()
        dapan.Clear()
    End Sub

    Private Sub TạoTrắcNghiệmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TạoTrắcNghiệmToolStripMenuItem.Click
        tracnghiem.Show()
        Me.Hide()
    End Sub





    Private Sub dapan_KeyUp(sender As Object, e As KeyEventArgs) Handles dapan.KeyUp
        '  If ck1.Checked = True Then
        'If e.KeyCode = Keys.Enter Then
        'checkcauhoi()
        'End If
        '  End If
    End Sub

    Private Sub TệpMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TệpMớiToolStripMenuItem.Click
        Dim homek As New thongtin
        homek.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ThêmCâuHỏiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmCâuHỏiToolStripMenuItem.Click
        checkcauhoi()
    End Sub

    Private Sub dapan_TextChanged(sender As Object, e As EventArgs) Handles dapan.TextChanged
        lb_sts.Text = "Tình trạng: Đang nhập đáp án...."
    End Sub

    Private Sub TruyCậpTrìnhSửaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TruyCậpTrìnhSửaToolStripMenuItem.Click
        Dim newedit As New trinhedit
        trinhedit.pathfile.Text = pathfile.Text
        trinhedit.Show()
        Me.Hide()
    End Sub
End Class