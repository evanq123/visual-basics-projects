<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.lblHumptyDumpty = New System.Windows.Forms.Label
        Me.picHumptyDumpty = New System.Windows.Forms.PictureBox
        Me.BtnNext = New System.Windows.Forms.Button
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picHumptyDumpty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHumptyDumpty
        '
        Me.lblHumptyDumpty.AutoSize = True
        Me.lblHumptyDumpty.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumptyDumpty.Location = New System.Drawing.Point(0, 0)
        Me.lblHumptyDumpty.Name = "lblHumptyDumpty"
        Me.lblHumptyDumpty.Size = New System.Drawing.Size(366, 57)
        Me.lblHumptyDumpty.TabIndex = 0
        Me.lblHumptyDumpty.Text = "Humpty Dumpty..."
        '
        'picHumptyDumpty
        '
        Me.picHumptyDumpty.Image = CType(resources.GetObject("picHumptyDumpty.Image"), System.Drawing.Image)
        Me.picHumptyDumpty.Location = New System.Drawing.Point(12, 74)
        Me.picHumptyDumpty.Name = "picHumptyDumpty"
        Me.picHumptyDumpty.Size = New System.Drawing.Size(100, 136)
        Me.picHumptyDumpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHumptyDumpty.TabIndex = 1
        Me.picHumptyDumpty.TabStop = False
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(337, 237)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 2
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = True
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
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 272)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.picHumptyDumpty)
        Me.Controls.Add(Me.lblHumptyDumpty)
        Me.Name = "frm1"
        Me.Text = "Page 1"
        CType(Me.picHumptyDumpty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHumptyDumpty As System.Windows.Forms.Label
    Friend WithEvents picHumptyDumpty As System.Windows.Forms.PictureBox
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents tmr2 As System.Windows.Forms.Timer
    Friend WithEvents tmr3 As System.Windows.Forms.Timer
End Class
