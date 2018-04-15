Public Class OrderHistory
    Private Username As String

    Private Sub BindData()
        Dim db As New DBDataContext()
        Dim order = From o In db.Orders Where o.Username = Username And o.OrderStatus = "Complete"
        With dgvHistory
            .DataSource = order
            .Columns.Remove("User")
        End With
        lblCount.Text = order.Count.ToString("0 record(s).")
    End Sub

    Private Sub OrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrderHistory_Shown(Nothing, Nothing)
    End Sub

    Private Sub OrderHistory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Username = MainPage.customer.Username
        lblUser.Text = " " & Username
        BindData()
    End Sub

End Class