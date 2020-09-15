Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloRecibe
    Dim r As New ModeloRecibe("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestGuardarRelacionPacienteDiagnostico()
        Dim Resultado As Boolean
        r.DocIdentidad = "19248371"
        ModeloDiagnostico.CodigoDiagnostico = "131345728"
        Try
            r.GuardarRelacionPacienteDiagnostico()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class