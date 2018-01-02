Public Class Form1

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strName As String = InputBox("What is your name?") 'Input box asks for name
        MsgBox("Hello" & " " & strName & "." & vbNewLine & "Welcome!") 'Message box asks name.
        lblNameHEre.Text = (" " & strName & ".")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        MsgBox("Great Job!") 'Tells person good job
        End 'Ends program
    End Sub

    Private Sub cboEyeColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEyeColor.SelectedIndexChanged
        If cboEyeColor.SelectedIndex = 0 Then 'blue eyes
            picBlueEyes.Visible = True
            picBrownEyes.Visible = False
            picGreenEyes.Visible = False
        End If

        If cboEyeColor.SelectedIndex = 1 Then 'brown eyes
            picBlueEyes.Visible = False
            picBrownEyes.Visible = True
            picGreenEyes.Visible = False
        End If

        If cboEyeColor.SelectedIndex = 2 Then ' Green Eyes
            picBlueEyes.Visible = False
            picBrownEyes.Visible = False
            picGreenEyes.Visible = True
        End If
    End Sub

    Private Sub cboHairColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHairColor.SelectedIndexChanged
        'HairColor brown
        If cboHairColor.SelectedIndex = 0 And cboHairStyle.SelectedIndex = 0 Then
            picLongHairBrown.Visible = True
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairColor.SelectedIndex = 0 And cboHairStyle.SelectedIndex = 1 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = True
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairColor.SelectedIndex = 0 And cboHairStyle.SelectedIndex = 2 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = True
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        'HairColor:Blonde
        If cboHairColor.SelectedIndex = 1 And cboHairStyle.SelectedIndex = 0 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = True
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairColor.SelectedIndex = 1 And cboHairStyle.SelectedIndex = 1 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = True
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairColor.SelectedIndex = 1 And cboHairStyle.SelectedIndex = 2 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = True
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        'HairColor:multi
        If cboHairColor.SelectedIndex = 2 And cboHairStyle.SelectedIndex = 0 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = True
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairColor.SelectedIndex = 2 And cboHairStyle.SelectedIndex = 1 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = True
            picFace.Visible = False
        End If
        If cboHairColor.SelectedIndex = 2 And cboHairStyle.SelectedIndex = 2 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = True
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
    End Sub

    Private Sub cboHairStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHairStyle.SelectedIndexChanged
        'hairstyle long
        If cboHairStyle.SelectedIndex = 0 And cboHairColor.SelectedIndex = 0 Then
            picLongHairBrown.Visible = True
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairStyle.SelectedIndex = 0 And cboHairColor.SelectedIndex = 1 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = True
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairStyle.SelectedIndex = 0 And cboHairColor.SelectedIndex = 2 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = True
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        'Hairslicked
        If cboHairStyle.SelectedIndex = 1 And cboHairColor.SelectedIndex = 0 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = True
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairStyle.SelectedIndex = 1 And cboHairColor.SelectedIndex = 1 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = True
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairStyle.SelectedIndex = 1 And cboHairColor.SelectedIndex = 2 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = True
            picFace.Visible = False
        End If
        'Hair messy
        If cboHairStyle.SelectedIndex = 2 And cboHairColor.SelectedIndex = 0 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = True
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairStyle.SelectedIndex = 2 And cboHairColor.SelectedIndex = 1 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = True
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = False
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
        If cboHairStyle.SelectedIndex = 2 And cboHairColor.SelectedIndex = 2 Then
            picLongHairBrown.Visible = False
            picLonghairBlonde.Visible = False
            picLongHairMultiColor.Visible = False
            picMessyHairblonde.Visible = False
            picMessyHairBrown.Visible = False
            picMessyHairMulti.Visible = True
            picslickedbackhairblonde.Visible = False
            picSlickedBackHairBrown.Visible = False
            picSlickedBackHairMulti.Visible = False
            picFace.Visible = False
        End If
    End Sub

    Private Sub cboMouth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMouth.SelectedIndexChanged
        If cboMouth.SelectedIndex = 0 Then 'mouth
            picMouth.Visible = True
            picMouthBeard.Visible = False
            picMouthMustache.Visible = False
        End If
        If cboMouth.SelectedIndex = 1 Then 'mustache
            picMouth.Visible = False
            picMouthBeard.Visible = False
            picMouthMustache.Visible = True
        End If
        If cboMouth.SelectedIndex = 2 Then 'beard
            picMouth.Visible = False
            picMouthBeard.Visible = True
            picMouthMustache.Visible = False
        End If

    End Sub

    Private Sub cboOtherFeatures_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOtherFeatures.SelectedIndexChanged
        If cboOtherFeatures.SelectedIndex = 0 Then 'nose 
            picnose.Visible = True
            picEyePatch.Visible = False
            picScar.Visible = False
        End If
        If cboOtherFeatures.SelectedIndex = 1 Then 'patch 
            picnose.Visible = False
            picEyePatch.Visible = True
            picScar.Visible = False
        End If
        If cboOtherFeatures.SelectedIndex = 2 Then 'scar
            picnose.Visible = False
            picEyePatch.Visible = False
            picScar.Visible = True
        End If
    End Sub

    Private Sub lblNameHEre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNameHEre.Click

    End Sub
End Class
