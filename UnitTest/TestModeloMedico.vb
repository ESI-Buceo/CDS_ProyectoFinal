Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloMedico
    Dim m As New ModeloMedico("11111111", "Ge.11111111")
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestCrearUsuarioBD()
        m.Documento = "36512327"
        m.RangoIpMedico = "%"
        m.Password = "Me.36512327"
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
        Try
            m.BuscarMedico("p.apellidos Like '%Chacon%' AND p.nombres LIKE '%Carlos%' AND p.docidentidad = 40717849")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarMedicoPorDocumento()
        Try
            m.buscarMedicoPorDocumento("40717849")
            Resultado = True
        Catch ex As Exception
            Resultado = False
            MsgBox(ex.Message)
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoMedico()
        Try
            m.CambiarEstadoMedico("19266171", "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(50)
    End Sub

    <TestMethod()> Public Sub TestEliminarUsuarioBD()
        m.RangoIpMedico = "%"
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
        Try
            m.ListarMedicos("0")
            Resultado = True
        Catch ex As Exception
            Resultado = False
            MsgBox(ex.Message)
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Try
            m.ListarTelefonos("19266173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class