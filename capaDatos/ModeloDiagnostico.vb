Imports System.Data.Odbc

Public Class ModeloDiagnostico
    Inherits ModeloConexion

    Public IdDiagnostico As String
    Public Prioridad As Integer

    Public Function GuardarDiagnostico(ByRef diagnostico As ModeloDiagnostico) As Boolean
        'codigo para guardar el diagnostico en la base de datos
        comando.CommandText = "INSERT INTO diagnostico (id, prioridad) VALUES (" & Me.idDiagnostico & ", " & Me.Prioridad & ")"
        comando.ExecuteNonQuery()
        cerrarConexion()
        Return True
    End Function
End Class
