Imports CapaEntidad
Imports CapaDatos
Public Class cls_Negocio
    Private ObjDatos As New cls_Datos
    Public Function N_ListarAsignaturas() As DataTable
        Return ObjDatos.D_ListarAsignaturas
    End Function
    Public Sub N_InsertarAsignaturas(enti As cls_Entidad)
        ObjDatos.D_insertarAsignatura(enti)
    End Sub

    Public Sub N_EliminarAsignaturas(enti As cls_Entidad)
        ObjDatos.D_eliminarAsignatura(enti)
    End Sub
End Class
