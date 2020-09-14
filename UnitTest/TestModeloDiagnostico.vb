Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloDiagnostico

    <TestMethod()> Public Sub TestGuardarDiagnostico()
        Dim d As New ModeloDiagnostico("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            d.GuardarDiagnostico()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

    End Sub

    <TestMethod()> Public Sub TestTraerDiagnosticos()
        Dim d As New ModeloDiagnostico("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            d.TraerDiagnosticos("19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

    End Sub

    <TestMethod()> Public Sub TestCantidadDeDiagnosticos()
        Dim d As New ModeloDiagnostico("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            d.CantidadDeDiagnosticos("19248371")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try

    End Sub

End Class