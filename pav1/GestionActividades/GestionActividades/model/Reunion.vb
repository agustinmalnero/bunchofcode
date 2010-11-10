Public Class Reunion
    Implements IModel

    Dim id As Integer
    Dim actividad As Integer
    Dim lugar As Integer
    Dim contacto As Integer

    Public Sub New(ByVal id As Integer, ByRef actividad As Integer, ByRef lugar As Integer, ByVal contacto As Integer)
        Me.id = id
        Me.actividad = actividad
        Me.lugar = lugar
        Me.contacto = contacto
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("fk_actividad")
        res.Add("fk_lugar")
        res.Add("fk_contacto")
        Return res
    End Function

    Public Function data() As ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add(actividad)
        res.Add(lugar)
        res.Add(contacto)
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
