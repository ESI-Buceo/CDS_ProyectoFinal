﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloAdministrativo
    Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
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
        a.Documento = "40717849"
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
        Dim Resultado As Boolean
        Try
            a.BuscarAdministativo("77777777")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestBuscarAdministrativoPorDocumento()
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
        Dim Resultado As Boolean
        Try
            a.CambiarEstadoAdmin("40717849", "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestEliminarUsuarioBD()
        Dim Resultado As Boolean
        Try
            a.EliminarUsuarioBD("40717849")
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestValidarAdministrativo()
        Dim Resultado As Boolean
        Try
            a.ValidarAdministrativo("40717849")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarPassword()
        Dim Resultado As Boolean
        a.Documento = "11111111"
        Try
            a.CambiarPassword("11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarAdministrativosSegunEstado()
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
        Dim Resultado As Boolean
        Try
            a.ListarTelefonos("40717849")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class