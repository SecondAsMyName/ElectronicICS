Public Class PaymentMainPage
    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        Me.Hide()
        MainPage.Show()
    End Sub

    Private Sub btnMakePay_Click(sender As Object, e As EventArgs) Handles btnMakePay.Click
        Me.Hide()
        PaymentPage.Show()
    End Sub

    Private Sub btnShowPayTransRecord_Click(sender As Object, e As EventArgs) Handles btnShowPayTransRecord.Click
        Me.Hide()
        PaymentHistoryPage.Show()
    End Sub

    Private Sub PaymentMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class