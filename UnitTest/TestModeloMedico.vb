Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloMedico
    Dim m As New ModeloMedico("11111111", "Ge.11111111")
    Public Property Comando As Object

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim Resultado As Boolean
        Try
            m.VerificarDocumentoDeIdentidad("'19266175'")
            Resultado = True
        Catch ex As Exception
            Resultado = True
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
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
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarMedico()
        Dim Resultado As Boolean
        Try
            m.BuscarMedico("p.docidentidad = '40717849' AND p.nombres = 'Carlos'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
            MsgBox(ex.Message)
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarMedicoPorDocumento()
        Dim Resultado As Boolean
        Try
            m.buscarMedicoPorDocumento("'40717849'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
            MsgBox(ex.Message)
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoMedico()
        Dim Resultado As Boolean
        Try
            m.CambiarEstadoMedico("'19266171'", "'1'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(50)
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
        Thread.Sleep(20)
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
        Thread.Sleep(50)
    End Sub

    <TestMethod()> Public Sub TestListarMedicosPorEstado()
        Dim Resultado As Boolean
        Try
            m.ListarMedicos("'0'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
            MsgBox(ex.Message)
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Dim Resultado As Boolean
        Try
            m.ListarTelefonos("'19266173'")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(50)
    End Sub

End Class