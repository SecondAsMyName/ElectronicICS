<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderMenu
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
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnHis = New System.Windows.Forms.Button()
        Me.btnPend = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElectronicICS.My.Resources.Resources.Order_now
        Me.PictureBox1.Location = New System.Drawing.Point(203, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'OrderMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(416, 323)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPend)
        Me.Controls.Add(Me.btnHis)
        Me.Controls.Add(Me.btnCart)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "OrderMenu"
        Me.Text = "OrderMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCart As Button
    Friend WithEvents btnHis As Button
    Friend WithEvents btnPend As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
