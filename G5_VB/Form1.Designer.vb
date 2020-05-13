<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.dgv_Asignaturas = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_Asignaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Location = New System.Drawing.Point(41, 170)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_Nuevo.TabIndex = 0
        Me.btn_Nuevo.Text = "&Nuevo"
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Location = New System.Drawing.Point(132, 170)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Editar.TabIndex = 1
        Me.btn_Editar.Text = "Editar"
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(225, 170)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 2
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'dgv_Asignaturas
        '
        Me.dgv_Asignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Asignaturas.Location = New System.Drawing.Point(12, 12)
        Me.dgv_Asignaturas.Name = "dgv_Asignaturas"
        Me.dgv_Asignaturas.Size = New System.Drawing.Size(327, 150)
        Me.dgv_Asignaturas.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 202)
        Me.Controls.Add(Me.dgv_Asignaturas)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_Asignaturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_Editar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents dgv_Asignaturas As DataGridView
End Class
