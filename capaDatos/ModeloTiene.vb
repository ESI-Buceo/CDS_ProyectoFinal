Imports System.Data.Odbc

Public Class ModeloTiene

    Public IdDiagnostico As String
    Public IdPatologia As String

    Public Function GuardarRelacionDiagnosticoPatologia()
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "INSERT INTO tiene VALUES(" & Me.IdDiagnostico & ", " & Me.IdPatologia & ")"
        c.Comando.ExecuteNonQuery()
        c.CerrarConexion()
        Return True
    End Function
End Class