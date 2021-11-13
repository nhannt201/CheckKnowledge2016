Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Word = Microsoft.Office.Interop.Word


Public Class word_file
    Private m_iMessage As Integer
    Private Shared WM_QUERYENDSESSION As Integer = &H11 'this is a logoff, shutdown, or reboot
    Private Shared WM_FORMCONTROLMENU As Integer = 16 'form closed via form control menu
    Dim cauhoi As New TextBox
    Dim xuli As New TextBox
    Dim hoitam As New TextBox
    Dim data_base As String = 0
    Dim baner As String
    Dim position As String
    Dim cauhoi_indam As String = ""
    Dim dapankk As String = ""
    Dim sotrang As String = False
    Dim randoms As New ListBox

    Dim num_tam As String
    ' Add to a subroutine 
    Dim Wd As Word.Application
    Dim doc As Word.Document
    Dim oTable As Word.Table
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        m_iMessage = m.Msg

        ' If this is WM_QUERYENDSESSION, the closing event should be fired in the base WndProc
        MyBase.WndProc(m)

    End Sub 'WndProc
    Private Sub word_file_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If m_iMessage = WM_FORMCONTROLMENU Then

            e.Cancel = True
            trinhedit.Enabled = True
            trinhedit.Show()
            Me.Hide()

        End If
    End Sub
    Private Sub word_file_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            bt_open.Enabled = False
            word_tuychon.Hide()
            richtxt.Text = richtxt.Text & "Bắt đầu xuất dữ liệu..." & vbNewLine
            ' Start Word and get Application object 
            Wd = New Word.Application

            Wd.Visible = True


            ' Add a new document 
            doc = Wd.Documents.Add
            doc.Range.Font.Name = "Arial"
            Dim tacgi As String = SplitString(trinhedit.data.Text, "<tacgia>", "</tacgia>")
            Dim ghichu As String = SplitString(trinhedit.data.Text, "<ghichu>", "</ghichu>")
            richtxt.Text = richtxt.Text & "Lấy thông tin dữ liệu..." & vbNewLine
            ''
            If sotrang = True Then
                doc.Content.Application.ActiveWindow.ActivePane.View.SeekView = CInt(Word.WdSeekView.wdSeekCurrentPageFooter)
                'Typing something in the header
                '  doc.Content.Application.Selection.TypeText(Text:="Tác giả: " & tacgi & " - " & ghichu)
                doc.Content.Application.Selection.TypeText(Text:="Trang ")
                'adding the page contents to the header

                doc.Content.Application.Selection.Fields.Add(Range:=doc.Content.Application.Selection.Range, Type:=CInt(Word.WdFieldType.wdFieldEmpty), Text:="page")
                'return to the main document        
                doc.Content.Application.ActiveWindow.ActivePane.View.SeekView = CInt(Word.WdSeekView.wdSeekMainDocument)


                'return to the main document        
                doc.Content.Application.ActiveWindow.ActivePane.View.SeekView = CInt(Word.WdSeekView.wdSeekMainDocument)
            End If
            ''
            richtxt.Text = richtxt.Text & "Cấu hình dữ liệu word..." & vbNewLine
            Wd.Selection.Font.Size = "25"
            Wd.Selection.Font.Bold = True
            doc.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            ' Wd.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            Wd.Selection.TypeText(ghichu & Chr(13))
            Wd.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            Wd.Selection.Font.Size = "11"
            Wd.Selection.Font.Bold = False
            If word_tuychon.ck_1.Checked = True Then
                Dim denhansoayma As String = word_tuychon.txt_num.Text
                If denhansoayma < 10 Then
                    denhansoayma = denhansoayma * 6
                Else
                    denhansoayma = denhansoayma * 3
                End If
                For indexx As Integer = 0 To denhansoayma
                    Dim r = New Random(Guid.NewGuid().GetHashCode())
                    Dim randomNumber = r.Next(word_tuychon.txt_num.Text)
                    '(randomNumber)
                    randoms.Items.Add(randomNumber)
                Next indexx
                Dim items(randoms.Items.Count - 1) As Object
                randoms.Items.CopyTo(items, 0)
                randoms.Items.Clear()
                randoms.Items.AddRange(items.AsEnumerable().Distinct().ToArray())

                For ikk As Integer = 0 To randoms.Items.Count - 1
                    data_base = data_base + 1
                    num_tam = 0
                    auto_send_get(randoms.Items(ikk).ToString)
                    richtxt.Text = richtxt.Text & "Xuất dữ liệu câu " & ikk + 1 & "..." & vbNewLine
                Next ikk

            Else
                'Neu check gioi han
                If word_tuychon.ck_2.Checked = True Then
                    For Index As Integer = 0 To word_tuychon.txt_num.Text - 1
                        data_base = data_base + 1
                        num_tam = 1
                        auto_send_get(Index)
                        richtxt.Text = richtxt.Text & "Xuất dữ liệu câu " & Index + 1 & "..." & vbNewLine
                    Next Index
                Else
                    For Index As Integer = 0 To trinhedit.lst_cauhoi.Items.Count - 1
                        data_base = data_base + 1
                        num_tam = 1
                        auto_send_get(Index)
                        richtxt.Text = richtxt.Text & "Xuất dữ liệu câu " & Index + 1 & "..." & vbNewLine
                    Next Index
                End If
            End If


            richtxt.Text = richtxt.Text & "Bắt đầu in đáp án..." & vbNewLine
            xuatword("Đáp án trắc nghiệm:")
            xuatword(dapankk)
            richtxt.Text = richtxt.Text & "Xuất dữ liệu Word hoàn tất!"
            ''
            'Insert a 3 x 5 table, fill it with data, and make the first row
            'bold and italic.
            ' Dim r As Integer, c As Integer
            '  oTable = doc.Tables.Add(doc.Bookmarks.Item("\endofdoc").Range, 3, 5)
            '  oTable.Range.ParagraphFormat.SpaceAfter = 6
            '  For r = 1 To 3
            '  For c = 1 To 5
            '  oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            '  Next
            '  Next
            ' oTable.Rows.Item(1).Range.Font.Bold = True
            ' oTable.Rows.Item(1).Range.Font.Italic = True
            ''
            ' Wd.Selection.TypeText(dapankk)

            ' Save 
            '  If IsWordRunning() = False Then
            If trinhedit.xam_note.Text = "1" Then

            Else
                Try
                    doc.SaveAs(Application.StartupPath & "\Result\luutam.docx")
                Catch ex As Exception
                    MsgBox("Không thể lưu bản Word tạm thời!!")
                End Try
            End If
            bt_open.Enabled = True


            '  Else

            '  End If


            ' Close 
            '  doc.Close()
            '  doc = Nothing
            '  Wd.Quit()

            ' Clean up 
            ' NOTE: When in release mode, this does the trick 
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            trinhedit.Enabled = True
            '   trinhedit.Show()
            Me.Close()
        Catch
            MsgBox("Có lỗi xảy ra: " & vbNewLine & "- Dường như bạn đang xuất bản cùng lúc nhiều bản WORD." & vbNewLine & "- Dường như máy bạn không cài Microsoft Office được hỗ trợ để xuất bản word.")
        End Try
    End Sub


    Sub auto_send_get(num As String)
        Dim conso As String = num
        '   Dim conso As String = Int((conso2 * Rnd()))
        Dim lst1 As String = SplitString(trinhedit.data.Text, "<" + conso + ">", "</" + conso + ">")

        Dim lst3 As String = SplitString(lst1, "<cauhoi>", "</cauhoi>")
        '  richtxt.Text = richtxt.Text & lst3 & vbNewLine

        ' richtxt.Text = richtxt.Text & "Câu " & num + 1 & ": " & lst3 & vbNewLine
        If num_tam = 0 Then
            cauhoi_indam = "Câu " & data_base & ": " & lst3
        Else
            cauhoi_indam = "Câu " & num + 1 & ": " & lst3
        End If

        xuatword(cauhoi_indam)
        Dim lst2 As String = SplitString(lst1, "<ketqua>", "</ketqua>")
        If lst2.Length = 1 Then
            If num_tam = 0 Then
                dapankk = dapankk & data_base & lst2 & " "
            Else
                dapankk = dapankk & num + 1 & lst2 & " "
            End If

            'Else
            ' dapankk = dapankk & num + 1 & vbNewLine & lst2 & vbNewLine
        End If

        cauhoi.Text = lst1

        If cauhoi.Text.Contains("<type>trn_abc</type>") Then

            If cauhoi.Text.Contains("<select4>") Then
                laydapan("select1")
                laydapan("select2")
                laydapan("select3")
                laydapan("select4")
                'richtxt.Text = richtxt.Text ' & vbNewLine
            ElseIf cauhoi.Text.Contains("<select3>") Then
                laydapan("select1")
                laydapan("select2")
                laydapan("select3")
                'richtxt.Text = richtxt.Text ' & vbNewLine
            ElseIf cauhoi.Text.Contains("<select2>") Then
                laydapan("select1")
                laydapan("select2")
                ' richtxt.Text = richtxt.Text & vbNewLine
            End If


            ' resetAllControls(Me)
        Else

            If lst2.Length = 1 Then
            Else
                '   richtxt.Text = richtxt.Text & lst2 ' & vbNewLine
                Wd.Selection.TypeText(lst2 & Chr(13))
            End If
            ' resetAllControls(play_all_program)
        End If
        '  resetAllControls(play_all_program)
        ' autonext()
        ' MsgBox(play_all_program.dapanchuan.Text)
        '    play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "<ketqua>", "")
        '  play_all_program.dapanchuan.Text = Replace(play_all_program.dapanchuan.Text, "</ketqua>", "")
    End Sub

    Sub laydapan(oks As String)

        Dim kqquatra As String = SplitString(cauhoi.Text, "<" & oks & ">", "</" & oks & ">")
        ' If kqquatra.Success Then
        If oks = "select4" Then
            '    Wd.Selection.Font.Bold = True
            Wd.Selection.TypeText("D.")
            '  Wd.Selection.Font.Bold = False
            Wd.Selection.TypeText(kqquatra & Chr(13))
            ' dpd.Visible = True
        ElseIf oks = "select3" Then
            '  Wd.Selection.Font.Bold = True
            Wd.Selection.TypeText("C.")
            ' Wd.Selection.Font.Bold = False
            Wd.Selection.TypeText(kqquatra & Chr(13))
            '  dpc.Visible = True
        ElseIf oks = "select2" Then
            'Wd.Selection.Font.Bold = True
            Wd.Selection.TypeText("B.")
            ' Wd.Selection.Font.Bold = False
            Wd.Selection.TypeText(kqquatra & Chr(13))
            ' dpb.Visible = True
        ElseIf oks = "select1" Then
            '   Wd.Selection.Font.Bold = True
            Wd.Selection.TypeText("A.")
            '  Wd.Selection.Font.Bold = False
            Wd.Selection.TypeText(kqquatra & Chr(13))
            ' dpa.Visible = True
        End If
    End Sub

    Sub xuatword(indam As String)

        ' Write some text 
        ' Wd.Selection.TypeText(richtxt.Text)
        'doc.Range.Font.Bold = True
        Wd.Selection.Font.Bold = True
        Wd.Selection.TypeText(indam & Chr(13))
        Wd.Selection.Font.Bold = False
        ' doc.Range.Font.Bold = False
        ' Wd.Selection.TypeText("ghfhfh")
        ' Bold the specified word 



    End Sub

    Private Sub bt_open_Click(sender As Object, e As EventArgs) Handles bt_open.Click
        Process.Start(Application.StartupPath & "\Result")

    End Sub
End Class