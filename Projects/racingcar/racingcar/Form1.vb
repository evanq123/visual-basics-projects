Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim page2 As Form2
        page2 = New Form2
        page2.show()
        Me.Hide()
    End Sub
End Class
