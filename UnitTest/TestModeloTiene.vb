﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloTiene
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim t As New ModeloTiene(usrGestor, usrGestor)

    Dim numAleatorio1 As New Random()
    Dim valorAleatorio1 As String = numAleatorio1.Next(1, 7)
    Dim numAleatorio2 As New Random()
    Dim valorAleatorio2 As String = numAleatorio2.Next(1, 6)

    <TestMethod()> Public Sub TestGuardarRelacionDiagnosticoPatologia()
        Dim Resultado As Boolean
        Dim Parametro As String = "('273039649','" + valorAleatorio1 + "','" + valorAleatorio2 + "')"
        Try
            t.GuardarRelacionDiagnosticoPatologia(Parametro)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class