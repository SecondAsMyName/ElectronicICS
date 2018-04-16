<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageStaff
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
        Me.lblSupplierCount = New System.Windows.Forms.Label()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSupplierCount
        '
        Me.lblSupplierCount.Location = New System.Drawing.Point(12, 403)
        Me.lblSupplierCount.Name = "lblSupplierCount"
        Me.lblSupplierCount.Size = New System.Drawing.Size(112, 23)
        Me.lblSupplierCount.TabIndex = 14
        '
        'lblTip
        '
        Me.lblTip.Location = New System.Drawing.Point(12, 380)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(404, 23)
        Me.lblTip.TabIndex = 13
        Me.lblTip.Text = "Double click the item in the list to update the Supplier's information."
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(671, 447)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 447)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 33)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&Add New Supplier"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Location = New System.Drawing.Point(15, 57)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.RowTemplate.Height = 24
        Me.dgvSupplier.Size = New System.Drawing.Size(731, 320)
        Me.dgvSupplier.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.CausesValidation = False
        Me.txtName.Location = New System.Drawing.Point(75, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "&Name: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmManageStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(780, 482)
        Me.Controls.Add(Me.lblSupplierCount)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvSupplier)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmManageStaff"
        Me.Text = "Manage Staff"
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSupplierCount As Label
    Friend WithEvents lblTip As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
End Class
