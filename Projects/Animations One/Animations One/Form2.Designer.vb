<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimationProgramsYourName2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimationProgramsYourName2))
        Me.tmrOne = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTwo = New System.Windows.Forms.Timer(Me.components)
        Me.picrain = New System.Windows.Forms.PictureBox
        Me.piccloud = New System.Windows.Forms.PictureBox
        Me.picSun = New System.Windows.Forms.PictureBox
        Me.BtnNext = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.picrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccloud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrOne
        '
        Me.tmrOne.Enabled = True
        '
        'tmrTwo
        '
        '
        'picrain
        '
        Me.picrain.Image = CType(resources.GetObject("picrain.Image"), System.Drawing.Image)
        Me.picrain.Location = New System.Drawing.Point(456, 32)
        Me.picrain.Name = "picrain"
        Me.picrain.Size = New System.Drawing.Size(100, 72)
        Me.picrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picrain.TabIndex = 0
        Me.picrain.TabStop = False
        '
        'piccloud
        '
        Me.piccloud.Image = CType(resources.GetObject("piccloud.Image"), System.Drawing.Image)
        Me.piccloud.Location = New System.Drawing.Point(24, 304)
        Me.piccloud.Name = "piccloud"
        Me.piccloud.Size = New System.Drawing.Size(100, 88)
        Me.piccloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccloud.TabIndex = 1
        Me.piccloud.TabStop = False
        Me.piccloud.Visible = False
        '
        'picSun
        '
        Me.picSun.Image = CType(resources.GetObject("picSun.Image"), System.Drawing.Image)
        Me.picSun.Location = New System.Drawing.Point(40, 40)
        Me.picSun.Name = "picSun"
        Me.picSun.Size = New System.Drawing.Size(100, 64)
        Me.picSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSun.TabIndex = 2
        Me.picSun.TabStop = False
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(481, 385)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 3
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 417)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Evan Quach Period 3 Programming"
        '
        'frmAnimationProgramsYourName2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 439)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.picSun)
        Me.Controls.Add(Me.piccloud)
        Me.Controls.Add(Me.picrain)
        Me.Name = "frmAnimationProgramsYourName2"
        Me.Text = "Form2"
        CType(Me.picrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccloud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrOne As System.Windows.Forms.Timer
    Friend WithEvents tmrTwo As System.Windows.Forms.Timer
    Friend WithEvents picrain As System.Windows.Forms.PictureBox
    Friend WithEvents piccloud As System.Windows.Forms.PictureBox
    Friend WithEvents picSun As System.Windows.Forms.PictureBox
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
