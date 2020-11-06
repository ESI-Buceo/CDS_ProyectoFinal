Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloAsociados
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim a As New ModeloAsociados(usrGestor, usrGestor)
    <TestMethod()> Public Sub TestFiltrarPatologiasPorSintomas()
        Dim Resultado As Boolean
        Try
            a.FiltrarPatologiasPorSintomas("1", "1")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class