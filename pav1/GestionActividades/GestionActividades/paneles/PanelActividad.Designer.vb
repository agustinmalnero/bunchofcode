<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelActividad
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
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cb_categoria = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_descripcion = New System.Windows.Forms.TextBox
        Me.tableActividad = New System.Windows.Forms.DataGridView
        Me.bt_agregar_tarea = New System.Windows.Forms.Button
        Me.dtp_inicio = New System.Windows.Forms.DateTimePicker
        Me.dtp_fin = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Inicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fin = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.tableActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(74, 40)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fin:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(136, 40)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(377, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Categoría:"
        '
        'cb_categoria
        '
        Me.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(136, 96)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(205, 21)
        Me.cb_categoria.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Descripción:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(136, 128)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(377, 20)
        Me.txt_descripcion.TabIndex = 5
        '
        'tableActividad
        '
        Me.tableActividad.AllowUserToAddRows = False
        Me.tableActividad.AllowUserToDeleteRows = False
        Me.tableActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableActividad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Descripcion, Me.Categoria, Me.Inicio, Me.Fin})
        Me.tableActividad.Location = New System.Drawing.Point(44, 187)
        Me.tableActividad.MultiSelect = False
        Me.tableActividad.Name = "tableActividad"
        Me.tableActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableActividad.Size = New System.Drawing.Size(498, 273)
        Me.tableActividad.TabIndex = 21
        '
        'bt_agregar_tarea
        '
        Me.bt_agregar_tarea.Location = New System.Drawing.Point(44, 158)
        Me.bt_agregar_tarea.Name = "bt_agregar_tarea"
        Me.bt_agregar_tarea.Size = New System.Drawing.Size(98, 23)
        Me.bt_agregar_tarea.TabIndex = 6
        Me.bt_agregar_tarea.Text = "Agrear Tarea"
        Me.bt_agregar_tarea.UseVisualStyleBackColor = True
        '
        'dtp_inicio
        '
        Me.dtp_inicio.Location = New System.Drawing.Point(136, 70)
        Me.dtp_inicio.Name = "dtp_inicio"
        Me.dtp_inicio.Size = New System.Drawing.Size(175, 20)
        Me.dtp_inicio.TabIndex = 2
        '
        'dtp_fin
        '
        Me.dtp_fin.Location = New System.Drawing.Point(342, 70)
        Me.dtp_fin.Name = "dtp_fin"
        Me.dtp_fin.Size = New System.Drawing.Size(171, 20)
        Me.dtp_fin.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Actividad:"
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Nombre
        '
        Me.Nombre.Frozen = True
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.Frozen = True
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Inicio
        '
        Me.Inicio.Frozen = True
        Me.Inicio.HeaderText = "Inicio"
        Me.Inicio.Name = "Inicio"
        Me.Inicio.ReadOnly = True
        Me.Inicio.Visible = False
        '
        'Fin
        '
        Me.Fin.Frozen = True
        Me.Fin.HeaderText = "Fin"
        Me.Fin.Name = "Fin"
        Me.Fin.ReadOnly = True
        Me.Fin.Visible = False
        '
        'PanelActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_fin)
        Me.Controls.Add(Me.dtp_inicio)
        Me.Controls.Add(Me.bt_agregar_tarea)
        Me.Controls.Add(Me.tableActividad)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_categoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "PanelActividad"
        Me.Size = New System.Drawing.Size(586, 496)
        CType(Me.tableActividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents tableActividad As System.Windows.Forms.DataGridView

    'Private Sub PanelActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '
    '   End Sub
    Friend WithEvents bt_agregar_tarea As System.Windows.Forms.Button
    Friend WithEvents dtp_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
