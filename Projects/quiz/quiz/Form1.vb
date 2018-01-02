Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMGYes.Click

    End Sub

    Private Sub RBTYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBTYes.CheckedChanged
        IMGNo.Visible = False
        IMGYes.Visible = True

    End Sub

    Private Sub RBTNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBTNo.CheckedChanged
        IMGYes.Visible = False
        IMGNo.Visible = True
    End Sub
End Class
