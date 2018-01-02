<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.piccar = New System.Windows.Forms.PictureBox
        Me.Tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tmr2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.piccar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'piccar
        '
        Me.piccar.Image = CType(resources.GetObject("piccar.Image"), System.Drawing.Image)
        Me.piccar.Location = New System.Drawing.Point(89, 60)
        Me.piccar.Name = "piccar"
        Me.piccar.Size = New System.Drawing.Size(451, 308)
        Me.piccar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccar.TabIndex = 0
        Me.piccar.TabStop = False
        '
        'Tmr1
        '
        Me.Tmr1.Enabled = True
        '
        'Tmr2
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 493)
        Me.Controls.Add(Me.piccar)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.piccar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents piccar As System.Windows.Forms.PictureBox
    Friend WithEvents Tmr1 As System.Windows.Forms.Timer
    Friend WithEvents Tmr2 As System.Windows.Forms.Timer
End Class
