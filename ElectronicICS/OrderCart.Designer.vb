<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderCart
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
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboQuan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtSysDate = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstOrderCart = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboItem
        '
        Me.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(12, 85)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(158, 21)
        Me.cboItem.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "It&em Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 381)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Quantity :"
        '
        'cboQuan
        '
        Me.cboQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuan.FormattingEnabled = True
        Me.cboQuan.Location = New System.Drawing.Point(100, 381)
        Me.cboQuan.Name = "cboQuan"
        Me.cboQuan.Size = New System.Drawing.Size(121, 21)
        Me.cboQuan.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Item Des&cription :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Item &Price (per Unit) :"
        '
        'txtItemDesc
        '
        Me.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemDesc.Location = New System.Drawing.Point(12, 173)
        Me.txtItemDesc.Multiline = True
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.ReadOnly = True
        Me.txtItemDesc.Size = New System.Drawing.Size(206, 125)
        Me.txtItemDesc.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(121, 333)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(492, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Price :"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(493, 239)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 12
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(12, 430)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 13
        Me.btnAddItem.Text = "Add item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(493, 391)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 34)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(493, 333)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(100, 36)
        Me.btnCal.TabIndex = 15
        Me.btnCal.Text = "Calculate price"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(495, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Username :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(492, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Date Time:"
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Location = New System.Drawing.Point(493, 86)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 18
        '
        'txtSysDate
        '
        Me.txtSysDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSysDate.Location = New System.Drawing.Point(493, 162)
        Me.txtSysDate.Name = "txtSysDate"
        Me.txtSysDate.ReadOnly = True
        Me.txtSysDate.Size = New System.Drawing.Size(100, 20)
        Me.txtSysDate.TabIndex = 19
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(134, 430)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(87, 23)
        Me.btnRemove.TabIndex = 21
        Me.btnRemove.Text = "Remove item "
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(628, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(97, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        '
        'lstOrderCart
        '
        Me.lstOrderCart.FormattingEnabled = True
        Me.lstOrderCart.Location = New System.Drawing.Point(248, 45)
        Me.lstOrderCart.Name = "lstOrderCart"
        Me.lstOrderCart.Size = New System.Drawing.Size(209, 381)
        Me.lstOrderCart.TabIndex = 23
        '
        'OrderCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(628, 477)
        Me.Controls.Add(Me.lstOrderCart)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtSysDate)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboQuan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "OrderCart"
        Me.Text = "OrderCart"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboItem As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboQuan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtItemDesc As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCal As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtSysDate As TextBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lstOrderCart As ListBox
End Class
