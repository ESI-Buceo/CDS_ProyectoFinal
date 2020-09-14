﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos


<TestClass()> Public Class TestModeloAsociados

    <TestMethod()> Public Sub TestFiltrarPatologiasPorSintomas()
        Dim a As New ModeloAsociados("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.FiltrarPatologiasPorSintomas("1", "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

End Class