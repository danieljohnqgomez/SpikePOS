Imports System.Windows
Imports MetroFramework

Public Class FrmInventory
    Dim AllListBox As ItemListBox
    Dim MealListBox As ItemListBox
    Dim PastaListBox As ItemListBox
    Dim BurgerListBox As ItemListBox
    Dim DrinksListBox As ItemListBox
    Dim DessertListBox As ItemListBox

    Dim itemList As List(Of Item)
    Dim mealList As List(Of Item)
    Dim pastaList As List(Of Item)
    Dim burgerlist As List(Of Item)
    Dim drinkslist As List(Of Item)
    Dim dessertlist As List(Of Item)

    Dim currentOperation As Integer = -1

    Const ADD_OPERATION = 0
    Const EDIT_OPERATION = 1

    Dim mParent As Form

    'Used to fix MetroFramework design bug
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const FIXED = 0

    Private Sub FixMetroFrameworkBug(listControl As ItemListBox)
        If listControl.Tag Is Nothing Then
            Dim originalPosition As System.Drawing.Point = Cursor.Position
            Cursor.Position = New System.Drawing.Point(1000, 243)
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                        Cursor.Position = originalPosition
                        listControl.Tag = FIXED
        End If

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddOperation()
        ItemDetailView1.setItem(New Item())
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Try
            If ValidateInputs() Then
                ItemDetailView1.isEnabled(False)
                MetroTabControl1.Visible = True
                btnAdd.Visible = True
                btnDone.Visible = False
                btnCancel.Visible = False
                btnEdit.Visible = False
                btnDelete.Visible = False
                Dim item As Item = ItemDetailView1.getItem()
                If currentOperation = ADD_OPERATION Then
                    AddItem(item)
                    MetroMessageBox.Show(mParent, item.Title & " was added successfully.", "Adding Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ItemDetailView1.setItem(New Item())
                Else
                    UpdateItem(item)
                    MetroMessageBox.Show(mParent, "Item record was updated successfully.", "Updating Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                MetroTabControl1.SelectedIndex = 0
                AllListLoaded()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(mParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim item As Item = ItemDetailView1.getItem()
        Dim errorMessage As String = ""

        If String.IsNullOrWhiteSpace(item.Title) Then
            errorMessage = "Name is empty"
        ElseIf String.IsNullOrWhiteSpace(item.Description) Then
            errorMessage = "Description is empty"
        ElseIf String.IsNullOrWhiteSpace(item.ReceiptDescription) Then
            errorMessage = "Receipt Description is empty"
        ElseIf item.Price <= 0 Then
            errorMessage = "Price can't be less than or equal to 0 "
        ElseIf item.Stock < 0 Then
            errorMessage = "Stocks can't be less than 0"
        End If

        If String.IsNullOrEmpty(errorMessage) Then
            Return True
        Else
            MetroMessageBox.Show(mParent, errorMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MetroTabControl1.Visible = True
        ItemDetailView1.isEnabled(False)
        ItemDetailView1.setItem(New Item())
        btnAdd.Show()
        btnDone.Hide()
        btnCancel.Hide()
        btnEdit.Hide()
        btnDelete.Hide()
    End Sub


    Private Sub FrmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemDetailView1.setItem(New Item())
        mParent = Parent.Parent
        ItemDetailView1.isEnabled(False)

        AllListBox = New ItemListBox
        AllHost.Child = AllListBox
        AddHandler AllListBox.Loaded, AddressOf AllListLoaded
        AddHandler AllListBox.SelectionChanged, AddressOf AllListSelectionChanged

        MealListBox = New ItemListBox
        MealHost.Child = MealListBox
        AddHandler MealListBox.Loaded, AddressOf MealListLoaded
        AddHandler MealListBox.SelectionChanged, AddressOf MealListSelectionChanged

        PastaListBox = New ItemListBox
        PastaHost.Child = PastaListBox
        AddHandler PastaListBox.Loaded, AddressOf PastaListLoaded
        AddHandler PastaListBox.SelectionChanged, AddressOf PastaListSelectionChanged

        BurgerListBox = New ItemListBox
        BurgerHost.Child = BurgerListBox
        AddHandler BurgerListBox.Loaded, AddressOf BurgerListLoaded
        AddHandler BurgerListBox.SelectionChanged, AddressOf BurgerListSelectionChanged

        DrinksListBox = New ItemListBox
        DrinksHost.Child = DrinksListBox
        AddHandler DrinksListBox.Loaded, AddressOf DrinksListLoaded
        AddHandler DrinksListBox.SelectionChanged, AddressOf DrinksListSelectionChanged

        DessertListBox = New ItemListBox
        DessertHost.Child = DessertListBox
        AddHandler DessertListBox.Loaded, AddressOf DessertListLoaded
        AddHandler DessertListBox.SelectionChanged, AddressOf DessertListSelectionChanged

        AddHandler ItemDetailView1.ImageClick, AddressOf ImageClick
        AddHandler ItemDetailView1.KioskClick, AddressOf KioskClick
        FixMetroFrameworkBug(AllListBox)
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        ItemDetailView1.setItem(New Item())
        AllListBox.ClearSelection()
        MealListBox.ClearSelection()
        BurgerListBox.ClearSelection()
        PastaListBox.ClearSelection()
        DrinksListBox.ClearSelection()
        DessertListBox.ClearSelection()
        btnEdit.Visible = False
        btnDelete.Visible = False
        btnAdd.Visible = True
    End Sub

    Private Function GetItemsByCategory(category As String) As List(Of Item)
        Return (From item In itemList Where item.Category = category).ToList()
    End Function

    Private Sub AllListLoaded()
        itemList = GetItemsByFieldName("", Item.FieldNames.Title, False, True)
        AllListBox.Clear()
        AllListBox.AddItemRange(itemList)
        FixMetroFrameworkBug(AllListBox)
    End Sub

    Private Sub MealListLoaded()
        MealListBox.Clear()
        mealList = GetItemsByCategory(Item.ItemCategory.Meal)
        MealListBox.AddItemRange(mealList)
        FixMetroFrameworkBug(MealListBox)
    End Sub

    Private Sub PastaListLoaded()
        PastaListBox.Clear()
        pastaList = GetItemsByCategory(Item.ItemCategory.Pasta)
        PastaListBox.AddItemRange(pastaList)
        FixMetroFrameworkBug(PastaListBox)

    End Sub

    Private Sub BurgerListLoaded()
        BurgerListBox.Clear()
        burgerlist = GetItemsByCategory(Item.ItemCategory.Burger)
        BurgerListBox.AddItemRange(burgerlist)
        FixMetroFrameworkBug(BurgerListBox)

    End Sub

    Private Sub DrinksListLoaded()
        DrinksListBox.Clear()
        drinkslist = GetItemsByCategory(Item.ItemCategory.Drinks)
        DrinksListBox.AddItemRange(drinkslist)
        FixMetroFrameworkBug(DrinksListBox)

    End Sub

    Private Sub DessertListLoaded()
        DessertListBox.Clear()
        dessertlist = GetItemsByCategory(Item.ItemCategory.Dessert)
        DessertListBox.AddItemRange(dessertlist)
        FixMetroFrameworkBug(DessertListBox)
    End Sub

    Function GetCurrentListBox() As ItemListBox
        Dim index = MetroTabControl1.SelectedIndex
        If index = 0 Then
            Return AllListBox
        ElseIf index = 1 Then
            Return MealListBox
        ElseIf index = 2 Then
            Return PastaListBox
        ElseIf index = 3 Then
            Return BurgerListBox
        ElseIf index = 4 Then
            Return DrinksListBox
        ElseIf index = 5 Then
            Return DessertListBox
        Else
            Return Nothing
        End If
    End Function

    Function GetCurrentListOfListBox() As List(Of Item)
        Dim index = MetroTabControl1.SelectedIndex
        If index = 0 Then
            Return itemList
        ElseIf index = 1 Then
            Return mealList
        ElseIf index = 2 Then
            Return pastaList
        ElseIf index = 3 Then
            Return burgerlist
        ElseIf index = 4 Then
            Return drinkslist
        ElseIf index = 5 Then
            Return dessertlist
        Else
            Return Nothing
        End If
    End Function

    Private Sub AllListSelectionChanged()
        If (AllListBox.SelectedItemIndex < 0) Then
            ItemDetailView1.setItem(New Item())
            btnEdit.Hide()
            btnDelete.Hide()
            btnAdd.Show()
        Else
            btnEdit.Show()
            btnDelete.Show()
            btnAdd.Show()
            ItemDetailView1.setItem(itemList(AllListBox.SelectedItemIndex))
        End If
    End Sub

    Private Sub MealListSelectionChanged()
        If (MealListBox.SelectedItemIndex < 0) Then
            ItemDetailView1.setItem(New Item())
            btnEdit.Hide()
            btnDelete.Hide()
            btnAdd.Show()
        Else
            btnEdit.Show()
            btnDelete.Show()
            btnAdd.Show()
            ItemDetailView1.setItem(mealList(MealListBox.SelectedItemIndex))
        End If
    End Sub


    Private Sub BurgerListSelectionChanged()
        If (BurgerListBox.SelectedItemIndex < 0) Then
            ItemDetailView1.setItem(New Item())
            btnEdit.Hide()
            btnDelete.Hide()
            btnAdd.Show()
        Else
            btnEdit.Show()
            btnDelete.Show()
            btnAdd.Show()
            ItemDetailView1.setItem(burgerlist(BurgerListBox.SelectedItemIndex))
        End If
    End Sub

    Private Sub PastaListSelectionChanged()
        If (PastaListBox.SelectedItemIndex < 0) Then
            ItemDetailView1.setItem(New Item())
            btnEdit.Hide()
            btnDelete.Hide()
            btnAdd.Show()
        Else
            btnEdit.Show()
            btnDelete.Show()
            btnAdd.Show()
            ItemDetailView1.setItem(pastaList(PastaListBox.SelectedItemIndex))
        End If
    End Sub


    Private Sub DessertListSelectionChanged()
        If (DessertListBox.SelectedItemIndex < 0) Then
            ItemDetailView1.setItem(New Item())
            btnEdit.Hide()
            btnDelete.Hide()
            btnAdd.Show()
        Else
            btnEdit.Show()
            btnDelete.Show()
            btnAdd.Show()
            ItemDetailView1.setItem(dessertlist(DessertListBox.SelectedItemIndex))
        End If
    End Sub


    Private Sub DrinksListSelectionChanged()
        If (DrinksListBox.SelectedItemIndex < 0) Then
            ItemDetailView1.setItem(New Item())
            btnEdit.Hide()
            btnDelete.Hide()
            btnAdd.Show()
        Else
            btnEdit.Show()
            btnDelete.Show()
            btnAdd.Show()
            ItemDetailView1.setItem(drinkslist(DrinksListBox.SelectedItemIndex))
        End If
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim current As ItemListBox = GetCurrentListBox()
        Dim currentItem As Item

        If current.Equals(AllListBox) Then
            currentItem = itemList(current.SelectedItemIndex)
        ElseIf current.Equals(MealListBox) Then
            currentItem = mealList(current.SelectedItemIndex)
        ElseIf current.Equals(PastaListBox) Then
            currentItem = pastaList(current.SelectedItemIndex)
        ElseIf current.Equals(BurgerListBox) Then
            currentItem = burgerlist(current.SelectedItemIndex)
        ElseIf current.Equals(DrinksListBox) Then
            currentItem = drinkslist(current.SelectedItemIndex)
        ElseIf current.Equals(DessertListBox) Then
            currentItem = dessertlist(current.SelectedItemIndex)
        End If

        EditOperation()

    End Sub


    Private Sub EditOperation()
        btnDone.Show()
        btnCancel.Show()
        btnEdit.Hide()
        btnAdd.Hide()
        MetroTabControl1.Hide()
        btnDelete.Hide()
        ItemDetailView1.isEnabled(True)
        currentOperation = EDIT_OPERATION
    End Sub

    Private Sub AddOperation()
        EditOperation()
        currentOperation = ADD_OPERATION
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            Dim current As ItemListBox = GetCurrentListBox()
            Dim currentItem As New Item
            If current.Equals(AllListBox) Then
                currentItem = itemList(current.SelectedItemIndex)
            ElseIf current.Equals(MealListBox) Then
                currentItem = mealList(current.SelectedItemIndex)
            ElseIf current.Equals(PastaListBox) Then
                currentItem = pastaList(current.SelectedItemIndex)
            ElseIf current.Equals(BurgerListBox) Then
                currentItem = burgerlist(current.SelectedItemIndex)
            ElseIf current.Equals(DrinksListBox) Then
                currentItem = drinkslist(current.SelectedItemIndex)
            ElseIf current.Equals(DessertListBox) Then
                currentItem = dessertlist(current.SelectedItemIndex)
            End If

            Dim result = MetroMessageBox.Show(mParent, "Are you sure you want to delete " & currentItem.Title & "?", "Delete Item", MessageBoxButton.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                DeleteItem(currentItem.Id)
                MetroMessageBox.Show(mParent, "Item record was deleted successfully.", "Deleting Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ItemDetailView1.isEnabled(False)
                MetroTabControl1.Visible = True
                btnAdd.Visible = True
                btnDone.Visible = False
                btnCancel.Visible = False
                btnEdit.Visible = False
                btnDelete.Visible = False
                ItemDetailView1.setItem(New Item())
                MetroTabControl1.SelectedIndex = 0
                AllListLoaded()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(mParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ImageClick()
        Try
            ofdImage.AutoUpgradeEnabled = False
            If ofdImage.ShowDialog() = DialogResult.OK Then
                ItemDetailView1.Image = Image.FromFile(ofdImage.FileName)
            End If
            ofdImage.Dispose()
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub KioskClick()
        Try
            ofdKiosk.AutoUpgradeEnabled = False
            If ofdKiosk.ShowDialog() = DialogResult.OK Then
                ItemDetailView1.Kiosk = Image.FromFile(ofdKiosk.FileName)
            End If
            ofdKiosk.Dispose()
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class