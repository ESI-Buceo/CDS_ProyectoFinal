Imports System.Data.Odbc
Public Class ModeloRecibe
    Inherits ModeloConexion

    Public DocIdentidad As Integer
    Public IdDiagnostico As Integer

    Public Function GuardarRelacionPacienteDiagnostico()
        comando.CommandText = "INSERT INTO recibe (idDiagnostico, idPaciente) VALUES('" & Me.idDiagnostico & "', " & Me.docIdentidad & ")"
        comando.ExecuteNonQuery()
        cerrarConexion()
        Return True
    End Function
End Class
