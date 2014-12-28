<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnalytics
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chart
        '
        Me.chart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chart.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI Light", 8.0!)
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Segoe UI Light", 8.0!)
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Segoe UI Light", 8.0!)
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.Transparent
        Me.chart.ChartAreas.Add(ChartArea1)
        Me.chart.Location = New System.Drawing.Point(50, 22)
        Me.chart.Name = "chart"
        Series1.ChartArea = "ChartArea1"
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Name = "Quantity"
        Me.chart.Series.Add(Series1)
        Me.chart.Size = New System.Drawing.Size(686, 256)
        Me.chart.TabIndex = 0
        Me.chart.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Title1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Title1.ForeColor = System.Drawing.Color.White
        Title1.Name = "title1"
        Title1.Text = "Items Sold By Quantity"
        Me.chart.Titles.Add(Title1)
        '
        'Chart1
        '
        Me.Chart1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI Light", 8.0!)
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisX.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Segoe UI Light", 8.0!)
        ChartArea2.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea2.AxisY.IsLabelAutoFit = False
        ChartArea2.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisY.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Segoe UI Light", 8.0!)
        ChartArea2.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea2.BorderColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartArea1"
        ChartArea2.ShadowColor = System.Drawing.Color.Transparent
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Location = New System.Drawing.Point(50, 309)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.CustomProperties = "DrawingStyle=Cylinder"
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Name = "Total Amount"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(686, 256)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        Title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Title2.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Title2.ForeColor = System.Drawing.Color.White
        Title2.Name = "title1"
        Title2.Text = "Items Sold By Total Price"
        Me.Chart1.Titles.Add(Title2)
        '
        'FrmAnalytics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 577)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.chart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAnalytics"
        Me.Text = "FrmAnalytics"
        CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
