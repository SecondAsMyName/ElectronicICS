<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSignUp
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.mskPassword = New System.Windows.Forms.MaskedTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.mskEmail = New System.Windows.Forms.MaskedTextBox()
        Me.mskHpNo = New System.Windows.Forms.MaskedTextBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender :"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(105, 153)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 5
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(199, 153)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 6
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "HP Number :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Address :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Email :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(94, 47)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'mskPassword
        '
        Me.mskPassword.Location = New System.Drawing.Point(94, 81)
        Me.mskPassword.Name = "mskPassword"
        Me.mskPassword.Size = New System.Drawing.Size(100, 20)
        Me.mskPassword.TabIndex = 13
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(94, 222)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(331, 72)
        Me.RichTextBox1.TabIndex = 15
        Me.RichTextBox1.Text = ""
        '
        'mskEmail
        '
        Me.mskEmail.Location = New System.Drawing.Point(94, 307)
        Me.mskEmail.Name = "mskEmail"
        Me.mskEmail.Size = New System.Drawing.Size(100, 20)
        Me.mskEmail.TabIndex = 16
        '
        'mskHpNo
        '
        Me.mskHpNo.Location = New System.Drawing.Point(94, 187)
        Me.mskHpNo.Name = "mskHpNo"
        Me.mskHpNo.Size = New System.Drawing.Size(100, 20)
        Me.mskHpNo.TabIndex = 17
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(182, 360)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUp.TabIndex = 18
        Me.btnSignUp.Text = "&Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 360)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FrmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(502, 395)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.mskHpNo)
        Me.Controls.Add(Me.mskEmail)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.mskPassword)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSignUp"
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents mskPassword As MaskedTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents mskEmail As MaskedTextBox
    Friend WithEvents mskHpNo As MaskedTextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnExit As Button
End Class
