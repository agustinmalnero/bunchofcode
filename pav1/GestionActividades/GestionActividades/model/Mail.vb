Public Class Mail
    Implements IModel

    Dim id As Integer
    Dim direccion As String

    Public Sub New(ByVal id As Integer, ByVal direccion As String)
        Me.id = id
        Me.direccion = direccion
    End Sub

    Public Function columns() As System.Collections.ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("id")
        res.Add("direccion")
        Return res
    End Function

    Public Function data() As System.Collections.ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add(id)
        res.Add(direccion)
        Return res
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "Mail"
    End Function
End Class
