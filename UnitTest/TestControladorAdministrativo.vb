Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports capaDatos
Imports System.Windows.Forms
Imports System.Threading

<TestClass()> Public Class TestControladorAdministrativo

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Assert.IsNotNull(controladorAdministrativo.VerificarDocumentoDeIdentidad("11111111", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestGuardarDatosAdmin()
        Dim Tel As New List(Of Integer)

        Assert.IsTrue(controladorAdministrativo.GuardarDatosAdmin("12345678", "nuevo@admincontrolador.com",
                                                                     "Cacho", "Castaña", "Argentina", "1234",
                                                                     "La Boca", "Tanguito", "", "1950-10-10", Tel,
                                                                     "3288", "11111111", "Ge.11111111"))
    End Sub

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        Assert.IsTrue(controladorAdministrativo.CrearUsuarioBD("65495251", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearCadenaDeBusquedaAdministrativo()
        Assert.IsNotNull(controladorAdministrativo.crearCadenaDeBusquedaAdministrativo("txtDocIdentidad", "11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarAdministrativo()
        Assert.IsNotNull(controladorAdministrativo.buscarAdministrativo("77777777", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarAdministrativoPorDocumento()
        Assert.IsNotNull(controladorAdministrativo.BuscarAdministrativoPorDocumento("77777777", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearTablaTelefono()
        Assert.IsNotNull(controladorAdministrativo.crearTablaTelefonos())
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestformatearSqlBuscquedaAdministrativo()
        Assert.IsNotNull(controladorAdministrativo.formatearSqlBuscquedaAdministrativo("13245"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcambiarEstadoAdmin()
        Assert.IsNotNull(controladorAdministrativo.cambiarEstadoAdmin("22222222", "1", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestValidarAdministrativo()
        Assert.IsNotNull(controladorAdministrativo.ValidarAdministrativo("11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TesteliminiarUsuarioBD()
        Assert.IsTrue(controladorAdministrativo.eliminiarUsuarioBD("65495251", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCambiarPassword()
        Assert.IsTrue(controladorAdministrativo.CambiarPassword("11111111", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarAdministrativosPorEstado()
        Assert.IsNotNull(controladorAdministrativo.ListarAdministrativos("1", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarAdministrativos()
        Assert.IsNotNull(controladorAdministrativo.ListarAdministrativos("11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Assert.IsNotNull(controladorAdministrativo.ListarTelefonos("11111111", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

End Class