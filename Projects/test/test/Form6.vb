Public Class frm5
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        'asks if user enjoys program. Message box says thank you.
        Dim strName As String = InputBox("Did you enjoy the story?")
        MsgBox("Thanks for watching!" & " " & strName & "." & vbNewLine & "Program will end now.")
        'this will end the program
        End
    End Sub
End Class