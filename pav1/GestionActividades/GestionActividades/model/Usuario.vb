Public Class Usuario
    Implements IModel

    Dim id As Integer
    Dim nombre As String
    Dim clave As String

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal clave As String)
        Me.id = id
        Me.nombre = nombre
        Me.clave = clave
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("nombre")
        res.Add("clave")
        Return res
    End Function

    Public Function data() As ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add("'" & nombre & "'")
        res.Add("'" & clave & "'")
        Return res
    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "usuario"
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function
End Class
