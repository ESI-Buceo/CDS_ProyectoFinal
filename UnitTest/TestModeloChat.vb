Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloChat
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim c As New ModeloChat(usrMedico, usrMedico)
    <TestMethod()> Public Sub TestEnviarMensaje()
        c.docidentidadPaciente = usrPaciente
        c.docidentidadMedico = usrMedico
        c.idSesion = "282917714"
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

    <TestMethod()> Public Sub TestRecibirMensajesPorDiagnostico()
        ModeloDiagnostico.CodigoDiagnostico = "282917714"

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
        'se pasa por parametro el id del chat para marcarlo como leido 
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
            c.CantidadDeChats(usrMedico)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListaHistoricaChatPaciente()
        Dim Resultado As Boolean
        Try
            c.ListaHistoricaChatPaciente(usrMedico)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class