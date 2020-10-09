Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestControladorDiagnostico
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestCrearInformeDiagnostico()
        Dim ListaDeSintomas As New List(Of Integer)
        ListaDeSintomas.Add("6")
        ListaDeSintomas.Add("8")
        ListaDeSintomas.Add("17")
        Try
            CrearInformeDiagnostico(ListaDeSintomas, "19248371", "Pa.19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestValidarSintomaSeleccionado()
        Dim Sintomas As New List(Of Integer)
        Sintomas.Add("0")
        Assert.IsTrue(ValidarSintomaSeleccionado("2", Sintomas))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVerificarSiYaFueIngresado()
        Dim Sintomas As New List(Of Integer)
        Sintomas.Add("1")
        Assert.IsTrue(VerificarSiYaFueIngresado("2", Sintomas))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestdevolverIdSesion()
        ModeloDiagnostico.CodigoDiagnostico = "32145698"
        Assert.AreEqual(devolverIdSesion(), "32145698")
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestTraerDiagnosticos()
        Try
            TraerDiagnosticos("19248371", "Pa.19248371", "19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCantidadDeDiagnosticos()
        Assert.AreNotEqual(CantidadDeDiagnosticos("19248371", "Pa.19248371", "19248371"), "0")
        Thread.Sleep(20)
    End Sub

End Class