<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNationalFlagsEvanQuach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNationalFlagsEvanQuach))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblInfo = New System.Windows.Forms.Label
        Me.rbtSpain = New System.Windows.Forms.RadioButton
        Me.rbtFrance = New System.Windows.Forms.RadioButton
        Me.rbtUnitedStates = New System.Windows.Forms.RadioButton
        Me.picSpain = New System.Windows.Forms.PictureBox
        Me.picFrance = New System.Windows.Forms.PictureBox
        Me.picUnitedStates = New System.Windows.Forms.PictureBox
        Me.lblSpain = New System.Windows.Forms.Label
        Me.lblFrance = New System.Windows.Forms.Label
        Me.lblUnitedStates = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.TextSpain = New System.Windows.Forms.TextBox
        Me.TextFrance = New System.Windows.Forms.TextBox
        Me.TextUnitedStates = New System.Windows.Forms.TextBox
        Me.rbtItaly = New System.Windows.Forms.RadioButton
        Me.TextItaly = New System.Windows.Forms.TextBox
        Me.picItaly = New System.Windows.Forms.PictureBox
        CType(Me.picSpain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnitedStates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picItaly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Chartreuse
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(203, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(110, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "National Flags"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Chartreuse
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(28, 470)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(146, 22)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Evan Quach 3 Flag"
        '
        'rbtSpain
        '
        Me.rbtSpain.AutoSize = True
        Me.rbtSpain.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rbtSpain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSpain.ForeColor = System.Drawing.Color.Cornsilk
        Me.rbtSpain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbtSpain.Location = New System.Drawing.Point(46, 81)
        Me.rbtSpain.Name = "rbtSpain"
        Me.rbtSpain.Size = New System.Drawing.Size(68, 24)
        Me.rbtSpain.TabIndex = 2
        Me.rbtSpain.TabStop = True
        Me.rbtSpain.Text = "Spain"
        Me.rbtSpain.UseVisualStyleBackColor = False
        '
        'rbtFrance
        '
        Me.rbtFrance.AutoSize = True
        Me.rbtFrance.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rbtFrance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFrance.ForeColor = System.Drawing.Color.Cornsilk
        Me.rbtFrance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbtFrance.Location = New System.Drawing.Point(40, 168)
        Me.rbtFrance.Name = "rbtFrance"
        Me.rbtFrance.Size = New System.Drawing.Size(77, 24)
        Me.rbtFrance.TabIndex = 3
        Me.rbtFrance.TabStop = True
        Me.rbtFrance.Text = "France"
        Me.rbtFrance.UseVisualStyleBackColor = False
        '
        'rbtUnitedStates
        '
        Me.rbtUnitedStates.AutoSize = True
        Me.rbtUnitedStates.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rbtUnitedStates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbtUnitedStates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtUnitedStates.ForeColor = System.Drawing.Color.Cornsilk
        Me.rbtUnitedStates.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbtUnitedStates.Location = New System.Drawing.Point(40, 266)
        Me.rbtUnitedStates.Name = "rbtUnitedStates"
        Me.rbtUnitedStates.Size = New System.Drawing.Size(125, 24)
        Me.rbtUnitedStates.TabIndex = 4
        Me.rbtUnitedStates.TabStop = True
        Me.rbtUnitedStates.Text = "United States"
        Me.rbtUnitedStates.UseVisualStyleBackColor = False
        '
        'picSpain
        '
        Me.picSpain.Image = CType(resources.GetObject("picSpain.Image"), System.Drawing.Image)
        Me.picSpain.Location = New System.Drawing.Point(180, 60)
        Me.picSpain.Name = "picSpain"
        Me.picSpain.Size = New System.Drawing.Size(142, 70)
        Me.picSpain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpain.TabIndex = 5
        Me.picSpain.TabStop = False
        Me.picSpain.Visible = False
        '
        'picFrance
        '
        Me.picFrance.Image = CType(resources.GetObject("picFrance.Image"), System.Drawing.Image)
        Me.picFrance.Location = New System.Drawing.Point(180, 158)
        Me.picFrance.Name = "picFrance"
        Me.picFrance.Size = New System.Drawing.Size(142, 72)
        Me.picFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFrance.TabIndex = 6
        Me.picFrance.TabStop = False
        Me.picFrance.Visible = False
        '
        'picUnitedStates
        '
        Me.picUnitedStates.Image = CType(resources.GetObject("picUnitedStates.Image"), System.Drawing.Image)
        Me.picUnitedStates.Location = New System.Drawing.Point(180, 248)
        Me.picUnitedStates.Name = "picUnitedStates"
        Me.picUnitedStates.Size = New System.Drawing.Size(142, 76)
        Me.picUnitedStates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUnitedStates.TabIndex = 7
        Me.picUnitedStates.TabStop = False
        Me.picUnitedStates.Visible = False
        '
        'lblSpain
        '
        Me.lblSpain.AutoSize = True
        Me.lblSpain.Location = New System.Drawing.Point(422, 99)
        Me.lblSpain.Name = "lblSpain"
        Me.lblSpain.Size = New System.Drawing.Size(0, 13)
        Me.lblSpain.TabIndex = 8
        '
        'lblFrance
        '
        Me.lblFrance.AutoSize = True
        Me.lblFrance.Location = New System.Drawing.Point(422, 175)
        Me.lblFrance.Name = "lblFrance"
        Me.lblFrance.Size = New System.Drawing.Size(0, 13)
        Me.lblFrance.TabIndex = 9
        '
        'lblUnitedStates
        '
        Me.lblUnitedStates.AutoSize = True
        Me.lblUnitedStates.Location = New System.Drawing.Point(422, 272)
        Me.lblUnitedStates.Name = "lblUnitedStates"
        Me.lblUnitedStates.Size = New System.Drawing.Size(0, 13)
        Me.lblUnitedStates.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Coral
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(763, 470)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'TextSpain
        '
        Me.TextSpain.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextSpain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSpain.Location = New System.Drawing.Point(373, 91)
        Me.TextSpain.Name = "TextSpain"
        Me.TextSpain.Size = New System.Drawing.Size(465, 26)
        Me.TextSpain.TabIndex = 12
        '
        'TextFrance
        '
        Me.TextFrance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextFrance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFrance.Location = New System.Drawing.Point(373, 167)
        Me.TextFrance.Name = "TextFrance"
        Me.TextFrance.Size = New System.Drawing.Size(465, 26)
        Me.TextFrance.TabIndex = 13
        '
        'TextUnitedStates
        '
        Me.TextUnitedStates.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextUnitedStates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUnitedStates.Location = New System.Drawing.Point(373, 265)
        Me.TextUnitedStates.Name = "TextUnitedStates"
        Me.TextUnitedStates.Size = New System.Drawing.Size(714, 26)
        Me.TextUnitedStates.TabIndex = 14
        '
        'rbtItaly
        '
        Me.rbtItaly.AutoSize = True
        Me.rbtItaly.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rbtItaly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbtItaly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtItaly.ForeColor = System.Drawing.Color.Cornsilk
        Me.rbtItaly.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbtItaly.Location = New System.Drawing.Point(42, 385)
        Me.rbtItaly.Name = "rbtItaly"
        Me.rbtItaly.Size = New System.Drawing.Size(56, 24)
        Me.rbtItaly.TabIndex = 15
        Me.rbtItaly.TabStop = True
        Me.rbtItaly.Text = "Italy"
        Me.rbtItaly.UseVisualStyleBackColor = False
        '
        'TextItaly
        '
        Me.TextItaly.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextItaly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextItaly.Location = New System.Drawing.Point(373, 353)
        Me.TextItaly.Name = "TextItaly"
        Me.TextItaly.Size = New System.Drawing.Size(465, 26)
        Me.TextItaly.TabIndex = 16
        '
        'picItaly
        '
        Me.picItaly.Image = CType(resources.GetObject("picItaly.Image"), System.Drawing.Image)
        Me.picItaly.Location = New System.Drawing.Point(180, 342)
        Me.picItaly.Name = "picItaly"
        Me.picItaly.Size = New System.Drawing.Size(142, 85)
        Me.picItaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picItaly.TabIndex = 17
        Me.picItaly.TabStop = False
        Me.picItaly.Visible = False
        '
        'frmNationalFlagsEvanQuach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1099, 500)
        Me.Controls.Add(Me.picItaly)
        Me.Controls.Add(Me.TextItaly)
        Me.Controls.Add(Me.rbtItaly)
        Me.Controls.Add(Me.TextUnitedStates)
        Me.Controls.Add(Me.TextFrance)
        Me.Controls.Add(Me.TextSpain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblUnitedStates)
        Me.Controls.Add(Me.lblFrance)
        Me.Controls.Add(Me.lblSpain)
        Me.Controls.Add(Me.picUnitedStates)
        Me.Controls.Add(Me.picFrance)
        Me.Controls.Add(Me.picSpain)
        Me.Controls.Add(Me.rbtUnitedStates)
        Me.Controls.Add(Me.rbtFrance)
        Me.Controls.Add(Me.rbtSpain)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmNationalFlagsEvanQuach"
        Me.Text = "National Flags"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picSpain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnitedStates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picItaly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents rbtSpain As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFrance As System.Windows.Forms.RadioButton
    Friend WithEvents rbtUnitedStates As System.Windows.Forms.RadioButton
    Friend WithEvents picSpain As System.Windows.Forms.PictureBox
    Friend WithEvents picFrance As System.Windows.Forms.PictureBox
    Friend WithEvents picUnitedStates As System.Windows.Forms.PictureBox
    Friend WithEvents lblSpain As System.Windows.Forms.Label
    Friend WithEvents lblFrance As System.Windows.Forms.Label
    Friend WithEvents lblUnitedStates As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents TextSpain As System.Windows.Forms.TextBox
    Friend WithEvents TextFrance As System.Windows.Forms.TextBox
    Friend WithEvents TextUnitedStates As System.Windows.Forms.TextBox
    Friend WithEvents rbtItaly As System.Windows.Forms.RadioButton
    Friend WithEvents TextItaly As System.Windows.Forms.TextBox
    Friend WithEvents picItaly As System.Windows.Forms.PictureBox

End Class
