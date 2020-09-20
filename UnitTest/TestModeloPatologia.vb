Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloPatologia
    Dim p As New ModeloPatologia("11111111", "Ge.11111111")
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestGuaradrPatologia()
        Dim ListaDeSintomas As New List(Of Integer)
        ListaDeSintomas.Add("2")

        p.Id = "101"
        p.Nombre = "Enfermedad"
        p.Ponderacion = "10"
        p.Descripcion = "Usted tiene algo"
        p.Activo = "1"
        p.ListaDeSintomasAsociados = ListaDeSintomas

        Try
            p.GuaradrPatologia()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCambiarEstadoPatologia()
        Try
            p.CambiarEstadoPatologia("101", "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarPatologiaPorNombre()
        Try
            p.BuscarPatologiaPorNombre("Gripe A")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestlistarPatologias()
        Try
            p.listarPatologias()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestlistarPatologiasPorEstado()
        Try
            p.ListarPatologias("0")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestlistarPatologiasPorSintoma()
        Try
            p.ListarPatologias("2")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPatologiasDeDiagnostico()
        Try
            p.ListarPatologiasDeDiagnostico("109354173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class