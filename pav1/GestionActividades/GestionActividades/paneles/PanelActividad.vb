Public Class PanelActividad
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess
    Dim tareas As PanelTarea
    Public buttons As Controls
    Dim usuario As Usuario

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess, _
                   ByRef buttons As Controls, ByRef user As Usuario)
        InitializeComponent()
        formPanel = fp
        Me.usuario = user
        Me.buttons = buttons
        Me.tareas = New PanelTarea(Me.formPanel, Me._access, Me)
        dtp_inicio.Value = Now
        dtp_fin.Value = Now
        _access = access

        Dim table = Me._access.buscar("SELECT * FROM categoria")
        util.create_combo(Me.cb_categoria, table, "id", "nombre")
    End Sub

    Public Sub nuevo() Implements IPaneles.nuevo
        
    End Sub

    Public Function buscar() As String Implements IPaneles.buscar
        Return "SELECT actividad.id, actividad.nombre, actividad.descripcion, " & _
        "categoria.nombre 'categoria', actividad.inicio, actividad.fin FROM actividad" & _
        " JOIN categoria ON actividad.fk_categoria = categoria.id WHERE actividad.fk_usuario = " & Me.usuario.getId()
    End Function

    Public Sub eliminar() Implements IPaneles.eliminar
        Dim index = Integer.Parse(Me.tableActividad.SelectedCells.Item(0).Value)
        Dim categoria = New Categoria(Me.cb_categoria.SelectedValue, Me.cb_categoria.SelectedText)
        Dim actividad = New Actividad(index, Me.txt_nombre.Text, Me.dtp_inicio.Value, _
                                      Me.dtp_fin.Value, categoria, _
                                      Me.txt_descripcion.Text, Me.usuario)
        Me._access.eliminar(actividad)

        Me._access.execute("DELETE FROM tarea WHERE fk_actividad = " & index)
        
        Me.reload()
        Me.tareas.clearTareas()
    End Sub

    Public Sub guardar() Implements IPaneles.guardar
        Dim categoria = New Categoria(Me.cb_categoria.SelectedValue, Me.cb_categoria.SelectedText)
        Dim actividad = New Actividad(0, Me.txt_nombre.Text, Me.dtp_inicio.Value, _
                                      Me.dtp_fin.Value, categoria, _
                                      Me.txt_descripcion.Text, Me.usuario)
        Dim index = Me._access.insertar(actividad)

        For Each item In Me.tareas.getTareas()
            item.setActividad(index)
            Me._access.insertar(item)
        Next

        Me.reload()
        Me.tareas.clearTareas()
    End Sub

    Public Sub modificar() Implements IPaneles.modificar
        Dim index = Integer.Parse(Me.tableActividad.SelectedCells.Item(0).Value)
        Dim categoria = New Categoria(Me.cb_categoria.SelectedValue, Me.cb_categoria.SelectedText)
        Dim actividad = New Actividad(index, Me.txt_nombre.Text, Me.dtp_inicio.Value, _
                                      Me.dtp_fin.Value, categoria, _
                                      Me.txt_descripcion.Text, Me.usuario)
        Me._access.modificar(actividad)

        Me._access.execute("DELETE FROM tarea WHERE fk_actividad = " & index)
        For Each item In Me.tareas.getTareas()
            item.setActividad(index)
            Me._access.insertar(item)
        Next

        Me.reload()
        Me.tareas.clearTareas()
    End Sub

    Public Sub loadTable(ByRef data As System.Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.tableActividad.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableActividad.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim() _
                                    , data.Rows(c)("descripcion").ToString().Trim(), _
                                    data.Rows(c)("categoria").ToString().Trim(), _
                                    data.Rows(c)("inicio").ToString().Trim(), _
                                    data.Rows(c)("fin").ToString().Trim() _
                                    )
        Next
    End Sub

    Private Sub reload()
        Me.txt_descripcion.Text = ""
        Me.txt_nombre.Text = ""
        Me.cb_categoria.SelectedIndex = 0
        dtp_inicio.Value = Now
        dtp_fin.Value = Now
        Dim data = Me._access.buscar("SELECT actividad.id, actividad.nombre, actividad.descripcion, " & _
        "categoria.nombre 'categoria', actividad.inicio, actividad.fin FROM actividad" & _
        " JOIN categoria ON actividad.fk_categoria = categoria.id")

        Dim c As Integer

        Me.tableActividad.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableActividad.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim() _
                                    , data.Rows(c)("descripcion").ToString().Trim(), _
                                    data.Rows(c)("categoria").ToString().Trim(), _
                                    data.Rows(c)("inicio").ToString().Trim(), _
                                    data.Rows(c)("fin").ToString().Trim() _
                                    )
        Next
    End Sub

    Private Sub bt_agregar_tarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_agregar_tarea.Click
        Me.tareas.reload_table()
        Me.buttons.setPanel(Me.tareas)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(Me.tareas)
    End Sub

    Private Sub tableActividad_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tableActividad.CellContentClick
        Me.txt_nombre.Text = Me.tableActividad.SelectedCells.Item(1).Value.ToString().Trim()
        Me.txt_descripcion.Text = Me.tableActividad.SelectedCells.Item(2).Value.ToString().Trim()

        Dim index = Integer.Parse(Me.tableActividad.SelectedCells.Item(0).Value)
        Dim table = Me._access.buscar("SELECT * FROM tarea WHERE fk_actividad = " & index)
        Me.tareas.loadTable(table)
    End Sub

    Private Sub PanelActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
