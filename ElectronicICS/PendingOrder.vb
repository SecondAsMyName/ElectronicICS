Public Class PendingOrder
    Private Username As String
    Private Sub BindData()
        Dim db As New DBDataContext()
        Dim order = From o In db.Orders Where o.Username = Username And o.OrderStatus = "Pending"
        dgvPending.DataSource = order
    End Sub

    Private Sub PendingOrder_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Username = MainPage.customer.Username
        lblUser.Text = " " & Username
        BindData()
    End Sub

    Private Sub dgvPending_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPending.CellDoubleClick
        Dim i As Integer = e.RowIndex
        Dim id As Integer
        If i > -1 Then
            id = CInt(dgvPending.Rows(i).Cells(0).Value)
        Else
            MessageBox.Show("No cart item selected.")
        End If
        OrderCart.OrderID = id
        OrderCart.Activate()
        OrderCart.Show()
        Me.Hide()
    End Sub


    Private Sub PendingOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PendingOrder_Shown(Nothing, Nothing)
    End Sub

    Private Sub PendingOrder_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        PendingOrder_Shown(Nothing, Nothing)
    End Sub
End Class