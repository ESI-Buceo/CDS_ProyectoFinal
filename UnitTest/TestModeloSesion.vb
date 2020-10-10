Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloSesion
    Dim s As New ModeloSesion("11111111", "Ge.11111111")
    Dim Resultado As New Boolean
    <TestMethod()> Public Sub TestGuardarSesion()
        s.IdSesion = "12345678"
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
            s.MostrarSesionesEnEspera("1234")
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
        ModeloDiagnostico.CodigoDiagnostico = "131345728"
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
        ModeloDiagnostico.CodigoDiagnostico = "131345728"
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
            s.GuardarEstado("131345728", "3")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestGuardarEstado()
        s.IdSesion = "131345728"
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
            s.VerificarEstadoSesion("131345728")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestSesionesPorMedico()
        Try
            s.SesionesPorMedico("09", "19266173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub


End Class