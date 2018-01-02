Public Class frm2
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'this will take the user to the next page
        Dim Page3 As frm3
        Page3 = New frm3
        Page3.Show()
        Me.Hide()
    End Sub
End Class