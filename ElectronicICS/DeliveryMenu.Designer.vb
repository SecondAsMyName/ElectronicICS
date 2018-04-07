<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeliveryMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstDelivery = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCurrentStatus = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnUpdateDelivery = New System.Windows.Forms.Button()
        Me.btnCreateOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstDelivery
        '
        Me.lstDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDelivery.FormattingEnabled = True
        Me.lstDelivery.ItemHeight = 20
        Me.lstDelivery.Location = New System.Drawing.Point(12, 124)
        Me.lstDelivery.Name = "lstDelivery"
        Me.lstDelivery.ScrollAlwaysVisible = True
        Me.lstDelivery.Size = New System.Drawing.Size(454, 224)
        Me.lstDelivery.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(472, 310)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 40)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCurrentStatus
        '
        Me.btnCurrentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentStatus.Location = New System.Drawing.Point(472, 266)
        Me.btnCurrentStatus.Name = "btnCurrentStatus"
        Me.btnCurrentStatus.Size = New System.Drawing.Size(168, 40)
        Me.btnCurrentStatus.TabIndex = 2
        Me.btnCurrentStatus.Text = "Current Status"
        Me.btnCurrentStatus.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(472, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 40)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Assign"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnUpdateDelivery
        '
        Me.btnUpdateDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDelivery.Location = New System.Drawing.Point(472, 174)
        Me.btnUpdateDelivery.Name = "btnUpdateDelivery"
        Me.btnUpdateDelivery.Size = New System.Drawing.Size(168, 40)
        Me.btnUpdateDelivery.TabIndex = 4
        Me.btnUpdateDelivery.Text = "Update Delivery"
        Me.btnUpdateDelivery.UseVisualStyleBackColor = True
        '
        'btnCreateOrder
        '
        Me.btnCreateOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateOrder.Location = New System.Drawing.Point(472, 128)
        Me.btnCreateOrder.Name = "btnCreateOrder"
        Me.btnCreateOrder.Size = New System.Drawing.Size(168, 40)
        Me.btnCreateOrder.TabIndex = 5
        Me.btnCreateOrder.Text = "Create Delivery"
        Me.btnCreateOrder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "DELIVERY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Delivery Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateOrder)
        Me.Controls.Add(Me.btnUpdateDelivery)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnCurrentStatus)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstDelivery)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDelivery As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCurrentStatus As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnUpdateDelivery As Button
    Friend WithEvents btnCreateOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
