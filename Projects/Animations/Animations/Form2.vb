Public Class frmanimationprogramsyourname

    Private Sub tmrOne_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOne.Tick
        'this will make the happy face move to the right
        picHappyFace.Left = picHappyFace.Left + 50
        If picHappyFace.Left > 440 Then
            tmrOne.Enabled = False
            tmrTwo.Enabled = True
        End If
    End Sub

    Private Sub tmrTwo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTwo.Tick
        'this will make the happy face move back to the left
        picHappyFace.Left = picHappyFace.Left - 50
        If picHappyFace.Left < 20 Then
            tmrOne.Enabled = True
            tmrTwo.Enabled = False
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'this will take the user to the next page
        Dim Page2 As frmanimationprogramsyourname2
        Page2 = New frmanimationprogramsyourname2
        Page2.Show()
        Me.Hide()
    End Sub
End Class