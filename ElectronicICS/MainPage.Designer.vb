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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDeliveryMenu
        '
        Me.btnDeliveryMenu.Location = New System.Drawing.Point(209, 147)
        Me.btnDeliveryMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeliveryMenu.Name = "btnDeliveryMenu"
        Me.btnDeliveryMenu.Size = New System.Drawing.Size(100, 28)
        Me.btnDeliveryMenu.TabIndex = 0
        Me.btnDeliveryMenu.Text = "Delivery"
        Me.btnDeliveryMenu.UseVisualStyleBackColor = True
        '
        'btnOrderForm
        '
        Me.btnOrderForm.Location = New System.Drawing.Point(46, 30)
        Me.btnOrderForm.Name = "btnOrderForm"
        Me.btnOrderForm.Size = New System.Drawing.Size(75, 23)
        Me.btnOrderForm.TabIndex = 1
        Me.btnOrderForm.Text = "Order"
        Me.btnOrderForm.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(240, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(62, 147)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOrderForm)
        Me.Controls.Add(Me.btnDeliveryMenu)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainPage"
        Me.Text = "ElectronicICS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDeliveryMenu As Button
    Friend WithEvents btnOrderForm As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
