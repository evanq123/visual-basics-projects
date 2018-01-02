<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFavoriteTeam
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
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblLastName = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.btContinue = New System.Windows.Forms.Button
        Me.lblTeam = New System.Windows.Forms.Label
        Me.txtTeam = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(242, 12)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(161, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(242, 61)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(161, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(242, 102)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(161, 20)
        Me.txtCity.TabIndex = 2
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Black
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.Lime
        Me.lblFirstName.Location = New System.Drawing.Point(13, 21)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(111, 24)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Black
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Lime
        Me.lblLastName.Location = New System.Drawing.Point(13, 57)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(108, 24)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.BackColor = System.Drawing.Color.Black
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.Lime
        Me.lblCity.Location = New System.Drawing.Point(13, 97)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(44, 24)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City"
        '
        'btContinue
        '
        Me.btContinue.Location = New System.Drawing.Point(129, 210)
        Me.btContinue.Name = "btContinue"
        Me.btContinue.Size = New System.Drawing.Size(184, 40)
        Me.btContinue.TabIndex = 6
        Me.btContinue.Text = "Continue"
        Me.btContinue.UseVisualStyleBackColor = True
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.BackColor = System.Drawing.Color.Black
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.ForeColor = System.Drawing.Color.Lime
        Me.lblTeam.Location = New System.Drawing.Point(13, 143)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(144, 24)
        Me.lblTeam.TabIndex = 7
        Me.lblTeam.Text = "Favorite Team"
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(242, 143)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(161, 20)
        Me.txtTeam.TabIndex = 8
        '
        'FrmFavoriteTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(437, 262)
        Me.Controls.Add(Me.txtTeam)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.btContinue)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "FrmFavoriteTeam"
        Me.Text = "Favorite Team"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents btContinue As System.Windows.Forms.Button
    Friend WithEvents lblTeam As System.Windows.Forms.Label
    Friend WithEvents txtTeam As System.Windows.Forms.TextBox

End Class
