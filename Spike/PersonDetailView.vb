Public Class PersonDetailView
    Dim currentUser As New User
    Public Event PictureClick()

    Public Sub setUser(ByVal value As User)
        currentUser = value
        With currentUser
            setUsername(.Username)
            setPassword(.Password)
            setFirstName(.FirstName)
            setMiddleName(.MiddleName)
            setLastName(.LastName)
            setGender(.Gender)
            setAccountType(.Type)
            setAccountStatus(.Status)
            setAddress(.Address)
            setDateOfBirth(.DateOfBirth)
            setImage(ByteToImage(.ImageBytes, My.Resources.imgUserDefault))
        End With
    End Sub

    Public Function getUser() As User
        Return currentUser
    End Function

    Public Sub setUsername(ByVal value As String)
        tbUsername.Text = value
        currentUser.Username = value
    End Sub

    Public Function getUsername() As String
        Return tbUsername.Text
    End Function

    Public Sub setPassword(ByVal value As String)
        tbPassword.Text = value
        currentUser.Password = value
    End Sub

    Public Function getPassword() As String
        Return tbPassword.Text
    End Function

    Public Sub setFirstName(ByVal value As String)
        tbFirstName.Text = value
        currentUser.FirstName = value
    End Sub

    Public Function getFirstName() As String
        Return tbFirstName.Text
    End Function

    Public Sub setMiddleName(ByVal value As String)
        tbMiddleName.Text = value
        currentUser.MiddleName = value
    End Sub

    Public Function getMiddleName() As String
        Return tbMiddleName.Text
    End Function

    Public Sub setLastName(ByVal value As String)
        tbLastName.Text = value
        currentUser.LastName = value
    End Sub

    Public Function getLastName() As String
        Return tbLastName.Text
    End Function

    Public Sub setGender(ByVal value As String)
        If (value = User.AccountGender.Male) Then
            cbGender.SelectedIndex = 0
        Else
            cbGender.SelectedIndex = 1
        End If
        currentUser.Gender = value
    End Sub

    Public Function getGender() As String
        Return cbGender.SelectedItem
    End Function

    Public Sub setAccountType(ByVal value As String)
        If (value = User.AccountType.Admin) Then
            cbAccountType.SelectedIndex = 0
        Else
            cbAccountType.SelectedIndex = 1
        End If
        currentUser.Type = value
    End Sub

    Public Function getAccountType() As String
        Return cbAccountType.SelectedItem
    End Function

    Public Sub setAccountStatus(ByVal value As String)
        If (value = User.AccountStatus.Active) Then
            cbAccountStatus.SelectedIndex = 0
        ElseIf (value.ToString() = User.AccountStatus.Inactive) Then
            cbAccountStatus.SelectedIndex = 1
        Else
            cbAccountStatus.SelectedIndex = 2
        End If
        currentUser.Status = value
    End Sub

    Public Function getAccountStatus() As String
        Return cbAccountStatus.SelectedItem
    End Function

    Public Sub setAddress(ByVal value As String)
        tbAddress.Text = value
        currentUser.Address = value
    End Sub

    Public Function getAdress() As String
        Return tbAddress.Text
    End Function

    Public Sub setDateOfBirth(ByVal value As String)
        tbDoB.Text = value
        currentUser.DateOfBirth = value
    End Sub

    Public Function getDateOfBirth() As String
        Return tbDoB.Text
    End Function

    Public Sub setImage(ByVal value As Image)
        pbPicture.Image = value
        Dim converter As New ImageConverter
        currentUser.ImageBytes = converter.ConvertTo(value, GetType(Byte()))
    End Sub

    Public Function getImage() As Image
        Return pbPicture.Image
    End Function

    Private Sub pbEye_MouseDown(sender As Object, e As MouseEventArgs) Handles pbEye.MouseDown
        pbEye.Image = My.Resources.openeye
        tbPassword.PasswordChar = vbNullChar
    End Sub

    Private Sub pbEye_MouseUp(sender As Object, e As MouseEventArgs) Handles pbEye.MouseUp
        tbPassword.PasswordChar = "*"
        pbEye.Image = My.Resources.closedeye

    End Sub

    Public Sub isEnabled(bool As Boolean)
        UserPanel.Enabled = bool
    End Sub

    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged
        currentUser.Username = tbUsername.Text
    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        currentUser.Password = tbPassword.Text
    End Sub

    Private Sub tbFirstName_TextChanged(sender As Object, e As EventArgs) Handles tbFirstName.TextChanged
        currentUser.FirstName = tbFirstName.Text
    End Sub

    Private Sub tbMiddleName_TextChanged(sender As Object, e As EventArgs) Handles tbMiddleName.TextChanged
        currentUser.MiddleName = tbMiddleName.Text
    End Sub

    Private Sub tbLastName_TextChanged(sender As Object, e As EventArgs) Handles tbLastName.TextChanged
        currentUser.LastName = tbLastName.Text
    End Sub

    Private Sub cbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGender.SelectedIndexChanged
        currentUser.Gender = cbGender.SelectedItem
    End Sub

    Private Sub cbAccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAccountType.SelectedIndexChanged
        currentUser.Type = cbAccountType.SelectedItem
    End Sub

    Private Sub cbAccountStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAccountStatus.SelectedIndexChanged
        currentUser.Status = cbAccountStatus.SelectedItem
    End Sub

    Private Sub tbAddress_TextChanged(sender As Object, e As EventArgs) Handles tbAddress.TextChanged
        currentUser.Address = tbAddress.Text
    End Sub

    Private Sub tbDoB_TextChanged(sender As Object, e As EventArgs) Handles tbDoB.TextChanged
        currentUser.DateOfBirth = tbDoB.Text
    End Sub


    Private Sub pbPicture_Click(sender As Object, e As EventArgs) Handles pbPicture.Click
        RaiseEvent PictureClick()
    End Sub

End Class
