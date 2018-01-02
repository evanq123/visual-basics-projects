Public Class frmAnimationProgramsYourName2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tmrOne_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOne.Tick
        'this will make the rain move to the left
        picRain.Left = picRain.Left - 50

        'this will enable tmrTwo 
        If picRain.Left < 39 Then
            picSun.Visible = False
            tmrOne.Enabled = False
            tmrTwo.Enabled = True
        End If

    End Sub

    Private Sub tmrTwo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTwo.Tick
        'this will make the sunshine become visible and move up
        picCloud.Visible = True
        picCloud.Top = picCloud.Top - 10

        'when the property reaches 600 then the raincloud becomes invisible
        If picCloud.Top < 40 Then
            picRain.Visible = False
            picCloud.Visible = False
            tmrTwo.Enabled = False
            picSun.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        'this will take the user to the next page
        Dim Page3 As frmAnimationProgramsYourName3
        Page3 = New frmAnimationProgramsYourName3
        Page3.Show()
        Me.Hide()

    End Sub
End Class