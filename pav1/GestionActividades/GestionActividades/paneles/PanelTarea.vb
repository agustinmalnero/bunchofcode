Public Class PanelTarea
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess
    Dim actividad As PanelActividad
    Dim tareas As List(Of Tarea)

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess, ByRef act As PanelActividad)
        InitializeComponent()
        _access = access
        formPanel = fp
        Me.tareas = New List(Of Tarea)
        Me.actividad = act

        Me.tableTarea.Rows.Clear()
    End Sub

    Private Sub Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function buscar() As String Implements IPaneles.buscar

    End Function

    Public Function getTareas() As List(Of Tarea)
        Return Me.tareas
    End Function

    Public Sub clearTareas()
        Me.tareas.Clear()
    End Sub

    Public Sub nuevo() Implements IPaneles.nuevo
        Me.txt_descripcion.Text = ""
        Me.txt_nombre.Text = ""
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.tableTarea.Rows.Clear()
        For c = 0 To data.Rows.Count() - 1
            Dim t = New Tarea(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim() _
                                    , data.Rows(c)("descripcion").ToString().Trim())
            Me.tareas.Add(t)
        Next
        Me.reload_table()
    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar
        Me.tareas.RemoveAt(Me.tableTarea.SelectedRows(0).Index)
        Me.done()
    End Sub

    Public Sub guardar() Implements IPaneles.guardar
        Dim tarea = New Tarea(0, Me.txt_nombre.Text, Me.txt_descripcion.Text)
        Me.tareas.Add(tarea)
        Me.done()
    End Sub

    Private Sub done()
        Me.actividad.buttons.setPanel(Me.actividad)
        Me.formPanel.Controls.Clear()
        Me.formPanel.Controls.Add(Me.actividad)
        Me.nuevo()
    End Sub

    Public Sub reload_table()
        Me.tableTarea.Rows.Clear()
        For Each item In Me.tareas
            Me.tableTarea.Rows.Add(item.getId(), item.getNombre(), item.getDescripcion())
        Next
    End Sub

    Public Sub modificar() Implements IPaneles.modificar
        Dim tarea = New Tarea(0, Me.txt_nombre.Text, Me.txt_descripcion.Text)
        Me.tareas.Insert(Me.tableTarea.SelectedRows(0).Index, tarea)
        Me.tareas.RemoveAt(Me.tableTarea.SelectedRows(0).Index + 1)
        Me.done()
    End Sub

    Private Sub tableTarea_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tableTarea.CellContentClick
        Me.txt_nombre.Text = Me.tableTarea.SelectedCells.Item(1).Value.ToString().Trim()
        Me.txt_descripcion.Text = Me.tableTarea.SelectedCells.Item(2).Value.ToString().Trim()
    End Sub
End Class
