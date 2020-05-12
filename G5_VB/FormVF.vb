Imports CapaNegocio
Imports CapaEntidad

Public Class FormVF
    Dim objNego As New cls_Negocio
    Dim objEnti As New cls_Entidad
    Private Sub FormVF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Asignaturas()
    End Sub
    Sub Listar_Asignaturas()
        Dim dt As DataTable = objNego.N_ListarAsignaturas()
        dgv_Asignaturas.DataSource = dt
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmVF2 As New FormVF_I
        frmVF2.ShowDialog()
        Listar_Asignaturas()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        objEnti.nomAsi = "Investigacion II"
        objNego.N_EliminarAsignaturas(objEnti)
        MessageBox.Show("Datoa eliminados correctamente")
        Listar_Asignaturas()
    End Sub
End Class