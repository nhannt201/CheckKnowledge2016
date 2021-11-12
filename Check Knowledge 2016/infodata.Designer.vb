<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infodata
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_ok = New System.Windows.Forms.Button()
        Me.pns = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ghichu = New System.Windows.Forms.TextBox()
        Me.txt_tg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pns.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "THÔNG TIN DỮ LIỆU"
        '
        'bt_ok
        '
        Me.bt_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ok.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ok.Location = New System.Drawing.Point(403, 264)
        Me.bt_ok.Name = "bt_ok"
        Me.bt_ok.Size = New System.Drawing.Size(99, 33)
        Me.bt_ok.TabIndex = 21
        Me.bt_ok.Text = "&OK"
        Me.bt_ok.UseVisualStyleBackColor = False
        '
        'pns
        '
        Me.pns.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pns.Controls.Add(Me.Label2)
        Me.pns.Controls.Add(Me.txt_ghichu)
        Me.pns.Controls.Add(Me.txt_tg)
        Me.pns.Controls.Add(Me.Label3)
        Me.pns.Location = New System.Drawing.Point(21, 38)
        Me.pns.Name = "pns"
        Me.pns.Size = New System.Drawing.Size(481, 220)
        Me.pns.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tác giả:"
        '
        'txt_ghichu
        '
        Me.txt_ghichu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ghichu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ghichu.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ghichu.Location = New System.Drawing.Point(163, 73)
        Me.txt_ghichu.Multiline = True
        Me.txt_ghichu.Name = "txt_ghichu"
        Me.txt_ghichu.ReadOnly = True
        Me.txt_ghichu.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_ghichu.Size = New System.Drawing.Size(303, 120)
        Me.txt_ghichu.TabIndex = 4
        '
        'txt_tg
        '
        Me.txt_tg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_tg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tg.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tg.Location = New System.Drawing.Point(162, 27)
        Me.txt_tg.Name = "txt_tg"
        Me.txt_tg.ReadOnly = True
        Me.txt_tg.Size = New System.Drawing.Size(303, 26)
        Me.txt_tg.TabIndex = 2
        Me.txt_tg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ghi chú:"
        '
        'infodata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(520, 306)
        Me.Controls.Add(Me.pns)
        Me.Controls.Add(Me.bt_ok)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "infodata"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin dữ liệu"
        Me.TopMost = True
        Me.pns.ResumeLayout(False)
        Me.pns.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bt_ok As Button
    Friend WithEvents pns As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ghichu As TextBox
    Friend WithEvents txt_tg As TextBox
    Friend WithEvents Label3 As Label
End Class
