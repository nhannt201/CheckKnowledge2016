'ham de dung regax nhung co the bo no do loi...
Imports System.Text.RegularExpressions
Imports System
Imports System.IO
Imports Microsoft.VisualBasic
'Imports System.core
Public Class theme2


    Dim macdinh As String
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim s1 As String = "data1"
    Dim s2 As String = "data2"
    Dim s3 As String = "data3"
    Dim s4 As String = "data4"
    Dim s5 As String = "data5"
    Dim s6 As String = "data6"
    Dim s7 As String = "data7"
    Dim s8 As String = "data8"
    Dim sX As String = "tudo"


    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        'thoat
        PostAction(26)
        ' End
        upload_sv.Show()
        upload_sv.Hide()
        Me.Hide()
    End Sub

    Private Sub miniform_Click(sender As Object, e As EventArgs) Handles miniform.Click
        'thu nho
        PostAction(25)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'hieu ung end
    Private Sub thoat_MouseMove(sender As Object, e As MouseEventArgs) Handles thoat.MouseMove
        thoat.BackColor = Color.Brown
    End Sub

    'hieu ung form colr mac dinh
    Private Sub theme2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        thoat.BackColor = Color.Red
        miniform.BackColor = Color.DodgerBlue
        lb_up.BackColor = Color.SteelBlue
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub


    'hieu ung theme
    Private Sub nen_MouseMove(sender As Object, e As MouseEventArgs) Handles nen.MouseMove
        thoat.BackColor = Color.Red
        miniform.BackColor = Color.DodgerBlue
        lop6.BackColor = Color.Aquamarine
        lop7.BackColor = Color.Aquamarine
        lop8.BackColor = Color.Aquamarine
        lop9.BackColor = Color.Aquamarine
        lop10.BackColor = Color.Aquamarine
        lop11.BackColor = Color.Aquamarine
        lop12.BackColor = Color.Aquamarine
        canhan.BackColor = Color.Aquamarine
        canhan2.BackColor = Color.Aquamarine
        lopk6.BackColor = lop6.BackColor
        lopk7.BackColor = lop7.BackColor
        lopk8.BackColor = lop8.BackColor
        lopk9.BackColor = lop9.BackColor
        lopk10.BackColor = lop10.BackColor
        lopk11.BackColor = lop11.BackColor
        lopk12.BackColor = lop12.BackColor
        lopk_me.BackColor = canhan.BackColor
        lb_nap.BackColor = canhan2.BackColor
        lb_st.BackColor = Color.LightSlateGray

    End Sub

    Private Sub miniform_MouseMove(sender As Object, e As MouseEventArgs) Handles miniform.MouseMove
        'hieu ung thu nho
        miniform.BackColor = Color.DeepSkyBlue
    End Sub
    'hieu ung di chuyen chu tieu de
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lb_title.Left = lb_title.Left - 2

        If lb_title.Left <= 6 Then lb_title.Left = macdinh

    End Sub

    Private Sub theme2_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
        Me.Refresh()
    End Sub

    Private Sub theme2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub theme2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            '   Label2.Parent = lop6
            '   Label2.BringToFront()
            lb_title.Text = "Check Knowledge - Kiểm tra kiến thức - Phiên bản " & My.Settings.client_ver
            If My.Computer.Network.IsAvailable Then
                lb_up.Visible = True
                PostAction(2)
            Else
                lb_up.Visible = False
            End If

            macdinh = lb_title.Left
            find_max_id.Close()
            thongke.Close()
            dapanshow.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lop6_Click(sender As Object, e As EventArgs) Handles lop6.Click
        'so ngau nhien
        'play_all_program.lv_class.Text = play_all_program.txt_get_class.Text

        '   find_max_id.lb_data.Text = "s1"

        'an form va qua lop 6
        ' play_all_program.Show()
        '  Me.Hide()
        show_me_all(s1)
    End Sub
    'ham khai ra cua các lay cau hoi
    Function FindStringLoc(rootstring As String, s As String) As List(Of Integer)
        Dim lst As New List(Of Integer)
        For i As Integer = 0 To rootstring.Length - s.Length
            If rootstring.Substring(i, s.Length).ToLower = s.ToLower Then
                lst.Add(i)
            End If
        Next
        Return lst
    End Function
    'end ham khai ra lay cau hoi

    Private Sub lop6_MouseMove(sender As Object, e As MouseEventArgs) Handles lop6.MouseMove
        lop6.BackColor = Color.MediumSpringGreen
        lopk6.BackColor = lop6.BackColor
    End Sub

    Private Sub lop7_Click(sender As Object, e As EventArgs) Handles lop7.Click

        show_me_all(s2)

    End Sub

    Sub show_me_all(rd As String)
        '   Try

        play_all_program.txt_get_class.Text = rd
        Me.Enabled = False
        '  Dim knew = New find_max_id
        ' knew.txt_get_class.Text = rd
        find_max_id.Show()
        '  Me.Close()

        '   If Not ActualForm Then
        ''       formForm2 = New find_max_id
        '    End If
        '   formForm2.Show()
        '   formForm2.Activate()
        '    ActualForm = True
        ' Dim fknews = New find_max_id
        'fknews.Show()
        ' Dim f As Form = Application.OpenForms("find_max_id")
        '  If f Is Nothing Then
        '  f = New find_max_id
        '   End If
        '   f.Show()
        ' Catch
        '  MsgBox("Không tìm thấy Data của mục này!")
        '    baoloi.Show()
        '  End Try
    End Sub

    Private Sub lop7_MouseMove(sender As Object, e As MouseEventArgs) Handles lop7.MouseMove
        lop7.BackColor = Color.MediumSpringGreen
        lopk7.BackColor = lop7.BackColor
    End Sub

    Private Sub lop8_MouseMove(sender As Object, e As MouseEventArgs) Handles lop8.MouseMove
        lop8.BackColor = Color.MediumSpringGreen
        lopk8.BackColor = lop8.BackColor
    End Sub

    Private Sub lop9_MouseMove(sender As Object, e As MouseEventArgs) Handles lop9.MouseMove
        lop9.BackColor = Color.MediumSpringGreen
        lopk9.BackColor = lop9.BackColor
    End Sub

    Private Sub lop10_MouseMove(sender As Object, e As MouseEventArgs) Handles lop10.MouseMove
        lop10.BackColor = Color.MediumSpringGreen
        lopk10.BackColor = lop10.BackColor
    End Sub

    Private Sub lop11_MouseMove(sender As Object, e As MouseEventArgs) Handles lop11.MouseMove
        lop11.BackColor = Color.MediumSpringGreen
        lopk11.BackColor = lop11.BackColor
    End Sub
    Private Sub lop12_MouseMove(sender As Object, e As MouseEventArgs) Handles lop12.MouseMove
        lop12.BackColor = Color.MediumSpringGreen
        lopk12.BackColor = lop12.BackColor
    End Sub

    Private Sub canhan_Click(sender As Object, e As EventArgs) Handles canhan.Click
        '  show_me_all(s8)
        'tu tao ca nhan
        PostAction(27)
        Me.TopMost = False
        Dim proc As New System.Diagnostics.Process()

        proc = Process.Start(Application.StartupPath & "\MAKEDATA.exe", "")
        ' canhan.Enabled = False
        ' lopk_me.Enabled = False
    End Sub

    Private Sub canhan_MouseMove(sender As Object, e As MouseEventArgs) Handles canhan.MouseMove
        canhan.BackColor = Color.MediumSpringGreen
        lopk_me.BackColor = canhan.BackColor

    End Sub
    Private Sub canhan2_MouseMove(sender As Object, e As MouseEventArgs) Handles canhan2.MouseMove
        canhan2.BackColor = Color.MediumSpringGreen
        lb_nap.BackColor = canhan2.BackColor

    End Sub


    Private Sub lb_st_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_st.MouseMove
        lb_st.BackColor = Color.SlateGray
    End Sub

    Private Sub lb_st_Click(sender As Object, e As EventArgs) Handles lb_st.Click
        Me.Enabled = False
        caidat.Show()
        PostAction(3)
    End Sub

    Private Sub lopk6_Click(sender As Object, e As EventArgs) Handles lopk6.Click
        show_me_all(s1)
    End Sub

    Private Sub lopl7_Click(sender As Object, e As EventArgs) Handles lopk7.Click
        show_me_all(s2)
    End Sub

    Private Sub lop8_Click(sender As Object, e As EventArgs) Handles lop8.Click
        show_me_all(s3)
    End Sub

    Private Sub lopk8_Click(sender As Object, e As EventArgs) Handles lopk8.Click
        show_me_all(s3)
    End Sub

    Private Sub lopk9_Click(sender As Object, e As EventArgs) Handles lopk9.Click
        show_me_all(s4)
    End Sub

    Private Sub lop9_Click(sender As Object, e As EventArgs) Handles lop9.Click
        show_me_all(s4)
    End Sub

    Private Sub lopk10_Click(sender As Object, e As EventArgs) Handles lopk10.Click
        show_me_all(s5)
    End Sub

    Private Sub lop10_Click(sender As Object, e As EventArgs) Handles lop10.Click
        show_me_all(s5)
    End Sub

    Private Sub lopk11_Click(sender As Object, e As EventArgs) Handles lopk11.Click
        show_me_all(s6)
    End Sub

    Private Sub lop11_Click(sender As Object, e As EventArgs) Handles lop11.Click
        show_me_all(s6)
    End Sub

    Private Sub lopk12_Click(sender As Object, e As EventArgs) Handles lopk12.Click
        show_me_all(s7)
    End Sub

    Private Sub lop12_Click(sender As Object, e As EventArgs) Handles lop12.Click
        show_me_all(s7)
    End Sub

    Private Sub lopk_me_Click(sender As Object, e As EventArgs) Handles lopk_me.Click
        '  show_me_all(s8)
        PostAction(27)
        Me.TopMost = False
        Dim proc As New System.Diagnostics.Process()

        proc = Process.Start(Application.StartupPath & "\MAKEDATA.exe", "")
        ' lopk_me.Enabled = False
        'canhan.Enabled = False
    End Sub

    Private Sub canhan2_Click(sender As Object, e As EventArgs) Handles canhan2.Click
        load_open()
    End Sub
    Sub load_open()
        PostAction(28)
        chonpath.Close()
        Me.Enabled = False
        Dim new_conpath As New chonpath
        new_conpath.Show()
        new_conpath.TopMost = True
    End Sub
    Sub load_open2()
        Dim s As New OpenFileDialog
        s.Title = "Mở dữ liệu"
        s.FileName = "Tệp của bạn"
        s.Filter = "Tệp dữ liệu CKT|*.ckt"
        If s.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            find_max_id.pathk.Text = s.FileName
            show_me_all("tudo")
            Me.Hide()
        End If
    End Sub
    Private Sub lb_nap_Click(sender As Object, e As EventArgs) Handles lb_nap.Click
        load_open()
    End Sub

    Private Sub xyx_Click(sender As Object, e As EventArgs) Handles xyx.Click
        ngaunhienint()
    End Sub
    Sub ngaunhienint()
        Dim r As Random = New Random
