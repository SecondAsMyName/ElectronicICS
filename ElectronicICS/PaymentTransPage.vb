Public Class PaymentTransPage
    Private OrderID As Integer = 0

    Private Shared nextPayID As Integer = 1000

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
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
        Try
            db.SubmitChanges()
        Catch err As Exception
            MessageBox.Show("Error. Please Try Again.")
        End Try

        Dim order As New Order
        With order
            .OrderStatus = "Paid"
        End With

        Try
            db.SubmitChanges()
        Catch err As Exception
            MessageBox.Show("Error. Please Try Again.")
        End Try
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


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class