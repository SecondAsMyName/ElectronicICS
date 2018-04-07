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
        Me.SuspendLayout()
        '
        'btnDeliveryMenu
        '
        Me.btnDeliveryMenu.Location = New System.Drawing.Point(35, 123)
        Me.btnDeliveryMenu.Name = "btnDeliveryMenu"
        Me.btnDeliveryMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnDeliveryMenu.TabIndex = 0
        Me.btnDeliveryMenu.Text = "Delivery"
        Me.btnDeliveryMenu.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDeliveryMenu)
        Me.Name = "MainPage"
        Me.Text = "ElectronicICS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDeliveryMenu As Button
End Class
