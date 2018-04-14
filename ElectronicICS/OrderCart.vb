Public Class OrderCart
    Private OrderID As Integer
    Private Username As String

    Private Sub BindData()
        Dim db As New DBDataContext()
        Dim item = From o In db.Items
        cboItem.DataSource = item
        cboItem.DisplayMember = "ItemName"
        cboItem.ValueMember = "ItemID"

        Dim cart = From o In db.OrderLines Where o.OrderId = OrderID
        lstOrderCart.DataSource = cart
        lstOrderCart.DisplayMember = "ItemId"
        lstOrderCart.ValueMember = "ItemId"
        lstOrderCart.DisplayMember = "Quantity"
        lstOrderCart.ValueMember = "Quantity"
    End Sub

    Private Function IsDuplicatedID(id As Integer) As Boolean
        Dim db As New DBDataContext()
        Return db.Orders.Any(Function(o) o.OrderId = id)
        'True records meets the criteria
        'FALSE records does not meet the criteria
    End Function

    Private Function getLastID() As Integer
        Dim db As New DBDataContext()
        Dim getId = From o In db.Orders Select o.OrderId
        Dim lastid As Integer = getId.Max
        Return lastid
    End Function

    Private Sub AddNewOrder()
        'New order and orderline object
        Dim order As New Order
        With order
            .OrderId = OrderID
            .OrderDate = System.DateTime.Now
            .OrderDesc = ""
            .Username = Username
        End With
    End Sub

    Private Sub OrderCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Username = "kevlim2906"
        OrderID = getLastID()
        BindData()
        cboItem.SelectedIndex = 0
        cboQuan.SelectedIndex = 0
        cboItem_SelectedIndexChanged(Nothing, Nothing)
        AddNewOrder()
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

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click



    End Sub
End Class