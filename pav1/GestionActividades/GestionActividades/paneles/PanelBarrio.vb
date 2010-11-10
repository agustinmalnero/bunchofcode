Public Class PanelBarrio
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess)
        formPanel = fp
        InitializeComponent()
        Me._access = access
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tableBarrio.CellContentClick
        Me.txt_nombre.Text = Me.tableBarrio.SelectedCells.Item(1).Value.ToString().Trim()
        Me.cboCiudad.SelectedValue = Me.tableBarrio.SelectedCells.Item(2).Value
    End Sub
    
    Private Sub PanelBarrio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function buscar() As String Implements IPaneles.buscar
        Return "SELECT barrio.id, barrio.nombre, barrio.fk_ciudad, ciudad.nombre 'ciudad' FROM barrio join ciudad on barrio.fk_ciudad = ciudad.id"
    End Function

    Public Sub nuevo() Implements IPaneles.nuevo
        Me.txt_nombre.Text = ""
        Me.cboCiudad.SelectedIndex = 0
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.tableBarrio.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableBarrio.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim() _
                                    , data.Rows(c)("fk_ciudad").ToString().Trim(), data.Rows(c)("ciudad").ToString().Trim())
        Next

        Dim table = Me._access.buscar("SELECT * FROM ciudad")
        util.create_combo(Me.cboCiudad, table, "id", "nombre")
    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar
        Dim index = Integer.Parse(Me.tableBarrio.SelectedCells.Item(0).Value)
        Dim fk_ciudad = Integer.Parse(Me.tableBarrio.SelectedCells.Item(2).Value)
        Dim ciudad = New Ciudad(fk_ciudad, Me.cboCiudad.Text)
        Dim barrio = New Barrio(index, Me.txt_nombre.Text, ciudad)
        _access.modificar(barrio)
        Me.reload()
    End Sub

    Public Sub guardar() Implements IPaneles.guardar
        Dim ciudad = New Ciudad(Me.cboCiudad.SelectedValue, Me.cboCiudad.Text)
        Dim barrio = New Barrio(0, Me.txt_nombre.Text, ciudad)
        _access.insertar(barrio)

        Me.reload()
    End Sub

    Private Sub reload()
        Me.nuevo()

        Dim data = _access.buscar("SELECT barrio.id, barrio.nombre, barrio.fk_ciudad, ciudad.nombre 'ciudad' FROM barrio join ciudad on barrio.fk_ciudad = ciudad.id")
        Dim c As Integer
        Me.tableBarrio.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableBarrio.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim() _
                                    , data.Rows(c)("fk_ciudad").ToString().Trim(), data.Rows(c)("ciudad").ToString().Trim())
        Next
    End Sub

    Public Sub modificar() Implements IPaneles.modificar
        Dim index = Integer.Parse(Me.tableBarrio.SelectedCells.Item(0).Value)
        Dim fk_ciudad = Integer.Parse(Me.tableBarrio.SelectedCells.Item(2).Value)
        Dim ciudad = New Ciudad(fk_ciudad, Me.cboCiudad.Text)
        Dim barrio = New Barrio(index, Me.txt_nombre.Text, ciudad)
        _access.modificar(barrio)
        Me.reload()
    End Sub
End Class
