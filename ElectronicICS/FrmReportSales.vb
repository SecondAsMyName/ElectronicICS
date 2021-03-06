﻿Imports System.Globalization
Imports System.Text

Public Class FrmReportSales
    Private fromPassDate As Date
    Private toPassDate As Date

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGenrate_Click(sender As Object, e As EventArgs) Handles btnGenrate.Click
        Dim fromDate As Date = dtpFrom.Value
        Dim toDate As Date = dtpTo.Value

        Dim db As New DBDataContext()
        Dim order = From o In db.Orders Where o.OrderStatus = "Complete" And o.OrderDate >= fromDate And o.OrderDate <= toDate

        With dgvReport
            .DataSource = order
            .Columns.Remove("User")
        End With
        lblCount.Text = order.Count.ToString("0 record(s).")
    End Sub

    Private Sub FrmReportMonthSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ppdReportSales.Document = pdReportSales
        ppdReportSales.ShowDialog(Me)
    End Sub

    Private Sub pdReportSales_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdReportSales.PrintPage
        fromPassDate = dtpFrom.Value
        toPassDate = dtpTo.Value
        ' (1) Fonts 
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        ' (2) Prepare header and sub-header 
        Dim header As String = "On Demand Sales Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared by LIMKAHHIM", DateTime.Now)

        ' (3) Prepare body 
        Dim db As New DBDataContext()
        Dim order = From o In db.Orders Where o.OrderStatus = "Complete" And o.OrderDate >= fromPassDate And o.OrderDate <= toPassDate Select o.OrderId, o.OrderDesc, o.OrderDate, o.Username

        Dim body As New StringBuilder()
        body.AppendLine("Order ID  Description                 Date                        Customer")
        body.AppendLine("--------  --------------------------  ------------------------    --------")
        Dim cnt As Integer = 0

        For Each orders In order
            cnt += 1
            body.AppendFormat("{0,8},{1,27},{2,25},{3,15}" & vbNewLine, orders.OrderId, orders.OrderDesc, orders.OrderDate, orders.Username)
            body.AppendLine("")
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        ' (4) Print 
        With e.Graphics
            .DrawImage(My.Resources.LIMKAHHIM, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub
End Class