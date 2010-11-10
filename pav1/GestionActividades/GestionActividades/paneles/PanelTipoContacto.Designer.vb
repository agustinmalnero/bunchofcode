<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelTipoContacto
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tableTipoContacto = New System.Windows.Forms.DataGridView
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.tableTipoContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableTipoContacto
        '
        Me.tableTipoContacto.AllowUserToAddRows = False
        Me.tableTipoContacto.AllowUserToDeleteRows = False
        Me.tableTipoContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableTipoContacto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Tipo})
        Me.tableTipoContacto.Location = New System.Drawing.Point(42, 121)
        Me.tableTipoContacto.Name = "tableTipoContacto"
        Me.tableTipoContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableTipoContacto.Size = New System.Drawing.Size(498, 168)
        Me.tableTipoContacto.TabIndex = 66
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(133, 42)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(384, 20)
        Me.txt_nombre.TabIndex = 65
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(63, 45)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 64
        Me.lbl_nombre.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Tipo Contacto:"
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Tipo
        '
        Me.Tipo.Frozen = True
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'PanelTipoContacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tableTipoContacto)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "PanelTipoContacto"
        Me.Size = New System.Drawing.Size(586, 496)
        CType(Me.tableTipoContacto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tableTipoContacto As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
