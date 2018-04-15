Imports System.Text

Public Class FrmViewPO
    Dim purchaseOrder As New PurchaseOrder

    Private Sub BindData()
        Dim db As New DBDataContext()
        Dim purchaseLine = From p In db.PurchaseLines Where p.PoID = FrmManagePO.selectedPOID
        With dgvPO
            .DataSource = purchaseLine
            .Columns.Remove("PoID")
            .Columns.Remove("Item")
            .Columns.Remove("PurchaseOrder")
        End With

        purchaseOrder = db.PurchaseOrders.FirstOrDefault(Function(o) o.PoId = FrmManagePO.selectedPOID)
    End Sub

    Private Sub BtnCreateDO_Click(sender As Object, e As EventArgs) Handles btnCreateDO.Click
        If Me.ValidateChildren = False Then
            Return
        End If
        Dim db As New DBDataContext()
        Dim newDO As New DeliveryOrder
        With newDO
            .DoId = GetLastID()
            .PoID = FrmManagePO.selectedPOID
            .DeliveryDate = dtpDeliveryDate.Value
            .Remarks = "Delivering"
            .Address = txtAddress.Text
        End With

        db.DeliveryOrders.InsertOnSubmit(newDO)

        Dim updatePO = (From po In db.PurchaseOrders Where po.PoId = FrmManagePO.selectedPOID).ToList()(0)
        updatePO.Remarks = "Accepted"

        Try
            db.SubmitChanges()
            MessageBox.Show(String.Format("Delivery Order for purchase order [{0}] create successful.", FrmManagePO.selectedPOID), "Create DO success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error encounter. Unable to Create the delivery order.", "Create fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub

    Private Function GetLastID() As Integer
        Dim db As New DBDataContext
        Dim getid = From o In db.DeliveryOrders Select o.DoId
        Try
            getid.Max
        Catch ex As Exception
            Return 1000
        End Try
        Return getid.Max + 1
    End Function

    Private Sub BtnCloseDO_Click(sender As Object, e As EventArgs) Handles btnCloseDO.Click
        Dim db As New DBDataContext
        Dim updatePO = (From po In db.PurchaseOrders Where po.PoId = FrmManagePO.selectedPOID).ToList()(0)
        updatePO.Remarks = "Closed"
        Dim updateDO = (From d In db.DeliveryOrders Where d.PoID = FrmManagePO.selectedPOID).ToList()(0)
        updateDO.Remarks = "Closed"

        For Each pl As PurchaseLine In From p In db.PurchaseLines Where p.PoID = FrmManagePO.selectedPOID
            Dim updateItem = (From i In db.Items Where i.ItemID = pl.ItemID).ToList()(0)
            updateItem.Quantity = updateItem.Quantity + pl.Quantity
        Next

        Try
            db.SubmitChanges()
            MessageBox.Show("Stock amount has been updated.", "Stock In success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error encounter. Unable to update stock amount.", "Stock In fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    Private Sub FrmViewPO_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        BindData()

        Dim db As New DBDataContext()
        Dim deliveryOrder As DeliveryOrder = db.DeliveryOrders.FirstOrDefault(Function(o) o.PoID = FrmManagePO.selectedPOID)

        If deliveryOrder Is Nothing Then
            btnCreateDO.Visible = True
            btnCloseDO.Visible = False
        Else
            btnCreateDO.Visible = False
            If deliveryOrder.Remarks = "Delivering" Then
                btnCloseDO.Visible = True
            Else
                btnCloseDO.Visible = False
            End If
            dtpDeliveryDate.Value = deliveryOrder.DeliveryDate
            dtpDeliveryDate.Enabled = False
            txtAddress.Text = deliveryOrder.Address.ToString
            txtAddress.Enabled = False
        End If

        lblPOID.Text = FrmManagePO.selectedPOID.ToString
        lblOrderDate.Text = purchaseOrder.OrderDate.ToString("dd/MM/yyyy")
        lblSupplierName.Text = purchaseOrder.Supplier.SupplierName.ToString
    End Sub

    Private Sub txtAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAddress.Validating
        Dim address As String = txtAddress.Text

        If address = "" Then
            err.SetError(txtAddress, "Please enter address")
            e.Cancel = True
        Else
            err.SetError(txtAddress, Nothing)
        End If
    End Sub

    Private Sub dtpDeliveryDate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpDeliveryDate.Validating
        Dim deliveryDate As Date = dtpDeliveryDate.Value

        If deliveryDate <= purchaseOrder.OrderDate Then
            err.SetError(dtpDeliveryDate, "Please select a date after order date.")
        Else
            err.SetError(dtpDeliveryDate, Nothing)
        End If
    End Sub

    Private Sub btnPring_Click(sender As Object, e As EventArgs) Handles btnPring.Click
        dlgPriviewPO.Document = docPO
        dlgPriviewPO.ShowDialog(Me)
    End Sub

    Private Sub docPO_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docPO.PrintPage
        ' (1) Fonts 
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        ' (2) Prepare header and sub-header 
        Dim header As String = "Purchase Order"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared by LOW SING KEAT", DateTime.Now & vbNewLine &
                                                "Purchase Order ID: " & FrmManagePO.selectedPOID & vbNewLine &
                                                "Order Date: " & purchaseOrder.OrderDate.ToString("dd/MM/yyyy") & vbNewLine &
                                                "Supplier Name: " & purchaseOrder.Supplier.SupplierName & vbNewLine &
                                                "Supplier Ref. ID: " & purchaseOrder.SupplierID)

        ' (3) Prepare body 
        Dim db As New DBDataContext()
        Dim pl = From o In db.PurchaseLines Where o.PoID = FrmManagePO.selectedPOID
        Dim body As New StringBuilder()
        body.AppendLine("Item ID    Item Name                          Quantity  Price (RM)")
        body.AppendLine("-------    ---------------------------------  --------  ----------")
        Dim cnt As Integer = 0
        Dim ttlPrice As Decimal = 0.00D
        For Each purchaseLine As PurchaseLine In pl
            cnt += 1
            body.AppendFormat("{0,7}    {1,30}  {2,10}  {3,10}" & vbNewLine, purchaseLine.Item.ItemID, purchaseLine.Item.ItemName, purchaseLine.Quantity, purchaseLine.Price)
            ttlPrice += purchaseLine.Price.GetValueOrDefault(0)
            body.AppendLine("")
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} item(s)", cnt)
        body.AppendLine()
        body.AppendFormat("Summary: ")
        body.AppendLine()
        body.AppendFormat("Total cost: RM {0,2}", ttlPrice)
        body.AppendLine()
        body.AppendLine()
        body.AppendFormat("End of Purchase Order.")
        ' (4) Print 
        With e.Graphics
            .DrawImage(My.Resources.LogoMakr_9T5ghY, 0, 0, 380, 100)
            .DrawString(header, fontHeader, Brushes.Green, 380, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 380, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 200)
        End With
    End Sub
End Class