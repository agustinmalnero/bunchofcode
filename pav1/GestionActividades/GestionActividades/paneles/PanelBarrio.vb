Public Class PanelBarrio
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel

    Public Sub New(ByRef fp As System.Windows.Forms.Panel)
        formPanel = fp
        InitializeComponent()
    End Sub

    Private Sub lbl_nombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_nombre.Click

    End Sub
    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub txt_clave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PanelBarrio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
End Class
