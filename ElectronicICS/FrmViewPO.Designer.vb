<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewPO
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewPO))
        Me.btnCreateDO = New System.Windows.Forms.Button()
        Me.btnCloseDO = New System.Windows.Forms.Button()
        Me.dgvPO = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPOID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.grPO = New System.Windows.Forms.GroupBox()
        Me.grDO = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.dtpDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnPring = New System.Windows.Forms.Button()
        Me.docPO = New System.Drawing.Printing.PrintDocument()
        Me.dlgPriviewPO = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grPO.SuspendLayout()
        Me.grDO.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateDO
        '
        Me.btnCreateDO.Location = New System.Drawing.Point(106, 146)
        Me.btnCreateDO.Name = "btnCreateDO"
        Me.btnCreateDO.Size = New System.Drawing.Size(100, 28)
        Me.btnCreateDO.TabIndex = 0
        Me.btnCreateDO.Text = "Create DO"
        Me.btnCreateDO.UseVisualStyleBackColor = True
        Me.btnCreateDO.Visible = False
        '
        'btnCloseDO
        '
        Me.btnCloseDO.CausesValidation = False
        Me.btnCloseDO.Location = New System.Drawing.Point(342, 146)
        Me.btnCloseDO.Name = "btnCloseDO"
        Me.btnCloseDO.Size = New System.Drawing.Size(100, 28)
        Me.btnCloseDO.TabIndex = 1
        Me.btnCloseDO.Text = "Close DO"
        Me.btnCloseDO.UseVisualStyleBackColor = True
        Me.btnCloseDO.Visible = False
        '
        'dgvPO
        '
        Me.dgvPO.AllowUserToAddRows = False
        Me.dgvPO.AllowUserToDeleteRows = False
        Me.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPO.Location = New System.Drawing.Point(12, 172)
        Me.dgvPO.Name = "dgvPO"
        Me.dgvPO.ReadOnly = True
        Me.dgvPO.RowTemplate.Height = 24
        Me.dgvPO.Size = New System.Drawing.Size(463, 150)
        Me.dgvPO.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Purchase Order ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPOID
        '
        Me.lblPOID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPOID.Location = New System.Drawing.Point(149, 18)
        Me.lblPOID.Name = "lblPOID"
        Me.lblPOID.Size = New System.Drawing.Size(308, 23)
        Me.lblPOID.TabIndex = 4
        Me.lblPOID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Supplier Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Order Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSupplierName
        '
        Me.lblSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSupplierName.Location = New System.Drawing.Point(149, 50)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(308, 55)
        Me.lblSupplierName.TabIndex = 7
        Me.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrderDate
        '
        Me.lblOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrderDate.Location = New System.Drawing.Point(149, 115)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(308, 23)
        Me.lblOrderDate.TabIndex = 8
        Me.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grPO
        '
        Me.grPO.Controls.Add(Me.lblPOID)
        Me.grPO.Controls.Add(Me.lblOrderDate)
        Me.grPO.Controls.Add(Me.Label1)
        Me.grPO.Controls.Add(Me.lblSupplierName)
        Me.grPO.Controls.Add(Me.Label3)
        Me.grPO.Controls.Add(Me.Label4)
        Me.grPO.Location = New System.Drawing.Point(12, 12)
        Me.grPO.Name = "grPO"
        Me.grPO.Size = New System.Drawing.Size(463, 154)
        Me.grPO.TabIndex = 9
        Me.grPO.TabStop = False
        '
        'grDO
        '
        Me.grDO.Controls.Add(Me.btnPring)
        Me.grDO.Controls.Add(Me.dtpDeliveryDate)
        Me.grDO.Controls.Add(Me.txtAddress)
        Me.grDO.Controls.Add(Me.Label5)
        Me.grDO.Controls.Add(Me.btnCloseDO)
        Me.grDO.Controls.Add(Me.Label2)
        Me.grDO.Controls.Add(Me.btnCreateDO)
        Me.grDO.Location = New System.Drawing.Point(12, 328)
        Me.grDO.Name = "grDO"
        Me.grDO.Size = New System.Drawing.Size(463, 183)
        Me.grDO.TabIndex = 10
        Me.grDO.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Delivery Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Address:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(115, 55)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(327, 79)
        Me.txtAddress.TabIndex = 10
        '
        'dtpDeliveryDate
        '
        Me.dtpDeliveryDate.Location = New System.Drawing.Point(116, 18)
        Me.dtpDeliveryDate.Name = "dtpDeliveryDate"
        Me.dtpDeliveryDate.Size = New System.Drawing.Size(326, 22)
        Me.dtpDeliveryDate.TabIndex = 11
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'btnPring
        '
        Me.btnPring.Location = New System.Drawing.Point(0, 146)
        Me.btnPring.Name = "btnPring"
        Me.btnPring.Size = New System.Drawing.Size(100, 28)
        Me.btnPring.TabIndex = 12
        Me.btnPring.Text = "Print PO"
        Me.btnPring.UseVisualStyleBackColor = True
        '
        'docPO
        '
        '
        'dlgPriviewPO
        '
        Me.dlgPriviewPO.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPriviewPO.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPriviewPO.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPriviewPO.Document = Me.docPO
        Me.dlgPriviewPO.Enabled = True
        Me.dlgPriviewPO.Icon = CType(resources.GetObject("dlgPriviewPO.Icon"), System.Drawing.Icon)
        Me.dlgPriviewPO.Name = "dlgPriviewPO"
        Me.dlgPriviewPO.Visible = False
        '
        'FrmViewPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(486, 523)
        Me.Controls.Add(Me.grPO)
        Me.Controls.Add(Me.dgvPO)
        Me.Controls.Add(Me.grDO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmViewPO"
        Me.Text = "View Purchase Order"
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grPO.ResumeLayout(False)
        Me.grDO.ResumeLayout(False)
        Me.grDO.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateDO As Button
    Friend WithEvents btnCloseDO As Button
    Friend WithEvents dgvPO As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPOID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSupplierName As Label
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents grPO As GroupBox
    Friend WithEvents grDO As GroupBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDeliveryDate As DateTimePicker
    Friend WithEvents err As ErrorProvider
    Friend WithEvents btnPring As Button
    Friend WithEvents docPO As Printing.PrintDocument
    Friend WithEvents dlgPriviewPO As PrintPreviewDialog
End Class
