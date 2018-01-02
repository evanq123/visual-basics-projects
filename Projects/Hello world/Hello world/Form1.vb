Public Class frmHelowWorldEvanQuach

    Private Sub rbtSmile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSmile.CheckedChanged
        picSmile.Visible = True
        picGrin.Visible = False
        picFrown.Visible = False
        lblSmile.Text = "I'm going to Disney World!"
        lblGrin.Text = ""
        lblFrown.Text = ""
    End Sub

    Private Sub rbtGrin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGrin.CheckedChanged
        picSmile.Visible = False
        picGrin.Visible = True
        picFrown.Visible = False
        lblSmile.Text = ""
        lblGrin.Text = "I have a cold"
        lblFrown.Text = ""
    End Sub

    Private Sub rbtFrown_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFrown.CheckedChanged
        picSmile.Visible = False
        picGrin.Visible = False
        picFrown.Visible = True
        lblSmile.Text = ""
        lblGrin.Text = ""
        lblFrown.Text = "I have a lot of homework!"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
