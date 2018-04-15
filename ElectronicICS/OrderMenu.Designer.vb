<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderMenu
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
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnHis = New System.Windows.Forms.Button()
        Me.btnPend = New System.Windows.Forms.Button()
        Me.btnORemark = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCart
        '
        Me.btnCart.Location = New System.Drawing.Point(37, 35)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(137, 63)
        Me.btnCart.TabIndex = 0
        Me.btnCart.Text = "Order &Cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnHis
        '
        Me.btnHis.Location = New System.Drawing.Point(247, 35)
        Me.btnHis.Name = "btnHis"
        Me.btnHis.Size = New System.Drawing.Size(126, 63)
        Me.btnHis.TabIndex = 1
        Me.btnHis.Text = "Order &History"
        Me.btnHis.UseVisualStyleBackColor = True
        '
        'btnPend
        '
        Me.btnPend.Location = New System.Drawing.Point(37, 198)
        Me.btnPend.Name = "btnPend"
        Me.btnPend.Size = New System.Drawing.Size(137, 64)
        Me.btnPend.TabIndex = 2
        Me.btnPend.Text = "Pending &Order"
        Me.btnPend.UseVisualStyleBackColor = True
        '
        'btnORemark
        '
        Me.btnORemark.Location = New System.Drawing.Point(247, 198)
        Me.btnORemark.Name = "btnORemark"
        Me.btnORemark.Size = New System.Drawing.Size(126, 64)
        Me.btnORemark.TabIndex = 3
        Me.btnORemark.Text = "Update Order &Remark"
        Me.btnORemark.UseVisualStyleBackColor = True
        '
        'OrderMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(416, 323)
        Me.Controls.Add(Me.btnORemark)
        Me.Controls.Add(Me.btnPend)
        Me.Controls.Add(Me.btnHis)
        Me.Controls.Add(Me.btnCart)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "OrderMenu"
        Me.Text = "OrderMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCart As Button
    Friend WithEvents btnHis As Button
    Friend WithEvents btnPend As Button
    Friend WithEvents btnORemark As Button
End Class
