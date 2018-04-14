Public Class FrmLogin
    Public userName As String
    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Me.Hide()
        MainPage.Show()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class