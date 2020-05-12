<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.dgv_Empleados = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnRegistrarProfesores = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgv_Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Empleados
        '
        Me.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Empleados.Location = New System.Drawing.Point(12, 26)
        Me.dgv_Empleados.Name = "dgv_Empleados"
        Me.dgv_Empleados.Size = New System.Drawing.Size(565, 323)
        Me.dgv_Empleados.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(634, 114)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(110, 52)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Registrar Alumnos"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnRegistrarProfesores
        '
        Me.btnRegistrarProfesores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarProfesores.Location = New System.Drawing.Point(634, 35)
        Me.btnRegistrarProfesores.Name = "btnRegistrarProfesores"
        Me.btnRegistrarProfesores.Size = New System.Drawing.Size(110, 51)
        Me.btnRegistrarProfesores.TabIndex = 2
        Me.btnRegistrarProfesores.Text = "Registrar Profesores"
        Me.btnRegistrarProfesores.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(634, 298)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 37)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Regresar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 380)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnRegistrarProfesores)
        Me.Controls.Add(Me.dgv_Empleados)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form6"
        CType(Me.dgv_Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_Empleados As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnRegistrarProfesores As Button
    Friend WithEvents btnEliminar As Button
End Class
