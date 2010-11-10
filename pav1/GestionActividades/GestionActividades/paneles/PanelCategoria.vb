Public Class PanelCategoria
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess

    Public Sub New(ByRef formPanel As System.Windows.Forms.Panel, ByRef access As DataAccess)
        InitializeComponent()
        Me.formPanel = formPanel
        Me._access = access
    End Sub
    Public Function buscar() As String Implements IPaneles.buscar
        Return "SELECT * FROM categoria"
    End Function

    Public Sub nuevo() Implements IPaneles.nuevo
        Me.txt_nombre.Text = ""
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.tableCategoria.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableCategoria.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim())
        Next
    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar
        Dim index = Integer.Parse(Me.tableCategoria.SelectedCells.Item(0).Value)
        Dim categoria = New Categoria(index, Me.txt_nombre.Text)
        _access.eliminar(categoria)
        Me.reload()
    End Sub

    Public Sub guardar() Implements IPaneles.guardar
        Dim categoria = New Categoria(0, Me.txt_nombre.Text)
        _access.insertar(categoria)
        Me.reload()
    End Sub

    Private Sub reload()
        Me.nuevo()
        Dim data = _access.buscar("SELECT * FROM categoria")
        Dim c As Integer
        Me.tableCategoria.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableCategoria.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim())
        Next
    End Sub

    Public Sub modificar() Implements IPaneles.modificar
        Dim index = Integer.Parse(Me.tableCategoria.SelectedCells.Item(0).Value)
        Dim categoria = New Categoria(index, Me.txt_nombre.Text)
        _access.modificar(categoria)
        Me.reload()
    End Sub

    Private Sub tableCategoria_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tableCategoria.CellContentClick
        Me.txt_nombre.Text = Me.tableCategoria.SelectedCells.Item(1).Value.ToString().Trim()
    End Sub
End Class
