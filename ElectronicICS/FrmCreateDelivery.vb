Public Class FrmCreateDelivery
    Private Sub FrmCreateDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim deliveryDate As String
        Dim deliveryID As Integer
        deliveryDate = Now.Date.ToShortDateString
        lblDeliveryDate.Text = deliveryDate
        deliveryID = getLastID()
        lblDeliveryID.Text = deliveryID.ToString
        getOrderID()
    End Sub

    Private Function getLastID() As Integer
        Dim db As New DBDataContext()
        Dim getId = From d In db.Deliveries Select d.DeliveryId
        Dim lastid As Integer = getId.Max
        Return lastid + 1
    End Function

    Private Sub getOrderID()

        Dim db As New DBDataContext()
        Dim getID = From o In db.Orders Where o.OrderStatus = "Complete" Select o.OrderId

        Dim getAssignedID = From a In db.Deliveries Select a.OrderId
        'arr.Equals(getID.Except(getAssignedID).Union(getAssignedID.Except(getID)))
        'Dim assignID As Integer = Integer.Parse(getAssignedID.ToString)
        'If Not getID.Contains(assignID) Then
        '    arr.Add(getAssignedID.
        'End If
        ddlOrderID.DataSource = getID.Except(getAssignedID).Union(getAssignedID.Except(getID))
        'For Each item As Delivery In db.Deliveries
        '    If getAssignedID.Equals(getID) Then


        '    End If
        'Next




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        DeliveryMenu.Visible = True
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim DeliveryID As Integer = Integer.Parse(lblDeliveryID.Text)
        Dim delivery As New Delivery

        With delivery
            .DeliveryId = DeliveryID
            .Date = System.DateTime.Now
            .Status = "Delivering"
            .OrderId = Integer.Parse(ddlOrderID.SelectedItem.ToString)
        End With
        Dim db As New DBDataContext()
        db.Deliveries.InsertOnSubmit(delivery)

        Try
            db.SubmitChanges()
        Catch err As Exception
            MessageBox.Show("Error. Please Try Again.")
        End Try

        MessageBox.Show("Delivery has been made", "Delivery Creation Successful.")

        FormReset()
        getOrderID()
    End Sub

    Private Sub FormReset()
        lblDeliveryID.Text = getLastID().ToString
        ddlOrderID.SelectedIndex = -1

    End Sub
End Class