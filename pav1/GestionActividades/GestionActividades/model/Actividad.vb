Public Class Actividad
    Implements IModel

    Dim nombre As String
    Dim inicio As Date
    Dim fin As Date
    Dim categoria As PanelCategoria
    Dim descripcion As String
    Dim tareas As List(Of Tarea)

    Public Sub New(ByVal nombre As String, ByVal inicio As Date, _
                   ByVal fin As Date, ByVal categoria As PanelCategoria, _
                   ByVal descripcion As String, ByRef tareas As List(Of Tarea))
        Me.nombre = nombre
        Me.inicio = inicio
        Me.fin = fin
        Me.categoria = categoria
        Me.descripcion = descripcion
        Me.tareas = tareas
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns

    End Function

    Public Function data() As ArrayList Implements IModel.data

    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "actividad"
    End Function

    Public Function getId() As String Implements IModel.getId

    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

End Class
