Public Class FrmAnalytics

    Private Sub FrmAnalytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qData = GetItemSoldRecords(True)
        Dim aData = GetItemSoldRecords(False)
        For Each title As String In qData.Keys
            chart.Series("Quantity").Points.AddXY(title, qData(title))
        Next
        For Each title As String In aData.Keys
            Chart1.Series("Total Amount").Points.AddXY(title, aData(title))
        Next

        For i As Integer = 0 To Chart1.Series(0).Points.Count - 1
            Chart1.Series(0).Points(i).AxisLabel = qData.Keys(i)
            Chart1.Series(0).Points(i).LabelForeColor = Color.White
        Next
    End Sub
End Class