<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateItem
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
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPriceCen = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labeldesc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(107, 262)
        Me.txtQuantity.MaxLength = 10
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantity.TabIndex = 19
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPriceCen
        '
        Me.txtPriceCen.CausesValidation = False
        Me.txtPriceCen.Location = New System.Drawing.Point(217, 227)
        Me.txtPriceCen.MaxLength = 2
        Me.txtPriceCen.Name = "txtPriceCen"
        Me.txtPriceCen.Size = New System.Drawing.Size(30, 22)
        Me.txtPriceCen.TabIndex = 16
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(107, 227)
        Me.txtPrice.MaxLength = 10
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 14
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(107, 80)
        Me.txtDesc.MaxLength = 50
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(196, 121)
        Me.txtDesc.TabIndex = 13
        '
        'lblItemID
        '
        Me.lblItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemID.Location = New System.Drawing.Point(107, 11)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(113, 24)
        Me.lblItemID.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(18, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "&Quantity:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labeldesc
        '
        Me.labeldesc.Location = New System.Drawing.Point(8, 83)
        Me.labeldesc.Name = "labeldesc"
        Me.labeldesc.Size = New System.Drawing.Size(93, 17)
        Me.labeldesc.TabIndex = 17
        Me.labeldesc.Text = "&Description:"
        Me.labeldesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "&Price (RM):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelName
        '
        Me.labelName.Location = New System.Drawing.Point(14, 48)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(88, 17)
        Me.labelName.TabIndex = 15
        Me.labelName.Text = "&Name:"
        Me.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(107, 46)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(196, 22)
        Me.txtName.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Item ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(110, 301)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.Location = New System.Drawing.Point(228, 301)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'FrmUpdateItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(333, 336)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPriceCen)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblItemID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labeldesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmUpdateItem"
        Me.Text = "FrmUpdateItem"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPriceCen As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblItemID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labeldesc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labelName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents err As ErrorProvider
End Class
