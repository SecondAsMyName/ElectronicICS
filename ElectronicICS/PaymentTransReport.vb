Imports System.Text

Public Class PaymentTransReport

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Close Form?", "Form Closing", MessageBoxButtons.OKCancel)
        If answer = DialogResult.OK Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub PrintReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintReport.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        Dim header As String = "Details Payment Transaction Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine & "Prepared by LIM KAH WAI", DateTime.Now)

        Dim db As New DBDataContext()
        Dim payment = From p In db.Payments

        Dim body As New StringBuilder()
        body.AppendLine("Payment ID     Payment Type      Total Price(RM)       Payment Date              Remarks")
        body.AppendLine("----------     ------------      ---------------       ------------------        ------------")

        Dim cnt As Integer = 0
        For Each payments In payment
            cnt += 1
            body.AppendFormat("{0,5}        {1,10}           {2,-5}             {3,-5}       {4,-20}" & vbNewLine, payments.PaymentId, payments.PaymentType, payments.Price, payments.PaymentDate, payments.Remarks)
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        With e.Graphics
            .DrawImage(My.Resources.cash, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString, fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreviewReport.Document = PrintReport
        dlgPreviewReport.ShowDialog()
    End Sub

    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        FrmMainpageStaff.ShowDialog()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim db As New DBDataContext()
        Dim payment = From p In db.Payments

        With dgvReport
            .DataSource = payment
            .Columns.Remove("OrderId")
        End With
        lblCount.Text = payment.Count.ToString("0 record(s).")
    End Sub

    Private Sub PaymentTransReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class