Public Class test_beta

    Dim newImage As Image = Nothing

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Set the filter to only open text files or image files
        OpenFileDialog1.Filter = "Text File|*.txt|Images Jpg, Bmp, Png|*.jpg;*.bmp;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim file As String = OpenFileDialog1.FileName
            If file.EndsWith(".txt") Then
                word.Lines = System.IO.File.ReadAllLines(file)
                newImage = Nothing 'just in case (newimage) has been set already you will want to reset (newimage)
            Else word.Text = ""
                newImage = Image.FromFile(OpenFileDialog1.FileName)
            End If

        End If
    End Sub

    Private Sub test_beta_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Only draw the image if (newimage) is not Nothing
        If Not newImage Is Nothing Then
            Dim g As Graphics = Graphics.FromHwnd(word.Handle)
            g.DrawImage(newImage, word.ClientRectangle)
            g.Dispose()
        End If
    End Sub

    Private Sub test_beta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class