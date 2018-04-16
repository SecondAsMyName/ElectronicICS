Public Class FrmManageSupplier
    Private selectedSupplierID As Integer = -1

    Private Sub BindData()
        Dim name As String = txtName.Text

        Dim db As New DBDataContext()
        Dim rs = From supplier In db.Suppliers
                 Where supplier.SupplierName.Contains(name)

        dgvSupplier.DataSource = rs

        lblSupplierCount.Text = rs.Count().ToString("0 Supplier(s)")
    End Sub

    Private Sub FrmManageStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmCreateSupplier.ShowDialog(Me)
        BindData()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedSupplierID = -1 Then
            MessageBox.Show("Please select one of the supplier from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim s As String = String.Format("Are you sure to delete the supplier?" & vbNewLine & "The supplier will delete from database.")
        Dim response As Integer = MessageBox.Show(s, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If response = DialogResult.Yes Then
            Dim db As New DBDataContext()
            Dim i As Supplier = db.Suppliers.FirstOrDefault(Function(o) o.SupplierId = selectedSupplierID)

            If i Is Nothing Then
                MessageBox.Show("Supplier not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Dim deleteSupplier = (From supp In db.Suppliers Where supp.SupplierId = selectedSupplierID).ToList()(0)
                db.Suppliers.DeleteOnSubmit(deleteSupplier)
                db.SubmitChanges()

                Dim msgDelete As String = String.Format("Supplier [{0}] deleted.", selectedSupplierID)
                MessageBox.Show(msgDelete, "Delete success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("The supplier can't be deleted.", "Unable to delete", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

        BindData()
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        BindData()
    End Sub

    Private Sub dgvSupplier_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            FrmUpdateSupplier.supplierID = selectedSupplierID
            FrmUpdateSupplier.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub DgvSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            selectedSupplierID = CInt(dgvSupplier.Rows(i).Cells(0).Value)
        End If
    End Sub
End Class