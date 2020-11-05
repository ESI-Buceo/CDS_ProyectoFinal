Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloRecibe
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim r As New ModeloRecibe(usrPaciente, usrPaciente)

    <TestMethod()> Public Sub TestGuardarRelacionPacienteDiagnostico()
        Dim Resultado As Boolean
        r.DocIdentidad = usrPaciente
        ModeloDiagnostico.CodigoDiagnostico = "282917714"
        Try
            r.GuardarRelacionPacienteDiagnostico()
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class