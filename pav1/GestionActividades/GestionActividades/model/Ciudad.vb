Public Class Ciudad
    Implements IModel

    Dim nombre As String

    Public Sub New(ByVal nombre As String)
        Me.nombre = nombre
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns

    End Function

    Public Function data() As ArrayList Implements IModel.data

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "ciudad"
    End Function

    Public Function getId() As String Implements IModel.getId

    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

End Class
