<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnimationProgramsYourName3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnimationProgramsYourName3))
        Me.tmrOne = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTwo = New System.Windows.Forms.Timer(Me.components)
        Me.picHeart = New System.Windows.Forms.PictureBox
        Me.BtnExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.picHeart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrOne
        '
        Me.tmrOne.Enabled = True
        '
        'tmrTwo
        '
        Me.tmrTwo.Enabled = True
        '
        'picHeart
        '
        resources.ApplyResources(Me.picHeart, "picHeart")
        Me.picHeart.Name = "picHeart"
        Me.picHeart.TabStop = False
        '
        'BtnExit
        '
        resources.ApplyResources(Me.BtnExit, "BtnExit")
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'FrmAnimationProgramsYourName3
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.picHeart)
        Me.Name = "FrmAnimationProgramsYourName3"
        CType(Me.picHeart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrOne As System.Windows.Forms.Timer
    Friend WithEvents tmrTwo As System.Windows.Forms.Timer
    Friend WithEvents picHeart As System.Windows.Forms.PictureBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
