<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.PicBasketball = New System.Windows.Forms.PictureBox
        Me.PicBaseball = New System.Windows.Forms.PictureBox
        Me.PicFootball = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PicBasketball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBaseball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFootball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Football", "Baseball", "Basketball"})
        Me.ComboBox1.Location = New System.Drawing.Point(328, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Choose One"
        '
        'PicBasketball
        '
        Me.PicBasketball.Image = Global.WindowsApplication1.My.Resources.Resources.Miama_Heats
        Me.PicBasketball.Location = New System.Drawing.Point(541, 116)
        Me.PicBasketball.Name = "PicBasketball"
        Me.PicBasketball.Size = New System.Drawing.Size(211, 199)
        Me.PicBasketball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBasketball.TabIndex = 3
        Me.PicBasketball.TabStop = False
        Me.PicBasketball.Visible = False
        '
        'PicBaseball
        '
        Me.PicBaseball.Image = Global.WindowsApplication1.My.Resources.Resources.Washington_Nationals
        Me.PicBaseball.Location = New System.Drawing.Point(271, 116)
        Me.PicBaseball.Name = "PicBaseball"
        Me.PicBaseball.Size = New System.Drawing.Size(229, 199)
        Me.PicBaseball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBaseball.TabIndex = 2
        Me.PicBaseball.TabStop = False
        Me.PicBaseball.Visible = False
        '
        'PicFootball
        '
        Me.PicFootball.Image = Global.WindowsApplication1.My.Resources.Resources.Baltimore_Ravens
        Me.PicFootball.Location = New System.Drawing.Point(21, 116)
        Me.PicFootball.Name = "PicFootball"
        Me.PicFootball.Size = New System.Drawing.Size(204, 199)
        Me.PicFootball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFootball.TabIndex = 1
        Me.PicFootball.TabStop = False
        Me.PicFootball.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "My Favorite Sports Team"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 344)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicBasketball)
        Me.Controls.Add(Me.PicBaseball)
        Me.Controls.Add(Me.PicFootball)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicBasketball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBaseball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFootball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PicFootball As System.Windows.Forms.PictureBox
    Friend WithEvents PicBaseball As System.Windows.Forms.PictureBox
    Friend WithEvents PicBasketball As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
