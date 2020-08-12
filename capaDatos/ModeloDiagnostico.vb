Imports System.Data.Odbc

Public Class ModeloDiagnostico
    Inherits ModeloConexion

    Public Shared CodigoDiagnostico As String
    Public Shared Ponderacion As String

    Public Sub New(ByRef uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function GuardarDiagnostico() As Boolean
        'codigo para guardar el diagnostico en la base de datos
        Comando.CommandText = "INSERT INTO diagnostico VALUES (" & CodigoDiagnostico & ", " & Ponderacion & ")"
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function
End Class
