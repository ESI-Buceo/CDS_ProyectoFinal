Imports System.Data.Odbc

Public Class ModeloTiene
    Public idDiagnostico As Integer
    Public idPatologia As Integer

    Public Function guardarRelacionDiagnosticoPatologia()
        Dim conexion As New ModeloConexion
        Dim comando As New OdbcCommand
        Try
            comando.CommandText = "INSERT INTO tiene VALUES(" & Me.idDiagnostico & ", " & Me.idPatologia & ")"
            comando.Connection = conexion.Abrir
            comando.ExecuteNonQuery()
            conexion.Cerrar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class