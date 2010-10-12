Public Class Telefono
    Implements IModel

    Dim id As Integer
    Dim numero As String

    Public Sub New(ByVal id As Integer, ByVal numero As String)
        Me.id = id
        Me.numero = numero
    End Sub
    Public Function columns() As System.Collections.ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("id")
        res.Add("numero")
        Return res
    End Function

    Public Function data() As System.Collections.ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add(id)
        res.Add(numero)
        Return res
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "telefono"
    End Function
End Class
