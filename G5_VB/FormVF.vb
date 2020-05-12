Imports CapaNegocio
Imports CapaEntidad

Public Class FormVF
    Dim objNego As New cls_Negocio
    Dim objEnti As New cls_Entidad
    Dim codigo As New Integer
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
        'codigo = dgv_Asignaturas.CurrentRow.Cells.Item(0).Value
        objEnti.nomAsi = codigo
        objNego.N_EliminarAsignaturas(objEnti)
        MessageBox.Show("Dato eliminados correctamente")
        Listar_Asignaturas()
    End Sub

    Private Sub dgv_Asignaturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Asignaturas.CellContentClick
        'Dim a = dgv_Asignaturas.Rows(e.RowIndex)
        codigo = dgv_Asignaturas.CurrentRow.Cells.Item(0).Value
        'MessageBox.Show(codigo)


    End Sub
End Class