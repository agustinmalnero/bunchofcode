Public Class Barrio
    Implements IModel

    Dim nombre As String
    Dim ciudad As Ciudad

    Public Sub New(ByVal nombre As String, ByRef ciudad As Ciudad)
        Me.nombre = nombre
        Me.ciudad = ciudad
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns

    End Function

    Public Function data() As ArrayList Implements IModel.data

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "barrio"
    End Function

    Public Function getId() As String Implements IModel.getId

    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function
End Class
