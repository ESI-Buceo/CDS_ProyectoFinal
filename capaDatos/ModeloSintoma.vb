Imports capaDatos
Imports MySql.Data
Imports System.Data.Odbc
Public Class ModeloSintoma
    Inherits ModeloConexion

    Public ID As Integer
    Public Nombre As String
    Public Estado As Boolean

    Public lector As OdbcDataReader

    Public Function guardarSintoma() As Boolean
        'envia solicitud de guardar
        Return True
    End Function

    Public Function eliminarSintoma(ByVal id As Integer) As Boolean
        'elimina sintoma o lo marca como 0 - inhabilitado
        Return True
    End Function

    Public Function TraeDatosSintomasDeBD() As DataTable
        Dim tabla As New DataTable
        comando.CommandText = "SELECT * FROM sintoma WHERE activo = 1 "
        lector = comando.ExecuteReader()
            tabla.Load(lector)
            Return tabla
    End Function

    Public Function TraeDatosSintomasDeBD(sintoma As String) As DataTable
        Dim tabla As New DataTable
        comando.CommandText = "SELECT * FROM sintoma WHERE activo = 1 AND nombre like '%" + sintoma + "%'"
        lector = comando.ExecuteReader()
        tabla.Load(lector)
        Return tabla
    End Function

End Class
