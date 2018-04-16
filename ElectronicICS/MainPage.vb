Public Class MainPage
    Public customer As User
    Private Sub btnDeliveryMenu_Click(sender As Object, e As EventArgs) Handles btnDeliveryMenu.Click
        DeliveryMenu.Show(Me)
    End Sub

    Private Sub btnOrderForm_Click(sender As Object, e As EventArgs) Handles btnOrderForm.Click
        OrderMenu.ShowDialog()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Me.Hide()
        PaymentMainPage.Show()

    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        Me.Hide()
        PaymentMainPage.Show()
    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuAccLogout_Click(sender As Object, e As EventArgs) Handles mnuAccLogout.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
