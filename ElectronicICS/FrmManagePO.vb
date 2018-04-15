Public Class FrmManagePO
    Private selectedItemID As Integer = -1
    Private Sub BindData()
        Dim status As String = cboStatus.Text

        Dim db As New DBDataContext()
        Dim rs = From PO In db.PurchaseOrders
                 Where (status = "All" Or PO.Remarks = status)

        dgvPo.DataSource = rs
    End Sub
    Private Sub FrmManagePO_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        BindData()
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.Hide()
        FrmCreatePO.ShowDialog(Me)
        Me.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedItemID = -1 Then
            MessageBox.Show("Please select one of the item from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim db As New DBDataContext()
        Dim i As PurchaseOrder = db.PurchaseOrders.FirstOrDefault(Function(o) o.PoId = selectedItemID)

        If i Is Nothing Then
            MessageBox.Show("PO not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If i.Remarks <> "Pending" And i.Remarks <> "Rejected" Then
            MessageBox.Show("Only PO with status Pending and Rejected can be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Dim s As String = String.Format("Are you sure to delete the PO?" & vbNewLine & "The PO will delete from database.")
            Dim response As Integer = MessageBox.Show(s, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If response = DialogResult.Yes Then
                Try
                    Dim deletePurchaseLine = (From purchaseLine In db.PurchaseLines Where purchaseLine.PoID = selectedItemID)
                    For Each purchaseLine In deletePurchaseLine
                        db.PurchaseLines.DeleteOnSubmit(purchaseLine)
                    Next

                    Dim deletePO = (From purchaseOrder In db.PurchaseOrders Where purchaseOrder.PoId = selectedItemID).ToList()(0)
                    db.PurchaseOrders.DeleteOnSubmit(deletePO)

                    db.SubmitChanges()

                    Dim msgDelete As String = String.Format("Purchase Order [{0}] deleted.", selectedItemID)
                    MessageBox.Show(msgDelete, "Delete success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Delete fail.", "Unable to delete", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End Try
            End If
        End If
        BindData()
    End Sub

    Private Sub DgvPo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPo.CellDoubleClick

    End Sub

    Private Sub DgvPo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPo.CellClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            selectedItemID = CInt(dgvPo.Rows(i).Cells(0).Value)
        End If
    End Sub
End Class