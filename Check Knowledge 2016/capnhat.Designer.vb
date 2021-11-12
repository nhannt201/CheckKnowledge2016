<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capnhat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(capnhat))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_up = New System.Windows.Forms.Label()
        Me.upda = New System.Windows.Forms.Timer(Me.components)
        Me.prb = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kiểm tra cập nhật"
        '
        'lb_up
        '
        Me.lb_up.AutoSize = True
        Me.lb_up.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_up.Location = New System.Drawing.Point(12, 35)
        Me.lb_up.Name = "lb_up"
        Me.lb_up.Size = New System.Drawing.Size(213, 23)
        Me.lb_up.TabIndex = 1
        Me.lb_up.Text = "Đang kết nối máy chủ..."
        '
        'upda
        '
        Me.upda.Enabled = True
        Me.upda.Interval = 500
        '
        'prb
        '
        Me.prb.Location = New System.Drawing.Point(16, 59)
        Me.prb.Name = "prb"
        Me.prb.Size = New System.Drawing.Size(431, 10)
        Me.prb.TabIndex = 2
        '
        'capnhat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(465, 73)
        Me.Controls.Add(Me.prb)
        Me.Controls.Add(Me.lb_up)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "capnhat"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cập nhật CSDL"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lb_up As Label
    Friend WithEvents upda As Timer
    Friend WithEvents prb As ProgressBar
End Class
