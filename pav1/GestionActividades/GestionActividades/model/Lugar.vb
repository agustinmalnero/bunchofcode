Public Class Lugar
    Implements IModel

    Dim id As Integer
    Dim nombre As String
    Dim direccion As Direccion

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByRef direccion As Direccion)
        Me.id = id
        Me.nombre = nombre
        Me.direccion = direccion
    End Sub

    Public Function columns() As System.Collections.ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("id")
        res.Add("nombre")
        res.Add("direccion")
        Return res
    End Function

    Public Function data() As System.Collections.ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add(id)
        res.Add(nombre)
        res.Add(direccion)
        Return res
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

    Public Function tableName() As String Implements IModel.tableName

    End Function
End Class
