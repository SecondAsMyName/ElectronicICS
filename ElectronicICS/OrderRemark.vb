Public Class OrderRemark
    Private Username As String

    Private Sub BindData()
        Dim db As New DBDataContext()
        Dim order = From o In db.Orders Where o.Username = Username And o.OrderStatus = "Pending"
        cboOrderId.DataSource = order
        cboOrderId.DisplayMember = "OrderId"
        cboOrderId.ValueMember = "OrderId"
    End Sub

    Private Sub resetForm()
        BindData()
        txtRemark.Text = ""
        cboOrderId.SelectedIndex = 0
        cboOrderId_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub OrderRemark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Username = MainPage.customer.Username
        txtUser.Text = " " & Username
        txtSysDate.Text = System.DateTime.Now.ToString(" dd/mm/yyyy")
        resetForm()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim orderid As Integer = If(TypeOf cboOrderId.SelectedValue Is Integer, DirectCast(cboOrderId.SelectedValue, Integer), 0)
        Dim db As New DBDataContext()
        Dim updateOrderRemark = (From ord In db.Orders
                                 Where ord.OrderId = orderid).ToList()(0)

        updateOrderRemark.OrderDesc = txtRemark.Text

        Try
            db.SubmitChanges()
            MessageBox.Show("Remark submited.")
        Catch
            MessageBox.Show("No remark submited.")
        End Try
        Me.Close()
    End Sub

    Private Sub cboOrderId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrderId.SelectedIndexChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub OrderRemark_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        OrderRemark_Load(Nothing, Nothing)
    End Sub
End Class