Public Class FrmOrderChecking

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    Private Sub FrmOrderChecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pass = GetPassPara()
        lblOrder.Text = pass

        Dim db As New DBDataContext()
        'Dim ordDate = From o In db.Orders Where o.OrderId = num Select o.OrderDate
        Dim ordDesc = From o In db.Orders Where o.OrderId = CInt(pass) Select o.OrderDesc
        Dim itemCode = From ol In db.OrderLines Where ol.OrderId = CInt(pass) Select ol.ItemId
        Dim code = itemCode.FirstOrDefault()
        Dim desc = From i In db.Items Where i.ItemID = code Select i.ItemDesc

        lblDesc.Text = ordDesc.FirstOrDefault.ToString()
        lblItemID.Text = code.ToString()
        lblItemDesc.Text = desc.FirstOrDefault.ToString()
    End Sub

    Public Function GetPassPara() As String
        Return FrmTrackDelivery.lblOrderID.Text
    End Function
End Class