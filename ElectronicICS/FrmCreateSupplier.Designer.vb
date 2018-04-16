<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreateSupplier
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtTelNo2 = New System.Windows.Forms.TextBox()
        Me.txtTelNo1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.CausesValidation = False
        Me.btnClear.Location = New System.Drawing.Point(143, 298)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtTelNo2
        '
        Me.txtTelNo2.Location = New System.Drawing.Point(173, 254)
        Me.txtTelNo2.MaxLength = 8
        Me.txtTelNo2.Name = "txtTelNo2"
        Me.txtTelNo2.Size = New System.Drawing.Size(129, 22)
        Me.txtTelNo2.TabIndex = 17
        '
        'txtTelNo1
        '
        Me.txtTelNo1.Location = New System.Drawing.Point(105, 254)
        Me.txtTelNo1.MaxLength = 3
        Me.txtTelNo1.Name = "txtTelNo1"
        Me.txtTelNo1.Size = New System.Drawing.Size(46, 22)
        Me.txtTelNo1.TabIndex = 15
        Me.txtTelNo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(227, 298)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 35)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(107, 117)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(196, 121)
        Me.txtAddress.TabIndex = 14
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(25, 298)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblSupplierID
        '
        Me.lblSupplierID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSupplierID.Location = New System.Drawing.Point(106, 16)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(113, 24)
        Me.lblSupplierID.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Address:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tel No.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelName
        '
        Me.labelName.Location = New System.Drawing.Point(13, 53)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(88, 17)
        Me.labelName.TabIndex = 16
        Me.labelName.Text = "&Name:"
        Me.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(106, 51)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(196, 22)
        Me.txtName.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Supplier ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(13, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Email:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 78)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(196, 22)
        Me.txtEmail.TabIndex = 29
        '
        'FrmCreateSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(326, 342)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtTelNo2)
        Me.Controls.Add(Me.txtTelNo1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSupplierID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCreateSupplier"
        Me.Text = "Create Supplier"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents txtTelNo2 As TextBox
    Friend WithEvents txtTelNo1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblSupplierID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labelName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
End Class
