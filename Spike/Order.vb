Public Class Order
    Private _items As List(Of OrderItem)
    Private _customerNo As Integer

    Sub New(items As List(Of OrderItem), customerNo As Integer)
        _items = items
        _customerNo = customerNo
    End Sub

    Property Items() As List(Of OrderItem)
        Get
            Return _items
        End Get
        Set(val As List(Of OrderItem))
            _items = val
        End Set
    End Property

    ReadOnly Property CustomerNo() As Integer
        Get
            Return _customerNo
        End Get
    End Property

    ReadOnly Property DateSold() As String
        Get
            Return StringTools.FormatDate(DateTime.Now.ToString("MM/dd/yyyy"))
        End Get
    End Property
End Class
