Imports System.Data.Odbc
Public Class ModeloConexion
    'Dim conexion As New MySqlConnection("server=192.168.1.15;database=proyectocds;user=pepe;password=Pepe1234*;port=3306")
    Dim conexion As New Odbc.OdbcConnection("DRIVER=MySQL ODBC 5.3 ANSI Driver;UID=marcos;PWD=admin;PORT=3306;DATABASE=dbTriage;SERVER=localhost")
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
