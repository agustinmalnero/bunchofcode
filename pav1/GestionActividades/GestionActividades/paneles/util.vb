Module util

    Public Sub create_combo(ByRef combo As ComboBox, ByRef data As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.Controls.Clear()
        combo.DataSource = data
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Public Sub create_combo_common(ByRef combo As ComboBox, ByRef data As Data.DataTable, ByVal col As String)
        combo.Controls.Clear()
        For i = 0 To data.Rows.Count - 1
            combo.Items.Add(data(i)(col))
        Next
    End Sub

End Module
