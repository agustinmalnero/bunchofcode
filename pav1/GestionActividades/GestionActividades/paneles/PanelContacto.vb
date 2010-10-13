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
            "barrio.nombre 'barrio', ciudad.nombre 'ciudad' FROM contacto JOIN barrio ON contacto.fk_barrio = " & _
            "barrio.id JOIN ciudad ON contacto.fk_ciudad = ciudad.id"
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
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable
        Dim c As Integer

        Me.tableContacto.Rows.Clear()

        For c = 0 To data.Rows.Count() - 1
            Me.tableContacto.Rows.Add(data.Rows(c)("id"), data.Rows(c)("nombre"), data.Rows(c)("apellido"), _
                                      data.Rows(c)("calle"), data.Rows(c)("numero"), data.Rows(c)("barrio"), _
                                      data.Rows(c)("ciudad"))
        Next

        Dim table = Me._access.buscar("SELECT * FROM ciudad")

        Me.cboCiudad.Controls.Clear()

        For c = 0 To table.Rows.Count() - 1
            Me.cboCiudad.Items.Add(table.Rows(c)("nombre") & ", " & table.Rows(c)("id"))
        Next

        table = Me._access.buscar("SELECT * FROM barrio")

        Me.cboBarrio.Controls.Clear()

        For c = 0 To table.Rows.Count() - 1
            Me.cboBarrio.Items.Add(table.Rows(c)("nombre") & ", " & table.Rows(c)("id"))
        Next

        table = Me._access.buscar("SELECT * FROM tipocontacto")

        Me.cboTipo.Controls.Clear()

        For c = 0 To table.Rows.Count() - 1
            Me.cboTipo.Items.Add(table.Rows(c)("tipo") & ", " & table.Rows(c)("id"))
        Next
    End Sub

    Private Sub bt_mas_tlfn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mas_tlfn.Click
        Me.cb_telefono.Items.Add(Me.txt_telefono.Text)
        Me.txt_telefono.Text = ""
    End Sub

    Private Sub btn_menos_tlfn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menos_tlfn.Click
        Me.cb_telefono.Items.Remove(Me.cb_telefono.Text)
    End Sub

    Private Sub bt_mas_mail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mas_mail.Click
        Me.cb_mail.Items.Add(Me.txt_mail.Text)
        Me.txt_mail.Text = ""
    End Sub

    Private Sub bt_menos_mail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_menos_mail.Click
        Me.cb_mail.Items.Remove(Me.cb_mail.Text)
    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar

    End Sub

    Public Sub guardar() Implements IPaneles.guardar
        Dim ciudadSeleccionada = Me.cboCiudad.SelectedItem.ToString()
        Dim vals = ciudadSeleccionada.Split(", ")
        Dim index = Integer.Parse(vals.GetValue(1))
        Dim ciudad = New Ciudad(index, vals.GetValue(0))
        Dim barrioSeleccionada = Me.cboBarrio.SelectedItem.ToString()
        vals = barrioSeleccionada.Split(", ")
        index = Integer.Parse(vals.GetValue(1))
        Dim barrio = New Barrio(index, vals.GetValue(0), ciudad)
        Dim tipoSeleccionado = Me.cboTipo.SelectedItem.ToString()
        vals = tipoSeleccionado.Split(", ")
        index = Integer.Parse(vals.GetValue(1))
        Dim tipo = New TipoContacto(index, vals.GetValue(0))
        Dim contacto = New Contacto(0, Me.txt_nombre.Text, Me.txt_apellidos.Text, _
                                  Me.txt_calle.Text, Integer.Parse(Me.txt_numero.Text), _
                                  barrio, ciudad, tipo)
        _access.insertar(contacto)

        Me.txt_nombre.Text = ""
        Me.txt_apellidos.Text = ""
        Me.txt_calle.Text = ""
        Me.txt_mail.Text = ""
        Me.txt_numero.Text = ""
        Me.txt_telefono.Text = ""
        Me.cb_mail.Items.Clear()
        Me.cb_telefono.Items.Clear()
    End Sub

    Public Sub modificar() Implements IPaneles.modificar

    End Sub

    Private Sub tableContacto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tableContacto.CellContentClick

    End Sub
End Class
