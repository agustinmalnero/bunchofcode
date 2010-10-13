Public Class PanelActividad
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel
    Dim _access As DataAccess

    Public Sub New(ByRef fp As System.Windows.Forms.Panel, ByRef access As DataAccess)
        formPanel = fp
        InitializeComponent()
        dtp_inicio.Value = Now
        dtp_fin.Value = Now
        _access = access
    End Sub

    Private Sub PanelActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub nuevo() Implements IPaneles.nuevo

    End Sub

    Private Sub bt_mas_categoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.cb_categoria.DropDownStyle = ComboBoxStyle.Simple
        Me.cb_categoria.Focus()
    End Sub

    Private Sub dtp_inicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_inicio.ValueChanged

    End Sub

    Public Sub loadTable(ByRef data As Data.DataTable) Implements IPaneles.loadTable

    End Sub

    Public Function buscar() As String Implements IPaneles.buscar

    End Function

    Public Sub eliminar() Implements IPaneles.eliminar

    End Sub

    Public Sub guardar() Implements IPaneles.guardar

    End Sub

    Public Sub modificar() Implements IPaneles.modificar

    End Sub
End Class
