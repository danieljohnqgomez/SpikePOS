
Imports MetroFramework
Imports System.Drawing.Text
Imports Microsoft.TeamFoundation.MVVM
Imports System.Text

Public Class FrmCounter

    Dim tips() As String = {My.Resources.CounterTip1, My.Resources.CounterTip2}
    Dim currentTip As Integer = 1

    Dim AllListBox As ItemListBox
    Dim MealListBox As ItemListBox
    Dim PastaListBox As ItemListBox
    Dim BurgerListBox As ItemListBox
    Dim DrinksListBox As ItemListBox
    Dim DessertListBox As ItemListBox

    Dim ReceiptListBox As ReceiptListBox

    Dim itemList As List(Of Item)
    Dim mealList As List(Of Item)
    Dim pastaList As List(Of Item)
    Dim burgerlist As List(Of Item)
    Dim drinkslist As List(Of Item)
    Dim dessertlist As List(Of Item)

    Dim mParent As Form

    'Used to fix MetroFramework design bug
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const FIXED = 0

    Private Sub FixMetroFrameworkBug()
        Dim listControl = GetCurrentListBox()
        If listControl.Tag Is Nothing Then
            Dim originalPosition As System.Drawing.Point = Cursor.Position
            Cursor.Position = New System.Drawing.Point(352, 253)
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

    Private Sub FrmCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mParent = Parent.Parent
