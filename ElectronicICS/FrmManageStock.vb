Public Class FrmManageStock
    Private selectedItemID As Integer = -1
    Private Sub BindData()
        Dim name As String = txtName.Text

        Dim db As New DBDataContext()
        Dim rs = From item In db.Items
                 Where item.ItemName.Contains(name)

        dgvItems.DataSource = rs

        lblItemCount.Text = rs.Count().ToString("0 Item(s)")
    End Sub

    Private Sub FrmManageStock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMainpageStaff.Show()
    End Sub

    Private Sub FrmManageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub DgvItems_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            FrmUpdateItem.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedItemID = -1 Then
            MessageBox.Show("Please select one of the item from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim s As String = String.Format("Are you sure to delete the item?" & vbNewLine & "The item will delete from database.")
        Dim response As Integer = MessageBox.Show(s, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If response = DialogResult.Yes Then
            Dim db As New DBDataContext()
            Dim i As Item = db.Items.FirstOrDefault(Function(o) o.ItemID = selectedItemID)

            If i Is Nothing Then
                MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Dim deleteItem = (From item In db.Items Where item.ItemID = selectedItemID).ToList()(0)

                db.Items.DeleteOnSubmit(deleteItem)
            Catch ex As Exception
                MessageBox.Show("The item has been ordered by customer.", "Unable to delete", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

        BindData()
    End Sub

    Private Sub DgvItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            selectedItemID = CInt(dgvItems.Rows(i).Cells(0).Value)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmCreateItem.ShowDialog(Me)
        BindData()
    End Sub
End Class