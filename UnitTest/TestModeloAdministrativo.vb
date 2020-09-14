Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloAdministrativo

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.VerificarDocumentoDeIdentidad("19266173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestGuardarAdministrativo()
        Dim Resultado As Boolean
        Dim Telefono As New DataTable
        Telefono.Columns.Add("Telefono")
        Telefono.Rows.Add("097050602")
        Telefono.Rows.Add("098451212")
        Dim a As New ModeloAdministrativo("22222222", "Ge.22222222")
        a.Documento = "40717849"
        a.Email = "nuevo@admin.com"
        a.Nombres = "maria"
        a.Apellidos = "calambres"
        a.Calle = "colombes"
        a.Numero = "1245"
        a.Barrio = "jacinto vera"
        a.Esquina = "del infinito"
        a.Apartamento = "3"
        a.FechaNacimiento = "1976-12-20"
        a.NumeroEmpleado = "7894"
        a.Telefonos = Telefono

        Try
            a.GuardarAdministrativo()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        a.Documento = "32165498"
        Dim Resultado As Boolean
        Try
            a.CrearUsuarioBD()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestBuscarAdministativo()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.BuscarAdministativo("12345678")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestBuscarAdministrativoPorDocumento()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.BuscarAdministativo("77777777")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoAdmin()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.CambiarEstadoAdmin("77777777", "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestEliminarUsuarioBD()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.EliminarUsuarioBD("32165498")
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestValidarAdministrativo()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.ValidarAdministrativo("19266173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarPassword()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.CambiarPassword("11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarAdministrativosSegunEstado()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.ListarAdministrativos("1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarAdministrativos()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.ListarAdministrativos()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.ListarTelefonos("407138496")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class