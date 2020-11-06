Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports capaDatos
Imports System.Windows.Forms
Imports System.Threading

<TestClass()> Public Class TestControladorAdministrativo

    Dim Resultado As Boolean

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        'La función devuelve un documento que se pasa por parámetro. 
        'Se comparan los resultados.
        Dim Documento As Integer = "40713841"
        Assert.AreEqual(controladorAdministrativo.VarificarDocumentoDeIdentidad("40713841", "40713841", "40713841"), Documento)
        Thread.Sleep(20)
        'El metodo de llama vArificar por algún motivo 
    End Sub

    <TestMethod()> Public Sub TestGuardarDatosAdmin()
        Dim Tel As New List(Of String)
        Try
            controladorAdministrativo.GuardarDatosAdmin("12345678", "nuevo@admincontrolador.com",
                                                                     "Cacho", "Castaña", "Argentina", "1234",
                                                                     "La Boca", "Tanguito", "", "1950-10-10", Tel,
                                                                     "3288", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        'Se comenta porque no funciona en la escuela
        'Try
        ' controladorAdministrativo.CrearUsuarioBD("65495251", "40713841", "40713841")
        'Resultado = True
        'Catch ex As Exception
        ' Resultado = False
        ' End Try
        'Assert.IsTrue(Resultado)
        'Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearCadenaDeBusquedaAdministrativo()
        'Con los parametros que se envian a la función, la misma debería devolver 
        'exactamente el valor que se encuentra dentro de la variable Cadena.
        Dim Cadena As String = "p.docidentidad=40713841"
        Assert.AreEqual(controladorAdministrativo.crearCadenaDeBusquedaAdministrativo("txtDocIdentidad", "40713841"), Cadena)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarAdministrativo()
        Try
            controladorAdministrativo.buscarAdministrativo("p.apellidos LIKE '%fernandez%' AND p.nombres 
                                                                        LIKE '%mario juan%' AND p.docidentidad=40713841 
                                                                        AND", "40713841", "40713841")

            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarAdministrativoPorDocumento()
        Try
            controladorAdministrativo.BuscarAdministrativoPorDocumento("77777777", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearTablaTelefono()
        Try
            controladorAdministrativo.crearTablaTelefonos()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcambiarEstadoAdmin()
        Try
            controladorAdministrativo.cambiarEstadoAdmin("22222222", "1", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestValidarAdministrativo()
        Try
            controladorAdministrativo.ValidarAdministrativo("40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TesteliminiarUsuarioBD()
        'Se comento porque no funciona en la escuela
        'Try
        ' controladorAdministrativo.eliminiarUsuarioBD("65495251", "40713841", "40713841")
        'Resultado = True
        'Catch ex As Exception
        'Resultado = False
        'End Try
        'Assert.IsTrue(Resultado)
        'Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarAdministrativosPorEstado()
        Try
            controladorAdministrativo.ListarAdministrativos("1", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarAdministrativos()
        Try
            controladorAdministrativo.ListarAdministrativos("40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Try
            controladorAdministrativo.ListarTelefonos("40713841", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class