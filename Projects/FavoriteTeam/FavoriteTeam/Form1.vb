Public Class FrmFavoriteTeam
    Dim strFirstName As String
    Dim strLastName As String
    Dim strCity As String
    Dim StrTeam As String

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged
        strFirstName = txtFirstName.Text
    End Sub

    Private Sub btContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btContinue.Click
        MsgBox("Hello " & strFirstName & " " & strLastName & " of " & strCity & ". You are now a member of the " & StrTeam & " fan patrol!")
    End Sub

    Private Sub txtLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.TextChanged
        strLastName = txtLastName.Text
    End Sub

    Private Sub txtCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCity.TextChanged
        strCity = txtCity.Text
    End Sub

    Private Sub txtTeam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTeam.TextChanged
        StrTeam = txtTeam.Text
    End Sub
End Class
