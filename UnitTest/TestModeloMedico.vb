Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloMedico

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim m As New ModeloMedico("19266171", "Me.19266171")
        Dim Resultado As Boolean
        Try
            m.VerificarDocumentoDeIdentidad("19266171")
            Resultado = True
        Catch ex As Exception
            Resultado = True
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestGuardarDatosMedico()
        Dim Resultado As Boolean
        Dim Telefono As New DataTable
        Telefono.Columns.Add("Telefono")
        Telefono.Rows.Add("097050602")
        Telefono.Rows.Add("098451212")
        Dim m As New ModeloMedico("22222222", "Ge.22222222")
        m.Documento = "56512328"
        m.Email = "nuevo@medico.com"
        m.Nombres = "Carlos"
        m.Apellidos = "Chacon"
        m.Calle = "Atahualpa"
        m.Numero = "1245"
        m.Barrio = "Yupanqui"
        m.Esquina = "Del Infinito"
        m.Apartamento = "3"
        m.FechaNacimiento = "1976-12-20"
        m.NumeroMedico = "4594"
        m.Telefonos = Telefono

        Try
            m.GuardarDatosMedico()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        Dim m As New ModeloMedico("11111111", "Ge.11111111")
        m.Documento = "56512329"
        Dim Resultado As Boolean
        Try
            m.CrearUsuarioBD()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestBuscarMedico()
        Dim m As New ModeloMedico("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            m.BuscarMedico("19266175")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestEliminarUsuarioBD()
        Dim m As New ModeloMedico("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            m.EliminarUsuarioBD("56512329")
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class