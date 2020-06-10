Imports System.Data.Odbc
Public Class ModeloRecibe
    Public docIdentidad As Integer
    Public idDiagnostico As Integer

    Public Function guardarRelacionPacienteDiagnostico()
        Dim conexion As New ModeloConexion
        Dim comando As New OdbcCommand
        Try
            comando.CommandText = "INSERT INTO recibe (idDiagnostico, idPaciente) VALUES('" & Me.idDiagnostico & "', " & Me.docIdentidad & ")"
            comando.Connection = conexion.Abrir
            comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
