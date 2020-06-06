Imports System.Data.Odbc
Public Class ModeloConexion

    Dim conexion As New Odbc.OdbcConnection("DRIVER=MySQL ODBC 5.3 ANSI Driver;UID=rgainza;PWD=Aleand.06.2020;PORT=3306;DATABASE=dbTriage;SERVER=192.168.1.15")
    Public Function Abrir() As Odbc.OdbcConnection
        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception
            MsgBox("falla de conexion")
        End Try
    End Function

    Public Sub Cerrar()
        Try
            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
