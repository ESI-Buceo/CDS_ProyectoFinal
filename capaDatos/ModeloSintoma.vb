Imports capaDatos
Imports MySql.Data
Imports System.Data.Odbc
Public Class ModeloSintoma

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
        Dim conexion As New ModeloConexion
        Dim tabla As New DataTable
        Dim comando As New OdbcCommand
        Try
            comando.CommandText = "SELECT * FROM sintoma WHERE activo = 1 "
            comando.Connection = conexion.Abrir()
            lector = comando.ExecuteReader()
            tabla.Load(lector)
            conexion.Cerrar()
            Return tabla
        Catch ex As Exception
            Return tabla
        End Try

    End Function

    Public Function TraeDatosSintomasDeBD(sintoma As String) As DataTable
        Dim conexion As New ModeloConexion
        Dim tabla As New DataTable
        Dim comando As New OdbcCommand
        Try
            comando.CommandText = "SELECT * FROM sintoma WHERE activo = 1 AND nombre like '%" + sintoma + "%'"
            comando.Connection = conexion.Abrir()
            lector = comando.ExecuteReader()
            tabla.Load(lector)
            Return tabla
            conexion.Cerrar()
        Catch ex As Exception
            Return tabla
        End Try
    End Function

End Class
