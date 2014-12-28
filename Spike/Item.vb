Public Class Item
    Private _id As Integer
    Private _itemId As Integer
    Private _title As String
    Private _image As Byte()
    Private _description As String
    Private _receiptDescription As String
    Private _category As String = "Meal"
    Private _categoryId As Integer
    Private _stock As Integer
    Private _price As Double
    Private _kiosk As Byte()

    Public Class FieldNames
        Public Const Id = "tbl_item.id"
        Public Const ItemId = "item_id"
        Public Const Title = "title"
        Public Const Image = "image"
        Public Const Description = "description"
        Public Const Stock = "stock"
        Public Const Price = "price"
        Public Const Kiosk = "kiosk"
        Public Const Category = "category_title"
        Public Const CategoryId = "category"
        Public Const ReceiptDescription = "receipt_description"
    End Class

    Public Class ItemCategory
        Public Const Meal = "Meal"
        Public Const Pasta = "Pasta"
        Public Const Burger = "Burger"
        Public Const Drinks = "Drinks"
        Public Const Dessert = "Dessert"
    End Class

    Public Shared Function CategoryToId(c As String) As Integer
        If (c = "Meal") Then
            Return 1
        ElseIf c = "Pasta" Then
            Return 2
        ElseIf c = "Burger" Then
            Return 3
        ElseIf c = "Drinks" Then
            Return 4
        ElseIf c = "Dessert" Then
            Return 5
        Else
            Throw New InvalidCategoryException("Invalid Category")
        End If
    End Function

    Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

    Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property

    Property Image() As Byte()
        Get
            Return _image
        End Get
        Set(ByVal value As Byte())
            _image = value
        End Set
    End Property

    Property Kiosk() As Byte()
        Get
            Return _kiosk
        End Get
        Set(ByVal value As Byte())
            _kiosk = value
        End Set
    End Property

    Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Property ReceiptDescription() As String
        Get
            Return _receiptDescription
        End Get
        Set(ByVal value As String)
            _receiptDescription = value
        End Set
    End Property

    Property Category() As String
        Get
            Return _category
        End Get
        Set(ByVal value As String)
            _category = value
        End Set
    End Property
    Property CategoryId() As Integer
        Get
            Return _categoryId
        End Get
        Set(ByVal value As Integer)
            _categoryId = value
        End Set
    End Property

    Property Stock() As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
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

End Class
