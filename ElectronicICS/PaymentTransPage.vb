Public Class PaymentTransPage
    Private Shared nextPayID As Integer = 1000

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim OrderID As Integer = If(TypeOf cboOrderID.SelectedValue Is Integer, DirectCast(cboOrderID.SelectedValue, Integer), 0)
        Dim payment As New Payment
        Dim paymenttype As String = Nothing

        If radCash.Checked Then
            paymenttype = radCash.Text.ToString
        ElseIf radCreditCard.Checked Then
            paymenttype = radCreditCard.Text.ToString
        End If

        With payment
            .PaymentId = CInt(lblPayID.Text)
            .PaymentType = paymenttype
            .Price = CDec(lblPrice.Text)
            .PaymentDate = System.DateTime.Now
            .Remarks = rtbRemarks.Text
            .OrderId = CInt(cboOrderID.Text)
        End With

        Dim db As New DBDataContext()
        db.Payments.InsertOnSubmit(payment)

        Dim order As New Order
        With order
            .OrderStatus = "Paid"
        End With

        Try
            db.SubmitChanges()
        Catch err As Exception
            MessageBox.Show("Error. Please Try Again.")
        End Try

        MessageBox.Show("Payment has been paid", "Payment Transaction Successful.")


    End Sub

    Private Sub PaymentTransPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        Dim orderLines = From o In db.OrderLines
        cboOrderID.DataSource = orderLines
        cboOrderID.DisplayMember = "OrderId"
        cboOrderID.ValueMember = "OrderId"

        Dim paymentID As Integer
        lblPayID.Text = CType(nextPayID, String)
        paymentID = nextPayID
        nextPayID += 1

        Dim cart = From ol In db.OrderLines Where ol.OrderId = cboOrderID.SelectedIndex Select ol.Subtotal
        Dim totalprice As Double = Convert.ToDouble(cart.Sum)
        lblPrice.Text = totalprice.ToString("0.00")



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Cancel Transaction?", "Form Closing", MessageBoxButtons.OKCancel)
        If answer = DialogResult.OK Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub cboOrderID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrderID.SelectedIndexChanged
        Dim db As New DBDataContext()
        Dim orderID As Integer = If(TypeOf cboOrderID.SelectedValue Is Integer, DirectCast(cboOrderID.SelectedValue, Integer), 0)
        Dim price = From o In db.OrderLines Where o.OrderId = orderID Select o.Subtotal
        lblPrice.Text = (price.FirstOrDefault()).ToString()
    End Sub
End Class