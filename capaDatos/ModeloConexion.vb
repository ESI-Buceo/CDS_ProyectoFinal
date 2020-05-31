Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class ModeloConexion
    Dim conexion As New MySqlConnection("server=localhost;database=proyectocds;user=root;password=;port=3306")

    Public Function Abrir() As MySqlConnection
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
