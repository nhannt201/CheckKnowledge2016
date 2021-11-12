Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class find_max_id
    '   Inherits System.Windows.Forms.Form
    Dim data_base As String = 0
    Dim baner As String
    Dim position As String
    Dim s1 As String = "data1"
    Dim s2 As String = "data2"
    Dim s3 As String = "data3"
    Dim s4 As String = "data4"
    Dim s5 As String = "data5"
    Dim s6 As String = "data6"
    Dim s7 As String = "data7"
    Dim sX As String = "tudo"

    Private Sub tm1_Tick(sender As Object, e As EventArgs) Handles tm1.Tick
        Try
            data_base = data_base + 1
            ' If InStr(1, baner, "<" + data_base + ">") = 0 Then
            'InStr( 1, baner, "<" & data_base & ">" )


            '  End If
            position = InStr(1, baner, "<" + data_base + ">")
            If position = 0 Then
                auto_send_get()
                play_all_program.get_id_max.Text = data_base

                play_all_program.Show()
                theme2.Enabled = True
                theme2.Hide()
                theme2.Close()
                '  theme2.ActualForm = False
                Me.Hide()
                tm1.Stop()

                Close()



            End If

        Catch
            '  Me.Close()

            baoloi.Show()
            tm1.Stop()

        End Try
    End Sub
    ' get2 moi chinh hang cai nay test
    Sub auto_send_get()
        Dim conso2 As String = Int((data_base * Rnd()))
        Dim conso As String = Int((conso2 * Rnd()))
        Dim lst1 As String = SplitString(play_all_program.hoi.Text, "<" + conso + ">", "</" + conso + ">")
        ' play_all_program.cauhoi.Text = ""
        play_all_program.sostt2.Text = conso
        play_all_program.cauhoi.Text = lst1
        play_all_program.xuli.Text = play_all_program.cauhoi.Text
        Dim lst2 As String = SplitString(lst1, "<ketqua>", "</ketqua>")
        ' play_all_program.dapanchuan.Text = ""
        play_all_program.traloi.Text = ""
        play_all_program.dapanchuan.Text = lst2
        play_all_program.dapannguyen.Text = lst2
        'Bo sung dap ans ang form chinh de hien dap an
        If lst2 = "A" Then
            play_all_program.dapan_khisai.Text = SplitString(lst1, "<select1>", "</select1>")
        ElseIf lst2 = "B" Then
            play_all_program.dapan_khisai.Text = SplitString(lst1, "<select2>", "</select2>")
        ElseIf lst2 = "C" Then
            play_all_program.dapan_khisai.Text = SplitString(lst1, "<select3>", "</select3>")
        ElseIf lst2 = "D" Then
            play_all_program.dapan_khisai.Text = SplitString(lst1, "<select4>", "</select4>")
        End If
        Dim lst3 As String = SplitString(lst1, "<cauhoi>", "</cauhoi>")
        '  play_all_program.dapanchuan.Text = ""
        play_all_program.traloi.Text = ""
        ' play_all_program.cauhoi.Text = ""
        play_all_program.cauhoi.Text = lst3
        'phan kiem tra trac nghiem
        If play_all_program.xuli.Text.Contains("<type>trn_abc</type>") Then
            play_all_program.luachonkq.Visible = True
            play_all_program.traloi.Enabled = False
            laydapan("select1")
            laydapan("select2")
            laydapan("select3")
            laydapan("select4")

        Else
            play_all_program.luachonkq.Visible = False
            play_all_program.traloi.Enabled = True
        End If
        ' MsgBox(play_all_program.dapanchuan.Text)
        '    play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "<ketqua>", "")
        '  play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "</ketqua>", "")
    End Sub

    Sub auto_send_get2()
        Dim conso2 As String = Int((data_base * Rnd()))
        Dim conso As String = Int((conso2 * Rnd()))
        '  show_score.txt_tam.Text = conso
        'lay cau hoi
        Dim lst1, lst2 As New List(Of Integer)
        lst1 = FindStringLoc(play_all_program.hoi.Text, "<" + conso + ">")
        lst2 = FindStringLoc(play_all_program.hoi.Text, "</" + conso + ">")
        play_all_program.cauhoi.Text = ""
        play_all_program.sostt2.Text = conso
        For i As Integer = 0 To lst1.Count - 1
            If i + 1 <= lst1.Count - 1 Then
                play_all_program.cauhoi.Text &= play_all_program.hoi.Text.Substring(lst1(i) + 0, lst2(i) - lst1(i) - 0) & vbNewLine
            Else
                play_all_program.cauhoi.Text &= play_all_program.hoi.Text.Substring(lst1(i) + 0, lst2(i) - lst1(i) - 0)
            End If
        Next
        play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "<" + conso + ">", "")
        play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "</" + conso + ">", "")
        ' play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "<cauhoi>", "")
        ' play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "</cauhoi>", "")
        play_all_program.xuli.Text = play_all_program.cauhoi.Text
        'lay ket qua
        Dim lst3, lst4 As New List(Of Integer)
        lst3 = FindStringLoc(play_all_program.cauhoi.Text, "<ketqua>")
        lst4 = FindStringLoc(play_all_program.cauhoi.Text, "</ketqua>")
        play_all_program.dapanchuan.Text = ""
        play_all_program.traloi.Text = ""
        For i As Integer = 0 To lst3.Count - 1
            If i + 1 <= lst3.Count - 1 Then
                play_all_program.dapanchuan.Text &= play_all_program.cauhoi.Text.Substring(lst3(i) + 0, lst4(i) - lst3(i) - 0) & vbNewLine
            Else
                play_all_program.dapanchuan.Text &= play_all_program.cauhoi.Text.Substring(lst3(i) + 0, lst4(i) - lst3(i) - 0)
            End If
        Next
        'lay cau hoi trong
        Dim lst5, lst6 As New List(Of Integer)
        lst5 = FindStringLoc(play_all_program.xuli.Text, "<cauhoi>")
        lst6 = FindStringLoc(play_all_program.xuli.Text, "</cauhoi>")
        play_all_program.cauhoi.Text = ""
        For i As Integer = 0 To lst3.Count - 1
            If i + 1 <= lst3.Count - 1 Then
                play_all_program.cauhoi.Text &= play_all_program.xuli.Text.Substring(lst5(i) + 0, lst6(i) - lst5(i) - 0) & vbNewLine
            Else
                play_all_program.cauhoi.Text &= play_all_program.xuli.Text.Substring(lst5(i) + 0, lst6(i) - lst5(i) - 0)
            End If
        Next
        play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "<cauhoi>", "")
        play_all_program.cauhoi.Text = Replace(play_all_program.cauhoi.Text, "</cauhoi>", "")
        'phan kiem tra trac nghiem
        If play_all_program.xuli.Text.Contains("<type>trn_abc</type>") Then
            play_all_program.luachonkq.Visible = True
            play_all_program.traloi.Enabled = False
            laydapan("select1")
            laydapan("select2")
            laydapan("select3")
            laydapan("select4")

        Else
            play_all_program.luachonkq.Visible = False
            play_all_program.traloi.Enabled = True
        End If
        play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "<ketqua>", "")
        play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "</ketqua>", "")

    End Sub
    Sub laydapan(oks As String)
        Dim kqquatra As Match = Regex.Match(play_all_program.xuli.Text, "<" & oks & ">(.*?)</" & oks & "\>")
        If kqquatra.Success Then
            If oks = "select4" Then
                play_all_program.cauhoi.Text = play_all_program.cauhoi.Text & vbNewLine & "D." & (kqquatra.Groups(1).Value)
                play_all_program.dpd.Visible = True

            ElseIf oks = "select3" Then
                play_all_program.cauhoi.Text = play_all_program.cauhoi.Text & vbNewLine & "C." & (kqquatra.Groups(1).Value)
                play_all_program.dpc.Visible = True

            ElseIf oks = "select2" Then
                play_all_program.cauhoi.Text = play_all_program.cauhoi.Text & vbNewLine & "B." & (kqquatra.Groups(1).Value)
                play_all_program.dpc.Visible = True

            ElseIf oks = "select1" Then
                play_all_program.cauhoi.Text = play_all_program.cauhoi.Text & vbNewLine & "A." & (kqquatra.Groups(1).Value)
                play_all_program.dpc.Visible = True

            End If
        Else
            If oks = "select4" Then
                play_all_program.dpd.Visible = False
            ElseIf oks = "select3" Then
                play_all_program.dpc.Visible = False
            ElseIf oks = "select2" Then
                play_all_program.dpc.Visible = False
            ElseIf oks = "select1" Then
                play_all_program.dpc.Visible = False
            End If
        End If
    End Sub
    Private Sub find_max_id_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Try
        play_all_program.lb_kienthuc.Text = "Check Knowledge - Kiểm tra kiến thức - "
        If play_all_program.txt_get_class.Text = s1 Then
            Dim FILE_NAME As String = Application.StartupPath & "\Data\" & s1 & ".ckt"
            load_data(FILE_NAME)
            PostAction(17)
        ElseIf play_all_program.txt_get_class.Text = s2 Then
            Dim FILE_NAME As String = Application.StartupPath & "\Data\" & s2 & ".ckt"
            load_data(FILE_NAME)
            PostAction(18)
        ElseIf play_all_program.txt_get_class.Text = s3 Then
            Dim FILE_NAME As String = Application.StartupPath & "\Data\" & s3 & ".ckt"
            load_data(FILE_NAME)
            PostAction(19)
        ElseIf play_all_program.txt_get_class.Text = s4 Then
            Dim FILE_NAME As String = Application.StartupPath & "\Data\" & s4 & ".ckt"
            load_data(FILE_NAME)
            PostAction(20)
        ElseIf play_all_program.txt_get_class.Text = s5 Then
            Dim FILE_NAME As String = Application.StartupPath & "\Data\" & s5 & ".ckt"
            load_data(FILE_NAME)
            PostAction(21)
        ElseIf play_all_program.txt_get_class.Text = s6 Then
            Dim FILE_NAME As String = Application.StartupPath & "\Data\" & s6 & ".ckt"
            load_data(FILE_NAME)
            PostAction(22)
        ElseIf play_all_program.txt_get_class.Text = s7 Then
            Dim FILE_NAME As String = Application.StartupPath & "\Data\" & s7 & ".ckt"
            load_data(FILE_NAME)
            PostAction(23)
        ElseIf play_all_program.txt_get_class.Text = sX Then
            '  Dim FILE_NAME As String = pathk.Text
            play_all_program.lb_kienthuc.Text = "Check Knowledge - Kiểm tra kiến thức - Ngẫu nhiên && Tự chọn"
            play_all_program.lv_class.Text = ""
            PostAction(24)
            ' play_all_program.daymanhinh.Interval = 3000
            load_data(pathk.Text)

        Else
            'Khong tim thay file yeu cau nen chon file mac dinh
            Dim FILE_NAME As String = Application.StartupPath & "\Data\data1.ckt"
            load_data(FILE_NAME)
                '   MsgBox(play_all_program.play_all_program.txt_get_class.Text)
            End If


            '  Catch
        '       baoloi.Show()
        '  End Try
    End Sub
    Sub load_data(s As String)
        tm1.Start()
        Dim TextLine As String

        If System.IO.File.Exists(s) = True Then

            Dim objReader As New System.IO.StreamReader(s)


            Do While objReader.Peek() <> -1

                TextLine = TextLine & objReader.ReadLine() & vbNewLine

            Loop

            play_all_program.hoi.Text = decode(TextLine)
            baner = decode(TextLine)
            play_all_program.cauhoi.Text = TextLine
            ' Me.Hide()
        Else

            'MessageBox.Show("Không tìm thấy Data!")

            baoloi.Show()
        End If
    End Sub
    Function FindStringLoc(rootstring As String, s As String) As List(Of Integer)
        Dim lst As New List(Of Integer)
        For i As Integer = 0 To rootstring.Length - s.Length
            If rootstring.Substring(i, s.Length).ToLower = s.ToLower Then
                lst.Add(i)
            End If
        Next
        Return lst
    End Function
    Private Function giongnhau(ByVal xau1$, ByVal xau2$) As String
        Dim x1() As String = xau1.Split(" ")
        Dim x2() As String = xau2.Split(" ")
        Dim x$ = ""
        Dim i% = -1
        Dim j As Integer
        Do : i = i + 1
            For j = 0 To UBound(x1)
                If x2(i) = x1(j) Then
                    x = x & x2(i) & " "
                    x1(j) = ""
                End If
            Next
        Loop Until i = UBound(x2)
        Dim t() As String = x.Trim.Split(" ")
        'giongnhau = "Các từ của xâu 1 (" & xau1 & ") có trong xâu 2 (" & xau2 & ") là '" & x.Trim() & Chr(10) & "Như vậy xâu 1 giống xâu 2 là " & ((UBound(t) + 1) / (UBound(x2) + 1)) * 100 & "%."
        giongnhau = ((UBound(t) + 1) / (UBound(x2) + 1)) * 100

    End Function
    Private Function decode(data As String) As String
        data = data.Replace("A1A5", "<").Replace("_2_7", ">").Replace("_01rtfg_-_dg.__d-gdg", "tacgia").Replace("_..rt)(dfdf)_----", "about")
        data = data.Replace("_x50_", "â").Replace("_x22_", "ă").Replace("_x25_", "ấ").Replace("_x29_", "ằ").Replace("_x23_", "á").Replace("_x211_", "à").Replace("_x2._", "ạ").Replace("_121_aaass_", "ô").Replace("5912556.8", "ậ").Replace("_89123245_", "ự").Replace("_113114115_", "ử").Replace("_YYYXXX__", "ê").Replace("_986_1532_2019_", "ớ")
        data = data.Replace("_x2905_", "pass").Replace("_pass_15x_091_", "ketqua").Replace("_0x001520_", "select").Replace("_anti_vs_xem_", "cauhoi")
        data = data.Replace("_<3_", "nh").Replace("_<2_", "qu").Replace("_<o_", "th").Replace("_<i_", "kh").Replace("_<p_", "ngh").Replace("_<s_", "ch").Replace("_<u_", "tr")
        Return data
    End Function
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

    Private Sub find_max_id_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)

    End Sub
End Class