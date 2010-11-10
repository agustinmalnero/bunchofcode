Public Class PanelAcciones

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess
    Dim ipanel As IPaneles
    Dim buttonsPanel As System.Windows.Forms.Panel
    Dim buttons As Controls
    Dim usuario As Usuario

    Public Sub New(ByRef panel As System.Windows.Forms.Panel, _
                   ByRef buttons As System.Windows.Forms.Panel, ByRef access As DataAccess)
        InitializeComponent()
        _access = access
        Me.formPanel = panel
        Me.buttonsPanel = buttons
        Me.buttons = New Controls(_access)
    End Sub

    Public Sub setUser(ByRef user As Usuario)
        Me.usuario = user
    End Sub

    Private Sub btnActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActividad.Click
        Dim panelActividad = New PanelActividad(Me.formPanel, _access, Me.buttons, Me.usuario)
        Me.ipanel = panelActividad
        Dim query = Me.ipanel.buscar()
        Dim data = Me._access.buscar(query)
        Me.ipanel.loadTable(data)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(panelActividad)
        panelActividad.txt_nombre.Focus()

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
    End Sub

    Private Sub btnReunion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReunion.Click
        Dim panelReunion = New PanelReunion(Me.formPanel, _access, Me.usuario)
        Me.ipanel = panelReunion
        Dim query = Me.ipanel.buscar()
        Dim data = Me._access.buscar(query)
        Me.ipanel.loadTable(data)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(panelReunion)
        panelReunion.cb_actividad.Focus()

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
    End Sub

    Private Sub btnPlanificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanificar.Click
        Me.formPanel.Controls.Clear()
    End Sub

    Private Sub btnContactos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContactos.Click
        Dim panelContacto = New PanelContacto(Me.formPanel, Me._access)
        Me.ipanel = panelContacto
        Dim query = Me.ipanel.buscar()
        Dim data = Me._access.buscar(query)
        Me.ipanel.loadTable(data)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(panelContacto)
        panelContacto.txt_nombre.Focus()

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calendar.DateChanged
        Dim fecha = e.End
        Dim s = "SELECT * FROM actividad WHERE DATEPART(month, inicio) = " & fecha.Month & " AND " & _
                "DATEPART(year, inicio) = " & fecha.Year & " AND DATEPART(day, inicio) = " & fecha.Day
        Dim table = Me._access.buscar(s)
        Dim dayView = New DayView(table)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(dayView)
    End Sub
End Class
