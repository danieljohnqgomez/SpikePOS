<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventory))
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
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnDone = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.ItemDetailView1 = New Spike.ItemDetailView()
        Me.ofdKiosk = New System.Windows.Forms.OpenFileDialog()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabAll.SuspendLayout()
        Me.tablMeal.SuspendLayout()
        Me.tabPasta.SuspendLayout()
        Me.tabBurger.SuspendLayout()
        Me.tabDrinks.SuspendLayout()
        Me.tabDessert.SuspendLayout()
        Me.SuspendLayout()
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
        Me.MetroTabControl1.Location = New System.Drawing.Point(669, 24)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(357, 489)
        Me.MetroTabControl1.TabIndex = 38
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
        Me.tabAll.Size = New System.Drawing.Size(349, 447)
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
        Me.AllHost.Size = New System.Drawing.Size(349, 447)
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
        Me.tablMeal.Size = New System.Drawing.Size(349, 447)
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
        Me.MealHost.Size = New System.Drawing.Size(349, 447)
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
        Me.tabPasta.Size = New System.Drawing.Size(349, 447)
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
        Me.PastaHost.Size = New System.Drawing.Size(349, 447)
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
        Me.tabBurger.Size = New System.Drawing.Size(349, 447)
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
        Me.BurgerHost.Size = New System.Drawing.Size(349, 447)
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
        Me.tabDrinks.Size = New System.Drawing.Size(349, 447)
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
        Me.DrinksHost.Size = New System.Drawing.Size(349, 447)
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
        Me.tabDessert.Size = New System.Drawing.Size(349, 447)
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
        Me.DessertHost.Size = New System.Drawing.Size(349, 447)
        Me.DessertHost.TabIndex = 41
        Me.DessertHost.Text = "ElementHost1"
        Me.DessertHost.Child = Nothing
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(747, 519)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 26)
        Me.btnDelete.TabIndex = 44
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseSelectable = True
        Me.btnDelete.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(842, 519)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(89, 26)
        Me.btnEdit.TabIndex = 43
        Me.btnEdit.Text = "Edit Item"
        Me.btnEdit.UseSelectable = True
        Me.btnEdit.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(472, 520)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 26)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        Me.btnCancel.Visible = False
        '
        'btnDone
        '
        Me.btnDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDone.Location = New System.Drawing.Point(361, 520)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(89, 26)
        Me.btnDone.TabIndex = 41
        Me.btnDone.Text = "Done"
        Me.btnDone.UseSelectable = True
        Me.btnDone.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(937, 519)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 26)
        Me.btnAdd.TabIndex = 40
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseSelectable = True
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "OpenFileDialog1"
        '
        'ItemDetailView1
        '
        Me.ItemDetailView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ItemDetailView1.BackColor = System.Drawing.Color.Transparent
        Me.ItemDetailView1.Category = ""
        Me.ItemDetailView1.Description = ""
        Me.ItemDetailView1.Image = CType(resources.GetObject("ItemDetailView1.Image"), System.Drawing.Image)
        Me.ItemDetailView1.Kiosk = CType(resources.GetObject("ItemDetailView1.Kiosk"), System.Drawing.Image)
        Me.ItemDetailView1.Location = New System.Drawing.Point(12, 12)
        Me.ItemDetailView1.Name = "ItemDetailView1"
        Me.ItemDetailView1.Price = 0.0R
        Me.ItemDetailView1.RDescription = ""
        Me.ItemDetailView1.Size = New System.Drawing.Size(593, 501)
        Me.ItemDetailView1.Stocks = 0
        Me.ItemDetailView1.TabIndex = 39
        Me.ItemDetailView1.Title = ""
        '
        'ofdKiosk
        '
        Me.ofdKiosk.FileName = "OpenFileDialog1"
        '
        'FrmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1077, 575)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ItemDetailView1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInventory"
        Me.Text = "FrmInventory"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabAll.ResumeLayout(False)
        Me.tablMeal.ResumeLayout(False)
        Me.tabPasta.ResumeLayout(False)
        Me.tabBurger.ResumeLayout(False)
        Me.tabDrinks.ResumeLayout(False)
        Me.tabDessert.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabAll As MetroFramework.Controls.MetroTabPage
    Friend WithEvents AllHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents tablMeal As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MealHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents tabPasta As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PastaHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents tabBurger As MetroFramework.Controls.MetroTabPage
    Friend WithEvents BurgerHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents tabDrinks As MetroFramework.Controls.MetroTabPage
    Friend WithEvents DrinksHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents tabDessert As MetroFramework.Controls.MetroTabPage
    Friend WithEvents DessertHost As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents ItemDetailView1 As Spike.ItemDetailView
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDone As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdKiosk As System.Windows.Forms.OpenFileDialog
End Class
