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
        Me.lblCatchCriminal = New System.Windows.Forms.Label
        Me.lblWitnessName = New System.Windows.Forms.Label
        Me.lblNameHEre = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboHairColor = New System.Windows.Forms.ComboBox
        Me.cboEyeColor = New System.Windows.Forms.ComboBox
        Me.cboHairStyle = New System.Windows.Forms.ComboBox
        Me.cboOtherFeatures = New System.Windows.Forms.ComboBox
        Me.cboMouth = New System.Windows.Forms.ComboBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.picFace = New System.Windows.Forms.PictureBox
        Me.picLonghairBlonde = New System.Windows.Forms.PictureBox
        Me.picLongHairBrown = New System.Windows.Forms.PictureBox
        Me.picLongHairMultiColor = New System.Windows.Forms.PictureBox
        Me.picMessyHairblonde = New System.Windows.Forms.PictureBox
        Me.picMessyHairBrown = New System.Windows.Forms.PictureBox
        Me.picMessyHairMulti = New System.Windows.Forms.PictureBox
        Me.picslickedbackhairblonde = New System.Windows.Forms.PictureBox
        Me.picSlickedBackHairBrown = New System.Windows.Forms.PictureBox
        Me.picSlickedBackHairMulti = New System.Windows.Forms.PictureBox
        Me.picBlueEyes = New System.Windows.Forms.PictureBox
        Me.picBrownEyes = New System.Windows.Forms.PictureBox
        Me.picGreenEyes = New System.Windows.Forms.PictureBox
        Me.picMouth = New System.Windows.Forms.PictureBox
        Me.picMouthBeard = New System.Windows.Forms.PictureBox
        Me.picMouthMustache = New System.Windows.Forms.PictureBox
        Me.picnose = New System.Windows.Forms.PictureBox
        Me.picScar = New System.Windows.Forms.PictureBox
        Me.picEyePatch = New System.Windows.Forms.PictureBox
        CType(Me.picFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLonghairBlonde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLongHairBrown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLongHairMultiColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMessyHairblonde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMessyHairBrown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMessyHairMulti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picslickedbackhairblonde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlickedBackHairBrown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlickedBackHairMulti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlueEyes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrownEyes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreenEyes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMouth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMouthBeard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMouthMustache, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picnose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEyePatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCatchCriminal
        '
        Me.lblCatchCriminal.AutoSize = True
        Me.lblCatchCriminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatchCriminal.Location = New System.Drawing.Point(20, 9)
        Me.lblCatchCriminal.Name = "lblCatchCriminal"
        Me.lblCatchCriminal.Size = New System.Drawing.Size(213, 25)
        Me.lblCatchCriminal.TabIndex = 0
        Me.lblCatchCriminal.Text = "Catch the Criminal!"
        '
        'lblWitnessName
        '
        Me.lblWitnessName.AutoSize = True
        Me.lblWitnessName.Location = New System.Drawing.Point(29, 44)
        Me.lblWitnessName.Name = "lblWitnessName"
        Me.lblWitnessName.Size = New System.Drawing.Size(106, 13)
        Me.lblWitnessName.TabIndex = 1
        Me.lblWitnessName.Text = "Name of the Witness"
        '
        'lblNameHEre
        '
        Me.lblNameHEre.AutoSize = True
        Me.lblNameHEre.Location = New System.Drawing.Point(29, 57)
        Me.lblNameHEre.Name = "lblNameHEre"
        Me.lblNameHEre.Size = New System.Drawing.Size(91, 13)
        Me.lblNameHEre.TabIndex = 2
        Me.lblNameHEre.Text = "(Name goes here)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Evan Quach 3 4/9/14"
        '
        'cboHairColor
        '
        Me.cboHairColor.FormattingEnabled = True
        Me.cboHairColor.Items.AddRange(New Object() {"brown", "blond", "multicolored"})
        Me.cboHairColor.Location = New System.Drawing.Point(25, 223)
        Me.cboHairColor.Name = "cboHairColor"
        Me.cboHairColor.Size = New System.Drawing.Size(121, 21)
        Me.cboHairColor.TabIndex = 4
        Me.cboHairColor.Text = "HAIR COLOR"
        '
        'cboEyeColor
        '
        Me.cboEyeColor.FormattingEnabled = True
        Me.cboEyeColor.Items.AddRange(New Object() {"blue", "brown", "green"})
        Me.cboEyeColor.Location = New System.Drawing.Point(25, 169)
        Me.cboEyeColor.Name = "cboEyeColor"
        Me.cboEyeColor.Size = New System.Drawing.Size(121, 21)
        Me.cboEyeColor.TabIndex = 5
        Me.cboEyeColor.Text = "EYE COLOR"
        '
        'cboHairStyle
        '
        Me.cboHairStyle.FormattingEnabled = True
        Me.cboHairStyle.Items.AddRange(New Object() {"long", "slicked back", "messy"})
        Me.cboHairStyle.Location = New System.Drawing.Point(25, 196)
        Me.cboHairStyle.Name = "cboHairStyle"
        Me.cboHairStyle.Size = New System.Drawing.Size(121, 21)
        Me.cboHairStyle.TabIndex = 6
        Me.cboHairStyle.Text = "HAIRSTYLE"
        '
        'cboOtherFeatures
        '
        Me.cboOtherFeatures.FormattingEnabled = True
        Me.cboOtherFeatures.Items.AddRange(New Object() {"nose", "eyepatch", "scar"})
        Me.cboOtherFeatures.Location = New System.Drawing.Point(25, 277)
        Me.cboOtherFeatures.Name = "cboOtherFeatures"
        Me.cboOtherFeatures.Size = New System.Drawing.Size(121, 21)
        Me.cboOtherFeatures.TabIndex = 7
        Me.cboOtherFeatures.Text = "OtherFeatures"
        '
        'cboMouth
        '
        Me.cboMouth.FormattingEnabled = True
        Me.cboMouth.Items.AddRange(New Object() {"plain", "mustache", "beard"})
        Me.cboMouth.Location = New System.Drawing.Point(25, 250)
        Me.cboMouth.Name = "cboMouth"
        Me.cboMouth.Size = New System.Drawing.Size(121, 21)
        Me.cboMouth.TabIndex = 8
        Me.cboMouth.Text = "MOUTH"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(590, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picFace
        '
        Me.picFace.Image = CType(resources.GetObject("picFace.Image"), System.Drawing.Image)
        Me.picFace.Location = New System.Drawing.Point(269, 9)
        Me.picFace.Name = "picFace"
        Me.picFace.Size = New System.Drawing.Size(374, 309)
        Me.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFace.TabIndex = 10
        Me.picFace.TabStop = False
        '
        'picLonghairBlonde
        '
        Me.picLonghairBlonde.Image = CType(resources.GetObject("picLonghairBlonde.Image"), System.Drawing.Image)
        Me.picLonghairBlonde.Location = New System.Drawing.Point(269, 9)
        Me.picLonghairBlonde.Name = "picLonghairBlonde"
        Me.picLonghairBlonde.Size = New System.Drawing.Size(374, 309)
        Me.picLonghairBlonde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLonghairBlonde.TabIndex = 11
        Me.picLonghairBlonde.TabStop = False
        Me.picLonghairBlonde.Visible = False
        '
        'picLongHairBrown
        '
        Me.picLongHairBrown.Image = CType(resources.GetObject("picLongHairBrown.Image"), System.Drawing.Image)
        Me.picLongHairBrown.Location = New System.Drawing.Point(269, 9)
        Me.picLongHairBrown.Name = "picLongHairBrown"
        Me.picLongHairBrown.Size = New System.Drawing.Size(374, 309)
        Me.picLongHairBrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLongHairBrown.TabIndex = 12
        Me.picLongHairBrown.TabStop = False
        Me.picLongHairBrown.Visible = False
        '
        'picLongHairMultiColor
        '
        Me.picLongHairMultiColor.Image = CType(resources.GetObject("picLongHairMultiColor.Image"), System.Drawing.Image)
        Me.picLongHairMultiColor.Location = New System.Drawing.Point(269, 12)
        Me.picLongHairMultiColor.Name = "picLongHairMultiColor"
        Me.picLongHairMultiColor.Size = New System.Drawing.Size(374, 309)
        Me.picLongHairMultiColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLongHairMultiColor.TabIndex = 13
        Me.picLongHairMultiColor.TabStop = False
        Me.picLongHairMultiColor.Visible = False
        '
        'picMessyHairblonde
        '
        Me.picMessyHairblonde.Image = CType(resources.GetObject("picMessyHairblonde.Image"), System.Drawing.Image)
        Me.picMessyHairblonde.Location = New System.Drawing.Point(269, 9)
        Me.picMessyHairblonde.Name = "picMessyHairblonde"
        Me.picMessyHairblonde.Size = New System.Drawing.Size(374, 309)
        Me.picMessyHairblonde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMessyHairblonde.TabIndex = 14
        Me.picMessyHairblonde.TabStop = False
        Me.picMessyHairblonde.Visible = False
        '
        'picMessyHairBrown
        '
        Me.picMessyHairBrown.Image = CType(resources.GetObject("picMessyHairBrown.Image"), System.Drawing.Image)
        Me.picMessyHairBrown.Location = New System.Drawing.Point(269, 9)
        Me.picMessyHairBrown.Name = "picMessyHairBrown"
        Me.picMessyHairBrown.Size = New System.Drawing.Size(374, 309)
        Me.picMessyHairBrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMessyHairBrown.TabIndex = 15
        Me.picMessyHairBrown.TabStop = False
        Me.picMessyHairBrown.Visible = False
        '
        'picMessyHairMulti
        '
        Me.picMessyHairMulti.Image = CType(resources.GetObject("picMessyHairMulti.Image"), System.Drawing.Image)
        Me.picMessyHairMulti.Location = New System.Drawing.Point(269, 9)
        Me.picMessyHairMulti.Name = "picMessyHairMulti"
        Me.picMessyHairMulti.Size = New System.Drawing.Size(374, 309)
        Me.picMessyHairMulti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMessyHairMulti.TabIndex = 16
        Me.picMessyHairMulti.TabStop = False
        Me.picMessyHairMulti.Visible = False
        '
        'picslickedbackhairblonde
        '
        Me.picslickedbackhairblonde.Image = CType(resources.GetObject("picslickedbackhairblonde.Image"), System.Drawing.Image)
        Me.picslickedbackhairblonde.Location = New System.Drawing.Point(269, 0)
        Me.picslickedbackhairblonde.Name = "picslickedbackhairblonde"
        Me.picslickedbackhairblonde.Size = New System.Drawing.Size(374, 309)
        Me.picslickedbackhairblonde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picslickedbackhairblonde.TabIndex = 17
        Me.picslickedbackhairblonde.TabStop = False
        Me.picslickedbackhairblonde.Visible = False
        '
        'picSlickedBackHairBrown
        '
        Me.picSlickedBackHairBrown.Image = CType(resources.GetObject("picSlickedBackHairBrown.Image"), System.Drawing.Image)
        Me.picSlickedBackHairBrown.Location = New System.Drawing.Point(269, 9)
        Me.picSlickedBackHairBrown.Name = "picSlickedBackHairBrown"
        Me.picSlickedBackHairBrown.Size = New System.Drawing.Size(374, 309)
        Me.picSlickedBackHairBrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSlickedBackHairBrown.TabIndex = 18
        Me.picSlickedBackHairBrown.TabStop = False
        Me.picSlickedBackHairBrown.Visible = False
        '
        'picSlickedBackHairMulti
        '
        Me.picSlickedBackHairMulti.Image = CType(resources.GetObject("picSlickedBackHairMulti.Image"), System.Drawing.Image)
        Me.picSlickedBackHairMulti.Location = New System.Drawing.Point(269, 12)
        Me.picSlickedBackHairMulti.Name = "picSlickedBackHairMulti"
        Me.picSlickedBackHairMulti.Size = New System.Drawing.Size(374, 309)
        Me.picSlickedBackHairMulti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSlickedBackHairMulti.TabIndex = 19
        Me.picSlickedBackHairMulti.TabStop = False
        Me.picSlickedBackHairMulti.Visible = False
        '
        'picBlueEyes
        '
        Me.picBlueEyes.Image = CType(resources.GetObject("picBlueEyes.Image"), System.Drawing.Image)
        Me.picBlueEyes.Location = New System.Drawing.Point(413, 87)
        Me.picBlueEyes.Name = "picBlueEyes"
        Me.picBlueEyes.Size = New System.Drawing.Size(98, 51)
        Me.picBlueEyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlueEyes.TabIndex = 20
        Me.picBlueEyes.TabStop = False
        Me.picBlueEyes.Visible = False
        '
        'picBrownEyes
        '
        Me.picBrownEyes.Image = CType(resources.GetObject("picBrownEyes.Image"), System.Drawing.Image)
        Me.picBrownEyes.Location = New System.Drawing.Point(413, 87)
        Me.picBrownEyes.Name = "picBrownEyes"
        Me.picBrownEyes.Size = New System.Drawing.Size(98, 54)
        Me.picBrownEyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrownEyes.TabIndex = 21
        Me.picBrownEyes.TabStop = False
        Me.picBrownEyes.Visible = False
        '
        'picGreenEyes
        '
        Me.picGreenEyes.Image = CType(resources.GetObject("picGreenEyes.Image"), System.Drawing.Image)
        Me.picGreenEyes.Location = New System.Drawing.Point(413, 87)
        Me.picGreenEyes.Name = "picGreenEyes"
        Me.picGreenEyes.Size = New System.Drawing.Size(98, 51)
        Me.picGreenEyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGreenEyes.TabIndex = 22
        Me.picGreenEyes.TabStop = False
        Me.picGreenEyes.Visible = False
        '
        'picMouth
        '
        Me.picMouth.Image = CType(resources.GetObject("picMouth.Image"), System.Drawing.Image)
        Me.picMouth.Location = New System.Drawing.Point(391, 207)
        Me.picMouth.Name = "picMouth"
        Me.picMouth.Size = New System.Drawing.Size(120, 46)
        Me.picMouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMouth.TabIndex = 23
        Me.picMouth.TabStop = False
        Me.picMouth.Visible = False
        '
        'picMouthBeard
        '
        Me.picMouthBeard.Image = CType(resources.GetObject("picMouthBeard.Image"), System.Drawing.Image)
        Me.picMouthBeard.Location = New System.Drawing.Point(391, 207)
        Me.picMouthBeard.Name = "picMouthBeard"
        Me.picMouthBeard.Size = New System.Drawing.Size(120, 64)
        Me.picMouthBeard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMouthBeard.TabIndex = 24
        Me.picMouthBeard.TabStop = False
        Me.picMouthBeard.Visible = False
        '
        'picMouthMustache
        '
        Me.picMouthMustache.Image = CType(resources.GetObject("picMouthMustache.Image"), System.Drawing.Image)
        Me.picMouthMustache.Location = New System.Drawing.Point(391, 207)
        Me.picMouthMustache.Name = "picMouthMustache"
        Me.picMouthMustache.Size = New System.Drawing.Size(120, 64)
        Me.picMouthMustache.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMouthMustache.TabIndex = 25
        Me.picMouthMustache.TabStop = False
        Me.picMouthMustache.Visible = False
        '
        'picnose
        '
        Me.picnose.Image = CType(resources.GetObject("picnose.Image"), System.Drawing.Image)
        Me.picnose.Location = New System.Drawing.Point(419, 147)
        Me.picnose.Name = "picnose"
        Me.picnose.Size = New System.Drawing.Size(56, 54)
        Me.picnose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picnose.TabIndex = 26
        Me.picnose.TabStop = False
        Me.picnose.Visible = False
        '
        'picScar
        '
        Me.picScar.Image = CType(resources.GetObject("picScar.Image"), System.Drawing.Image)
        Me.picScar.Location = New System.Drawing.Point(481, 147)
        Me.picScar.Name = "picScar"
        Me.picScar.Size = New System.Drawing.Size(41, 70)
        Me.picScar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScar.TabIndex = 27
        Me.picScar.TabStop = False
        Me.picScar.Visible = False
        '
        'picEyePatch
        '
        Me.picEyePatch.Image = CType(resources.GetObject("picEyePatch.Image"), System.Drawing.Image)
        Me.picEyePatch.Location = New System.Drawing.Point(459, 87)
        Me.picEyePatch.Name = "picEyePatch"
        Me.picEyePatch.Size = New System.Drawing.Size(52, 54)
        Me.picEyePatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEyePatch.TabIndex = 28
        Me.picEyePatch.TabStop = False
        Me.picEyePatch.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(677, 352)
        Me.Controls.Add(Me.picEyePatch)
        Me.Controls.Add(Me.picBlueEyes)
        Me.Controls.Add(Me.cboEyeColor)
        Me.Controls.Add(Me.picGreenEyes)
        Me.Controls.Add(Me.picBrownEyes)
        Me.Controls.Add(Me.picMouthBeard)
        Me.Controls.Add(Me.picScar)
        Me.Controls.Add(Me.picnose)
        Me.Controls.Add(Me.picMouth)
        Me.Controls.Add(Me.picMouthMustache)
        Me.Controls.Add(Me.picFace)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboMouth)
        Me.Controls.Add(Me.cboOtherFeatures)
        Me.Controls.Add(Me.cboHairStyle)
        Me.Controls.Add(Me.cboHairColor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNameHEre)
        Me.Controls.Add(Me.lblWitnessName)
        Me.Controls.Add(Me.lblCatchCriminal)
        Me.Controls.Add(Me.picLonghairBlonde)
        Me.Controls.Add(Me.picLongHairBrown)
        Me.Controls.Add(Me.picLongHairMultiColor)
        Me.Controls.Add(Me.picMessyHairblonde)
        Me.Controls.Add(Me.picMessyHairBrown)
        Me.Controls.Add(Me.picMessyHairMulti)
        Me.Controls.Add(Me.picslickedbackhairblonde)
        Me.Controls.Add(Me.picSlickedBackHairBrown)
        Me.Controls.Add(Me.picSlickedBackHairMulti)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLonghairBlonde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLongHairBrown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLongHairMultiColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMessyHairblonde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMessyHairBrown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMessyHairMulti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picslickedbackhairblonde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlickedBackHairBrown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlickedBackHairMulti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlueEyes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrownEyes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreenEyes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMouth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMouthBeard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMouthMustache, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picnose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEyePatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCatchCriminal As System.Windows.Forms.Label
    Friend WithEvents lblWitnessName As System.Windows.Forms.Label
    Friend WithEvents lblNameHEre As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboHairColor As System.Windows.Forms.ComboBox
    Friend WithEvents cboEyeColor As System.Windows.Forms.ComboBox
    Friend WithEvents cboHairStyle As System.Windows.Forms.ComboBox
    Friend WithEvents cboOtherFeatures As System.Windows.Forms.ComboBox
    Friend WithEvents cboMouth As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picFace As System.Windows.Forms.PictureBox
    Friend WithEvents picLonghairBlonde As System.Windows.Forms.PictureBox
    Friend WithEvents picLongHairBrown As System.Windows.Forms.PictureBox
    Friend WithEvents picLongHairMultiColor As System.Windows.Forms.PictureBox
    Friend WithEvents picMessyHairblonde As System.Windows.Forms.PictureBox
    Friend WithEvents picMessyHairBrown As System.Windows.Forms.PictureBox
    Friend WithEvents picMessyHairMulti As System.Windows.Forms.PictureBox
    Friend WithEvents picslickedbackhairblonde As System.Windows.Forms.PictureBox
    Friend WithEvents picSlickedBackHairBrown As System.Windows.Forms.PictureBox
    Friend WithEvents picSlickedBackHairMulti As System.Windows.Forms.PictureBox
    Friend WithEvents picBlueEyes As System.Windows.Forms.PictureBox
    Friend WithEvents picBrownEyes As System.Windows.Forms.PictureBox
    Friend WithEvents picGreenEyes As System.Windows.Forms.PictureBox
    Friend WithEvents picMouth As System.Windows.Forms.PictureBox
    Friend WithEvents picMouthBeard As System.Windows.Forms.PictureBox
    Friend WithEvents picMouthMustache As System.Windows.Forms.PictureBox
    Friend WithEvents picnose As System.Windows.Forms.PictureBox
    Friend WithEvents picScar As System.Windows.Forms.PictureBox
    Friend WithEvents picEyePatch As System.Windows.Forms.PictureBox

End Class
