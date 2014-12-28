Public Class OrderItem
    Private _quantity As Integer = 1
    Private _itemId As Integer
    Private _price As Double
    Private _rdesc As String
    Private _totalAmount As Double
    Private _desc As String
    Private _title As String

    Sub New(item As Item, quantity As Integer)
        _quantity = quantity
        _itemId = item.ItemId
        _price = item.Price
        _desc = item.Description
        _title = item.Title
        _totalAmount = (_price * quantity)
    End Sub

    Sub New()

    End Sub

    Property Quantity() As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal value As Integer)
            _quantity = value
        End Set
    End Property

    Property Price() As Double
        Get
            Return _price
        End Get
        Set(ByVal value As Double)
            _price = value
        End Set
    End Property

    Property ItemId() As Integer
        Get
            Return _itemId
        End Get
        Set(ByVal value As Integer)
            _itemId = value
        End Set
    End Property

    Property TotalAmount() As Double
        Get
            Return (_price * Quantity)
        End Get
        Set(ByVal value As Double)
            _totalAmount = value
        End Set
    End Property

    Property RDesc() As String
        Get
            Return GetReceiptDescriptionById(ItemId)
        End Get
        Set(value As String)
            _rdesc = value
        End Set
    End Property

    Property Description() As String
        Get
            Return _desc
        End Get
        Set(value As String)
            _desc = value
        End Set
    End Property

    Property Title() As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Sub IncrementQuantity()
        _quantity += 1
    End Sub

    Public Sub DecrementQuantity()
        _quantity -= 1
    End Sub

    Public Sub AddQuantity(q As Integer)
        _quantity += q
    End Sub
End Class
