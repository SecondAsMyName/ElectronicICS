<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentHistoryPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPayHistoryCount = New System.Windows.Forms.Label()
        Me.dgvPaymentHistory = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgvPaymentHistory
        '
        Me.dgvPaymentHistory.AllowUserToAddRows = False
        Me.dgvPaymentHistory.AllowUserToDeleteRows = False
        Me.dgvPaymentHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentHistory.Location = New System.Drawing.Point(15, 38)
        Me.dgvPaymentHistory.Name = "dgvPaymentHistory"
        Me.dgvPaymentHistory.ReadOnly = True
        Me.dgvPaymentHistory.Size = New System.Drawing.Size(570, 183)
        Me.dgvPaymentHistory.TabIndex = 3
        '
        'PaymentHistoryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 274)
        Me.Controls.Add(Me.dgvPaymentHistory)
        Me.Controls.Add(Me.lblPayHistoryCount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaymentHistoryPage"
        Me.Text = "PaymentHistory"
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPayHistoryCount As Label
    Friend WithEvents dgvPaymentHistory As DataGridView
End Class
