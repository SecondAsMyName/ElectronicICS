<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentMainPage
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
        Me.btnMakePay = New System.Windows.Forms.Button()
        Me.btnShowPayTransRecord = New System.Windows.Forms.Button()
        Me.mnuPayMainPage = New System.Windows.Forms.MenuStrip()
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnuPayMainPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMakePay
        '
        Me.btnMakePay.Location = New System.Drawing.Point(123, 52)
        Me.btnMakePay.Name = "btnMakePay"
        Me.btnMakePay.Size = New System.Drawing.Size(195, 47)
        Me.btnMakePay.TabIndex = 0
        Me.btnMakePay.Text = "Make Payment"
        Me.btnMakePay.UseVisualStyleBackColor = True
        '
        'btnShowPayTransRecord
        '
        Me.btnShowPayTransRecord.Location = New System.Drawing.Point(123, 133)
        Me.btnShowPayTransRecord.Name = "btnShowPayTransRecord"
        Me.btnShowPayTransRecord.Size = New System.Drawing.Size(195, 50)
        Me.btnShowPayTransRecord.TabIndex = 1
        Me.btnShowPayTransRecord.Text = "Show Payment Transaction Record"
        Me.btnShowPayTransRecord.UseVisualStyleBackColor = True
        '
        'mnuPayMainPage
        '
        Me.mnuPayMainPage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToolStripMenuItem})
        Me.mnuPayMainPage.Location = New System.Drawing.Point(0, 0)
        Me.mnuPayMainPage.Name = "mnuPayMainPage"
        Me.mnuPayMainPage.Size = New System.Drawing.Size(476, 24)
        Me.mnuPayMainPage.TabIndex = 2
        Me.mnuPayMainPage.Text = "MenuStrip1"
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.GoBackToolStripMenuItem.Text = "Go back"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElectronicICS.My.Resources.Resources.cash
        Me.PictureBox1.Location = New System.Drawing.Point(345, 163)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PaymentMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(476, 269)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnShowPayTransRecord)
        Me.Controls.Add(Me.btnMakePay)
        Me.Controls.Add(Me.mnuPayMainPage)
        Me.MainMenuStrip = Me.mnuPayMainPage
        Me.Name = "PaymentMainPage"
        Me.Text = "Payment Main Page"
        Me.mnuPayMainPage.ResumeLayout(False)
        Me.mnuPayMainPage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMakePay As Button
    Friend WithEvents btnShowPayTransRecord As Button
    Friend WithEvents mnuPayMainPage As MenuStrip
    Friend WithEvents GoBackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
