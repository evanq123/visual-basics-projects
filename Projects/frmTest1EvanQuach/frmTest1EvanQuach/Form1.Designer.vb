<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest1EvanQuach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTest1EvanQuach))
        Me.lblItsJokeTime = New System.Windows.Forms.Label
        Me.lblJoke1 = New System.Windows.Forms.Label
        Me.picChicken = New System.Windows.Forms.PictureBox
        Me.picNewspaper = New System.Windows.Forms.PictureBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.rbtAnswer1 = New System.Windows.Forms.RadioButton
        Me.rbtAnswer2 = New System.Windows.Forms.RadioButton
        Me.lblJoke2 = New System.Windows.Forms.Label
        Me.lblAnswer1 = New System.Windows.Forms.Label
        Me.lblAnswer2 = New System.Windows.Forms.Label
        Me.lblEvanQuach = New System.Windows.Forms.Label
        CType(Me.picChicken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNewspaper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblItsJokeTime
        '
        Me.lblItsJokeTime.AutoSize = True
        Me.lblItsJokeTime.BackColor = System.Drawing.Color.LightBlue
        Me.lblItsJokeTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItsJokeTime.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItsJokeTime.Location = New System.Drawing.Point(131, 34)
        Me.lblItsJokeTime.Name = "lblItsJokeTime"
        Me.lblItsJokeTime.Size = New System.Drawing.Size(284, 54)
        Me.lblItsJokeTime.TabIndex = 0
        Me.lblItsJokeTime.Text = "It's Joke Time"
        '
        'lblJoke1
        '
        Me.lblJoke1.AutoSize = True
        Me.lblJoke1.BackColor = System.Drawing.Color.LightPink
        Me.lblJoke1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJoke1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoke1.Location = New System.Drawing.Point(21, 136)
        Me.lblJoke1.Name = "lblJoke1"
        Me.lblJoke1.Size = New System.Drawing.Size(232, 20)
        Me.lblJoke1.TabIndex = 1
        Me.lblJoke1.Text = "Why did the chicken cross the road?"
        Me.lblJoke1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picChicken
        '
        Me.picChicken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picChicken.Image = CType(resources.GetObject("picChicken.Image"), System.Drawing.Image)
        Me.picChicken.Location = New System.Drawing.Point(50, 196)
        Me.picChicken.Name = "picChicken"
        Me.picChicken.Size = New System.Drawing.Size(203, 179)
        Me.picChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChicken.TabIndex = 5
        Me.picChicken.TabStop = False
        Me.picChicken.Visible = False
        '
        'picNewspaper
        '
        Me.picNewspaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picNewspaper.Image = CType(resources.GetObject("picNewspaper.Image"), System.Drawing.Image)
        Me.picNewspaper.Location = New System.Drawing.Point(308, 196)
        Me.picNewspaper.Name = "picNewspaper"
        Me.picNewspaper.Size = New System.Drawing.Size(220, 179)
        Me.picNewspaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNewspaper.TabIndex = 6
        Me.picNewspaper.TabStop = False
        Me.picNewspaper.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(453, 452)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'rbtAnswer1
        '
        Me.rbtAnswer1.AutoSize = True
        Me.rbtAnswer1.BackColor = System.Drawing.Color.Orange
        Me.rbtAnswer1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.rbtAnswer1.Location = New System.Drawing.Point(107, 168)
        Me.rbtAnswer1.Name = "rbtAnswer1"
        Me.rbtAnswer1.Size = New System.Drawing.Size(75, 23)
        Me.rbtAnswer1.TabIndex = 9
        Me.rbtAnswer1.TabStop = True
        Me.rbtAnswer1.Text = "Answer"
        Me.rbtAnswer1.UseVisualStyleBackColor = False
        '
        'rbtAnswer2
        '
        Me.rbtAnswer2.AutoSize = True
        Me.rbtAnswer2.BackColor = System.Drawing.Color.Orange
        Me.rbtAnswer2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.rbtAnswer2.Location = New System.Drawing.Point(378, 167)
        Me.rbtAnswer2.Name = "rbtAnswer2"
        Me.rbtAnswer2.Size = New System.Drawing.Size(75, 23)
        Me.rbtAnswer2.TabIndex = 10
        Me.rbtAnswer2.TabStop = True
        Me.rbtAnswer2.Text = "Answer"
        Me.rbtAnswer2.UseVisualStyleBackColor = False
        '
        'lblJoke2
        '
        Me.lblJoke2.AutoSize = True
        Me.lblJoke2.BackColor = System.Drawing.Color.LightPink
        Me.lblJoke2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJoke2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoke2.Location = New System.Drawing.Point(279, 136)
        Me.lblJoke2.Name = "lblJoke2"
        Me.lblJoke2.Size = New System.Drawing.Size(249, 20)
        Me.lblJoke2.TabIndex = 11
        Me.lblJoke2.Text = "What's Black, white, and read all over?"
        Me.lblJoke2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnswer1
        '
        Me.lblAnswer1.AutoSize = True
        Me.lblAnswer1.BackColor = System.Drawing.Color.LightPink
        Me.lblAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnswer1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.lblAnswer1.Location = New System.Drawing.Point(61, 378)
        Me.lblAnswer1.Name = "lblAnswer1"
        Me.lblAnswer1.Size = New System.Drawing.Size(169, 21)
        Me.lblAnswer1.TabIndex = 12
        Me.lblAnswer1.Text = "To get to the other side"
        Me.lblAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAnswer1.Visible = False
        '
        'lblAnswer2
        '
        Me.lblAnswer2.AutoSize = True
        Me.lblAnswer2.BackColor = System.Drawing.Color.LightPink
        Me.lblAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnswer2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.lblAnswer2.Location = New System.Drawing.Point(385, 378)
        Me.lblAnswer2.Name = "lblAnswer2"
        Me.lblAnswer2.Size = New System.Drawing.Size(76, 21)
        Me.lblAnswer2.TabIndex = 13
        Me.lblAnswer2.Text = "The News"
        Me.lblAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAnswer2.Visible = False
        '
        'lblEvanQuach
        '
        Me.lblEvanQuach.AutoSize = True
        Me.lblEvanQuach.BackColor = System.Drawing.Color.LightPink
        Me.lblEvanQuach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEvanQuach.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblEvanQuach.Location = New System.Drawing.Point(12, 452)
        Me.lblEvanQuach.Name = "lblEvanQuach"
        Me.lblEvanQuach.Size = New System.Drawing.Size(168, 17)
        Me.lblEvanQuach.TabIndex = 14
        Me.lblEvanQuach.Text = "Evan Quach Period 3 Ch.3 Test"
        Me.lblEvanQuach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTest1EvanQuach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(557, 487)
        Me.Controls.Add(Me.lblEvanQuach)
        Me.Controls.Add(Me.lblAnswer2)
        Me.Controls.Add(Me.lblAnswer1)
        Me.Controls.Add(Me.lblJoke2)
        Me.Controls.Add(Me.rbtAnswer2)
        Me.Controls.Add(Me.rbtAnswer1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picNewspaper)
        Me.Controls.Add(Me.picChicken)
        Me.Controls.Add(Me.lblJoke1)
        Me.Controls.Add(Me.lblItsJokeTime)
        Me.Name = "frmTest1EvanQuach"
        Me.Text = "Joke Time"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picChicken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNewspaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblItsJokeTime As System.Windows.Forms.Label
    Friend WithEvents lblJoke1 As System.Windows.Forms.Label
    Friend WithEvents picChicken As System.Windows.Forms.PictureBox
    Friend WithEvents picNewspaper As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents rbtAnswer1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAnswer2 As System.Windows.Forms.RadioButton
    Friend WithEvents lblJoke2 As System.Windows.Forms.Label
    Friend WithEvents lblAnswer1 As System.Windows.Forms.Label
    Friend WithEvents lblAnswer2 As System.Windows.Forms.Label
    Friend WithEvents lblEvanQuach As System.Windows.Forms.Label

End Class
