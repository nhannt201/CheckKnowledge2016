'Code by Nguyen trung nhan
Imports System.Runtime.InteropServices

Module Endechung
    Public Function encode(data As String) As String
        data = data.Replace("<", "A1A5").Replace(">", "_2_7").Replace("tacgia", "_01rtfg_-_dg.__d-gdg").Replace("about", "_..rt)(dfdf)_----")
        data = data.Replace("â", "_x50_").Replace("ă", "_x22_").Replace("ấ", "_x25_").Replace("ằ", "_x29_").Replace("á", "_x23_").Replace("à", "_x211_").Replace("ạ", "_x2._").Replace("ô", "_121_aaass_").Replace("ậ", "5912556.8").Replace("ự", "_89123245_").Replace("ử", "_113114115_").Replace("ê", "_YYYXXX__").Replace("ớ", "_986_1532_2019_")
        data = data.Replace("pass", "_x2905_").Replace("ketqua", "_pass_15x_091_").Replace("select", "_0x001520_").Replace("cauhoi", "_anti_vs_xem_")
        data = data.Replace("nh", "_<3_").Replace("qu", "_<2_").Replace("th", "_<o_").Replace("kh", "_<i_").Replace("ngh", "_<p_").Replace("ch", "_<s_").Replace("tr", "_<u_")
        Return data
    End Function
    Public Function decode(data As String) As String
        data = data.Replace("A1A5", "<").Replace("_2_7", ">").Replace("_01rtfg_-_dg.__d-gdg", "tacgia").Replace("_..rt)(dfdf)_----", "about")
        data = data.Replace("_x50_", "â").Replace("_x22_", "ă").Replace("_x25_", "ấ").Replace("_x29_", "ằ").Replace("_x23_", "á").Replace("_x211_", "à").Replace("_x2._", "ạ").Replace("_121_aaass_", "ô").Replace("5912556.8", "ậ").Replace("_89123245_", "ự").Replace("_113114115_", "ử").Replace("_YYYXXX__", "ê").Replace("_986_1532_2019_", "ớ")
        data = data.Replace("_x2905_", "pass").Replace("_pass_15x_091_", "ketqua").Replace("_0x001520_", "select").Replace("_anti_vs_xem_", "cauhoi")
        data = data.Replace("_<3_", "nh").Replace("_<2_", "qu").Replace("_<o_", "th").Replace("_<i_", "kh").Replace("_<p_", "ngh").Replace("_<s_", "ch").Replace("_<u_", "tr")
        Return data
    End Function
    Public Function enccode(ByVal inString As String) As String
        Dim enc As New System.Text.UnicodeEncoding
        Dim buffer As Byte() = enc.GetBytes(inString)
        enccode = Convert.ToBase64String(buffer)

    End Function

    Public Function deccode(ByVal inString As String) As String
        Dim enc As New System.Text.UnicodeEncoding
        Dim buffer As Byte() = Convert.FromBase64String(inString)
        deccode = enc.GetString(buffer)
    End Function


    Public Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function
    Public Function SplitString(ByVal mainString As String, ByVal BeginString As String, ByVal EndString As String) As String
        Dim i_s As Integer : i_s = InStr(mainString, BeginString)
        Dim i_e As Integer : i_e = InStr(mainString, EndString)
        On Error Resume Next
        If i_s <> -1 And i_e <> -1 Then
            Dim s As String

            s = Mid(mainString, i_s + Len(BeginString), i_e - i_s - Len(BeginString))
            SplitString = s
            If s.Length = 0 Then
                SplitString = "(Không rõ)"
            End If

        Else
            SplitString = "(Không rõ)"
        End If
    End Function

    Public Function IsWordRunning() As Boolean
        Dim wordObj As Object = Marshal.GetActiveObject("Word.Application")
        Return Not wordObj Is Nothing
    End Function
End Module
