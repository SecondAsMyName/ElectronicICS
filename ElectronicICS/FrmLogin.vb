﻿Public Class FrmLogin
    Public user As Security_Account
    Private Sub BtnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = mskPassword.Text

        If Me.ValidateChildren = False Then
            Return
        End If

        If AuthenticateUser(username, password) Then
            MainPage.Show()
            Me.Close()
        Else
            ResetForm()
        End If
    End Sub

    Private Sub BtnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function AuthenticateUser(userName As String, password As String) As Boolean
        Dim db As New DBDataContext
        Dim sc As Security_Account = db.Security_Accounts.FirstOrDefault(Function(o) o.Username = userName)

        If sc Is Nothing Then
            MessageBox.Show("User name not found.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            If sc.Password <> password Then
                MessageBox.Show("Incorrect Password.", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

        user = sc
        Return True
    End Function

    Private Sub ResetForm()
        mskPassword.Text = ""
        mskPassword.Focus()
        Err.Clear()
    End Sub

    Private Sub txtUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsername.Validating
        Dim username As String = txtUsername.Text

        If username = "" Then
            errLogin.SetError(txtUsername, "Please enter user name.")
            e.Cancel = True
        Else
            errLogin.SetError(txtUsername, Nothing)
        End If
    End Sub

    Private Sub mskPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskPassword.Validating
        Dim password As String = mskPassword.Text

        If password = "" Then
            errLogin.SetError(mskPassword, "Please enter password.")
            e.Cancel = True
        Else
            errLogin.SetError(mskPassword, Nothing)
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class