Imports System.Data.Odbc

Public Class ModeloTiene
    Inherits ModeloConexion

    Public IdDiagnostico As Integer
    Public IdPatologia As Integer

    Public Function GuardarRelacionDiagnosticoPatologia()
        comando.CommandText = "INSERT INTO tiene VALUES(" & Me.idDiagnostico & ", " & Me.idPatologia & ")"
        comando.ExecuteNonQuery()
        cerrarConexion()
        Return True
    End Function
End Class