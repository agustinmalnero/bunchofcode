Public Class Lugar
    Implements IModel

    Dim id As Integer
    Dim nombre As String
    Dim calle As String
    Dim numero As Integer
    Dim barrio As Integer
    Dim ciudad As Integer

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal calle As String, ByVal numero As Integer, _
                   ByVal barrio As Integer, ByVal ciudad As Integer)
        Me.id = id
        Me.nombre = nombre
        Me.calle = calle
        Me.numero = numero
        Me.barrio = barrio
        Me.ciudad = ciudad
    End Sub

    Public Function columns() As System.Collections.ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("nombre")
        res.Add("calle")
        res.Add("numero")
        res.Add("barrio")
        res.Add("ciudad")
        Return res
    End Function

    Public Function data() As System.Collections.ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add("'" & nombre & "'")
        res.Add("'" & calle & "'")
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
        Return "lugar"
    End Function
End Class
