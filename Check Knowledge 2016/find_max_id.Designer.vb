<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class find_max_id
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(find_max_id))
        Me.lb_data = New System.Windows.Forms.Label()
        Me.tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.p1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pathk = New System.Windows.Forms.Label()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_data
        '
        Me.lb_data.AutoSize = True
        Me.lb_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lb_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_data.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_data.ForeColor = System.Drawing.Color.White
        Me.lb_data.Location = New System.Drawing.Point(46, 149)
        Me.lb_data.Name = "lb_data"
        Me.lb_data.Size = New System.Drawing.Size(292, 35)
        Me.lb_data.TabIndex = 1
        Me.lb_data.Text = "Đang nạp dữ liệu..."
        '
        'tm1
        '
        Me.tm1.Interval = 1
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.p1.Location = New System.Drawing.Point(12, 12)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(352, 185)
        Me.p1.TabIndex = 0
        Me.p1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox2.Image = Global.Check_Knowledge.My.Resources.Resources.log2o
        Me.PictureBox2.Location = New System.Drawing.Point(117, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 115)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'pathk
        '
        Me.pathk.AutoSize = True
        Me.pathk.Location = New System.Drawing.Point(370, 41)
        Me.pathk.Name = "pathk"
        Me.pathk.Size = New System.Drawing.Size(49, 13)
        Me.pathk.TabIndex = 3
        Me.pathk.Text = "pathtudo"
        Me.pathk.Visible = False
        '
        'find_max_id
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 210)
        Me.Controls.Add(Me.pathk)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lb_data)
        Me.Controls.Add(Me.p1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "find_max_id"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Waiting..."
        Me.TopMost = True
        CType(Me.p1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents p1 As PictureBox
    Friend WithEvents lb_data As Label
    Friend WithEvents tm1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pathk As Label
End Class
