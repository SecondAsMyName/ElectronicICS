﻿Public Class FrmCreatePO
    Private purchaseOrder As New PurchaseOrder
    Private purchaseLineList As New List(Of PurchaseLine)

    Private Sub FrmCreatePO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        cboSupplierID.SelectedIndex = 0
        cboItemID.SelectedIndex = -1
        purchaseOrder = New PurchaseOrder()
        With purchaseOrder
            .PoId = GetLastID()
            .Remarks = "New"
        End With
        purchaseLineList.Clear()
        BindDgvItem()
        lblPOID.Text = CType(purchaseOrder.PoId, String)
        lblDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub BindDgvItem()
        dgvItem.Rows.Clear()
        dgvItem.Columns.Clear()
        Dim dgvColumnItemID As New DataGridViewTextBoxColumn()
        With dgvColumnItemID
            .ReadOnly = True
            .HeaderText = "Item ID"
            .Name = "ItemID"
        End With
        Dim dgvColumnQuantity As New DataGridViewTextBoxColumn()
        With dgvColumnQuantity
            .ReadOnly = False
            .HeaderText = "Quantity"
            .Name = "Quantity"
            .DefaultCellStyle.Format = "N0"
        End With
        Dim dgvColumnPrice As New DataGridViewTextBoxColumn
        With dgvColumnPrice
            .ReadOnly = False
            .HeaderText = "Price"
            .Name = "Price"
            .DefaultCellStyle.Format = "N2"
        End With
        With dgvItem
            .ReadOnly = False
            .Columns.Add(dgvColumnItemID)
            .Columns.Add(dgvColumnQuantity)
            .Columns.Add(dgvColumnPrice)
        End With
    End Sub

    Private Sub RefreshDgvItem()
        dgvItem.Rows.Clear()

        For Each purchaseLine In purchaseLineList
            dgvItem.Rows.Add(purchaseLine.ItemID, purchaseLine.Quantity, purchaseLine.Price)
        Next
    End Sub

    Private Function GetLastID() As Integer
        Dim db As New DBDataContext
        Dim getid = From o In db.PurchaseOrders Select o.PoId
        Try
            getid.Max
        Catch ex As Exception
            Return 1000
        End Try
        Return getid.Max + 1
    End Function

    Private Sub BindData()
        Dim db As New DBDataContext()
        Dim supplierList = From o In db.Suppliers
        With cboSupplierID
            .DisplayMember = "SupplierId"
            .ValueMember = "SupplierId"
            .DataSource = supplierList
        End With
        Dim item = From o In db.Items
        With cboItemID
            .DisplayMember = "ItemID"
            .ValueMember = "ItemID"
            .DataSource = item
        End With

    End Sub

    Private Sub CboItemID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboItemID.SelectionChangeCommitted
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
                .Quantity = 0
            End With
            purchaseLineList.Add(purchaseLine)
        End If
        RefreshDgvItem()
    End Sub

    Private Sub CboSupplierID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplierID.SelectedIndexChanged
        Dim db As New DBDataContext()
        Dim supplierid As Integer = CInt(cboSupplierID.SelectedValue)
        Dim supplier = db.Suppliers.FirstOrDefault(Function(o) o.SupplierId = supplierid)
        txtSupplierDetails.Text = String.Format("Name: " & supplier.SupplierName & vbNewLine & "TelNo: " & supplier.TelNo & vbNewLine & "Email: " & supplier.Email)
    End Sub

    Private Sub DgvItem_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvItem.CellValidating
        Try
            If dgvItem.IsCurrentCellDirty Then
                Select Case dgvItem.Columns(e.ColumnIndex).Name.ToUpper
                    Case "Quantity"
                        If Not IsNumeric(e.FormattedValue) Then
                            MsgBox("Invalid value.")
                            e.Cancel = True
                            Exit Sub
                        End If

                        If CType(e.FormattedValue, Integer) < 0 Then
                            MsgBox("Invalid value.")
                            e.Cancel = True
                            Exit Sub
                        End If
                    Case "Price"
                        If Not IsNumeric(e.FormattedValue) Then
                            MsgBox("Invalid value.")
                            e.Cancel = True
                            Exit Sub
                        End If

                        If CType(e.FormattedValue, Integer) < 0 Then
                            MsgBox("Invalid value.")
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvItem_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellEndEdit
        Dim tempPurchaseLList As New List(Of PurchaseLine)
        Try
            Dim dgvRow As DataGridViewRow
            For Each dgvRow In dgvItem.Rows
                Dim purchaseLine As New PurchaseLine
                With purchaseLine
                    .PoID = purchaseOrder.PoId
                    .ItemID = CInt(dgvRow.Cells(0).Value.ToString)
                    .Quantity = CInt(dgvRow.Cells(1).Value.ToString)
                    .Price = CDec(dgvRow.Cells(2).Value.ToString)
                End With
                tempPurchaseLList.Add(purchaseLine)
            Next
            Dim i As Decimal = CDec(Me.dgvItem.SelectedCells(0).Value.ToString)
            purchaseLineList = tempPurchaseLList
        Catch ex As Exception
            Me.dgvItem.SelectedCells(0).Value = "0"
        End Try

    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim db As New DBDataContext()
        For Each purchaseLine As PurchaseLine In purchaseLineList
            If (purchaseLine.Quantity < 1 Or purchaseLine.Price < 0.01D) Then
                MessageBox.Show("Please enter quantity and price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim newPurchaseLine As New PurchaseLine
            With newPurchaseLine
                .ItemID = purchaseLine.ItemID
                .PoID = purchaseOrder.PoId
                .Quantity = purchaseLine.Quantity
                .Price = purchaseLine.Price
            End With

            db.PurchaseLines.InsertOnSubmit(newPurchaseLine)
        Next

        With purchaseOrder
            .Remarks = "Pending"
            .OrderDate = System.DateTime.Now
            .SupplierID = CInt(cboSupplierID.SelectedValue.ToString)
        End With
        db.PurchaseOrders.InsertOnSubmit(purchaseOrder)
        Try
            db.SubmitChanges()
            MessageBox.Show(String.Format("Purchase Order [{0}] created.", purchaseOrder.PoId), "Create PO Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(String.Format("Purchase Order create fail." & vbNewLine & ex.Message), "Create PO Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class