﻿Public Class FrmSignUp
    Private Sub FrmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Close The form?", "Form Closing", MessageBoxButtons.OKCancel)
        If answer = DialogResult.OK Then
            Me.Close()
        Else
        End If
    End Sub

    Private Function IsDuplicatedID(id As String) As Boolean
        Dim db As New DBDataContext()
        Return db.Security_Accounts.Any(Function(o) o.Username = id)
        'True records meets the criteria
        'FALSE records does not meet the criteria
    End Function

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim securityAccount As New Security_Account
        Dim role As String

        If (txtUsername.Text = "" And mskPassword.Text = "" And txtName.Text = "" And txtEmail.Text = "" And txtHpno.Text = "" And txtaddress.Text = "") Then
            MessageBox.Show("Please don't leave the text field blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        role = "Customer"
        With securityAccount
            .Username = txtUsername.Text
            .Password = If(mskPassword.MaskCompleted, mskPassword.Text, "")
            .Role = role.Trim()
        End With

        If IsDuplicatedID(securityAccount.Username) Then
            MessageBox.Show("Duplicated ID.")
        Else
            'add new records
            Dim db As New DBDataContext()
            db.Security_Accounts.InsertOnSubmit(securityAccount)

            ' Submit the change to the database.
            Try
                db.SubmitChanges()
            Catch err As Exception
                MessageBox.Show("No security account created.")
            End Try

            Dim gender As String = ""
            If radMale.Checked = True Then
                gender = "Male"
            ElseIf radFemale.Checked = True Then
                gender = "Female"
            Else
                gender = "Male"
            End If
            Dim user As New User
            With user
                .Username = txtUsername.Text
                .Name = txtName.Text
                .Gender = gender
                .HpNo = txtHpno.Text
                .email_ = txtEmail.Text
                .Address = txtaddress.Text
            End With

            'add new records
            db.Users.InsertOnSubmit(user)

            ' Submit the change to the database.
            Try
                db.SubmitChanges()
            Catch err As Exception
                MessageBox.Show("No user created.")
            End Try
            MessageBox.Show("Sign Up success.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If

    End Sub
End Class