﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainpageStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainpageStaff))
        Me.mnuStaff = New System.Windows.Forms.MenuStrip()
        Me.mnusHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusMS = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusSupplyPO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusReportSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusRprtSmmInvValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnDemandReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusMyAcc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusMyAccProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pcPurchaseOrder = New System.Windows.Forms.PictureBox()
        Me.pcInvValSumm = New System.Windows.Forms.PictureBox()
        Me.pcManageStock = New System.Windows.Forms.PictureBox()
        Me.docInv = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreviewInv = New System.Windows.Forms.PrintPreviewDialog()
        Me.mnuStaff.SuspendLayout()
        CType(Me.pcPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcInvValSumm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcManageStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStaff
        '
        Me.mnuStaff.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuStaff.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusHome, Me.mnusMS, Me.SupplyToolStripMenuItem, Me.mnusReport, Me.mnusMyAcc})
        Me.mnuStaff.Location = New System.Drawing.Point(0, 0)
        Me.mnuStaff.Name = "mnuStaff"
        Me.mnuStaff.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
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
        Me.SupplyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageSupplierToolStripMenuItem, Me.mnusSupplyPO})
        Me.SupplyToolStripMenuItem.Name = "SupplyToolStripMenuItem"
        Me.SupplyToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.SupplyToolStripMenuItem.Text = "Supply"
        '
        'ManageSupplierToolStripMenuItem
        '
        Me.ManageSupplierToolStripMenuItem.Name = "ManageSupplierToolStripMenuItem"
        Me.ManageSupplierToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ManageSupplierToolStripMenuItem.Text = "Manage Supplier"
        '
        'mnusSupplyPO
        '
        Me.mnusSupplyPO.Name = "mnusSupplyPO"
        Me.mnusSupplyPO.Size = New System.Drawing.Size(216, 26)
        Me.mnusSupplyPO.Text = "Purchase Order"
        '
        'mnusReport
        '
        Me.mnusReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusReportSummary, Me.DetailToolStripMenuItem, Me.OnDemandReportToolStripMenuItem})
        Me.mnusReport.Name = "mnusReport"
        Me.mnusReport.Size = New System.Drawing.Size(66, 24)
        Me.mnusReport.Text = "Report"
        '
        'mnusReportSummary
        '
        Me.mnusReportSummary.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusRprtSmmInvValue})
        Me.mnusReportSummary.Name = "mnusReportSummary"
        Me.mnusReportSummary.Size = New System.Drawing.Size(213, 26)
        Me.mnusReportSummary.Text = "Summary"
        '
        'mnusRprtSmmInvValue
        '
        Me.mnusRprtSmmInvValue.Name = "mnusRprtSmmInvValue"
        Me.mnusRprtSmmInvValue.Size = New System.Drawing.Size(191, 26)
        Me.mnusRprtSmmInvValue.Text = "Inventory Values"
        '
        'DetailToolStripMenuItem
        '
        Me.DetailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentTransactionToolStripMenuItem})
        Me.DetailToolStripMenuItem.Name = "DetailToolStripMenuItem"
        Me.DetailToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.DetailToolStripMenuItem.Text = "Detail"
        '
        'PaymentTransactionToolStripMenuItem
        '
        Me.PaymentTransactionToolStripMenuItem.Name = "PaymentTransactionToolStripMenuItem"
        Me.PaymentTransactionToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.PaymentTransactionToolStripMenuItem.Text = "Payment Transaction"
        '
        'OnDemandReportToolStripMenuItem
        '
        Me.OnDemandReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesReportToolStripMenuItem})
        Me.OnDemandReportToolStripMenuItem.Name = "OnDemandReportToolStripMenuItem"
        Me.OnDemandReportToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.OnDemandReportToolStripMenuItem.Text = "On Demand Report"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
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
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(139, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Purchase Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(261, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 38)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Inventory Values Summary Report"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pcPurchaseOrder
        '
        Me.pcPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcPurchaseOrder.Image = Global.ElectronicICS.My.Resources.Resources.purchase_order
        Me.pcPurchaseOrder.Location = New System.Drawing.Point(139, 31)
        Me.pcPurchaseOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcPurchaseOrder.Name = "pcPurchaseOrder"
        Me.pcPurchaseOrder.Size = New System.Drawing.Size(120, 90)
        Me.pcPurchaseOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcPurchaseOrder.TabIndex = 4
        Me.pcPurchaseOrder.TabStop = False
        '
        'pcInvValSumm
        '
        Me.pcInvValSumm.BackColor = System.Drawing.Color.White
        Me.pcInvValSumm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcInvValSumm.Image = Global.ElectronicICS.My.Resources.Resources.summary_report_icon_26
        Me.pcInvValSumm.Location = New System.Drawing.Point(265, 31)
        Me.pcInvValSumm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcInvValSumm.Name = "pcInvValSumm"
        Me.pcInvValSumm.Size = New System.Drawing.Size(120, 90)
        Me.pcInvValSumm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcInvValSumm.TabIndex = 3
        Me.pcInvValSumm.TabStop = False
        '
        'pcManageStock
        '
        Me.pcManageStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcManageStock.Image = Global.ElectronicICS.My.Resources.Resources.warehouse_inventory
        Me.pcManageStock.Location = New System.Drawing.Point(12, 31)
        Me.pcManageStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcManageStock.Name = "pcManageStock"
        Me.pcManageStock.Size = New System.Drawing.Size(120, 90)
        Me.pcManageStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcManageStock.TabIndex = 2
        Me.pcManageStock.TabStop = False
        '
        'docInv
        '
        '
        'dlgPreviewInv
        '
        Me.dlgPreviewInv.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewInv.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewInv.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewInv.Enabled = True
        Me.dlgPreviewInv.Icon = CType(resources.GetObject("dlgPreviewInv.Icon"), System.Drawing.Icon)
        Me.dlgPreviewInv.Name = "PrintPreviewDialog1"
        Me.dlgPreviewInv.Visible = False
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
        Me.Controls.Add(Me.pcInvValSumm)
        Me.Controls.Add(Me.pcManageStock)
        Me.Controls.Add(Me.mnuStaff)
        Me.MainMenuStrip = Me.mnuStaff
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmMainpageStaff"
        Me.Text = "Home Page"
        Me.mnuStaff.ResumeLayout(False)
        Me.mnuStaff.PerformLayout()
        CType(Me.pcPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcInvValSumm, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pcPurchaseOrder As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SupplyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnusSupplyPO As ToolStripMenuItem
    Friend WithEvents DetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnDemandReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pcInvValSumm As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents docInv As Printing.PrintDocument
    Friend WithEvents dlgPreviewInv As PrintPreviewDialog
End Class
