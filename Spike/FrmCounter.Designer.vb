<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCounter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCounter))
        Me.ItemImages = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.tipTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabAll = New MetroFramework.Controls.MetroTabPage()
        Me.AllHost = New System.Windows.Forms.Integration.ElementHost()
        Me.tablMeal = New MetroFramework.Controls.MetroTabPage()
        Me.MealHost = New System.Windows.Forms.Integration.ElementHost()
        Me.tabPasta = New MetroFramework.Controls.MetroTabPage()
        Me.PastaHost = New System.Windows.Forms.Integration.ElementHost()
        Me.tabBurger = New MetroFramework.Controls.MetroTabPage()
        Me.BurgerHost = New System.Windows.Forms.Integration.ElementHost()
        Me.tabDrinks = New MetroFramework.Controls.MetroTabPage()
        Me.DrinksHost = New System.Windows.Forms.Integration.ElementHost()
        Me.tabDessert = New MetroFramework.Controls.MetroTabPage()
        Me.DessertHost = New System.Windows.Forms.Integration.ElementHost()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReceiptHost = New System.Windows.Forms.Integration.ElementHost()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCustomerNo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.btnCheckout = New MetroFramework.Controls.MetroButton()
        Me.btnDecrease = New MetroFramework.Controls.MetroButton()
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabAll.SuspendLayout()
        Me.tablMeal.SuspendLayout()
        Me.tabPasta.SuspendLayout()
        Me.tabBurger.SuspendLayout()
        Me.tabDrinks.SuspendLayout()
        Me.tabDessert.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.nQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemImages
        '
        Me.ItemImages.ImageStream = CType(resources.GetObject("ItemImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ItemImages.TransparentColor = System.Drawing.Color.Transparent
        Me.ItemImages.Images.SetKeyName(0, "about.png")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(448, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 37)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Receipt"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(173, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Qty:"
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.ForeColor = System.Drawing.Color.White
        Me.lblTip.Location = New System.Drawing.Point(23, 372)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(261, 13)
        Me.lblTip.TabIndex = 34
        Me.lblTip.Text = "Tip: You can quickly add an item by double clicking it."
        '
        'tipTimer
        '
        Me.tipTimer.Enabled = True
        Me.tipTimer.Interval = 10000
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.tabAll)
        Me.MetroTabControl1.Controls.Add(Me.tablMeal)
        Me.MetroTabControl1.Controls.Add(Me.tabPasta)
        Me.MetroTabControl1.Controls.Add(Me.tabBurger)
        Me.MetroTabControl1.Controls.Add(Me.tabDrinks)
        Me.MetroTabControl1.Controls.Add(Me.tabDessert)
        Me.MetroTabControl1.Location = New System.Drawing.Point(22, 29)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(357, 374)
        Me.MetroTabControl1.TabIndex = 37
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.AllHost)
        Me.tabAll.HorizontalScrollbarBarColor = True
        Me.tabAll.HorizontalScrollbarHighlightOnWheel = False
        Me.tabAll.HorizontalScrollbarSize = 10
        Me.tabAll.Location = New System.Drawing.Point(4, 38)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Size = New System.Drawing.Size(349, 332)
        Me.tabAll.TabIndex = 0
        Me.tabAll.Text = "All"
        Me.tabAll.VerticalScrollbarBarColor = True
        Me.tabAll.VerticalScrollbarHighlightOnWheel = False
        Me.tabAll.VerticalScrollbarSize = 10
        '
        'AllHost
        '
        Me.AllHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.AllHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AllHost.Location = New System.Drawing.Point(0, 0)
        Me.AllHost.Name = "AllHost"
        Me.AllHost.Size = New System.Drawing.Size(349, 332)
        Me.AllHost.TabIndex = 2
        Me.AllHost.Text = "ElementHost1"
        Me.AllHost.Child = Nothing
        '
        'tablMeal
        '
        Me.tablMeal.Controls.Add(Me.MealHost)
        Me.tablMeal.HorizontalScrollbarBarColor = True
        Me.tablMeal.HorizontalScrollbarHighlightOnWheel = False
        Me.tablMeal.HorizontalScrollbarSize = 10
        Me.tablMeal.Location = New System.Drawing.Point(4, 38)
        Me.tablMeal.Name = "tablMeal"
        Me.tablMeal.Size = New System.Drawing.Size(349, 332)
        Me.tablMeal.TabIndex = 1
        Me.tablMeal.Text = "Meal"
        Me.tablMeal.VerticalScrollbarBarColor = True
        Me.tablMeal.VerticalScrollbarHighlightOnWheel = False
        Me.tablMeal.VerticalScrollbarSize = 10
        '
        'MealHost
        '
        Me.MealHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.MealHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MealHost.Location = New System.Drawing.Point(0, 0)
        Me.MealHost.Name = "MealHost"
        Me.MealHost.Size = New System.Drawing.Size(349, 332)
        Me.MealHost.TabIndex = 38
        Me.MealHost.Text = "ElementHost1"
        Me.MealHost.Child = Nothing
        '
        'tabPasta
        '
        Me.tabPasta.Controls.Add(Me.PastaHost)
        Me.tabPasta.HorizontalScrollbarBarColor = True
        Me.tabPasta.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPasta.HorizontalScrollbarSize = 10
        Me.tabPasta.Location = New System.Drawing.Point(4, 38)
        Me.tabPasta.Name = "tabPasta"
        Me.tabPasta.Size = New System.Drawing.Size(349, 332)
        Me.tabPasta.TabIndex = 2
        Me.tabPasta.Text = "Pasta"
        Me.tabPasta.VerticalScrollbarBarColor = True
        Me.tabPasta.VerticalScrollbarHighlightOnWheel = False
        Me.tabPasta.VerticalScrollbarSize = 10
        '
        'PastaHost
        '
        Me.PastaHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PastaHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PastaHost.Location = New System.Drawing.Point(0, 0)
        Me.PastaHost.Name = "PastaHost"
        Me.PastaHost.Size = New System.Drawing.Size(349, 332)
        Me.PastaHost.TabIndex = 39
        Me.PastaHost.Text = "ElementHost2"
        Me.PastaHost.Child = Nothing
        '
        'tabBurger
        '
        Me.tabBurger.Controls.Add(Me.BurgerHost)
        Me.tabBurger.HorizontalScrollbarBarColor = True
        Me.tabBurger.HorizontalScrollbarHighlightOnWheel = False
        Me.tabBurger.HorizontalScrollbarSize = 10
        Me.tabBurger.Location = New System.Drawing.Point(4, 38)
        Me.tabBurger.Name = "tabBurger"
        Me.tabBurger.Size = New System.Drawing.Size(349, 332)
        Me.tabBurger.TabIndex = 3
        Me.tabBurger.Text = "Burger"
        Me.tabBurger.VerticalScrollbarBarColor = True
        Me.tabBurger.VerticalScrollbarHighlightOnWheel = False
        Me.tabBurger.VerticalScrollbarSize = 10
        '
        'BurgerHost
        '
        Me.BurgerHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.BurgerHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BurgerHost.Location = New System.Drawing.Point(0, 0)
        Me.BurgerHost.Name = "BurgerHost"
        Me.BurgerHost.Size = New System.Drawing.Size(349, 332)
        Me.BurgerHost.TabIndex = 41
        Me.BurgerHost.Text = "ElementHost2"
        Me.BurgerHost.Child = Nothing
        '
        'tabDrinks
        '
        Me.tabDrinks.Controls.Add(Me.DrinksHost)
        Me.tabDrinks.HorizontalScrollbarBarColor = True
        Me.tabDrinks.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDrinks.HorizontalScrollbarSize = 10
        Me.tabDrinks.Location = New System.Drawing.Point(4, 38)
        Me.tabDrinks.Name = "tabDrinks"
        Me.tabDrinks.Size = New System.Drawing.Size(349, 332)
        Me.tabDrinks.TabIndex = 4
        Me.tabDrinks.Text = "Drinks"
        Me.tabDrinks.VerticalScrollbarBarColor = True
        Me.tabDrinks.VerticalScrollbarHighlightOnWheel = False
        Me.tabDrinks.VerticalScrollbarSize = 10
        '
        'DrinksHost
        '
        Me.DrinksHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.DrinksHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DrinksHost.Location = New System.Drawing.Point(0, 0)
        Me.DrinksHost.Name = "DrinksHost"
        Me.DrinksHost.Size = New System.Drawing.Size(349, 332)
        Me.DrinksHost.TabIndex = 40
        Me.DrinksHost.Text = "ElementHost1"
        Me.DrinksHost.Child = Nothing
        '
        'tabDessert
        '
        Me.tabDessert.Controls.Add(Me.DessertHost)
        Me.tabDessert.HorizontalScrollbarBarColor = True
        Me.tabDessert.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDessert.HorizontalScrollbarSize = 10
        Me.tabDessert.Location = New System.Drawing.Point(4, 38)
        Me.tabDessert.Name = "tabDessert"
        Me.tabDessert.Size = New System.Drawing.Size(349, 332)
        Me.tabDessert.TabIndex = 5
        Me.tabDessert.Text = "Dessert"
        Me.tabDessert.VerticalScrollbarBarColor = True
        Me.tabDessert.VerticalScrollbarHighlightOnWheel = False
        Me.tabDessert.VerticalScrollbarSize = 10
        '
        'DessertHost
        '
        Me.DessertHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.DessertHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DessertHost.Location = New System.Drawing.Point(0, 0)
        Me.DessertHost.Name = "DessertHost"
        Me.DessertHost.Size = New System.Drawing.Size(349, 332)
        Me.DessertHost.TabIndex = 41
        Me.DessertHost.Text = "ElementHost1"
        Me.DessertHost.Child = Nothing
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Dot Matrix", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(326, 30)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "FOOD EXPRESS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.Spike.My.Resources.Resources.paper
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.ReceiptHost)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblCustomerNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Font = New System.Drawing.Font("Dot Matrix", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(448, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 331)
        Me.Panel1.TabIndex = 40
        '
        'ReceiptHost
        '
        Me.ReceiptHost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReceiptHost.BackColor = System.Drawing.Color.Transparent
        Me.ReceiptHost.Location = New System.Drawing.Point(37, 173)
        Me.ReceiptHost.Name = "ReceiptHost"
        Me.ReceiptHost.Size = New System.Drawing.Size(268, 69)
        Me.ReceiptHost.TabIndex = 48
        Me.ReceiptHost.Text = "ElementHost1"
        Me.ReceiptHost.Child = Nothing
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(187, 251)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(120, 21)
        Me.lblTotal.TabIndex = 47
        Me.lblTotal.Text = "TOTAL: "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Dot Matrix", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(35, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(280, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "__________________________________"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Dot Matrix", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(34, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(272, 16)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "_________________________________"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCustomerNo
        '
        Me.lblCustomerNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustomerNo.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerNo.Font = New System.Drawing.Font("Dot Matrix", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerNo.ForeColor = System.Drawing.Color.Black
        Me.lblCustomerNo.Location = New System.Drawing.Point(42, 118)
        Me.lblCustomerNo.Name = "lblCustomerNo"
        Me.lblCustomerNo.Size = New System.Drawing.Size(290, 30)
        Me.lblCustomerNo.TabIndex = 44
        Me.lblCustomerNo.Text = "CUSTOMER NO: "
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Dot Matrix", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(37, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(268, 30)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "STORE MGR/DIR. : DANIEL GOMEZ"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Dot Matrix", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 30)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "1-800-274-578"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dot Matrix", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(323, 12)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "WHERE AMAZING FOODS ARE MADE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nQuantity
        '
        Me.nQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nQuantity.Location = New System.Drawing.Point(218, 412)
        Me.nQuantity.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nQuantity.Name = "nQuantity"
        Me.nQuantity.Size = New System.Drawing.Size(66, 20)
        Me.nQuantity.TabIndex = 42
        Me.nQuantity.ThousandsSeparator = True
        Me.nQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(300, 412)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 43
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAdd.UseSelectable = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCheckout.Location = New System.Drawing.Point(716, 415)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckout.TabIndex = 44
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCheckout.UseSelectable = True
        '
        'btnDecrease
        '
        Me.btnDecrease.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDecrease.Location = New System.Drawing.Point(635, 415)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrease.TabIndex = 45
        Me.btnDecrease.Text = "Decrease"
        Me.btnDecrease.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnDecrease.UseSelectable = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(554, 415)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnDelete.UseSelectable = True
        '
        'FrmCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(823, 486)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.nQuantity)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCounter"
        Me.Text = "FrmCounter"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabAll.ResumeLayout(False)
        Me.tablMeal.ResumeLayout(False)
        Me.tabPasta.ResumeLayout(False)
        Me.tabBurger.ResumeLayout(False)
        Me.tabDrinks.ResumeLayout(False)
        Me.tabDessert.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemImages As System.Windows.Forms.ImageList
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents tipTimer As System.Windows.Forms.Timer
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabAll As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tablMeal As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabPasta As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabBurger As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabDrinks As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabDessert As MetroFramework.Controls.MetroTabPage
    Friend WithEvents AllHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents MealHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents PastaHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents BurgerHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents DrinksHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents DessertHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCustomerNo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ReceiptHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents nQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCheckout As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDecrease As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
End Class
