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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboQuan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtSysDate = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstItemDesc = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.dgvOrderCart = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvOrderCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboItem
        '
        Me.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(12, 71)
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
        Me.Label3.Location = New System.Drawing.Point(12, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Quantity :"
        '
        'cboQuan
        '
        Me.cboQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuan.FormattingEnabled = True
        Me.cboQuan.Items.AddRange(New Object() {"--Select--", "1", "2", "3", "4", "5"})
        Me.cboQuan.Location = New System.Drawing.Point(100, 281)
        Me.cboQuan.Name = "cboQuan"
        Me.cboQuan.Size = New System.Drawing.Size(121, 21)
        Me.cboQuan.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Item Des&cription :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Item &Price (per Unit) :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(551, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Price :"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(554, 250)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 12
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(143, 333)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 13
        Me.btnAddItem.Text = "Add item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(554, 351)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 34)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(549, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Username :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(551, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Date Time:"
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Location = New System.Drawing.Point(552, 119)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 18
        '
        'txtSysDate
        '
        Me.txtSysDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSysDate.Location = New System.Drawing.Point(554, 185)
        Me.txtSysDate.Name = "txtSysDate"
        Me.txtSysDate.ReadOnly = True
        Me.txtSysDate.Size = New System.Drawing.Size(100, 20)
        Me.txtSysDate.TabIndex = 19
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(678, 24)
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
        'lstItemDesc
        '
        Me.lstItemDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItemDesc.FormattingEnabled = True
        Me.lstItemDesc.HorizontalExtent = 500
        Me.lstItemDesc.HorizontalScrollbar = True
        Me.lstItemDesc.ItemHeight = 25
        Me.lstItemDesc.Location = New System.Drawing.Point(12, 143)
        Me.lstItemDesc.Name = "lstItemDesc"
        Me.lstItemDesc.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstItemDesc.Size = New System.Drawing.Size(206, 54)
        Me.lstItemDesc.TabIndex = 24
        '
        'lstPrice
        '
        Me.lstPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 25
        Me.lstPrice.Location = New System.Drawing.Point(124, 221)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(97, 29)
        Me.lstPrice.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(245, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(212, 36)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "* Please double click the list box below to delete cart item"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(549, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Id :"
        '
        'txtOrderID
        '
        Me.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderID.Location = New System.Drawing.Point(577, 43)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.ReadOnly = True
        Me.txtOrderID.Size = New System.Drawing.Size(77, 20)
        Me.txtOrderID.TabIndex = 28
        '
        'dgvOrderCart
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrderCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderCart.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrderCart.Location = New System.Drawing.Point(248, 93)
        Me.dgvOrderCart.Name = "dgvOrderCart"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderCart.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOrderCart.Size = New System.Drawing.Size(270, 332)
        Me.dgvOrderCart.TabIndex = 29
        '
        'OrderCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(678, 445)
        Me.Controls.Add(Me.dgvOrderCart)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstItemDesc)
        Me.Controls.Add(Me.txtSysDate)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label6)
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvOrderCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboItem As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboQuan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtSysDate As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lstItemDesc As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents dgvOrderCart As DataGridView
End Class
