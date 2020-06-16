Imports System.Data.Odbc

Public Class ModeloTiene
    Inherits ModeloConexion

    Public idDiagnostico As Integer
    Public idPatologia As Integer

    Public Function guardarRelacionDiagnosticoPatologia()
        comando.CommandText = "INSERT INTO tiene VALUES(" & Me.idDiagnostico & ", " & Me.idPatologia & ")"
        comando.ExecuteNonQuery()
        cerrarConexion()
        Return True
    End Function
End Class