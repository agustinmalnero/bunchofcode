Public Interface IPaneles

    Sub nuevo()
    Sub loadTable(ByRef data As Data.DataTable)
    Function buscar() As String
    Sub eliminar()
    Sub modificar()
    Sub guardar()

End Interface
