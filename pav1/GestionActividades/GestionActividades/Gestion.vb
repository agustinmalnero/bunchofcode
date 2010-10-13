Public Class VentanaGestion

    Dim acciones As PanelAcciones
    Dim tareas As PanelTareas
    Dim month = New MonthView()
    Dim views As Views
    Dim buttons As Controls
    Dim ipanel As IPaneles
    Dim access As DataAccess
    Dim login As Sesion
    Dim data As DataAccess

    Dim buttonsInterface As IButtons

    Public Sub New()
        InitializeComponent()
        Me.data = New DataAccess()
        Me.acciones = New PanelAcciones(Me.centralPanel, Me.buttonsPanel, data)
        Me.views = New Views(Me.centralPanel)
        Me.buttons = New Controls(data)
        Me.tareas = New PanelTareas()
        Me.access = New DataAccess()
        Me.login = New Sesion(Me)
        Me.habilitar(False, "")
    End Sub

    Public Sub habilitar(ByVal val As Boolean, ByVal name As String)

        If val Then
            centralPanel.Controls.Clear()
            panelIzquierda.Controls.Add(acciones)
            panelDerecha.Controls.Add(tareas)
            centralPanel.Controls.Add(month)
            buttonsPanel.Controls.Add(views)
            toolbar.Enabled = True
            lblUsuario.Text = "Usuario: " & name
        Else
            panelIzquierda.Controls.Clear()
            panelDerecha.Controls.Clear()
            centralPanel.Controls.Clear()
            buttonsPanel.Controls.Clear()
            centralPanel.Controls.Add(Me.login)
            toolbar.Enabled = False
            lblUsuario.Text = "Usuario: "
        End If

    End Sub

    Private Sub menuUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuUsuario.Click
        Dim panelUsuario = New PanelUsuario(Me.centralPanel, Me.access)
        Me.ipanel = panelUsuario
        Dim query = Me.ipanel.buscar()
        Dim data = Me.access.buscar(query)
        Me.ipanel.loadTable(data)
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
        Dim panelCiudad = New PanelCiudad(Me.centralPanel, Me.access)
        Me.ipanel = panelCiudad
        Dim query = Me.ipanel.buscar()
        Dim data = Me.access.buscar(query)
        Me.ipanel.loadTable(data)
        Me.centralPanel.Controls.Clear()
        Me.centralPanel.Controls.Add(panelCiudad)

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
        panelCiudad.txt_nombre.Focus()
    End Sub

    Private Sub menuBarrios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBarrios.Click
        Dim panelBarrio = New PanelBarrio(Me.centralPanel, Me.access)
        Me.ipanel = panelBarrio
        Dim query = Me.ipanel.buscar()
        Dim data = Me.access.buscar(query)
        Me.ipanel.loadTable(data)
        Me.centralPanel.Controls.Clear()
        Me.centralPanel.Controls.Add(panelBarrio)

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
        panelBarrio.txt_nombre.Focus()
    End Sub

    Private Sub menuCategorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCategorias.Click
        Dim panelCategoria = New PanelCategoria(Me.centralPanel, Me.access)
        Me.ipanel = panelCategoria
        Dim query = Me.ipanel.buscar()
        Dim data = Me.access.buscar(query)
        Me.ipanel.loadTable(data)
        Me.centralPanel.Controls.Clear()
        Me.centralPanel.Controls.Add(panelCategoria)

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
        panelCategoria.txt_nombre.Focus()
    End Sub

    Private Sub IniciarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarSesionToolStripMenuItem.Click
        Me.habilitar(False, "")
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.habilitar(False, "")
    End Sub

    Private Sub AdministrarTipoContactoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrarTipoContactoToolStripMenuItem.Click
        Dim panelTipoContacto = New PanelTipoContacto(Me.centralPanel, Me.access)
        Me.ipanel = panelTipoContacto
        Dim query = Me.ipanel.buscar()
        Dim data = Me.access.buscar(query)
        Me.ipanel.loadTable(data)
        Me.centralPanel.Controls.Clear()
        Me.centralPanel.Controls.Add(panelTipoContacto)

        Me.buttons.setPanel(Me.ipanel)
        Me.buttonsPanel.Controls.Clear()
        Me.buttonsPanel.Controls.Add(Me.buttons)
        panelTipoContacto.txt_nombre.Focus()
    End Sub
End Class
