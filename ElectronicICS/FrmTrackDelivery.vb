Public Class FrmTrackDelivery
    Private Sub txtDeliveryID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDeliveryID.KeyDown
        Try
            Dim db As New DBDataContext()
            If e.KeyCode = Keys.Enter Then
                Dim deliID As Integer = Integer.Parse(txtDeliveryID.Text)
                Dim getID = From d In db.Deliveries Where d.DeliveryId = deliID Select d.OrderId
                lblOrderID.Text = getID.FirstOrDefault().ToString()
                Dim getStatus = From s In db.Deliveries Where s.DeliveryId = deliID Select s.Status
                Dim strStatus = getStatus.FirstOrDefault().ToString()
                lblStatus.Text = strStatus
                If (strStatus = "Complete") Then
                    btnCheckOrder.Enabled = False
                Else
                    btnCheckOrder.Enabled = True
                End If
            End If
        Catch
            MessageBox.Show("No result found!")
            ResetForm()
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        DeliveryMenu.Visible = True
    End Sub

    Private Sub ResetForm()
        txtDeliveryID.Text = ""
        txtDeliveryID.Select()
        lblStatus.Text = ""
        lblOrderID.Text = ""
        btnCheckOrder.Enabled = True
    End Sub

    Private Sub btnCheckOrder_Click(sender As Object, e As EventArgs) Handles btnCheckOrder.Click

        FrmOrderChecking.ShowDialog()

    End Sub



End Class
