﻿Imports System.Data.Odbc
Public Class ModeloRecibe
    Inherits ModeloConexion

    Public DocIdentidad As String

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function GuardarRelacionPacienteDiagnostico()
        Comando.CommandText = "INSERT INTO recibe (idDiagnostico, idPaciente) VALUES(" & ModeloDiagnostico.CodigoDiagnostico & ", " & Me.DocIdentidad & ")"
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function
End Class
