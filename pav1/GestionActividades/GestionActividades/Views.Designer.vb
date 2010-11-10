<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Views
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
        Me.btnMonth = New System.Windows.Forms.Button
        Me.btnWeek = New System.Windows.Forms.Button
        Me.btnDay = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnMonth
        '
        Me.btnMonth.Location = New System.Drawing.Point(3, 3)
        Me.btnMonth.Name = "btnMonth"
        Me.btnMonth.Size = New System.Drawing.Size(74, 22)
        Me.btnMonth.TabIndex = 0
        Me.btnMonth.Text = "<"
        Me.btnMonth.UseVisualStyleBackColor = True
        '
        'btnWeek
        '
        Me.btnWeek.Location = New System.Drawing.Point(3, 31)
        Me.btnWeek.Name = "btnWeek"
        Me.btnWeek.Size = New System.Drawing.Size(171, 22)
        Me.btnWeek.TabIndex = 1
        Me.btnWeek.Text = "Semana"
        Me.btnWeek.UseVisualStyleBackColor = True
        '
        'btnDay
        '
        Me.btnDay.Location = New System.Drawing.Point(3, 59)
        Me.btnDay.Name = "btnDay"
        Me.btnDay.Size = New System.Drawing.Size(171, 22)
        Me.btnDay.TabIndex = 2
        Me.btnDay.Text = "Dia"
        Me.btnDay.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 22)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Views
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDay)
        Me.Controls.Add(Me.btnWeek)
        Me.Controls.Add(Me.btnMonth)
        Me.Name = "Views"
        Me.Size = New System.Drawing.Size(177, 126)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMonth As System.Windows.Forms.Button
    Friend WithEvents btnWeek As System.Windows.Forms.Button
    Friend WithEvents btnDay As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
