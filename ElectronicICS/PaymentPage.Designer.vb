<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentPage
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
        Me.dgvOrderCart = New System.Windows.Forms.DataGridView()
        Me.mnuPaymentMenu = New System.Windows.Forms.MenuStrip()
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PaymentHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvOrderCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPaymentMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Order Cart :"
        '
        'dgvOrderCart
        '
        Me.dgvOrderCart.AllowUserToAddRows = False
        Me.dgvOrderCart.AllowUserToDeleteRows = False
        Me.dgvOrderCart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrderCart.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrderCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderCart.Location = New System.Drawing.Point(16, 56)
        Me.dgvOrderCart.Name = "dgvOrderCart"
        Me.dgvOrderCart.ReadOnly = True
        Me.dgvOrderCart.Size = New System.Drawing.Size(667, 227)
        Me.dgvOrderCart.TabIndex = 7
        '
        'mnuPaymentMenu
        '
        Me.mnuPaymentMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToolStripMenuItem, Me.PaymentHistoryToolStripMenuItem})
        Me.mnuPaymentMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuPaymentMenu.Name = "mnuPaymentMenu"
        Me.mnuPaymentMenu.Size = New System.Drawing.Size(714, 24)
        Me.mnuPaymentMenu.TabIndex = 9
        Me.mnuPaymentMenu.Text = "MenuStrip1"
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.GoBackToolStripMenuItem.Text = "Go back"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Order List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Pick 1 to be able to process tranasction."
        '
        'PaymentHistoryToolStripMenuItem
        '
        Me.PaymentHistoryToolStripMenuItem.Name = "PaymentHistoryToolStripMenuItem"
        Me.PaymentHistoryToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.PaymentHistoryToolStripMenuItem.Text = "Payment History"
        '
        'PaymentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(714, 318)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mnuPaymentMenu)
        Me.Controls.Add(Me.dgvOrderCart)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaymentPage"
        Me.Text = "Payment Page(Order List)"
        CType(Me.dgvOrderCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPaymentMenu.ResumeLayout(False)
        Me.mnuPaymentMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvOrderCart As DataGridView
    Friend WithEvents mnuPaymentMenu As MenuStrip
    Friend WithEvents GoBackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PaymentHistoryToolStripMenuItem As ToolStripMenuItem
End Class
