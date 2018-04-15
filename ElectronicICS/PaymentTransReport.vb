Imports System.Text

Public Class PaymentTransReport
    Private Sub dgvPaymentTransReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PaymentTransReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBDataContext()
        dgvReport.DataSource = db.Payments
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PrintReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintReport.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        Dim header As String = "Student Listing"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine & "Prepared by LIM KAH WAI", DateTime.Now)

        Dim body As New StringBuilder()
        body.AppendLine("Payment ID     Payment Type      Total Price(RM)     Payment Date        Remarks     Order ID")
        body.AppendLine("----------     ------------      ---------------     -------------       --------    ----------")

        Dim cnt As Integer = 0
        Dim parts() As String
        Dim db As New DBDataContext()
        'For Each item In dgvReport.Item
        cnt += 1
        '     parts = CStr(item).Split(CChar(vbTab))
        body.AppendFormat("{0,4}    {1,10}      {2,-30}" & vbNewLine, cnt, parts(0), parts(1))
        'Next
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        With e.Graphics
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
End Class