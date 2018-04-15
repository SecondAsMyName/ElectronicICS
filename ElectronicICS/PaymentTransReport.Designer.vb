<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentTransReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentTransReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintReport = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreviewReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.mnuTransReport = New System.Windows.Forms.MenuStrip()
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuTransReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Payment Transaction Report"
        '
        'dgvReport
        '
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(24, 72)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.Size = New System.Drawing.Size(688, 238)
        Me.dgvReport.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(596, 342)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(387, 342)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintReport
        '
        '
        'dlgPreviewReport
        '
        Me.dlgPreviewReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewReport.Enabled = True
        Me.dlgPreviewReport.Icon = CType(resources.GetObject("dlgPreviewReport.Icon"), System.Drawing.Icon)
        Me.dlgPreviewReport.Name = "dlgPreviewReport"
        Me.dlgPreviewReport.Visible = False
        '
        'mnuTransReport
        '
        Me.mnuTransReport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToolStripMenuItem})
        Me.mnuTransReport.Location = New System.Drawing.Point(0, 0)
        Me.mnuTransReport.Name = "mnuTransReport"
        Me.mnuTransReport.Size = New System.Drawing.Size(724, 24)
        Me.mnuTransReport.TabIndex = 9
        Me.mnuTransReport.Text = "MenuStrip1"
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.GoBackToolStripMenuItem.Text = "Go back"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(490, 342)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 10
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(45, 347)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(100, 23)
        Me.lblCount.TabIndex = 11
        '
        'PaymentTransReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(724, 402)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuTransReport)
        Me.MainMenuStrip = Me.mnuTransReport
        Me.Name = "PaymentTransReport"
        Me.Text = "Payment Transaction Report"
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuTransReport.ResumeLayout(False)
        Me.mnuTransReport.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintReport As Printing.PrintDocument
    Friend WithEvents dlgPreviewReport As PrintPreviewDialog
    Friend WithEvents mnuTransReport As MenuStrip
    Friend WithEvents GoBackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblCount As Label
End Class
