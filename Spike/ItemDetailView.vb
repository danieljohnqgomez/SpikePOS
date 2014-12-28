Imports System.Resources

Public Class ItemDetailView
    Dim currentItem As New Item

    Public Event ImageClick()
    Public Event KioskClick()

    Public Sub setItem(ByVal value As Item)
        currentItem = value
        With currentItem
            Image = ByteToImage(.Image, My.Resources.question)
            Kiosk = ByteToImage(.Kiosk, My.Resources.questioncanvass)
            Title = .Title
            Description = .Description
            RDescription = .ReceiptDescription
            Category = .Category
            Stocks = .Stock
            Price = .Price
        End With
    End Sub

    Public Function getItem() As Item
        Return currentItem
    End Function

    Property Image() As Image
        Get
            Return pbImage.Image
        End Get
        Set(value As Image)
            pbImage.Image = value
            currentItem.Image = ImageToByte(value)
        End Set
    End Property

    Property Kiosk() As Image
        Get
            Return pbKiosk.Image
        End Get
        Set(value As Image)
            pbKiosk.Image = value
            currentItem.Kiosk = ImageToByte(value)
        End Set
    End Property


    Property Title() As String
        Get
            Return tbName.Text
        End Get
        Set(value As String)
            tbName.Text = value
        End Set
    End Property

    Property Description() As String
        Get
            Return tbDescription.Text
        End Get
        Set(value As String)
            tbDescription.Text = value
        End Set
    End Property

    Property RDescription() As String
        Get
            Return tbRDesc.Text
        End Get
        Set(value As String)
            tbRDesc.Text = value
        End Set
    End Property

    Property Category() As String
        Get
            Return tbDescription.Text
        End Get
        Set(value As String)
            cbCategory.SelectedIndex = CategoryToIndex(value)
        End Set
    End Property

    Property Stocks() As Integer
        Get
            Return nStocks.Value
        End Get
        Set(value As Integer)
            nStocks.Value = value
        End Set
    End Property

    Property Price() As Double
        Get
            Return nPrice.Value
        End Get
        Set(value As Double)
            nPrice.Value = value
        End Set
    End Property

    Function CategoryToIndex(category As String) As Integer
        If category = "Meal" Then
            Return 0
        ElseIf category = "Pasta" Then
            Return 1
        ElseIf category = "Burger" Then
            Return 2
        ElseIf category = "Drinks" Then
            Return 3
        ElseIf category = "Dessert" Then
            Return 4
        Else
            Return -1
        End If
    End Function

    Public Sub isEnabled(bool As Boolean)
        Panel1.Enabled = bool
    End Sub

    Private Sub pbImage_Click(sender As Object, e As EventArgs) Handles pbImage.Click
        RaiseEvent ImageClick()
    End Sub

    Private Sub pbKiosk_Click(sender As Object, e As EventArgs) Handles pbKiosk.Click
        RaiseEvent KioskClick()
    End Sub


    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        currentItem.Title = tbName.Text
    End Sub

    Private Sub tbDescription_TextChanged(sender As Object, e As EventArgs) Handles tbDescription.TextChanged
        currentItem.Description = tbDescription.Text
    End Sub

    Private Sub tbRDesc_TextChanged(sender As Object, e As EventArgs) Handles tbRDesc.TextChanged
        currentItem.ReceiptDescription = tbRDesc.Text
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        currentItem.Category = cbCategory.SelectedItem
    End Sub

    Private Sub nStocks_ValueChanged(sender As Object, e As EventArgs) Handles nStocks.ValueChanged
        currentItem.Stock = nStocks.Value
    End Sub

    Private Sub nPrice_ValueChanged(sender As Object, e As EventArgs) Handles nPrice.ValueChanged
        currentItem.Price = nPrice.Value
    End Sub

End Class
