<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelContacto
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
        Me.lbl_apellidos = New System.Windows.Forms.Label
        Me.lbl_calle = New System.Windows.Forms.Label
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.lbl_barrio = New System.Windows.Forms.Label
        Me.lbl_ciudad = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_apellidos = New System.Windows.Forms.TextBox
        Me.txt_calle = New System.Windows.Forms.TextBox
        Me.txt_numero = New System.Windows.Forms.TextBox
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.lbl_telefono = New System.Windows.Forms.Label
        Me.lbl_mails = New System.Windows.Forms.Label
        Me.txt_mail = New System.Windows.Forms.TextBox
        Me.cb_telefono = New System.Windows.Forms.ComboBox
        Me.cb_mail = New System.Windows.Forms.ComboBox
        Me.bt_mas_tlfn = New System.Windows.Forms.Button
        Me.bt_mas_mail = New System.Windows.Forms.Button
        Me.btn_menos_tlfn = New System.Windows.Forms.Button
        Me.bt_menos_mail = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(69, 28)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.Location = New System.Drawing.Point(69, 57)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(52, 13)
        Me.lbl_apellidos.TabIndex = 1
        Me.lbl_apellidos.Text = "Apellidos:"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(43, 22)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_calle.TabIndex = 3
        Me.lbl_calle.Text = "Calle:"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(32, 53)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 4
        Me.lbl_numero.Text = "Número"
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(140, 53)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_barrio.TabIndex = 5
        Me.lbl_barrio.Text = "Barrio:"
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.Location = New System.Drawing.Point(315, 54)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(43, 13)
        Me.lbl_ciudad.TabIndex = 6
        Me.lbl_ciudad.Text = "Ciudad:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(139, 25)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(394, 20)
        Me.txt_nombre.TabIndex = 7
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(139, 57)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(394, 20)
        Me.txt_apellidos.TabIndex = 8
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(94, 19)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(393, 20)
        Me.txt_calle.TabIndex = 18
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(94, 51)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(40, 20)
        Me.txt_numero.TabIndex = 19
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(138, 88)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 9
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(64, 91)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 12
        Me.lbl_telefono.Text = "Teléfono:"
        '
        'lbl_mails
        '
        Me.lbl_mails.AutoSize = True
        Me.lbl_mails.Location = New System.Drawing.Point(87, 121)
        Me.lbl_mails.Name = "lbl_mails"
        Me.lbl_mails.Size = New System.Drawing.Size(29, 13)
        Me.lbl_mails.TabIndex = 13
        Me.lbl_mails.Text = "Mail:"
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(138, 118)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(100, 20)
        Me.txt_mail.TabIndex = 13
        '
        'cb_telefono
        '
        Me.cb_telefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_telefono.FormattingEnabled = True
        Me.cb_telefono.Location = New System.Drawing.Point(273, 88)
        Me.cb_telefono.Name = "cb_telefono"
        Me.cb_telefono.Size = New System.Drawing.Size(230, 21)
        Me.cb_telefono.TabIndex = 11
        '
        'cb_mail
        '
        Me.cb_mail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_mail.FormattingEnabled = True
        Me.cb_mail.Location = New System.Drawing.Point(273, 118)
        Me.cb_mail.Name = "cb_mail"
        Me.cb_mail.Size = New System.Drawing.Size(230, 21)
        Me.cb_mail.TabIndex = 15
        '
        'bt_mas_tlfn
        '
        Me.bt_mas_tlfn.Location = New System.Drawing.Point(244, 86)
        Me.bt_mas_tlfn.Name = "bt_mas_tlfn"
        Me.bt_mas_tlfn.Size = New System.Drawing.Size(23, 23)
        Me.bt_mas_tlfn.TabIndex = 10
        Me.bt_mas_tlfn.Text = "+"
        Me.bt_mas_tlfn.UseVisualStyleBackColor = True
        '
        'bt_mas_mail
        '
        Me.bt_mas_mail.Location = New System.Drawing.Point(244, 116)
        Me.bt_mas_mail.Name = "bt_mas_mail"
        Me.bt_mas_mail.Size = New System.Drawing.Size(23, 23)
        Me.bt_mas_mail.TabIndex = 14
        Me.bt_mas_mail.Text = "+"
        Me.bt_mas_mail.UseVisualStyleBackColor = True
        '
        'btn_menos_tlfn
        '
        Me.btn_menos_tlfn.Location = New System.Drawing.Point(509, 88)
        Me.btn_menos_tlfn.Name = "btn_menos_tlfn"
        Me.btn_menos_tlfn.Size = New System.Drawing.Size(23, 23)
        Me.btn_menos_tlfn.TabIndex = 12
        Me.btn_menos_tlfn.Text = "-"
        Me.btn_menos_tlfn.UseVisualStyleBackColor = True
        '
        'bt_menos_mail
        '
        Me.bt_menos_mail.Location = New System.Drawing.Point(509, 116)
        Me.bt_menos_mail.Name = "bt_menos_mail"
        Me.bt_menos_mail.Size = New System.Drawing.Size(23, 23)
        Me.bt_menos_mail.TabIndex = 16
        Me.bt_menos_mail.Text = "-"
        Me.bt_menos_mail.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(183, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(126, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(364, 50)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox2.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(498, 168)
        Me.DataGridView1.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txt_numero)
        Me.GroupBox1.Controls.Add(Me.txt_calle)
        Me.GroupBox1.Controls.Add(Me.lbl_ciudad)
        Me.GroupBox1.Controls.Add(Me.lbl_barrio)
        Me.GroupBox1.Controls.Add(Me.lbl_numero)
        Me.GroupBox1.Controls.Add(Me.lbl_calle)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 88)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dirección"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(138, 147)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox3.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Tipo Contacto::"
        '
        'PanelContacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bt_menos_mail)
        Me.Controls.Add(Me.btn_menos_tlfn)
        Me.Controls.Add(Me.bt_mas_mail)
        Me.Controls.Add(Me.bt_mas_tlfn)
        Me.Controls.Add(Me.cb_mail)
        Me.Controls.Add(Me.cb_telefono)
        Me.Controls.Add(Me.txt_mail)
        Me.Controls.Add(Me.lbl_mails)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_apellidos)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_apellidos)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "PanelContacto"
        Me.Size = New System.Drawing.Size(586, 496)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidos As System.Windows.Forms.Label
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents lbl_barrio As System.Windows.Forms.Label
    Friend WithEvents lbl_ciudad As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellidos As System.Windows.Forms.TextBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_mails As System.Windows.Forms.Label
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents cb_telefono As System.Windows.Forms.ComboBox
    Friend WithEvents cb_mail As System.Windows.Forms.ComboBox
    Friend WithEvents bt_mas_tlfn As System.Windows.Forms.Button
    Friend WithEvents bt_mas_mail As System.Windows.Forms.Button
    Friend WithEvents btn_menos_tlfn As System.Windows.Forms.Button
    Friend WithEvents bt_menos_mail As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
