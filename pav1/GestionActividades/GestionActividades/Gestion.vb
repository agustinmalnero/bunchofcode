Public Class VentanaGestion

    Dim acciones As PanelAcciones
    Dim tareas As PanelTareas
    Dim month = New MonthView()
    Dim views As Views
    Dim buttons As Controls
    Dim ipanel As IPaneles

    Dim buttonsInterface As IButtons

    Public Sub New()
        InitializeComponent()
        Me.acciones = New PanelAcciones(Me.centralPanel)
        Me.views = New Views(Me.centralPanel)
        Me.buttons = New Controls()
        Me.tareas = New PanelTareas()
        panelIzquierda.Controls.Add(acciones)
        panelDerecha.Controls.Add(tareas)
        centralPanel.Controls.Add(Month)
        buttonsPanel.Controls.Add(Views)

    End Sub

    Private Sub menuUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuUsuario.Click
        Dim panelUsuario = New PanelUsuario(Me.centralPanel)
        Me.ipanel = panelUsuario
        Me.centralPanel.Controls.Clear()
        Me.centralPanel.Controls.Add(panelUsuario)

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
        panelUsuario.txt_nombre.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.centralPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.views)
    End Sub

    Private Sub menuCiudades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCiudades.Click
        Dim panelCiudad = New PanelCiudad(Me.centralPanel)
        Me.ipanel = panelCiudad
        Me.centralPanel.Controls.Clear()
        Me.centralPanel.Controls.Add(panelCiudad)

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
        panelCiudad.txt_nombre.Focus()
    End Sub

    Private Sub menuBarrios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBarrios.Click
        Dim panelBarrio = New PanelBarrio(Me.centralPanel)
        Me.ipanel = panelBarrio
        Me.centralPanel.Controls.Clear()
        Me.centralPanel.Controls.Add(panelBarrio)

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
        panelBarrio.txt_nombre.Focus()
    End Sub

    Private Sub menuCategorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCategorias.Click
        'falta crear panel categoria
    End Sub
End Class
