Public Class AllAboutMe

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strName As String = InputBox("What is your name?")
        MsgBox("Hello" & " " & strName & "." & vbNewLine & "Welcome!")

    End Sub

    Private Sub rbtEarly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEarly.CheckedChanged
        lblMyInfo.Text = "I was born in Springfield, Virginia. My Birthday is April 5th, 1999." & vbNewLine & "I used to live at my grandpa's house until I was 3. I was born with vision impairment." & vbNewLine & "I also had clept pallete. My doctor said I was really unhealthy."

    End Sub

    Private Sub rbtCurrent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCurrent.CheckedChanged
        lblMyInfo.Text = "I Live in Springfield. I attend Lee Highschool. I am a freshman. I am 14 years old. I live in a townhouse."& vbnewline & "I make 0 dollars a year.
    End Sub

    Private Sub rbtFuture_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFuture.CheckedChanged
        lblMyInfo.Text = "I plan on going to college. I want to major in engineering. I want to work as an Engineer for a top company." & vbNewLine & "I'll want to make at least 95k a year. I would have a modern home." & vbNewLine & "I would have a luxury car, the best technology, and some relaly nice guitars."
    End Sub

    Private Sub rbtGuitar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGuitar.CheckedChanged
        lblMyInfo.Text = "I got a new guitar for christmas this year, I enjoy fingerstyle music, because the melody is in the music, so i don't need to sing.."
    End Sub

    Private Sub rbtGames_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGames.CheckedChanged
        lblMyInfo.Text = "I own 40+ games over 5 years, and I only had to pay a total of 60 dollars."
    End Sub

    Private Sub rbtComputer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtComputer.CheckedChanged
        lblMyInfo.Text = "I built my computer from computar parts on sale, for only 500 dollars. It can run any game I want."
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub lblMyInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMyInfo.Click

    End Sub

    Private Sub chkPhotoMe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPhotoMe.CheckedChanged
        If chkPhotoMe.Checked = True Then
            PicFriend.Visible = True
        Else
            PicFriend.Visible = False
        End If

    End Sub

    Private Sub chkPhotoFriend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPhotoFriend.CheckedChanged
        If chkPhotoFriend.Checked = True Then
            PicMe.Visible = True
        Else
            PicMe.Visible = False
        End If

    End Sub
End Class
