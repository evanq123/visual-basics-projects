<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTitlePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTitlePage))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblDesc = New System.Windows.Forms.Label
        Me.PicHumpty = New System.Windows.Forms.PictureBox
        Me.picCloud2 = New System.Windows.Forms.PictureBox
        Me.PicCloud = New System.Windows.Forms.PictureBox
        Me.BtnNext = New System.Windows.Forms.Button
        CType(Me.PicHumpty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCloud2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCloud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(115, 142)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(363, 50)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Humpty Dumpty"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(12, 380)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(135, 13)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "Evan Quach 3 May 2 2014"
        '
        'PicHumpty
        '
        Me.PicHumpty.Image = CType(resources.GetObject("PicHumpty.Image"), System.Drawing.Image)
        Me.PicHumpty.Location = New System.Drawing.Point(171, 195)
        Me.PicHumpty.Name = "PicHumpty"
        Me.PicHumpty.Size = New System.Drawing.Size(250, 198)
        Me.PicHumpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicHumpty.TabIndex = 2
        Me.PicHumpty.TabStop = False
        '
        'picCloud2
        '
        Me.picCloud2.Image = CType(resources.GetObject("picCloud2.Image"), System.Drawing.Image)
        Me.picCloud2.Location = New System.Drawing.Point(408, 12)
        Me.picCloud2.Name = "picCloud2"
        Me.picCloud2.Size = New System.Drawing.Size(165, 109)
        Me.picCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCloud2.TabIndex = 3
        Me.picCloud2.TabStop = False
        '
        'PicCloud
        '
        Me.PicCloud.Image = CType(resources.GetObject("PicCloud.Image"), System.Drawing.Image)
        Me.PicCloud.Location = New System.Drawing.Point(15, 12)
        Me.PicCloud.Name = "PicCloud"
        Me.PicCloud.Size = New System.Drawing.Size(168, 104)
        Me.PicCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCloud.TabIndex = 4
        Me.PicCloud.TabStop = False
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(498, 375)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 5
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'FrmTitlePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(592, 418)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.PicCloud)
        Me.Controls.Add(Me.picCloud2)
        Me.Controls.Add(Me.PicHumpty)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FrmTitlePage"
        Me.Text = "HumptyDumpty"
        CType(Me.PicHumpty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCloud2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCloud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents PicHumpty As System.Windows.Forms.PictureBox
    Friend WithEvents picCloud2 As System.Windows.Forms.PictureBox
    Friend WithEvents PicCloud As System.Windows.Forms.PictureBox
    Friend WithEvents BtnNext As System.Windows.Forms.Button

End Class
