Imports System.Data.SqlClient

Public Class DataAccess

    Dim WithEvents con As SqlConnection

    Public Sub New()
        con = New SqlConnection("Server=(local)\SQLEXPRESS;Initial Catalog=pav;Integrated Security=SSPI")

        Dim cmd As New SqlCommand()
        cmd.CommandText = "PRINT('Connection')"
        cmd.Connection = con
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub insertar(ByVal model As IModel)
        Dim cmd As New SqlCommand()
        Try
            cmd.Connection = con
            Dim columns = ""
            Dim values = ""
            Dim first = True
            For Each item As String In model.data()
                If first Then
                    values = item
                    first = False
                Else
                    values = "," & item
                End If
            Next
            first = True
            For Each item As String In model.columns()
                If first Then
                    columns = item
                    first = False
                Else
                    columns = "," & item
                End If
            Next
            Dim query = "INSERT INTO " & model.tableName() & "(" _
                    & columns & ") " & "VALUES(" + values & ")"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub eliminar(ByVal model As IModel)
        Dim cmd As New SqlCommand()
        Try
            cmd.Connection = con
            Dim query = "DELETE FROM " & model.tableName() & " WHERE id=" & model.getId()
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub modificar(ByVal model As IModel)
        Dim cmd As New SqlCommand()
        Try
            cmd.Connection = con
            Dim values = ""
            Dim first = True
            Dim length = model.columns().Count
            Dim cols = model.columns()
            Dim data = model.data()
            For i As Integer = 0 To length
                If first Then
                    values = cols.Item(i) & "=" & data.Item(i)
                End If
            Next
            Dim query = "UPDATE " & model.tableName() & " SET " & values & " WHERE id=" & model.getId()
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Function buscar(ByVal query As String) As Data.DataTable
        Dim cmd As New SqlCommand()
        Dim tabla As New Data.DataTable
        Try
            cmd.Connection = con
            cmd.CommandText = query
            tabla.Load(cmd.ExecuteReader())
        Catch ex As Exception

        End Try

        Return tabla
    End Function

End Class
