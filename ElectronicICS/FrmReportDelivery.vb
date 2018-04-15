Imports System.Text
Imports System.Globalization

Public Class FrmReportDelivery
    Private fromPassDate As Date
    Private toPassDate As Date
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim fromDate As Date = dtpFrom.Value
        Dim toDate As Date = dtpTo.Value

        Dim db As New DBDataContext()
        Dim delivery = From d In db.Deliveries Where d.Status = "Complete" And d.Date >= fromDate And d.Date <= toDate

        With dgvReport
            .DataSource = delivery
            .Columns.Remove("Order")
        End With

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ppdReportDelivery.Document = pdReportDelivery
        ppdReportDelivery.ShowDialog(Me)
    End Sub

    Private Sub pdReportSales_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdReportDelivery.PrintPage
        fromPassDate = dtpFrom.Value
        toPassDate = dtpTo.Value

        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)

        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)


        Dim header As String = "On Demand Completed Delivery Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared by NG WEN DA", DateTime.Now & vbNewLine & vbNewLine &
                                                "Date range From " & fromPassDate.ToShortDateString & " - " & toPassDate.ToShortDateString)



        Dim db As New DBDataContext()
        Dim delivery = From d In db.Deliveries Where d.Status = "Complete" And d.Date >= fromPassDate And d.Date < toPassDate Select d.DeliveryId, d.OrderId, d.Date

        Dim body As New StringBuilder()
        body.AppendLine("Delivery ID      Order ID             Date         ")
        body.AppendLine("------------  ------------  -----------------")
        Dim cnt As Integer = 0

        For Each deli In delivery
            cnt += 1
            body.AppendFormat("{0,12}  {1,12} {2,17}" & vbNewLine, deli.DeliveryId, deli.OrderId, deli.Date.ToShortDateString)
            body.AppendLine("")
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)


        With e.Graphics
            .DrawString(header, fontHeader, Brushes.Purple, 160, 20)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 180, 80)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 40, 180)

        End With
    End Sub


End Class