Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloInformes
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim i As New ModeloInformes(usrGestor, usrGestor)

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

    <TestMethod()> Public Sub TestSintomasNuncaSeleccionados()
        Dim Resultado As Boolean
        Try
            i.SintomasNuncaSeleccionados()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class