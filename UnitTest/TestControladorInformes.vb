Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica


<TestClass()> Public Class TestControladorInformes

    <TestMethod()> Public Sub TestRankingPatologias()
        Assert.IsNotNull(RankingPatologias("11111111", "Ge.11111111"))
    End Sub

    <TestMethod()> Public Sub TestDiagnosticosBrindados()
        Assert.IsNotNull(DiagnosticosBrindados("11111111", "Ge.11111111"))
    End Sub

    <TestMethod()> Public Sub TestCantidadDeChatMeses()
        Assert.IsNotNull(CantidadDeChatMeses("11111111", "Ge.11111111"))
    End Sub

    <TestMethod()> Public Sub TestCantidadDeChatMes()
        Assert.IsNotNull(CantidadDeChatMes("11111111", "Ge.11111111", "2020", "09"))
    End Sub

End Class