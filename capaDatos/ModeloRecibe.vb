Imports System.Data.Odbc
Public Class ModeloRecibe
    Inherits ModeloConexion

    Public docIdentidad As Integer
    Public idDiagnostico As Integer

    Public Function guardarRelacionPacienteDiagnostico()
        comando.CommandText = "INSERT INTO recibe (idDiagnostico, idPaciente) VALUES('" & Me.idDiagnostico & "', " & Me.docIdentidad & ")"
        comando.ExecuteNonQuery()
        cerrarConexion()
        Return True
    End Function
End Class
