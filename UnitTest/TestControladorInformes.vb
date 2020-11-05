Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica


<TestClass()> Public Class TestControladorInformes
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestRankingPatologias()
        Try
            RankingPatologias("40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Assert.IsNotNull(RankingPatologias("40713841", "40713841"))
    End Sub

    <TestMethod()> Public Sub TestDiagnosticosBrindados()
        Try
            DiagnosticosBrindados("40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Assert.IsNotNull(DiagnosticosBrindados("40713841", "40713841"))
    End Sub

    <TestMethod()> Public Sub TestCantidadDeChatMeses()
        Try
            CantidadDeChatMeses("40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Assert.IsNotNull(CantidadDeChatMeses("40713841", "40713841"))
    End Sub

    <TestMethod()> Public Sub TestCantidadDeChatMes()
        Try
            CantidadDeChatMes("40713841", "40713841", "2020", "09")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Assert.IsNotNull(CantidadDeChatMes("40713841", "40713841", "2020", "09"))
    End Sub

End Class