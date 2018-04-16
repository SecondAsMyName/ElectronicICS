Public Class PaymentPage
    Private Sub PaymentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        dgvOrderCart.DataSource = db.Orders
    End Sub

    Private Sub dgvOrderCart_DoubleClick(sender As Object, e As EventArgs) Handles dgvOrderCart.DoubleClick
        Me.Hide()
        PaymentTransPage.Show()
    End Sub

    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        Me.Hide()
        MainPage.Show()
    End Sub


    Private Sub PaymentHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentHistoryToolStripMenuItem.Click
        Me.Hide()
        PaymentHistoryPage.ShowDialog()
        Me.Show()
    End Sub
End Class