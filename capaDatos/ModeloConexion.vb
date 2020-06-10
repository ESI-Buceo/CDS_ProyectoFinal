Imports System.Data.Odbc
Public Class ModeloConexion

    Dim conexion As New Odbc.OdbcConnection("DRIVER=MySQL ODBC 5.3 ANSI Driver;UID=u876920732_proyectocds;PWD=npvtcADR;PORT=3306;DATABASE=u876920732_dbTriage;SERVER=213.190.6.127")
    Public Function Abrir() As OdbcConnection
        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception

        End Try
    End Function

    Public Sub Cerrar()
        Try
            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
