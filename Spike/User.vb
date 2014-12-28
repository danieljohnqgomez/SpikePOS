
Public Class User
    Private _id As Integer
    Private _username As String = ""
    Private _type As String = "User"
    Private _status As String = "Active"
    Private _firstName As String = ""
    Private _middleName As String = ""
    Private _lastName As String = ""
    Private _address As String = ""
    Private _dob As String = ""
    Private _gender As String = "Male"
    Private _imageBytes As Byte()
    Private _password As String = ""


    Public Class FieldNames
        'From tbl_account
        Public Const Id = "ID"
        Public Const Username = "username"
        Public Const Password = "password"
        Public Const AccountType = "account_type_id"
        Public Const StatusId = "status_id"

        'From tbl_user
        Public Const AccountId = "account_id"
        Public Const FirstName = "firstname"
        Public Const MiddleName = "middlename"
        Public Const LastName = "lastname"
        Public Const Address = "address"
        Public Const DateOfBirth = "dob"
        Public Const Gender = "gender"
        Public Const Image = "thumbnail"

        'From tbl_account_type
        Public Const Type = "type"


        'From tbl_account_type
        Public Const Status = "status"

    End Class

    Public Class AccountType
        Public Const Admin = "Administrator"
        Public Const User = "User"
    End Class

    Public Class AccountGender
        Public Const Male = "Male"
        Public Const Female = "Female"
    End Class

    Public Class AccountStatus
        Public Const Active = "Active"
        Public Const Inactive = "Inactive"
        Public Const Disabled = "Disabled"
    End Class

    Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property Type() As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property

    Property Status() As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property
    Property MiddleName() As String
        Get
            Return _middleName
        End Get
        Set(value As String)
            _middleName = value
        End Set
    End Property
    Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property
    Property Address() As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property
    Property DateOfBirth() As String
        Get
            Return _dob
        End Get
        Set(value As String)
            _dob = value
        End Set
    End Property
    Property Gender() As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property

    Property ImageBytes() As Byte()
        Get
            If IsNothing(_imageBytes) Then
                Dim converter As New ImageConverter
                Return converter.ConvertTo(My.Resources.imgUserDefault, GetType(Byte()))
            Else
                Return _imageBytes
            End If
        End Get
        Set(value As Byte())
            _imageBytes = value
        End Set
    End Property

    ReadOnly Property FullName() As String
        Get
            Return _firstName & " " & _lastName
        End Get
    End Property

    Public Function typeToID(value As String) As Integer
        If (value = AccountType.Admin) Then
            Return 1
        Else
            Return 2
        End If
    End Function

    Public Function statusToID(value As String) As Integer
        If (value = User.AccountStatus.Active) Then
            Return 1
        ElseIf (value.ToString() = User.AccountStatus.Inactive) Then
            Return 2
        Else
            Return 3
        End If
    End Function
End Class
