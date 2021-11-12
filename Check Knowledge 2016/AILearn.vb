Module AILearn
    Dim user As String
    Dim server As String = "http://build.luutru360.com/up.php"
    Dim pass As String = ""
    Dim memori_trial As String = ""
    Public Sub StartAI(ByVal id As String)
        user = id
        ' MsgBox("Comple First!")
    End Sub
    Public Sub PostAction(ByVal action As String)
        memori_trial = memori_trial + action + "|"
        '  GetServer(action)
    End Sub
    Public Sub PostAction2(ByVal action As String)
        If action = 1 Then
            PostServer("Login...")
            ''Home
        ElseIf action = 2 Then
            PostServer("Đang ở trang chủ")
        ElseIf action = 3 Then
            PostServer("Đang mở cài đặt")
        ElseIf action = 4 Then
            PostServer("Đã click 'Trở về'")
        ElseIf action = 5 Then
            PostServer("Đã click 'Lưu'")
        ElseIf action = 6 Then
            PostServer("Đã tick 'Tự động sang...'")
        ElseIf action = 7 Then
            PostServer("Đã bỏ tick 'Tự động sang...'")
        ElseIf action = 8 Then
            PostServer("Đã tick 'Tự động trả lời...'")
        ElseIf action = 9 Then
            PostServer("Đã bỏ tick 'Tự động đã lời...'")
        ElseIf action = 10 Then
            PostServer("Đã tick 'Hiện đáp án...'")
        ElseIf action = 11 Then
            PostServer("Đã bỏ tick 'Hiện đáp án...'")
        ElseIf action = 12 Then
            PostServer("Đã tick 'Bật âm thanh...'")
        ElseIf action = 13 Then
            PostServer("Đã bỏ tick 'Bật âm thanh...'")
        ElseIf action = 14 Then
            PostServer("Đã tick 'Toàn màn hình...'")
        ElseIf action = 15 Then
            PostServer("Đã bỏ tick 'Toàn màn hình...'")
        ElseIf action = 16 Then
            PostServer("Đã mở 'Cập nhật...'")
            ''Den phan Lop THCS va THPT
        ElseIf action = 17 Then
            PostServer("Đã click 'Lớp 6...'")
        ElseIf action = 18 Then
            PostServer("Đã click 'Lớp 7...'")
        ElseIf action = 19 Then
            PostServer("Đã click 'Lớp 8...'")
        ElseIf action = 20 Then
            PostServer("Đã click 'Lớp 9...'")
        ElseIf action = 21 Then
            PostServer("Đã click 'Lớp 10...'")
        ElseIf action = 22 Then
            PostServer("Đã click 'Lớp 11...'")
        ElseIf action = 23 Then
            PostServer("Đã click 'Lớp 12...'")
        ElseIf action = 24 Then
            PostServer("Đã click 'Ngẫu nhiên'")
        ElseIf action = 27 Then
            PostServer("Đã click 'Tạo và sửa bài kiểm'")
        ElseIf action = 28 Then
            PostServer("Đã click 'Nhập bài kiểm'")
            ''Menu
        ElseIf action = 25 Then
            PostServer("Đã click 'Thu nhỏ tại trang chủ'")
        ElseIf action = 26 Then
            PostServer("Đã thoát tại trang chủ")
            ''Formchonpath
        ElseIf action = 29 Then
            PostServer("Đang ở trang chọn Path")
        ElseIf action = 30 Then
            PostServer("Đã click 'Quay lại' tại trang chọn Path")
        ElseIf action = 31 Then
            PostServer("Đã click 'Chọn dữ liệu trong máy'")
        ElseIf action = 32 Then
            PostServer("Đã click 'Chọn dữ liệu từ thư viện'")
        End If
    End Sub
    Public Sub UpSV()
        memori_trial = "[" + user + "]" + memori_trial
        PostServer(memori_trial)
    End Sub
    Public Sub PostServer(ByVal serveritem As String)
        Try
            Dim W As New Net.WebClient
            Dim NC As New System.Collections.Specialized.NameValueCollection
            NC.Add("AIlearn", serveritem) ' + "|" + user)
            Dim RESP As Byte()
            Dim R As String
            RESP = W.UploadValues(server, NC)
            R = System.Text.Encoding.ASCII.GetString(RESP)
            ' MsgBox(R)
            End
        Catch

        End Try
    End Sub
    Public Sub GetServer(ByVal serveritem As String)
        Dim sourceString As String = New System.Net.WebClient().DownloadString(server + "?AIlearn=" + serveritem)
    End Sub
End Module
