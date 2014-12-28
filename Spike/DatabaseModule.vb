Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Controls

Module DatabaseModule
    ReadOnly Connection As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GetResourceFolder() & "dbSpike.accdb")
    Private _user As User

    Function GetUserByFieldName(searchText As String, fieldName As String) As User
        Connection.Open()

        Dim command As New OleDbCommand("SELECT tbl_account.*, tbl_status.status, tbl_user.*, tbl_account_type.type " &
                                        "FROM tbl_user INNER JOIN (tbl_status INNER JOIN (tbl_account_type INNER JOIN tbl_account ON tbl_account_type.ID = tbl_account.account_type_id) ON tbl_status.ID = tbl_account.status_id) ON tbl_user.account_id = tbl_account.ID " &
                                        "WHERE " & fieldName & " = ?", Connection)
        command.Parameters.AddWithValue("@fieldName", searchText)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        Dim mUser = New User()
        While reader.Read()
            With mUser
                .Id = reader(User.FieldNames.Id)
                .Username = reader(User.FieldNames.Username)
                .Password = reader(User.FieldNames.Password)
                .Type = reader(User.FieldNames.Type)
                .Status = reader(User.FieldNames.Status)
                .FirstName = reader(User.FieldNames.FirstName)
                .MiddleName = reader(User.FieldNames.MiddleName)
                .LastName = reader(User.FieldNames.LastName)
                .Address = reader(User.FieldNames.Address)
                .DateOfBirth = StringTools.FormatDate(reader(User.FieldNames.DateOfBirth))
                .Gender = reader(User.FieldNames.Gender)
                Dim imgData = reader(User.FieldNames.Image)
                If Not (TypeOf imgData Is DBNull Or imgData Is Nothing) Then
                    .ImageBytes = CType(imgData, Byte())
                End If
            End With
        End While
        reader.Close()
        Connection.Close()
        Return mUser
    End Function

    Function GetAllUsers() As List(Of User)
        Connection.Open()

        Dim command As New OleDbCommand("SELECT tbl_account.*, tbl_status.status, tbl_user.*, tbl_account_type.type " &
                                        "FROM tbl_user INNER JOIN (tbl_status INNER JOIN (tbl_account_type INNER JOIN tbl_account ON tbl_account_type.ID = tbl_account.account_type_id) ON tbl_status.ID = tbl_account.status_id) ON tbl_user.account_id = tbl_account.ID ", Connection)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        Dim userList As New List(Of User)
        While reader.Read()
            Dim mUser = New User()
            With mUser
                .Id = reader(User.FieldNames.Id)
                .Username = reader(User.FieldNames.Username)
                .Password = reader(User.FieldNames.Password)
                .Type = reader(User.FieldNames.Type)
                .Status = reader(User.FieldNames.Status)
                .FirstName = reader(User.FieldNames.FirstName)
                .MiddleName = reader(User.FieldNames.MiddleName)
                .LastName = reader(User.FieldNames.LastName)
                .Address = reader(User.FieldNames.Address)
                .DateOfBirth = StringTools.FormatDate(reader(User.FieldNames.DateOfBirth))
                .Gender = reader(User.FieldNames.Gender)
                Dim imgData = reader(User.FieldNames.Image)
                If Not (TypeOf imgData Is DBNull Or imgData Is Nothing) Then
                    .ImageBytes = CType(imgData, Byte())
                End If
            End With
            userList.Add(mUser)
        End While
        reader.Close()
        Connection.Close()
        Return userList
    End Function

    Sub UpdatePictureByUsername(username As String, image As Drawing.Image)
        Connection.Open()

        Dim command As New OleDbCommand("UPDATE tbl_user INNER JOIN tbl_account ON tbl_user.account_id = tbl_account.ID " &
                                        "SET tbl_user.thumbnail = ? " &
                                        "WHERE (((tbl_account.username) = ?))", Connection)

        Dim imageBytes = ImageToByte(image)
        command.Parameters.Add("@thumbnail", OleDbType.Binary).Value = imageBytes
        command.Parameters.AddWithValue("@username", username)
        command.ExecuteNonQuery()
        _user.ImageBytes = imageBytes
        Connection.Close()
    End Sub

    Function ByteToImage(b As Byte(), errorImage As Drawing.Image) As Drawing.Image
        If (b IsNot Nothing) Then
            Dim myMS As New MemoryStream
            For Each ar As Byte In b
                myMS.WriteByte(ar)
            Next
            Return Drawing.Image.FromStream(myMS)
        Else
            Return errorImage
        End If
    End Function

    Function IsCorrectPassword(username As String, password As String) As Boolean
        Dim comparison As Boolean
        Connection.Open()
        Dim command As New OleDbCommand("SELECT password FROM tbl_account WHERE username = ?", Connection)
        command.Parameters.AddWithValue("@username", username)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        Dim count As Integer = 0
        While reader.Read()
            comparison = (password = reader(0).ToString())
            count = count + 1
        End While
        reader.Close()
        Connection.Close()
        If count = 0 Then
            Throw New UsernameNotFoundException("Username not found")
        End If
        Return comparison
    End Function

    Public Function GetResourceFolder() As String
        Return Environment.CurrentDirectory & "\Resources\"
    End Function

    Property CurrentUser() As User
        Get
            Return _user
        End Get
        Set(value As User)
            _user = value
        End Set
    End Property

    Function GetItemsByFieldName(searchText As String, fieldName As String, isExact As Boolean, includeOutOfStocks As Boolean) As List(Of Item)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        Dim command As OleDbCommand
        If isExact Then
            command = New OleDbCommand("SELECT * FROM tbl_item_category INNER JOIN tbl_item ON tbl_item_category.ID = tbl_item.category WHERE " & fieldName & " = ? ", Connection)
        Else
            command = New OleDbCommand("SELECT * FROM tbl_item_category INNER JOIN tbl_item ON tbl_item_category.ID = tbl_item.category WHERE " & fieldName & " LIKE '%" & searchText & "%'", Connection)
        End If
        If Not includeOutOfStocks Then
            command.CommandText += "AND " & Item.FieldNames.Stock & ">0"
        End If
        command.Parameters.AddWithValue("@fieldName", searchText)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        Dim items As List(Of Item) = New List(Of Item)
        While reader.Read()
            Dim item As Item = New Item()
            With item
                .Id = reader(item.FieldNames.Id)
                .Title = reader(item.FieldNames.Title)
                .ItemId = reader(item.FieldNames.ItemId)
                .Description = reader(item.FieldNames.Description)
                .ReceiptDescription = reader(item.FieldNames.ReceiptDescription)
                .Stock = reader(item.FieldNames.Stock)
                .Price = reader(item.FieldNames.Price)
                .Category = reader(item.FieldNames.Category)
                .CategoryId = reader(item.FieldNames.CategoryId)
                Dim imgData = reader(item.FieldNames.Image)
                If Not (TypeOf imgData Is DBNull Or imgData Is Nothing) Then
                    .Image = CType(imgData, Byte())
                Else
                    .Image = ImageToByte(My.Resources.question)
                End If
                Dim kioskData = reader(item.FieldNames.Kiosk)
                If Not (TypeOf kioskData Is DBNull Or kioskData Is Nothing) Then
                    .Kiosk = CType(kioskData, Byte())
                Else
                    .Kiosk = ImageToByte(My.Resources.questioncanvass)

                End If

            End With
            items.Add(item)
        End While
        reader.Close()
        Connection.Close()
        Return items
    End Function

    Function ImageToByte(img As Drawing.Image) As Byte()
        Dim converter As New ImageConverter
        Return converter.ConvertTo(img, GetType(Byte()))
    End Function

    Sub AddUser(user As User)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        With user
            Dim tbl_user_command As New OleDbCommand("INSERT INTO tbl_user (firstname, middlename, lastname, address, dob, gender, thumbnail) " &
                                            "VALUES (?, ?, ?, ?, ?, ?, ?)", Connection)

            tbl_user_command.Parameters.AddWithValue("@firstname", .FirstName)
            tbl_user_command.Parameters.AddWithValue("@middlename", .MiddleName)
            tbl_user_command.Parameters.AddWithValue("@lastname", .LastName)
            tbl_user_command.Parameters.AddWithValue("@address", .Address)
            tbl_user_command.Parameters.AddWithValue("@dob", StringTools.FormatDate(.DateOfBirth))
            tbl_user_command.Parameters.AddWithValue("@gender", .Gender)
            tbl_user_command.Parameters.Add("@thumbnail", OleDbType.Binary).Value = .ImageBytes
            tbl_user_command.ExecuteScalar()
            tbl_user_command.Parameters.Clear()

            'Getting the user ID after insertion
            Dim id_command As New OleDbCommand("SELECT @@IDENTITY FROM tbl_user", Connection)
            Dim newId = id_command.ExecuteScalar()

            'Inserting a record to tbl_account with the ID from user table
            Dim tbl_account_command As New OleDbCommand("INSERT INTO tbl_account (username, [password], account_type_id, status_id, account_id) VALUES (?, ?, ?, ?, ?)", Connection)

            tbl_account_command.Parameters.AddWithValue("@username", .Username)
            tbl_account_command.Parameters.AddWithValue("@password", .Password)
            tbl_account_command.Parameters.AddWithValue("@account_type_id", user.typeToID(.Type))
            tbl_account_command.Parameters.AddWithValue("@status_id", user.statusToID(.Status))
            tbl_account_command.Parameters.AddWithValue("@account_id", newId)

            tbl_account_command.ExecuteNonQuery()


            Connection.Close()
        End With
    End Sub

    Sub UpdateUser(user As User)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        With user
            Dim tbl_user_command As New OleDbCommand("UPDATE tbl_user SET firstname=?, middlename=?, lastname=?, address=?, dob=?, gender=?, [thumbnail] = ? " &
                                            "WHERE account_id=?", Connection)

            tbl_user_command.Parameters.AddWithValue("@firstname", .FirstName)
            tbl_user_command.Parameters.AddWithValue("@middlename", .MiddleName)
            tbl_user_command.Parameters.AddWithValue("@lastname", .LastName)
            tbl_user_command.Parameters.AddWithValue("@address", .Address)
            tbl_user_command.Parameters.AddWithValue("@dob", StringTools.FormatDate(.DateOfBirth))
            tbl_user_command.Parameters.AddWithValue("@gender", .Gender)
            tbl_user_command.Parameters.AddWithValue("@thumbnail", .ImageBytes)
            tbl_user_command.Parameters.AddWithValue("@account_id", .Id)
            tbl_user_command.ExecuteNonQuery()

            Dim tbl_account_command As New OleDbCommand("UPDATE tbl_account SET username=?, [password]=?, account_type_id=?, status_id=? WHERE account_id=?", Connection)

            tbl_account_command.Parameters.AddWithValue("@username", .Username)
            tbl_account_command.Parameters.AddWithValue("@password", .Password)
            tbl_account_command.Parameters.AddWithValue("@account_type_id", user.typeToID(.Type))
            tbl_account_command.Parameters.AddWithValue("@status_id", user.statusToID(.Status))
            tbl_account_command.Parameters.AddWithValue("@account_id", .Id)
            tbl_account_command.ExecuteNonQuery()
            Connection.Close()
        End With
    End Sub

    Sub DeleteUser(Id As String)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        Dim tbl_user_command As New OleDbCommand("DELETE FROM tbl_user WHERE account_id=?", Connection)

        tbl_user_command.Parameters.AddWithValue("@account_id", Id)
        tbl_user_command.ExecuteNonQuery()

        Dim tbl_account_command As New OleDbCommand("DELETE FROM tbl_account WHERE account_id=?", Connection)

        tbl_account_command.Parameters.AddWithValue("@account_id", Id)
        tbl_account_command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Function GetReceiptDescriptionById(id As Integer) As String
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        Dim command As New OleDbCommand("SELECT * FROM tbl_item WHERE item_id=?", Connection)

        command.Parameters.AddWithValue("@item_id", id)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        Dim desc As String = ""
        While reader.Read()
            desc = reader("receipt_description")
        End While
        Connection.Close()
        Return desc
    End Function

    Sub CheckoutOrder(order As Order)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        For Each item In order.Items
            Dim quantity_check_command As New OleDbCommand("SELECT stock FROM tbl_item WHERE item_id = ?", Connection)
            quantity_check_command.Parameters.AddWithValue("@item_id", item.ItemId)
            Dim stocks As Integer = quantity_check_command.ExecuteScalar()
            If stocks < item.Quantity Then
                Connection.Close()
                Throw New OutOfStocksException(item.Title & " is out of stocks.")
            Else
                Dim command As New OleDbCommand("INSERT INTO tbl_sold (item_id, quantity, total_amount, date_sold, customer_no) " & "VALUES (?, ?, ?, ?, ?)", Connection)
                command.Parameters.AddWithValue("@item_id", item.ItemId)
                command.Parameters.AddWithValue("@quantity", item.Quantity)
                command.Parameters.AddWithValue("@total_amount", item.TotalAmount)
                command.Parameters.AddWithValue("@date_sold", order.DateSold)
                command.Parameters.AddWithValue("@customer_no", order.CustomerNo)
                command.ExecuteNonQuery()

                Dim update As New OleDbCommand("UPDATE tbl_item SET stock = stock - " & item.Quantity & " WHERE item_id = ?", Connection)
                update.Parameters.AddWithValue("@item_id", item.ItemId)
                update.ExecuteNonQuery()
            End If
        Next
        Connection.Close()
    End Sub

    Function GetCurrentCustomerNo() As Integer
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        Dim MaxCustomerNo As Integer = 0

        Dim command As New OleDbCommand("SELECT Max(customer_no) AS MaxCustomerNo FROM tbl_sold", Connection)

        Dim reader As OleDbDataReader = command.ExecuteReader()
        While reader.Read()
            Dim value = reader("MaxCustomerNo")
            If Not Convert.IsDBNull(value) Then
                MaxCustomerNo = value
            End If
        End While
        Connection.Close()
        Return MaxCustomerNo + 1
    End Function

    Function GetItemsWithKiosk() As List(Of Item)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If

        Dim command As New OleDbCommand("SELECT * FROM tbl_item WHERE kiosk IS NOT NULL", Connection)

        Dim reader As OleDbDataReader = command.ExecuteReader()
        Dim list As New List(Of Item)
        While reader.Read()
            Dim item As New Item
            item.ItemId = reader("item_id")
            item.Title = reader("title")
            item.Description = reader("description")
            item.Price = reader("price")
            item.Kiosk = reader("kiosk")
            list.Add(item)
        End While
        Connection.Close()
        Return list
    End Function

    Sub AddItem(item As Item)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        With item
            Dim max_item_id As Integer
            Dim item_id As Integer
            Dim cmdId As New OleDbCommand("SELECT Max(item_id) AS MaxItemId FROM tbl_item", Connection)
            Dim reader As OleDbDataReader = cmdId.ExecuteReader()
            While reader.Read()
                Dim value = reader("MaxItemId")
                If Not Convert.IsDBNull(value) Then
                    max_item_id = value
                End If
            End While
            item_id = max_item_id + 1

            Dim command As New OleDbCommand("INSERT INTO tbl_item (item_id, title, [image], kiosk, description, receipt_description, category, stock, price) " &
                                            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)", Connection)

            command.Parameters.AddWithValue("@item_id", item_id)
            command.Parameters.AddWithValue("@title", .Title)
            If .Image Is Nothing Then
                command.Parameters.Add("@image", OleDbType.Binary).Value = ImageToByte(My.Resources.question)
            Else
                command.Parameters.Add("@image", OleDbType.Binary).Value = .Image
            End If
            If .Kiosk Is Nothing Then
                command.Parameters.Add("@kiosk", OleDbType.Binary).Value = ImageToByte(My.Resources.questioncanvass)
            Else
                command.Parameters.Add("@kiosk", OleDbType.Binary).Value = .Kiosk
            End If
            command.Parameters.AddWithValue("@description", .Description)
            command.Parameters.AddWithValue("@receipt_description", .ReceiptDescription)
            command.Parameters.AddWithValue("@category", item.CategoryToId(.Category))
            command.Parameters.AddWithValue("@stock", .Stock)
            command.Parameters.AddWithValue("@price", .Price)
            command.ExecuteNonQuery()

            Connection.Close()
        End With
    End Sub

    Sub UpdateItem(item As Item)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        With item
            Dim command As New OleDbCommand("UPDATE tbl_item SET title=?, [image]=?, kiosk=?, description=?, receipt_description=?, category=?, stock=?, price=? " &
                                            "WHERE item_id=?", Connection)

            command.Parameters.AddWithValue("@title", .Title)
            command.Parameters.Add("@image", OleDbType.Binary).Value = .Image
            command.Parameters.Add("@kiosk", OleDbType.Binary).Value = .Kiosk
            command.Parameters.AddWithValue("@description", .Description)
            command.Parameters.AddWithValue("@receipt_description", .ReceiptDescription)
            command.Parameters.AddWithValue("@category", item.CategoryToId(.Category))
            command.Parameters.AddWithValue("@stock", .Stock)
            command.Parameters.AddWithValue("@price", .Price)
            command.Parameters.AddWithValue("@item_id", item.ItemId)
            command.ExecuteNonQuery()
            Connection.Close()
        End With
    End Sub

    Sub DeleteItem(Id As String)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        Dim tbl_user_command As New OleDbCommand("DELETE FROM tbl_item WHERE item_id=?", Connection)

        tbl_user_command.Parameters.AddWithValue("@item_id", Id)
        tbl_user_command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Function GetItemSoldRecords(isQuantity As Boolean) As Dictionary(Of String, Integer)
        If Not Connection.State = ConnectionState.Open Then
            Connection.Open()
        End If
        Dim command As New OleDbCommand
        command.Connection = Connection
        If isQuantity Then
            command.CommandText = "SELECT tbl_item.title, tbl_sold.quantity FROM tbl_item INNER JOIN tbl_sold ON tbl_item.id = tbl_sold.item_id"
        Else
            command.CommandText = "SELECT item_id, SUM(tbl_sold.total_amount) As tSum FROM tbl_sold GROUP BY tbl_sold.item_id"
        End If
        Dim reader As OleDbDataReader = command.ExecuteReader()
        Dim dictionary As New Dictionary(Of String, Integer)
        While reader.Read()
            If isQuantity Then
                Dim title = reader("title")
                If dictionary.ContainsKey(title) Then
                    dictionary.Item(title) += reader("quantity")
                Else
                    dictionary.Add(reader("title"), reader("quantity"))
                End If
            Else
                dictionary.Add(reader("item_id"), reader("tSum"))
            End If
        End While
        Connection.Close()
        Return dictionary
    End Function

End Module
