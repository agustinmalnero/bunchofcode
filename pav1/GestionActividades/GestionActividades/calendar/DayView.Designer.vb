<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayView
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.table = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'table
        '
        Me.table.AllowUserToAddRows = False
        Me.table.AllowUserToDeleteRows = False
        Me.table.AllowUserToResizeColumns = False
        Me.table.AllowUserToResizeRows = False
        Me.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Hr, Me.Day})
        Me.table.Location = New System.Drawing.Point(3, 3)
        Me.table.MultiSelect = False
        Me.table.Name = "table"
        Me.table.ReadOnly = True
        Me.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table.Size = New System.Drawing.Size(578, 492)
        Me.table.TabIndex = 0
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Hr
        '
        Me.Hr.Frozen = True
        Me.Hr.HeaderText = "Hr"
        Me.Hr.Name = "Hr"
        Me.Hr.ReadOnly = True
        '
        'Day
        '
        Me.Day.Frozen = True
        Me.Day.HeaderText = "Day"
        Me.Day.Name = "Day"
        Me.Day.ReadOnly = True
        '
        'DayView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.table)
        Me.Name = "DayView"
        Me.Size = New System.Drawing.Size(584, 498)
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents table As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
