Public Class Direccion
    Implements IModel

    Dim id As Integer
    Dim calle As String
    Dim numero As Integer
    Dim barrio As Barrio
    Dim ciudad As Ciudad

    Public Sub New(ByVal id As Integer, ByVal calle As String, ByVal numero As Integer, _
                   ByVal barrio As Barrio, ByVal ciudad As Ciudad)
        Me.id = id
        Me.calle = calle
        Me.numero = numero
        Me.barrio = barrio
        Me.ciudad = ciudad
    End Sub

    Public Function columns() As System.Collections.ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("id")
        res.Add("calle")
        res.Add("numero")
        res.Add("barrio")
        res.Add("ciudad")
        Return res
    End Function

    Public Function data() As System.Collections.ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add(id)
        res.Add(calle)
        res.Add(numero)
        res.Add(barrio)
        res.Add(ciudad)
        Return res
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "Direccion"
    End Function
End Class
