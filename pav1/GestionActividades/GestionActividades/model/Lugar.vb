Public Class Lugar
    Implements IModel

    Dim nombre As String
    Dim direccion As Direccion

    Public Sub New(ByVal nombre As String, ByRef direccion As Direccion)
        Me.nombre = nombre
        Me.direccion = direccion
    End Sub

    Public Function columns() As System.Collections.ArrayList Implements IModel.columns

    End Function

    Public Function data() As System.Collections.ArrayList Implements IModel.data

    End Function

    Public Function getId() As String Implements IModel.getId

    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

    Public Function tableName() As String Implements IModel.tableName

    End Function
End Class
