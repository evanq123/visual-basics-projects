<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmanimationprogramsyourname
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmanimationprogramsyourname))
        Me.tmrOne = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTwo = New System.Windows.Forms.Timer(Me.components)
        Me.picHappyFace = New System.Windows.Forms.PictureBox
        Me.btnNext = New System.Windows.Forms.Button
        CType(Me.picHappyFace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrOne
        '
        Me.tmrOne.Enabled = True
        '
        'tmrTwo
        '
        '
        'picHappyFace
        '
        Me.picHappyFace.Image = CType(resources.GetObject("picHappyFace.Image"), System.Drawing.Image)
        Me.picHappyFace.Location = New System.Drawing.Point(440, 128)
        Me.picHappyFace.Name = "picHappyFace"
        Me.picHappyFace.Size = New System.Drawing.Size(88, 80)
        Me.picHappyFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHappyFace.TabIndex = 0
        Me.picHappyFace.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(448, 300)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmanimationprogramsyourname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 335)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picHappyFace)
        Me.Name = "frmanimationprogramsyourname"
        Me.Text = "Happy Face"
        CType(Me.picHappyFace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrOne As System.Windows.Forms.Timer
    Friend WithEvents tmrTwo As System.Windows.Forms.Timer
    Friend WithEvents picHappyFace As System.Windows.Forms.PictureBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
End Class
