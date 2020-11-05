Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading


<TestClass()> Public Class TestModeloSintoma
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim s As New ModeloSintoma(usrGestor, usrGestor)

    Dim Resultado As New Boolean
    <TestMethod()> Public Sub TestGuardarSintoma()
        s.ID = "201"
        s.Nombre = "Rengueo como loco"
        s.Estado = "1"

        Try
            s.GuardarSintoma()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBorrarSintoma()
        s.ID = "96"
        Try
            s.BorrarSintoma()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestTraeDatosSintomasDeBD()
        Try
            s.TraeDatosSintomasDeBD()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestTraeDatosSintomasDeBDPorNombre()
        Try
            s.TraeDatosSintomasDeBD("Tos")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarSintomasXPatologia()
        Try
            s.ListarSintomasXPatologia("100")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestSintomasIngresadosPorPaciente()
        Try
            s.SintomasIngresadosPorPaciente("282917714")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarSintomas()
        Try
            s.ListarSintomas("1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTodosLosSintomas()
        Try
            s.ListarTodosLosSintomas()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class