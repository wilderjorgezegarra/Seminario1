﻿Imports CapaNegocio
Public Class Form6
    Dim objNego As New cls_Negocio
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEmpleado()

    End Sub
    Sub ListarEmpleado()
        Dim dt As DataTable = objNego.N_ListarEmpleados
        dgv_Empleados.DataSource = dt
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form2 As New Form2
        form2.ShowDialog()
        ListarEmpleado()

    End Sub
End Class