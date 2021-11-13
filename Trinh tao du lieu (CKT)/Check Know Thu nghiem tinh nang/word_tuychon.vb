
Imports System.ComponentModel

Public Class word_tuychon
    Private m_iMessage As Integer
    Private Shared WM_QUERYENDSESSION As Integer = &H11 'this is a logoff, shutdown, or reboot
    Private Shared WM_FORMCONTROLMENU As Integer = 16 'form closed via form control menu
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        m_iMessage = m.Msg

        ' If this is WM_QUERYENDSESSION, the closing event should be fired in the base WndProc
        MyBase.WndProc(m)

    End Sub 'WndProc

    Private Sub word_tuychon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub word_tuychon_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If m_iMessage = WM_FORMCONTROLMENU Then
            trinhedit.Enabled = True
            trinhedit.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ck_2_CheckedChanged(sender As Object, e As EventArgs) Handles ck_2.CheckedChanged
        If ck_2.Checked = True Then
            txt_num.Enabled = True
        Else
            txt_num.Enabled = False
        End If
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        trinhedit.Hide()
        Dim taowordmoi As New word_file
        taowordmoi.Show()
        Me.Hide()
    End Sub

    Private Sub txt_num_TextChanged(sender As Object, e As EventArgs) Handles txt_num.TextChanged
        Dim getnum As String = trinhedit.lst_cauhoi.Items.Count
        If txt_num.Text.Length > getnum.Length Then
            txt_num.Text = trinhedit.lst_cauhoi.Items.Count
        End If
        If txt_num.Text.Length = 0 Then
            txt_num.Text = 1
        End If
        If txt_num.Text > trinhedit.lst_cauhoi.Items.Count Then
            txt_num.Text = trinhedit.lst_cauhoi.Items.Count
        End If
        txt_num.Text = CInt(txt_num.Text).ToString
        txt_num.Text.Trim()
    End Sub

    Function TrapKey(ByVal KCode As Integer) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Sub txt_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub
End Class