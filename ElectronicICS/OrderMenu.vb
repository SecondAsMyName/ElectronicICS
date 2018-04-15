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


    Private Sub OrderMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class