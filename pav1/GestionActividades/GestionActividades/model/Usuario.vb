Public Class Usuario
    Implements IModel

    Dim nombre As String
    Dim clave As String

    Public Sub New(ByVal nommbre As String, ByVal clave As String)
        Me.nombre = nommbre
        Me.clave = clave
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns

    End Function

    Public Function data() As ArrayList Implements IModel.data

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "usuario"
    End Function

    Public Function getId() As String Implements IModel.getId

    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function
End Class