lamlaine:
        Dim intk As String = r.Next(1, 7)
        If intk = My.Settings.sotam Then
            intk = r.Next(1, 7)
        End If
        Dim FILE_NAME As String = Application.StartupPath & "\Data\"
        If System.IO.File.Exists(FILE_NAME & "data" & intk & ".ckt") = True Then
            find_max_id.pathk.Text = FILE_NAME & "data" & intk & ".ckt"
            My.Settings.sotam = intk
            My.Settings.Save()
            show_me_all("tudo")
            Me.Hide()
        Else
            GoTo lamlaine
        End If
    End Sub

    Private Sub px_xx_Click(sender As Object, e As EventArgs) Handles px_xx.Click
        ngaunhienint()
    End Sub

    Private Sub theme2_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub
    Dim sever_host_up As String = "http://build.luutru360.com/up/ver.txt"
    Private Sub lb_up_Click(sender As Object, e As EventArgs) Handles lb_up.Click
        '  If homeupver = My.Settings.update Then
        If My.Computer.Network.IsAvailable Then
            '   Dim homeupver As String = New System.Net.WebClient().DownloadString(sever_host_up)
            '  If (homeupver.Length > 0) Then
            ' My.Settings.update = homeupver Then
            'MsgBox("Bạn đang dùng CSDL mới nhất " & My.Settings.update)
            'Else
            capnhat.Show()
                    Me.Close()
            '   End If
        Else
                MsgBox("Bạn đang dùng CSDL mới nhất " & My.Settings.update)
            End If
        ' End If
        PostAction(16)

        ' Else
        'MsgBox("Đã có phiên bản mới!! Phiên bản: " & My.Settings.update, vbInformation, "Thông báo")
        '  My.Settings.update = "1.0.0"
        '  My.Settings.Save()
        '  capnhat.Show()
        '  Me.Enabled = False
        '  End If
        '   MsgBox("Chức năng đang trong quá trình phát triển, vui lòng quay lại sau!", vbInformation, "Thông báo")
    End Sub

    Private Sub lb_up_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_up.MouseMove
        lb_up.BackColor = Color.DeepSkyBlue 'SteelBlue
    End Sub
End Class