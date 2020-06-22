Imports System.Data.Odbc

Public Class ModeloDiagnostico

    Public IdDiagnostico As String
    Public Prioridad As Integer

    Public Function GuardarDiagnostico() As Boolean
        'codigo para guardar el diagnostico en la base de datos
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "INSERT INTO diagnostico VALUES (" & Me.IdDiagnostico & ", " & Me.Prioridad & ")"
        c.Comando.ExecuteNonQuery()
        c.CerrarConexion()
        Return True
    End Function
End Class
