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
        If Me.ValidateChildren = False Then
            Return
        End If


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

    Private Sub TxtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Dim name As String = txtName.Text

        If name = "" Then
            err.SetError(txtName, "Please enter item's name.")
            e.Cancel = True
        Else
            err.SetError(txtName, Nothing)
        End If
    End Sub

    Private Sub TxtDesc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDesc.Validating
        Dim desc As String = txtDesc.Text

        If name = "" Then
            err.SetError(txtDesc, "Please enter item's description.")
            e.Cancel = True
        Else
            err.SetError(txtDesc, Nothing)
        End If
    End Sub

    Private Sub TxtPrice_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrice.Validating
        Dim price As String = txtPrice.Text

        If name = "" Then
            err.SetError(txtPrice, "Please enter item's price.")
            e.Cancel = True
        Else
            err.SetError(txtPrice, Nothing)
        End If
    End Sub

    Private Sub TxtQuantity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtQuantity.Validating
        Dim qty As String = txtQuantity.Text

        If name = "" Then
            err.SetError(txtQuantity, "Please enter item's quantity.")
            e.Cancel = True
        Else
            err.SetError(txtQuantity, Nothing)
        End If
    End Sub
End Class