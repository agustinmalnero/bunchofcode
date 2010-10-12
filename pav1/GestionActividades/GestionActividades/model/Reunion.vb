Public Class Reunion
    Implements IModel

    Dim id As Integer
    Dim actividad As Actividad
    Dim lugar As Lugar
    Dim contactos As List(Of Contacto)

    Public Sub New(ByVal id As Integer, ByRef actividad As Actividad, ByRef lugar As Lugar, _
                   ByRef contacos As List(Of Contacto))
        Me.id = id
        Me.actividad = actividad
        Me.lugar = lugar
        Me.contactos = contactos
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("id")
        res.Add("actividad")
        res.Add("lugar")
        Return res
    End Function

    Public Function data() As ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add(id)
        res.Add(actividad.getId)
        res.Add(lugar.getId)
        Return res
    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "reunion"
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function
End Class
