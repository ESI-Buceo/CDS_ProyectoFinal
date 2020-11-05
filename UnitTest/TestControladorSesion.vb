Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestControladorSesion
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestGuardarSesionDeChat()
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(500000000, 999999999)
        ModeloDiagnostico.CodigoDiagnostico = valorAleatorio
        ModeloDiagnostico.Ponderacion = "40"
        Try
            GuardarSesionDeChat("19248378", "19248378")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestChequearSesionesPendientes()
        Try
            ChequearSesionesPendientes("19248378", "19248378")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestchequearSesionesEnEspera()
        Try
            chequearSesionesEnEspera("19266172", "19266172")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVerificarEstadoDeSesionPorID()
        Dim Estado As Integer = "3"
        Assert.AreEqual(VerificarEstadoDeSesion("131345728", "19248378", "19248378"), Estado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestVerificarEstadoDeSesion()
        ModeloDiagnostico.CodigoDiagnostico = "131345728"
        Assert.AreEqual(VerificarEstadoDeSesion("19266172", "19266172"), "3")
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestDatosDelMedicoSesion()
        'Se agrega comando DISTINCT a la sentencia SQL ya que traia datos repetidos    
        ModeloDiagnostico.CodigoDiagnostico = "161348021"
        Try
            DatosDelMedicoSesion("19266172", "19266172")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCancelarSesionDeChat()
        ModeloDiagnostico.CodigoDiagnostico = "131345728"
        Try
            CancelarSesionDeChat("19266172", "19266172")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestGuardarEstadoSesion()
        Try
            GuardarEstadoSesion("131345728", "19266172", "19266172")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class