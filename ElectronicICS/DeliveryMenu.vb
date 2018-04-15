Public Class DeliveryMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCreateOrder_Click(sender As Object, e As EventArgs) Handles btnCreateOrder.Click
        FrmCreateDelivery.Show(Me)
        Me.Visible = False
    End Sub
End Class
