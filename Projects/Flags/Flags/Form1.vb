Public Class frmNationalFlagsEvanQuach

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFrance.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUnitedStates.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInfo.Click

    End Sub

    Private Sub rbtSpain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSpain.CheckedChanged
        picSpain.Visible = True
        picFrance.Visible = False
        picUnitedStates.Visible = False
        picItaly.Visible = False
        TextSpain.Text = "This is te Spanish Flag!"
        TextFrance.Text = ""
        TextUnitedStates.Text = ""
        TextItaly.Text = ""
    End Sub

    Private Sub rbtFrance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFrance.CheckedChanged
        picSpain.Visible = False
        picFrance.Visible = True
        picUnitedStates.Visible = False
        picItaly.Visible = False
        TextSpain.Text = ""
        TextFrance.Text = "This is the French Flag!"
        TextUnitedStates.Text = ""
        TextItaly.Text = ""
    End Sub

    Private Sub rbtUnitedStates_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtUnitedStates.CheckedChanged
        picSpain.Visible = False
        picFrance.Visible = False
        picUnitedStates.Visible = True
        picItaly.Visible = False
        TextSpain.Text = ""
        TextFrance.Text = ""
        TextUnitedStates.Text = "I am Evan Quach, a student at Lake Braddock Secondary School in Burke, VA.  I live in the United States."
        TextItaly.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TextSpain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextSpain.TextChanged

    End Sub

    Private Sub rbtItaly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtItaly.CheckedChanged
        picSpain.Visible = False
        picFrance.Visible = False
        picUnitedStates.Visible = False
        picItaly.Visible = True
        TextSpain.Text = ""
        TextFrance.Text = ""
        TextUnitedStates.Text = ""
        TextItaly.Text = "This is the Italian Flag!"
    End Sub
End Class
