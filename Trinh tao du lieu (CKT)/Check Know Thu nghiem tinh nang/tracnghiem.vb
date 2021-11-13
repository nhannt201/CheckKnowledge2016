Public Class tracnghiem
    Dim d1 As String = 0
    Dim d2 As String = 0
    Dim d3 As String = 0
    Dim d4 As String = 0
    Dim dapan As String = ""
    Dim datak As String = ""

    Sub reset()
        cauhoi.Clear()
        slct1.Clear()
        slct2.Clear()
        slct3.Clear()
        slct4.Clear()
        dpa.Checked = False
        dpb.Checked = False
        dpc.Checked = False
        dpd.Checked = False
        lb_sts.Text = ""
    End Sub



    Private Sub bt_add_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        checkdulieu()

    End Sub
    Sub checkdulieu()
        If cauhoi.Text.Replace(" ", "").Length < 5 Then
            MsgBox("Câu hỏi quá ngắn!", vbInformation, "Báo lỗi")
        ElseIf dpa.Checked = False And dpb.Checked = False And dpc.Checked = False And dpd.Checked = False Then
            MsgBox("Bạn chưa chọn đáp án", vbInformation, "Báo lỗi")
        ElseIf slct4.Text.Replace(" ", "").Length = 0 And d4 = 1 Then
            MsgBox("Đáp án của bạn không được toàn dấu cách!", vbInformation, "Báo lỗi")
        ElseIf slct3.Text.Replace(" ", "").Length = 0 And d3 = 1 Then
            MsgBox("Đáp án của bạn không được toàn dấu cách!", vbInformation, "Báo lỗi")
        ElseIf slct2.Text.Replace(" ", "").Length = 0 And d2 = 1 Then
            MsgBox("Đáp án của bạn không được toàn dấu cách!", vbInformation, "Báo lỗi")
        ElseIf slct1.Text.Replace(" ", "").Length = 0 And d1 = 1 Then
            MsgBox("Đáp án của bạn không được toàn dấu cách!", vbInformation, "Báo lỗi")
        ElseIf slct1.Text.Length >= 1 And slct3.Text.Length >= 1 Then
            If slct2.Text.Length = 0 Then
                MsgBox("Dường như bạn đang chọn đáp án không theo thứ tự?", vbInformation, "Báo lỗi")
            Else
                adddb()
            End If
        ElseIf slct1.Text.Length >= 1 And slct4.Text.Length >= 1 Then
            If slct3.Text.Length = 0 Then
                MsgBox("Dường như bạn đang chọn đáp án không theo thứ tự?", vbInformation, "Báo lỗi")
            Else
                adddb()
            End If
        ElseIf slct1.Text.Length >= 1 And slct4.Text.Length >= 1 Then
            If slct3.Text.Length = 0 And slct2.Text.Length = 0 Then
                MsgBox("Dường như bạn đang chọn đáp án không theo thứ tự?", vbInformation, "Báo lỗi")
            Else
                adddb()
            End If
        Else
            adddb()
        End If
    End Sub
    Sub adddb()
        If d1 = 1 And d2 = 1 And d3 = 1 And d4 = 1 Then
            datak = "<select1>" + slct1.Text + "</select1><select2>" + slct2.Text + "</select2><select3>" + slct3.Text + "</select3><select4>" + slct4.Text + "</select4>"
            addthatne()
            lb_sts.Text = "Tình trạng: Đã thêm câu hỏi và trắc nghiệm mới!"
        ElseIf d1 = 1 And d2 = 1 Then
            datak = "<select1>" + slct1.Text + "</select1><select2>" + slct2.Text + "</select2>"
            addthatne()
            lb_sts.Text = "Tình trạng: Đã thêm câu hỏi và trắc nghiệm mới!"
        ElseIf d1 = 1 And d2 = 1 And d3 = 1 Then
            datak = "<select1>" + slct1.Text + "</select1><select2>" + slct2.Text + "</select2><select3>" + slct3.Text + "</select3>"
            addthatne()
            lb_sts.Text = "Tình trạng: Đã thêm câu hỏi và trắc nghiệm mới!"
        ElseIf d1 = 1 Then
            MsgBox("Bạn không thể tạo trắc nghiệm với một đáp án!", vbInformation, "Báo lỗi")
        Else
            MsgBox("Dường như bạn đang chọn đáp án không theo thứ tự?", vbInformation, "Báo lỗi")
        End If


    End Sub
    Sub addthatne()

        editv1.data.Text = editv1.data.Text + " <" + editv1.numsv.Text + "> " + "<type>trn_abc</type><cauhoi>" + cauhoi.Text + "</cauhoi>" + datak + " <ketqua>" + dapan + "</ketqua>" + "</" + editv1.numsv.Text + ">"
        editv1.data.SelectionStart = editv1.data.Text.Length
        editv1.data.ScrollToCaret()
        editv1.data.Refresh()
        editv1.numsv.Text = editv1.numsv.Text + 1
        '    If ck1.Enabled = True Then
        If System.IO.File.Exists(editv1.pathfile.Text) = True Then

            Dim objWriter As New System.IO.StreamWriter(editv1.pathfile.Text)

            objWriter.Write(encode(editv1.data.Text))
            objWriter.Close()
            reset()
            ' MessageBox.Show("Text written to file")
        Else
            MsgBox("Không tìm thấy tệp dữ liệu, có vẻ bạn đã xoá nó?", vbInformation, "Báo lỗi")
        End If

    End Sub

    Private Sub slct1_TextChanged(sender As Object, e As EventArgs) Handles slct1.TextChanged
        If slct1.Text.Length >= 1 Then
            dpa.Enabled = True
            slct2.Enabled = True
            d1 = 1
            slct1.Text.Trim()
        Else
            dpa.Enabled = False
            d1 = 0
        End If
    End Sub

    Private Sub slct2_TextChanged(sender As Object, e As EventArgs) Handles slct2.TextChanged
        ' If d1 = 1 Then
        If slct2.Text.Length >= 1 Then
            dpb.Enabled = True
            slct3.Enabled = True
            slct2.Text.Trim()
            d2 = 1
        Else
            dpb.Enabled = False
            d2 = 0
        End If
        ' End If
    End Sub

    Private Sub slct3_TextChanged(sender As Object, e As EventArgs) Handles slct3.TextChanged
        '  If d1 = 1 And d2 = 1 Then
        If slct3.Text.Length >= 1 Then
                dpc.Enabled = True
            slct4.Enabled = True
            slct3.Text.Trim()
            d3 = 1
            Else
                dpc.Enabled = False
                d3 = 0
            End If

        ' End If
    End Sub

    Private Sub slct4_TextChanged(sender As Object, e As EventArgs) Handles slct4.TextChanged
        '  If d1 = 1 And d2 = 1 And d3 = 1 Then
        If slct4.Text.Length >= 1 Then
            dpd.Enabled = True
            slct4.Text.Trim()
            d4 = 1
            Else
                dpd.Enabled = False
                d4 = 0
            End If

        '  End If
    End Sub

    Private Sub dpa_CheckedChanged(sender As Object, e As EventArgs) Handles dpa.CheckedChanged
        dapan = "A"
    End Sub

    Private Sub dpb_CheckedChanged(sender As Object, e As EventArgs) Handles dpb.CheckedChanged
        dapan = "B"
    End Sub

    Private Sub dpc_CheckedChanged(sender As Object, e As EventArgs) Handles dpc.CheckedChanged
        dapan = "C"
    End Sub

    Private Sub dpd_CheckedChanged(sender As Object, e As EventArgs) Handles dpd.CheckedChanged
        dapan = "D"
    End Sub

    Private Sub cauhoi_TextChanged(sender As Object, e As EventArgs) Handles cauhoi.TextChanged
        lb_sts.Text = ""
    End Sub



    Private Sub tracnghiem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        editv1.Show()
    End Sub

    Private Sub rehome_Click(sender As Object, e As EventArgs)
        Dim homek As New thongtin
        homek.Show()
        Me.Hide()
    End Sub

    Private Sub tracnghiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TệpMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TệpMớiToolStripMenuItem.Click
        Dim homek As New thongtin
        homek.Show()
        Me.Hide()
    End Sub

    Private Sub QuayLạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuayLạiToolStripMenuItem.Click
        editv1.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        End
    End Sub

    Private Sub LàmMớiKhungNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LàmMớiKhungNhậpToolStripMenuItem.Click
        reset()
    End Sub

    Private Sub TạoCâuHỏiTựLuậnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TạoCâuHỏiTựLuậnToolStripMenuItem.Click
        editv1.Show()
        Me.Hide()
    End Sub

    Private Sub ThêmCâuHỏiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmCâuHỏiToolStripMenuItem.Click
        checkdulieu()
    End Sub

    Private Sub VàoTrìnhChỉnhSửaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VàoTrìnhChỉnhSửaToolStripMenuItem.Click
        Dim newedit As New trinhedit
        trinhedit.pathfile.Text = editv1.pathfile.Text
        trinhedit.Show()
        Me.Hide()
    End Sub
End Class