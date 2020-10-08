Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Threading
Imports capaDatos

<TestClass()> Public Class TestControladorPaciente
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestidentificarPaciente()
        Assert.IsNotNull(controladorPacientes.identificarPaciente("19248371", "Pa.19248371"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVarificarDocumentoDeIdentidad()
        Assert.IsNotNull(controladorPacientes.VarificarDocumentoDeIdentidad("19248371", "19248371", "Pa.19248371"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestGuardarDatosPaciente()
        Dim telefonos As New List(Of String)
        Dim preExistentes As New List(Of String)
        Try
            controladorPacientes.GuardarDatosPaciente("96325874", "algo@nuevopaciente.com", "Coso", "Perez", "Se",
                                                                "3216", "Los nierys", "brava", "37", "1998-06-06", "1",
                                                                telefonos, preExistentes, "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        Try
            controladorPacientes.CrearUsuarioBD("26325874", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TesteliminiarPacienteBD()
        Try
            controladorPacientes.eliminiarPacienteBD("26325874", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoPaciente()
        Assert.IsNotNull(controladorPacientes.CambiarEstadoPaciente("96325874", "1", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarPacientePorDocumento()
        Assert.IsNotNull(controladorPacientes.buscarPacientePorDocumento("96325874", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarPaciente()
        Assert.IsNotNull(controladorPacientes.buscarPaciente("96325874", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    '<TestMethod()> Public Sub TestformatearSqlBuscquedaPaciente()
    '    Assert.IsNotNull(controladorPacientes.formatearSqlBuscquedaPaciente("13245"))
    '    Thread.Sleep(20)
    'End Sub

    <TestMethod()> Public Sub TestcrearTablaTelefono()
        Assert.IsNotNull(controladorPacientes.crearTablaTelefonos())
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearTablaPreExistentes()
        Assert.IsNotNull(controladorPacientes.crearTablaPreExistentes())
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearCadenaDeBusquedaPaciente()
        Assert.IsNotNull(controladorPacientes.crearCadenaDeBusquedaPaciente("txtDocIdentidad", "11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCargarEnfermedadesPreExistentes()
        Assert.IsNotNull(controladorPacientes.CargarEnfermedadesPreExistentes("96325874", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPacientes()
        Assert.IsNotNull(controladorPacientes.ListarPacientes("11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPacientesPorEstado()
        Assert.IsNotNull(controladorPacientes.ListarPacientes("1", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Assert.IsNotNull(controladorPacientes.ListarTelefonos("96325874", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

End Class