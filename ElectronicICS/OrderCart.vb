Public Class OrderCart
    Private OrderID As Integer = 0
    Private Username As String
    Private TotalPrice As Double = 0.00

    Private Sub BindData()
        Dim db As New DBDataContext()
        Dim item = From o In db.Items
        cboItem.DataSource = item
        cboItem.DisplayMember = "ItemName"
        cboItem.ValueMember = "ItemID"

        Dim cart = From o In db.OrderLines Where o.OrderId = OrderID
        With dgvOrderCart
            .DataSource = cart
            .Columns.Remove("Item")
            .Columns.Remove("Order")
            .Columns.Remove("OrderId")
        End With
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
        Return lastid + 1
    End Function

    Private Sub AddNewOrder()
        'New order and orderline object
        Dim order As New Order
        With order
            .OrderId = OrderID
            .OrderDate = System.DateTime.Now
            .OrderDesc = ""
            .OrderStatus = "Pending"
            .Username = Username
        End With

        If IsDuplicatedID(OrderID) = True Then
            MessageBox.Show("Duplicated ID.")
        Else
            'add new records
            Dim db As New DBDataContext()
            db.Orders.InsertOnSubmit(order)

            ' Submit the change to the database.
            Try
                db.SubmitChanges()
            Catch err As Exception
                MessageBox.Show("try again.")
            End Try
        End If

    End Sub

    Private Sub ResetForm()
        BindData()
        cboItem.SelectedIndex = 0
        cboQuan.SelectedIndex = 0
        cboItem_SelectedIndexChanged(Nothing, Nothing)
        txtOrderID.Text = OrderID.ToString(" 0000")
        txtUser.Text = " " & Username
        txtSysDate.Text = System.DateTime.Now.ToString(" dd/mm/yyyy")
    End Sub

    Private Sub OrderCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Username = "kevlim2906"
        If OrderID = 0 Then
            OrderID = getLastID()
            AddNewOrder()
        End If
        ResetForm()
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
        'New order and orderline object
        Dim itemID As Integer = If(TypeOf cboItem.SelectedValue Is Integer, DirectCast(cboItem.SelectedValue, Integer), 0)
        Dim quantity As Integer = Integer.Parse(cboQuan.Text)
        Dim price As Double = Convert.ToDouble(lstPrice.SelectedValue)
        Dim orderline As New OrderLine
        With orderline
            .OrderId = OrderID
            .ItemId = itemID
            .Quantity = quantity
        End With

        'add new records
        Dim db As New DBDataContext()
        db.OrderLines.InsertOnSubmit(orderline)

        ' Submit the change to the database.
        Try
            db.SubmitChanges()
        Catch err As Exception
            MessageBox.Show("Same item in cart.")
        End Try

        TotalPrice = TotalPrice + (quantity * price)
        txtTotal.Text = TotalPrice.ToString("0.00")
        BindData()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim db As New DBDataContext()
        Dim updateOrderStatus = (From ord In db.Orders
                                 Where ord.OrderId = OrderID).ToList()(0)

        updateOrderStatus.OrderStatus = "Complete"

        Try
            db.SubmitChanges()
            MessageBox.Show("No order submited.")
        Catch
            MessageBox.Show("No order submited.")
        End Try
    End Sub
End Class