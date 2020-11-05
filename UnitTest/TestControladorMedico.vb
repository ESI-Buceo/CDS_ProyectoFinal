Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Threading

<TestClass()> Public Class TestControladorMedico
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestidentificarMedico()
        Try
            ControladorMedico.identificarMedico("19266172", "19266172")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim Documento As Integer = "19266172"
        Assert.AreEqual(ControladorMedico.VarificarDocumentoDeIdentidad("19266172", "40713841", "40713841"), Documento)
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

    '<TestMethod()> Public Sub TestCrearUsuarioBD()
    '    Try
    '        ControladorMedico.crearUsuarioBD("41752836", "40713841", "40713841")
    '        Resultado = True
    '    Catch ex As Exception
    '        Resultado = False
    '    End Try
    '    Assert.IsTrue(Resultado)
    '    Thread.Sleep(20)
    'End Sub

    <TestMethod()> Public Sub TestcrearCadenaDeBusqueda()
        'Con los parametros que se envian a la función, la misma debería devolver 
        'exactamente el valor que se encuentra dentro de la variable Cadena.
        Dim Cadena As String = "p.docidentidad=78345678"
        Assert.AreEqual(ControladorMedico.crearCadenaDeBusquedaMedico("txtDocIdentidad", "78345678"), Cadena)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarMedico()
        Try
            ControladorMedico.buscarMedico("p.apellidos LIKE '%Curita%' AND p.nombres 
                                            LIKE '%Alberto%' AND p.docidentidad=78345678 
                                            AND", "40713841", "40713841")

            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarMedicoPorDocumento()
        Try
            ControladorMedico.buscarMedicoPorDocumento("19266172", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearTablaTelefono()
        Try
            ControladorMedico.crearTablaTelefonos()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcambiarEstadoMedico()
        Try
            ControladorMedico.CambiarEstadoMedico("78345678", "1", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TesteliminiarUsuarioBD()
        Try
            ControladorMedico.eliminiarUsuarioBD("41752836", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarMedicosPorEstado()
        Try
            ControladorMedico.ListarMedicos("1", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarMedicos()
        Try
            ControladorMedico.ListarMedicos("40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Try
            ControladorMedico.ListarTelefonos("19266172", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarSesionesDeChat()
        Try
            ControladorMedico.ListarSesionesDeChat("40713841", "40713841", "19266172")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class