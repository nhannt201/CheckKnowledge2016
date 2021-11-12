<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class load2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.imgload = New System.Windows.Forms.PictureBox()
        Me.ppx = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ppx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.imgload)
        Me.Panel1.Controls.Add(Me.ppx)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 256)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox3.Location = New System.Drawing.Point(77, 229)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(349, 10)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'imgload
        '
        Me.imgload.BackColor = System.Drawing.Color.Black
        Me.imgload.Location = New System.Drawing.Point(77, 229)
        Me.imgload.Name = "imgload"
        Me.imgload.Size = New System.Drawing.Size(349, 10)
        Me.imgload.TabIndex = 5
        Me.imgload.TabStop = False
        '
        'ppx
        '
        Me.ppx.Image = Global.Check_Knowledge.My.Resources.Resources.Check_knowledge
        Me.ppx.Location = New System.Drawing.Point(62, 13)
        Me.ppx.Name = "ppx"
        Me.ppx.Size = New System.Drawing.Size(377, 196)
        Me.ppx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ppx.TabIndex = 0
        Me.ppx.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'load2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(529, 280)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "load2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading..."
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ppx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ppx As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents imgload As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
