<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthView
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MonthHrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthMonday = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthTuesday = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthWednesday = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthThursday = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthFriday = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthSaturday = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthSunday = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonthHrs, Me.MonthMonday, Me.MonthTuesday, Me.MonthWednesday, Me.MonthThursday, Me.MonthFriday, Me.MonthSaturday, Me.MonthSunday})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 10
        Me.DataGridView1.Size = New System.Drawing.Size(578, 492)
        Me.DataGridView1.TabIndex = 0
        '
        'MonthHrs
        '
        Me.MonthHrs.Frozen = True
        Me.MonthHrs.HeaderText = "Hrs"
        Me.MonthHrs.Name = "MonthHrs"
        Me.MonthHrs.ReadOnly = True
        Me.MonthHrs.Width = 49
        '
        'MonthMonday
        '
        Me.MonthMonday.Frozen = True
        Me.MonthMonday.HeaderText = "Monday"
        Me.MonthMonday.Name = "MonthMonday"
        Me.MonthMonday.ReadOnly = True
        Me.MonthMonday.Width = 71
        '
        'MonthTuesday
        '
        Me.MonthTuesday.Frozen = True
        Me.MonthTuesday.HeaderText = "Tuesday"
        Me.MonthTuesday.Name = "MonthTuesday"
        Me.MonthTuesday.ReadOnly = True
        Me.MonthTuesday.Width = 74
        '
        'MonthWednesday
        '
        Me.MonthWednesday.Frozen = True
        Me.MonthWednesday.HeaderText = "Wednesday"
        Me.MonthWednesday.Name = "MonthWednesday"
        Me.MonthWednesday.ReadOnly = True
        Me.MonthWednesday.Width = 90
        '
        'MonthThursday
        '
        Me.MonthThursday.Frozen = True
        Me.MonthThursday.HeaderText = "Thursday"
        Me.MonthThursday.Name = "MonthThursday"
        Me.MonthThursday.ReadOnly = True
        Me.MonthThursday.Width = 77
        '
        'MonthFriday
        '
        Me.MonthFriday.Frozen = True
        Me.MonthFriday.HeaderText = "Friday"
        Me.MonthFriday.Name = "MonthFriday"
        Me.MonthFriday.ReadOnly = True
        Me.MonthFriday.Width = 61
        '
        'MonthSaturday
        '
        Me.MonthSaturday.Frozen = True
        Me.MonthSaturday.HeaderText = "Saturday"
        Me.MonthSaturday.Name = "MonthSaturday"
        Me.MonthSaturday.ReadOnly = True
        Me.MonthSaturday.Width = 75
        '
        'MonthSunday
        '
        Me.MonthSunday.Frozen = True
        Me.MonthSunday.HeaderText = "Sunday"
        Me.MonthSunday.Name = "MonthSunday"
        Me.MonthSunday.ReadOnly = True
        Me.MonthSunday.Width = 69
        '
        'monthView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "monthView"
        Me.Size = New System.Drawing.Size(584, 498)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MonthHrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthMonday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthTuesday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthWednesday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthThursday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthFriday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthSaturday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthSunday As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
