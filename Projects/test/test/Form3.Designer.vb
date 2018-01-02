<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm2))
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblSatonawall = New System.Windows.Forms.Label
        Me.picHumptyDumpty = New System.Windows.Forms.PictureBox
        Me.picWall = New System.Windows.Forms.PictureBox
        CType(Me.picHumptyDumpty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(434, 362)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblSatonawall
        '
        Me.lblSatonawall.AutoSize = True
        Me.lblSatonawall.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSatonawall.Location = New System.Drawing.Point(12, 9)
        Me.lblSatonawall.Name = "lblSatonawall"
        Me.lblSatonawall.Size = New System.Drawing.Size(314, 57)
        Me.lblSatonawall.TabIndex = 1
        Me.lblSatonawall.Text = "...Sat on a wall."
        '
        'picHumptyDumpty
        '
        Me.picHumptyDumpty.Image = CType(resources.GetObject("picHumptyDumpty.Image"), System.Drawing.Image)
        Me.picHumptyDumpty.Location = New System.Drawing.Point(355, 58)
        Me.picHumptyDumpty.Name = "picHumptyDumpty"
        Me.picHumptyDumpty.Size = New System.Drawing.Size(136, 106)
        Me.picHumptyDumpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHumptyDumpty.TabIndex = 2
        Me.picHumptyDumpty.TabStop = False
        '
        'picWall
        '
        Me.picWall.Image = CType(resources.GetObject("picWall.Image"), System.Drawing.Image)
        Me.picWall.Location = New System.Drawing.Point(324, 113)
        Me.picWall.Name = "picWall"
        Me.picWall.Size = New System.Drawing.Size(197, 302)
        Me.picWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWall.TabIndex = 3
        Me.picWall.TabStop = False
        '
        'frm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 397)
        Me.Controls.Add(Me.lblSatonawall)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picHumptyDumpty)
        Me.Controls.Add(Me.picWall)
        Me.Name = "frm2"
        Me.Text = "Page 2"
        CType(Me.picHumptyDumpty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblSatonawall As System.Windows.Forms.Label
    Friend WithEvents picHumptyDumpty As System.Windows.Forms.PictureBox
    Friend WithEvents picWall As System.Windows.Forms.PictureBox
End Class
