<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreatePO
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
        Me.gbPo = New System.Windows.Forms.GroupBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPOID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbSupplier = New System.Windows.Forms.GroupBox()
        Me.txtSupplierDetails = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSupplierID = New System.Windows.Forms.ComboBox()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.cboItemID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbPo.SuspendLayout()
        Me.gbSupplier.SuspendLayout()
        Me.gbItem.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Order ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbPo
        '
        Me.gbPo.Controls.Add(Me.lblDate)
        Me.gbPo.Controls.Add(Me.lblPOID)
        Me.gbPo.Controls.Add(Me.Label2)
        Me.gbPo.Controls.Add(Me.Label1)
        Me.gbPo.Location = New System.Drawing.Point(12, 12)
        Me.gbPo.Name = "gbPo"
        Me.gbPo.Size = New System.Drawing.Size(318, 100)
        Me.gbPo.TabIndex = 1
        Me.gbPo.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Location = New System.Drawing.Point(148, 62)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(164, 23)
        Me.lblDate.TabIndex = 3
        '
        'lblPOID
        '
        Me.lblPOID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPOID.Location = New System.Drawing.Point(148, 22)
        Me.lblPOID.Name = "lblPOID"
        Me.lblPOID.Size = New System.Drawing.Size(164, 23)
        Me.lblPOID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbSupplier
        '
        Me.gbSupplier.Controls.Add(Me.txtSupplierDetails)
        Me.gbSupplier.Controls.Add(Me.Label4)
        Me.gbSupplier.Controls.Add(Me.Label3)
        Me.gbSupplier.Controls.Add(Me.cboSupplierID)
        Me.gbSupplier.Location = New System.Drawing.Point(336, 12)
        Me.gbSupplier.Name = "gbSupplier"
        Me.gbSupplier.Size = New System.Drawing.Size(380, 160)
        Me.gbSupplier.TabIndex = 2
        Me.gbSupplier.TabStop = False
        '
        'txtSupplierDetails
        '
        Me.txtSupplierDetails.Enabled = False
        Me.txtSupplierDetails.Location = New System.Drawing.Point(119, 47)
        Me.txtSupplierDetails.Multiline = True
        Me.txtSupplierDetails.Name = "txtSupplierDetails"
        Me.txtSupplierDetails.Size = New System.Drawing.Size(246, 107)
        Me.txtSupplierDetails.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Supplier Details:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(25, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Supplier ID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboSupplierID
        '
        Me.cboSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupplierID.FormattingEnabled = True
        Me.cboSupplierID.Location = New System.Drawing.Point(119, 18)
        Me.cboSupplierID.Name = "cboSupplierID"
        Me.cboSupplierID.Size = New System.Drawing.Size(121, 24)
        Me.cboSupplierID.TabIndex = 0
        '
        'gbItem
        '
        Me.gbItem.Controls.Add(Me.dgvItem)
        Me.gbItem.Controls.Add(Me.cboItemID)
        Me.gbItem.Controls.Add(Me.Label5)
        Me.gbItem.Location = New System.Drawing.Point(12, 118)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(704, 307)
        Me.gbItem.TabIndex = 3
        Me.gbItem.TabStop = False
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Location = New System.Drawing.Point(9, 60)
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.ReadOnly = True
        Me.dgvItem.RowTemplate.Height = 24
        Me.dgvItem.Size = New System.Drawing.Size(680, 238)
        Me.dgvItem.TabIndex = 9
        '
        'cboItemID
        '
        Me.cboItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemID.FormattingEnabled = True
        Me.cboItemID.Location = New System.Drawing.Point(86, 21)
        Me.cboItemID.Name = "cboItemID"
        Me.cboItemID.Size = New System.Drawing.Size(121, 24)
        Me.cboItemID.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Item ID:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(17, 431)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 35)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "&Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(629, 431)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 35)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmCreatePO
        '
        Me.AcceptButton = Me.btnCreate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(717, 468)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.gbSupplier)
        Me.Controls.Add(Me.gbPo)
        Me.Controls.Add(Me.gbItem)
        Me.KeyPreview = True
        Me.Name = "FrmCreatePO"
        Me.Text = "Create Purchase Order"
        Me.gbPo.ResumeLayout(False)
        Me.gbSupplier.ResumeLayout(False)
        Me.gbSupplier.PerformLayout()
        Me.gbItem.ResumeLayout(False)
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbPo As GroupBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPOID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbSupplier As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSupplierID As ComboBox
    Friend WithEvents gbItem As GroupBox
    Friend WithEvents cboItemID As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSupplierDetails As TextBox
    Friend WithEvents dgvItem As DataGridView
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
End Class
