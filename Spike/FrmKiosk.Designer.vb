<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKiosk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.imgPanel = New System.Windows.Forms.Panel()
        Me.btnPlay = New MetroFramework.Controls.MetroButton()
        Me.kioskTimer = New System.Windows.Forms.Timer(Me.components)
        Me.imgPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(-4, 430)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(827, 67)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDescription.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Light", 24.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(21, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(301, 55)
        Me.lblTitle.TabIndex = 2
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI Light", 24.0!)
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(700, 22)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 45)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'imgPanel
        '
        Me.imgPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPanel.BackColor = System.Drawing.Color.Transparent
        Me.imgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgPanel.Controls.Add(Me.lblDescription)
        Me.imgPanel.Location = New System.Drawing.Point(1, 96)
        Me.imgPanel.Name = "imgPanel"
        Me.imgPanel.Size = New System.Drawing.Size(823, 497)
        Me.imgPanel.TabIndex = 4
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(352, 38)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(89, 26)
        Me.btnPlay.TabIndex = 5
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseSelectable = True
        Me.btnPlay.Visible = False
        '
        'kioskTimer
        '
        Me.kioskTimer.Interval = 3000
        '
        'FrmKiosk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(826, 594)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.imgPanel)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmKiosk"
        Me.Text = "FrmKiosk"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.imgPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents imgPanel As System.Windows.Forms.Panel
    Friend WithEvents btnPlay As MetroFramework.Controls.MetroButton
    Friend WithEvents kioskTimer As System.Windows.Forms.Timer
End Class
