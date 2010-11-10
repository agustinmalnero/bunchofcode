Public Class DayView

    Public Sub New(ByRef data As Data.DataTable)
        InitializeComponent()

        Dim c As Integer

        Me.table.Rows.Clear()
        If data.Rows.Count > 0 Then
            Me.table.Columns.Item(2).HeaderText = Format(data.Rows(0)("inicio"), "yyyy-MM-dd")
        End If

        For c = 0 To data.Rows.Count() - 1
            Me.table.Rows.Add(data.Rows(c)("id"), Format(data.Rows(c)("inicio"), "h:mm:ss"), _
                              data.Rows(c)("nombre").ToString().Trim() _
                                    & ", " & data.Rows(c)("descripcion"))
        Next

    End Sub
End Class
