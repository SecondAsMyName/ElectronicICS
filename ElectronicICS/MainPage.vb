Public Class MainPage
    Public customer As User
    Private Sub btnDeliveryMenu_Click(sender As Object, e As EventArgs) Handles btnDeliveryMenu.Click
        DeliveryMenu.Show(Me)
    End Sub

    Private Sub btnOrderForm_Click(sender As Object, e As EventArgs) Handles btnOrderForm.Click
        OrderMenu.ShowDialog()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        PaymentPage.ShowDialog()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        PaymentPage.ShowDialog()
    End Sub
End Class
