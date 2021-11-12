Imports System.Text.RegularExpressions

Module ThugonALL
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
                play_all_program.dpb.Visible = True
            ElseIf oks = "select1" Then
                play_all_program.cauhoi.Text = play_all_program.cauhoi.Text & vbNewLine & "A." & (kqquatra.Groups(1).Value)
                play_all_program.dpa.Visible = True
            End If
        Else
            If oks = "select4" Then
                play_all_program.dpd.Visible = False
            ElseIf oks = "select3" Then
                play_all_program.dpc.Visible = False
            ElseIf oks = "select2" Then
                play_all_program.dpb.Visible = False
            ElseIf oks = "select1" Then
                play_all_program.dpa.Visible = False
            End If
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

    Friend ReadOnly Property Settings() As Global.Check_Knowledge.My.MySettings
        Get
            Return Global.Check_Knowledge.My.MySettings.Default
        End Get
    End Property
End Module
