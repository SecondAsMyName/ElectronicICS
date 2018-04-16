Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class FrmUpdateSupplier
    Public supplierID As Integer
    Private oldSupplier As Supplier = New Supplier

    Private Sub FrmUpdateSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        oldSupplier = db.Suppliers.FirstOrDefault(Function(o) o.SupplierId = supplierID)

        lblSupplierID.Text = oldSupplier.SupplierId.ToString
        txtName.Text = oldSupplier.SupplierName
        txtEmail.Text = oldSupplier.Email
        txtAddress.Text = oldSupplier.Address
        Dim telNoArr() As String
        telNoArr = oldSupplier.TelNo.Split(CType("-", Char()))
        txtTelNo1.Text = telNoArr(0)
        txtTelNo2.Text = telNoArr(1)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub NumberOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelNo2.KeyPress, txtTelNo1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelNo1_TextChanged(sender As Object, e As EventArgs) Handles txtTelNo1.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtTelNo1.Text = digitsOnly.Replace(txtTelNo1.Text, "")
    End Sub

    Private Sub txtTelNo2_TextChanged(sender As Object, e As EventArgs) Handles txtTelNo2.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtTelNo2.Text = digitsOnly.Replace(txtTelNo2.Text, "")
    End Sub
    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Dim name As String = txtName.Text

        If name = "" Then
            err.SetError(txtName, "Please enter name.")
            e.Cancel = True
        Else
            err.SetError(txtName, Nothing)
        End If
    End Sub

    Private Sub TxtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Try
            Dim address As MailAddress = New MailAddress(txtEmail.Text.ToString)
            err.SetError(txtEmail, Nothing)
        Catch ex As Exception
            err.SetError(txtEmail, "Please enter valid email address.")
            e.Cancel = True
        End Try
    End Sub

    Private Sub TxtAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAddress.Validating
        Dim address As String = txtAddress.Text

        If address = "" Then
            err.SetError(txtAddress, "Please enter address.")
            e.Cancel = True
        Else
            err.SetError(txtAddress, Nothing)
        End If
    End Sub

    Private Sub TxtTelNo1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTelNo1.Validating
        Dim telno As String = txtTelNo1.Text

        If telno = "" Then
            err.SetError(txtTelNo1, "Please enter telephone number.")
            e.Cancel = True
        ElseIf telno.Chars(0) <> "0" Then
            err.SetError(txtTelNo1, "Please enter valid telephone number.")
            e.Cancel = True
        Else
            err.SetError(txtTelNo1, Nothing)
        End If
    End Sub

    Private Sub TxtTelNo2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTelNo2.Validating
        Dim telno As String = txtTelNo2.Text

        If telno = "" Then
            err.SetError(txtTelNo2, "Please enter telephone number.")
            e.Cancel = True
        Else
            err.SetError(txtTelNo2, Nothing)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren = False Then
            Return
        End If

        Try
            Dim address As MailAddress = New MailAddress(txtEmail.Text.ToString)
            err.SetError(txtEmail, Nothing)
        Catch ex As Exception
            err.SetError(txtEmail, "Please enter valid email address.")
            Return
        End Try

        Dim db As New DBDataContext()
        Dim updateSupplier = (From supplier In db.Suppliers Where supplier.SupplierId = supplierID).ToList()(0)
        With updateSupplier
            .SupplierId = CInt(lblSupplierID.Text)
            .SupplierName = txtName.Text
            .Email = txtEmail.Text
            .Address = txtAddress.Text
            .TelNo = txtTelNo1.Text & "-" & txtTelNo2.Text
        End With

        Try
            db.SubmitChanges()
            Dim msgUpdate As String = String.Format("Supplier [{0}]'s details updated.", supplierID)
            MessageBox.Show(msgUpdate, "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error encounter. Unable to update the supplier.", "Update fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        BtnCancel_Click(Nothing, Nothing)
    End Sub
End Class