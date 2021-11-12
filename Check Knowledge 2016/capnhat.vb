Imports System
Imports System.Net
Imports System.IO
Public Class capnhat
    Dim serverhost_dw As String = "http://build.luutru360.com/up/"
    Dim numk As String = 0
    Dim list_upfile() As String = {"data1.ckt", "data2.ckt", "data3.ckt", "data4.ckt", "data5.ckt", "data6.ckt", "data7.ckt"}

    Private Sub upda_Tick(sender As Object, e As EventArgs) Handles upda.Tick
        If numk = 0 Then
            lb_up.Text = "Đang kiểm tra phiên bản cập nhật..."
            numk = 1
        ElseIf numk = 1 Then
            updatee()
            upda.Stop()
        End If

    End Sub

    Private Sub capnhat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub updatee()
        Try
            Dim homeupver As String = New System.Net.WebClient().DownloadString("http://build.luutru360.com/up/ver.txt")
            Dim home_client As String = New System.Net.WebClient().DownloadString("http://build.luutru360.com/up/ver2.txt")
            Dim home_client_url As String = New System.Net.WebClient().DownloadString("http://build.luutru360.com/up/urlup.txt")
            If My.Settings.client_ver = home_client Then
                If My.Settings.update = homeupver Then
                    upda.Stop()
                    MsgBox("Bạn đang dùng CSDL mới nhất " & My.Settings.update)
                    Dim load_all As New load1
                    load_all.Show()
                    Me.Close()
                Else
                    lb_up.Text = "Tiến hành xóa dữ liệu cũ..."
                    For Each file_name As String In list_upfile
                        Try
                            If System.IO.File.Exists(Application.StartupPath & "\Data\" & file_name) = True Then
                                System.IO.File.Delete(Application.StartupPath & "\Data\" & file_name)
                            End If
                        Catch

                        End Try
                    Next

                    lb_up.Text = "Đang cập nhật dữ liệu mới..."
                    For Each file_name As String In list_upfile
                        ' My.Computer.Network.DownloadFile(serverhost_dw & file_name, Application.StartupPath & "\Data\" & file_name)
                        Dim client As WebClient = New WebClient
                        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
                        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
                        client.DownloadFileAsync(New Uri(serverhost_dw & "/" & file_name), Application.StartupPath & "\Data\" & file_name)
                    Next
                    My.Settings.update = homeupver
                    My.Settings.Save()
                    upda.Stop()
                    MsgBox("Đã cập nhật phiên bản dữ liệu mới!!")
                    caidat.lb_csdl.Text = "Phiên bản CSDL: " & My.Settings.update
                    Dim load_all As New load1
                    load_all.Show()
                    Me.Close()
                End If

            Else
                upda.Stop()
                MsgBox("Đã có phiên bản Client mới, Client sẽ mở URL sau để  bạn cập nhật.")
                Process.Start(home_client_url)
                End
            End If
        Catch
            upda.Stop()
            MsgBox("Có lỗi xảy ra với máy chủ, không thể kiểm tra cập nhật!" & vbNewLine & "Vui lòng thử lại sao.")
            Dim load_all As New load1
            load_all.Show()
            Me.Close()
        End Try

    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        prb.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        '  MessageBox.Show("Download Complete")
        prb.Value = 0
        '   btnStartDownload.Text = "Start Download"
        '  btnStartDownload.Enabled = True
    End Sub

End Class