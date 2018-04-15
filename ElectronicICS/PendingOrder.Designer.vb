<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PendingOrder
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
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.dgvPending = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pending Order of : "
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(137, 24)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(103, 31)
        Me.lblUser.TabIndex = 1
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(30, 342)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(185, 19)
        Me.lblCount.TabIndex = 2
        '
        'dgvPending
        '
        Me.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPending.Location = New System.Drawing.Point(33, 68)
        Me.dgvPending.Name = "dgvPending"
        Me.dgvPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPending.Size = New System.Drawing.Size(415, 250)
        Me.dgvPending.TabIndex = 3
        '
        'PendingOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 383)
        Me.Controls.Add(Me.dgvPending)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PendingOrder"
        Me.Text = "PendingOrder"
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents dgvPending As DataGridView
End Class
