Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloDiagnostico
    Dim d As New ModeloDiagnostico("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestGuardarDiagnostico()
        Dim numAleatorio As New Random()
        Dim valorAleatorio As String = numAleatorio.Next(100000000, 999999999)
        Dim Resultado As Boolean
        ModeloDiagnostico.CodigoDiagnostico = valorAleatorio
        ModeloDiagnostico.Ponderacion = "10"

        Try
            d.GuardarDiagnostico()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestTraerDiagnosticos()
        Dim Resultado As Boolean
        Try
            d.TraerDiagnosticos("19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestCantidadDeDiagnosticos()
        Dim Resultado As Boolean
        Try
            d.CantidadDeDiagnosticos("19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

End Class