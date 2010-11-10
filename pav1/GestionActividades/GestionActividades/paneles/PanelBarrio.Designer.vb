<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBarrio
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.tableBarrio = New System.Windows.Forms.DataGridView
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.cboCiudad = New System.Windows.Forms.ComboBox
        Me.bt_mas_ciudad = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Barrio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.tableBarrio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Ciudad:"
        '
        'tableBarrio
        '
        Me.tableBarrio.AllowUserToAddRows = False
        Me.tableBarrio.AllowUserToDeleteRows = False
        Me.tableBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableBarrio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Barrio, Me.id_ciudad, Me.Ciudad})
        Me.tableBarrio.Location = New System.Drawing.Point(42, 121)
        Me.tableBarrio.Name = "tableBarrio"
        Me.tableBarrio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableBarrio.Size = New System.Drawing.Size(498, 168)
        Me.tableBarrio.TabIndex = 70
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(133, 42)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(384, 20)
        Me.txt_nombre.TabIndex = 67
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(63, 45)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 66
        Me.lbl_nombre.Text = "Nombre:"
        '
        'cboCiudad
        '
        Me.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCiudad.FormattingEnabled = True
        Me.cboCiudad.Location = New System.Drawing.Point(133, 68)
        Me.cboCiudad.Name = "cboCiudad"
        Me.cboCiudad.Size = New System.Drawing.Size(347, 21)
        Me.cboCiudad.TabIndex = 68
        '
        'bt_mas_ciudad
        '
        Me.bt_mas_ciudad.Location = New System.Drawing.Point(494, 66)
        Me.bt_mas_ciudad.Name = "bt_mas_ciudad"
        Me.bt_mas_ciudad.Size = New System.Drawing.Size(23, 23)
        Me.bt_mas_ciudad.TabIndex = 69
        Me.bt_mas_ciudad.Text = "+"
        Me.bt_mas_ciudad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Barrio:"
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Barrio
        '
        Me.Barrio.Frozen = True
        Me.Barrio.HeaderText = "Barrio"
        Me.Barrio.Name = "Barrio"
        Me.Barrio.ReadOnly = True
        '
        'id_ciudad
        '
        Me.id_ciudad.Frozen = True
        Me.id_ciudad.HeaderText = "id_ciudad"
        Me.id_ciudad.Name = "id_ciudad"
        Me.id_ciudad.ReadOnly = True
        Me.id_ciudad.Visible = False
        '
        'Ciudad
        '
        Me.Ciudad.Frozen = True
        Me.Ciudad.HeaderText = "Ciudad"
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.ReadOnly = True
        '
        'PanelBarrio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bt_mas_ciudad)
        Me.Controls.Add(Me.cboCiudad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tableBarrio)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "PanelBarrio"
        Me.Size = New System.Drawing.Size(586, 496)
        CType(Me.tableBarrio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tableBarrio As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents cboCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents bt_mas_ciudad As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_ciudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ciudad As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
