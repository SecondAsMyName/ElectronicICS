Public Class OrderRemark
    Private Username As String
    Private Sub OrderRemark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Username = MainPage.customer.Username
        txtUser.Text = " " & Username
        txtSysDate.Text = System.DateTime.Now.ToString(" dd/mm/yyyy")
    End Sub
End Class