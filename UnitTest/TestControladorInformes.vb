Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica


<TestClass()> Public Class TestControladorInformes
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestRankingPatologias()
        Try
            RankingPatologias("11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Assert.IsNotNull(RankingPatologias("11111111", "Ge.11111111"))
    End Sub

    <TestMethod()> Public Sub TestDiagnosticosBrindados()
        Try
            DiagnosticosBrindados("11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Assert.IsNotNull(DiagnosticosBrindados("11111111", "Ge.11111111"))
    End Sub

    <TestMethod()> Public Sub TestCantidadDeChatMeses()
        Try
            CantidadDeChatMeses("11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Assert.IsNotNull(CantidadDeChatMeses("11111111", "Ge.11111111"))
    End Sub

    <TestMethod()> Public Sub TestCantidadDeChatMes()
        Try
            CantidadDeChatMes("11111111", "Ge.11111111", "2020", "09")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Assert.IsNotNull(CantidadDeChatMes("11111111", "Ge.11111111", "2020", "09"))
    End Sub

End Class