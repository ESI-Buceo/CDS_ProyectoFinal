Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloPersona
    Dim p As New ModeloPersona("11111111", "Ge.11111111")
    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim Resultado As Boolean
        Try
            p.VerificarDocumentoDeIdentidad("19266173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(100)
    End Sub

    <TestMethod()> Public Sub TestCambiarPassword()
        Dim Resultado As Boolean
        p.Documento = "11111111"
        p.RangoIP = "'%'"
        Try
            p.CambiarPassword("11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class