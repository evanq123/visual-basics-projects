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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grbGirl = New System.Windows.Forms.GroupBox
        Me.chkNecklace = New System.Windows.Forms.CheckBox
        Me.chkPurse = New System.Windows.Forms.CheckBox
        Me.chkBow = New System.Windows.Forms.CheckBox
        Me.chkTutu = New System.Windows.Forms.CheckBox
        Me.grbBoy = New System.Windows.Forms.GroupBox
        Me.chkZipper = New System.Windows.Forms.CheckBox
        Me.chkBowtie = New System.Windows.Forms.CheckBox
        Me.chkTie = New System.Windows.Forms.CheckBox
        Me.chkHat = New System.Windows.Forms.CheckBox
        Me.picGirl = New System.Windows.Forms.PictureBox
        Me.btnOrder = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtOrder = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.picBoy = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblYourOrder = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.picBow = New System.Windows.Forms.PictureBox
        Me.picNecklace = New System.Windows.Forms.PictureBox
        Me.picTutu = New System.Windows.Forms.PictureBox
        Me.picPurse = New System.Windows.Forms.PictureBox
        Me.picHat = New System.Windows.Forms.PictureBox
        Me.PicBowTie = New System.Windows.Forms.PictureBox
        Me.picTie = New System.Windows.Forms.PictureBox
        Me.picZipper = New System.Windows.Forms.PictureBox
        Me.grbGirl.SuspendLayout()
        Me.grbBoy.SuspendLayout()
        CType(Me.picGirl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNecklace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTutu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPurse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBowTie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picZipper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbGirl
        '
        Me.grbGirl.Controls.Add(Me.chkNecklace)
        Me.grbGirl.Controls.Add(Me.chkPurse)
        Me.grbGirl.Controls.Add(Me.chkBow)
        Me.grbGirl.Controls.Add(Me.chkTutu)
        Me.grbGirl.Location = New System.Drawing.Point(12, 107)
        Me.grbGirl.Name = "grbGirl"
        Me.grbGirl.Size = New System.Drawing.Size(153, 119)
        Me.grbGirl.TabIndex = 0
        Me.grbGirl.TabStop = False
        Me.grbGirl.Text = "Girl Bear"
        '
        'chkNecklace
        '
        Me.chkNecklace.AutoSize = True
        Me.chkNecklace.Location = New System.Drawing.Point(6, 88)
        Me.chkNecklace.Name = "chkNecklace"
        Me.chkNecklace.Size = New System.Drawing.Size(111, 17)
        Me.chkNecklace.TabIndex = 3
        Me.chkNecklace.Text = "Necklace: $12.50"
        Me.chkNecklace.UseVisualStyleBackColor = True
        '
        'chkPurse
        '
        Me.chkPurse.AutoSize = True
        Me.chkPurse.Location = New System.Drawing.Point(6, 65)
        Me.chkPurse.Name = "chkPurse"
        Me.chkPurse.Size = New System.Drawing.Size(92, 17)
        Me.chkPurse.TabIndex = 2
        Me.chkPurse.Text = "Purse: $35.00"
        Me.chkPurse.UseVisualStyleBackColor = True
        '
        'chkBow
        '
        Me.chkBow.AutoSize = True
        Me.chkBow.Location = New System.Drawing.Point(6, 42)
        Me.chkBow.Name = "chkBow"
        Me.chkBow.Size = New System.Drawing.Size(102, 17)
        Me.chkBow.TabIndex = 1
        Me.chkBow.Text = "Hair Bow: $7.50"
        Me.chkBow.UseVisualStyleBackColor = True
        '
        'chkTutu
        '
        Me.chkTutu.AutoSize = True
        Me.chkTutu.Location = New System.Drawing.Point(6, 19)
        Me.chkTutu.Name = "chkTutu"
        Me.chkTutu.Size = New System.Drawing.Size(87, 17)
        Me.chkTutu.TabIndex = 0
        Me.chkTutu.Text = "Tutu: $25.00"
        Me.chkTutu.UseVisualStyleBackColor = True
        '
        'grbBoy
        '
        Me.grbBoy.Controls.Add(Me.chkZipper)
        Me.grbBoy.Controls.Add(Me.chkBowtie)
        Me.grbBoy.Controls.Add(Me.chkTie)
        Me.grbBoy.Controls.Add(Me.chkHat)
        Me.grbBoy.Location = New System.Drawing.Point(447, 107)
        Me.grbBoy.Name = "grbBoy"
        Me.grbBoy.Size = New System.Drawing.Size(153, 119)
        Me.grbBoy.TabIndex = 4
        Me.grbBoy.TabStop = False
        Me.grbBoy.Text = "Boy Bear"
        '
        'chkZipper
        '
        Me.chkZipper.AutoSize = True
        Me.chkZipper.Location = New System.Drawing.Point(6, 88)
        Me.chkZipper.Name = "chkZipper"
        Me.chkZipper.Size = New System.Drawing.Size(95, 17)
        Me.chkZipper.TabIndex = 3
        Me.chkZipper.Text = "Zipper: $15.00"
        Me.chkZipper.UseVisualStyleBackColor = True
        '
        'chkBowtie
        '
        Me.chkBowtie.AutoSize = True
        Me.chkBowtie.Location = New System.Drawing.Point(6, 65)
        Me.chkBowtie.Name = "chkBowtie"
        Me.chkBowtie.Size = New System.Drawing.Size(104, 17)
        Me.chkBowtie.TabIndex = 2
        Me.chkBowtie.Text = "Bow Tie: $25.00"
        Me.chkBowtie.UseVisualStyleBackColor = True
        '
        'chkTie
        '
        Me.chkTie.AutoSize = True
        Me.chkTie.Location = New System.Drawing.Point(6, 42)
        Me.chkTie.Name = "chkTie"
        Me.chkTie.Size = New System.Drawing.Size(80, 17)
        Me.chkTie.TabIndex = 1
        Me.chkTie.Text = "Tie: $15.00"
        Me.chkTie.UseVisualStyleBackColor = True
        '
        'chkHat
        '
        Me.chkHat.AutoSize = True
        Me.chkHat.Location = New System.Drawing.Point(6, 19)
        Me.chkHat.Name = "chkHat"
        Me.chkHat.Size = New System.Drawing.Size(82, 17)
        Me.chkHat.TabIndex = 0
        Me.chkHat.Text = "Hat: $10.00"
        Me.chkHat.UseVisualStyleBackColor = True
        '
        'picGirl
        '
        Me.picGirl.Image = CType(resources.GetObject("picGirl.Image"), System.Drawing.Image)
        Me.picGirl.Location = New System.Drawing.Point(195, 107)
        Me.picGirl.Name = "picGirl"
        Me.picGirl.Size = New System.Drawing.Size(177, 213)
        Me.picGirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGirl.TabIndex = 4
        Me.picGirl.TabStop = False
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(18, 405)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 6
        Me.btnOrder.Text = "Place Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(18, 493)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(195, 405)
        Me.txtOrder.Multiline = True
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(177, 111)
        Me.txtOrder.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(423, 496)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(177, 20)
        Me.txtTotal.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(647, 493)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picBoy
        '
        Me.picBoy.Image = CType(resources.GetObject("picBoy.Image"), System.Drawing.Image)
        Me.picBoy.Location = New System.Drawing.Point(623, 107)
        Me.picBoy.Name = "picBoy"
        Me.picBoy.Size = New System.Drawing.Size(177, 213)
        Me.picBoy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoy.TabIndex = 12
        Me.picBoy.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Salmon
        Me.lblTitle.Font = New System.Drawing.Font("Forte", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(210, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(404, 70)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Build-A-Bear"
        '
        'lblYourOrder
        '
        Me.lblYourOrder.AutoSize = True
        Me.lblYourOrder.Location = New System.Drawing.Point(255, 389)
        Me.lblYourOrder.Name = "lblYourOrder"
        Me.lblYourOrder.Size = New System.Drawing.Size(61, 13)
        Me.lblYourOrder.TabIndex = 14
        Me.lblYourOrder.Text = "Your Order:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(478, 480)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(70, 13)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "Your Total Is:"
        '
        'picBow
        '
        Me.picBow.Image = CType(resources.GetObject("picBow.Image"), System.Drawing.Image)
        Me.picBow.Location = New System.Drawing.Point(258, 107)
        Me.picBow.Name = "picBow"
        Me.picBow.Size = New System.Drawing.Size(63, 36)
        Me.picBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBow.TabIndex = 16
        Me.picBow.TabStop = False
        Me.picBow.Visible = False
        '
        'picNecklace
        '
        Me.picNecklace.Image = CType(resources.GetObject("picNecklace.Image"), System.Drawing.Image)
        Me.picNecklace.Location = New System.Drawing.Point(258, 205)
        Me.picNecklace.Name = "picNecklace"
        Me.picNecklace.Size = New System.Drawing.Size(54, 30)
        Me.picNecklace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNecklace.TabIndex = 17
        Me.picNecklace.TabStop = False
        Me.picNecklace.Visible = False
        '
        'picTutu
        '
        Me.picTutu.Image = CType(resources.GetObject("picTutu.Image"), System.Drawing.Image)
        Me.picTutu.Location = New System.Drawing.Point(240, 241)
        Me.picTutu.Name = "picTutu"
        Me.picTutu.Size = New System.Drawing.Size(81, 60)
        Me.picTutu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTutu.TabIndex = 18
        Me.picTutu.TabStop = False
        Me.picTutu.Visible = False
        '
        'picPurse
        '
        Me.picPurse.Image = CType(resources.GetObject("picPurse.Image"), System.Drawing.Image)
        Me.picPurse.Location = New System.Drawing.Point(195, 241)
        Me.picPurse.Name = "picPurse"
        Me.picPurse.Size = New System.Drawing.Size(50, 52)
        Me.picPurse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPurse.TabIndex = 19
        Me.picPurse.TabStop = False
        Me.picPurse.Visible = False
        '
        'picHat
        '
        Me.picHat.Image = CType(resources.GetObject("picHat.Image"), System.Drawing.Image)
        Me.picHat.Location = New System.Drawing.Point(687, 107)
        Me.picHat.Name = "picHat"
        Me.picHat.Size = New System.Drawing.Size(54, 36)
        Me.picHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHat.TabIndex = 20
        Me.picHat.TabStop = False
        Me.picHat.Visible = False
        '
        'PicBowTie
        '
        Me.PicBowTie.Image = CType(resources.GetObject("PicBowTie.Image"), System.Drawing.Image)
        Me.PicBowTie.Location = New System.Drawing.Point(687, 184)
        Me.PicBowTie.Name = "PicBowTie"
        Me.PicBowTie.Size = New System.Drawing.Size(44, 17)
        Me.PicBowTie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBowTie.TabIndex = 21
        Me.PicBowTie.TabStop = False
        Me.PicBowTie.Visible = False
        '
        'picTie
        '
        Me.picTie.Image = CType(resources.GetObject("picTie.Image"), System.Drawing.Image)
        Me.picTie.Location = New System.Drawing.Point(697, 184)
        Me.picTie.Name = "picTie"
        Me.picTie.Size = New System.Drawing.Size(25, 58)
        Me.picTie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTie.TabIndex = 22
        Me.picTie.TabStop = False
        Me.picTie.Visible = False
        '
        'picZipper
        '
        Me.picZipper.Image = CType(resources.GetObject("picZipper.Image"), System.Drawing.Image)
        Me.picZipper.Location = New System.Drawing.Point(697, 241)
        Me.picZipper.Name = "picZipper"
        Me.picZipper.Size = New System.Drawing.Size(25, 24)
        Me.picZipper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picZipper.TabIndex = 23
        Me.picZipper.TabStop = False
        Me.picZipper.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(837, 531)
        Me.Controls.Add(Me.picZipper)
        Me.Controls.Add(Me.picTie)
        Me.Controls.Add(Me.PicBowTie)
        Me.Controls.Add(Me.picHat)
        Me.Controls.Add(Me.picPurse)
        Me.Controls.Add(Me.picTutu)
        Me.Controls.Add(Me.picNecklace)
        Me.Controls.Add(Me.picBow)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblYourOrder)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBoy)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.picGirl)
        Me.Controls.Add(Me.grbBoy)
        Me.Controls.Add(Me.grbGirl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grbGirl.ResumeLayout(False)
        Me.grbGirl.PerformLayout()
        Me.grbBoy.ResumeLayout(False)
        Me.grbBoy.PerformLayout()
        CType(Me.picGirl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNecklace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTutu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPurse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBowTie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picZipper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbGirl As System.Windows.Forms.GroupBox
    Friend WithEvents chkNecklace As System.Windows.Forms.CheckBox
    Friend WithEvents chkPurse As System.Windows.Forms.CheckBox
    Friend WithEvents chkBow As System.Windows.Forms.CheckBox
    Friend WithEvents chkTutu As System.Windows.Forms.CheckBox
    Friend WithEvents grbBoy As System.Windows.Forms.GroupBox
    Friend WithEvents chkZipper As System.Windows.Forms.CheckBox
    Friend WithEvents chkBowtie As System.Windows.Forms.CheckBox
    Friend WithEvents chkTie As System.Windows.Forms.CheckBox
    Friend WithEvents chkHat As System.Windows.Forms.CheckBox
    Friend WithEvents picGirl As System.Windows.Forms.PictureBox
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picBoy As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblYourOrder As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents picBow As System.Windows.Forms.PictureBox
    Friend WithEvents picNecklace As System.Windows.Forms.PictureBox
    Friend WithEvents picTutu As System.Windows.Forms.PictureBox
    Friend WithEvents picPurse As System.Windows.Forms.PictureBox
    Friend WithEvents picHat As System.Windows.Forms.PictureBox
    Friend WithEvents PicBowTie As System.Windows.Forms.PictureBox
    Friend WithEvents picTie As System.Windows.Forms.PictureBox
    Friend WithEvents picZipper As System.Windows.Forms.PictureBox

End Class
