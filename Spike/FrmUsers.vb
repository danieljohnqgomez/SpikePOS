
Imports System.Windows
Imports System.Windows.Controls
Imports MetroFramework

Public Class FrmUsers

    'Used to fix MetroFramework design bug
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const FIXED = 0

    Dim AllListBox As PersonListBox
    Dim AdminListBox As PersonListBox
    Dim UserListBox As PersonListBox

    Dim userList As New List(Of User)
    Dim currentOperation As Integer = -1

    Const ADD_OPERATION = 0
    Const EDIT_OPERATION = 1
    Dim pForm As Form

    Private Sub FixMetroFrameworkBug(listControl As Control)
        If listControl.Tag Is Nothing Then
            Dim originalPosition As System.Drawing.Point = Cursor.Position
            Cursor.Position = New System.Drawing.Point(950, 230)
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


    Function GetUsersByType(type As String) As List(Of User)
        Dim list As New List(Of User)
        For Each user In userList
            If type Is Nothing Then
                list.Add(user)
            ElseIf user.Type = type.ToString() Then
                list.Add(user)
            End If
        Next
        Return list
    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddOperation()
        PersonDetailView1.setUser(New User())
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Try
            If ValidateInputs() Then
                PersonDetailView1.isEnabled(False)
                MetroTabControl2.Visible = True
                btnAdd.Visible = True
                btnDone.Visible = False
                btnCancel.Visible = False
                btnEdit.Visible = False
                btnDelete.Visible = False
                Dim user As User = PersonDetailView1.getUser()
                If currentOperation = ADD_OPERATION Then
                    AddUser(user)
                    MetroMessageBox.Show(pForm, user.FirstName & " " & user.LastName & " was added successfully.", "Adding Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PersonDetailView1.setUser(New User())
                Else
                    UpdateUser(user)
                    MetroMessageBox.Show(pForm, "User record was updated successfully.", "Updating Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                MetroTabControl2.SelectedIndex = 0
                AllListLoaded()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(pForm, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim user As User = PersonDetailView1.getUser()
        Dim errorMessage As String = ""

        If String.IsNullOrWhiteSpace(user.Username) Then
            errorMessage = "Username is empty"
        ElseIf String.IsNullOrWhiteSpace(user.Password) Then
            errorMessage = "Password is empty"
        ElseIf String.IsNullOrWhiteSpace(user.FirstName) Then
            errorMessage = "First name is empty"
        ElseIf String.IsNullOrWhiteSpace(user.LastName) Then
            errorMessage = "Last name is empty"
        ElseIf String.IsNullOrWhiteSpace(user.Address) Then
            errorMessage = "Address is empty"
        ElseIf Not StringTools.IsValidDate(user.DateOfBirth) Then
            errorMessage = "Date is invalid"
        End If

        If String.IsNullOrEmpty(errorMessage) Then
            Return True
        Else
            MetroMessageBox.Show(pForm, errorMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MetroTabControl2.Visible = True
        PersonDetailView1.isEnabled(False)
        PersonDetailView1.setUser(New User())
        btnAdd.Show()
        btnDone.Hide()
        btnCancel.Hide()
        btnEdit.Hide()
        btnDelete.Hide()
    End Sub


    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PersonDetailView1.isEnabled(False)
        AllListBox = New PersonListBox
        AddHandler AllListBox.SelectionChanged, AddressOf AllListSelectionChanged
        AddHandler AllListBox.Loaded, AddressOf AllListLoaded
        elementHostAll.Child = AllListBox

        AdminListBox = New PersonListBox
        AddHandler AdminListBox.SelectionChanged, AddressOf AdminListSelectionChanged
        AddHandler AdminListBox.Loaded, AddressOf AdminListLoaded
        elementHostAdmin.Child = AdminListBox

        UserListBox = New PersonListBox
        AddHandler UserListBox.SelectionChanged, AddressOf UserListSelectionChanged
        AddHandler UserListBox.Loaded, AddressOf UserListLoaded
        elementHostUser.Child = UserListBox

        pForm = ParentForm

        AddHandler PersonDetailView1.PictureClick, AddressOf PictureClick

    End Sub


    Private Sub MetroTabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl2.SelectedIndexChanged
        PersonDetailView1.setUser(New User())
        AllListBox.ClearSelection()
        AdminListBox.ClearSelection()
        UserListBox.ClearSelection()
        btnEdit.Visible = False
        btnDelete.Visible = False
        btnAdd.Visible = True
    End Sub

    Private Sub AllListSelectionChanged()
        If (AllListBox.selectedIndex < 0) Then
            PersonDetailView1.setUser(New User())
            btnEdit.Hide()
            btnDelete.Hide()
            btnAdd.Show()
        Else
            btnEdit.Show()
            btnDelete.Show()
            btnAdd.Show()
            PersonDetailView1.setUser(userList(AllListBox.selectedIndex))
        End If
    End Sub

    Private Sub AllListLoaded()
        userList = GetAllUsers()
        AllListBox.Clear()
        AllListBox.AddItemRange(userList)
        FixMetroFrameworkBug(AllListBox)
    End Sub

    Private Sub AdminListSelectionChanged()
        If (AdminListBox.selectedIndex < 0) Then
            PersonDetailView1.setUser(New User())
            btnEdit.Hide()
            btnDelete.Hide()
            btnAdd.Show()
        Else
            btnEdit.Show()
            btnDelete.Show()
            btnAdd.Show()
            PersonDetailView1.setUser(GetUsersByType(User.AccountType.Admin)((AdminListBox.selectedIndex)))
        End If
    End Sub

    Private Sub AdminListLoaded()
        AdminListBox.Clear()
        AdminListBox.AddItemRange(GetUsersByType(User.AccountType.Admin))
        FixMetroFrameworkBug(AdminListBox)
    End Sub

    Private Sub UserListSelectionChanged()
        If (UserListBox.selectedIndex < 0) Then
            PersonDetailView1.setUser(New User())
            btnEdit.Hide()
            btnDelete.Hide()
            btnAdd.Show()
        Else
            btnEdit.Show()
            btnDelete.Show()
            btnAdd.Show()
            PersonDetailView1.setUser(GetUsersByType(User.AccountType.User)((UserListBox.selectedIndex)))
        End If
    End Sub

    Private Sub UserListLoaded()
        UserListBox.Clear()
        UserListBox.AddItemRange(GetUsersByType(User.AccountType.User))
        FixMetroFrameworkBug(UserListBox)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim current As PersonListBox = GetCurrentListBox(MetroTabControl2.SelectedIndex())
        Dim currentUser As User
        If current.Equals(AllListBox) Then
            currentUser = userList(current.selectedIndex)
        ElseIf current.Equals(UserListBox) Then
            currentUser = GetUsersByType(User.AccountType.User)((current.selectedIndex))
        Else
            currentUser = GetUsersByType(User.AccountType.Admin)((current.selectedIndex))
        End If
        If (currentUser.Id = DatabaseModule.CurrentUser.Id) Then
            Dim result = MetroMessageBox.Show(pForm, "You are editing your own account, some changes will only take effect after relogging in. Do you want to proceed? ", "Editing Current Account", MessageBoxButton.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                EditOperation()
            End If
        Else
            EditOperation()
        End If

    End Sub

    Private Function GetCurrentListBox(tabIndex As Integer) As PersonListBox
        If (tabIndex = 0) Then
            Return AllListBox
        ElseIf tabIndex = 1 Then
            Return AdminListBox
        Else
            Return UserListBox
        End If
    End Function

    Private Sub EditOperation()
        btnDone.Show()
        btnCancel.Show()

        btnEdit.Hide()
        btnAdd.Hide()
        MetroTabControl2.Hide()
        btnDelete.Hide()
        PersonDetailView1.isEnabled(True)
        currentOperation = EDIT_OPERATION
    End Sub

    Private Sub AddOperation()
        EditOperation()
        currentOperation = ADD_OPERATION
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            Dim current As PersonListBox = GetCurrentListBox(MetroTabControl2.SelectedIndex())
            Dim currentUser As User
            If current.Equals(AllListBox) Then
                currentUser = userList(current.selectedIndex)
            ElseIf current.Equals(UserListBox) Then
                currentUser = GetUsersByType(User.AccountType.User)((current.selectedIndex))
            Else
                currentUser = GetUsersByType(User.AccountType.Admin)((current.selectedIndex))
            End If

            If currentUser.Id = DatabaseModule.CurrentUser.Id Then
                MetroFramework.MetroMessageBox.Show(pForm, "You cannot delete a currently logged in account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim result = MetroFramework.MetroMessageBox.Show(pForm, "Are you sure you want to delete " & currentUser.FullName & "?", "Delete User", MessageBoxButton.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                DeleteUser(currentUser.Id)
                MetroFramework.MetroMessageBox.Show(pForm, "User record was deleted successfully.", "Deleting Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PersonDetailView1.isEnabled(False)
                MetroTabControl2.Visible = True
                btnAdd.Visible = True
                btnDone.Visible = False
                btnCancel.Visible = False
                btnEdit.Visible = False
                btnDelete.Visible = False
                PersonDetailView1.setUser(New User())
                MetroTabControl2.SelectedIndex = 0
                AllListLoaded()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(pForm, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureClick()
        Try
            If ofdImage.ShowDialog() = DialogResult.OK Then
                PersonDetailView1.setImage(System.Drawing.Image.FromFile(ofdImage.FileName))
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class