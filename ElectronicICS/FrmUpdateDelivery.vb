Public Class FrmUpdateDelivery
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        resetForm()
    End Sub

    Private Sub FrmUpdateDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForm()

        'If Not (getID.Equals("")) Then
        '    ddlDeliveryID.DataSource = getID
        'Else
        '    MessageBox.Show("No pending delivery available")
        'End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        DeliveryMenu.Visible = True
    End Sub

    Private Sub ddlDeliveryID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDeliveryID.SelectedIndexChanged


        Dim db As New DBDataContext()

        Dim deliveryID As Integer = If(TypeOf ddlDeliveryID.SelectedValue Is Integer, DirectCast(ddlDeliveryID.SelectedValue, Integer), 0)
        Dim deliverDate = From o In db.Deliveries Where o.DeliveryId = deliveryID Select o.Date
        lblDeliveryDate.Text = deliverDate.FirstOrDefault().ToShortDateString()
        Dim ordID = From o In db.Deliveries Where o.DeliveryId = deliveryID Select o.OrderId
        lblOrderID.Text = ordID.FirstOrDefault().ToString()
        Dim deliveryStatus = From o In db.Deliveries Where o.DeliveryId = deliveryID Select o.Status
        ddlStatus.SelectedItem = deliveryStatus.FirstOrDefault().ToString()


    End Sub

    Private Sub resetForm()
        Dim db As New DBDataContext()
        Dim getID = From d In db.Deliveries Select d.DeliveryId
        ddlDeliveryID.DataSource = getID
    End Sub


End Class