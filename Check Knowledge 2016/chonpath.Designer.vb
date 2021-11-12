<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chonpath
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
        Me.bt1 = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.bt_next = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(19, 29)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(175, 72)
        Me.bt1.TabIndex = 20
        Me.bt1.Text = "&Chọn dữ liệu có sẵn trong máy"
        Me.bt1.UseVisualStyleBackColor = False
        '
        'bt2
        '
        Me.bt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt2.Location = New System.Drawing.Point(219, 29)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(175, 72)
        Me.bt2.TabIndex = 21
        Me.bt2.Text = "&Chọn từ thư viện trực tuyến"
        Me.bt2.UseVisualStyleBackColor = False
        '
        'bt_next
        '
        Me.bt_next.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_next.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_next.Location = New System.Drawing.Point(313, 141)
        Me.bt_next.Name = "bt_next"
        Me.bt_next.Size = New System.Drawing.Size(115, 41)
        Me.bt_next.TabIndex = 22
        Me.bt_next.Text = "&Quay lại"
        Me.bt_next.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt2)
        Me.GroupBox1.Controls.Add(Me.bt1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 123)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lựa chọn dữ liệu"
        '
        'chonpath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 194)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_next)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "chonpath"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bt1 As Button
    Friend WithEvents bt2 As Button
    Friend WithEvents bt_next As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
