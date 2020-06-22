Imports System.Data.Odbc
Public Class ModeloRecibe

    Public DocIdentidad As String
    Public IdDiagnostico As String

    Public Function GuardarRelacionPacienteDiagnostico()
        Dim c As New ModeloConexion
        c.conectar()
        c.Comando.CommandText = "INSERT INTO recibe (idDiagnostico, idPaciente) VALUES(" & Me.IdDiagnostico & ", " & Me.DocIdentidad & ")"
        c.Comando.ExecuteNonQuery()
        c.CerrarConexion()
        Return True
    End Function
End Class
