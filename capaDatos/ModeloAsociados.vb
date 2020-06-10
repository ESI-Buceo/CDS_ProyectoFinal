Imports System.Data.Odbc

Public Class ModeloAsociados
    Public IdPatologia As Integer
    Public IdSintoma As Integer
    Public IdSigno As Integer
    Public incluida As Boolean
    Public lectorAsociados As OdbcDataReader

    Public Function CargarListaAsociadosBD()
        'carga la lista de la tabla asociados donde se vinculan patologias, sintomas y signos
        Dim conexion As New ModeloConexion
        Dim comando As New OdbcCommand
        Dim tabla As New DataTable
        Try
            comando.CommandText = "SELECT DISTINCT(a.idPatologia), a.idPatologia, a.idSintoma, a.idSigno FROM asociados a JOIN patologia p ON p.activo = 1"
            comando.Connection = conexion.Abrir()
            lectorAsociados = comando.ExecuteReader()
            tabla.Load(lectorAsociados)
            conexion.Cerrar()
            Return tabla
        Catch ex As Exception
            Return False
        End Try
    End Function


End Class
