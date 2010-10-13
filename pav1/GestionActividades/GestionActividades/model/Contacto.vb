Public Class Contacto
    Implements IModel

    Dim id As String
    Dim nombre As String
    Dim apellido As String
    Dim calle As String
    Dim numero As Integer
    Dim barrio As Barrio
    Dim ciudad As Ciudad
    Dim tipoContacto As TipoContacto
    'Dim direccion As Direccion

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal apellido As String, _
                   ByVal calle As String, ByVal numero As Integer, ByVal barrio As Barrio, _
                   ByVal ciudad As Ciudad, ByVal tipo As TipoContacto)
        Me.id = id
        Me.nombre = nombre
        Me.apellido = apellido
        Me.calle = calle
        Me.numero = numero
        Me.barrio = barrio
        Me.ciudad = ciudad
        Me.tipoContacto = tipo
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("nombre")
        res.Add("apellido")
        res.Add("calle")
        res.Add("numero")
        res.Add("fk_barrio")
        res.Add("fk_ciudad")
        res.Add("fk_tipocontacto")
        Return res
    End Function

    Public Function data() As ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add("'" & nombre & "'")
        res.Add("'" & apellido & "'")
        res.Add("'" & calle & "'")
        res.Add(numero)
        res.Add(barrio.getId())
        res.Add(ciudad.getId())
        res.Add(tipoContacto.getId())
        Return res
    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "contacto"
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

End Class
