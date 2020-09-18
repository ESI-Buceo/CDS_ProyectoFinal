﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloPaciente2
    Dim p As New ModeloPaciente("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestGuardarDatosPaciente()
        Dim Resultado As Boolean
        Dim Telefono As New List(Of Integer)
        Telefono.Add("097654978")
        Telefono.Add("097789456")

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
        Thread.Sleep(20)
    End Sub

End Class