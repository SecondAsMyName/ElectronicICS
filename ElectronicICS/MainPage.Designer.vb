<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.btnDeliveryMenu = New System.Windows.Forms.Button()
        Me.btnOrderForm = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.AsdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDeliveryMenu
        '
        Me.btnDeliveryMenu.Location = New System.Drawing.Point(140, 115)
        Me.btnDeliveryMenu.Name = "btnDeliveryMenu"
        Me.btnDeliveryMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnDeliveryMenu.TabIndex = 0
        Me.btnDeliveryMenu.Text = "Delivery"
        Me.btnDeliveryMenu.UseVisualStyleBackColor = True
        '
        'btnOrderForm
        '
        Me.btnOrderForm.Location = New System.Drawing.Point(46, 72)
        Me.btnOrderForm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderForm.Name = "btnOrderForm"
        Me.btnOrderForm.Size = New System.Drawing.Size(56, 19)
        Me.btnOrderForm.TabIndex = 1
        Me.btnOrderForm.Text = "Order"
        Me.btnOrderForm.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(140, 72)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(75, 29)
        Me.btnPayment.TabIndex = 2
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(46, 119)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 19)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'mnu
        '
        Me.mnu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsdaToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.mnuAcc})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnu.Size = New System.Drawing.Size(284, 24)
        Me.mnu.TabIndex = 4
        Me.mnu.Text = "MenuStrip1"
        '
        'AsdaToolStripMenuItem
        '
        Me.AsdaToolStripMenuItem.Name = "AsdaToolStripMenuItem"
        Me.AsdaToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.AsdaToolStripMenuItem.Text = "Order"
        '
        'mnuAcc
        '
        Me.mnuAcc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAccProfile, Me.mnuAccLogout, Me.ExitToolStripMenuItem})
        Me.mnuAcc.Name = "mnuAcc"
        Me.mnuAcc.Size = New System.Drawing.Size(84, 20)
        Me.mnuAcc.Text = "My Account"
        '
        'mnuAccProfile
        '
        Me.mnuAccProfile.Name = "mnuAccProfile"
        Me.mnuAccProfile.Size = New System.Drawing.Size(156, 22)
        Me.mnuAccProfile.Text = "Account Profile"
        '
        'mnuAccLogout
        '
        Me.mnuAccLogout.Name = "mnuAccLogout"
        Me.mnuAccLogout.Size = New System.Drawing.Size(156, 22)
        Me.mnuAccLogout.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnOrderForm)
        Me.Controls.Add(Me.btnDeliveryMenu)
        Me.Controls.Add(Me.mnu)
        Me.MainMenuStrip = Me.mnu
        Me.Name = "MainPage"
        Me.Text = "ElectronicICS"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeliveryMenu As Button
    Friend WithEvents btnOrderForm As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents mnu As MenuStrip
    Friend WithEvents AsdaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAcc As ToolStripMenuItem
    Friend WithEvents mnuAccProfile As ToolStripMenuItem
    Friend WithEvents mnuAccLogout As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
End Class
