Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad

Public Class cls_Datos
    'Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("Proyecto").ConnectionString)
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cursoMVC.My.MySettings.conexion").ConnectionString)
    'Mostrar asignaturas
    Public Function D_ListarAsignaturas() As DataTable
        Dim cmd As New SqlCommand("SELECT * FROM Asignatura", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt
    End Function

    'Insertar asignaturas
    Public Sub D_insertarAsignatura(enti As cls_Entidad)
        Dim cmd As New SqlCommand("insert into Asignatura values(@nomAsi)", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@nomAsi", enti.nomasi)
        End With
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd.Parameters.Clear()
    End Sub

    'Eliminar asignaturas
    Public Sub D_eliminarAsignatura(enti As cls_Entidad)
        Dim cmd As New SqlCommand("delete from Asignatura where nomAsi=@nomAsi", cn)
        cn.Open()
        cmd.CommandType = CommandType.Text
        With cmd.Parameters
            .AddWithValue("@nomAsi", enti.nomasi)
        End With
        cmd.ExecuteNonQuery()
        cn.Close()
        cmd.Parameters.Clear()
    End Sub

End Class
