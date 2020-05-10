Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class cls_Datos
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("miConexion").ConnectionString))
    'Mostrar asignaturas
    Dim cmd As New SqlCommand("SELECT * FROM dbo.Asignatura", cn)
    'cn.Open()
    'cmd.CommandType= CommandType.Text
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable
    'da.Fill(dt)
    'cn.Close()
    'Return dt
End Class
