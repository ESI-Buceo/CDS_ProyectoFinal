Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloSesion
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim s As New ModeloSesion(usrGestor, usrGestor)
    Dim Resultado As New Boolean

    <TestMethod()> Public Sub TestGuardarSesion()
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(500000000, 999999999)
        s.IdSesion = valorAleatorio
        s.Prioridad = "20"

        Try
            s.GuardarSesion()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMostrarSesionesPendientes()
        Try
            s.MostrarSesionesPendientes()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMostrarSesionesEnProceso()
        Try
            s.MostrarSesionesEnProceso()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMostrarSesionesEnEspera()
        Try
            s.MostrarSesionesEnEspera(usrMedico)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMostrarSesionesFinalizadas()
        Try
            s.MostrarSesionesFinalizadas()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestMostrarSesionesCanceladasUsuarios()
        Try
            s.MostrarSesionesCanceladasUsuarios()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVerificarEstadoSesion()
        ModeloDiagnostico.CodigoDiagnostico = "282917714"
        Try
            s.VerificarEstadoSesion()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestDevolverNombreApellidoMedico()
        ModeloDiagnostico.CodigoDiagnostico = "282917714"
        Try
            s.DevolverNombreApellidoMedico()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestGuardarEstadoPorId()
        Try
            s.GuardarEstado("282917714", "3")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestGuardarEstado()
        s.IdSesion = "282917714"
        Try
            s.GuardarEstado("3")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVerificarEstadoSesionPorparametro()
        Try
            s.VerificarEstadoSesion("282917714")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestSesionesPorMedico()
        Try
            s.SesionesPorMedico("09", usrMedico)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub


End Class