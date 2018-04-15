<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreateDelivery
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
        Me.lblDeliveryID = New System.Windows.Forms.Label()
        Me.ddlOrderID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDeliveryDate = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CREATE DELIVERY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Delivery ID: "
        '
        'lblDeliveryID
        '
        Me.lblDeliveryID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliveryID.Location = New System.Drawing.Point(112, 61)
        Me.lblDeliveryID.Name = "lblDeliveryID"
        Me.lblDeliveryID.Size = New System.Drawing.Size(64, 20)
        Me.lblDeliveryID.TabIndex = 2
        '
        'ddlOrderID
        '
        Me.ddlOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlOrderID.FormattingEnabled = True
        Me.ddlOrderID.Location = New System.Drawing.Point(116, 100)
        Me.ddlOrderID.Name = "ddlOrderID"
        Me.ddlOrderID.Size = New System.Drawing.Size(121, 21)
        Me.ddlOrderID.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Order ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date:"
        '
        'lblDeliveryDate
        '
        Me.lblDeliveryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliveryDate.Location = New System.Drawing.Point(116, 148)
        Me.lblDeliveryDate.Name = "lblDeliveryDate"
        Me.lblDeliveryDate.Size = New System.Drawing.Size(100, 23)
        Me.lblDeliveryDate.TabIndex = 6
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(12, 211)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(110, 39)
        Me.btnCreate.TabIndex = 7
        Me.btnCreate.Text = "&Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(148, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FrmCreateDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 258)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblDeliveryDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ddlOrderID)
        Me.Controls.Add(Me.lblDeliveryID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCreateDelivery"
        Me.Text = "FrmCreateDelivery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDeliveryID As Label
    Friend WithEvents ddlOrderID As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDeliveryDate As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnExit As Button
End Class
