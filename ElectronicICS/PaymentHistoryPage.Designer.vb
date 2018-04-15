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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuPaymentHistoryMenu = New System.Windows.Forms.MenuStrip()
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPaymentHistoryMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
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
        Me.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentHistory.Location = New System.Drawing.Point(15, 50)
        Me.dgvPaymentHistory.Name = "dgvPaymentHistory"
        Me.dgvPaymentHistory.ReadOnly = True
        Me.dgvPaymentHistory.Size = New System.Drawing.Size(567, 170)
        Me.dgvPaymentHistory.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(507, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'mnuPaymentHistoryMenu
        '
        Me.mnuPaymentHistoryMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToolStripMenuItem})
        Me.mnuPaymentHistoryMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuPaymentHistoryMenu.Name = "mnuPaymentHistoryMenu"
        Me.mnuPaymentHistoryMenu.Size = New System.Drawing.Size(611, 24)
        Me.mnuPaymentHistoryMenu.TabIndex = 6
        Me.mnuPaymentHistoryMenu.Text = "MenuStrip1"
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.GoBackToolStripMenuItem.Text = "Go Back"
        '
        'PaymentHistoryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(611, 297)
        Me.Controls.Add(Me.mnuPaymentHistoryMenu)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvPaymentHistory)
        Me.Controls.Add(Me.lblPayHistoryCount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaymentHistoryPage"
        Me.Text = "Payment History"
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPaymentHistoryMenu.ResumeLayout(False)
        Me.mnuPaymentHistoryMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPayHistoryCount As Label
    Friend WithEvents dgvPaymentHistory As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents mnuPaymentHistoryMenu As MenuStrip
    Friend WithEvents GoBackToolStripMenuItem As ToolStripMenuItem
End Class
