<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreateItem
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.TextBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblPriceCen = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.TextBox()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelName
        '
        Me.labelName.Location = New System.Drawing.Point(18, 65)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(88, 17)
        Me.labelName.TabIndex = 3
        Me.labelName.Text = "&Name:"
        Me.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Price (RM):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&Description:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(22, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "&Quantity:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemID
        '
        Me.lblItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemID.Location = New System.Drawing.Point(111, 28)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(113, 24)
        Me.lblItemID.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(111, 97)
        Me.lblDescription.MaxLength = 50
        Me.lblDescription.Multiline = True
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(196, 121)
        Me.lblDescription.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.CausesValidation = False
        Me.Button2.Location = New System.Drawing.Point(232, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(111, 244)
        Me.lblPrice.MaxLength = 10
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 22)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'lblPriceCen
        '
        Me.lblPriceCen.Location = New System.Drawing.Point(221, 244)
        Me.lblPriceCen.MaxLength = 2
        Me.lblPriceCen.Name = "lblPriceCen"
        Me.lblPriceCen.Size = New System.Drawing.Size(30, 22)
        Me.lblPriceCen.TabIndex = 12
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(111, 279)
        Me.lblQuantity.MaxLength = 10
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 22)
        Me.lblQuantity.TabIndex = 13
        Me.lblQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(111, 63)
        Me.lblName.MaxLength = 50
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(196, 22)
        Me.lblName.TabIndex = 1
        '
        'FrmCreateItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(317, 350)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPriceCen)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblItemID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCreateItem"
        Me.Text = "Add New Item"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labelName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblItemID As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDescription As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrice As TextBox
    Friend WithEvents err As ErrorProvider
    Friend WithEvents lblQuantity As TextBox
    Friend WithEvents lblPriceCen As TextBox
    Friend WithEvents lblName As TextBox
End Class
