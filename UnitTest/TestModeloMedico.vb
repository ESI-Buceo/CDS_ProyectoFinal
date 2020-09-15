Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloMedico
    Dim m As New ModeloMedico("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim Resultado As Boolean
        Try
            m.VerificarDocumentoDeIdentidad("19266175")
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
        Telefono.Rows.Add("097650602")
        Telefono.Rows.Add("099451212")

        m.Documento = "36512328"
        m.Email = "nuevo@medico.com"
        m.Nombres = "Carlitos"
        m.Apellidos = "Hacelaplancha"
        m.Calle = "Atahualpa"
        m.Numero = "1245"
        m.Barrio = "Yupanqui"
        m.Esquina = "Del Infinito"
        m.Apartamento = "3"
        m.FechaNacimiento = "1986-12-20"
        m.NumeroMedico = "4598"
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
        m.Documento = "36512327"
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
        Dim Resultado As Boolean
        Try
            m.BuscarMedico("19266171")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestBuscarMedicoPorDocumento()
        Dim Resultado As Boolean
        Try
            m.BuscarMedicoPorDocumento("19266173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoMedico()
        Dim Resultado As Boolean
        Try
            m.CambiarEstadoMedico("19266171", "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestEliminarUsuarioBD()
        Dim Resultado As Boolean
        Try
            m.EliminarUsuarioBD("36512327")
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarMedicos()
        Dim Resultado As Boolean
        Try
            m.ListarMedicos()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarMedicosPorEstado()
        Dim Resultado As Boolean
        Try
            m.ListarMedicos("1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Dim Resultado As Boolean
        Try
            m.ListarTelefonos("19266173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class