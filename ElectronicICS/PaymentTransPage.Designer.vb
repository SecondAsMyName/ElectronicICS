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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboOrderID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPayID = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.rtbRemarks = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radCreditCard = New System.Windows.Forms.RadioButton()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ElectronicICS.My.Resources.Resources.creditcard
        Me.PictureBox2.Location = New System.Drawing.Point(347, 159)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElectronicICS.My.Resources.Resources.cash
        Me.PictureBox1.Location = New System.Drawing.Point(90, 159)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'cboOrderID
        '
        Me.cboOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrderID.FormattingEnabled = True
        Me.cboOrderID.Location = New System.Drawing.Point(90, 18)
        Me.cboOrderID.Name = "cboOrderID"
        Me.cboOrderID.Size = New System.Drawing.Size(121, 21)
        Me.cboOrderID.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Order ID :"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(90, 267)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(150, 24)
        Me.lblPrice.TabIndex = 26
        '
        'lblPayID
        '
        Me.lblPayID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayID.Location = New System.Drawing.Point(90, 68)
        Me.lblPayID.Name = "lblPayID"
        Me.lblPayID.Size = New System.Drawing.Size(150, 24)
        Me.lblPayID.TabIndex = 25
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(377, 419)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 42)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(248, 419)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(77, 42)
        Me.btnPay.TabIndex = 23
        Me.btnPay.Text = "&Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'rtbRemarks
        '
        Me.rtbRemarks.Location = New System.Drawing.Point(90, 308)
        Me.rtbRemarks.Name = "rtbRemarks"
        Me.rtbRemarks.Size = New System.Drawing.Size(362, 96)
        Me.rtbRemarks.TabIndex = 22
        Me.rtbRemarks.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Remarks :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Price (RM):"
        '
        'radCreditCard
        '
        Me.radCreditCard.AutoSize = True
        Me.radCreditCard.Location = New System.Drawing.Point(248, 159)
        Me.radCreditCard.Name = "radCreditCard"
        Me.radCreditCard.Size = New System.Drawing.Size(77, 17)
        Me.radCreditCard.TabIndex = 19
        Me.radCreditCard.TabStop = True
        Me.radCreditCard.Text = "Credit Card"
        Me.radCreditCard.UseVisualStyleBackColor = True
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Location = New System.Drawing.Point(12, 159)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(49, 17)
        Me.radCash.TabIndex = 18
        Me.radCash.TabStop = True
        Me.radCash.Text = "Cash"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Select Payment Type :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Payment ID :"
        '
        'PaymentTransPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 494)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboOrderID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblPayID)
        Me.Controls.Add(Me.btnExit)
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboOrderID As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblPayID As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents rtbRemarks As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents radCreditCard As RadioButton
    Friend WithEvents radCash As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
