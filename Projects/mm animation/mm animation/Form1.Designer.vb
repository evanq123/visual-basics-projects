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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picsnow1 = New System.Windows.Forms.PictureBox
        Me.picmmr = New System.Windows.Forms.PictureBox
        Me.picmml = New System.Windows.Forms.PictureBox
        Me.picswitch = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.picsnow3 = New System.Windows.Forms.PictureBox
        Me.picsnow2 = New System.Windows.Forms.PictureBox
        CType(Me.picsnow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picmmr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picmml, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picswitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsnow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsnow2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picsnow1
        '
        Me.picsnow1.Image = CType(resources.GetObject("picsnow1.Image"), System.Drawing.Image)
        Me.picsnow1.Location = New System.Drawing.Point(23, 12)
        Me.picsnow1.Name = "picsnow1"
        Me.picsnow1.Size = New System.Drawing.Size(58, 50)
        Me.picsnow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsnow1.TabIndex = 1
        Me.picsnow1.TabStop = False
        '
        'picmmr
        '
        Me.picmmr.Image = CType(resources.GetObject("picmmr.Image"), System.Drawing.Image)
        Me.picmmr.Location = New System.Drawing.Point(260, 91)
        Me.picmmr.Name = "picmmr"
        Me.picmmr.Size = New System.Drawing.Size(83, 77)
        Me.picmmr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picmmr.TabIndex = 3
        Me.picmmr.TabStop = False
        '
        'picmml
        '
        Me.picmml.Image = CType(resources.GetObject("picmml.Image"), System.Drawing.Image)
        Me.picmml.Location = New System.Drawing.Point(84, 161)
        Me.picmml.Name = "picmml"
        Me.picmml.Size = New System.Drawing.Size(83, 77)
        Me.picmml.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picmml.TabIndex = 4
        Me.picmml.TabStop = False
        '
        'picswitch
        '
        Me.picswitch.Image = CType(resources.GetObject("picswitch.Image"), System.Drawing.Image)
        Me.picswitch.Location = New System.Drawing.Point(260, 302)
        Me.picswitch.Name = "picswitch"
        Me.picswitch.Size = New System.Drawing.Size(83, 77)
        Me.picswitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picswitch.TabIndex = 5
        Me.picswitch.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 300
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 750
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 750
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 500
        '
        'picsnow3
        '
        Me.picsnow3.Image = CType(resources.GetObject("picsnow3.Image"), System.Drawing.Image)
        Me.picsnow3.Location = New System.Drawing.Point(358, 12)
        Me.picsnow3.Name = "picsnow3"
        Me.picsnow3.Size = New System.Drawing.Size(58, 50)
        Me.picsnow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsnow3.TabIndex = 6
        Me.picsnow3.TabStop = False
        '
        'picsnow2
        '
        Me.picsnow2.Image = CType(resources.GetObject("picsnow2.Image"), System.Drawing.Image)
        Me.picsnow2.Location = New System.Drawing.Point(183, 12)
        Me.picsnow2.Name = "picsnow2"
        Me.picsnow2.Size = New System.Drawing.Size(58, 50)
        Me.picsnow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsnow2.TabIndex = 7
        Me.picsnow2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(448, 406)
        Me.Controls.Add(Me.picsnow2)
        Me.Controls.Add(Me.picsnow3)
        Me.Controls.Add(Me.picswitch)
        Me.Controls.Add(Me.picmml)
        Me.Controls.Add(Me.picmmr)
        Me.Controls.Add(Me.picsnow1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picsnow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picmmr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picmml, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picswitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsnow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsnow2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picsnow1 As System.Windows.Forms.PictureBox
    Friend WithEvents picmmr As System.Windows.Forms.PictureBox
    Friend WithEvents picmml As System.Windows.Forms.PictureBox
    Friend WithEvents picswitch As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents picsnow3 As System.Windows.Forms.PictureBox
    Friend WithEvents picsnow2 As System.Windows.Forms.PictureBox

End Class
