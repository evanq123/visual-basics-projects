Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Me.PicFootball.Visible = True
            MsgBox("Go Ravens!")
        End If

        If ComboBox1.SelectedIndex = 1 Then
            Me.PicBaseball.Visible = True
            MsgBox("Go Nationals!")

        End If

        If ComboBox1.SelectedIndex = 2 Then
            Me.PicBasketball.Visible = True
            MsgBox("Go Heats!")
        End If

        End
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBaseball.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicFootball.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strName As String
        strName = InputBox("Please Enter Your Name", "Student's Name")
    End Sub
End Class
