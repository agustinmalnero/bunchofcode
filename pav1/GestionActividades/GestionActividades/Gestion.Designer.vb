<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaGestion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaGestion))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.IniciarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.btnPreferencias = New System.Windows.Forms.ToolStripSplitButton
        Me.menuUsuario = New System.Windows.Forms.ToolStripMenuItem
        Me.menuCiudades = New System.Windows.Forms.ToolStripMenuItem
        Me.menuBarrios = New System.Windows.Forms.ToolStripMenuItem
        Me.menuCategorias = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancel = New System.Windows.Forms.ToolStripButton
        Me.panelIzquierda = New System.Windows.Forms.Panel
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.panelDerecha = New System.Windows.Forms.Panel
        Me.centralPanel = New System.Windows.Forms.Panel
        Me.buttonsPanel = New System.Windows.Forms.Panel
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 534)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(965, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.btnPreferencias, Me.ToolStripSeparator1, Me.btnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(965, 30)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSesionToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(37, 27)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'IniciarSesionToolStripMenuItem
        '
        Me.IniciarSesionToolStripMenuItem.Name = "IniciarSesionToolStripMenuItem"
        Me.IniciarSesionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.IniciarSesionToolStripMenuItem.Text = "Iniciar Sesion"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 27)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Sincronizar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(28, 27)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Consultas"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(28, 27)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Estadisticas"
        '
        'btnPreferencias
        '
        Me.btnPreferencias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPreferencias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuUsuario, Me.menuCiudades, Me.menuBarrios, Me.menuCategorias})
        Me.btnPreferencias.Image = CType(resources.GetObject("btnPreferencias.Image"), System.Drawing.Image)
        Me.btnPreferencias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreferencias.Name = "btnPreferencias"
        Me.btnPreferencias.Size = New System.Drawing.Size(40, 27)
        Me.btnPreferencias.Text = "Preferencias"
        '
        'menuUsuario
        '
        Me.menuUsuario.Name = "menuUsuario"
        Me.menuUsuario.Size = New System.Drawing.Size(194, 22)
        Me.menuUsuario.Text = "Administrar Usuarios"
        '
        'menuCiudades
        '
        Me.menuCiudades.Name = "menuCiudades"
        Me.menuCiudades.Size = New System.Drawing.Size(194, 22)
        Me.menuCiudades.Text = "Administrar Ciudades"
        '
        'menuBarrios
        '
        Me.menuBarrios.Name = "menuBarrios"
        Me.menuBarrios.Size = New System.Drawing.Size(194, 22)
        Me.menuBarrios.Text = "Administrar Barrios"
        '
        'menuCategorias
        '
        Me.menuCategorias.Name = "menuCategorias"
        Me.menuCategorias.Size = New System.Drawing.Size(194, 22)
        Me.menuCategorias.Text = "Administrar Categorias"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(28, 27)
        Me.btnCancel.Text = "Cancelar"
        '
        'panelIzquierda
        '
        Me.panelIzquierda.Location = New System.Drawing.Point(0, 33)
        Me.panelIzquierda.Name = "panelIzquierda"
        Me.panelIzquierda.Size = New System.Drawing.Size(180, 366)
        Me.panelIzquierda.TabIndex = 2
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(965, 556)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 183
        Me.LineShape1.X2 = 183
        Me.LineShape1.Y1 = 33
        Me.LineShape1.Y2 = 531
        '
        'panelDerecha
        '
        Me.panelDerecha.Location = New System.Drawing.Point(776, 33)
        Me.panelDerecha.Name = "panelDerecha"
        Me.panelDerecha.Size = New System.Drawing.Size(189, 498)
        Me.panelDerecha.TabIndex = 4
        '
        'centralPanel
        '
        Me.centralPanel.Location = New System.Drawing.Point(186, 33)
        Me.centralPanel.Name = "centralPanel"
        Me.centralPanel.Size = New System.Drawing.Size(584, 498)
        Me.centralPanel.TabIndex = 5
        '
        'buttonsPanel
        '
        Me.buttonsPanel.Location = New System.Drawing.Point(3, 405)
        Me.buttonsPanel.Name = "buttonsPanel"
        Me.buttonsPanel.Size = New System.Drawing.Size(177, 126)
        Me.buttonsPanel.TabIndex = 6
        '
        'VentanaGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 556)
        Me.Controls.Add(Me.buttonsPanel)
        Me.Controls.Add(Me.centralPanel)
        Me.Controls.Add(Me.panelDerecha)
        Me.Controls.Add(Me.panelIzquierda)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.Name = "VentanaGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestion de Actividades"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents panelIzquierda As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents IniciarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents panelDerecha As System.Windows.Forms.Panel
    Friend WithEvents centralPanel As System.Windows.Forms.Panel
    Friend WithEvents buttonsPanel As System.Windows.Forms.Panel
    Friend WithEvents btnPreferencias As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents menuUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCiudades As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuBarrios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCategorias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton

End Class
