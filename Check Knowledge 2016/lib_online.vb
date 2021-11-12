Imports System.Xml

Public Class lib_online
    Dim txt_try As New TextBox
    'Dim dayup As String
    Dim dammay As String = "http://build.luutru360.com/"
    Dim download As String = dammay & "taive.aspx?id="
    Dim id_dw As String
    Dim name_id As String
    Dim path_dw As String
    Dim new_findmaxid As New find_max_id
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub lib_online_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            '
            PostAction(63)
            txt_try.Multiline = True
            Dim xr As XmlReader = XmlReader.Create(dammay & "time-line")
            Dim xDoc As XDocument = XDocument.Load(xr)

            For Each server As XElement In xDoc.Root.Elements("data")
                Dim tendulieu As String = CType(server.Element("name"), String)
                Dim ngay As String = CType(server.Element("date"), String)
                Dim mota As String = CType(server.Element("mota"), String)
                Dim id As String = CType(server.Element("id"), String)
                Dim col As String = CType(server.Element("col"), String)
                txt_try.Text = txt_try.Text + "<id_" + rpdwn(id) + ">" + "<col>" + col + "</col>" + "<mota>" + mota + "</mota>" + "<tenfile>" + tendulieu + "</tenfile>" + "<id>" + rpdwn(id) + "</id>" + "<date>" + ngay + "</date>" + "</id_" + rpdwn(id) + ">"
                ' your ping logic goes here '
                ' Dim ping As String = "50"

                listonline.Items.Add(String.Format("{0} [{1}]", tendulieu, rpdwn(id)))
            Next
            ' Dim lst1 As String = SplitString(txt_try.Text, "<id_0110256>", "</id_0110256>")
            ' MsgBox(SplitString(lst1, "<mota>", "</mota>"))
            Dim folderInfo As New IO.DirectoryInfo(Application.StartupPath & "\Download\")
            Dim arrFilesInFolder() As IO.FileInfo
            Dim fileInFolder As IO.FileInfo
            arrFilesInFolder = folderInfo.GetFiles("*.ckt")
            For Each fileInFolder In arrFilesInFolder
                lst_down.Items.Add(fileInFolder.Name)
            Next
            cbx.Items.Add("Tất cả")
            cbx.Items.Add("Toán")
            cbx.Items.Add("Sinh Học")
            cbx.Items.Add("Hóa Học")
            cbx.Items.Add("Tin Học")
            cbx.Items.Add("Công Nghệ")
            cbx.Items.Add("Tiếng Anh")
            cbx.Items.Add("Vật Lí")
            cbx.Items.Add("Ngữ Văn")
            cbx.Items.Add("Lịch Sử")
            cbx.Items.Add("Địa Lí")
            cbx.Items.Add("Giáo Dục Công Dân")
            cbx.Items.Add("Thể Dục")
            cbx.Items.Add("Giáo Dục Quốc Phòng")
            cbx.Items.Add("Âm Nhạc - Mỹ Thuật")
            cbx.Items.Add("Khác")
            cbx.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Xin lỗi, máy chủ hiện tại không thể truy cập. Vui lòng quay lại sao!")
            Dim load_all As New load1
            load_all.Show()
            Me.Close()
        End Try
    End Sub
    Public Function SplitString(ByVal mainString As String, ByVal BeginString As String, ByVal EndString As String) As String
        Dim i_s As Integer : i_s = InStr(mainString, BeginString)
        Dim i_e As Integer : i_e = InStr(mainString, EndString)
        On Error Resume Next
        If i_s <> -1 And i_e <> -1 Then
            Dim s As String

            s = Mid(mainString, i_s + Len(BeginString), i_e - i_s - Len(BeginString))
            SplitString = s

        Else
            SplitString = ""
        End If
    End Function

    Private Sub listonline_Click(sender As Object, e As EventArgs) Handles listonline.Click
        click_or_select()
    End Sub

    Sub click_or_select()
        If listonline.Items.Count < 1 Then
            txt_mota.Clear()
            PostAction(71)
        Else
            PostAction(71)
            Dim idk As String = SplitString(listonline.Text, "[", "]")
            id_dw = rpdwn(idk)
            Dim lst2 As String = SplitString(txt_try.Text, "<id_" + idk + ">", "</id_" + idk + ">")
            Dim ngayla As String = SplitString(lst2, "<date>", "</date>")
            Dim tenfilek As String = SplitString(lst2, "<tenfile>", "</tenfile>")
            Dim col_name As String = SplitString(lst2, "<col>", "</col>")

            name_id = tenfilek
            ' Dim ngayla As String = SplitString(lst2, "<date>", "</date>")
            txt_mota.Text = (SplitString(lst2, "<mota>", "</mota>")) & vbNewLine & "Đăng vào ngày " & ngayla & vbNewLine & "Chủ đề: " & get_mon(col_name, 0)
        End If
    End Sub
    Public Function get_mon(numk As String, name As String) As String
        If numk = 1 Then
            name = "Toán"
        ElseIf numk = 2 Then
            name = "Sinh Học"
        ElseIf numk = 3 Then
            name = "Hóa Học"
        ElseIf numk = 4 Then
            name = "Tin Học"
        ElseIf numk = 5 Then
            name = "Công Nghệ"
        ElseIf numk = 6 Then
            name = "Tiếng Anh"
        ElseIf numk = 7 Then
            name = "Vật Lí"
        ElseIf numk = 8 Then
            name = "Ngữ Văn"
        ElseIf numk = 9 Then
            name = "Lịch Sử"
        ElseIf numk = 10 Then
            name = "Địa Lí"
        ElseIf numk = 11 Then
            name = "Giáo Dục Công Dân"
        ElseIf numk = 12 Then
            name = "Thể Dục"
        ElseIf numk = 13 Then
            name = "Giáo Dục Quốc Phòng"
        ElseIf numk = 14 Then
            name = "Âm Nhạc - Mỹ Thuật"
        ElseIf numk = 15 Then
            name = "Khác"
            ' ElseIf numk = 16 Then
            '    name = "Tất cả"
        End If
        Return name
    End Function
    Public Function rpdwn(chuoi As String) As String
        chuoi = chuoi.Replace("0", "T00").Replace("1", "00A").Replace("2", "0Z0").Replace("3", "Q00").Replace("4", "Y00").Replace("5", "0I0").Replace("6", "X00").Replace("7", "0O0").Replace("8", "L00").Replace("9", "0S0")
        Return chuoi
    End Function

    Private Sub bt_q_Click(sender As Object, e As EventArgs) Handles bt_q.Click
        timkiem(txt_q.Text, rent_num)

    End Sub
    Sub timkiem(chuoi As String, numkk As String)
        '
        Try
            PostAction(64)
            txt_try.Multiline = True
            txt_try.Clear()
            listonline.Items.Clear()
            Dim check_timeline As String
            If numkk = 0 Then
                check_timeline = dammay & "time-line?q=" & chuoi
            Else
                check_timeline = dammay & "time-line?q=" & chuoi & "&col=" & numkk
            End If
            Dim xr As XmlReader = XmlReader.Create(check_timeline)
            Dim xDoc As XDocument = XDocument.Load(xr)
            For Each server As XElement In xDoc.Root.Elements("data")
                Dim tendulieu As String = CType(server.Element("name"), String)
                Dim ngay As String = CType(server.Element("date"), String)
                Dim mota As String = CType(server.Element("mota"), String)
                Dim id As String = CType(server.Element("id"), String)
                Dim col As String = CType(server.Element("col"), String)
                txt_try.Text = txt_try.Text + "<id_" + rpdwn(id) + ">" + "<col>" + col + "</col>" + "<mota>" + mota + "</mota>" + "<tenfile>" + tendulieu + "</tenfile>" + "<id>" + rpdwn(id) + "</id>" + "<date>" + ngay + "</date>" + "</id_" + rpdwn(id) + ">"
                listonline.Items.Add(String.Format("{0} [{1}]", tendulieu, rpdwn(id)))
            Next
        Catch
            MsgBox("Không tìm thấy tài liệu nào!", vbInformation, "Cảnh báo!!")
        End Try
    End Sub

    Sub select_col(col_num As String)
        '
        Try
            PostAction(64)
            txt_try.Multiline = True
            txt_try.Clear()
            listonline.Items.Clear()
            Dim check_timlin As String
            If col_num = 0 Then
                check_timlin = dammay & "time-line"
            Else
                check_timlin = dammay & "time-line?col=" & col_num
            End If
            Dim xr As XmlReader = XmlReader.Create(check_timlin)
            Dim xDoc As XDocument = XDocument.Load(xr)

            For Each server As XElement In xDoc.Root.Elements("data")
                Dim tendulieu As String = CType(server.Element("name"), String)
                Dim ngay As String = CType(server.Element("date"), String)
                Dim mota As String = CType(server.Element("mota"), String)
                Dim id As String = CType(server.Element("id"), String)
                Dim col As String = CType(server.Element("col"), String)
                txt_try.Text = txt_try.Text + "<id_" + rpdwn(id) + ">" + "<col>" + col + "</col>" + "<mota>" + mota + "</mota>" + "<tenfile>" + tendulieu + "</tenfile>" + "<id>" + rpdwn(id) + "</id>" + "<date>" + ngay + "</date>" + "</id_" + rpdwn(id) + ">"
                listonline.Items.Add(String.Format("{0} [{1}]", tendulieu, rpdwn(id)))
            Next
        Catch
            MsgBox("Không tìm thấy tài liệu nào!", vbInformation, "Cảnh báo!!")
        End Try
    End Sub

    Private Sub txt_q_TextChanged(sender As Object, e As EventArgs) Handles txt_q.TextChanged
        'timkiem(txt_q.Text)

    End Sub


    Private Sub bt_dw_Click(sender As Object, e As EventArgs) Handles bt_dw.Click
        Try
            PostAction(65)
            If System.IO.File.Exists(Application.StartupPath & "\Download\" & name_id & ".ckt") Then
                MsgBox("Xin lỗi, tệp tin bạn dự định tải đã có sẵn trong máy!")
            Else
                lb_dw.Visible = True
                lb_dw.Text = "Đang tải tệp '" & name_id & "'"
                Me.Enabled = False
                My.Computer.Network.DownloadFile(download & id_dw, Application.StartupPath & "\Download\" & name_id & ".ckt")
                Me.Enabled = True
                lb_dw.Visible = False
                lst_down.Items.Add(name_id & ".ckt")
                MsgBox("Tải về hoàn tất")
            End If
        Catch
            MsgBox("Xin lỗi, tệp tin bạn dự định tải có thể đã bị xóa hoặc không tồn tại!")
            Me.Enabled = True
            lb_dw.Visible = False
        End Try
    End Sub



    Private Sub lst_down_Click(sender As Object, e As EventArgs) Handles lst_down.Click
        path_dw = lst_down.Text
    End Sub

    Private Sub bt_del_Click(sender As Object, e As EventArgs) Handles bt_del.Click
        Try
            PostAction(66)
            If path_dw = "" Then
                MsgBox("Bạn chưa chọn tệp để xóa!", vbInformation, "Cảnh báo!!")
            Else
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Download\" & path_dw)
                lst_down.Items.Remove(lst_down.SelectedItem)
                MsgBox("Đã xóa tệp tin!", vbInformation, "Cảnh báo!!")
            End If
        Catch
            MsgBox("Tệp này đã được xóa!", vbInformation, "Cảnh báo!!")
        End Try
    End Sub

    Private Sub txt_open_Click(sender As Object, e As EventArgs) Handles bt_open.Click
        PostAction(67)
        If path_dw = "" Then
            MsgBox("Bạn chưa chọn tệp để mở!", vbInformation, "Cảnh báo!!")
        Else
            load_open()
        End If

    End Sub
    Sub load_open()
        new_findmaxid.pathk.Text = Application.StartupPath & "\Download\" & path_dw
        show_me_all("tudo")
        Me.Hide()
    End Sub

    Sub show_me_all(rd As String)
        play_all_program.txt_get_class.Text = rd
        Me.Enabled = False
        new_findmaxid.Show()
    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        PostAction(68)
        Dim frk = New load1
        frk.Show()
        My.Computer.Audio.Stop()
        theme2.Enabled = True
        find_max_id.Close()
        play_all_program.Close()
        Me.Close()
    End Sub

    Private Sub lib_online_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub txt_q_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_q.KeyDown
        If e.KeyCode = Keys.Enter Then
            timkiem(txt_q.Text, rent_num)
        End If
    End Sub


    Private Sub pn_1_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub pn_1_MouseDown(sender As Object, e As MouseEventArgs) Handles pn_1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub pn_1_MouseUp(sender As Object, e As MouseEventArgs) Handles pn_1.MouseUp
        drag = False
        Me.Refresh()
    End Sub

    Private Sub pn_1_Paint(sender As Object, e As PaintEventArgs) Handles pn_1.Paint
        PostAction(69)
    End Sub

    Private Sub txt_mota_TextChanged(sender As Object, e As EventArgs) Handles txt_mota.TextChanged
        PostAction(70)
    End Sub

    Private Sub cbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx.SelectedIndexChanged
        select_col(rent_num)
    End Sub

    Public Function rent_num()
        Dim numk As String
        If cbx.Text = "Toán" Then
            numk = 1
        ElseIf cbx.Text = "Sinh Học" Then
            numk = 2
        ElseIf cbx.Text = "Hóa Học" Then
            numk = 3
        ElseIf cbx.Text = "Tin Học" Then
            numk = 4
        ElseIf cbx.Text = "Công Nghệ" Then
            numk = 5
        ElseIf cbx.Text = "Tiếng Anh" Then
            numk = 6
        ElseIf cbx.Text = "Vật Lí" Then
            numk = 7
        ElseIf cbx.Text = "Ngữ Văn" Then
            numk = 8
        ElseIf cbx.Text = "Lịch Sử" Then
            numk = 9
        ElseIf cbx.Text = "Địa Lí" Then
            numk = 10
        ElseIf cbx.Text = "Giáo Dục Công Dân" Then
            numk = 11
        ElseIf cbx.Text = "Thể Dục" Then
            numk = 12
        ElseIf cbx.Text = "Giáo Dục Quốc Phòng" Then
            numk = 13
        ElseIf cbx.Text = "Âm Nhạc - Mỹ Thuật" Then
            numk = 14
        ElseIf cbx.Text = "Khác" Then
            numk = 15
        ElseIf cbx.Text = "Tất cả" Then
            numk = 0
        End If
        Return numk
    End Function
    Private Sub cbx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbx.KeyPress
        e.Handled = True
    End Sub

    Private Sub listonline_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listonline.SelectedIndexChanged
        click_or_select()
    End Sub
End Class