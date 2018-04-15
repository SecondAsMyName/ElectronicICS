Public Class PaymentPage
    Private Sub PaymentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        dgvOrderCart.DataSource = db.Orders
    End Sub

    Private Sub dgvOrderCart_DoubleClick(sender As Object, e As EventArgs) Handles dgvOrderCart.DoubleClick
        PaymentTransPage.ShowDialog()
    End Sub

    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        MainPage.ShowDialog()
    End Sub
End Class