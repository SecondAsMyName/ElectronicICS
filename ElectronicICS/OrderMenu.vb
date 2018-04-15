Public Class OrderMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        OrderCart.Show()
    End Sub

    Private Sub btnHis_Click(sender As Object, e As EventArgs) Handles btnHis.Click
        OrderHistory.Show()
    End Sub

    Private Sub btnPend_Click(sender As Object, e As EventArgs) Handles btnPend.Click
        PendingOrder.Show()
    End Sub

    Private Sub btnORemark_Click(sender As Object, e As EventArgs) Handles btnORemark.Click
        OrderRemark.Show()
    End Sub
End Class