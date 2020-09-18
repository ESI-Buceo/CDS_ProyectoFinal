Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloPaciente
    Dim p As New ModeloPaciente("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim Resultado As Boolean
        Try
            p.VerificarDocumentoDeIdentidad("'19248371'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub



    <TestMethod()> Public Sub TestCrearUsuarioBD()
        p.RangoIpPaciente = "localhost"
        p.Documento = "54895632"
        Dim Resultado As Boolean
        Try
            p.CrearUsuarioBD()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarPaciente()
        Dim Resultado As Boolean
        Try
            p.BuscarPaciente("p.docidentidad = '19248371' AND p.nombres = 'Andrea Laura'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoPaciente()
        Dim Resultado As Boolean
        Try
            p.CambiarEstadoPaciente("'19248371'", "'1'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestEliminarUsuarioBD()
        p.RangoIpPaciente = "localhost"
        Dim Resultado As Boolean
        Try
            p.EliminarUsuarioBD("54895632")
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarPacientePorDocumento()
        Dim Resultado As Boolean
        Try
            p.buscarPacientePorDocumento("'31256542'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestDatosPaciente()
        Dim Resultado As Boolean
        Try
            p.DatosPaciente("'131345728'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCargarPreExistentes()
        p.Documento = "19248371"
        Dim Resultado As Boolean
        Try
            p.CargarPreExistentes()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPacientes()
        Dim Resultado As Boolean
        Try
            p.ListarPacientes()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPacientesSegunEstado()
        Dim Resultado As Boolean
        Try
            p.ListarPacientes("'1'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Dim Resultado As Boolean
        Try
            p.ListarTelefonos("'19248371'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class