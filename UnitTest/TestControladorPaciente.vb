Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Threading
Imports capaDatos

<TestClass()> Public Class TestControladorPaciente
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestidentificarPaciente()
        Try
            controladorPacientes.identificarPaciente("19248371", "Pa.19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVarificarDocumentoDeIdentidad()
        'La función devuelve un documento que se pasa por parámetro. 
        'Se comparan los resultados.
        Dim Documento As Integer = "19248371"
        Assert.AreEqual(controladorPacientes.VarificarDocumentoDeIdentidad("19248371", "19248371", "Pa.19248371"), Documento)
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
        Try
            controladorPacientes.CambiarEstadoPaciente("96325874", "1", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarPacientePorDocumento()
        Try
            controladorPacientes.buscarPacientePorDocumento("96325874", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarPaciente()
        Try
            controladorPacientes.buscarPaciente("p.apellidos LIKE '%Perez%' AND p.nombres 
                                                 LIKE '%Coso%' AND p.docidentidad=96325874
                                                 AND", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)

    End Sub

    <TestMethod()> Public Sub TestcrearTablaTelefono()
        Try
            controladorPacientes.crearTablaTelefonos()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearTablaPreExistentes()
        Try
            controladorPacientes.crearTablaPreExistentes()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearCadenaDeBusquedaPaciente()
        'Con los parametros que se envian a la función, la misma debería devolver 
        'exactamente el valor que se encuentra dentro de la variable Cadena.
        Dim Cadena As String = "p.docidentidad=96325874"
        Assert.AreEqual(controladorPacientes.crearCadenaDeBusquedaPaciente("txtDocIdentidad", "96325874"), Cadena)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCargarEnfermedadesPreExistentes()
        Try
            controladorPacientes.CargarEnfermedadesPreExistentes("96325874", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPacientes()
        Try
            controladorPacientes.ListarPacientes("11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPacientesPorEstado()
        Try
            controladorPacientes.ListarPacientes("1", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Try
            controladorPacientes.ListarTelefonos("96325874", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class