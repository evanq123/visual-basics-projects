Public Class FrmTitlePage
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        'this will take the user to the next page
        Dim Page3 As frm1
        Page3 = New frm1
        Page3.Show()
        Me.Hide()
    End Sub
End Class
