Imports System.Text

Public Class FrmMainpageStaff
    Public staff As User

    Private Sub PcManageStock_Click(sender As Object, e As EventArgs) Handles pcManageStock.Click
        MnusMS_Click(Nothing, Nothing)
    End Sub

    Private Sub PcPurchaseOrder_Click(sender As Object, e As EventArgs) Handles pcPurchaseOrder.Click
        MnusSupplyPO_Click(Nothing, Nothing)
    End Sub
    Private Sub MnusMS_Click(sender As Object, e As EventArgs) Handles mnusMS.Click
        FrmManageStock.ShowDialog()
    End Sub
    Private Sub PcInvValSumm_Click(sender As Object, e As EventArgs) Handles pcInvValSumm.Click
        dlgPreviewInv.Document = docInv
        dlgPreviewInv.ShowDialog(Me)
    End Sub

    Private Sub PaymentTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentTransactionToolStripMenuItem.Click
        Me.Hide()
        PaymentTransReport.Show()
    End Sub


    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        FrmReportSales.Show()
    End Sub

    Private Sub MnusSupplyPO_Click(sender As Object, e As EventArgs) Handles mnusSupplyPO.Click
        FrmManagePO.ShowDialog()
    End Sub

    Private Sub MnusRprtSmmInvValue_Click(sender As Object, e As EventArgs) Handles mnusRprtSmmInvValue.Click
        PcInvValSumm_Click(Nothing, Nothing)
    End Sub

    Private Sub docInv_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docInv.PrintPage
        ' (1) Fonts 
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        ' (2) Prepare header and sub-header 
        Dim header As String = "Inventory Values Summary Report"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared by LOW SING KEAT", DateTime.Now)

        ' (3) Prepare body 
        Dim db As New DBDataContext()
        Dim items = From o In db.Items
        Dim body As New StringBuilder()
        body.AppendLine("Item ID    Item Name                          Price (RM)  In Stock Quantity   Stock Value (RM)")
        body.AppendLine("-------    ---------------------------------  ----------  -----------------   ----------------")
        Dim cnt As Integer = 0
        Dim ttlvalue As Decimal = 0.00D
        For Each item In items
            cnt += 1
            body.AppendFormat("{0,8}    {1,30}  {2,10}  {3,17}  {4,13}" & vbNewLine, item.ItemID, item.ItemName, item.ItemPrice, item.Quantity, item.ItemPrice * item.Quantity)
            ttlvalue += item.ItemPrice * item.Quantity
            body.AppendLine("")
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} item(s)", cnt)
        body.AppendLine()
        body.AppendFormat("Summary: ")
        body.AppendLine()
        body.AppendFormat("Inventory Total Value: RM {0,2}", ttlvalue)
        body.AppendLine()
        body.AppendLine()
        body.AppendFormat("End of Report.")
        ' (4) Print 
        With e.Graphics
            .DrawImage(My.Resources.LogoMakr_9T5ghY, 0, 0, 240, 100)
            .DrawString(header, fontHeader, Brushes.Green, 240, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 240, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub mnusLogout_Click(sender As Object, e As EventArgs) Handles mnusLogout.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub mnusExit_Click(sender As Object, e As EventArgs) Handles mnusExit.Click
        Me.Close()
    End Sub

    Private Sub ManageSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSupplierToolStripMenuItem.Click
        FrmManageSupplier.ShowDialog(Me)
    End Sub
End Class