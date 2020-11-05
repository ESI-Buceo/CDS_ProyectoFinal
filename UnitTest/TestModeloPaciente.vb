Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloPaciente
    Dim Resultado As Boolean
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim p As New ModeloPaciente(usrGestor, usrGestor)

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        'Se comenta porque no se puede probar en la escuela
        'p.RangoIpPaciente = "%"
        'p.Documento = "54895632"
        'p.Password = "Pa.54895632"
        'Try
        '    p.CrearUsuarioBD()
        '    Resultado = True
        'Catch ex As Odbc.OdbcException
        '    Resultado = False
        'End Try
        'Assert.IsTrue(Resultado)
        'Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCargarPreExistentes()
        p.Documento = usrPaciente
        Try
            p.CargarPreExistentes()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoPaciente()
        Try
            p.CambiarEstadoPaciente(usrPaciente, "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub


    <TestMethod()> Public Sub TestDatosPaciente()
        Try
            p.DatosPaciente("282917714")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub



    <TestMethod()> Public Sub TestListarPacientes()
        Try
            p.ListarPacientes()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPacientesSegunEstado()
        Try
            p.ListarPacientes("1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarTelefonos()
        Try
            p.ListarTelefonos(usrPaciente)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class