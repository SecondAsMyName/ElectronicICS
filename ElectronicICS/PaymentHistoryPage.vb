Public Class PaymentHistoryPage
    Private Sub BindData()
        Dim paymentType As String
        Dim price As Decimal = 0.00D
        Dim paymentDate As Date
        Dim remarks As String

        Dim totalPrice As Decimal = 0.00D
        Dim quantity As Decimal = 0.00D

        totalPrice = price * quantity

        Dim db As New DBDataContext()

        Dim rs = From p In db.Payments
                 Where p.PaymentType.Contains(paymentType) And p.Price = totalPrice And p.PaymentDate = paymentDate And p.Remarks.Contains(remarks)

        lstPaymentHistory.DataSource = rs

        lblPayHistoryCount.Text = rs.Count().ToString("0 record(s)")
    End Sub
    Private Sub PaymentHistoryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

End Class