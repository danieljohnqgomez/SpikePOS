
Imports System.Windows.Forms
Imports MetroFramework


Public Class FrmAdmin
    Dim currentForm As Form
    Dim menus() As Label

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            menus = {lblCounter, lblInventory, lblKiosk, lblAbout, lblAnalytics, lblEmployees}
            tClock.Start()
            lblCounter_Click(lblCounter, Nothing) 'Default selected menu
            lblName.Text = String.Format("{0} {1}", CurrentUser.FirstName, CurrentUser.LastName)
            lblAccountType.Text = CurrentUser.Type

            If (CurrentUser.ImageBytes Is Nothing) Then
                pbUser.Image = My.Resources.imgUserDefault
                UpdatePictureByUsername(CurrentUser.Username, pbUser.Image)
            Else
                pbUser.Image = ByteToImage(CurrentUser.ImageBytes, My.Resources.imgUserDefault)
            End If
            lblEdit.Refresh()
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pbUser_Click(sender As Object, e As EventArgs) Handles pbUser.Click, lblEdit.Click
        Try
            If ofdPicture.ShowDialog() = DialogResult.OK Then
                pbUser.Image = Image.FromFile(ofdPicture.FileName)
                UpdatePictureByUsername(CurrentUser.Username, pbUser.Image)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub lblSignOut_Click(sender As Object, e As EventArgs) Handles lblSignOut.Click
    

        Dim result = MetroMessageBox.Show(Me, "Are you sure you want to sign out?", "Sign out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If (result = DialogResult.Yes) Then
            CurrentUser() = Nothing
            FrmLogin.Show()
            Close()
        End If

    End Sub

    Private Sub FrmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Modifiers = Keys.Control And e.KeyCode = Keys.S Then
            lblSignOut_Click(lblSignOut, Nothing)
        End If
    End Sub

    Private Sub tClock_Tick(sender As Object, e As EventArgs) Handles tClock.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm tt")
        lblDate.Text = DateTime.Now.ToLongDateString()
    End Sub


    Private Sub pContainer_Resize(sender As Object, e As EventArgs) Handles pContainer.Resize
        If currentForm IsNot Nothing Then
            currentForm.Size = pContainer.Size
        End If
    End Sub

    Private Sub About(sender As Object, e As EventArgs) Handles lblAbout.Click, pbAbout.Click
        SetMenuSelected(lblAbout)
        currentForm = New FrmAbout
        ShowFormOnContainer(currentForm)
    End Sub

    Sub ShowFormOnContainer(form As Form)
        With form
            .TopLevel = False
            .AutoSize = False
        End With
        pContainer.Controls.Clear()
        pContainer.Controls.Add(form)
        currentForm.Location = New Point(0, 0)
        currentForm.Size = pContainer.Size
        currentForm.Show()
    End Sub

    Sub SetMenuSelected(label As Label)
        For Each m In menus
            m.ForeColor = Color.White
            m.Font = New Font("Segoe UI Light", 19)
        Next
        label.ForeColor = Color.FromArgb(0, 174, 219)
        label.Font = New Font("Segoe UI Light", 22)
    End Sub

    Private Sub lblCounter_Click(sender As Object, e As EventArgs) Handles lblCounter.Click, pbCounter.Click
        SetMenuSelected(lblCounter)
        currentForm = New FrmCounter
        ShowFormOnContainer(currentForm)
    End Sub

    Private Sub lblKiosk_Click(sender As Object, e As EventArgs) Handles lblKiosk.Click, pbKiosk.Click
        SetMenuSelected(lblKiosk)
        Dim kiosk = New FrmKiosk(False)
        currentForm = kiosk
        ShowFormOnContainer(currentForm)
    End Sub

    Private Sub lblAnalytics_Click(sender As Object, e As EventArgs) Handles lblAnalytics.Click, pbAnalytics.Click
        SetMenuSelected(lblAnalytics)
        currentForm = New FrmAnalytics()
        ShowFormOnContainer(currentForm)
    End Sub

    Private Sub lblInventory_Click(sender As Object, e As EventArgs) Handles lblInventory.Click, pbInventory.Click
        SetMenuSelected(lblInventory)
        currentForm = New FrmInventory()
        ShowFormOnContainer(currentForm)
    End Sub

    Private Sub lblEmployees_Click(sender As Object, e As EventArgs) Handles lblEmployees.Click, pbEmployees.Click
        SetMenuSelected(lblEmployees)
        currentForm = New FrmUsers
        ShowFormOnContainer(currentForm)
    End Sub
 
    Private Sub FrmAdmin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If currentForm IsNot Nothing Then
            currentForm.Location = New Point(0, 0)
            currentForm.Size = pContainer.Size
        End If
    End Sub

    Public Sub exitKiosk()
        lblKiosk_Click(Nothing, Nothing)
    End Sub

End Class