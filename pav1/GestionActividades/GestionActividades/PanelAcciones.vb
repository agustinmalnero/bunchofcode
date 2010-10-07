Public Class PanelAcciones

    Dim formPanel As System.Windows.Forms.Panel

    Public Sub New(ByRef panel As System.Windows.Forms.Panel)
        InitializeComponent()

        Me.formPanel = panel
    End Sub

    Private Sub btnActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActividad.Click
        Dim panelActividad = New PanelActividad(Me.formPanel)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(panelActividad)
        panelActividad.txt_nombre.Focus()
    End Sub

    Private Sub btnReunion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReunion.Click
        Dim panelReunion = New PanelReunion(Me.formPanel)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(panelReunion)
        panelReunion.cb_actividad.Focus()
    End Sub

    Private Sub btnPlanificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanificar.Click
        Dim panelActividad = New PanelActividad(Me.formPanel)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(panelActividad)
    End Sub

    Private Sub btnContactos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContactos.Click
        Dim panelContacto = New PanelContacto(Me.formPanel)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(panelContacto)
        panelContacto.txt_nombre.Focus()
    End Sub
End Class
