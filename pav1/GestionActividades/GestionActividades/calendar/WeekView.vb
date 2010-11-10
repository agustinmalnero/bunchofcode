Public Class WeekView

    Public Sub New(ByRef data As Data.DataTable)
        InitializeComponent()

        Dim c As Integer

        Me.table.Rows.Clear()
        If data.Rows.Count > 0 Then
            Me.table.Columns.Item(3).HeaderText = "Monday"
            Me.table.Columns.Item(4).HeaderText = "Tuesday"
            Me.table.Columns.Item(5).HeaderText = "Wednesday"
            Me.table.Columns.Item(6).HeaderText = "Thursday"
            Me.table.Columns.Item(7).HeaderText = "Friday"
            Me.table.Columns.Item(8).HeaderText = "Saturday"
        End If

        For c = 0 To data.Rows.Count() - 1
            Dim fecha As Date
            fecha = data.Rows(c)("inicio")
            If fecha.DayOfWeek = DayOfWeek.Sunday Then
                Me.table.Rows.Add(data.Rows(c)("id"), Format(data.Rows(c)("inicio"), "h:mm:ss"), _
                              data.Rows(c)("nombre").ToString().Trim() _
                                    & ", " & data.Rows(c)("descripcion"), "", "", "", "", "", "")
            ElseIf fecha.DayOfWeek = DayOfWeek.Monday Then
                Me.table.Rows.Add(data.Rows(c)("id"), Format(data.Rows(c)("inicio"), "h:mm:ss"), _
                              "", data.Rows(c)("nombre").ToString().Trim() _
                                    & ", " & data.Rows(c)("descripcion"), "", "", "", "", "")
            ElseIf fecha.DayOfWeek = DayOfWeek.Tuesday Then
                Me.table.Rows.Add(data.Rows(c)("id"), Format(data.Rows(c)("inicio"), "h:mm:ss"), _
                              "", "", data.Rows(c)("nombre").ToString().Trim() _
                                    & ", " & data.Rows(c)("descripcion"), "", "", "", "")
            ElseIf fecha.DayOfWeek = DayOfWeek.Wednesday Then
                Me.table.Rows.Add(data.Rows(c)("id"), Format(data.Rows(c)("inicio"), "h:mm:ss"), _
                              "", "", "", data.Rows(c)("nombre").ToString().Trim() _
                                    & ", " & data.Rows(c)("descripcion"), "", "", "")
            ElseIf fecha.DayOfWeek = DayOfWeek.Thursday Then
                Me.table.Rows.Add(data.Rows(c)("id"), Format(data.Rows(c)("inicio"), "h:mm:ss"), _
                              "", "", "", "", data.Rows(c)("nombre").ToString().Trim() _
                                    & ", " & data.Rows(c)("descripcion"), "", "")
            ElseIf fecha.DayOfWeek = DayOfWeek.Friday Then
                Me.table.Rows.Add(data.Rows(c)("id"), Format(data.Rows(c)("inicio"), "h:mm:ss"), _
                              "", "", "", "", "", data.Rows(c)("nombre").ToString().Trim() _
                                    & ", " & data.Rows(c)("descripcion"), "")
            ElseIf fecha.DayOfWeek = DayOfWeek.Saturday Then
                Me.table.Rows.Add(data.Rows(c)("id"), Format(data.Rows(c)("inicio"), "h:mm:ss"), _
                              "", "", "", "", "", "", data.Rows(c)("nombre").ToString().Trim() _
                                    & ", " & data.Rows(c)("descripcion"))
            End If
        Next

    End Sub
End Class
