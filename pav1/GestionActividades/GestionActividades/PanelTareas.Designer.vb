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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lunes")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Martes")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Miercoles")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jueves")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Viernes")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sabado")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Domingo")
        Me.tree = New System.Windows.Forms.TreeView
        Me.SuspendLayout()
        '
        'tree
        '
        Me.tree.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tree.Location = New System.Drawing.Point(0, 0)
        Me.tree.Name = "tree"
        TreeNode1.ForeColor = System.Drawing.Color.Navy
        TreeNode1.Name = "nodoLunes"
        TreeNode1.Text = "Lunes"
        TreeNode2.ForeColor = System.Drawing.Color.Teal
        TreeNode2.Name = "Nodo1"
        TreeNode2.Text = "Martes"
        TreeNode3.ForeColor = System.Drawing.Color.Green
        TreeNode3.Name = "Nodo2"
        TreeNode3.Text = "Miercoles"
        TreeNode4.ForeColor = System.Drawing.Color.Olive
        TreeNode4.Name = "Nodo3"
        TreeNode4.Text = "Jueves"
        TreeNode5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        TreeNode5.Name = "Nodo4"
        TreeNode5.Text = "Viernes"
        TreeNode6.ForeColor = System.Drawing.Color.Maroon
        TreeNode6.Name = "Nodo5"
        TreeNode6.Text = "Sabado"
        TreeNode7.ForeColor = System.Drawing.Color.Purple
        TreeNode7.Name = "Nodo6"
        TreeNode7.Text = "Domingo"
        Me.tree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Me.tree.Size = New System.Drawing.Size(186, 495)
        Me.tree.TabIndex = 0
        '
        'PanelTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tree)
        Me.Name = "PanelTareas"
        Me.Size = New System.Drawing.Size(189, 498)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tree As System.Windows.Forms.TreeView

End Class
