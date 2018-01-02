Public Class frm1
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        'this will take the user to the next page
        Dim Page3 As frm2
        Page3 = New frm2
        Page3.Show()
        Me.Hide()
    End Sub

    Private Sub tmr1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr1.Tick
        'Makes Humpty move to left
        picHumptyDumpty.Left = picHumptyDumpty.Left + 50
        'Makes humpty loop back
        If picHumptyDumpty.Left > 300 Then
            picHumptyDumpty.Left = 0
        End If
    End Sub

    Private Sub tmr2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr2.Tick
        'Makes humpty walk animation
        Me.picHumptyDumpty.Image = Image.FromFile("H:\humpty dumpty walk 2.png")
        If tmr2.Enabled = True Then
            tmr2.Enabled = False
            tmr3.Enabled = True
        Else
            tmr3.Enabled = True
        End If
    End Sub

    Private Sub tmr3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr3.Tick
        'humpty dumpty's walk animation
        Me.picHumptyDumpty.Image = Image.FromFile("H:\humptydumpty walk.png")
        If tmr3.Enabled = True Then
            tmr3.Enabled = False
            tmr2.Enabled = True
        Else
            tmr2.Enabled = True
        End If

    End Sub
End Class