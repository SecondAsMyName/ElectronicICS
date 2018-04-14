Public Class OrderCart
    Private Sub BindData()
        Dim db As New DBDataContext()

        Dim rs = From o In db.Items

        cboItem.DataSource = rs
        cboItem.DisplayMember = "ItemName"
        cboItem.ValueMember = "ItemID"
    End Sub

    Private Function IsDuplicatedID(id As Integer) As Boolean
        Dim db As New DBDataContext()
        Return db.Orders.Any(Function(o) o.OrderId = id)
        'True records meets the criteria
        'FALSE records does not meet the criteria
    End Function

    Private Sub OrderCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

End Class