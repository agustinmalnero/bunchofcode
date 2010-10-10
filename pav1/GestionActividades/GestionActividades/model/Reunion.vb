Public Class Reunion
    Implements IModel

    Dim actividad As Actividad
    Dim lugar As Lugar
    Dim contactos As List(Of Contacto)

    Public Sub New(ByRef actividad As Actividad, ByRef lugar As Lugar, _
                   ByRef contacos As List(Of Contacto))
        Me.actividad = actividad
        Me.lugar = lugar
        Me.contactos = contactos
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns

    End Function

    Public Function data() As ArrayList Implements IModel.data

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "reunion"
    End Function

    Public Function getId() As String Implements IModel.getId

    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function
End Class
