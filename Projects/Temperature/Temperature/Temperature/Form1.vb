Public Class Form1
    Dim sngTemp As Single
    Dim sngF As Single
    Dim sngC As Single

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CelsiusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CelsiusToolStripMenuItem.Click
        sngTemp = Val(txtTemp.Text)
        sngF = 9 / 5 * sngTemp + 32
        txtF.Text = sngF
        txtC.Text = sngTemp

    End Sub

    Private Sub FahrenheitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FahrenheitToolStripMenuItem.Click
        sngTemp = Val(txtTemp.Text)
        sngC = 5 / 9 * (sngTemp - 32)
        txtC.Text = sngC
        txtF.Text = sngTemp

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
