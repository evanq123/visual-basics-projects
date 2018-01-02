<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllAboutMe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllAboutMe))
        Me.lblMyInfo = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PicMe = New System.Windows.Forms.PictureBox
        Me.PicFriend = New System.Windows.Forms.PictureBox
        Me.chkPhotoMe = New System.Windows.Forms.CheckBox
        Me.chkPhotoFriend = New System.Windows.Forms.CheckBox
        Me.gboxPersonal = New System.Windows.Forms.GroupBox
        Me.rbtFuture = New System.Windows.Forms.RadioButton
        Me.rbtCurrent = New System.Windows.Forms.RadioButton
        Me.rbtEarly = New System.Windows.Forms.RadioButton
        Me.gboxFavorites = New System.Windows.Forms.GroupBox
        Me.rbtComputer = New System.Windows.Forms.RadioButton
        Me.rbtGames = New System.Windows.Forms.RadioButton
        Me.rbtGuitar = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblDescription = New System.Windows.Forms.Label
        CType(Me.PicMe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFriend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxPersonal.SuspendLayout()
        Me.gboxFavorites.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMyInfo
        '
        Me.lblMyInfo.AutoSize = True
        Me.lblMyInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyInfo.ForeColor = System.Drawing.Color.Crimson
        Me.lblMyInfo.Location = New System.Drawing.Point(13, 42)
        Me.lblMyInfo.Name = "lblMyInfo"
        Me.lblMyInfo.Size = New System.Drawing.Size(130, 18)
        Me.lblMyInfo.TabIndex = 0
        Me.lblMyInfo.Text = "(Info will go here)"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblTitle.Location = New System.Drawing.Point(422, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(146, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "About Evan"
        '
        'PicMe
        '
        Me.PicMe.Image = CType(resources.GetObject("PicMe.Image"), System.Drawing.Image)
        Me.PicMe.Location = New System.Drawing.Point(630, 260)
        Me.PicMe.Name = "PicMe"
        Me.PicMe.Size = New System.Drawing.Size(303, 223)
        Me.PicMe.TabIndex = 2
        Me.PicMe.TabStop = False
        Me.PicMe.Visible = False
        '
        'PicFriend
        '
        Me.PicFriend.Image = CType(resources.GetObject("PicFriend.Image"), System.Drawing.Image)
        Me.PicFriend.Location = New System.Drawing.Point(12, 257)
        Me.PicFriend.Name = "PicFriend"
        Me.PicFriend.Size = New System.Drawing.Size(157, 251)
        Me.PicFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFriend.TabIndex = 3
        Me.PicFriend.TabStop = False
        Me.PicFriend.Visible = False
        '
        'chkPhotoMe
        '
        Me.chkPhotoMe.AutoSize = True
        Me.chkPhotoMe.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPhotoMe.ForeColor = System.Drawing.Color.Turquoise
        Me.chkPhotoMe.Location = New System.Drawing.Point(50, 232)
        Me.chkPhotoMe.Name = "chkPhotoMe"
        Me.chkPhotoMe.Size = New System.Drawing.Size(74, 22)
        Me.chkPhotoMe.TabIndex = 4
        Me.chkPhotoMe.Text = "My Pic"
        Me.chkPhotoMe.UseVisualStyleBackColor = True
        '
        'chkPhotoFriend
        '
        Me.chkPhotoFriend.AutoSize = True
        Me.chkPhotoFriend.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPhotoFriend.ForeColor = System.Drawing.Color.Turquoise
        Me.chkPhotoFriend.Location = New System.Drawing.Point(816, 232)
        Me.chkPhotoFriend.Name = "chkPhotoFriend"
        Me.chkPhotoFriend.Size = New System.Drawing.Size(107, 22)
        Me.chkPhotoFriend.TabIndex = 5
        Me.chkPhotoFriend.Text = "Friend's Pic"
        Me.chkPhotoFriend.UseVisualStyleBackColor = True
        '
        'gboxPersonal
        '
        Me.gboxPersonal.Controls.Add(Me.rbtFuture)
        Me.gboxPersonal.Controls.Add(Me.rbtCurrent)
        Me.gboxPersonal.Controls.Add(Me.rbtEarly)
        Me.gboxPersonal.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxPersonal.ForeColor = System.Drawing.Color.Teal
        Me.gboxPersonal.Location = New System.Drawing.Point(16, 132)
        Me.gboxPersonal.Name = "gboxPersonal"
        Me.gboxPersonal.Size = New System.Drawing.Size(114, 94)
        Me.gboxPersonal.TabIndex = 6
        Me.gboxPersonal.TabStop = False
        Me.gboxPersonal.Text = "Personal"
        '
        'rbtFuture
        '
        Me.rbtFuture.AutoSize = True
        Me.rbtFuture.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFuture.Location = New System.Drawing.Point(6, 66)
        Me.rbtFuture.Name = "rbtFuture"
        Me.rbtFuture.Size = New System.Drawing.Size(111, 22)
        Me.rbtFuture.TabIndex = 2
        Me.rbtFuture.TabStop = True
        Me.rbtFuture.Text = "Future Plans"
        Me.rbtFuture.UseVisualStyleBackColor = True
        '
        'rbtCurrent
        '
        Me.rbtCurrent.AutoSize = True
        Me.rbtCurrent.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCurrent.Location = New System.Drawing.Point(6, 43)
        Me.rbtCurrent.Name = "rbtCurrent"
        Me.rbtCurrent.Size = New System.Drawing.Size(108, 22)
        Me.rbtCurrent.TabIndex = 1
        Me.rbtCurrent.TabStop = True
        Me.rbtCurrent.Text = "Current Life"
        Me.rbtCurrent.UseVisualStyleBackColor = True
        '
        'rbtEarly
        '
        Me.rbtEarly.AutoSize = True
        Me.rbtEarly.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEarly.Location = New System.Drawing.Point(6, 19)
        Me.rbtEarly.Name = "rbtEarly"
        Me.rbtEarly.Size = New System.Drawing.Size(95, 22)
        Me.rbtEarly.TabIndex = 0
        Me.rbtEarly.TabStop = True
        Me.rbtEarly.Text = "Early Life"
        Me.rbtEarly.UseVisualStyleBackColor = True
        '
        'gboxFavorites
        '
        Me.gboxFavorites.Controls.Add(Me.rbtComputer)
        Me.gboxFavorites.Controls.Add(Me.rbtGames)
        Me.gboxFavorites.Controls.Add(Me.rbtGuitar)
        Me.gboxFavorites.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxFavorites.ForeColor = System.Drawing.Color.Teal
        Me.gboxFavorites.Location = New System.Drawing.Point(830, 132)
        Me.gboxFavorites.Name = "gboxFavorites"
        Me.gboxFavorites.Size = New System.Drawing.Size(113, 94)
        Me.gboxFavorites.TabIndex = 7
        Me.gboxFavorites.TabStop = False
        Me.gboxFavorites.Text = "Favorites"
        '
        'rbtComputer
        '
        Me.rbtComputer.AutoSize = True
        Me.rbtComputer.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtComputer.Location = New System.Drawing.Point(6, 66)
        Me.rbtComputer.Name = "rbtComputer"
        Me.rbtComputer.Size = New System.Drawing.Size(87, 22)
        Me.rbtComputer.TabIndex = 4
        Me.rbtComputer.TabStop = True
        Me.rbtComputer.Text = "Computer"
        Me.rbtComputer.UseVisualStyleBackColor = True
        '
        'rbtGames
        '
        Me.rbtGames.AutoSize = True
        Me.rbtGames.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtGames.Location = New System.Drawing.Point(6, 43)
        Me.rbtGames.Name = "rbtGames"
        Me.rbtGames.Size = New System.Drawing.Size(68, 22)
        Me.rbtGames.TabIndex = 3
        Me.rbtGames.TabStop = True
        Me.rbtGames.Text = "Games"
        Me.rbtGames.UseVisualStyleBackColor = True
        '
        'rbtGuitar
        '
        Me.rbtGuitar.AutoSize = True
        Me.rbtGuitar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtGuitar.Location = New System.Drawing.Point(6, 20)
        Me.rbtGuitar.Name = "rbtGuitar"
        Me.rbtGuitar.Size = New System.Drawing.Size(68, 22)
        Me.rbtGuitar.TabIndex = 3
        Me.rbtGuitar.TabStop = True
        Me.rbtGuitar.Text = "Guitar"
        Me.rbtGuitar.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(868, 501)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(13, 511)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(124, 13)
        Me.lblDescription.TabIndex = 9
        Me.lblDescription.Text = "Evan Quach, Program, 3"
        '
        'AllAboutMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 536)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gboxFavorites)
        Me.Controls.Add(Me.gboxPersonal)
        Me.Controls.Add(Me.chkPhotoFriend)
        Me.Controls.Add(Me.chkPhotoMe)
        Me.Controls.Add(Me.PicFriend)
        Me.Controls.Add(Me.PicMe)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblMyInfo)
        Me.Name = "AllAboutMe"
        Me.Text = "All About Me"
        CType(Me.PicMe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFriend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxPersonal.ResumeLayout(False)
        Me.gboxPersonal.PerformLayout()
        Me.gboxFavorites.ResumeLayout(False)
        Me.gboxFavorites.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMyInfo As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PicMe As System.Windows.Forms.PictureBox
    Friend WithEvents PicFriend As System.Windows.Forms.PictureBox
    Friend WithEvents chkPhotoMe As System.Windows.Forms.CheckBox
    Friend WithEvents chkPhotoFriend As System.Windows.Forms.CheckBox
    Friend WithEvents gboxPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCurrent As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEarly As System.Windows.Forms.RadioButton
    Friend WithEvents gboxFavorites As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents rbtFuture As System.Windows.Forms.RadioButton
    Friend WithEvents rbtComputer As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGames As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGuitar As System.Windows.Forms.RadioButton
    Friend WithEvents lblDescription As System.Windows.Forms.Label

End Class
