<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.ofdPicture = New System.Windows.Forms.OpenFileDialog()
        Me.lblEmployees = New System.Windows.Forms.Label()
        Me.lblKiosk = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblAnalytics = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblSignOut = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbAbout = New System.Windows.Forms.PictureBox()
        Me.pbEmployees = New System.Windows.Forms.PictureBox()
        Me.pbInventory = New System.Windows.Forms.PictureBox()
        Me.pbAnalytics = New System.Windows.Forms.PictureBox()
        Me.pbKiosk = New System.Windows.Forms.PictureBox()
        Me.pbCounter = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tClock = New System.Windows.Forms.Timer(Me.components)
        Me.pContainer = New System.Windows.Forms.Panel()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pbAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAnalytics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbKiosk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(297, 178)
        Me.Panel1.MinimumSize = New System.Drawing.Size(0, 470)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 470)
        Me.Panel1.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(181, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(505, 30)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name"
        '
        'lblAccountType
        '
        Me.lblAccountType.AutoSize = True
        Me.lblAccountType.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lblAccountType.Location = New System.Drawing.Point(181, 75)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(41, 21)
        Me.lblAccountType.TabIndex = 7
        Me.lblAccountType.Text = "Type"
        '
        'ofdPicture
        '
        Me.ofdPicture.FileName = "OpenFileDialog1"
        '
        'lblEmployees
        '
        Me.lblEmployees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployees.Font = New System.Drawing.Font("Segoe UI Light", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployees.Location = New System.Drawing.Point(72, 296)
        Me.lblEmployees.MaximumSize = New System.Drawing.Size(0, 200)
        Me.lblEmployees.Name = "lblEmployees"
        Me.lblEmployees.Size = New System.Drawing.Size(157, 74)
        Me.lblEmployees.TabIndex = 2
        Me.lblEmployees.Text = "Users"
        Me.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKiosk
        '
        Me.lblKiosk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKiosk.Font = New System.Drawing.Font("Segoe UI Light", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKiosk.Location = New System.Drawing.Point(72, 74)
        Me.lblKiosk.MaximumSize = New System.Drawing.Size(0, 200)
        Me.lblKiosk.Name = "lblKiosk"
        Me.lblKiosk.Size = New System.Drawing.Size(157, 74)
        Me.lblKiosk.TabIndex = 4
        Me.lblKiosk.Text = "Kiosk"
        Me.lblKiosk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInventory
        '
        Me.lblInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInventory.Font = New System.Drawing.Font("Segoe UI Light", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventory.Location = New System.Drawing.Point(72, 222)
        Me.lblInventory.MaximumSize = New System.Drawing.Size(0, 200)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(157, 74)
        Me.lblInventory.TabIndex = 12
        Me.lblInventory.Text = "Inventory"
        Me.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCounter
        '
        Me.lblCounter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCounter.Font = New System.Drawing.Font("Segoe UI Light", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblCounter.Location = New System.Drawing.Point(72, 0)
        Me.lblCounter.MaximumSize = New System.Drawing.Size(0, 200)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(157, 74)
        Me.lblCounter.TabIndex = 1
        Me.lblCounter.Text = "Counter"
        Me.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnalytics
        '
        Me.lblAnalytics.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnalytics.Font = New System.Drawing.Font("Segoe UI Light", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnalytics.Location = New System.Drawing.Point(72, 148)
        Me.lblAnalytics.MaximumSize = New System.Drawing.Size(0, 200)
        Me.lblAnalytics.Name = "lblAnalytics"
        Me.lblAnalytics.Size = New System.Drawing.Size(157, 74)
        Me.lblAnalytics.TabIndex = 13
        Me.lblAnalytics.Text = "Analytics"
        Me.lblAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAbout
        '
        Me.lblAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAbout.Font = New System.Drawing.Font("Segoe UI Light", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(72, 370)
        Me.lblAbout.MaximumSize = New System.Drawing.Size(0, 200)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(157, 80)
        Me.lblAbout.TabIndex = 14
        Me.lblAbout.Text = "About"
        Me.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSignOut
        '
        Me.lblSignOut.AutoSize = True
        Me.lblSignOut.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Underline)
        Me.lblSignOut.Location = New System.Drawing.Point(181, 120)
        Me.lblSignOut.Name = "lblSignOut"
        Me.lblSignOut.Size = New System.Drawing.Size(69, 21)
        Me.lblSignOut.TabIndex = 15
        Me.lblSignOut.Text = "Sign Out"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pbAbout, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.pbEmployees, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.pbInventory, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.pbAnalytics, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.pbKiosk, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pbCounter, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAbout, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAnalytics, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCounter, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmployees, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKiosk, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInventory, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(47, 175)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(0, 450)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(232, 450)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'pbAbout
        '
        Me.pbAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbAbout.Image = Global.Spike.My.Resources.Resources.about
        Me.pbAbout.Location = New System.Drawing.Point(3, 373)
        Me.pbAbout.Name = "pbAbout"
        Me.pbAbout.Padding = New System.Windows.Forms.Padding(15)
        Me.pbAbout.Size = New System.Drawing.Size(63, 74)
        Me.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbAbout.TabIndex = 24
        Me.pbAbout.TabStop = False
        '
        'pbEmployees
        '
        Me.pbEmployees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbEmployees.Image = Global.Spike.My.Resources.Resources.employees
        Me.pbEmployees.Location = New System.Drawing.Point(3, 299)
        Me.pbEmployees.Name = "pbEmployees"
        Me.pbEmployees.Padding = New System.Windows.Forms.Padding(15)
        Me.pbEmployees.Size = New System.Drawing.Size(63, 68)
        Me.pbEmployees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbEmployees.TabIndex = 23
        Me.pbEmployees.TabStop = False
        '
        'pbInventory
        '
        Me.pbInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbInventory.Image = Global.Spike.My.Resources.Resources.inventory
        Me.pbInventory.Location = New System.Drawing.Point(3, 225)
        Me.pbInventory.Name = "pbInventory"
        Me.pbInventory.Padding = New System.Windows.Forms.Padding(15)
        Me.pbInventory.Size = New System.Drawing.Size(63, 68)
        Me.pbInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbInventory.TabIndex = 22
        Me.pbInventory.TabStop = False
        '
        'pbAnalytics
        '
        Me.pbAnalytics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbAnalytics.Image = Global.Spike.My.Resources.Resources.analytics
        Me.pbAnalytics.Location = New System.Drawing.Point(3, 151)
        Me.pbAnalytics.Name = "pbAnalytics"
        Me.pbAnalytics.Padding = New System.Windows.Forms.Padding(15)
        Me.pbAnalytics.Size = New System.Drawing.Size(63, 68)
        Me.pbAnalytics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbAnalytics.TabIndex = 21
        Me.pbAnalytics.TabStop = False
        '
        'pbKiosk
        '
        Me.pbKiosk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbKiosk.Image = Global.Spike.My.Resources.Resources.kiosk
        Me.pbKiosk.Location = New System.Drawing.Point(3, 77)
        Me.pbKiosk.Name = "pbKiosk"
        Me.pbKiosk.Padding = New System.Windows.Forms.Padding(15)
        Me.pbKiosk.Size = New System.Drawing.Size(63, 68)
        Me.pbKiosk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbKiosk.TabIndex = 20
        Me.pbKiosk.TabStop = False
        '
        'pbCounter
        '
        Me.pbCounter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCounter.Image = Global.Spike.My.Resources.Resources.counter
        Me.pbCounter.Location = New System.Drawing.Point(3, 3)
        Me.pbCounter.Name = "pbCounter"
        Me.pbCounter.Padding = New System.Windows.Forms.Padding(15)
        Me.pbCounter.Size = New System.Drawing.Size(63, 68)
        Me.pbCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbCounter.TabIndex = 19
        Me.pbCounter.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(556, 75)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(284, 41)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "12/12/2014"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(684, 45)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(156, 30)
        Me.lblTime.TabIndex = 18
        Me.lblTime.Text = "9:04 AM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tClock
        '
        '
        'pContainer
        '
        Me.pContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.pContainer.Location = New System.Drawing.Point(323, 178)
        Me.pContainer.MinimumSize = New System.Drawing.Size(0, 450)
        Me.pContainer.Name = "pContainer"
        Me.pContainer.Size = New System.Drawing.Size(517, 450)
        Me.pContainer.TabIndex = 19
        '
        'pbUser
        '
        Me.pbUser.Location = New System.Drawing.Point(47, 45)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(100, 96)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUser.TabIndex = 5
        Me.pbUser.TabStop = False
        '
        'lblEdit
        '
        Me.lblEdit.BackColor = System.Drawing.Color.Transparent
        Me.lblEdit.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.White
        Me.lblEdit.Location = New System.Drawing.Point(50, 144)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(97, 13)
        Me.lblEdit.TabIndex = 20
        Me.lblEdit.Text = "Edit"
        Me.lblEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 668)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.pContainer)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblSignOut)
        Me.Controls.Add(Me.lblAccountType)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbUser)
        Me.Controls.Add(Me.Panel1)
        Me.DisplayHeader = False
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmAdmin"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Text = "Spike"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pbAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAnalytics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbKiosk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAccountType As System.Windows.Forms.Label
    Friend WithEvents ofdPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblEmployees As System.Windows.Forms.Label
    Friend WithEvents lblKiosk As System.Windows.Forms.Label
    Friend WithEvents lblInventory As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents lblAnalytics As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents lblSignOut As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tClock As System.Windows.Forms.Timer
    Friend WithEvents pbCounter As System.Windows.Forms.PictureBox
    Friend WithEvents pbAbout As System.Windows.Forms.PictureBox
    Friend WithEvents pbEmployees As System.Windows.Forms.PictureBox
    Friend WithEvents pbInventory As System.Windows.Forms.PictureBox
    Friend WithEvents pbAnalytics As System.Windows.Forms.PictureBox
    Friend WithEvents pbKiosk As System.Windows.Forms.PictureBox
    Friend WithEvents pContainer As System.Windows.Forms.Panel
    Friend WithEvents lblEdit As System.Windows.Forms.Label
End Class
