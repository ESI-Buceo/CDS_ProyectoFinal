Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloMedico
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim m As New ModeloMedico(usrGestor, usrGestor)
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestCrearUsuarioBD()
        'Se comenta porque no ese puede probar en la escuela
        'm.Documento = "36512327"
        'm.RangoIpMedico = "%"
        'm.Password = "Me.36512327"
        'Try
        '    m.CrearUsuarioBD()
        '    Resultado = True
        'Catch ex As Odbc.OdbcException
        '    Resultado = False
        'End Try
        'Assert.IsTrue(Resultado)
        'Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarMedico()
        Try
            m.BuscarMedico("p.apellidos Like '%gainza%' AND p.nombres LIKE '%ruben%' AND p.docidentidad =" & usrMedico)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarMedicoPorDocumento()
        Try
            m.buscarMedicoPorDocumento(usrMedico)
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
        'Se comenta porque no se puede probar en la escuela
        'm.RangoIpMedico = "%"
        'Try
        '    m.EliminarUsuarioBD("36512327")
        '    Resultado = True
        'Catch ex As Odbc.OdbcException
        '    Resultado = False
        'End Try
        'Assert.IsTrue(Resultado)
        'Thread.Sleep(20)
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
            m.ListarTelefonos(usrMedico)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class