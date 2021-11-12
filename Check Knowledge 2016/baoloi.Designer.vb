<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class baoloi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(baoloi))
        Me.lb_ror = New System.Windows.Forms.Label()
        Me.lb_er = New System.Windows.Forms.Label()
        Me.end_pr = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lb_ror
        '
        Me.lb_ror.AutoSize = True
        Me.lb_ror.Font = New System.Drawing.Font("Virtual DJ", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ror.ForeColor = System.Drawing.Color.White
        Me.lb_ror.Location = New System.Drawing.Point(16, 39)
        Me.lb_ror.Name = "lb_ror"
        Me.lb_ror.Size = New System.Drawing.Size(776, 40)
        Me.lb_ror.TabIndex = 3
        Me.lb_ror.Text = "Đã xảy ra lỗi không xác định!"
        '
        'lb_er
        '
        Me.lb_er.AutoSize = True
        Me.lb_er.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_er.ForeColor = System.Drawing.Color.White
        Me.lb_er.Location = New System.Drawing.Point(162, 197)
        Me.lb_er.Name = "lb_er"
        Me.lb_er.Size = New System.Drawing.Size(139, 39)
        Me.lb_er.TabIndex = 2
        Me.lb_er.Text = "Báo lỗi:"
        Me.lb_er.Visible = False
        '
        'end_pr
        '
        Me.end_pr.Enabled = True
        Me.end_pr.Interval = 2000
        '
        'baoloi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(804, 432)
        Me.Controls.Add(Me.lb_ror)
        Me.Controls.Add(Me.lb_er)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "baoloi"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lỗi"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_ror As Label
    Friend WithEvents lb_er As Label
    Friend WithEvents end_pr As Timer
End Class
