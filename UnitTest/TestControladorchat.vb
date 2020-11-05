﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestControladorChat
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestRecibirMensajes()
        'Prueba que el metodo reciba algún valor
        ModeloDiagnostico.CodigoDiagnostico = "161348021"
        Assert.IsNotNull(ControladorChat.RecibirMensajes("M", "19266171", "Me.19266171"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestRecibirMensajesPorSesion()
        'Prueba que el metodo reciba algún valor
        Assert.IsNotNull(ControladorChat.RecibirMensajes("161348021", "M", "19266171", "Me.19266171"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestRecibirTodosMensajes()
        'Prueba que el metodo reciba algún valor
        Assert.IsNotNull(ControladorChat.RecibirTodosMensajes("161348021", "19266171", "Me.19266171"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestEnviarMensajePaciente()
        Try
            ControladorChat.EnviarMensajePaciente("Hola Gato", "161348021", "19248371", "Pa.19248371", "19266171")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestEnviarMensajeMedico()
        Try
            ControladorChat.EnviarMensajeMedico("Que pasó?", "161348021", "19266171", "Me.19266171", "19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMarcarMensajeLeido()
        Try
            ControladorChat.MarcarMensajeLeido("19248371", "19266171", "Me.19266171")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestDatosPaciente()
        Assert.IsNotNull(ControladorChat.DatosPaciente("161348021", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMostrarSintomasPaciente()
        Assert.IsNotNull(ControladorChat.MostrarSintomasPaciente("161348021", "19266171", "Me.19266171"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMarcarEnProceso()
        Try
            ControladorChat.MarcarEnProceso("161348021", "1", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestEnviarChatAEspera()
        Try
            ControladorChat.EnviarChatAEspera("161348021", "19248371", "Pa.19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMensajeInicioDeSesion()
        Try
            ControladorChat.MensajeInicioDeSesion("161348021", "19248371", "Pa.19248371", "19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListaHistoricaChatPaciente()
        Try
            ControladorChat.ListaHistoricaChatPaciente("11111111", "Ge.11111111", "19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCantidadDeChats()
        Dim actual As String = ""
        Assert.AreSame(ControladorChat.CantidadDeChats("11111111", "Ge.11111111", "19248371").GetType(), actual.GetType())
        Thread.Sleep(20)
    End Sub

End Class