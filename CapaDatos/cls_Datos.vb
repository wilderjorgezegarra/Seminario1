Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class cls_Datos
    'se comentó para poder testear quitar comilla

    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("G5_VB.My.MySettings.conexion").ConnectionString)
    'Mostrar TABLA
    Public Function D_ListarEmpleados() As DataTable

        Dim cmd As New SqlCommand("SELECT * FROM dbo.Alumnos", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Sub D_InsertarEmpleados(enti As cls_Entidad)
        Dim cmd As New SqlCommand("INSERT INTO ALUMNOS VALUES (@nombres, @edad, @sexo, @escuela)", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@nombres", enti.nombres)
            .AddWithValue("@edad", enti.edad)
            .AddWithValue("@sexo", enti.sexo)
            .AddWithValue("@escuela", enti.escuela)
        End With
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd.Parameters.Clear()
    End Sub
End Class
