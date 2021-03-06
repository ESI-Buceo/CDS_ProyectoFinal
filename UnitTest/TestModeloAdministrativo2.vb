﻿Imports System.Text
Imports System.Threading
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloAdministrativo2
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim a As New ModeloAdministrativo(usrGestor, usrGestor)

    <TestMethod()> Public Sub TestGuardarAdministrativo()
        Dim Resultado As Boolean
        Dim Telefono As New List(Of String)
        Telefono.Add("095623215")
        Telefono.Add("097050602")
        Telefono.Add("098451212")

        a.Documento = "43219563"
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
        Thread.Sleep(20)
    End Sub

End Class