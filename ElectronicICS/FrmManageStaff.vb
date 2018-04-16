Public Class FrmManageStaff
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmCreateSupplier.ShowDialog(Me)
        BindData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

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

    Private Sub dgvSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            selectedSupplierID = CInt(dgvSupplier.Rows(i).Cells(0).Value)
        End If
    End Sub
End Class