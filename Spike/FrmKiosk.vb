Imports MetroFramework

Public Class FrmKiosk
    Dim trueform As Boolean
    Dim itemlist As List(Of Item)
    Dim mParent As Form
    Dim currentImageIndex = 0

    Sub New(isTrueForm As Boolean)
        InitializeComponent()
        trueform = isTrueForm
        If isTrueForm Then
            btnPlay.Hide()
        End If
    End Sub

    Dim formParent As Form
    Dim n As FrmKiosk

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim panel As Panel = Parent
        formParent = panel.Parent
        n = New FrmKiosk(True)
        n.Show()
        formParent.Hide()
        kioskTimer.Start()
    End Sub

    Private Sub FrmKiosk_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If trueform Then
            Close()
            Dim openForms = Application.OpenForms.OfType(Of FrmAdmin)()
            While openForms.Any()
                Dim form = openForms.First
                form.exitKiosk()
                form.Show()
                Exit Sub
            End While
        End If
    End Sub

    Private Sub FrmKiosk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not trueform Then
            mParent = Parent.Parent
        End If
        itemlist = GetItemsWithKiosk()
        If (itemlist.Count = 0) Then
            MetroMessageBox.Show(mParent, "No available item with kiosk image. Please use the inventory to add images.", "Error loading kiosk items", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnPlay.Hide()
        Else
            If trueform Then
                If (itemlist.Count = 1) Then
                    LoadItem(itemlist(0))
                Else
                    LoadItem(itemlist(0))
                    kioskTimer.Start()
                End If
            Else
                LoadItem(itemlist(0))
                btnPlay.Show()
            End If
        End If


    End Sub

    Private Sub kioskTimer_Tick(sender As Object, e As EventArgs) Handles kioskTimer.Tick
        If currentImageIndex < itemlist.Count - 1 Then
            currentImageIndex += 1
            LoadItem(itemlist(currentImageIndex))
        Else
            currentImageIndex = 0
            LoadItem(itemlist(0))
        End If
    End Sub

    Private Sub LoadItem(item As Item)
        imgPanel.BackgroundImage = ByteToImage(item.Kiosk, My.Resources.questioncanvass)
        lblDescription.Text = item.Description
        lblTitle.Text = item.Title
        lblPrice.Text = "₱" & item.Price
        lblDescription.Show()
    End Sub
End Class