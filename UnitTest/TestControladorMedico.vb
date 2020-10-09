Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Threading

<TestClass()> Public Class TestControladorMedico
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestidentificarMedico()
        Try
            ControladorMedico.identificarMedico("19266171", "Me.19266171")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim Documento As Integer = "19266173"
        Assert.AreEqual(ControladorMedico.VarificarDocumentoDeIdentidad("19266173", "11111111", "Ge.11111111"), Documento)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestGuardarDatosMedico()
        Dim Tel As New List(Of String)
        Try
            ControladorMedico.GuardarDatosMedico("78345678", "nuevo@medicocontrolador.com",
                                                                     "Alberto", "Curita", "Algo", "1234",
                                                                     "La Boca", "Tanguito", "", "1950-10-10", Tel,
                                                                     "3288", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        Try
            ControladorMedico.crearUsuarioBD("41752836", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearCadenaDeBusqueda()
        Assert.IsNotNull(ControladorMedico.crearCadenaDeBusquedaMedico("txtDocIdentidad", "78345678"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarMedico()
        Assert.IsNotNull(ControladorMedico.buscarMedico("78345678", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarMedicoPorDocumento()
        Assert.IsNotNull(ControladorMedico.buscarMedicoPorDocumento("19266173", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearTablaTelefono()
        Assert.IsNotNull(ControladorMedico.crearTablaTelefonos())
        Thread.Sleep(20)
    End Sub

    '<TestMethod()> Public Sub TestformatearSqlBuscquedaMedico()
    '    Assert.IsNotNull(ControladorMedico.formatearSqlBuscquedaMedico("13245"))
    '    Thread.Sleep(20)
    'End Sub

    <TestMethod()> Public Sub TestcambiarEstadoMedico()
        Assert.IsNotNull(ControladorMedico.CambiarEstadoMedico("78345678", "1", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TesteliminiarUsuarioBD()
        Try
            ControladorMedico.eliminiarUsuarioBD("41752836", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarMedicosPorEstado()
        Assert.IsNotNull(ControladorMedico.ListarMedicos("1", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarMedicos()
        Assert.IsNotNull(ControladorMedico.ListarMedicos("11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Assert.IsNotNull(ControladorMedico.ListarTelefonos("19266173", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

End Class