<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.lg = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b1 = New System.Windows.Forms.PictureBox()
        Me.b3 = New System.Windows.Forms.PictureBox()
        Me.b4 = New System.Windows.Forms.PictureBox()
        Me.b2 = New System.Windows.Forms.PictureBox()
        CType(Me.lg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lg
        '
        Me.lg.BackColor = System.Drawing.Color.Transparent

        Me.lg.Location = New System.Drawing.Point(12, 12)
        Me.lg.Name = "lg"
        Me.lg.Size = New System.Drawing.Size(273, 243)
        Me.lg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lg.TabIndex = 1
        Me.lg.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(957, 707)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
        '
       
        
      
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Knowledge"
        CType(Me.lg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lg As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b1 As System.Windows.Forms.PictureBox
    Friend WithEvents b3 As System.Windows.Forms.PictureBox
    Friend WithEvents b4 As System.Windows.Forms.PictureBox
    Friend WithEvents b2 As System.Windows.Forms.PictureBox
End Class
