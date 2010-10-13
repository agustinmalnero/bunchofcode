Public Class Controls
    Implements IButtons

    Dim ipanel As IPaneles
    Dim _access As DataAccess

    Public Sub setPanel(ByRef panel As IPaneles) Implements IButtons.setPanel
        Me.ipanel = panel
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.nuevo()
    End Sub

    Public Sub modificar() Implements IButtons.modificar
        Me.ipanel.modificar()
    End Sub

    Public Sub dia() Implements IButtons.dia

    End Sub

    Public Sub eliminar() Implements IButtons.eliminar
        Me.ipanel.eliminar()
    End Sub

    Public Sub guardar() Implements IButtons.guardar
        Me.ipanel.guardar()
    End Sub

    Public Sub mes() Implements IButtons.mes

    End Sub

    Public Sub nuevo() Implements IButtons.nuevo
        Me.ipanel.nuevo()
    End Sub

    Public Sub semana() Implements IButtons.semana

    End Sub

    Public Sub New(ByRef access As DataAccess)
        InitializeComponent()
        Me._access = access
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.guardar()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.modificar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Me.eliminar()
    End Sub
End Class
