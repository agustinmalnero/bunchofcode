Public Class Views
    Implements IButtons

    Dim formPanel As System.Windows.Forms.Panel

    Public Sub New(ByRef panel As System.Windows.Forms.Panel)
        InitializeComponent()

        Me.formPanel = panel
    End Sub

    Public Sub buscar() Implements IButtons.buscar

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
        Dim monthView = New MonthView()
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(monthView)
    End Sub

    Private Sub btnWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeek.Click
        Dim weekView = New WeekView()
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(weekView)
    End Sub

    Private Sub btnDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDay.Click
        Dim dayView = New DayView()
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(dayView)
    End Sub

    Public Sub setPanel(ByRef panel As IPaneles) Implements IButtons.setPanel

    End Sub
End Class
