<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelReunion
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
        Me.cb_actividad = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.table = New System.Windows.Forms.DataGridView
        Me.gb_lugar = New System.Windows.Forms.GroupBox
        Me.bt_mas_lugar = New System.Windows.Forms.Button
        Me.cb_nombre = New System.Windows.Forms.ComboBox
        Me.cb_ciudad = New System.Windows.Forms.ComboBox
        Me.cb_barrio = New System.Windows.Forms.ComboBox
        Me.txt_numero = New System.Windows.Forms.TextBox
        Me.txt_calle = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cb_contactos = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fk_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Actividad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fk_lugar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lugar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fk_contacto = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_lugar.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_actividad
        '
        Me.cb_actividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_actividad.FormattingEnabled = True
        Me.cb_actividad.Location = New System.Drawing.Point(127, 44)
        Me.cb_actividad.Name = "cb_actividad"
        Me.cb_actividad.Size = New System.Drawing.Size(364, 21)
        Me.cb_actividad.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Actividad"
        '
        'table
        '
        Me.table.AllowUserToAddRows = False
        Me.table.AllowUserToDeleteRows = False
        Me.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.fk_actividad, Me.Actividad, Me.fk_lugar, Me.Lugar, Me.fk_contacto})
        Me.table.Location = New System.Drawing.Point(44, 244)
        Me.table.MultiSelect = False
        Me.table.Name = "table"
        Me.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table.Size = New System.Drawing.Size(498, 213)
        Me.table.TabIndex = 62
        '
        'gb_lugar
        '
        Me.gb_lugar.Controls.Add(Me.bt_mas_lugar)
        Me.gb_lugar.Controls.Add(Me.cb_nombre)
        Me.gb_lugar.Controls.Add(Me.cb_ciudad)
        Me.gb_lugar.Controls.Add(Me.cb_barrio)
        Me.gb_lugar.Controls.Add(Me.txt_numero)
        Me.gb_lugar.Controls.Add(Me.txt_calle)
        Me.gb_lugar.Controls.Add(Me.Label1)
        Me.gb_lugar.Controls.Add(Me.Label5)
        Me.gb_lugar.Controls.Add(Me.Label6)
        Me.gb_lugar.Controls.Add(Me.Label7)
        Me.gb_lugar.Controls.Add(Me.Label8)
        Me.gb_lugar.Location = New System.Drawing.Point(42, 73)
        Me.gb_lugar.Name = "gb_lugar"
        Me.gb_lugar.Size = New System.Drawing.Size(498, 119)
        Me.gb_lugar.TabIndex = 54
        Me.gb_lugar.TabStop = False
        Me.gb_lugar.Text = "Lugar"
        '
        'bt_mas_lugar
        '
        Me.bt_mas_lugar.Location = New System.Drawing.Point(406, 15)
        Me.bt_mas_lugar.Name = "bt_mas_lugar"
        Me.bt_mas_lugar.Size = New System.Drawing.Size(23, 23)
        Me.bt_mas_lugar.TabIndex = 27
        Me.bt_mas_lugar.Text = "+"
        Me.bt_mas_lugar.UseVisualStyleBackColor = True
        '
        'cb_nombre
        '
        Me.cb_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_nombre.FormattingEnabled = True
        Me.cb_nombre.Location = New System.Drawing.Point(84, 17)
        Me.cb_nombre.Name = "cb_nombre"
        Me.cb_nombre.Size = New System.Drawing.Size(316, 21)
        Me.cb_nombre.TabIndex = 26
        '
        'cb_ciudad
        '
        Me.cb_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ciudad.Enabled = False
        Me.cb_ciudad.FormattingEnabled = True
        Me.cb_ciudad.Location = New System.Drawing.Point(354, 79)
        Me.cb_ciudad.Name = "cb_ciudad"
        Me.cb_ciudad.Size = New System.Drawing.Size(123, 21)
        Me.cb_ciudad.TabIndex = 31
        '
        'cb_barrio
        '
        Me.cb_barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_barrio.Enabled = False
        Me.cb_barrio.FormattingEnabled = True
        Me.cb_barrio.Location = New System.Drawing.Point(173, 80)
        Me.cb_barrio.Name = "cb_barrio"
        Me.cb_barrio.Size = New System.Drawing.Size(126, 21)
        Me.cb_barrio.TabIndex = 30
        '
        'txt_numero
        '
        Me.txt_numero.Enabled = False
        Me.txt_numero.Location = New System.Drawing.Point(84, 80)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(40, 20)
        Me.txt_numero.TabIndex = 29
        '
        'txt_calle
        '
        Me.txt_calle.Enabled = False
        Me.txt_calle.Location = New System.Drawing.Point(84, 48)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(393, 20)
        Me.txt_calle.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(305, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Ciudad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(130, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Barrio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(24, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Número"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(35, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Calle:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Contactos:"
        '
        'cb_contactos
        '
        Me.cb_contactos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_contactos.FormattingEnabled = True
        Me.cb_contactos.Location = New System.Drawing.Point(126, 207)
        Me.cb_contactos.Name = "cb_contactos"
        Me.cb_contactos.Size = New System.Drawing.Size(364, 21)
        Me.cb_contactos.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Reunion:"
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'fk_actividad
        '
        Me.fk_actividad.Frozen = True
        Me.fk_actividad.HeaderText = "fk_actividad"
        Me.fk_actividad.Name = "fk_actividad"
        Me.fk_actividad.ReadOnly = True
        Me.fk_actividad.Visible = False
        '
        'Actividad
        '
        Me.Actividad.Frozen = True
        Me.Actividad.HeaderText = "Actividad"
        Me.Actividad.Name = "Actividad"
        Me.Actividad.ReadOnly = True
        '
        'fk_lugar
        '
        Me.fk_lugar.Frozen = True
        Me.fk_lugar.HeaderText = "fk_lugar"
        Me.fk_lugar.Name = "fk_lugar"
        Me.fk_lugar.ReadOnly = True
        Me.fk_lugar.Visible = False
        '
        'Lugar
        '
        Me.Lugar.Frozen = True
        Me.Lugar.HeaderText = "Lugar"
        Me.Lugar.Name = "Lugar"
        Me.Lugar.ReadOnly = True
        '
        'fk_contacto
        '
        Me.fk_contacto.Frozen = True
        Me.fk_contacto.HeaderText = "fk_contacto"
        Me.fk_contacto.Name = "fk_contacto"
        Me.fk_contacto.ReadOnly = True
        Me.fk_contacto.Visible = False
        '
        'PanelReunion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_contactos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.table)
        Me.Controls.Add(Me.gb_lugar)
        Me.Controls.Add(Me.cb_actividad)
        Me.Controls.Add(Me.Label4)
        Me.Name = "PanelReunion"
        Me.Size = New System.Drawing.Size(586, 496)
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_lugar.ResumeLayout(False)
        Me.gb_lugar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_actividad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents table As System.Windows.Forms.DataGridView
    Friend WithEvents gb_lugar As System.Windows.Forms.GroupBox
    Friend WithEvents bt_mas_lugar As System.Windows.Forms.Button
    Friend WithEvents cb_nombre As System.Windows.Forms.ComboBox
    Friend WithEvents cb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents cb_barrio As System.Windows.Forms.ComboBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_contactos As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fk_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fk_lugar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lugar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fk_contacto As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
