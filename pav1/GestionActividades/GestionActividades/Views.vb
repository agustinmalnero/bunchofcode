Public Class Views
    Implements IButtons

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess

    Public Sub New(ByRef panel As System.Windows.Forms.Panel, ByRef access As DataAccess)
        InitializeComponent()
        Me._access = access
        Me.formPanel = panel
    End Sub

    Public Sub modificar() Implements IButtons.modificar

    End Sub

    Public Sub dia() Implements IButtons.dia

    End Sub

    Public Sub eliminar() Implements IButtons.eliminar

    End Sub

    Public Sub guardar() Implements IButtons.guardar

    End Sub

    Public Sub mes() Implements IButtons.mes

    End Sub

    Public Sub nuevo() Implements IButtons.nuevo

    End Sub

    Public Sub semana() Implements IButtons.semana

    End Sub

    Private Sub btnMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonth.Click
        Dim s = "SELECT * FROM actividad WHERE DATEPART(month, inicio) = DATEPART(month, GETDATE()) AND " & _
                "DATEPART(year, inicio) = DATEPART(year, GETDATE()) AND DATEPART(week, inicio) = DATEPART(week, GETDATE()) - 1" & _
                "ORDER BY inicio"
        Dim table = Me._access.buscar(s)
        Dim weekView = New WeekView(table)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(weekView)
    End Sub

    Public Function obtainMonth() As WeekView
        Dim s = "SELECT * FROM actividad WHERE DATEPART(month, inicio) = DATEPART(month, GETDATE()) AND " & _
                "DATEPART(year, inicio) = DATEPART(year, GETDATE()) AND DATEPART(week, inicio) = DATEPART(week, GETDATE()) " & _
                "ORDER BY inicio"
        Dim table = Me._access.buscar(s)
        Dim weekView = New WeekView(table)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(weekView)
        Return weekView
    End Function

    Private Sub btnWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeek.Click
        Dim s = "SELECT * FROM actividad WHERE DATEPART(month, inicio) = DATEPART(month, GETDATE()) AND " & _
                "DATEPART(year, inicio) = DATEPART(year, GETDATE()) AND DATEPART(week, inicio) = DATEPART(week, GETDATE()) " & _
                "ORDER BY inicio"
        Dim table = Me._access.buscar(s)
        Dim weekView = New WeekView(table)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(weekView)
    End Sub

    Private Sub btnDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDay.Click
        Dim s = "SELECT * FROM actividad WHERE DATEPART(month, inicio) = DATEPART(month, GETDATE()) AND " & _
                "DATEPART(year, inicio) = DATEPART(year, GETDATE()) AND DATEPART(day, inicio) = DATEPART(day, GETDATE()) " & _
                "ORDER BY inicio"
        Dim table = Me._access.buscar(s)
        Dim dayView = New DayView(table)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(dayView)
    End Sub

    Public Sub setPanel(ByRef panel As IPaneles) Implements IButtons.setPanel

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s = "SELECT * FROM actividad WHERE DATEPART(month, inicio) = DATEPART(month, GETDATE()) AND " & _
                "DATEPART(year, inicio) = DATEPART(year, GETDATE()) AND DATEPART(week, inicio) = DATEPART(week, GETDATE()) + 1" & _
                "ORDER BY inicio"
        Dim table = Me._access.buscar(s)
        Dim weekView = New WeekView(table)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(weekView)
    End Sub
End Class
