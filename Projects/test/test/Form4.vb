Public Class frm3

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'this will take the user to the next page
        Dim Page3 As frm4
        Page3 = New frm4
        Page3.Show()
        Me.Hide()
    End Sub

    Private Sub tmr1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr1.Tick
        'makes humpty fall and loop
        picHumptyDumpty.Top = picHumptyDumpty.Top + 100
        If picHumptyDumpty.Top > 300 Then
            tmr1.Enabled = False
            picHumptyDumpty.Top = 0
            tmr1.Enabled = True
        End If
    End Sub

    Private Sub tmr3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr3.Tick
        'changes form background color to red
        Me.BackColor = Color.Red
        tmr2.Enabled = True
        tmr3.Enabled = False
    End Sub

    Private Sub tmr2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr2.Tick
        'changes form background color to blue
        Me.BackColor = Color.Blue
        tmr2.Enabled = False
        tmr3.Enabled = True
    End Sub

    Private Sub tmr4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr4.Tick
        'Makes Humpty Blink
        If picHumptyDumpty.Visible = True Then
            picHumptyDumpty.Visible = False
        Else
            picHumptyDumpty.Visible = True
        End If
    End Sub
End Class