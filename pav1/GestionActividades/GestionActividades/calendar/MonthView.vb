Public Class MonthView

    Public Sub New(ByRef data As Data.DataTable)
        InitializeComponent()

        Dim c As Integer
        For i = 1 To 31
            For c = 0 To data.Rows.Count() - 1
                Dim fecha As Date
                fecha = data.Rows(c)("inicio")

                Dim actividad = ""
                If fecha.Day = i Then
                    actividad = data.Rows(c)("nombre").ToString().Trim() & "\n"
                End If
                If fecha.DayOfWeek = DayOfWeek.Sunday Then
                    Me.table.Rows.Add(actividad, "", "", "", "", "", "")
                ElseIf fecha.DayOfWeek = DayOfWeek.Monday Then
                    Me.table.Rows.Add("", actividad, "", "", "", "", "")
                ElseIf fecha.DayOfWeek = DayOfWeek.Tuesday Then
                    Me.table.Rows.Add("", "", actividad, "", "", "", "")
                ElseIf fecha.DayOfWeek = DayOfWeek.Wednesday Then
                    Me.table.Rows.Add("", "", "", actividad, "", "", "")
                ElseIf fecha.DayOfWeek = DayOfWeek.Thursday Then
                    Me.table.Rows.Add("", "", "", "", actividad, "", "")
                ElseIf fecha.DayOfWeek = DayOfWeek.Friday Then
                    Me.table.Rows.Add("", "", "", "", "", actividad, "")
                ElseIf fecha.DayOfWeek = DayOfWeek.Saturday Then
                    Me.table.Rows.Add("", "", "", "", "", "", actividad)
                End If
            Next
        Next

    End Sub
End Class
