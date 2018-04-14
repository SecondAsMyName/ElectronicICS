Public Class PaymentTransPage
    Private Shared nextPayID As Integer = 1000

    Private Sub PaymentTransPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim orderID As Integer
        Dim paymentID As Integer
        Dim paymentType As String
        Dim totalPrice As Decimal = 0.00D
        Dim price As Decimal
        Dim quantity As Integer
        Dim paymentDate As DateTime = DateTime.Now
        Dim remarks As String

        orderID = CInt(lblOrderID.Text)
        lblPayID.Text = CType(nextPayID, String)
        paymentID = nextPayID
        nextPayID += 1
        totalPrice = price * quantity
        totalPrice = CDec(lblPrice.Text)
        remarks = rtbRemarks.Text


        Dim p As New Payment()
        p.OrderId = orderID
        p.PaymentId = paymentID
        If CBool(p.PaymentType) = radCash.Checked Then
            p.PaymentType = radCash.Text
        ElseIf CBool(p.PaymentType) = radCreditCard.Checked Then
            paymentType = radCreditCard.Text
        End If
        p.Price = totalPrice
        p.PaymentDate = paymentDate
        p.Remarks = remarks

        Dim db As New DBDataContext()
        db.Payments.InsertOnSubmit(p)
        db.SubmitChanges()

        Dim o As New Order()
        o.OrderStatus = "Paid"
        db.SubmitChanges()
    End Sub
End Class