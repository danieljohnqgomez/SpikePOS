<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemDetailView
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
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.pbKiosk = New System.Windows.Forms.PictureBox()
        Me.tbName = New MetroFramework.Controls.MetroTextBox()
        Me.lblName = New MetroFramework.Controls.MetroLabel()
        Me.lblDescription = New MetroFramework.Controls.MetroLabel()
        Me.lblRDesc = New MetroFramework.Controls.MetroLabel()
        Me.lblCategory = New MetroFramework.Controls.MetroLabel()
        Me.lblStocks = New MetroFramework.Controls.MetroLabel()
        Me.lblPrice = New MetroFramework.Controls.MetroLabel()
        Me.tbDescription = New MetroFramework.Controls.MetroTextBox()
        Me.tbRDesc = New MetroFramework.Controls.MetroTextBox()
        Me.nStocks = New System.Windows.Forms.NumericUpDown()
        Me.nPrice = New System.Windows.Forms.NumericUpDown()
        Me.cbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbKiosk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbImage
        '
        Me.pbImage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Image = Global.Spike.My.Resources.Resources.question
        Me.pbImage.Location = New System.Drawing.Point(98, 317)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(115, 104)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'pbKiosk
        '
        Me.pbKiosk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbKiosk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbKiosk.Image = Global.Spike.My.Resources.Resources.questioncanvass
        Me.pbKiosk.Location = New System.Drawing.Point(54, 28)
        Me.pbKiosk.Name = "pbKiosk"
        Me.pbKiosk.Size = New System.Drawing.Size(494, 228)
        Me.pbKiosk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbKiosk.TabIndex = 1
        Me.pbKiosk.TabStop = False
        '
        'tbName
        '
        Me.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbName.Lines = New String(-1) {}
        Me.tbName.Location = New System.Drawing.Point(357, 278)
        Me.tbName.MaxLength = 32767
        Me.tbName.Name = "tbName"
        Me.tbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbName.SelectedText = ""
        Me.tbName.Size = New System.Drawing.Size(191, 23)
        Me.tbName.TabIndex = 32
        Me.tbName.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbName.UseSelectable = True
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(272, 282)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 19)
        Me.lblName.TabIndex = 34
        Me.lblName.Text = "Name:"
        Me.lblName.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(272, 310)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(77, 19)
        Me.lblDescription.TabIndex = 35
        Me.lblDescription.Text = "Description:"
        Me.lblDescription.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblRDesc
        '
        Me.lblRDesc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblRDesc.AutoSize = True
        Me.lblRDesc.Location = New System.Drawing.Point(272, 371)
        Me.lblRDesc.Name = "lblRDesc"
        Me.lblRDesc.Size = New System.Drawing.Size(124, 19)
        Me.lblRDesc.TabIndex = 36
        Me.lblRDesc.Text = "Receipt Description:"
        Me.lblRDesc.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(272, 402)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(67, 19)
        Me.lblCategory.TabIndex = 37
        Me.lblCategory.Text = "Category:"
        Me.lblCategory.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblStocks
        '
        Me.lblStocks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStocks.AutoSize = True
        Me.lblStocks.Location = New System.Drawing.Point(272, 432)
        Me.lblStocks.Name = "lblStocks"
        Me.lblStocks.Size = New System.Drawing.Size(48, 19)
        Me.lblStocks.TabIndex = 38
        Me.lblStocks.Text = "Stocks:"
        Me.lblStocks.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(272, 462)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(41, 19)
        Me.lblPrice.TabIndex = 39
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tbDescription
        '
        Me.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbDescription.Lines = New String(-1) {}
        Me.tbDescription.Location = New System.Drawing.Point(357, 306)
        Me.tbDescription.MaxLength = 32767
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDescription.SelectedText = ""
        Me.tbDescription.Size = New System.Drawing.Size(191, 55)
        Me.tbDescription.TabIndex = 40
        Me.tbDescription.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbDescription.UseSelectable = True
        '
        'tbRDesc
        '
        Me.tbRDesc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbRDesc.Lines = New String(-1) {}
        Me.tbRDesc.Location = New System.Drawing.Point(402, 367)
        Me.tbRDesc.MaxLength = 10
        Me.tbRDesc.Name = "tbRDesc"
        Me.tbRDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbRDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbRDesc.SelectedText = ""
        Me.tbRDesc.Size = New System.Drawing.Size(146, 23)
        Me.tbRDesc.TabIndex = 41
        Me.tbRDesc.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbRDesc.UseSelectable = True
        '
        'nStocks
        '
        Me.nStocks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nStocks.Location = New System.Drawing.Point(336, 432)
        Me.nStocks.Name = "nStocks"
        Me.nStocks.Size = New System.Drawing.Size(212, 20)
        Me.nStocks.TabIndex = 42
        '
        'nPrice
        '
        Me.nPrice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nPrice.DecimalPlaces = 2
        Me.nPrice.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nPrice.Location = New System.Drawing.Point(336, 461)
        Me.nPrice.Name = "nPrice"
        Me.nPrice.Size = New System.Drawing.Size(212, 20)
        Me.nPrice.TabIndex = 43
        Me.nPrice.ThousandsSeparator = True
        '
        'cbCategory
        '
        Me.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbCategory.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbCategory.FontWeight = MetroFramework.MetroComboBoxWeight.Light
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.ItemHeight = 19
        Me.cbCategory.Items.AddRange(New Object() {"Meal", "Pasta", "Burger", "Drinks", "Dessert"})
        Me.cbCategory.Location = New System.Drawing.Point(345, 396)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(203, 25)
        Me.cbCategory.TabIndex = 44
        Me.cbCategory.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbCategory.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbKiosk)
        Me.Panel1.Controls.Add(Me.cbCategory)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Controls.Add(Me.tbRDesc)
        Me.Panel1.Controls.Add(Me.pbImage)
        Me.Panel1.Controls.Add(Me.tbDescription)
        Me.Panel1.Controls.Add(Me.lblStocks)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.nPrice)
        Me.Panel1.Controls.Add(Me.lblRDesc)
        Me.Panel1.Controls.Add(Me.lblCategory)
        Me.Panel1.Controls.Add(Me.nStocks)
        Me.Panel1.Controls.Add(Me.tbName)
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 497)
        Me.Panel1.TabIndex = 45
        '
        'ItemDetailView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ItemDetailView"
        Me.Size = New System.Drawing.Size(591, 497)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbKiosk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents pbKiosk As System.Windows.Forms.PictureBox
    Friend WithEvents tbName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDescription As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblRDesc As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCategory As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblStocks As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPrice As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbRDesc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents nStocks As System.Windows.Forms.NumericUpDown
    Friend WithEvents nPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
