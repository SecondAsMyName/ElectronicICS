Public Class PaymentPage
    Private Sub PaymentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstOrderCart_DoubleClick(sender As Object, e As EventArgs) Handles lstOrderCart.DoubleClick
        PaymentTransPage.ShowDialog(Me)
    End Sub
End Class