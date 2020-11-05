Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModelochat2
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim c As New ModeloChat(usrMedico, usrMedico)

    <TestMethod()> Public Sub TestRecibirTodosMensajes()
        Dim Resultado As Boolean
        Try
            c.RecibirTodosMensajes("282917714")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestRecibirMensajesAppPaciente()
        Dim Resultado As Boolean
        Try
            c.RecibirMensajes("'282917714'", emisor:="M")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(100)
    End Sub

End Class