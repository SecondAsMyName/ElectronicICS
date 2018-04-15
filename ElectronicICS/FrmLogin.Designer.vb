<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.grTitle = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskPassword = New System.Windows.Forms.MaskedTextBox()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.errLogin = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pcLogo = New System.Windows.Forms.PictureBox()
        Me.grTitle.SuspendLayout()
        CType(Me.errLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(84, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&User Name :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(84, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Password :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(189, 118)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(155, 22)
        Me.txtUsername.TabIndex = 0
        '
        'grTitle
        '
        Me.grTitle.Controls.Add(Me.Label3)
        Me.grTitle.Controls.Add(Me.pcLogo)
        Me.grTitle.Location = New System.Drawing.Point(12, 12)
        Me.grTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grTitle.Name = "grTitle"
        Me.grTitle.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grTitle.Size = New System.Drawing.Size(469, 100)
        Me.grTitle.TabIndex = 4
        Me.grTitle.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(291, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Electronic Shop Sdn.bhd."
        '
        'mskPassword
        '
        Me.mskPassword.Location = New System.Drawing.Point(189, 159)
        Me.mskPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskPassword.Name = "mskPassword"
        Me.mskPassword.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mskPassword.Size = New System.Drawing.Size(155, 22)
        Me.mskPassword.TabIndex = 1
        Me.mskPassword.UseSystemPasswordChar = True
        '
        'btnSignin
        '
        Me.btnSignin.BackColor = System.Drawing.Color.LightCoral
        Me.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignin.Location = New System.Drawing.Point(220, 187)
        Me.btnSignin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(83, 30)
        Me.btnSignin.TabIndex = 2
        Me.btnSignin.Text = "Sign &In"
        Me.btnSignin.UseVisualStyleBackColor = False
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.LightCoral
        Me.btnSignup.CausesValidation = False
        Me.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSignup.Location = New System.Drawing.Point(220, 238)
        Me.btnSignup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(83, 30)
        Me.btnSignup.TabIndex = 3
        Me.btnSignup.Text = "&Sign Up"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.CausesValidation = False
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(392, 231)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Or"
        '
        'errLogin
        '
        Me.errLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errLogin.ContainerControl = Me
        '
        'pcLogo
        '
        Me.pcLogo.BackColor = System.Drawing.SystemColors.Control
        Me.pcLogo.Image = Global.ElectronicICS.My.Resources.Resources.LogoMakr_9T5ghY
        Me.pcLogo.Location = New System.Drawing.Point(6, 0)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.Size = New System.Drawing.Size(457, 95)
        Me.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcLogo.TabIndex = 6
        Me.pcLogo.TabStop = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnSignin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(491, 281)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.mskPassword)
        Me.Controls.Add(Me.grTitle)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.grTitle.ResumeLayout(False)
        CType(Me.errLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents grTitle As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskPassword As MaskedTextBox
    Friend WithEvents btnSignin As Button
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents errLogin As ErrorProvider
    Friend WithEvents pcLogo As PictureBox
End Class
