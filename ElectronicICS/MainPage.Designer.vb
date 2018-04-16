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
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.AsdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeliveryMenu
        '
        Me.btnDeliveryMenu.Location = New System.Drawing.Point(45, 210)
        Me.btnDeliveryMenu.Name = "btnDeliveryMenu"
        Me.btnDeliveryMenu.Size = New System.Drawing.Size(221, 45)
        Me.btnDeliveryMenu.TabIndex = 0
        Me.btnDeliveryMenu.Text = "Delivery"
        Me.btnDeliveryMenu.UseVisualStyleBackColor = True
        '
        'btnOrderForm
        '
        Me.btnOrderForm.Location = New System.Drawing.Point(45, 48)
        Me.btnOrderForm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderForm.Name = "btnOrderForm"
        Me.btnOrderForm.Size = New System.Drawing.Size(221, 56)
        Me.btnOrderForm.TabIndex = 1
        Me.btnOrderForm.Text = "Order"
        Me.btnOrderForm.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(45, 132)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(221, 48)
        Me.btnPayment.TabIndex = 2
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'mnu
        '
        Me.mnu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsdaToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.mnuAcc})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnu.Size = New System.Drawing.Size(479, 24)
        Me.mnu.TabIndex = 4
        Me.mnu.Text = "MenuStrip1"
        '
        'AsdaToolStripMenuItem
        '
        Me.AsdaToolStripMenuItem.Name = "AsdaToolStripMenuItem"
        Me.AsdaToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.AsdaToolStripMenuItem.Text = "Order"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PaymentToolStripMenuItem.Text = "Payment"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElectronicICS.My.Resources.Resources.CustomerMainPageLogo
        Me.PictureBox1.Location = New System.Drawing.Point(295, 174)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(479, 311)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnOrderForm)
        Me.Controls.Add(Me.btnDeliveryMenu)
        Me.Controls.Add(Me.mnu)
        Me.MainMenuStrip = Me.mnu
        Me.Name = "MainPage"
        Me.Text = "ElectronicICS"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeliveryMenu As Button
    Friend WithEvents btnOrderForm As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents mnu As MenuStrip
    Friend WithEvents AsdaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAcc As ToolStripMenuItem
    Friend WithEvents mnuAccProfile As ToolStripMenuItem
    Friend WithEvents mnuAccLogout As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
