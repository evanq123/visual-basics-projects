Public Class Form1
    Dim decTotal As Decimal
    Private Sub chkBow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBow.CheckedChanged
        If chkBow.Checked = True Then
            picBow.Visible = True
        Else
            picBow.Visible = False
        End If
    End Sub

    Private Sub chkTutu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTutu.CheckedChanged
        If chkTutu.Checked = True Then
            picTutu.Visible = True
        Else
            picTutu.Visible = False
        End If
    End Sub

    Private Sub chkPurse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPurse.CheckedChanged
        If chkPurse.Checked = True Then
            picPurse.Visible = True
        Else
            picPurse.Visible = False
        End If
    End Sub

    Private Sub chkNecklace_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNecklace.CheckedChanged
        If chkNecklace.Checked = True Then
            picNecklace.Visible = True
        Else
            picNecklace.Visible = False
        End If
    End Sub

    Private Sub chkHat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHat.CheckedChanged
        If chkHat.Checked = True Then
            picHat.Visible = True
        Else
            picHat.Visible = False
        End If
    End Sub

    Private Sub chkTie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTie.CheckedChanged
        If chkTie.Checked = True Then
            picTie.Visible = True
        Else
            picTie.Visible = False
        End If
    End Sub

    Private Sub chkBowtie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBowtie.CheckedChanged
        If chkBowTie.Checked = True Then
            PicBowTie.Visible = True
        Else
            PicBowTie.Visible = False
        End If
    End Sub

    Private Sub chkZipper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkZipper.CheckedChanged
        If chkZipper.Checked = True Then
            picZipper.Visible = True
        Else
            picZipper.Visible = False
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clears everything
        chkTutu.Checked = False
        chkBow.Checked = False
        chkPurse.Checked = False
        chkNecklace.Checked = False
        chkHat.Checked = False
        chkTie.Checked = False
        chkBowtie.Checked = False
        chkZipper.Checked = False
        txtOrder.Text = " "
        txtTotal.Text = " "
        decTotal = 0
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        'adds prices to order list
        If chkBow.Checked = True Then
            decTotal = decTotal + 7.5
            txtOrder.Text = "Hair Bow: $7.50" & vbNewLine & txtOrder.Text
        End If
        If chkTutu.Checked = True Then
            decTotal = decTotal + 25
            txtOrder.Text = "Tutu: $25.00" & vbNewLine & txtOrder.Text
        End If
        If chkPurse.Checked = True Then
            decTotal = decTotal + 35
            txtOrder.Text = "Purse: $35.00" & vbNewLine & txtOrder.Text
        End If
        If chkNecklace.Checked = True Then
            decTotal = decTotal + 12.5
            txtOrder.Text = "Necklace: $12.50" & vbNewLine & txtOrder.Text
        End If
        If chkHat.Checked = True Then
            decTotal = decTotal + 10
            txtOrder.Text = "Hat: $10.00" & vbNewLine & txtOrder.Text
        End If
        If chkTie.Checked = True Then
            decTotal = decTotal + 15
            txtOrder.Text = "Tie: $15.00" & vbNewLine & txtOrder.Text
        End If
        If chkBowtie.Checked = True Then
            decTotal = decTotal + 25
            txtOrder.Text = "Bow Tie: $25.00" & vbNewLine & txtOrder.Text
        End If
        If chkZipper.Checked = True Then
            decTotal = decTotal + 15
            txtOrder.Text = "Zipper: $15.00" & vbNewLine & txtOrder.Text
        End If
        txtTotal.Text = FormatCurrency(decTotal)
    End Sub
End Class
