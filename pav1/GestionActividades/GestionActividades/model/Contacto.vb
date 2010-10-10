Public Class Contacto
    Implements IModel

    Dim nombre As String
    Dim apellido As String
    Dim telefonos As List(Of Telefono)
    Dim mails As List(Of Mail)
    Dim tipoContacto As String
    Dim direccion As Direccion

    Public Sub New(ByVal nombre As String, ByVal apellido As String, _
                   ByRef telefonos As List(Of Telefono), ByRef mails As List(Of Mail), _
                   ByVal tipoContacto As String, ByRef direccion As Direccion)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.telefonos = telefonos
        Me.mails = mails
        Me.tipoContacto = tipoContacto
        Me.direccion = direccion
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns

    End Function

    Public Function data() As ArrayList Implements IModel.data

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "contacto"
    End Function

    Public Function getId() As String Implements IModel.getId

    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

End Class
