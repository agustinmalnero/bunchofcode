<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeekView
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
        Me.Day1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Day2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Day3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Day4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Day5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Day6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Day7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Day1, Me.Day2, Me.Day3, Me.Day4, Me.Day5, Me.Day6, Me.Day7})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(578, 492)
        Me.DataGridView1.TabIndex = 0
        '
        'Day1
        '
        Me.Day1.Frozen = True
        Me.Day1.HeaderText = "Day1"
        Me.Day1.Name = "Day1"
        Me.Day1.ReadOnly = True
        Me.Day1.Width = 58
        '
        'Day2
        '
        Me.Day2.Frozen = True
        Me.Day2.HeaderText = "Day2"
        Me.Day2.Name = "Day2"
        Me.Day2.ReadOnly = True
        Me.Day2.Width = 58
        '
        'Day3
        '
        Me.Day3.Frozen = True
        Me.Day3.HeaderText = "Day3"
        Me.Day3.Name = "Day3"
        Me.Day3.ReadOnly = True
        Me.Day3.Width = 58
        '
        'Day4
        '
        Me.Day4.Frozen = True
        Me.Day4.HeaderText = "Day4"
        Me.Day4.Name = "Day4"
        Me.Day4.ReadOnly = True
        Me.Day4.Width = 58
        '
        'Day5
        '
        Me.Day5.Frozen = True
        Me.Day5.HeaderText = "Day5"
        Me.Day5.Name = "Day5"
        Me.Day5.ReadOnly = True
        Me.Day5.Width = 58
        '
        'Day6
        '
        Me.Day6.Frozen = True
        Me.Day6.HeaderText = "Day6"
        Me.Day6.Name = "Day6"
        Me.Day6.ReadOnly = True
        Me.Day6.Width = 58
        '
        'Day7
        '
        Me.Day7.Frozen = True
        Me.Day7.HeaderText = "Day7"
        Me.Day7.Name = "Day7"
        Me.Day7.ReadOnly = True
        Me.Day7.Width = 58
        '
        'weekView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "weekView"
        Me.Size = New System.Drawing.Size(584, 498)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Day1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day7 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
