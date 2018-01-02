Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Makes picture melt
        'Picture loaded into picture box from design form
        'Make sure timer is enabled!
        picmml.Height = picmml.Height - 1
        picmml.Top = picmml.Top + 1

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'Makes the picture fade from right to left
        'Picture loaded into picture box from design form
        'Make sure timer is enabled!
        picmmr.Width = picmmr.Width - 1

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        'Makes the images alternate
        'Set interval to 750 
        'Make sure timer is enabled!
        Me.picswitch.Image = Image.FromFile("H:\VB\Blue M&M.gif")

        If Timer3.Enabled = True Then
            Timer3.Enabled = False
            Timer4.Enabled = True
        Else
            Timer3.Enabled = True
        End If


    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        'Makes the images alternate
        'set interval to 750
        'Make sure timer is enabled!
        Me.picswitch.Image = Image.FromFile("H:\VB\yellow M&M.gif")

        If Timer4.Enabled = True Then
            Timer4.Enabled = False
            Timer3.Enabled = True
        Else
            Timer4.Enabled = True
        End If


    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        'Make sure timer is enabled!

        picsnow1.Top = picsnow1.Top + 100

        'this will make objects fall repeatedly
        If picsnow1.Top > 300 Then
            Timer5.Enabled = False
            picsnow1.Top = 0
            Timer5.Enabled = True
        End If

        picsnow2.Top = picsnow2.Top + 100

        'this will make objects fall repeatedly
        If picsnow2.Top > 300 Then
            Timer5.Enabled = False
            picsnow2.Top = 0
            Timer5.Enabled = True
        End If

        picsnow3.Top = picsnow3.Top + 100

        'this will make objects fall repeatedly
        If picsnow3.Top > 300 Then
            Timer5.Enabled = False
            picsnow3.Top = 0
            Timer5.Enabled = True
        End If

    End Sub
End Class
