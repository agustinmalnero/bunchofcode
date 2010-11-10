Public Class Tarea
    Implements IModel

    Dim id As Integer
    Dim nombre As String
    Dim descripcion As String
    Dim fk_actividad As Integer

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal descripccion As String)
        Me.id = id
        Me.nombre = nombre
        Me.descripcion = descripccion
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("nombre")
        res.Add("descripcion")
        res.Add("fk_actividad")
        Return res
    End Function

    Public Function data() As ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add("'" & nombre & "'")
        res.Add("'" & descripcion & "'")
        res.Add(Me.fk_actividad)
        Return res
    End Function

    Public Function tableName() As String Implements IModel.tableName
        Return "tarea"
    End Function

    Public Function getId() As String Implements IModel.getId
        Return Me.id
    End Function

    Public Sub setActividad(ByVal index As Integer)
        Me.fk_actividad = index
    End Sub

    Public Function getNombre() As String
        Return Me.nombre
    End Function

    Public Function getDescripcion() As String
        Return Me.descripcion
    End Function

    Public Function getQuery() As String Implements IModel.getQuery

    End Function

End Class
