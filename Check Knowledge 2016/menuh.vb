Public Class menuh
    'Dim LastSize As Size

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' LastSize = Me.Size

        'Me.MinimumSize = Me.Size
        TransparencyKey = BackColor


        ' PictureBox5.
    End Sub
   
   
    


    Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

        'This will comapre the width and the height of the last size

        'and the current size and loop through all of the controls

        'so that each control will grow or shrink at the same rate

        'as the form

        ' If Me.Width > LastSize.Width Then

        '  For Each Ctrl As Control In Me.Controls

        'Ctrl.Width += (Me.Width - LastSize.Width)

        '  Next

        ' End If

        '  If Me.Width < LastSize.Width Then

        '  For Each Ctrl As Control In Me.Controls

        '  Ctrl.Width -= (LastSize.Width - Me.Width)

        '  Next

        'End If

        ' If Me.Height > LastSize.Height Then
        '
        ' For Each Ctrl As Control In Me.Controls

        'Ctrl.Height += (Me.Height - LastSize.Height)

        ' Next

        '  End If

        ' If Me.Height < LastSize.Height Then

        ' For Each Ctrl As Control In Me.Controls
        '
        '  Ctrl.Height -= (LastSize.Height - Me.Height)

        ' Next
        ' End If

        ' LastSize = Me.Size

        ' Dim kichthuoctudong As String = Me.Size.Width & " " & gb1.Width & " " & Me.Size.Height & " " & gb1.Height
        ' Dim kichthuoctudong2 As String = Me.Size.Width & " " & gb2.Width & " " & Me.Size.Height & " " & gb2.Height

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        End
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Dim IsMouseDown = False
    Dim startPoint
    Private Sub TitleBar_MouseUp_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitleBar.MouseUp
        IsMouseDown = False
    End Sub
    Private Sub TitleBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitleBar.MouseDown
        startPoint = e.Location
        IsMouseDown = True
    End Sub
    Private Sub TitleBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitleBar.MouseMove
        If IsMouseDown Then
            Dim p1 = New Point(e.X, e.Y)
            Dim p2 = PointToScreen(p1)
            Dim p3 = New Point(p2.X - startPoint.X, p2.Y - startPoint.Y)
            Location = p3
        End If
    End Sub
End Class