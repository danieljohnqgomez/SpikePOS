Imports System.Windows.Input

Public Class ReceiptListBox
    Private _itemList As New List(Of OrderItem)
    Private _total As Double = 0
    Public Event ItemChanged()
    Public Event ItemDoubleClick()

    Private _selectedIndex = -1

    Sub AddItem(item As OrderItem)
        Dim existingOrder As OrderItem = ExistingOrderItem(item.ItemId)
        If existingOrder Is Nothing Then
            _itemList.Add(item)
            listBox.Items.Add(item)
        Else
            existingOrder.AddQuantity(item.Quantity)
            listBox.Items.Refresh()
        End If
        RaiseEvent ItemChanged()
    End Sub

    Sub AddItem(item As Item)
        Dim orderItem As New OrderItem
        orderItem.ItemId = item.ItemId
        orderItem.Quantity = 1
        orderItem.Price = item.Price
        orderItem.Title = item.Title
        orderItem.Description = item.Description
        AddItem(orderItem)
    End Sub

    Sub AddItem(item As Item, quantity As Integer)
        Dim orderItem As New OrderItem
        orderItem.ItemId = item.ItemId
        orderItem.Quantity = quantity
        orderItem.Price = item.Price
        orderItem.Title = item.Title
        orderItem.Description = item.Description
        AddItem(orderItem)
    End Sub

    Sub DecreaseItem(index As Integer)
        If Not index = -1 Then
            Dim item = _itemList(index)
            If item.Quantity = 1 Then
                _itemList.Remove(item)
                listBox.Items.RemoveAt(index)
            Else
                item.DecrementQuantity()
            End If
            listBox.Items.Refresh()
            RaiseEvent ItemChanged()
        End If
    End Sub

    Sub DeleteItem(index As Integer)
        If Not index = -1 Then
            Dim item = _itemList(index)
                _itemList.Remove(item)
                listBox.Items.RemoveAt(index)
            listBox.Items.Refresh()
            RaiseEvent ItemChanged()
        End If
    End Sub

    Sub ClearItems()
        listBox.Items.Clear()
        listBox.Items.Refresh()
    End Sub

    Public Sub Checkout(customerNo As Integer)
        CheckoutOrder(New Order(_itemList, customerNo))
        _itemList = New List(Of OrderItem)
        _total = 0
        RaiseEvent ItemChanged()
    End Sub

    Public Sub Clear()
        listBox.ItemsSource = Nothing
        listBox.Items.Clear()
    End Sub

    Public Sub ClearSelection()
        listBox.UnselectAll()
    End Sub

    ReadOnly Property Total() As Double
        Get
            _total = 0
            For Each i In _itemList
                _total += i.TotalAmount
            Next
            Return _total
        End Get
    End Property

    ReadOnly Property SelectedIndex() As Integer
        Get
            Return _selectedIndex
        End Get
    End Property

    Private Function ExistingOrderItem(id As Integer) As OrderItem
        For Each orderItem In _itemList
            If orderItem.ItemId = id Then
                Return orderItem
            End If
        Next
        Return Nothing
    End Function

    Private Sub ListBoxItem_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        RaiseEvent ItemDoubleClick()
        RaiseEvent ItemChanged()
    End Sub

    Private Sub listBox_SelectionChanged(sender As Object, e As Windows.Controls.SelectionChangedEventArgs) Handles listBox.SelectionChanged
        _selectedIndex = listBox.SelectedIndex
    End Sub
End Class
