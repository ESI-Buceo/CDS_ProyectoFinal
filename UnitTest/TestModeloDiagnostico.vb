Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloDiagnostico

    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"
    Dim d As New ModeloDiagnostico(usrGestor, usrGestor)

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
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestTraerDiagnosticos()
        Dim Resultado As Boolean
        Try
            d.TraerDiagnosticos(usrMedico)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCantidadDeDiagnosticos()
        Dim Resultado As Boolean
        Try
            d.cantidadDeDiagnosticos(usrMedico)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class