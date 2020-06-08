Imports System.Data.Odbc

Public Class ModeloDiagnostico
    Public idDiagnostico As String
    Public Prioridad As Integer

    Public Function guardarDiagnostico(ByRef diagnostico As ModeloDiagnostico) As Boolean
        'codigo para guardar el diagnostico en la base de datos
        Try
            Dim conexion As New ModeloConexion
            Dim comando As New OdbcCommand

            'Guarda registro de diagnostico
            comando.CommandText = "INSERT INTO diagnostico (id, prioridad) VALUES (" & Me.idDiagnostico & ", " & Me.Prioridad & ")"
            comando.Connection = conexion.Abrir()
            comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
