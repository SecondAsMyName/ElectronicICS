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
        Me.mnuStaff = New System.Windows.Forms.MenuStrip()
        Me.mnusHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusMS = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusReportSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusRprtSmmInvValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlySalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.DetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuStaff.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuStaff.Size = New System.Drawing.Size(421, 24)
        Me.mnuStaff.TabIndex = 0
        Me.mnuStaff.Text = "MenuStrip1"
        '
        'mnusHome
        '
        Me.mnusHome.Name = "mnusHome"
        Me.mnusHome.Size = New System.Drawing.Size(81, 20)
        Me.mnusHome.Text = "Home Page"
        '
        'mnusMS
        '
        Me.mnusMS.Name = "mnusMS"
        Me.mnusMS.Size = New System.Drawing.Size(94, 20)
        Me.mnusMS.Text = "Manage Stock"
        '
        'SupplyToolStripMenuItem
        '
        Me.SupplyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageSupplierToolStripMenuItem, Me.PurchaseOrderToolStripMenuItem})
        Me.SupplyToolStripMenuItem.Name = "SupplyToolStripMenuItem"
        Me.SupplyToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.SupplyToolStripMenuItem.Text = "Supply"
        '
        'ManageSupplierToolStripMenuItem
        '
        Me.ManageSupplierToolStripMenuItem.Name = "ManageSupplierToolStripMenuItem"
        Me.ManageSupplierToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ManageSupplierToolStripMenuItem.Text = "Manage Supplier"
        '
        'PurchaseOrderToolStripMenuItem
        '
        Me.PurchaseOrderToolStripMenuItem.Name = "PurchaseOrderToolStripMenuItem"
        Me.PurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PurchaseOrderToolStripMenuItem.Text = "Purchase Order"
        '
        'mnusReport
        '
        Me.mnusReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusReportSummary, Me.DetailToolStripMenuItem})
        Me.mnusReport.Name = "mnusReport"
        Me.mnusReport.Size = New System.Drawing.Size(54, 20)
        Me.mnusReport.Text = "Report"
        '
        'mnusReportSummary
        '
        Me.mnusReportSummary.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusRprtSmmInvValue, Me.MonthlySalesToolStripMenuItem})
        Me.mnusReportSummary.Name = "mnusReportSummary"
        Me.mnusReportSummary.Size = New System.Drawing.Size(152, 22)
        Me.mnusReportSummary.Size = New System.Drawing.Size(180, 22)
        Me.mnusReportSummary.Text = "Summary"
        '
        'mnusRprtSmmInvValue
        '
        Me.mnusRprtSmmInvValue.Name = "mnusRprtSmmInvValue"
        Me.mnusRprtSmmInvValue.Size = New System.Drawing.Size(160, 22)
        Me.mnusRprtSmmInvValue.Size = New System.Drawing.Size(196, 22)
        Me.mnusRprtSmmInvValue.Text = "Inventory Values"
        '
        'MonthlySalesToolStripMenuItem
        '
        Me.MonthlySalesToolStripMenuItem.Name = "MonthlySalesToolStripMenuItem"
        Me.MonthlySalesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.MonthlySalesToolStripMenuItem.Text = "OnDemandSalesReport"
        '
        'mnusMyAcc
        '
        Me.mnusMyAcc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusMyAccProfile, Me.mnusLogout, Me.mnusExit})
        Me.mnusMyAcc.Name = "mnusMyAcc"
        Me.mnusMyAcc.Size = New System.Drawing.Size(84, 20)
        Me.mnusMyAcc.Text = "My Account"
        '
        'mnusMyAccProfile
        '
        Me.mnusMyAccProfile.Name = "mnusMyAccProfile"
        Me.mnusMyAccProfile.Size = New System.Drawing.Size(156, 22)
        Me.mnusMyAccProfile.Text = "Account Profile"
        '
        'mnusLogout
        '
        Me.mnusLogout.Name = "mnusLogout"
        Me.mnusLogout.Size = New System.Drawing.Size(156, 22)
        Me.mnusLogout.Text = "Log Out"
        '
        'mnusExit
        '
        Me.mnusExit.Name = "mnusExit"
        Me.mnusExit.Size = New System.Drawing.Size(156, 22)
        Me.mnusExit.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Manage Stock"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(222, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(104, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Purchase Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pcPurchaseOrder
        '
        Me.pcPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcPurchaseOrder.Image = Global.ElectronicICS.My.Resources.Resources.purchase_order
        Me.pcPurchaseOrder.Location = New System.Drawing.Point(104, 25)
        Me.pcPurchaseOrder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pcPurchaseOrder.Location = New System.Drawing.Point(104, 25)
        Me.pcPurchaseOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.pcPurchaseOrder.Name = "pcPurchaseOrder"
        Me.pcPurchaseOrder.Size = New System.Drawing.Size(90, 73)
        Me.pcPurchaseOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcPurchaseOrder.TabIndex = 4
        Me.pcPurchaseOrder.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(224, 25)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Location = New System.Drawing.Point(224, 25)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 73)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'pcManageStock
        '
        Me.pcManageStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcManageStock.Image = Global.ElectronicICS.My.Resources.Resources.warehouse_inventory
        Me.pcManageStock.Location = New System.Drawing.Point(9, 25)
        Me.pcManageStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pcManageStock.Location = New System.Drawing.Point(9, 25)
        Me.pcManageStock.Margin = New System.Windows.Forms.Padding(2)
        Me.pcManageStock.Name = "pcManageStock"
        Me.pcManageStock.Size = New System.Drawing.Size(90, 73)
        Me.pcManageStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcManageStock.TabIndex = 2
        Me.pcManageStock.TabStop = False
        '
        'DetailToolStripMenuItem
        '
        Me.DetailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentTransactionToolStripMenuItem})
        Me.DetailToolStripMenuItem.Name = "DetailToolStripMenuItem"
        Me.DetailToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DetailToolStripMenuItem.Text = "Detail"
        '
        'PaymentTransactionToolStripMenuItem
        '
        Me.PaymentTransactionToolStripMenuItem.Name = "PaymentTransactionToolStripMenuItem"
        Me.PaymentTransactionToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PaymentTransactionToolStripMenuItem.Text = "Payment Transaction"
        '
        'FrmMainpageStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(421, 349)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcPurchaseOrder)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pcManageStock)
        Me.Controls.Add(Me.mnuStaff)
        Me.MainMenuStrip = Me.mnuStaff
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents DetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlySalesToolStripMenuItem As ToolStripMenuItem
End Class
