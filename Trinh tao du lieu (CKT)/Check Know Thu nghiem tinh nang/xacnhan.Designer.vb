<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xacnhan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xacnhan))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pk = New System.Windows.Forms.TextBox()
        Me.bt_ok = New System.Windows.Forms.Button()
        Me.bt_cel = New System.Windows.Forms.Button()
        Me.passk = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nhập mã bảo mật"
        '
        'txt_pk
        '
        Me.txt_pk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_pk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_pk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pk.Location = New System.Drawing.Point(34, 71)
        Me.txt_pk.MaxLength = 200
        Me.txt_pk.Name = "txt_pk"
        Me.txt_pk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pk.Size = New System.Drawing.Size(295, 20)
        Me.txt_pk.TabIndex = 2
        Me.txt_pk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bt_ok
        '
        Me.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ok.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ok.Location = New System.Drawing.Point(34, 110)
        Me.bt_ok.Name = "bt_ok"
        Me.bt_ok.Size = New System.Drawing.Size(111, 42)
        Me.bt_ok.TabIndex = 4
        Me.bt_ok.Text = "&Xác nhận"
        Me.bt_ok.UseVisualStyleBackColor = True
        '
        'bt_cel
        '
        Me.bt_cel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cel.Location = New System.Drawing.Point(218, 110)
        Me.bt_cel.Name = "bt_cel"
        Me.bt_cel.Size = New System.Drawing.Size(111, 42)
        Me.bt_cel.TabIndex = 5
        Me.bt_cel.Text = "&Trở về"
        Me.bt_cel.UseVisualStyleBackColor = True
        '
        'passk
        '
        Me.passk.AutoSize = True
        Me.passk.Location = New System.Drawing.Point(350, 189)
        Me.passk.Name = "passk"
        Me.passk.Size = New System.Drawing.Size(24, 13)
        Me.passk.TabIndex = 6
        Me.passk.Text = "pks"
        Me.passk.Visible = False
        '
        'xacnhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 174)
        Me.Controls.Add(Me.passk)
        Me.Controls.Add(Me.bt_cel)
        Me.Controls.Add(Me.bt_ok)
        Me.Controls.Add(Me.txt_pk)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "xacnhan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xác nhận dữ liệu"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pk As TextBox
    Friend WithEvents bt_ok As Button
    Friend WithEvents bt_cel As Button
    Friend WithEvents passk As Label
End Class
