Imports System.Windows.Input

Public Class ItemListBox

    Public Event ItemDoubleClick()
    Public Event SelectionChanged()

    Private _selectedItemIndex As Integer = -1

    Public Sub AddItem(i As Item)
        listBox.Items.Add(i)
    End Sub

    Public Sub RefreshItems()
        listBox.Items.Refresh()
    End Sub

    Public Sub Clear()
        listBox.ItemsSource = Nothing
        listBox.Items.Clear()
    End Sub

    Public Sub ClearSelection()
        listBox.UnselectAll()
    End Sub

    Public Sub AddItemRange(array As IEnumerable)
        listBox.ItemsSource = array
    End Sub

    Private Sub ListBox_SelectionChanged(sender As Object, e As Windows.Controls.SelectionChangedEventArgs)
        _selectedItemIndex = listBox.SelectedIndex
        RaiseEvent SelectionChanged()
    End Sub
    ReadOnly Property SelectedItemIndex() As Integer
        Get
            Return _selectedItemIndex
        End Get
    End Property

    Private Sub ListBoxItem_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        RaiseEvent ItemDoubleClick()
    End Sub
End Class
