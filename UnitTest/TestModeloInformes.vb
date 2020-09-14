﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloInformes

    <TestMethod()> Public Sub TestRankigPatologias()
        Dim i As New ModeloInformes("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            i.RankigPatologias(DateTime.Now.ToString("MM"))
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestDiagnosticosBrindados()
        Dim i As New ModeloInformes("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            i.DiagnosticosBrindados(DateTime.Now.ToString("MM"))
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestCantidadChat()
        Dim i As New ModeloInformes("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            i.CantidadChat(DateTime.Now.ToString("MM"))
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestCantidadChatMes()
        Dim i As New ModeloInformes("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            i.CantidadChatMes("2", "2020")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

End Class