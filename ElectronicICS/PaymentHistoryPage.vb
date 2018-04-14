Public Class PaymentHistoryPage

    Private Sub PaymentHistoryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        dgvPaymentHistory.DataSource = db.Payments
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class