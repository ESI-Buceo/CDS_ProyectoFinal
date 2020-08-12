Imports System.Data.Odbc

Public Class ModeloTiene
    Inherits ModeloConexion

    Public IdDiagnostico As String
    Public IdPatologia As String
    Public IdSintoma As String

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function GuardarRelacionDiagnosticoPatologia(ByVal stringSQL As String)
        Comando.CommandText = "INSERT INTO tiene VALUES" & stringSQL
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function

End Class