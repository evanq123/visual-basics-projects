Public Class FrmAnimationProgramsYourName3

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        'this will end the program
        Me.Close()

    End Sub

    Private Sub tmrTwo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTwo.Tick
        'this will make the red heart move up diagonally
        picHeart.Left = picHeart.Left + 100
        picHeart.Top = picHeart.Top - 50

    End Sub

    Private Sub tmrOne_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOne.Tick
        'this will make the red heart blink  
        If picHeart.Visible = True Then
            picHeart.Visible = False
        Else
            picHeart.Visible = True
        End If

    End Sub
End Class