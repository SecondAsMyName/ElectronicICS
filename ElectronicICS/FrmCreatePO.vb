Public Class FrmCreatePO
    Private purchaseOrder As New PurchaseOrder
    Private purchaseLineList As New List(Of PurchaseLine)

    Private Sub CboItemID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemID.SelectedIndexChanged
        Dim selectedItemID As Integer = CInt(cboItemID.SelectedValue.ToString)

        Dim i As Integer = 0
        Dim exist As Boolean = False
        For Each pL In purchaseLineList
            If pL.ItemID = selectedItemID Then
                purchaseLineList.RemoveAt(i)
                exist = True
                Exit For
            End If
            i += 1
        Next

        If exist = False Then
            Dim purchaseLine As New PurchaseLine
            With purchaseLine
                .PoID = purchaseOrder.PoId
                .ItemID = selectedItemID
                .Quantity = 1
            End With
            purchaseLineList.Add(purchaseLine)
        End If

        dgvItem.DataSource = purchaseLineList
    End Sub

    Private Sub FrmCreatePO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        cboSupplierID.SelectedIndex = 0

        With purchaseOrder
            .PoId = GetLastID()
            .Remarks = "New"
        End With
    End Sub

    Private Function GetLastID() As Integer
        Dim db As New DBDataContext
        Dim getid = From o In db.PurchaseOrders Select o.PoId
        Return getid.Max + 1
    End Function

    Private Sub BindData()
        Dim db As New DBDataContext()
        Dim supplierList = From o In db.Suppliers
        cboSupplierID.DataSource = supplierList
        cboSupplierID.DisplayMember = "SupplierId"
        cboSupplierID.ValueMember = "SupplierId"

        Dim item = From o In db.Items
        cboItemID.DataSource = item
        cboItemID.DisplayMember = "ItemID"
        cboItemID.ValueMember = "ItemID"

    End Sub

    Private Sub CboSupplierID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplierID.SelectedIndexChanged
        Dim db As New DBDataContext()
        Dim supplier = db.Suppliers.FirstOrDefault(Function(o) o.SupplierId = CInt(cboSupplierID.SelectedValue))
        txtSupplierDetails.Text = String.Format("Name: " & supplier.SupplierName & vbNewLine & "TelNo: " & supplier.TelNo & vbNewLine & "Email: " & supplier.Email)
    End Sub
End Class