Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloAdministrativo
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim a As New ModeloAdministrativo(usrGestor, usrGestor)

    <TestMethod()> Public Sub TestBuscarAdministativo()
        Dim Resultado As Boolean
        Try
            a.BuscarAdministativo("p.apellidos LIKE '%bueno%' AND p.nombres 
                                   LIKE '%marcos%' AND p.docidentidad=" & usrGestor)
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
            a.BuscarAdministrativoPorDocumento(usrGestor)
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
            a.ValidarAdministrativo(usrGestor)
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
        'Se comenta porque no se puede ejectuar en la escuela
        'a.Documento = "40717849"
        'a.RangoIpAdministrativo = "%"
        'a.Password = "Ge.40717849"
        'Dim Resultado As Boolean
        'Try
        '    a.CrearUsuarioBD()
        '    Resultado = True
        'Catch ex As Odbc.OdbcException
        '    Resultado = False
        'End Try
        'Assert.IsTrue(Resultado)
        'Thread.Sleep(20)
    End Sub


    <TestMethod()> Public Sub TestEliminarUsuarioBD()
        'Se comenta porque no se puede ejectuar en la escuela
        'Dim Resultado As Boolean
        'a.RangoIpAdministrativo = "%"
        'Try
        '    a.EliminarUsuarioBD("40717849")
        '    Resultado = True
        'Catch ex As Odbc.OdbcException
        '    Resultado = False
        'End Try
        'Assert.IsTrue(Resultado)
        'Thread.Sleep(20)
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
            a.ListarTelefonos(usrGestor)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class