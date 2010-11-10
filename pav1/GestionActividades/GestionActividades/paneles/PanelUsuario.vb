Public Class PanelUsuario
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess)
        formPanel = fp
        InitializeComponent()
        _access = access
    End Sub

    Public Function buscar() As String Implements IPaneles.buscar
        Return "SELECT * FROM usuario"
    End Function

    Public Sub nuevo() Implements IPaneles.nuevo
        Me.txt_nombre.Text = ""
        Me.txt_clave.Text = ""
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.tableUsuario.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableUsuario.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim(), _
                                      data.Rows(c)("clave").ToString().Trim())
        Next
    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar
        Dim index = Integer.Parse(Me.tableUsuario.SelectedCells.Item(0).Value)
        Dim usuario = New Usuario(index, Me.txt_nombre.Text, Me.txt_clave.Text)
        _access.eliminar(usuario)
        Me.reload()
    End Sub

    Public Sub guardar() Implements IPaneles.guardar
        Dim usuario = New Usuario(0, Me.txt_nombre.Text, Me.txt_clave.Text)
        _access.insertar(usuario)
        Me.reload()
    End Sub

    Private Sub reload()
        Me.nuevo()

        Dim data = _access.buscar("SELECT * FROM usuario")
        Dim c As Integer
        Me.tableUsuario.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableUsuario.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim(), _
                                      data.Rows(c)("clave").ToString().Trim())
        Next
    End Sub

    Public Sub modificar() Implements IPaneles.modificar
        Dim index = Integer.Parse(Me.tableUsuario.SelectedCells.Item(0).Value)
        Dim usuario = New Usuario(index, Me.txt_nombre.Text, Me.txt_clave.Text)
        _access.modificar(usuario)
        Me.reload()
    End Sub

    Private Sub tableUsuario_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tableUsuario.CellContentClick
        Me.txt_nombre.Text = Me.tableUsuario.SelectedCells.Item(1).Value.ToString().Trim()
        Me.txt_clave.Text = Me.tableUsuario.SelectedCells.Item(2).Value.ToString().Trim()
    End Sub
End Class
