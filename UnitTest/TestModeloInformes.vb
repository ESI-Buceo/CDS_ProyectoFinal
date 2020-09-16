﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloInformes
    Dim i As New ModeloInformes("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestRankigPatologias()
        Dim Resultado As Boolean
        Try
            i.RankigPatologias(DateTime.Now.ToString("MM"))
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestDiagnosticosBrindados()
        Dim Resultado As Boolean
        Try
            i.DiagnosticosBrindados(DateTime.Now.ToString("MM"))
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCantidadChat()
        Dim Resultado As Boolean
        Try
            i.CantidadChat(DateTime.Now.ToString("MM"))
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCantidadChatMes()
        Dim Resultado As Boolean
        Try
            i.CantidadChatMes("2", "2020")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class