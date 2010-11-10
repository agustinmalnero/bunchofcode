Public Class PanelReunion
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess
    Dim usuario As Usuario

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess, ByRef user As Usuario)
        formPanel = fp
        InitializeComponent()
        _access = access
        Me.usuario = user

        Dim table = Me._access.buscar("SELECT * FROM actividad WHERE fk_usuario = " & usuario.getId())
        util.create_combo(Me.cb_actividad, table, "id", "nombre")

        table = Me._access.buscar("SELECT * FROM lugar")
        util.create_combo(Me.cb_nombre, table, "id", "nombre")

        table = Me._access.buscar("SELECT * from contacto")
        util.create_combo(Me.cb_contactos, table, "id", "nombre")

        table = Me._access.buscar("SELECT * FROM ciudad")
        util.create_combo(Me.cb_ciudad, table, "id", "nombre")
    End Sub

    Private Sub PanelReunion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function buscar() As String Implements IPaneles.buscar
        Return "SELECT reunion.id, reunion.fk_actividad, actividad.nombre 'actividad', reunion.fk_lugar, " & _
                "lugar.nombre 'lugar', reunion.fk_contacto FROM reunion JOIN actividad " & _
                "ON reunion.fk_actividad = actividad.id " & _
                "JOIN lugar ON reunion.fk_lugar = lugar.id"
    End Function

    Public Sub nuevo() Implements IPaneles.nuevo
        Me.cb_actividad.SelectedIndex = 0
        Me.bt_mas_lugar.Enabled = True
        Me.cb_nombre.DropDownStyle = ComboBoxStyle.DropDownList
        Me.txt_calle.Enabled = False
        Me.txt_numero.Enabled = False
        Me.cb_barrio.Enabled = False
        Me.cb_ciudad.Enabled = False
        Me.txt_calle.Text = ""
        Me.txt_numero.Text = ""
        Me.cb_ciudad.SelectedIndex = 0
        Me.cb_contactos.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mas_lugar.Click
        Me.bt_mas_lugar.Enabled = False
        Me.cb_nombre.DropDownStyle = ComboBoxStyle.Simple
        Me.txt_calle.Enabled = True
        Me.txt_numero.Enabled = True
        Me.cb_barrio.Enabled = True
        Me.cb_ciudad.Enabled = True
        Me.cb_nombre.Focus()
    End Sub

    Private Sub bt_mas_contactos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.cb_contactos.DropDownStyle = ComboBoxStyle.Simple
        Me.cb_contactos.Focus()
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.table.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.table.Rows.Add(data.Rows(c)("id"), data.Rows(c)("fk_actividad").ToString().Trim() _
                                    , data.Rows(c)("actividad").ToString().Trim(), _
                                    data.Rows(c)("fk_lugar").ToString().Trim(), _
                                    data.Rows(c)("lugar").ToString().Trim(), _
                                    data.Rows(c)("fk_contacto").ToString().Trim() _
                                    )
        Next
    End Sub

    Private Sub reload()
        Dim data = Me._access.buscar(Me.buscar())
        Dim c As Integer

        Me.table.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.table.Rows.Add(data.Rows(c)("id"), data.Rows(c)("fk_actividad").ToString().Trim() _
                                    , data.Rows(c)("actividad").ToString().Trim(), _
                                    data.Rows(c)("fk_lugar").ToString().Trim(), _
                                    data.Rows(c)("lugar").ToString().Trim(), _
                                    data.Rows(c)("fk_contacto").ToString().Trim() _
                                    )
        Next

        Me.cb_nombre.Controls.Clear()
        data = Me._access.buscar("SELECT * FROM lugar")
        util.create_combo(Me.cb_nombre, data, "id", "nombre")
    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar
        Dim reunion = New Reunion(Me.table.SelectedCells(0).Value, Me.cb_actividad.SelectedValue, 0, Me.cb_contactos.SelectedValue)
        Me._access.eliminar(reunion)
        Me.nuevo()
        Me.reload()
    End Sub

    Public Sub guardar() Implements IPaneles.guardar
        Dim index = 0
        If Me.bt_mas_lugar.Enabled = False Then
            Dim lugar = New Lugar(index, Me.cb_nombre.Text, Me.txt_calle.Text, Integer.Parse(Me.txt_numero.Text), _
                              Me.cb_barrio.SelectedValue, Me.cb_ciudad.SelectedValue)
            index = Me._access.insertar(lugar)
        Else
            index = Me.cb_nombre.SelectedValue
        End If

        Dim reunion = New Reunion(0, Me.cb_actividad.SelectedValue, index, Me.cb_contactos.SelectedValue)
        Me._access.insertar(reunion)
        Me.nuevo()
        Me.reload()
    End Sub

    Public Sub modificar() Implements IPaneles.modificar
        Dim index = 0
        If Me.bt_mas_lugar.Enabled = False Then
            Dim lugar = New Lugar(index, Me.cb_nombre.Text, Me.txt_calle.Text, Integer.Parse(Me.txt_numero.Text), _
                              Me.cb_barrio.SelectedValue, Me.cb_ciudad.SelectedValue)
            index = Me._access.insertar(lugar)
        Else
            index = Me.cb_nombre.SelectedValue
        End If

        Dim reunion = New Reunion(Me.table.SelectedCells(0).Value, Me.cb_actividad.SelectedValue, index, Me.cb_contactos.SelectedValue)
        Me._access.modificar(reunion)
        Me.nuevo()
        Me.reload()
    End Sub

    Private Sub cb_ciudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_ciudad.SelectedIndexChanged
        Try
            Dim index = Me.cb_ciudad.SelectedValue
            Dim table = Me._access.buscar("SELECT * FROM barrio WHERE fk_ciudad = " & index)
            util.create_combo(Me.cb_barrio, table, "id", "nombre")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub table_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles table.CellContentClick
        Me.cb_actividad.SelectedValue = Me.table.SelectedCells.Item(1).Value
        Me.cb_nombre.SelectedValue = Me.table.SelectedCells.Item(3).Value
        Me.cb_contactos.SelectedValue = Me.table.SelectedCells.Item(5).Value
    End Sub
End Class
