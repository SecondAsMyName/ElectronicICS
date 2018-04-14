Public Class OrderCart
    Private Sub BindData()
        Dim orderID As Integer
        Dim username As String

        Dim db As New DBDataContext()

        Dim rs = From o In db.OrderLines
                 Where o.OrderId = orderID

        lstOrderCart.DataSource = rs


    End Sub

    Private Sub OrderCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class