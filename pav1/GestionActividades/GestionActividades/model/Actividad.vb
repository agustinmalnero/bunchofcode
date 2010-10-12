Public Class Actividad
    Implements IModel

    Dim id As Integer
    Dim nombre As String
    Dim inicio As Date
    Dim fin As Date
    Dim categoria As Categoria
    Dim descripcion As String
    Dim tareas As List(Of Tarea)

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal inicio As Date, _
                   ByVal fin As Date, ByVal categoria As Categoria, _
                   ByVal descripcion As String, ByRef tareas As List(Of Tarea))
        Me.id = id
        Me.nombre = nombre
        Me.inicio = inicio
        Me.fin = fin
        Me.categoria = categoria
        Me.descripcion = descripcion
        Me.tareas = tareas
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("id")
        res.Add("nombre")
        res.Add("incio")
        res.Add("fin")
        res.Add("categoria")
        res.Add("descripcion")
        Return res
    End Function

    Public Function data() As ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add(id)
        res.Add(nombre)
        res.Add(inicio)
        res.Add(fin)
        res.Add(categoria.getId)
        res.Add(descripcion)
        Return res
    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "actividad"
    End Function

    Public Function getId() As String Implements IModel.getId
        Return id
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

End Class
