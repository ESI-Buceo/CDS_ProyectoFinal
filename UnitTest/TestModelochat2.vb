Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModelochat2
    Dim c As New ModeloChat("19266171", "Me.19266171")

    <TestMethod()> Public Sub TestRecibirTodosMensajes()
        Dim Resultado As Boolean
        Try
            c.RecibirTodosMensajes("161348021")
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
            c.RecibirMensajes("'161348021'", emisor:="M")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(100)
    End Sub

End Class