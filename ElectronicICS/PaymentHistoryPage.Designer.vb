<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentHistoryPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPayHistoryCount = New System.Windows.Forms.Label()
        Me.lstPaymentHistory = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment History"
        '
        'lblPayHistoryCount
        '
        Me.lblPayHistoryCount.Location = New System.Drawing.Point(12, 237)
        Me.lblPayHistoryCount.Name = "lblPayHistoryCount"
        Me.lblPayHistoryCount.Size = New System.Drawing.Size(184, 28)
        Me.lblPayHistoryCount.TabIndex = 2
        '
        'lstPaymentHistory
        '
        Me.lstPaymentHistory.FormattingEnabled = True
        Me.lstPaymentHistory.Location = New System.Drawing.Point(16, 43)
        Me.lstPaymentHistory.Name = "lstPaymentHistory"
        Me.lstPaymentHistory.Size = New System.Drawing.Size(592, 186)
        Me.lstPaymentHistory.TabIndex = 3
        '
        'PaymentHistoryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 274)
        Me.Controls.Add(Me.lstPaymentHistory)
        Me.Controls.Add(Me.lblPayHistoryCount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaymentHistoryPage"
        Me.Text = "PaymentHistory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPayHistoryCount As Label
    Friend WithEvents lstPaymentHistory As ListBox
End Class
