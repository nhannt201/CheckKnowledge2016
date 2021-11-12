<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home_v2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home_v2))
        Me.imgindex = New System.Windows.Forms.PictureBox()
        Me.lb_txt = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.list_last = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_path = New System.Windows.Forms.Label()
        CType(Me.imgindex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgindex
        '
        Me.imgindex.Image = Global.Check_Knowledge.My.Resources.Resources.Check_knowledge
        Me.imgindex.Location = New System.Drawing.Point(85, 60)
        Me.imgindex.Name = "imgindex"
        Me.imgindex.Size = New System.Drawing.Size(265, 197)
        Me.imgindex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgindex.TabIndex = 1
        Me.imgindex.TabStop = False
        '
        'lb_txt
        '
        Me.lb_txt.AutoSize = True
        Me.lb_txt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_txt.ForeColor = System.Drawing.Color.White
        Me.lb_txt.Location = New System.Drawing.Point(98, 260)
        Me.lb_txt.Name = "lb_txt"
        Me.lb_txt.Size = New System.Drawing.Size(252, 16)
        Me.lb_txt.TabIndex = 2
        Me.lb_txt.Text = "Kiểm tra kiến thức - Check Knowledge"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(373, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(641, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'list_last
        '
        Me.list_last.BackColor = System.Drawing.Color.Black
        Me.list_last.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list_last.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_last.ForeColor = System.Drawing.Color.White
        Me.list_last.Location = New System.Drawing.Point(16, 19)
        Me.list_last.Name = "list_last"
        Me.list_last.Size = New System.Drawing.Size(261, 256)
        Me.list_last.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.list_last)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(85, 293)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 269)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đám mây"
        '
        'lb_path
        '
        Me.lb_path.AutoSize = True
        Me.lb_path.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_path.ForeColor = System.Drawing.Color.White
        Me.lb_path.Location = New System.Drawing.Point(389, 271)
        Me.lb_path.Name = "lb_path"
        Me.lb_path.Size = New System.Drawing.Size(0, 16)
        Me.lb_path.TabIndex = 8
        '
        'home_v2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lb_path)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lb_txt)
        Me.Controls.Add(Me.imgindex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "home_v2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kiểm tra kiến thức - Check Knowledge"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imgindex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgindex As PictureBox
    Friend WithEvents lb_txt As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents list_last As TreeView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lb_path As Label
End Class
