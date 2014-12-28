<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblTagLine = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.ttUsernameError = New MetroFramework.Components.MetroToolTip()
        Me.ttPasswordError = New MetroFramework.Components.MetroToolTip()
        Me.pbPasswordError = New System.Windows.Forms.PictureBox()
        Me.pbUsernameError = New System.Windows.Forms.PictureBox()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPasswordError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsernameError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUsername.Font = New System.Drawing.Font("Segoe UI Light", 10.25!)
        Me.tbUsername.ForeColor = System.Drawing.Color.White
        Me.tbUsername.Location = New System.Drawing.Point(216, 141)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(150, 26)
        Me.tbUsername.TabIndex = 3
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI Light", 10.25!)
        Me.tbPassword.ForeColor = System.Drawing.Color.White
        Me.tbPassword.Location = New System.Drawing.Point(216, 175)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(150, 26)
        Me.tbPassword.TabIndex = 5
        '
        'btnSignIn
        '
        Me.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI Light", 11.25!)
        Me.btnSignIn.Location = New System.Drawing.Point(130, 224)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(239, 32)
        Me.btnSignIn.TabIndex = 6
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI Light", 8.0!)
        Me.lblCopyright.ForeColor = System.Drawing.Color.Silver
        Me.lblCopyright.Location = New System.Drawing.Point(189, 272)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(109, 13)
        Me.lblCopyright.TabIndex = 7
        Me.lblCopyright.Text = "© Daniel John Gomez"
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Light", 12.25!)
        Me.lblUsername.Location = New System.Drawing.Point(123, 141)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(87, 23)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Light", 12.25!)
        Me.lblPassword.Location = New System.Drawing.Point(123, 175)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(82, 23)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        '
        'lblTagLine
        '
        Me.lblTagLine.AutoSize = True
        Me.lblTagLine.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagLine.ForeColor = System.Drawing.Color.Snow
        Me.lblTagLine.Location = New System.Drawing.Point(188, 92)
        Me.lblTagLine.Name = "lblTagLine"
        Me.lblTagLine.Size = New System.Drawing.Size(139, 20)
        Me.lblTagLine.TabIndex = 1
        Me.lblTagLine.Text = "A faster way to serve"
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(161, 60)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(195, 32)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Spike"
        '
        'ttUsernameError
        '
        Me.ttUsernameError.Style = MetroFramework.MetroColorStyle.Blue
        Me.ttUsernameError.StyleManager = Nothing
        Me.ttUsernameError.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ttPasswordError
        '
        Me.ttPasswordError.Style = MetroFramework.MetroColorStyle.Blue
        Me.ttPasswordError.StyleManager = Nothing
        Me.ttPasswordError.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'pbPasswordError
        '
        Me.pbPasswordError.Image = CType(resources.GetObject("pbPasswordError.ImageBytes"), System.Drawing.Image)
        Me.pbPasswordError.Location = New System.Drawing.Point(372, 175)
        Me.pbPasswordError.Name = "pbPasswordError"
        Me.pbPasswordError.Padding = New System.Windows.Forms.Padding(5)
        Me.pbPasswordError.Size = New System.Drawing.Size(26, 26)
        Me.pbPasswordError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPasswordError.TabIndex = 11
        Me.pbPasswordError.TabStop = False
        Me.pbPasswordError.Visible = False
        '
        'pbUsernameError
        '
        Me.pbUsernameError.Image = CType(resources.GetObject("pbUsernameError.ImageBytes"), System.Drawing.Image)
        Me.pbUsernameError.Location = New System.Drawing.Point(372, 141)
        Me.pbUsernameError.Name = "pbUsernameError"
        Me.pbUsernameError.Padding = New System.Windows.Forms.Padding(5)
        Me.pbUsernameError.Size = New System.Drawing.Size(26, 26)
        Me.pbUsernameError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUsernameError.TabIndex = 10
        Me.pbUsernameError.TabStop = False
        Me.pbUsernameError.Visible = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.Controls.Add(Me.pbPasswordError)
        Me.Controls.Add(Me.pbUsernameError)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTagLine)
        Me.Controls.Add(Me.lblWelcome)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "Login"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPasswordError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsernameError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnSignIn As System.Windows.Forms.Button
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents pbUsernameError As System.Windows.Forms.PictureBox
    Friend WithEvents pbPasswordError As System.Windows.Forms.PictureBox
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblTagLine As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents ttUsernameError As MetroFramework.Components.MetroToolTip
    Friend WithEvents ttPasswordError As MetroFramework.Components.MetroToolTip

End Class
