<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainpageStaff
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
        Me.mnuStaff = New System.Windows.Forms.MenuStrip()
        Me.mnusHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusMS = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusReportSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusRprtSmmInvValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusMyAcc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusMyAccProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pcPurchaseOrder = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pcManageStock = New System.Windows.Forms.PictureBox()
        Me.mnuStaff.SuspendLayout()
        CType(Me.pcPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcManageStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStaff
        '
        Me.mnuStaff.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuStaff.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusHome, Me.mnusMS, Me.SupplyToolStripMenuItem, Me.mnusReport, Me.mnusMyAcc})
        Me.mnuStaff.Location = New System.Drawing.Point(0, 0)
        Me.mnuStaff.Name = "mnuStaff"
        Me.mnuStaff.Size = New System.Drawing.Size(561, 28)
        Me.mnuStaff.TabIndex = 0
        Me.mnuStaff.Text = "MenuStrip1"
        '
        'mnusHome
        '
        Me.mnusHome.Name = "mnusHome"
        Me.mnusHome.Size = New System.Drawing.Size(98, 24)
        Me.mnusHome.Text = "Home Page"
        '
        'mnusMS
        '
        Me.mnusMS.Name = "mnusMS"
        Me.mnusMS.Size = New System.Drawing.Size(115, 24)
        Me.mnusMS.Text = "Manage Stock"
        '
        'SupplyToolStripMenuItem
        '
        Me.SupplyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageSupplierToolStripMenuItem, Me.PurchaseOrderToolStripMenuItem})
        Me.SupplyToolStripMenuItem.Name = "SupplyToolStripMenuItem"
        Me.SupplyToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.SupplyToolStripMenuItem.Text = "Supply"
        '
        'ManageSupplierToolStripMenuItem
        '
        Me.ManageSupplierToolStripMenuItem.Name = "ManageSupplierToolStripMenuItem"
        Me.ManageSupplierToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ManageSupplierToolStripMenuItem.Text = "Manage Supplier"
        '
        'PurchaseOrderToolStripMenuItem
        '
        Me.PurchaseOrderToolStripMenuItem.Name = "PurchaseOrderToolStripMenuItem"
        Me.PurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.PurchaseOrderToolStripMenuItem.Text = "Purchase Order"
        '
        'mnusReport
        '
        Me.mnusReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusReportSummary})
        Me.mnusReport.Name = "mnusReport"
        Me.mnusReport.Size = New System.Drawing.Size(66, 24)
        Me.mnusReport.Text = "Report"
        '
        'mnusReportSummary
        '
        Me.mnusReportSummary.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusRprtSmmInvValue})
        Me.mnusReportSummary.Name = "mnusReportSummary"
        Me.mnusReportSummary.Size = New System.Drawing.Size(146, 26)
        Me.mnusReportSummary.Text = "Summary"
        '
        'mnusRprtSmmInvValue
        '
        Me.mnusRprtSmmInvValue.Name = "mnusRprtSmmInvValue"
        Me.mnusRprtSmmInvValue.Size = New System.Drawing.Size(191, 26)
        Me.mnusRprtSmmInvValue.Text = "Inventory Values"
        '
        'mnusMyAcc
        '
        Me.mnusMyAcc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusMyAccProfile, Me.mnusLogout, Me.mnusExit})
        Me.mnusMyAcc.Name = "mnusMyAcc"
        Me.mnusMyAcc.Size = New System.Drawing.Size(99, 24)
        Me.mnusMyAcc.Text = "My Account"
        '
        'mnusMyAccProfile
        '
        Me.mnusMyAccProfile.Name = "mnusMyAccProfile"
        Me.mnusMyAccProfile.Size = New System.Drawing.Size(185, 26)
        Me.mnusMyAccProfile.Text = "Account Profile"
        '
        'mnusLogout
        '
        Me.mnusLogout.Name = "mnusLogout"
        Me.mnusLogout.Size = New System.Drawing.Size(185, 26)
        Me.mnusLogout.Text = "Log Out"
        '
        'mnusExit
        '
        Me.mnusExit.Name = "mnusExit"
        Me.mnusExit.Size = New System.Drawing.Size(185, 26)
        Me.mnusExit.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Manage Stock"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(296, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(138, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Purchase Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pcPurchaseOrder
        '
        Me.pcPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcPurchaseOrder.Image = Global.ElectronicICS.My.Resources.Resources.purchase_order
        Me.pcPurchaseOrder.Location = New System.Drawing.Point(138, 31)
        Me.pcPurchaseOrder.Name = "pcPurchaseOrder"
        Me.pcPurchaseOrder.Size = New System.Drawing.Size(120, 90)
        Me.pcPurchaseOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcPurchaseOrder.TabIndex = 4
        Me.pcPurchaseOrder.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(299, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(120, 90)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'pcManageStock
        '
        Me.pcManageStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcManageStock.Image = Global.ElectronicICS.My.Resources.Resources.warehouse_inventory
        Me.pcManageStock.Location = New System.Drawing.Point(12, 31)
        Me.pcManageStock.Name = "pcManageStock"
        Me.pcManageStock.Size = New System.Drawing.Size(120, 90)
        Me.pcManageStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcManageStock.TabIndex = 2
        Me.pcManageStock.TabStop = False
        '
        'FrmMainpageStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(561, 430)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcPurchaseOrder)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pcManageStock)
        Me.Controls.Add(Me.mnuStaff)
        Me.MainMenuStrip = Me.mnuStaff
        Me.Name = "FrmMainpageStaff"
        Me.Text = "Home Page"
        Me.mnuStaff.ResumeLayout(False)
        Me.mnuStaff.PerformLayout()
        CType(Me.pcPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcManageStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStaff As MenuStrip
    Friend WithEvents mnusMS As ToolStripMenuItem
    Friend WithEvents mnusMyAcc As ToolStripMenuItem
    Friend WithEvents mnusMyAccProfile As ToolStripMenuItem
    Friend WithEvents mnusLogout As ToolStripMenuItem
    Friend WithEvents mnusExit As ToolStripMenuItem
    Friend WithEvents mnusHome As ToolStripMenuItem
    Friend WithEvents mnusReport As ToolStripMenuItem
    Friend WithEvents mnusReportSummary As ToolStripMenuItem
    Friend WithEvents mnusRprtSmmInvValue As ToolStripMenuItem
    Friend WithEvents pcManageStock As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pcPurchaseOrder As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SupplyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseOrderToolStripMenuItem As ToolStripMenuItem
End Class
