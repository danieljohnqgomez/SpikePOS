Imports MetroFramework

Public Class FrmLogin

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Try

            Dim username As String = tbUsername.Text
            Dim password As String = tbPassword.Text
            Dim errorMessage As String = ""
            Dim preValidated As Boolean = True
            Dim usernameEmpty = String.IsNullOrEmpty(username.Trim())
            If (usernameEmpty) Then
                pbUsernameError.Show()
                ttUsernameError.SetToolTip(pbUsernameError, My.Resources.StrEmptyUsername)
                errorMessage = My.Resources.StrEmptyUsername
                preValidated = False
            Else
                pbUsernameError.Hide()
            End If
            If (String.IsNullOrEmpty(password.Trim())) Then
                pbPasswordError.Show()
                ttPasswordError.SetToolTip(pbPasswordError, "Password can't be empty")
                If usernameEmpty Then
                    errorMessage += vbCrLf & My.Resources.StrEmptyPassword
                Else
                    errorMessage = My.Resources.StrEmptyPassword
                End If
                preValidated = False
            Else
                pbPasswordError.Hide()
            End If

            If (Not preValidated) Then
                MetroMessageBox.Show(Me, errorMessage, My.Resources.StrUsernameNotFound, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Dim postValidated As Boolean = IsCorrectPassword(username, password)
                    If postValidated Then
                        CurrentUser = GetUserByFieldName(username, User.FieldNames.Username)
                        If CurrentUser.Status = User.AccountStatus.Disabled Then
                            MetroMessageBox.Show(Me, "Sorry, your account is currently disabled.", My.Resources.Failed, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ElseIf CurrentUser.Status = User.AccountStatus.Inactive Then
                            CurrentUser.Status = User.AccountStatus.Active
                            UpdateUser(CurrentUser)
                            MetroMessageBox.Show(Me, "It has been a long time. Pleasure to have you back!", "Welcome back " & CurrentUser.FirstName & "!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            FrmAdmin.Show()
                            Close()
                        Else
                            FrmAdmin.Show()
                            Close()
                        End If
                    Else
                        pbPasswordError.Show()
                        ttPasswordError.SetToolTip(pbPasswordError, My.Resources.StrIncorrectPassword)
                        MetroMessageBox.Show(Me, My.Resources.StrIncorrectPassword, My.Resources.Failed, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        pbUsernameError.Hide()
                    End If
                Catch ex As UsernameNotFoundException
                    pbUsernameError.Show()
                    ttUsernameError.SetToolTip(pbUsernameError, My.Resources.StrUsernameNotFound)
                    MetroMessageBox.Show(Me, My.Resources.StrUsernameNotFound, My.Resources.Failed, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    pbPasswordError.Hide()
                End Try
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
