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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOrderCartCount = New System.Windows.Forms.Label()
        Me.dgvOrderCart = New System.Windows.Forms.DataGridView()
        CType(Me.dgvOrderCart, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pick 1 to be able to process tranasction."
        '
        'lblOrderCartCount
        '
        Me.lblOrderCartCount.Location = New System.Drawing.Point(26, 258)
        Me.lblOrderCartCount.Name = "lblOrderCartCount"
        Me.lblOrderCartCount.Size = New System.Drawing.Size(100, 23)
        Me.lblOrderCartCount.TabIndex = 6
        '
        'dgvOrderCart
        '
        Me.dgvOrderCart.AllowUserToAddRows = False
        Me.dgvOrderCart.AllowUserToDeleteRows = False
        Me.dgvOrderCart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrderCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderCart.Location = New System.Drawing.Point(16, 44)
        Me.dgvOrderCart.Name = "dgvOrderCart"
        Me.dgvOrderCart.ReadOnly = True
        Me.dgvOrderCart.Size = New System.Drawing.Size(473, 163)
        Me.dgvOrderCart.TabIndex = 7
        '
        'PaymentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 299)
        Me.Controls.Add(Me.dgvOrderCart)
        Me.Controls.Add(Me.lblOrderCartCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaymentPage"
        Me.Text = "PaymentPage"
        CType(Me.dgvOrderCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOrderCartCount As Label
    Friend WithEvents dgvOrderCart As DataGridView
End Class
