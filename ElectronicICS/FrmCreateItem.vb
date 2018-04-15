Imports System.Text.RegularExpressions

Public Class FrmCreateItem
    Private Sub FrmCreateItem_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ClearForm()
        lblItemID.Text = CType(GetLastID(), String)
    End Sub

    Private Function GetLastID() As Integer
        Dim db As New DBDataContext
        Dim getid = From o In db.Items Select o.ItemID
        Return getid.Max + 1
    End Function

    Private Sub ClearForm()
        lblItemID.Text = ""
        txtName.Text = ""
        txtDesc.Text = ""
        txtPrice.Text = ""
        txtPriceCen.Text = ""
        txtQuantity.Text = ""

        txtName.Focus()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        FrmCreateItem_Activated(Nothing, Nothing)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub NumberOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress, txtPriceCen.KeyPress, txtPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtPrice.Text = digitsOnly.Replace(txtPrice.Text, "")
    End Sub

    Private Sub TxtPriceCen_TextChanged(sender As Object, e As EventArgs) Handles txtPriceCen.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtPriceCen.Text = digitsOnly.Replace(txtPriceCen.Text, "")
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtQuantity.Text = digitsOnly.Replace(txtQuantity.Text, "")
    End Sub
End Class