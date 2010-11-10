Public Class Actividad
    Implements IModel

    Dim id As Integer
    Dim nombre As String
    Dim inicio As DateTime
    Dim fin As DateTime
    Dim categoria As Categoria
    Dim descripcion As String
    Dim usuario As Usuario

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal inicio As DateTime, _
                   ByVal fin As DateTime, ByVal categoria As Categoria, _
                   ByVal descripcion As String, ByVal user As Usuario)
        Me.id = id
        Me.nombre = nombre
        Me.inicio = inicio
        Me.fin = fin
        Me.categoria = categoria
        Me.descripcion = descripcion
        Me.usuario = user
    End Sub

    Public Function columns() As ArrayList Implements IModel.columns
        Dim res As New ArrayList
        res.Add("nombre")
        res.Add("inicio")
        res.Add("fin")
        res.Add("fk_categoria")
        res.Add("descripcion")
        res.Add("fk_usuario")
        Return res
    End Function

    Public Function data() As ArrayList Implements IModel.data
        Dim res As New ArrayList
        res.Add("'" & nombre & "'")
        res.Add("'" & Format(inicio, "yyyy-MM-dd h:mm:ss") & "'")
        res.Add("'" & Format(fin, "yyyy-MM-dd h:mm:ss") & "'")
        res.Add(categoria.getId())
        res.Add("'" & descripcion & "'")
        res.Add(Me.usuario.getId())
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
