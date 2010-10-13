Public Class PanelTipoContacto
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess)
        formPanel = fp
        InitializeComponent()
        _access = access
    End Sub

    Private Sub PanelTipoContacto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function buscar() As String Implements IPaneles.buscar
        Return "SELECT * FROM tipocontacto"
    End Function

    Public Sub nuevo() Implements IPaneles.nuevo
        Me.txt_nombre.Text = ""
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.tableTipoContacto.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableTipoContacto.Rows.Add(data.Rows(c)("id"), data.Rows(c)("tipo"))
        Next
    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar
        Dim index = Integer.Parse(Me.tableTipoContacto.SelectedCells.Item(0).Value)
        Dim tipoContacto = New TipoContacto(index, Me.txt_nombre.Text)
        _access.eliminar(tipoContacto)
        Me.txt_nombre.Text = ""
    End Sub

    Public Sub guardar() Implements IPaneles.guardar
        Dim tipoContacto = New TipoContacto(0, Me.txt_nombre.Text)
        _access.insertar(tipoContacto)
        Me.txt_nombre.Text = ""
    End Sub

    Public Sub modificar() Implements IPaneles.modificar
        Dim index = Integer.Parse(Me.tableTipoContacto.SelectedCells.Item(0).Value)
        Dim tipoContacto = New TipoContacto(index, Me.txt_nombre.Text)
        _access.modificar(tipoContacto)
        Me.txt_nombre.Text = ""
    End Sub

    Private Sub tableTipoContacto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tableTipoContacto.CellContentClick
        Me.txt_nombre.Text = Me.tableTipoContacto.SelectedCells.Item(1).Value.ToString().Trim()
    End Sub
End Class
