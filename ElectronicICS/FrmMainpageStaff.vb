﻿Public Class FrmMainpageStaff
    Public staff As User

    Private Sub MnusMS_Click(sender As Object, e As EventArgs) Handles mnusMS.Click
        Me.Hide()
        FrmManageStock.ShowDialog()
    End Sub

    Private Sub PcManageStock_Click(sender As Object, e As EventArgs) Handles pcManageStock.Click
        MnusMS_Click(Nothing, Nothing)
    End Sub
End Class