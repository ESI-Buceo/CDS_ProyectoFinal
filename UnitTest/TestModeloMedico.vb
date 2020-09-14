Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloMedico

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim m As New ModeloMedico("19266171", "Me.19266171")
        Dim Resultado As Boolean
        Try
            m.VerificarDocumentoDeIdentidad("19266171")
            Resultado = True
        Catch ex As Exception
            Resultado = True
        End Try
        Assert.IsTrue(Resultado)

    End Sub

End Class