Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloPersona
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim p As New ModeloPersona(usrGestor, usrGestor)

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Dim Resultado As Boolean
        Try
            p.VerificarDocumentoDeIdentidad(usrMedico)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(100)
    End Sub

    <TestMethod()> Public Sub TestCambiarPassword()
        Dim Resultado As Boolean
        p.Documento = "19266171"
        p.RangoIP = "%"
        Try
            p.CambiarPassword("Me.19266171")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class