﻿Public Class Categoria
    Implements IModel

    Dim nombre As String

    Public Sub New(ByVal nombre As String)
        Me.nombre = nombre
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