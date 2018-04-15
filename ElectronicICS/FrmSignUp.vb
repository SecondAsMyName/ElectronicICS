Public Class FrmSignUp
    Private Sub FrmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Close The form?", "Form Closing", MessageBoxButtons.OKCancel)
        If answer = DialogResult.OK Then
            Me.Close()
        Else
        End If
    End Sub
End Class