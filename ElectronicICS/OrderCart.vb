Public Class OrderCart
    Private Sub BindData()
        Dim db As New DBDataContext()

        Dim rs = From o In db.Items




    End Sub

    Private Sub OrderCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class