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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.mnuAcc = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDeliveryMenu
        '
        Me.btnDeliveryMenu.Location = New System.Drawing.Point(187, 142)
        Me.btnDeliveryMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeliveryMenu.Name = "btnDeliveryMenu"
        Me.btnDeliveryMenu.Size = New System.Drawing.Size(100, 28)
        Me.btnDeliveryMenu.TabIndex = 0
        Me.btnDeliveryMenu.Text = "Delivery"
        Me.btnDeliveryMenu.UseVisualStyleBackColor = True
        '
        'btnOrderForm
        '
        Me.btnOrderForm.Location = New System.Drawing.Point(62, 89)
        Me.btnOrderForm.Name = "btnOrderForm"
        Me.btnOrderForm.Size = New System.Drawing.Size(75, 23)
        Me.btnOrderForm.TabIndex = 1
        Me.btnOrderForm.Text = "Order"
        Me.btnOrderForm.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(62, 147)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'mnu
        '
        Me.mnu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsdaToolStripMenuItem, Me.mnuAcc})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(379, 28)
        Me.mnu.TabIndex = 4
        Me.mnu.Text = "MenuStrip1"
        '
        'mnuAcc
        '
        Me.mnuAcc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAccProfile, Me.mnuAccLogout})
        Me.mnuAcc.Name = "mnuAcc"
        Me.mnuAcc.Size = New System.Drawing.Size(99, 24)
        Me.mnuAcc.Text = "My Account"
        '
        'AsdaToolStripMenuItem
        '
        Me.AsdaToolStripMenuItem.Name = "AsdaToolStripMenuItem"
        Me.AsdaToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.AsdaToolStripMenuItem.Text = "Order"
        '
        'mnuAccProfile
        '
        Me.mnuAccProfile.Name = "mnuAccProfile"
        Me.mnuAccProfile.Size = New System.Drawing.Size(216, 26)
        Me.mnuAccProfile.Text = "Account Profile"
        '
        'mnuAccLogout
        '
        Me.mnuAccLogout.Name = "mnuAccLogout"
        Me.mnuAccLogout.Size = New System.Drawing.Size(216, 26)
        Me.mnuAccLogout.Text = "Log Out"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOrderForm)
        Me.Controls.Add(Me.btnDeliveryMenu)
        Me.Controls.Add(Me.mnu)
        Me.MainMenuStrip = Me.mnu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainPage"
        Me.Text = "ElectronicICS"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeliveryMenu As Button
    Friend WithEvents btnOrderForm As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents mnu As MenuStrip
    Friend WithEvents AsdaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAcc As ToolStripMenuItem
    Friend WithEvents mnuAccProfile As ToolStripMenuItem
    Friend WithEvents mnuAccLogout As ToolStripMenuItem
End Class
