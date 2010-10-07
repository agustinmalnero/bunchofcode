<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelAcciones
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
        Me.btnActividad = New System.Windows.Forms.Button
        Me.btnReunion = New System.Windows.Forms.Button
        Me.btnPlanificar = New System.Windows.Forms.Button
        Me.btnContactos = New System.Windows.Forms.Button
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.SuspendLayout()
        '
        'btnActividad
        '
        Me.btnActividad.Location = New System.Drawing.Point(0, 6)
        Me.btnActividad.Name = "btnActividad"
        Me.btnActividad.Size = New System.Drawing.Size(180, 42)
        Me.btnActividad.TabIndex = 0
        Me.btnActividad.Text = "Actividad"
        Me.btnActividad.UseVisualStyleBackColor = True
        '
        'btnReunion
        '
        Me.btnReunion.Location = New System.Drawing.Point(0, 54)
        Me.btnReunion.Name = "btnReunion"
        Me.btnReunion.Size = New System.Drawing.Size(180, 40)
        Me.btnReunion.TabIndex = 1
        Me.btnReunion.Text = "Reunion"
        Me.btnReunion.UseVisualStyleBackColor = True
        '
        'btnPlanificar
        '
        Me.btnPlanificar.Location = New System.Drawing.Point(0, 100)
        Me.btnPlanificar.Name = "btnPlanificar"
        Me.btnPlanificar.Size = New System.Drawing.Size(180, 42)
        Me.btnPlanificar.TabIndex = 2
        Me.btnPlanificar.Text = "Planificar"
        Me.btnPlanificar.UseVisualStyleBackColor = True
        '
        'btnContactos
        '
        Me.btnContactos.Location = New System.Drawing.Point(0, 148)
        Me.btnContactos.Name = "btnContactos"
        Me.btnContactos.Size = New System.Drawing.Size(180, 42)
        Me.btnContactos.TabIndex = 3
        Me.btnContactos.Text = "Contactos"
        Me.btnContactos.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 202)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'PanelAcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnContactos)
        Me.Controls.Add(Me.btnPlanificar)
        Me.Controls.Add(Me.btnReunion)
        Me.Controls.Add(Me.btnActividad)
        Me.Name = "PanelAcciones"
        Me.Size = New System.Drawing.Size(180, 366)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnActividad As System.Windows.Forms.Button
    Friend WithEvents btnReunion As System.Windows.Forms.Button
    Friend WithEvents btnPlanificar As System.Windows.Forms.Button
    Friend WithEvents btnContactos As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar

End Class
