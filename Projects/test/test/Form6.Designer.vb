<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm5))
        Me.BtnExit = New System.Windows.Forms.Button
        Me.lblCouldnt = New System.Windows.Forms.Label
        Me.lblBackTogether = New System.Windows.Forms.Label
        Me.picRIP = New System.Windows.Forms.PictureBox
        CType(Me.picRIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(334, 427)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "End"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'lblCouldnt
        '
        Me.lblCouldnt.AutoSize = True
        Me.lblCouldnt.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCouldnt.Location = New System.Drawing.Point(10, 9)
        Me.lblCouldnt.Name = "lblCouldnt"
        Me.lblCouldnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCouldnt.Size = New System.Drawing.Size(413, 57)
        Me.lblCouldnt.TabIndex = 1
        Me.lblCouldnt.Text = "Couldn't Put Humpty"
        '
        'lblBackTogether
        '
        Me.lblBackTogether.AutoSize = True
        Me.lblBackTogether.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackTogether.Location = New System.Drawing.Point(10, 76)
        Me.lblBackTogether.Name = "lblBackTogether"
        Me.lblBackTogether.Size = New System.Drawing.Size(399, 57)
        Me.lblBackTogether.TabIndex = 2
        Me.lblBackTogether.Text = "Back Together Again"
        '
        'picRIP
        '
        Me.picRIP.Image = CType(resources.GetObject("picRIP.Image"), System.Drawing.Image)
        Me.picRIP.Location = New System.Drawing.Point(74, 188)
        Me.picRIP.Name = "picRIP"
        Me.picRIP.Size = New System.Drawing.Size(235, 280)
        Me.picRIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRIP.TabIndex = 3
        Me.picRIP.TabStop = False
        '
        'frm5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 462)
        Me.Controls.Add(Me.picRIP)
        Me.Controls.Add(Me.lblBackTogether)
        Me.Controls.Add(Me.lblCouldnt)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "frm5"
        Me.Text = "Page 5"
        CType(Me.picRIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents lblCouldnt As System.Windows.Forms.Label
    Friend WithEvents lblBackTogether As System.Windows.Forms.Label
    Friend WithEvents picRIP As System.Windows.Forms.PictureBox
End Class
