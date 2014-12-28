<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonDetailView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.UserPanel = New System.Windows.Forms.Panel()
        Me.tbDoB = New System.Windows.Forms.MaskedTextBox()
        Me.pbPicture = New System.Windows.Forms.PictureBox()
        Me.tbUsername = New MetroFramework.Controls.MetroTextBox()
        Me.tbPassword = New MetroFramework.Controls.MetroTextBox()
        Me.pbEye = New System.Windows.Forms.PictureBox()
        Me.lblFirstName = New MetroFramework.Controls.MetroLabel()
        Me.cbGender = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.tbFirstName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.tbMiddleName = New MetroFramework.Controls.MetroTextBox()
        Me.tbAddress = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cbAccountStatus = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.tbLastName = New MetroFramework.Controls.MetroTextBox()
        Me.cbAccountType = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.UserPanel.SuspendLayout()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserPanel
        '
        Me.UserPanel.Controls.Add(Me.tbDoB)
        Me.UserPanel.Controls.Add(Me.pbPicture)
        Me.UserPanel.Controls.Add(Me.tbUsername)
        Me.UserPanel.Controls.Add(Me.tbPassword)
        Me.UserPanel.Controls.Add(Me.pbEye)
        Me.UserPanel.Controls.Add(Me.lblFirstName)
        Me.UserPanel.Controls.Add(Me.cbGender)
        Me.UserPanel.Controls.Add(Me.MetroLabel1)
        Me.UserPanel.Controls.Add(Me.MetroLabel9)
        Me.UserPanel.Controls.Add(Me.tbFirstName)
        Me.UserPanel.Controls.Add(Me.MetroLabel8)
        Me.UserPanel.Controls.Add(Me.tbMiddleName)
        Me.UserPanel.Controls.Add(Me.tbAddress)
        Me.UserPanel.Controls.Add(Me.MetroLabel3)
        Me.UserPanel.Controls.Add(Me.MetroLabel7)
        Me.UserPanel.Controls.Add(Me.MetroLabel2)
        Me.UserPanel.Controls.Add(Me.cbAccountStatus)
        Me.UserPanel.Controls.Add(Me.MetroLabel4)
        Me.UserPanel.Controls.Add(Me.MetroLabel6)
        Me.UserPanel.Controls.Add(Me.tbLastName)
        Me.UserPanel.Controls.Add(Me.cbAccountType)
        Me.UserPanel.Controls.Add(Me.MetroLabel5)
        Me.UserPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserPanel.Enabled = False
        Me.UserPanel.Location = New System.Drawing.Point(0, 0)
        Me.UserPanel.Name = "UserPanel"
        Me.UserPanel.Size = New System.Drawing.Size(554, 337)
        Me.UserPanel.TabIndex = 30
        '
        'tbDoB
        '
        Me.tbDoB.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tbDoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDoB.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDoB.ForeColor = System.Drawing.Color.White
        Me.tbDoB.Location = New System.Drawing.Point(362, 279)
        Me.tbDoB.Mask = "99/99/0000"
        Me.tbDoB.Name = "tbDoB"
        Me.tbDoB.Size = New System.Drawing.Size(145, 22)
        Me.tbDoB.TabIndex = 53
        '
        'pbPicture
        '
        Me.pbPicture.Image = Global.Spike.My.Resources.Resources.imgUserDefault
        Me.pbPicture.Location = New System.Drawing.Point(3, 3)
        Me.pbPicture.Name = "pbPicture"
        Me.pbPicture.Size = New System.Drawing.Size(110, 105)
        Me.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPicture.TabIndex = 30
        Me.pbPicture.TabStop = False
        '
        'tbUsername
        '
        Me.tbUsername.Lines = New String(-1) {}
        Me.tbUsername.Location = New System.Drawing.Point(139, 25)
        Me.tbUsername.MaxLength = 32767
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.Size = New System.Drawing.Size(146, 23)
        Me.tbUsername.TabIndex = 31
        Me.tbUsername.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbUsername.UseSelectable = True
        '
        'tbPassword
        '
        Me.tbPassword.Lines = New String(-1) {}
        Me.tbPassword.Location = New System.Drawing.Point(139, 85)
        Me.tbPassword.MaxLength = 32767
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.Size = New System.Drawing.Size(146, 23)
        Me.tbPassword.TabIndex = 32
        Me.tbPassword.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbPassword.UseSelectable = True
        '
        'pbEye
        '
        Me.pbEye.Image = Global.Spike.My.Resources.Resources.closedeye
        Me.pbEye.Location = New System.Drawing.Point(291, 85)
        Me.pbEye.Name = "pbEye"
        Me.pbEye.Padding = New System.Windows.Forms.Padding(3)
        Me.pbEye.Size = New System.Drawing.Size(23, 23)
        Me.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEye.TabIndex = 50
        Me.pbEye.TabStop = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(139, 3)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(71, 19)
        Me.lblFirstName.TabIndex = 33
        Me.lblFirstName.Text = "Username:"
        Me.lblFirstName.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbGender
        '
        Me.cbGender.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbGender.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.ItemHeight = 19
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(3, 211)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(146, 25)
        Me.cbGender.TabIndex = 49
        Me.cbGender.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbGender.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(138, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel1.TabIndex = 34
        Me.MetroLabel1.Text = "Password"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(3, 189)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel9.TabIndex = 48
        Me.MetroLabel9.Text = "Gender:"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tbFirstName
        '
        Me.tbFirstName.Lines = New String(-1) {}
        Me.tbFirstName.Location = New System.Drawing.Point(3, 152)
        Me.tbFirstName.MaxLength = 32767
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbFirstName.SelectedText = ""
        Me.tbFirstName.Size = New System.Drawing.Size(146, 23)
        Me.tbFirstName.TabIndex = 35
        Me.tbFirstName.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbFirstName.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(361, 257)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel8.TabIndex = 47
        Me.MetroLabel8.Text = "Date of Birth:"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tbMiddleName
        '
        Me.tbMiddleName.Lines = New String(-1) {}
        Me.tbMiddleName.Location = New System.Drawing.Point(180, 152)
        Me.tbMiddleName.MaxLength = 32767
        Me.tbMiddleName.Name = "tbMiddleName"
        Me.tbMiddleName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMiddleName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbMiddleName.SelectedText = ""
        Me.tbMiddleName.Size = New System.Drawing.Size(146, 23)
        Me.tbMiddleName.TabIndex = 36
        Me.tbMiddleName.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbMiddleName.UseSelectable = True
        '
        'tbAddress
        '
        Me.tbAddress.Lines = New String(-1) {}
        Me.tbAddress.Location = New System.Drawing.Point(3, 279)
        Me.tbAddress.MaxLength = 32767
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAddress.SelectedText = ""
        Me.tbAddress.Size = New System.Drawing.Size(323, 47)
        Me.tbAddress.TabIndex = 46
        Me.tbAddress.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbAddress.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 130)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel3.TabIndex = 37
        Me.MetroLabel3.Text = "First Name:"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 257)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel7.TabIndex = 45
        Me.MetroLabel7.Text = "Address"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(180, 130)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel2.TabIndex = 38
        Me.MetroLabel2.Text = "Middle Name:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbAccountStatus
        '
        Me.cbAccountStatus.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbAccountStatus.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.cbAccountStatus.FormattingEnabled = True
        Me.cbAccountStatus.ItemHeight = 19
        Me.cbAccountStatus.Items.AddRange(New Object() {"Active", "Inactive", "Disabled"})
        Me.cbAccountStatus.Location = New System.Drawing.Point(361, 211)
        Me.cbAccountStatus.Name = "cbAccountStatus"
        Me.cbAccountStatus.Size = New System.Drawing.Size(146, 25)
        Me.cbAccountStatus.TabIndex = 44
        Me.cbAccountStatus.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbAccountStatus.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(361, 130)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel4.TabIndex = 39
        Me.MetroLabel4.Text = "Last Name:"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Location = New System.Drawing.Point(361, 189)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(101, 25)
        Me.MetroLabel6.TabIndex = 43
        Me.MetroLabel6.Text = "Account Status:"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tbLastName
        '
        Me.tbLastName.Lines = New String(-1) {}
        Me.tbLastName.Location = New System.Drawing.Point(361, 152)
        Me.tbLastName.MaxLength = 32767
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbLastName.SelectedText = ""
        Me.tbLastName.Size = New System.Drawing.Size(146, 23)
        Me.tbLastName.TabIndex = 40
        Me.tbLastName.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbLastName.UseSelectable = True
        '
        'cbAccountType
        '
        Me.cbAccountType.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbAccountType.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.cbAccountType.FormattingEnabled = True
        Me.cbAccountType.ItemHeight = 19
        Me.cbAccountType.Items.AddRange(New Object() {"Administrator", "User"})
        Me.cbAccountType.Location = New System.Drawing.Point(180, 211)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.Size = New System.Drawing.Size(146, 25)
        Me.cbAccountType.TabIndex = 42
        Me.cbAccountType.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbAccountType.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Location = New System.Drawing.Point(180, 189)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(90, 25)
        Me.MetroLabel5.TabIndex = 41
        Me.MetroLabel5.Text = "Account Type:"
        Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'PersonDetailView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UserPanel)
        Me.Name = "PersonDetailView"
        Me.Size = New System.Drawing.Size(554, 337)
        Me.UserPanel.ResumeLayout(False)
        Me.UserPanel.PerformLayout()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserPanel As System.Windows.Forms.Panel
    Friend WithEvents tbDoB As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pbPicture As System.Windows.Forms.PictureBox
    Friend WithEvents tbUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pbEye As System.Windows.Forms.PictureBox
    Friend WithEvents lblFirstName As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbGender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbMiddleName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbAccountStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbAccountType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel

End Class
