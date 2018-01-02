Public Class frmTest1EvanQuach

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rbtAnswer1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAnswer1.CheckedChanged
        picChicken.Visible = True
        lblAnswer1.Visible = True
        picNewspaper.Visible = False
        lblAnswer2.Visible = False
    End Sub

    Private Sub rbtAnswer2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAnswer2.CheckedChanged
        picChicken.Visible = False
        lblAnswer1.Visible = False
        picNewspaper.Visible = True
        lblAnswer2.Visible = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
