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

    Private Function HasCartItem(id As Integer) As Boolean
        Dim db As New DBDataContext()
        Return db.OrderLines.Any(Function(o) o.OrderId = id)

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

        Dim db As New DBDataContext()
        Dim cart = From o In db.OrderLines Where o.OrderId = OrderID Select o.Subtotal
        Dim totalprice As Double = Convert.ToDouble(cart.Sum)
        txtTotal.Text = totalprice.ToString("0.00")
    End Sub

    Private Sub OrderCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Username = MainPage.customer.Username
        If OrderID = 0 Then
            OrderID = getLastID()
            AddNewOrder()
        End If
        ResetForm()
    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        Dim db As New DBDataContext()
        Dim itemID As Integer = If(TypeOf cboItem.SelectedValue Is Integer, DirectCast(cboItem.SelectedValue, Integer), 0)
        Dim desc = From o In db.Items Where o.ItemID = itemID Select o.ItemDesc
        txtDesc.Text = desc.FirstOrDefault()
        Dim price = From o In db.Items Where o.ItemID = itemID Select o.ItemPrice
        txtPrice.Text = (price.FirstOrDefault()).ToString()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        'New order and orderline object
        Dim itemID As Integer = If(TypeOf cboItem.SelectedValue Is Integer, DirectCast(cboItem.SelectedValue, Integer), 0)
        Dim quantity As Integer = Integer.Parse(cboQuan.Text)
        Dim price As Double = Convert.ToDouble(txtPrice.Text)
        Dim total As Double = (quantity * price)
        Dim orderline As New OrderLine
        With orderline
            .OrderId = OrderID
            .ItemId = itemID
            .Quantity = quantity
            .Subtotal = Convert.ToDecimal(total)
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


        ResetForm()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (HasCartItem(OrderID) = False) Then
            MessageBox.Show("No item ordered.")
        Else
            Dim db As New DBDataContext()
            Dim updateOrderStatus = (From ord In db.Orders
                                     Where ord.OrderId = OrderID).ToList()(0)

            updateOrderStatus.OrderStatus = "Complete"

            Try
                db.SubmitChanges()
                MessageBox.Show("Order submited.")
            Catch
                MessageBox.Show("No order submited.")
            End Try
            Me.Close()
        End If

    End Sub

    Private Sub dgvOrderCart_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderCart.CellDoubleClick
        Dim i As Integer = e.RowIndex
        Dim id As Integer
        If i > -1 Then
            id = CInt(dgvOrderCart.Rows(i).Cells(0).Value)
        Else
            MessageBox.Show("No cart item selected.")
        End If

        Dim db As New DBDataContext()
        Dim deleteCartItem = (From cart In db.OrderLines
                              Where cart.OrderId = OrderID And cart.ItemId = id).ToList()(0)

        db.OrderLines.DeleteOnSubmit(deleteCartItem)

        Try
            db.SubmitChanges()
        Catch
            MessageBox.Show("No cart item removed.")
        End Try
        ResetForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub OrderRemarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderRemarkToolStripMenuItem.Click
        OrderRemark.Show()
    End Sub
End Class