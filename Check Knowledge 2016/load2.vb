Imports System
Imports System.IO
Public Class load2

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox3.Width = PictureBox3.Width + 10
        If PictureBox3.Width >= 350 Then

            theme2.Show()

            Me.Hide()
            Timer1.Stop()
        End If

    End Sub

    Private Sub load2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        PictureBox3.Width = 0
        theme2.Close()
        thongke.Close()
        play_all_program.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '  Try
        ' sau nay kiem het data
        'kiem tra file dau tien
        Dim FILE_NAME As String = Application.StartupPath & "\Data\"

        Dim TextLine As String

        If System.IO.File.Exists(FILE_NAME & "data1.txt") = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME & "data1.txt")
            Do While objReader.Peek() <> -1
                TextLine = TextLine & objReader.ReadLine() & vbNewLine
            Loop
            play_all_program.hoi.Text = TextLine
            Timer1.Start()
            Timer2.Stop()
        Else
            baoloi.lb_ror.Visible = False
            baoloi.lb_er.Text = ("Không tìm thấy Data1.txt!")
            baoloi.lb_er.Visible = True
            baoloi.Show()
            Timer1.Stop()
            Timer2.Stop()
        End If
        'kiem tra thu muc Data
        If System.IO.Directory.Exists(Application.StartupPath & "\Data\") Then
            '  System.IO.Directory.CreateDirectory(YourPath) 'tao thuc muc moi
        Else
            baoloi.lb_ror.Visible = False
            baoloi.lb_er.Text = ("Không tìm thấy thư mục Data")
            baoloi.lb_er.Visible = True
            baoloi.Show()
            Timer1.Stop()
            Timer2.Stop()
        End If
        'kiem tra thu muc Sound
        '  If (Not System.IO.Directory.Exists(Application.StartupPath & "\Sound\")) Then
        If System.IO.Directory.Exists(Application.StartupPath & "\Sound\") Then
            '  System.IO.Directory.CreateDirectory(YourPath) 'tao thuc muc moi
        Else
            baoloi.lb_ror.Visible = False
            baoloi.lb_er.Text = ("Không tìm thấy thư mục Sound")
            baoloi.lb_er.Visible = True
            baoloi.Show()
            Timer1.Stop()
            Timer2.Stop()
        End If
        'kiem tra file folder sound
        If System.IO.File.Exists(Application.StartupPath & "\Sound\sound_bg.wav") Then
            '  System.IO.Directory.CreateDirectory(YourPath) 'tao thuc muc moi
        Else
            baoloi.lb_ror.Visible = False
            baoloi.lb_er.Text = ("Không tìm thấy thư mục tập tin 'sound_bg.waw'")
            baoloi.lb_er.Visible = True
            baoloi.Show()
            Timer1.Stop()
            Timer2.Stop()
        End If
        'khu kiem tra data 1 -> 8
        If System.IO.File.Exists(FILE_NAME & "data2.txt") Then

        Else
            theme2.lop7.Enabled = False
            theme2.lopk7.Enabled = False
        End If

        If System.IO.File.Exists(FILE_NAME & "data3.txt") Then

        Else
            theme2.lop8.Enabled = False
            theme2.lopk8.Enabled = False
        End If
        If System.IO.File.Exists(FILE_NAME & "data4.txt") Then
        Else
            theme2.lop9.Enabled = False
            theme2.lopk9.Enabled = False
        End If
        If System.IO.File.Exists(FILE_NAME & "data5.txt") Then
        Else
            theme2.lop10.Enabled = False
            theme2.lopk10.Enabled = False
        End If
        If System.IO.File.Exists(FILE_NAME & "data6.txt") Then
        Else
            theme2.lop11.Enabled = False
            theme2.lopk11.Enabled = False
        End If
        If System.IO.File.Exists(FILE_NAME & "data7.txt") Then
        Else
            theme2.lop12.Enabled = False
            theme2.lopk12.Enabled = False
        End If
        If System.IO.File.Exists(Application.StartupPath & "\MAKEDATA.exe") Then
        Else
            theme2.canhan.Enabled = False
            theme2.lopk_me.Enabled = False
        End If
        'If System.IO.File.Exists(FILE_NAME & "data8.txt") Then

        ' Else
        'theme2.canhan.Enabled = False
        'theme2.lopk_me.Enabled = False
        '  End If
        'Kiem tra cai dat
        If My.Settings.st1 = "turn_on" Then
            caidat.ck_1.Checked = True
            play_all_program.txt_auto_next.Text = "yes"
        Else
            My.Settings.st1 = "turn_off"
            My.Settings.Save()
        End If
        If My.Settings.st2 = "turn_on" Then
            caidat.ck_2.Checked = True
        Else
            My.Settings.st2 = "turn_off"
            My.Settings.Save()
        End If
        If My.Settings.st3 = "turn_on" Then
            caidat.ck_3.Checked = True
        Else
            My.Settings.st3 = "turn_off"
            My.Settings.Save()
        End If
        If My.Settings.st4 = "turn_on" Then
            caidat.ck_4.Checked = True
        Else
            My.Settings.st4 = "turn_off"
            My.Settings.Save()
        End If
        '  Catch
        ' End
        '     baoloi.Show()
        ' End Try
    End Sub


End Class