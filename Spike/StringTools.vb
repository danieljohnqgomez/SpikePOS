Imports System.Text

Public Class StringTools
    Shared Function FormatDate(d As String) As String
        Dim builder As New StringBuilder
        Dim splitted As String() = d.Split("/")
        For Each d In splitted
            If (d.Length = 1) Then
                builder.Append("0" & d)
            Else
                builder.Append(d)
            End If
            builder.Append("/")
        Next

        Return builder.Remove(builder.Length - 1, 1).ToString()
    End Function

    Shared Function IsValidDate(d As String) As Boolean
        Try
            If String.IsNullOrWhiteSpace(d) Then
                Return False
            Else
                Dim splitted As String() = d.Split("/")
                Dim month = splitted(0)
                Dim day = splitted(1)
                Dim year = splitted(2)
                Dim time As DateTime = DateTime.Now
                Return (InRange(month, 1, 12) And InRange(day, 1, 31) And InRange(year, 1800, time.Year))
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function InRange(i As Integer, lowerBound As Integer, upperBound As Integer) As Boolean
        Return (i >= lowerBound And i <= upperBound)
    End Function
End Class
