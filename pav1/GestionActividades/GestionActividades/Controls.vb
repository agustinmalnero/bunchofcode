Public Class Controls
    Implements IButtons

    Dim ipanel As IPaneles
    Dim data As DataAccess

    Public Sub setPanel(ByRef panel As IPaneles) Implements IButtons.setPanel
        Me.ipanel = panel
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.nuevo()
    End Sub

    Public Sub buscar() Implements IButtons.buscar

    End Sub

    Public Sub dia() Implements IButtons.dia

    End Sub

    Public Sub eliminar() Implements IButtons.eliminar

    End Sub

    Public Sub guardar() Implements IButtons.guardar

    End Sub

    Public Sub mes() Implements IButtons.mes

    End Sub

    Public Sub nuevo() Implements IButtons.nuevo
        Me.ipanel.nuevo()
    End Sub

    Public Sub semana() Implements IButtons.semana

    End Sub

    Public Sub New()
        InitializeComponent()

        Me.data = New DataAccess()
    End Sub
End Class
