Public Class OrderCart
    Private OrderID As Integer

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
        cboItem.SelectedIndex = 0
        cboItem_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        Dim db As New DBDataContext()
        Dim itemID As Integer = If(TypeOf cboItem.SelectedValue Is Integer, DirectCast(cboItem.SelectedValue, Integer), 0)
        Dim desc = From o In db.Items Where o.ItemID = itemID
        lstItemDesc.DataSource = desc
        lstItemDesc.DisplayMember = "ItemDesc"
        lstItemDesc.ValueMember = "ItemDesc"
        lstPrice.DataSource = desc
        lstPrice.DisplayMember = "ItemPrice"
        lstPrice.ValueMember = "ItemPrice"
    End Sub

    Private Sub lstItemDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItemDesc.SelectedIndexChanged

    End Sub
End Class