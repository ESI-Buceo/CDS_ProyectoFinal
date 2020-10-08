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
        Dim Documento As Integer = "11111111"
        Assert.AreEqual(controladorAdministrativo.VarificarDocumentoDeIdentidad("11111111", "11111111", "Ge.11111111"), Documento)
        Thread.Sleep(20)
        'El metodo de llama vArificar por algún motivo 
    End Sub

    <TestMethod()> Public Sub TestGuardarDatosAdmin()
        Dim Tel As New List(Of String)
        Try
            controladorAdministrativo.GuardarDatosAdmin("12345678", "nuevo@admincontrolador.com",
                                                                     "Cacho", "Castaña", "Argentina", "1234",
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
            controladorAdministrativo.CrearUsuarioBD("65495251", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearCadenaDeBusquedaAdministrativo()
        'Con los parametros que se envian a la función, la misma debería devolver 
        'exactamente el valor que se encuentra dentro de la variable Cadena.
        Dim Cadena As String = "p.docidentidad=11111111"
        Assert.AreEqual(controladorAdministrativo.crearCadenaDeBusquedaAdministrativo("txtDocIdentidad", "11111111"), Cadena)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarAdministrativo()
        Try
            controladorAdministrativo.buscarAdministrativo("p.apellidos LIKE '%fernandez%' AND p.nombres 
                                                                        LIKE '%mario juan%' AND p.docidentidad=11111111 
                                                                        AND", "11111111", "Ge.11111111")

            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarAdministrativoPorDocumento()
        Try
            controladorAdministrativo.BuscarAdministrativoPorDocumento("77777777", "11111111", "Ge.11111111")
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
            controladorAdministrativo.cambiarEstadoAdmin("22222222", "1", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestValidarAdministrativo()
        Try
            controladorAdministrativo.ValidarAdministrativo("11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TesteliminiarUsuarioBD()
        Try
            controladorAdministrativo.eliminiarUsuarioBD("65495251", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarAdministrativosPorEstado()
        Try
            controladorAdministrativo.ListarAdministrativos("1", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarAdministrativos()
        Try
            controladorAdministrativo.ListarAdministrativos("11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Try
            controladorAdministrativo.ListarTelefonos("11111111", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class