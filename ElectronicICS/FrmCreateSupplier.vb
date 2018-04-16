Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class FrmCreateSupplier
    Private Sub FrmCreateSupplier_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ClearForm()
        lblSupplierID.Text = CType(GetLastID(), String)
    End Sub
    Private Function GetLastID() As Integer
        Dim db As New DBDataContext
        Dim getid = From o In db.Suppliers Select o.SupplierId

        Try
            getid.Max
        Catch ex As Exception
            Return 1000
        End Try
        Return getid.Max + 1
    End Function

    Private Sub ClearForm()
        lblSupplierID.Text = ""
        txtName.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtTelNo1.Text = ""
        txtTelNo2.Text = ""

        txtName.Focus()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        FrmCreateSupplier_Activated(Nothing, Nothing)
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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

        Dim newSupplier As New Supplier
        With newSupplier
            .SupplierId = CInt(lblSupplierID.Text)
            .SupplierName = txtName.Text
            .Email = txtEmail.Text
            .Address = txtAddress.Text
            .TelNo = txtTelNo1.Text & "-" & txtTelNo2.Text
        End With

        Dim db As New DBDataContext()
        db.Suppliers.InsertOnSubmit(newSupplier)

        Try
            db.SubmitChanges()
            Dim s As String = String.Format("Supplier [{0}] Added.", newSupplier.SupplierId)
            MessageBox.Show(s, "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            BtnCancel_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show("Error encounter. Supplier not inserted.", "Add Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
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
End Class