Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestControladorDiagnostico

    <TestMethod()> Public Sub TestCrearInformeDiagnostico()
        Dim CantidadDeSintomas As New List(Of Integer)
        CantidadDeSintomas.Add("7")
        Assert.IsNotNull(CrearInformeDiagnostico(CantidadDeSintomas, "19248371", "Pa.19248371"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestevaluarTablaPatologiasSinPatologia()
        Dim patologias As New DataTable
        Dim CantidadDeSintomas As New List(Of Integer)
        CantidadDeSintomas.Add("7")
        Assert.IsNotNull(evaluarTablaPatologias(patologias, CantidadDeSintomas, "19248371", "Pa.19248371"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestevaluarTablaPatologiasConPatologia()
        Dim patologias As New DataTable
        patologias.Columns.Add("Patologia")
        patologias.Columns.Add("ponderacion")
        patologias.Columns.Add("IdPatologia")
        Dim Renglon As DataRow = patologias.NewRow()
        Renglon("Patologia") = "Gripe A"
        Renglon("ponderacion") = "40"
        Renglon("IdPatologia") = "2"
        patologias.Rows.Add(Renglon)
        Dim CantidadDeSintomas As New List(Of Integer)
        CantidadDeSintomas.Add("1")
        Assert.IsNotNull(evaluarTablaPatologias(patologias, CantidadDeSintomas, "19248371", "Pa.19248371"))
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
        Assert.IsNotNull(TraerDiagnosticos("19248371", "Pa.19248371", "19248371"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCantidadDeDiagnosticos()
        Assert.AreNotEqual(CantidadDeDiagnosticos("19248371", "Pa.19248371", "19248371"), "0")
        Thread.Sleep(20)
    End Sub

End Class