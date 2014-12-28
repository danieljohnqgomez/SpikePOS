
Public Class PersonListBox

    Public selectedIndex As Integer = -1

    Public Event SelectionChanged()

    Public Sub AddItem(u As User)
        listBox.Items.Add(u)
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
        selectedIndex = listBox.SelectedIndex
        RaiseEvent SelectionChanged()
    End Sub
End Class
