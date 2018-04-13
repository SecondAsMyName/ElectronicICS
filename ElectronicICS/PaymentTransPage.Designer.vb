<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentTransPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.radCreditCard = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtbRemarks = New System.Windows.Forms.RichTextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblPayID = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Payment Type :"
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Location = New System.Drawing.Point(19, 116)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(49, 17)
        Me.radCash.TabIndex = 2
        Me.radCash.TabStop = True
        Me.radCash.Text = "Cash"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'radCreditCard
        '
        Me.radCreditCard.AutoSize = True
        Me.radCreditCard.Location = New System.Drawing.Point(100, 116)
        Me.radCreditCard.Name = "radCreditCard"
        Me.radCreditCard.Size = New System.Drawing.Size(77, 17)
        Me.radCreditCard.TabIndex = 3
        Me.radCreditCard.TabStop = True
        Me.radCreditCard.Text = "Credit Card"
        Me.radCreditCard.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Price (RM):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Remarks :"
        '
        'rtbRemarks
        '
        Me.rtbRemarks.Location = New System.Drawing.Point(100, 192)
        Me.rtbRemarks.Name = "rtbRemarks"
        Me.rtbRemarks.Size = New System.Drawing.Size(219, 97)
        Me.rtbRemarks.TabIndex = 6
        Me.rtbRemarks.Text = ""
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(122, 295)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(77, 42)
        Me.btnPay.TabIndex = 7
        Me.btnPay.Text = "&Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblPayID
        '
        Me.lblPayID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayID.Location = New System.Drawing.Point(100, 48)
        Me.lblPayID.Name = "lblPayID"
        Me.lblPayID.Size = New System.Drawing.Size(150, 24)
        Me.lblPayID.TabIndex = 9
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(100, 154)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(150, 24)
        Me.lblPrice.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Order ID :"
        '
        'lblOrderID
        '
        Me.lblOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrderID.Location = New System.Drawing.Point(100, 9)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(150, 24)
        Me.lblOrderID.TabIndex = 13
        '
        'PaymentTransPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 344)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblPayID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.rtbRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.radCreditCard)
        Me.Controls.Add(Me.radCash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaymentTransPage"
        Me.Text = "PaymentTransPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radCash As RadioButton
    Friend WithEvents radCreditCard As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rtbRemarks As RichTextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblPayID As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOrderID As Label
End Class
