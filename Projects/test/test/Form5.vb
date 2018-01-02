Public Class frm4

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'this will take the user to the next page
        Dim Page3 As frm5
        Page3 = New frm5
        Page3.Show()
        Me.Hide()
    End Sub

    Private Sub tmr1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr1.Tick
        'Make humpty shrink, and fade away.
        picHumpty.Width = picHumpty.Width - 1
        picHumpty.Height = picHumpty.Height - 1
        picHumpty.Top = picHumpty.Top + 1
    End Sub
End Class