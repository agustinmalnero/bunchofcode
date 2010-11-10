Public Class PanelTareas

    Public Sub New(ByRef access As DataAccess)
        InitializeComponent()

        Dim s = "SELECT * FROM actividad WHERE DATEPART(month, inicio) = DATEPART(month, GETDATE()) AND " & _
                "DATEPART(year, inicio) = DATEPART(year, GETDATE()) AND DATEPART(week, inicio) = DATEPART(week, GETDATE()) " & _
                "ORDER BY inicio"
        Dim data = access.buscar(s)

        For c = 0 To data.Rows.Count() - 1
            Dim fecha As Date
            fecha = data.Rows(c)("inicio")
            If fecha.DayOfWeek = DayOfWeek.Sunday Then
                Me.tree.Nodes(6).Nodes.Add(data.Rows(c)("nombre").ToString().Trim())
            ElseIf fecha.DayOfWeek = DayOfWeek.Monday Then
                Me.tree.Nodes(0).Nodes.Add(data.Rows(c)("nombre").ToString().Trim())
            ElseIf fecha.DayOfWeek = DayOfWeek.Tuesday Then
                Me.tree.Nodes(1).Nodes.Add(data.Rows(c)("nombre").ToString().Trim())
            ElseIf fecha.DayOfWeek = DayOfWeek.Wednesday Then
                Me.tree.Nodes(2).Nodes.Add(data.Rows(c)("nombre").ToString().Trim())
            ElseIf fecha.DayOfWeek = DayOfWeek.Thursday Then
                Me.tree.Nodes(3).Nodes.Add(data.Rows(c)("nombre").ToString().Trim())
            ElseIf fecha.DayOfWeek = DayOfWeek.Friday Then
                Me.tree.Nodes(4).Nodes.Add(data.Rows(c)("nombre").ToString().Trim())
            ElseIf fecha.DayOfWeek = DayOfWeek.Saturday Then
                Me.tree.Nodes(5).Nodes.Add(data.Rows(c)("nombre").ToString().Trim())
            End If
        Next


    End Sub
End Class
