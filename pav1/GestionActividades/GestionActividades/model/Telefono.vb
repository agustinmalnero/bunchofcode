Public Class Telefono
    Implements IModel

    Dim numero As String

    Public Sub New(ByVal numero As String)
        Me.numero = numero
    End Sub
    Public Function columns() As System.Collections.ArrayList Implements IModel.columns

    End Function

    Public Function data() As System.Collections.ArrayList Implements IModel.data

    End Function

    Public Function getId() As String Implements IModel.getId

    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "telefono"
    End Function
End Class
