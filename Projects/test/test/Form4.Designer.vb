<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm3))
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblHumptyDumptyHad = New System.Windows.Forms.Label
        Me.picHumptyDumpty = New System.Windows.Forms.PictureBox
        Me.lblAGreatFall = New System.Windows.Forms.Label
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picHumptyDumpty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(356, 454)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblHumptyDumptyHad
        '
        Me.lblHumptyDumptyHad.AutoSize = True
        Me.lblHumptyDumptyHad.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumptyDumptyHad.Location = New System.Drawing.Point(12, 9)
        Me.lblHumptyDumptyHad.Name = "lblHumptyDumptyHad"
        Me.lblHumptyDumptyHad.Size = New System.Drawing.Size(419, 57)
        Me.lblHumptyDumptyHad.TabIndex = 1
        Me.lblHumptyDumptyHad.Text = "Humpty Dumpty Had"
        '
        'picHumptyDumpty
        '
        Me.picHumptyDumpty.Image = CType(resources.GetObject("picHumptyDumpty.Image"), System.Drawing.Image)
        Me.picHumptyDumpty.Location = New System.Drawing.Point(168, 151)
        Me.picHumptyDumpty.Name = "picHumptyDumpty"
        Me.picHumptyDumpty.Size = New System.Drawing.Size(100, 128)
        Me.picHumptyDumpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHumptyDumpty.TabIndex = 2
        Me.picHumptyDumpty.TabStop = False
        '
        'lblAGreatFall
        '
        Me.lblAGreatFall.AutoSize = True
        Me.lblAGreatFall.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAGreatFall.Location = New System.Drawing.Point(12, 66)
        Me.lblAGreatFall.Name = "lblAGreatFall"
        Me.lblAGreatFall.Size = New System.Drawing.Size(256, 57)
        Me.lblAGreatFall.TabIndex = 3
        Me.lblAGreatFall.Text = "A Great Fall"
        '
        'tmr1
        '
        Me.tmr1.Enabled = True
        '
        'tmr2
        '
        Me.tmr2.Enabled = True
        '
        'tmr3
        '
        Me.tmr3.Enabled = True
        '
        'tmr4
        '
        Me.tmr4.Enabled = True
        Me.tmr4.Interval = 50
        '
        'frm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(452, 489)
        Me.Controls.Add(Me.lblAGreatFall)
        Me.Controls.Add(Me.picHumptyDumpty)
        Me.Controls.Add(Me.lblHumptyDumptyHad)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frm3"
        Me.Text = "Page 3"
        CType(Me.picHumptyDumpty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblHumptyDumptyHad As System.Windows.Forms.Label
    Friend WithEvents picHumptyDumpty As System.Windows.Forms.PictureBox
    Friend WithEvents lblAGreatFall As System.Windows.Forms.Label
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents tmr2 As System.Windows.Forms.Timer
    Friend WithEvents tmr4 As System.Windows.Forms.Timer
    Friend WithEvents tmr3 As System.Windows.Forms.Timer
End Class
