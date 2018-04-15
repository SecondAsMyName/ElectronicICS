Public Class OrderHistory
    Private Username As String

    Private Sub BindData()
        Dim db As New DBDataContext()
        Dim order = From o In db.Orders Where o.Username = Username And o.OrderStatus = "Pending"
        With dgvPending
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

End Class