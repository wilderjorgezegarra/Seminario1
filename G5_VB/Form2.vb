Imports CapaNegocio
Imports CapaEntidad
Public Class Form2
    Dim objNeg As New cls_Negocio
    Dim objEnt As New cls_Entidad
    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
        Me.Hide()
    End Sub
    'boton guardar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        objEnt.nombres = txtNombres.Text
        objEnt.edad = txtEdad.Text
        objEnt.sexo = txtSexo.Text
        objEnt.escuela = txtEscuela.Text

        objNeg.N_InsertarEmpleados(objEnt)
        MessageBox.Show("Datos guardados correctamente")
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class