Public Class PanelTarea
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess)
        formPanel = fp
        InitializeComponent()
        _access = access
    End Sub

    Private Sub Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function buscar() As String Implements IPaneles.buscar

    End Function

    Public Sub nuevo() Implements IPaneles.nuevo

    End Sub

    Private Sub btn_mas_lugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mas_lugar.Click
        Me.btn_mas_lugar.Enabled = False
        Me.cb_nombre.DropDownStyle = ComboBoxStyle.Simple
        Me.txt_calle.Enabled = True
        Me.txt_numero.Enabled = True
        Me.cb_barrio.Enabled = True
        Me.cb_ciudad.Enabled = True
        Me.cb_nombre.Focus()
    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable

    End Sub

    Public Sub eliminar() Implements IPaneles.eliminar

    End Sub

    Public Sub guardar() Implements IPaneles.guardar

    End Sub

    Public Sub modificar() Implements IPaneles.modificar

    End Sub
End Class
