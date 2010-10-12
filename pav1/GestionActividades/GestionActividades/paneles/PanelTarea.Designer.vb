<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelTarea
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.cb_ciudad = New System.Windows.Forms.ComboBox
        Me.cb_barrio = New System.Windows.Forms.ComboBox
        Me.txt_numero = New System.Windows.Forms.TextBox
        Me.txt_calle = New System.Windows.Forms.TextBox
        Me.lbl_ciudad = New System.Windows.Forms.Label
        Me.lbl_barrio = New System.Windows.Forms.Label
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.lbl_calle = New System.Windows.Forms.Label
        Me.cb_nombre = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btn_mas_lugar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tb_descripcion = New System.Windows.Forms.TextBox
        Me.gb_lugar = New System.Windows.Forms.GroupBox
        Me.gb_tarea = New System.Windows.Forms.GroupBox
        Me.tb_nombre = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_lugar.SuspendLayout()
        Me.gb_tarea.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nombre:"
        '
        'cb_ciudad
        '
        Me.cb_ciudad.FormattingEnabled = True
        Me.cb_ciudad.Location = New System.Drawing.Point(354, 79)
        Me.cb_ciudad.Name = "cb_ciudad"
        Me.cb_ciudad.Size = New System.Drawing.Size(123, 21)
        Me.cb_ciudad.TabIndex = 31
        Me.cb_ciudad.Visible = False
        '
        'cb_barrio
        '
        Me.cb_barrio.FormattingEnabled = True
        Me.cb_barrio.Location = New System.Drawing.Point(173, 80)
        Me.cb_barrio.Name = "cb_barrio"
        Me.cb_barrio.Size = New System.Drawing.Size(126, 21)
        Me.cb_barrio.TabIndex = 30
        Me.cb_barrio.Visible = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(84, 80)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(40, 20)
        Me.txt_numero.TabIndex = 29
        Me.txt_numero.Visible = False
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(84, 48)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(393, 20)
        Me.txt_calle.TabIndex = 28
        Me.txt_calle.Visible = False
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.Location = New System.Drawing.Point(305, 83)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(43, 13)
        Me.lbl_ciudad.TabIndex = 27
        Me.lbl_ciudad.Text = "Ciudad:"
        Me.lbl_ciudad.Visible = False
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(130, 82)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_barrio.TabIndex = 26
        Me.lbl_barrio.Text = "Barrio:"
        Me.lbl_barrio.Visible = False
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(24, 79)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 25
        Me.lbl_numero.Text = "Número"
        Me.lbl_numero.Visible = False
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(35, 51)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_calle.TabIndex = 24
        Me.lbl_calle.Text = "Calle:"
        Me.lbl_calle.Visible = False
        '
        'cb_nombre
        '
        Me.cb_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_nombre.FormattingEnabled = True
        Me.cb_nombre.Location = New System.Drawing.Point(84, 17)
        Me.cb_nombre.Name = "cb_nombre"
        Me.cb_nombre.Size = New System.Drawing.Size(316, 21)
        Me.cb_nombre.TabIndex = 33
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 283)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(498, 171)
        Me.DataGridView1.TabIndex = 35
        '
        'btn_mas_lugar
        '
        Me.btn_mas_lugar.Location = New System.Drawing.Point(406, 15)
        Me.btn_mas_lugar.Name = "btn_mas_lugar"
        Me.btn_mas_lugar.Size = New System.Drawing.Size(23, 23)
        Me.btn_mas_lugar.TabIndex = 36
        Me.btn_mas_lugar.Text = "+"
        Me.btn_mas_lugar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Descripción:"
        '
        'tb_descripcion
        '
        Me.tb_descripcion.Location = New System.Drawing.Point(89, 50)
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(393, 20)
        Me.tb_descripcion.TabIndex = 34
        '
        'gb_lugar
        '
        Me.gb_lugar.Controls.Add(Me.btn_mas_lugar)
        Me.gb_lugar.Controls.Add(Me.cb_nombre)
        Me.gb_lugar.Controls.Add(Me.cb_ciudad)
        Me.gb_lugar.Controls.Add(Me.cb_barrio)
        Me.gb_lugar.Controls.Add(Me.txt_numero)
        Me.gb_lugar.Controls.Add(Me.txt_calle)
        Me.gb_lugar.Controls.Add(Me.lbl_ciudad)
        Me.gb_lugar.Controls.Add(Me.lbl_barrio)
        Me.gb_lugar.Controls.Add(Me.lbl_numero)
        Me.gb_lugar.Controls.Add(Me.lbl_calle)
        Me.gb_lugar.Controls.Add(Me.Label3)
        Me.gb_lugar.Location = New System.Drawing.Point(45, 137)
        Me.gb_lugar.Name = "gb_lugar"
        Me.gb_lugar.Size = New System.Drawing.Size(498, 119)
        Me.gb_lugar.TabIndex = 40
        Me.gb_lugar.TabStop = False
        Me.gb_lugar.Text = "Lugar"
        '
        'gb_tarea
        '
        Me.gb_tarea.Controls.Add(Me.tb_nombre)
        Me.gb_tarea.Controls.Add(Me.Label4)
        Me.gb_tarea.Controls.Add(Me.tb_descripcion)
        Me.gb_tarea.Controls.Add(Me.Label6)
        Me.gb_tarea.Location = New System.Drawing.Point(45, 37)
        Me.gb_tarea.Name = "gb_tarea"
        Me.gb_tarea.Size = New System.Drawing.Size(497, 85)
        Me.gb_tarea.TabIndex = 41
        Me.gb_tarea.TabStop = False
        Me.gb_tarea.Text = "Tarea"
        '
        'tb_nombre
        '
        Me.tb_nombre.Location = New System.Drawing.Point(89, 23)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(393, 20)
        Me.tb_nombre.TabIndex = 38
        '
        'Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gb_tarea)
        Me.Controls.Add(Me.gb_lugar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Panel"
        Me.Size = New System.Drawing.Size(586, 496)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_lugar.ResumeLayout(False)
        Me.gb_lugar.PerformLayout()
        Me.gb_tarea.ResumeLayout(False)
        Me.gb_tarea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents cb_barrio As System.Windows.Forms.ComboBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ciudad As System.Windows.Forms.Label
    Friend WithEvents lbl_barrio As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents cb_nombre As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_mas_lugar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

    'Private Sub Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '
    '   End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents gb_lugar As System.Windows.Forms.GroupBox
    Friend WithEvents gb_tarea As System.Windows.Forms.GroupBox
    Friend WithEvents tb_nombre As System.Windows.Forms.TextBox
End Class
