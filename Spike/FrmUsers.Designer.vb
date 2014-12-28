<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsers
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
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.tpAll = New MetroFramework.Controls.MetroTabPage()
        Me.elementHostAll = New System.Windows.Forms.Integration.ElementHost()
        Me.tpAdmins = New MetroFramework.Controls.MetroTabPage()
        Me.elementHostAdmin = New System.Windows.Forms.Integration.ElementHost()
        Me.tpUsers = New MetroFramework.Controls.MetroTabPage()
        Me.elementHostUser = New System.Windows.Forms.Integration.ElementHost()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.btnDone = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.PersonDetailView1 = New Spike.PersonDetailView()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.MetroTabControl2.SuspendLayout()
        Me.tpAll.SuspendLayout()
        Me.tpAdmins.SuspendLayout()
        Me.tpUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Controls.Add(Me.tpAll)
        Me.MetroTabControl2.Controls.Add(Me.tpAdmins)
        Me.MetroTabControl2.Controls.Add(Me.tpUsers)
        Me.MetroTabControl2.Location = New System.Drawing.Point(621, 1)
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(351, 365)
        Me.MetroTabControl2.TabIndex = 1
        Me.MetroTabControl2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl2.UseSelectable = True
        '
        'tpAll
        '
        Me.tpAll.Controls.Add(Me.elementHostAll)
        Me.tpAll.HorizontalScrollbarBarColor = True
        Me.tpAll.HorizontalScrollbarHighlightOnWheel = False
        Me.tpAll.HorizontalScrollbarSize = 10
        Me.tpAll.Location = New System.Drawing.Point(4, 38)
        Me.tpAll.Name = "tpAll"
        Me.tpAll.Size = New System.Drawing.Size(343, 323)
        Me.tpAll.TabIndex = 0
        Me.tpAll.Text = "All"
        Me.tpAll.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tpAll.VerticalScrollbarBarColor = True
        Me.tpAll.VerticalScrollbarHighlightOnWheel = False
        Me.tpAll.VerticalScrollbarSize = 10
        '
        'elementHostAll
        '
        Me.elementHostAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.elementHostAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.elementHostAll.Location = New System.Drawing.Point(0, 0)
        Me.elementHostAll.Name = "elementHostAll"
        Me.elementHostAll.Size = New System.Drawing.Size(343, 323)
        Me.elementHostAll.TabIndex = 27
        Me.elementHostAll.Text = "ElementHost1"
        Me.elementHostAll.Child = Nothing
        '
        'tpAdmins
        '
        Me.tpAdmins.Controls.Add(Me.elementHostAdmin)
        Me.tpAdmins.HorizontalScrollbarBarColor = True
        Me.tpAdmins.HorizontalScrollbarHighlightOnWheel = False
        Me.tpAdmins.HorizontalScrollbarSize = 10
        Me.tpAdmins.Location = New System.Drawing.Point(4, 38)
        Me.tpAdmins.Name = "tpAdmins"
        Me.tpAdmins.Size = New System.Drawing.Size(343, 323)
        Me.tpAdmins.TabIndex = 1
        Me.tpAdmins.Text = "Administrators"
        Me.tpAdmins.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tpAdmins.VerticalScrollbarBarColor = True
        Me.tpAdmins.VerticalScrollbarHighlightOnWheel = False
        Me.tpAdmins.VerticalScrollbarSize = 10
        '
        'elementHostAdmin
        '
        Me.elementHostAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.elementHostAdmin.Location = New System.Drawing.Point(0, 0)
        Me.elementHostAdmin.Name = "elementHostAdmin"
        Me.elementHostAdmin.Size = New System.Drawing.Size(343, 323)
        Me.elementHostAdmin.TabIndex = 2
        Me.elementHostAdmin.Text = "ElementHost1"
        Me.elementHostAdmin.Child = Nothing
        '
        'tpUsers
        '
        Me.tpUsers.Controls.Add(Me.elementHostUser)
        Me.tpUsers.ForeColor = System.Drawing.Color.White
        Me.tpUsers.HorizontalScrollbarBarColor = True
        Me.tpUsers.HorizontalScrollbarHighlightOnWheel = False
        Me.tpUsers.HorizontalScrollbarSize = 10
        Me.tpUsers.Location = New System.Drawing.Point(4, 38)
        Me.tpUsers.Name = "tpUsers"
        Me.tpUsers.Size = New System.Drawing.Size(343, 323)
        Me.tpUsers.TabIndex = 2
        Me.tpUsers.Text = "Users"
        Me.tpUsers.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tpUsers.UseCustomForeColor = True
        Me.tpUsers.VerticalScrollbarBarColor = True
        Me.tpUsers.VerticalScrollbarHighlightOnWheel = False
        Me.tpUsers.VerticalScrollbarSize = 10
        '
        'elementHostUser
        '
        Me.elementHostUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.elementHostUser.Location = New System.Drawing.Point(0, 0)
        Me.elementHostUser.Name = "elementHostUser"
        Me.elementHostUser.Size = New System.Drawing.Size(343, 323)
        Me.elementHostUser.TabIndex = 2
        Me.elementHostUser.Text = "ElementHost1"
        Me.elementHostUser.Child = Nothing
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(879, 373)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 26)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add User"
        Me.btnAdd.UseSelectable = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(346, 373)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(89, 26)
        Me.btnDone.TabIndex = 25
        Me.btnDone.Text = "Done"
        Me.btnDone.UseSelectable = True
        Me.btnDone.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(458, 373)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 26)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        Me.btnCancel.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(784, 373)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(89, 26)
        Me.btnEdit.TabIndex = 27
        Me.btnEdit.Text = "Edit User"
        Me.btnEdit.UseSelectable = True
        Me.btnEdit.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(689, 373)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 26)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete User"
        Me.btnDelete.UseSelectable = True
        Me.btnDelete.Visible = False
        '
        'PersonDetailView1
        '
        Me.PersonDetailView1.Location = New System.Drawing.Point(34, 40)
        Me.PersonDetailView1.Name = "PersonDetailView1"
        Me.PersonDetailView1.Size = New System.Drawing.Size(513, 337)
        Me.PersonDetailView1.TabIndex = 0
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1054, 463)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.PersonDetailView1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MetroTabControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsers"
        Me.Text = "FrmUsers"
        Me.MetroTabControl2.ResumeLayout(False)
        Me.tpAll.ResumeLayout(False)
        Me.tpAdmins.ResumeLayout(False)
        Me.tpUsers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tpAll As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tpAdmins As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tpUsers As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents PersonDetailView1 As Spike.PersonDetailView
    Friend WithEvents btnDone As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents elementHostAll As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents elementHostAdmin As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents elementHostUser As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog
End Class
