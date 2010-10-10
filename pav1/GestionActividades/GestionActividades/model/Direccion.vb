Public Class Direccion
    Implements IModel

    Dim calle As String
    Dim numero As Integer
    Dim barrio As String
    Dim ciudad As String

    Public Sub New(ByVal calle As String, ByVal numero As Integer, _
                   ByVal barrio As String, ByVal ciudad As String)
        Me.calle = calle
        Me.numero = numero
        Me.barrio = barrio
        Me.ciudad = ciudad
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
        Return "Direccion"
    End Function
End Class
