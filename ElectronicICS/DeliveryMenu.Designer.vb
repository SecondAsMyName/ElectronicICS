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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeliveryMenu))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTrackDelivery = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUpdateDelivery = New System.Windows.Forms.Button()
        Me.btnCreateOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 40)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTrackDelivery
        '
        Me.btnTrackDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrackDelivery.Location = New System.Drawing.Point(12, 147)
        Me.btnTrackDelivery.Name = "btnTrackDelivery"
        Me.btnTrackDelivery.Size = New System.Drawing.Size(168, 40)
        Me.btnTrackDelivery.TabIndex = 2
        Me.btnTrackDelivery.Text = "Track Delivery"
        Me.btnTrackDelivery.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(12, 193)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(168, 40)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnUpdateDelivery
        '
        Me.btnUpdateDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDelivery.Location = New System.Drawing.Point(12, 101)
        Me.btnUpdateDelivery.Name = "btnUpdateDelivery"
        Me.btnUpdateDelivery.Size = New System.Drawing.Size(168, 40)
        Me.btnUpdateDelivery.TabIndex = 4
        Me.btnUpdateDelivery.Text = "Update Delivery"
        Me.btnUpdateDelivery.UseVisualStyleBackColor = True
        '
        'btnCreateOrder
        '
        Me.btnCreateOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateOrder.Location = New System.Drawing.Point(12, 55)
        Me.btnCreateOrder.Name = "btnCreateOrder"
        Me.btnCreateOrder.Size = New System.Drawing.Size(168, 40)
        Me.btnCreateOrder.TabIndex = 5
        Me.btnCreateOrder.Text = "Create Delivery"
        Me.btnCreateOrder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "DELIVERY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(186, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'DeliveryMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 291)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateOrder)
        Me.Controls.Add(Me.btnUpdateDelivery)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnTrackDelivery)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "DeliveryMenu"
        Me.Text = "Delivery"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents btnTrackDelivery As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUpdateDelivery As Button
    Friend WithEvents btnCreateOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
