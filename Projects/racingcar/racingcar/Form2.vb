Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tmr1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr1.Tick
        piccar.Left = piccar.Left + 10
        If piccar.left > 40 Then
            Tmr1.Enabled = False
            Tmr1.Enabled = True
        End If
    End Sub

    Private Sub Tmr2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr2.Tick
        piccar.Left = piccar.Right = 20
        If piccar.Left < 20 Then
            Tmr1.Enabled = True
            Tmr1.Enabled = False
        End If
    End Sub
End Class