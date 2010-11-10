Public Class PanelContacto
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess)
        formPanel = fp
        InitializeComponent()
        _access = access
    End Sub

    Private Sub PanelContacto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function buscar() As String Implements IPaneles.buscar
        Return "SELECT contacto.id, contacto.nombre, contacto.apellido, contacto.calle, contacto.numero, " & _
            "barrio.nombre 'barrio', ciudad.nombre 'ciudad', tipocontacto.tipo 'tipo' FROM contacto JOIN " & _
            "barrio ON contacto.fk_barrio = barrio.id  " & _
            "JOIN ciudad ON contacto.fk_ciudad = ciudad.id " & _
            "JOIN tipocontacto ON contacto.fk_tipocontacto = tipocontacto.id"
    End Function

    Public Sub nuevo() Implements IPaneles.nuevo
        Me.txt_nombre.Text = ""
        Me.txt_apellidos.Text = ""
        Me.txt_calle.Text = ""
        Me.txt_mail.Text = ""
        Me.txt_numero.Text = ""
        Me.txt_telefono.Text = ""
        Me.cb_mail.Items.Clear()
        Me.cb_telefono.Items.Clear()
        Me.reload()
    End Sub

    Private Sub reload()
        Dim query = "SELECT contacto.id, contacto.nombre, contacto.apellido, contacto.calle, contacto.numero, " & _
            "barrio.nombre 'barrio', ciudad.nombre 'ciudad', tipocontacto.tipo 'tipo' FROM contacto JOIN " & _
            "barrio ON contacto.fk_barrio = barrio.id  " & _
            "JOIN ciudad ON contacto.fk_ciudad = ciudad.id " & _
            "JOIN tipocontacto ON contacto.fk_tipocontacto = tipocontacto.id"
        Dim data = Me._access.buscar(query)
        Dim c As Integer
        Me.tableContacto.Rows.Clear()

        For c = 0 To Data.Rows.Count() - 1
            Me.tableContacto.Rows.Add(Data.Rows(c)("id"), Data.Rows(c)("nombre").ToString().Trim(), _
                                      Data.Rows(c)("apellido").ToString().Trim(), _
                                      Data.Rows(c)("calle"), Data.Rows(c)("numero"), Data.Rows(c)("barrio"), _
                                      Data.Rows(c)("ciudad"), Data.Rows(c)("tipo").ToString().Trim())
        Next
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.tableContacto.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableContacto.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre").ToString().Trim(), _
                                      data.Rows(c)("apellido").ToString().Trim(), _
                                      data.Rows(c)("calle"), data.Rows(c)("numero"), data.Rows(c)("barrio"), _
                                      data.Rows(c)("ciudad"), data.Rows(c)("tipo").ToString().Trim())
        Next

        Dim table = Me._access.buscar("SELECT * FROM ciudad")
        util.create_combo(Me.cboCiudad, table, "id", "nombre")

        table = Me._access.buscar("SELECT * FROM tipocontacto")
        util.create_combo(Me.cboTipo, table, "id", "tipo")
    End Sub

    Private Sub bt_mas_tlfn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mas_tlfn.Click
        Me.cb_telefono.Items.Add(Me.txt_telefono.Text)
        Me.txt_telefono.Text = ""
    End Sub

    Private Sub btn_menos_tlfn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menos_tlfn.Click
        Me.cb_telefono.Items.RemoveAt(Me.cb_telefono.SelectedIndex)
    End Sub

    Private Sub bt_mas_mail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mas_mail.Click
        Me.cb_mail.Items.Add(Me.txt_mail.Text)
        Me.txt_mail.Text = ""
    End Sub

    Private Sub bt_menos_mail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_menos_mail.Click
        Me.cb_mail.Items.RemoveAt(Me.cb_mail.SelectedIndex)
    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar
        Dim index = Integer.Parse(Me.tableContacto.SelectedCells.Item(0).Value)
        Dim ciudad = New Ciudad(Me.cboCiudad.SelectedValue, Me.cboCiudad.SelectedText)
        Dim barrio = New Barrio(Me.cboBarrio.SelectedValue, Me.cboBarrio.SelectedText, ciudad)
        Dim tipo = New TipoContacto(Me.cboTipo.SelectedValue, Me.cboTipo.SelectedText)
        Dim contacto = New Contacto(index, Me.txt_nombre.Text, Me.txt_apellidos.Text, _
                                  Me.txt_calle.Text, Integer.Parse(Me.txt_numero.Text), _
                                  barrio, ciudad, tipo)
        _access.eliminar(contacto)

        Me._access.execute("DELETE FROM telefono WHERE contacto = " & index)
        
        Me._access.execute("DELETE FROM email WHERE contacto = " & index)
        
        Me.nuevo()
    End Sub

    Public Sub guardar() Implements IPaneles.guardar
        Dim ciudad = New Ciudad(Me.cboCiudad.SelectedValue, Me.cboCiudad.SelectedText)
        Dim barrio = New Barrio(Me.cboBarrio.SelectedValue, Me.cboBarrio.SelectedText, ciudad)
        Dim tipo = New TipoContacto(Me.cboTipo.SelectedValue, Me.cboTipo.SelectedText)
        Dim contacto = New Contacto(0, Me.txt_nombre.Text, Me.txt_apellidos.Text, _
                                  Me.txt_calle.Text, Integer.Parse(Me.txt_numero.Text), _
                                  barrio, ciudad, tipo)
        Dim id = _access.insertar(contacto)

        For i = 0 To Me.cb_telefono.Items.Count - 1
            Dim t = New Telefono(0, Me.cb_telefono.Items(i).ToString(), id)
            Me._access.insertar(t)
        Next

        For i = 0 To Me.cb_mail.Items.Count - 1
            Dim m = New Mail(0, Me.cb_mail.Items(i).ToString(), id)
            Me._access.insertar(m)
        Next

    End Sub

    Public Sub modificar() Implements IPaneles.modificar
        Dim index = Integer.Parse(Me.tableContacto.SelectedCells.Item(0).Value)
        Dim ciudad = New Ciudad(Me.cboCiudad.SelectedValue, Me.cboCiudad.SelectedText)
        Dim barrio = New Barrio(Me.cboBarrio.SelectedValue, Me.cboBarrio.SelectedText, ciudad)
        Dim tipo = New TipoContacto(Me.cboTipo.SelectedValue, Me.cboTipo.SelectedText)
        Dim contacto = New Contacto(index, Me.txt_nombre.Text, Me.txt_apellidos.Text, _
                                  Me.txt_calle.Text, Integer.Parse(Me.txt_numero.Text), _
                                  barrio, ciudad, tipo)
        _access.modificar(contacto)

        Me._access.execute("DELETE FROM telefono WHERE contacto = " & index)
        For i = 0 To Me.cb_telefono.Items.Count - 1
            Dim t = New Telefono(0, Me.cb_telefono.Items(i).ToString(), index)
            Me._access.insertar(t)
        Next

        Me._access.execute("DELETE FROM email WHERE contacto = " & index)
        For i = 0 To Me.cb_mail.Items.Count - 1
            Dim m = New Mail(0, Me.cb_mail.Items(i).ToString(), index)
            Me._access.insertar(m)
        Next

        Me.nuevo()
    End Sub

    Private Sub tableContacto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tableContacto.CellContentClick
        Me.txt_nombre.Text = Me.tableContacto.SelectedCells.Item(1).Value.ToString().Trim()
        Me.txt_apellidos.Text = Me.tableContacto.SelectedCells.Item(2).Value.ToString().Trim()
        Me.txt_calle.Text = Me.tableContacto.SelectedCells.Item(3).Value.ToString().Trim()
        Me.txt_numero.Text = Me.tableContacto.SelectedCells.Item(4).Value.ToString().Trim()

        Dim index = Integer.Parse(Me.tableContacto.SelectedCells.Item(0).Value)
        Dim data = Me._access.buscar("SELECT * FROM telefono WHERE contacto = " & index)
        util.create_combo_common(Me.cb_telefono, data, "numero")
        data = Me._access.buscar("SELECT * FROM email WHERE contacto = " & index)
        util.create_combo_common(Me.cb_mail, data, "mail")
    End Sub

    Private Sub cboCiudad_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCiudad.SelectedValueChanged
        Try
            Dim index = Integer.Parse(Me.cboCiudad.SelectedValue)
            Dim table = Me._access.buscar("SELECT * FROM barrio WHERE fk_ciudad = " & index)
            util.create_combo(Me.cboBarrio, table, "id", "nombre")
        Catch ex As Exception
        End Try
    End Sub

End Class
