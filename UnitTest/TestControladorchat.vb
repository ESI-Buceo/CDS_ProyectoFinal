Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestControladorChat

    <TestMethod()> Public Sub TestRecibirMensajes()
        ModeloDiagnostico.CodigoDiagnostico = "161348021"
        Assert.IsNotNull(ControladorChat.RecibirMensajes("M", "19266171", "Me.19266171"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestRecibirMensajesPorSesion()
        Assert.IsNotNull(ControladorChat.RecibirMensajes("161348021", "M", "19266171", "Me.19266171"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestRecibirTodosMensajes()
        Assert.IsNotNull(ControladorChat.RecibirTodosMensajes("161348021", "19266171", "Me.19266171"))
        Thread.Sleep(20)
    End Sub

    '<TestMethod()> Public Sub TestEnviarMensajePaciente()
    '    Assert.IsTrue(ControladorChat.EnviarMensajePaciente("Hola Gato", "161348021", "19248371", "Pa.19248371", "19266171"))
    '    Thread.Sleep(20)
    'End Sub

    '<TestMethod()> Public Sub TestEnviarMensajeMedico()
    '    Assert.IsTrue(ControladorChat.EnviarMensajeMedico("Que pasó?", "161348021", "19266171", "Me.19266171", "19248371"))
    '    Thread.Sleep(20)
    'End Sub

    '<TestMethod()> Public Sub TestMarcarMensajeLeido()
    '    Assert.IsTrue(ControladorChat.MarcarMensajeLeido("19248371", "19266171", "Me.19266171"))
    '    Thread.Sleep(20)
    'End Sub

    <TestMethod()> Public Sub TestDatosPaciente()
        Assert.IsNotNull(ControladorChat.DatosPaciente("161348021", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMostrarSintomasPaciente()
        Assert.IsNotNull(ControladorChat.MostrarSintomasPaciente("161348021", "19266171", "Me.19266171"))
        Thread.Sleep(20)
    End Sub

    '<TestMethod()> Public Sub TestMarcarEnProceso()
    '    Assert.IsTrue(ControladorChat.MarcarEnProceso("161348021", "1", "11111111", "Ge.11111111"))
    '    Thread.Sleep(20)
    'End Sub

    '<TestMethod()> Public Sub TestEnviarChatAEspera()
    '    Assert.IsTrue(ControladorChat.EnviarChatAEspera("161348021", "19248371", "Pa.19248371"))
    '    Thread.Sleep(20)
    'End Sub

    '<TestMethod()> Public Sub TestMensajeInicioDeSesion()
    '    Assert.IsTrue(ControladorChat.MensajeInicioDeSesion("161348021", "19248371", "Pa.19248371", "19248371"))
    '    Thread.Sleep(20)
    'End Sub

    '<TestMethod()> Public Sub TestmarcarchatEnProceso()
    '    Assert.IsTrue(ControladorChat.marcarchatEnProceso("161348021", "19248371", "Pa.19248371"))
    '    Thread.Sleep(20)
    'End Sub

    '<TestMethod()> Public Sub TestenviarMensajeDeEspera()
    '    Assert.IsTrue(ControladorChat.enviarMensajeDeEspera("161348021", "19266171", "Me.19266171", "19248371"))
    '    Thread.Sleep(20)
    'End Sub

    <TestMethod()> Public Sub TestListaHistoricaChatPaciente()
        Assert.IsNotNull(ControladorChat.ListaHistoricaChatPaciente("11111111", "Ge.11111111", "19248371"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCantidadDeChats()
        Assert.IsNotNull(ControladorChat.CantidadDeChats("11111111", "Ge.11111111", "19248371"))
        Thread.Sleep(20)
    End Sub

End Class