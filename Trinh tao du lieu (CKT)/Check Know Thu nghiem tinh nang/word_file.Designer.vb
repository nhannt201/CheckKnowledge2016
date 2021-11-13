<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class word_file
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
        Me.richtxt = New System.Windows.Forms.RichTextBox()
        Me.bt_open = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'richtxt
        '
        Me.richtxt.BackColor = System.Drawing.Color.White
        Me.richtxt.Location = New System.Drawing.Point(12, 44)
        Me.richtxt.Name = "richtxt"
        Me.richtxt.ReadOnly = True
        Me.richtxt.Size = New System.Drawing.Size(420, 288)
        Me.richtxt.TabIndex = 0
        Me.richtxt.Text = ""
        '
        'bt_open
        '
        Me.bt_open.BackColor = System.Drawing.Color.White
        Me.bt_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_open.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_open.Location = New System.Drawing.Point(12, 10)
        Me.bt_open.Name = "bt_open"
        Me.bt_open.Size = New System.Drawing.Size(420, 28)
        Me.bt_open.TabIndex = 1
        Me.bt_open.Text = "&Mở thư mục lưu"
        Me.bt_open.UseVisualStyleBackColor = False
        '
        'word_file
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 344)
        Me.Controls.Add(Me.bt_open)
        Me.Controls.Add(Me.richtxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "word_file"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trình xuất file Word"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents richtxt As RichTextBox
    Friend WithEvents bt_open As Button
End Class
