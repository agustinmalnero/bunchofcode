Public Class Tarea
    Implements IModel

    Dim nombre As String
    Dim descripcion As String
    Dim lugar As Lugar

    Public Sub New(ByVal nombre As String, ByVal descripccion As String, _
                   ByRef lugar As Lugar)
        Me.nombre = nombre
        Me.descripcion = descripccion
        Me.lugar = lugar
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns

    End Function

    Public Function data() As ArrayList Implements IModel.data

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "tarea"
    End Function

    Public Function getId() As String Implements IModel.getId

    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

End Class
