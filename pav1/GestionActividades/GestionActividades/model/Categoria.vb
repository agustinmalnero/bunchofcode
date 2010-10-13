Public Class Categoria
    Implements IModel

    Dim id As Integer
    Dim nombre As String

    Public Sub New(Byval id As Integer,ByVal nombre As String)
        Me.id = id
        Me.nombre = nombre
    End Sub
    Public Function columns() As System.Collections.ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("nombre")
        Return res
    End Function

    Public Function data() As System.Collections.ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add("'" & nombre & "'")
        Return res
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "categoria"
    End Function
End Class
