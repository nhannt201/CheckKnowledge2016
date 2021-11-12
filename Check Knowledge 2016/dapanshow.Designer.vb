<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dapanshow
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
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_ok = New System.Windows.Forms.Button()
        Me.pns = New System.Windows.Forms.Panel()
        Me.pns.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_data
        '
        Me.txt_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_data.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data.Location = New System.Drawing.Point(17, 17)
        Me.txt_data.Multiline = True
        Me.txt_data.Name = "txt_data"
        Me.txt_data.ReadOnly = True
        Me.txt_data.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_data.Size = New System.Drawing.Size(453, 163)
        Me.txt_data.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ĐÁP ÁN THAM KHẢO"
        '
        'bt_ok
        '
        Me.bt_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ok.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ok.Location = New System.Drawing.Point(401, 235)
        Me.bt_ok.Name = "bt_ok"
        Me.bt_ok.Size = New System.Drawing.Size(99, 33)
        Me.bt_ok.TabIndex = 20
        Me.bt_ok.Text = "&OK"
        Me.bt_ok.UseVisualStyleBackColor = False
        '
        'pns
        '
        Me.pns.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pns.Controls.Add(Me.txt_data)
        Me.pns.Location = New System.Drawing.Point(12, 36)
        Me.pns.Name = "pns"
        Me.pns.Size = New System.Drawing.Size(488, 192)
        Me.pns.TabIndex = 21
        '
        'dapanshow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(512, 279)
        Me.Controls.Add(Me.pns)
        Me.Controls.Add(Me.bt_ok)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dapanshow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đáp án"
        Me.TopMost = True
        Me.pns.ResumeLayout(False)
        Me.pns.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_data As TextBox
    Friend WithEvents bt_ok As Button
    Friend WithEvents pns As Panel
End Class
