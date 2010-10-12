Public Class Barrio
    Implements IModel

    Dim id As Integer
    Dim nombre As String
    Dim ciudad As Ciudad

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByRef ciudad As Ciudad)
        Me.id = id
        Me.nombre = nombre
        Me.ciudad = ciudad
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("id")
        res.Add("nombre")
        res.Add("ciudad")
        Return res
    End Function

    Public Function data() As ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add(id)
        res.Add(nombre)
        res.Add(ciudad.getId)
        Return res
    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "barrio"
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function
End Class
