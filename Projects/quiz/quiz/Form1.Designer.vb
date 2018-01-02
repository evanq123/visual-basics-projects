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
        Me.Label1 = New System.Windows.Forms.Label
        Me.RBTYes = New System.Windows.Forms.RadioButton
        Me.RBTNo = New System.Windows.Forms.RadioButton
        Me.IMGYes = New System.Windows.Forms.PictureBox
        Me.IMGNo = New System.Windows.Forms.PictureBox
        CType(Me.IMGYes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMGNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Were you ready for the Quiz"
        '
        'RBTYes
        '
        Me.RBTYes.AutoSize = True
        Me.RBTYes.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.RBTYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTYes.Location = New System.Drawing.Point(115, 132)
        Me.RBTYes.Name = "RBTYes"
        Me.RBTYes.Size = New System.Drawing.Size(60, 28)
        Me.RBTYes.TabIndex = 1
        Me.RBTYes.TabStop = True
        Me.RBTYes.Text = "Yes"
        Me.RBTYes.UseVisualStyleBackColor = False
        '
        'RBTNo
        '
        Me.RBTNo.AutoSize = True
        Me.RBTNo.BackColor = System.Drawing.SystemColors.GrayText
        Me.RBTNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTNo.Location = New System.Drawing.Point(115, 423)
        Me.RBTNo.Name = "RBTNo"
        Me.RBTNo.Size = New System.Drawing.Size(53, 28)
        Me.RBTNo.TabIndex = 2
        Me.RBTNo.TabStop = True
        Me.RBTNo.Text = "No"
        Me.RBTNo.UseVisualStyleBackColor = False
        '
        'IMGYes
        '
        Me.IMGYes.Image = Global.WindowsApplication1.My.Resources.Resources.EditorImages_16
        Me.IMGYes.Location = New System.Drawing.Point(315, 9)
        Me.IMGYes.Name = "IMGYes"
        Me.IMGYes.Size = New System.Drawing.Size(364, 292)
        Me.IMGYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMGYes.TabIndex = 4
        Me.IMGYes.TabStop = False
        '
        'IMGNo
        '
        Me.IMGNo.Image = Global.WindowsApplication1.My.Resources.Resources._2011_02_27_NO
        Me.IMGNo.Location = New System.Drawing.Point(315, 297)
        Me.IMGNo.Name = "IMGNo"
        Me.IMGNo.Size = New System.Drawing.Size(364, 270)
        Me.IMGNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMGNo.TabIndex = 3
        Me.IMGNo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 563)
        Me.Controls.Add(Me.IMGYes)
        Me.Controls.Add(Me.IMGNo)
        Me.Controls.Add(Me.RBTNo)
        Me.Controls.Add(Me.RBTYes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.IMGYes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMGNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RBTYes As System.Windows.Forms.RadioButton
    Friend WithEvents RBTNo As System.Windows.Forms.RadioButton
    Friend WithEvents IMGNo As System.Windows.Forms.PictureBox
    Friend WithEvents IMGYes As System.Windows.Forms.PictureBox

End Class
