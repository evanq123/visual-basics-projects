<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelowWorldEvanQuach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelowWorldEvanQuach))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblInfo = New System.Windows.Forms.Label
        Me.lblSmile = New System.Windows.Forms.Label
        Me.lblGrin = New System.Windows.Forms.Label
        Me.lblFrown = New System.Windows.Forms.Label
        Me.picSmile = New System.Windows.Forms.PictureBox
        Me.picGrin = New System.Windows.Forms.PictureBox
        Me.picFrown = New System.Windows.Forms.PictureBox
        Me.rbtSmile = New System.Windows.Forms.RadioButton
        Me.rbtGrin = New System.Windows.Forms.RadioButton
        Me.rbtFrown = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        CType(Me.picSmile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGrin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(130, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "How Do You Feel Today?"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.Location = New System.Drawing.Point(12, 361)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(182, 15)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Evan Quach 3 2/21/14 Hello World!"
        '
        'lblSmile
        '
        Me.lblSmile.AutoSize = True
        Me.lblSmile.Location = New System.Drawing.Point(304, 68)
        Me.lblSmile.Name = "lblSmile"
        Me.lblSmile.Size = New System.Drawing.Size(0, 13)
        Me.lblSmile.TabIndex = 2
        '
        'lblGrin
        '
        Me.lblGrin.AutoSize = True
        Me.lblGrin.Location = New System.Drawing.Point(304, 169)
        Me.lblGrin.Name = "lblGrin"
        Me.lblGrin.Size = New System.Drawing.Size(0, 13)
        Me.lblGrin.TabIndex = 3
        '
        'lblFrown
        '
        Me.lblFrown.AutoSize = True
        Me.lblFrown.Location = New System.Drawing.Point(304, 277)
        Me.lblFrown.Name = "lblFrown"
        Me.lblFrown.Size = New System.Drawing.Size(0, 13)
        Me.lblFrown.TabIndex = 4
        '
        'picSmile
        '
        Me.picSmile.Image = CType(resources.GetObject("picSmile.Image"), System.Drawing.Image)
        Me.picSmile.Location = New System.Drawing.Point(178, 36)
        Me.picSmile.Name = "picSmile"
        Me.picSmile.Size = New System.Drawing.Size(86, 78)
        Me.picSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmile.TabIndex = 5
        Me.picSmile.TabStop = False
        '
        'picGrin
        '
        Me.picGrin.Image = CType(resources.GetObject("picGrin.Image"), System.Drawing.Image)
        Me.picGrin.Location = New System.Drawing.Point(178, 145)
        Me.picGrin.Name = "picGrin"
        Me.picGrin.Size = New System.Drawing.Size(86, 78)
        Me.picGrin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGrin.TabIndex = 6
        Me.picGrin.TabStop = False
        Me.picGrin.Visible = False
        '
        'picFrown
        '
        Me.picFrown.Image = CType(resources.GetObject("picFrown.Image"), System.Drawing.Image)
        Me.picFrown.Location = New System.Drawing.Point(178, 256)
        Me.picFrown.Name = "picFrown"
        Me.picFrown.Size = New System.Drawing.Size(86, 78)
        Me.picFrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFrown.TabIndex = 7
        Me.picFrown.TabStop = False
        Me.picFrown.Visible = False
        '
        'rbtSmile
        '
        Me.rbtSmile.AutoSize = True
        Me.rbtSmile.Location = New System.Drawing.Point(36, 64)
        Me.rbtSmile.Name = "rbtSmile"
        Me.rbtSmile.Size = New System.Drawing.Size(75, 17)
        Me.rbtSmile.TabIndex = 8
        Me.rbtSmile.TabStop = True
        Me.rbtSmile.Text = "I'm Happy!"
        Me.rbtSmile.UseVisualStyleBackColor = True
        '
        'rbtGrin
        '
        Me.rbtGrin.AutoSize = True
        Me.rbtGrin.Location = New System.Drawing.Point(36, 169)
        Me.rbtGrin.Name = "rbtGrin"
        Me.rbtGrin.Size = New System.Drawing.Size(62, 17)
        Me.rbtGrin.TabIndex = 9
        Me.rbtGrin.TabStop = True
        Me.rbtGrin.Text = "I'm O.K."
        Me.rbtGrin.UseVisualStyleBackColor = True
        '
        'rbtFrown
        '
        Me.rbtFrown.AutoSize = True
        Me.rbtFrown.Location = New System.Drawing.Point(36, 273)
        Me.rbtFrown.Name = "rbtFrown"
        Me.rbtFrown.Size = New System.Drawing.Size(69, 17)
        Me.rbtFrown.TabIndex = 10
        Me.rbtFrown.TabStop = True
        Me.rbtFrown.Text = "I'm Sad..."
        Me.rbtFrown.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(307, 354)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 27)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmHelowWorldEvanQuach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(401, 393)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.rbtFrown)
        Me.Controls.Add(Me.rbtGrin)
        Me.Controls.Add(Me.rbtSmile)
        Me.Controls.Add(Me.picFrown)
        Me.Controls.Add(Me.picGrin)
        Me.Controls.Add(Me.picSmile)
        Me.Controls.Add(Me.lblFrown)
        Me.Controls.Add(Me.lblGrin)
        Me.Controls.Add(Me.lblSmile)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmHelowWorldEvanQuach"
        Me.Text = "Hello World!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picSmile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGrin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblSmile As System.Windows.Forms.Label
    Friend WithEvents lblGrin As System.Windows.Forms.Label
    Friend WithEvents lblFrown As System.Windows.Forms.Label
    Friend WithEvents picSmile As System.Windows.Forms.PictureBox
    Friend WithEvents picGrin As System.Windows.Forms.PictureBox
    Friend WithEvents picFrown As System.Windows.Forms.PictureBox
    Friend WithEvents rbtSmile As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGrin As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFrown As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