'        Dim pfc As New PrivateFontCollection()
'        pfc.AddFontFile(GetResourceFolder() & "DOTMATRI.TTF")
        '        Label3.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        '        Label4.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        '        Label5.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        '        Label6.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        '        Label7.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        '        Label8.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        '        Label9.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        '        lblTotal.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        tipTimer.Start()
        UpdateCustomerNo()
        AllListBox = New ItemListBox
        AllHost.Child = AllListBox
        AddHandler AllListBox.Loaded, AddressOf AllListLoaded
        AddHandler AllListBox.ItemDoubleClick, AddressOf AllListDoubleClick

        MealListBox = New ItemListBox
        MealHost.Child = MealListBox
        AddHandler MealListBox.Loaded, AddressOf MealListLoaded
        AddHandler MealListBox.ItemDoubleClick, AddressOf MealListDoubleClick

        PastaListBox = New ItemListBox
        PastaHost.Child = PastaListBox
        AddHandler PastaListBox.Loaded, AddressOf PastaListLoaded
        AddHandler PastaListBox.ItemDoubleClick, AddressOf PastaListDoubleClick

        BurgerListBox = New ItemListBox
        BurgerHost.Child = BurgerListBox
        AddHandler BurgerListBox.Loaded, AddressOf BurgerListLoaded
        AddHandler BurgerListBox.ItemDoubleClick, AddressOf BurgerListDoubleClick

        DrinksListBox = New ItemListBox
        DrinksHost.Child = DrinksListBox
        AddHandler DrinksListBox.Loaded, AddressOf DrinksListLoaded
        AddHandler DrinksListBox.ItemDoubleClick, AddressOf DrinksListDoubleClick

        DessertListBox = New ItemListBox
        DessertHost.Child = DessertListBox
        AddHandler DessertListBox.Loaded, AddressOf DessertListLoaded
        AddHandler DessertListBox.ItemDoubleClick, AddressOf DessertListDoubleClick

        ReceiptListBox = New ReceiptListBox
        ReceiptHost.Child = ReceiptListBox
        AddHandler ReceiptListBox.ItemDoubleClick, AddressOf ReceiptItemDoubleClick
        AddHandler ReceiptListBox.ItemChanged, AddressOf ReceiptItemChanged


    End Sub

    Private Sub ReceiptItemDoubleClick()
        ReceiptListBox.DecreaseItem(ReceiptListBox.SelectedIndex)
    End Sub

    Private Sub ReceiptItemChanged()
        lblTotal.Text = "Total: ₱" & ReceiptListBox.Total
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If GetCurrentListBox().SelectedItemIndex = -1 Then
            MetroMessageBox.Show(mParent, "Please select an item.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf nQuantity.Value < 1 Or (Not IsNumeric(nQuantity.Value)) Then
            MetroMessageBox.Show(mParent, "Please enter a valid quantity value.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ReceiptListBox.AddItem(GetCurrentListOfListBox()(GetCurrentListBox().SelectedItemIndex), nQuantity.Value)
        End If
    End Sub


    Private Sub tipTimer_Tick(sender As Object, e As EventArgs) Handles tipTimer.Tick
        If currentTip = tips.Length Then
            currentTip = 0
        Else
            lblTip.Text = "Tip: " & tips(currentTip)
            currentTip += 1
        End If
    End Sub

    Private Function GetItemsByCategory(category As String) As List(Of Item)
        Return (From item In itemList Where item.Category = category).ToList()
    End Function

    Private Sub AllListLoaded()
        FixMetroFrameworkBug()
        itemList = GetItemsByFieldName("", Item.FieldNames.Title, False, True)
        AllListBox.Clear()
        AllListBox.AddItemRange(itemList)
    End Sub

    Private Sub MealListLoaded()
        FixMetroFrameworkBug()
        MealListBox.Clear()
        mealList = GetItemsByCategory(Item.ItemCategory.Meal)
        MealListBox.AddItemRange(mealList)
    End Sub

    Private Sub PastaListLoaded()
        FixMetroFrameworkBug()
        PastaListBox.Clear()
        pastaList = GetItemsByCategory(Item.ItemCategory.Pasta)
        PastaListBox.AddItemRange(pastaList)
    End Sub

    Private Sub BurgerListLoaded()
        FixMetroFrameworkBug()
        BurgerListBox.Clear()
        burgerlist = GetItemsByCategory(Item.ItemCategory.Burger)
        BurgerListBox.AddItemRange(burgerlist)
    End Sub

    Private Sub DrinksListLoaded()
        FixMetroFrameworkBug()
        DrinksListBox.Clear()
        drinkslist = GetItemsByCategory(Item.ItemCategory.Drinks)
        DrinksListBox.AddItemRange(drinkslist)
    End Sub

    Private Sub DessertListLoaded()
        FixMetroFrameworkBug()
        DessertListBox.Clear()
        dessertlist = GetItemsByCategory(Item.ItemCategory.Dessert)
        DessertListBox.AddItemRange(dessertlist)
    End Sub

    Private Sub AllListDoubleClick()
        If Not AllListBox.SelectedItemIndex = -1 Then
            ReceiptListBox.AddItem(itemList(AllListBox.SelectedItemIndex))
        End If
    End Sub

    Private Sub DessertListDoubleClick()
        If Not DessertListBox.SelectedItemIndex = -1 Then
            ReceiptListBox.AddItem(dessertlist(DessertListBox.SelectedItemIndex))
        End If
    End Sub

    Private Sub DrinksListDoubleClick()
        If Not DrinksListBox.SelectedItemIndex = -1 Then
            ReceiptListBox.AddItem(drinkslist(DrinksListBox.SelectedItemIndex))
        End If
    End Sub

    Private Sub BurgerListDoubleClick()
        If Not BurgerListBox.SelectedItemIndex = -1 Then
            ReceiptListBox.AddItem(burgerlist(BurgerListBox.SelectedItemIndex))
        End If
    End Sub

    Private Sub PastaListDoubleClick()
        If Not PastaListBox.SelectedItemIndex = -1 Then
            ReceiptListBox.AddItem(pastaList(PastaListBox.SelectedItemIndex))
        End If
    End Sub

    Private Sub MealListDoubleClick()
        If Not MealListBox.SelectedItemIndex = -1 Then
            ReceiptListBox.AddItem(mealList(MealListBox.SelectedItemIndex))
        End If
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

    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click
        If ReceiptListBox.SelectedIndex = -1 Then
            MetroMessageBox.Show(mParent, "Please select an item.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ReceiptItemDoubleClick()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ReceiptListBox.SelectedIndex = -1 Then
            MetroMessageBox.Show(mParent, "Please select an item.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ReceiptListBox.DeleteItem(ReceiptListBox.SelectedIndex)
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Try
'            If (Not IsNumeric(tbNumber.Text) Or tbNumber.Text.StartsWith("63")) And (Not String.IsNullOrWhiteSpace(tbNumber.Text)) Then
'                MetroMessageBox.Show(mParent, "Please enter a correct mobile number. Use 63 as the prefix.", "Input invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Else
                Dim customerNo = GetCurrentCustomerNo()
                ReceiptListBox.Checkout(customerNo)
                ReceiptListBox.ClearItems()
                UpdateCustomerNo()
                MetroMessageBox.Show(mParent, "Order was processed successfully", "Order Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateItems()
'                If Not String.IsNullOrWhiteSpace(tbNumber.Text) Then
'                    SendTextMessage(customerNo)
'                End If
'            End If
           
        Catch ex As OutOfStocksException
            MetroMessageBox.Show(mParent, ex.Message, "Order failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch txtException As TextMessageException
            MetroMessageBox.Show(mParent, "Text message not sent. Response from the API: " & vbCrLf & txtException.Message, "Text Message Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
       End Sub

    Private Sub UpdateCustomerNo()
        lblCustomerNo.Text = "CUSTOMER NO: " & GetCurrentCustomerNo()
    End Sub

    Private Sub UpdateItems()
        AllListLoaded()
        MealListLoaded()
        DessertListLoaded()
        BurgerListLoaded()
        DrinksListLoaded()
        PastaListLoaded()
        GetCurrentListBox().RefreshItems()
    End Sub

   

    Private Sub SendTextMessage(customerNo As Integer)
        Dim url As New Uri("https://post.chikka.com/smsapi/request")

        Using client As New Net.WebClient
            client.UseDefaultCredentials = True
            Dim reqparm As New Specialized.NameValueCollection
            reqparm.Add("message_type", "SEND")
'            reqparm.Add("mobile_number", tbNumber.Text)
            reqparm.Add("shortcode", "29290660")
            reqparm.Add("message_id", customerNo)
            reqparm.Add("message", "Thank you for choosing Food Express! Your customer/receipt number is " & customerNo & ". The total amount purchased is " & ReceiptListBox.Total & ". Come again!")
            reqparm.Add("client_id", "8f668caf919a3603cc7b1a578205345b73208e07e579e4d13a4f9554977f23fe")
            reqparm.Add("secret_key", "8622077333b59d75af67cbae778dcaec29765cfdc142c73f345a1f4eeef37c99")
            AddHandler client.UploadValuesCompleted, AddressOf UploadValuesCompleted
            client.UploadValuesAsync(url, "POST", reqparm)
        End Using
    End Sub

    Private Sub UploadValuesCompleted(sender As Object, e As Net.UploadValuesCompletedEventArgs)
        Dim responsebytes = e.Result
        Dim responsebody = (New System.Text.UTF8Encoding).GetString(responsebytes)
        If Not responsebody.Contains("ACCEPTED") Then
            Throw New TextMessageException(responsebody)
        End If
    End Sub

End Class