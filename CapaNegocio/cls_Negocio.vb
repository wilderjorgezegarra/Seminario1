Imports CapaDatos
Imports CapaEntidad
Public Class cls_Negocio
    Private ObjDatos As New cls_Datos

    Public Function N_ListarEmpleados() As DataTable
        Return ObjDatos.D_ListarEmpleados
    End Function

    Public Sub N_InsertarEmpleados(enti As cls_Entidad)
        ObjDatos.D_InsertarEmpleados(enti)
    End Sub
End Class
