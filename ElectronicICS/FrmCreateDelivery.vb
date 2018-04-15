Public Class FrmCreateDelivery
    Private Sub FrmCreateDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim deliveryDate As String
        Dim deliveryID As Integer
        deliveryDate = Now.Date.ToShortDateString
        lblDeliveryDate.Text = deliveryDate
        deliveryID = getLastID()
        lblDeliveryID.Text = deliveryID.ToString

    End Sub

    Private Function getLastID() As Integer
        Dim db As New DBDataContext()
        Dim getId = From d In db.Deliveries Select d.DeliveryId
        Dim lastid As Integer = getId.Max
        Return lastid + 1
    End Function

    Private Sub getOrderID()
        Dim db As New DBDataContext()
        Dim getID = From o In db.Orders Select o.OrderId
        ddlOrderID.DataSource = getID

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
End Class