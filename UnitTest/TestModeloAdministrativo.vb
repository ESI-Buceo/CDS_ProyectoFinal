Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloAdministrativo

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim a As New ModeloAdministrativo("11111111", "Ge.11111111")
        Dim Resultado As Boolean
        Try
            a.VerificarDocumentoDeIdentidad("19266173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class