Imports System.Text.RegularExpressions

Public Class FrmUpdateItem
    Public itemID As Integer
    Private oldItem As Item = New Item

    Private Sub FrmUpdateItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        oldItem = db.Items.FirstOrDefault(Function(o) o.ItemID = itemID)

        Dim price As Decimal = Math.Floor(oldItem.ItemPrice)

        lblItemID.Text = oldItem.ItemID.ToString
        txtName.Text = oldItem.ItemName
        txtDesc.Text = oldItem.ItemDesc
        txtPrice.Text = price.ToString
        If (oldItem.ItemPrice - price) < 0.1 Then
            txtPriceCen.Text = "0" & (oldItem.ItemPrice - price) * 100
        Else
            txtPriceCen.Text = CType((oldItem.ItemPrice - price) * 100, String)
        End If
        txtQuantity.Text = CType(oldItem.Quantity, String)
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

        If desc = "" Then
            err.SetError(txtDesc, "Please enter item's description.")
            e.Cancel = True
        Else
            err.SetError(txtDesc, Nothing)
        End If
    End Sub

    Private Sub TxtPrice_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrice.Validating
        Dim price As String = txtPrice.Text

        If price = "" Then
            err.SetError(txtPrice, "Please enter item's price.")
            e.Cancel = True
        Else
            err.SetError(txtPrice, Nothing)
        End If
    End Sub

    Private Sub TxtQuantity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtQuantity.Validating
        Dim qty As String = txtQuantity.Text

        If qty = "" Then
            err.SetError(txtQuantity, "Please enter item's quantity.")
            e.Cancel = True
        Else
            err.SetError(txtQuantity, Nothing)
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren = False Then
            Return
        End If

        Dim cen As Decimal = 0.00D
        If txtPriceCen.Text <> "" Then
            If txtPriceCen.Text.Length = 1 Then
                cen = CDec(txtPriceCen.Text) / 10
            Else
                cen = CDec(txtPriceCen.Text) / 100
            End If
        End If

        Dim db As New DBDataContext()
        Dim updateItem = (From item In db.Items Where item.ItemID = itemID).ToList()(0)
        With updateItem
            .ItemID = oldItem.ItemID
            .ItemName = txtName.Text
            .ItemDesc = txtDesc.Text
            .ItemPrice = CDec(txtPrice.Text) + cen
            .Quantity = CInt(txtQuantity.Text)
        End With

        Try
            db.SubmitChanges()
            Dim msgUpdate As String = String.Format("Item [{0}]'s details updated.", itemID)
            MessageBox.Show(msgUpdate, "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error encounter. Unable to update the item.", "Update fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        BtnCancel_Click(Nothing, Nothing)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class