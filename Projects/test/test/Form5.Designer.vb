<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm4))
        Me.lblAllTheKingsHorses = New System.Windows.Forms.Label
        Me.lblAndall = New System.Windows.Forms.Label
        Me.picHorse = New System.Windows.Forms.PictureBox
        Me.picHumpty = New System.Windows.Forms.PictureBox
        Me.picKingsMen = New System.Windows.Forms.PictureBox
        Me.btnNext = New System.Windows.Forms.Button
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picHorse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHumpty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingsMen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAllTheKingsHorses
        '
        Me.lblAllTheKingsHorses.AutoSize = True
        Me.lblAllTheKingsHorses.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllTheKingsHorses.Location = New System.Drawing.Point(0, 0)
        Me.lblAllTheKingsHorses.Name = "lblAllTheKingsHorses"
        Me.lblAllTheKingsHorses.Size = New System.Drawing.Size(384, 57)
        Me.lblAllTheKingsHorses.TabIndex = 0
        Me.lblAllTheKingsHorses.Text = "All the Kings horses"
        '
        'lblAndall
        '
        Me.lblAndall.AutoSize = True
        Me.lblAndall.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAndall.Location = New System.Drawing.Point(0, 57)
        Me.lblAndall.Name = "lblAndall"
        Me.lblAndall.Size = New System.Drawing.Size(406, 57)
        Me.lblAndall.TabIndex = 1
        Me.lblAndall.Text = "and all the kings men"
        '
        'picHorse
        '
        Me.picHorse.Image = CType(resources.GetObject("picHorse.Image"), System.Drawing.Image)
        Me.picHorse.Location = New System.Drawing.Point(3, 145)
        Me.picHorse.Name = "picHorse"
        Me.picHorse.Size = New System.Drawing.Size(202, 180)
        Me.picHorse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHorse.TabIndex = 2
        Me.picHorse.TabStop = False
        '
        'picHumpty
        '
        Me.picHumpty.Image = CType(resources.GetObject("picHumpty.Image"), System.Drawing.Image)
        Me.picHumpty.Location = New System.Drawing.Point(143, 239)
        Me.picHumpty.Name = "picHumpty"
        Me.picHumpty.Size = New System.Drawing.Size(171, 142)
        Me.picHumpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHumpty.TabIndex = 3
        Me.picHumpty.TabStop = False
        '
        'picKingsMen
        '
        Me.picKingsMen.Image = CType(resources.GetObject("picKingsMen.Image"), System.Drawing.Image)
        Me.picKingsMen.Location = New System.Drawing.Point(320, 138)
        Me.picKingsMen.Name = "picKingsMen"
        Me.picKingsMen.Size = New System.Drawing.Size(134, 187)
        Me.picKingsMen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingsMen.TabIndex = 4
        Me.picKingsMen.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(389, 388)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'tmr1
        '
        Me.tmr1.Enabled = True
        '
        'frm4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 423)
        Me.Controls.Add(Me.picHumpty)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picKingsMen)
        Me.Controls.Add(Me.picHorse)
        Me.Controls.Add(Me.lblAndall)
        Me.Controls.Add(Me.lblAllTheKingsHorses)
        Me.Name = "frm4"
        Me.Text = "Page 4"
        CType(Me.picHorse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHumpty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingsMen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAllTheKingsHorses As System.Windows.Forms.Label
    Friend WithEvents lblAndall As System.Windows.Forms.Label
    Friend WithEvents picHorse As System.Windows.Forms.PictureBox
    Friend WithEvents picHumpty As System.Windows.Forms.PictureBox
    Friend WithEvents picKingsMen As System.Windows.Forms.PictureBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
End Class
