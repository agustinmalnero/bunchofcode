Public Class PanelReunion
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel

    Public Sub New(ByRef fp As System.Windows.Forms.Panel)
        formPanel = fp
        InitializeComponent()
    End Sub

    Private Sub PanelReunion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub buscar() Implements IPaneles.buscar

    End Sub

    Public Function eliminar() As IModel Implements IPaneles.eliminar

    End Function

    Public Function guardar() As IModel Implements IPaneles.guardar

    End Function

    Public Function modificar() As IModel Implements IPaneles.modificar

    End Function

    Public Sub nuevo() Implements IPaneles.nuevo

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

    Private Sub bt_mas_contactos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mas_contactos.Click
        Me.bt_mas_contactos.Enabled = False
        Me.cb_contactos.DropDownStyle = ComboBoxStyle.Simple
        Me.cb_contactos.Focus()
    End Sub
End Class
