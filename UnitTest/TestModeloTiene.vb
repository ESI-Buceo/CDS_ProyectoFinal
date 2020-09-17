Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloTiene
    Dim t As New ModeloTiene("11111111", "Ge.11111111")
    Dim numAleatorio1 As New Random()
    Dim valorAleatorio1 As String = numAleatorio1.Next(1, 7)
    Dim numAleatorio2 As New Random()
    Dim valorAleatorio2 As String = numAleatorio2.Next(1, 6)

    <TestMethod()> Public Sub TestGuardarRelacionDiagnosticoPatologia()
        Dim Resultado As Boolean
        Dim Parametro As String = "('713780720','" + valorAleatorio1 + "','" + valorAleatorio2 + "')"
        Try
            t.GuardarRelacionDiagnosticoPatologia(Parametro)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class