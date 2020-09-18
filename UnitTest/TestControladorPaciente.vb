Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Threading
Imports capaDatos

<TestClass()> Public Class TestControladorPaciente

    <TestMethod()> Public Sub TestidentificarPaciente()
        Assert.IsNotNull(controladorPacientes.identificarPaciente("19248371", "Pa.19248371"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVarificarDocumentoDeIdentidad()
        Assert.IsNotNull(controladorPacientes.VarificarDocumentoDeIdentidad("19248371", "19248371", "Pa.19248371"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestGuardarDatosPaciente()
        Dim telefonos As New List(Of Integer)
        Dim preExistentes As New List(Of String)
        Assert.IsTrue(controladorPacientes.GuardarDatosPaciente("96325874", "algo@nuevopaciente.com", "Coso", "Perez", "Se",
                                                                "3216", "Los nierys", "brava", "37", "1998-06-06", "1",
                                                                telefonos, preExistentes, "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        Assert.IsTrue(controladorPacientes.CrearUsuarioBD("26325874", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TesteliminiarPacienteBD()
        Assert.IsTrue(controladorPacientes.eliminiarPacienteBD("26325874", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub


End Class