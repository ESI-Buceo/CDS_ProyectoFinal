﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloChat
    Dim c As New ModeloChat("19266171", "Me.19266171")
    <TestMethod()> Public Sub TestEnviarMensaje()
        c.docidentidadPaciente = "19248371"
        c.docidentidadMedico = "19266171"
        c.idSesion = "161348021"
        c.emisor = "M"
        c.mensaje = "Hola Carola"

        Dim Resultado As Boolean
        Try
            c.enviarMensaje()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestRecibirMensajes()
        ModeloDiagnostico.CodigoDiagnostico = "161348021"

        Dim Resultado As Boolean
        Try
            c.RecibirMensajes(emisor:="M")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMarcarMensajeLeido()
        Dim Resultado As Boolean
        Try
            c.MarcarMensajeLeido("16")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub



    <TestMethod()> Public Sub TestCantidadDeChats()
        Dim Resultado As Boolean
        Try
            c.CantidadDeChats("19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class