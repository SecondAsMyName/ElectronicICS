Public Class PaymentHistoryPage

    Private Sub PaymentHistoryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        dgvPaymentHistory.DataSource = db.Payments
    End Sub

End Class