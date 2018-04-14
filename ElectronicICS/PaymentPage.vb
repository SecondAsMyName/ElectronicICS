Public Class PaymentPage
    Private Sub BindData()
        Dim orderDate As Date
        Dim orderDesc As String

        Dim db As New DBDataContext()

        Dim rs = From o In db.Orders
                 Where o.OrderDate = orderDate And o.OrderDesc = orderDesc

        lstOrderCart.DataSource = rs

        lblOrderCartCount.Text = rs.Count().ToString("0 record(s)")

    End Sub
    Private Sub PaymentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstOrderCart_DoubleClick(sender As Object, e As EventArgs)
        PaymentTransPage.ShowDialog(Me)
    End Sub
End Class