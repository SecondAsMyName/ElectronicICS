Imports System.Globalization

Public Class FrmReportMonthSales
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGenrate_Click(sender As Object, e As EventArgs) Handles btnGenrate.Click
        Dim fromDate As Date = dtpFrom.Value
        Dim toDate As Date = dtpTo.Value

        Dim db As New DBDataContext()
        Dim order = From o In db.Orders Where o.OrderStatus = "Complete" And o.OrderDate >= fromDate And o.OrderDate < toDate

        With dgvReport
            .DataSource = order
            .Columns.Remove("User")
        End With
        lblCount.Text = order.Count.ToString("0 record(s).")
    End Sub

    Private Sub FrmReportMonthSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class