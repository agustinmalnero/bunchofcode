Public Class PanelCiudad
    Implements IPaneles

    Dim formPanel As System.Windows.Forms.Panel

    Public Sub New(ByRef fp As System.Windows.Forms.Panel)
        formPanel = fp
        InitializeComponent()
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
