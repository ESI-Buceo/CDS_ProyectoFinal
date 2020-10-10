Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloAdministrativo
    Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestBuscarAdministativo()
        Dim Resultado As Boolean
        Try
            a.BuscarAdministativo("p.apellidos LIKE '%fernandez%' AND p.nombres 
                                   LIKE '%mario juan%' AND p.docidentidad=11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(50)
    End Sub

    <TestMethod()> Public Sub TestBuscarAdministrativoPorDocumento()
        Dim Resultado As Boolean
        Try
            a.BuscarAdministrativoPorDocumento("77777777")
            Resultado = True
        Catch ex As Exception
            Resultado = False
            MsgBox(ex.Message)
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(50)

    End Sub

    <TestMethod()> Public Sub TestListarAdministrativosSegunEstado()
        Dim Resultado As Boolean
        Try
            a.ListarAdministrativos("1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
            MsgBox(ex.Message)
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestValidarAdministrativo()
        Dim Resultado As Boolean
        Try
            a.ValidarAdministrativo("11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
            MsgBox(ex.Message)
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoAdmin()
        Dim Resultado As Boolean
        Try
            a.CambiarEstadoAdmin("22222222", "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
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
        Thread.Sleep(20)
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
        Thread.Sleep(20)
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
        Thread.Sleep(20)
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
        Thread.Sleep(20)
    End Sub

End Class