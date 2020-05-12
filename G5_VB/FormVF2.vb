Imports CapaEntidad
Imports CapaNegocio

Public Class FormVF_I
    Dim objNeg As New cls_Negocio
    Dim objEnt As New cls_Entidad
    Private Sub FormVF_I_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNomAsi.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        objEnt.nomAsi = txtNomAsi.Text
        objNeg.N_InsertarAsignaturas(objEnt)
        MessageBox.Show("Datoa agregados correctamente")
        Me.Close()
    End Sub
End Class