Public Class OrderCart
    Private Sub BindData()
        Dim db As New DBDataContext()

        Dim rs = From o In db.Items
        cboItem.Items.Add(rs)

    End Sub

    Private Sub OrderCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

End Class