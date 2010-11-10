Public Class PanelCiudad
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess)
        formPanel = fp
        InitializeComponent()
        _access = access
    End Sub

    Public Function buscar() As String Implements IPaneles.buscar
        Return "SELECT * FROM ciudad"
    End Function

    Public Sub guardar() Implements IPaneles.guardar
        Dim ciudad = New Ciudad(0, Me.txt_nombre.Text)
        _access.insertar(ciudad)
        Me.reload()
    End Sub

    Private Sub reload()
        Me.nuevo()

        Dim data = _access.buscar("SELECT * FROM ciudad")
        Dim c As Integer
        Me.tableCiudad.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableCiudad.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim())
        Next
    End Sub

    Public Sub nuevo() Implements IPaneles.nuevo
        Me.txt_nombre.Text = ""
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.tableCiudad.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableCiudad.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim())
        Next
    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar
        Dim index = Integer.Parse(Me.tableCiudad.SelectedCells.Item(0).Value)
        Dim ciudad = New Ciudad(index, Me.txt_nombre.Text)
        _access.eliminar(ciudad)
        Me.reload()
    End Sub

    Public Sub modificar() Implements IPaneles.modificar
        Dim index = Integer.Parse(Me.tableCiudad.SelectedCells.Item(0).Value)
        Dim ciudad = New Ciudad(index, Me.txt_nombre.Text)
        _access.modificar(ciudad)
        Me.reload()
    End Sub

    Private Sub tableCiudad_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tableCiudad.CellContentClick
        Me.txt_nombre.Text = Me.tableCiudad.SelectedCells.Item(1).Value.ToString().Trim()
    End Sub
End Class
