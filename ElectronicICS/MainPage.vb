Public Class MainPage
    Private Sub btnDeliveryMenu_Click(sender As Object, e As EventArgs) Handles btnDeliveryMenu.Click
        DeliveryMenu.Show(Me)
    End Sub

    Private Sub btnOrderForm_Click(sender As Object, e As EventArgs) Handles btnOrderForm.Click
        OrderCart.ShowDialog()
    End Sub
End Class
