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
        Me.ManageStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStaff.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStaff
        '
        Me.mnuStaff.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuStaff.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageStockToolStripMenuItem, Me.MyAccountToolStripMenuItem})
        Me.mnuStaff.Location = New System.Drawing.Point(0, 0)
        Me.mnuStaff.Name = "mnuStaff"
        Me.mnuStaff.Size = New System.Drawing.Size(800, 28)
        Me.mnuStaff.TabIndex = 0
        Me.mnuStaff.Text = "MenuStrip1"
        '
        'ManageStockToolStripMenuItem
        '
        Me.ManageStockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreatePurchaseOrderToolStripMenuItem})
        Me.ManageStockToolStripMenuItem.Name = "ManageStockToolStripMenuItem"
        Me.ManageStockToolStripMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.ManageStockToolStripMenuItem.Text = "Manage Stock"
        '
        'MyAccountToolStripMenuItem
        '
        Me.MyAccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountProfileToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MyAccountToolStripMenuItem.Name = "MyAccountToolStripMenuItem"
        Me.MyAccountToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.MyAccountToolStripMenuItem.Text = "My Account"
        '
        'AccountProfileToolStripMenuItem
        '
        Me.AccountProfileToolStripMenuItem.Name = "AccountProfileToolStripMenuItem"
        Me.AccountProfileToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AccountProfileToolStripMenuItem.Text = "Account Profile"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CreatePurchaseOrderToolStripMenuItem
        '
        Me.CreatePurchaseOrderToolStripMenuItem.Name = "CreatePurchaseOrderToolStripMenuItem"
        Me.CreatePurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.CreatePurchaseOrderToolStripMenuItem.Text = "Create Purchase Order"
        '
        'FrmMainpageStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mnuStaff)
        Me.MainMenuStrip = Me.mnuStaff
        Me.Name = "FrmMainpageStaff"
        Me.Text = "FrmMainpageStaff"
        Me.mnuStaff.ResumeLayout(False)
        Me.mnuStaff.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStaff As MenuStrip
    Friend WithEvents ManageStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreatePurchaseOrderToolStripMenuItem As ToolStripMenuItem
End Class
