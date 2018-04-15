Public Class DeliveryMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCreateOrder_Click(sender As Object, e As EventArgs) Handles btnCreateOrder.Click
        FrmCreateDelivery.Show(Me)
        Me.Visible = False
    End Sub

    Private Sub btnUpdateDelivery_Click(sender As Object, e As EventArgs) Handles btnUpdateDelivery.Click
        FrmUpdateDelivery.Show(Me)
        Me.Visible = False
    End Sub

    Private Sub btnTrackDelivery_Click(sender As Object, e As EventArgs) Handles btnTrackDelivery.Click
        FrmTrackDelivery.Show(Me)
        Me.Visible = False
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

    End Sub
End Class
