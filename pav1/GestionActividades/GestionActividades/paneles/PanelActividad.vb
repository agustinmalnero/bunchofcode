Public Class PanelActividad
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel

    Public Sub New(ByRef fp As System.Windows.Forms.Panel)
        formPanel = fp
        InitializeComponent()
        dtp_inicio.Value = Now
        dtp_fin.Value = Now
    End Sub

    Private Sub PanelActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub bt_mas_categoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.cb_categoria.DropDownStyle = ComboBoxStyle.Simple
        Me.cb_categoria.Focus()
    End Sub

    Private Sub dtp_inicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_inicio.ValueChanged

    End Sub
End Class
