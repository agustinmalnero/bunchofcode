<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelTareas
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tarea1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tarea2")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lunes", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Martes")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clases")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Miercoles", New System.Windows.Forms.TreeNode() {TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jueves")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Parcial")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Viernes", New System.Windows.Forms.TreeNode() {TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sabado")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Domingo")
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Nodo7"
        TreeNode1.Text = "Tarea1"
        TreeNode2.Name = "Nodo9"
        TreeNode2.Text = "Tarea2"
        TreeNode3.ForeColor = System.Drawing.Color.Navy
        TreeNode3.Name = "nodoLunes"
        TreeNode3.Text = "Lunes"
        TreeNode4.ForeColor = System.Drawing.Color.Teal
        TreeNode4.Name = "Nodo1"
        TreeNode4.Text = "Martes"
        TreeNode5.Name = "Nodo10"
        TreeNode5.Text = "Clases"
        TreeNode6.ForeColor = System.Drawing.Color.Green
        TreeNode6.Name = "Nodo2"
        TreeNode6.Text = "Miercoles"
        TreeNode7.ForeColor = System.Drawing.Color.Olive
        TreeNode7.Name = "Nodo3"
        TreeNode7.Text = "Jueves"
        TreeNode8.Name = "Nodo11"
        TreeNode8.Text = "Parcial"
        TreeNode9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        TreeNode9.Name = "Nodo4"
        TreeNode9.Text = "Viernes"
        TreeNode10.ForeColor = System.Drawing.Color.Maroon
        TreeNode10.Name = "Nodo5"
        TreeNode10.Text = "Sabado"
        TreeNode11.ForeColor = System.Drawing.Color.Purple
        TreeNode11.Name = "Nodo6"
        TreeNode11.Text = "Domingo"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode6, TreeNode7, TreeNode9, TreeNode10, TreeNode11})
        Me.TreeView1.Size = New System.Drawing.Size(186, 495)
        Me.TreeView1.TabIndex = 0
        '
        'PanelTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "PanelTareas"
        Me.Size = New System.Drawing.Size(189, 498)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
