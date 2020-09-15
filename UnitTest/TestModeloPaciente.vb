Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloPaciente
    Dim p As New ModeloPaciente("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim Resultado As Boolean
        Try
            p.VerificarDocumentoDeIdentidad("19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestGuardarDatosPaciente()
        Dim Resultado As Boolean
        Dim Telefono As New DataTable
        Telefono.Columns.Add("Telefono")
        Telefono.Rows.Add("097654978")
        Telefono.Rows.Add("097789456")

        p.Documento = "31256542"
        p.Email = "nuevo@paciente.com"
        p.Nombres = "Maria"
        p.Apellidos = "De los Dolores"
        p.Calle = "Quebrada"
        p.Numero = "123"
        p.Barrio = "El tropezón"
        p.Esquina = ""
        p.Apartamento = "4"
        p.FechaNacimiento = "1966-10-25"
        p.Telefonos = Telefono

        Try
            p.GuardarDatosPaciente()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        p.Documento = "31256542"
        Dim Resultado As Boolean
        Try
            p.CrearUsuarioBD()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestBuscarPaciente()
        Dim Resultado As Boolean
        Try
            p.BuscarPaciente("19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoPaciente()
        Dim Resultado As Boolean
        Try
            p.CambiarEstadoPaciente("19248371", "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestEliminarUsuarioBD()
        Dim Resultado As Boolean
        Try
            p.EliminarUsuarioBD("31256542")
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestbuscarPacientePorDocumento()
        Dim Resultado As Boolean
        Try
            p.buscarPacientePorDocumento("31256542")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestDatosPaciente()
        Dim Resultado As Boolean
        Try
            p.DatosPaciente("131345728")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
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

    End Sub

    <TestMethod()> Public Sub TestListarPacientesSegunEstado()
        Dim Resultado As Boolean
        Try
            p.ListarPacientes("1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Dim Resultado As Boolean
        Try
            p.ListarTelefonos("19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class