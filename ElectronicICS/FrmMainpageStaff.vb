Public Class FrmMainpageStaff
    Public staff As User

    Private Sub MnusMS_Click(sender As Object, e As EventArgs) Handles mnusMS.Click
        Me.Hide()
        FrmManageStock.ShowDialog()
    End Sub

    Private Sub PcManageStock_Click(sender As Object, e As EventArgs) Handles pcManageStock.Click
        MnusMS_Click(Nothing, Nothing)
    End Sub

    Private Sub PaymentTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentTransactionToolStripMenuItem.Click
        PaymentTransReport.ShowDialog()
    End Sub


    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        FrmReportSales.Show()
    End Sub
End Class