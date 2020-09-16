Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Threading

<TestClass()> Public Class TestControladorPaciente

    <TestMethod()> Public Sub TestidentificarPaciente()
        Assert.IsNotNull(controladorPacientes.identificarPaciente("19248371", "Pa.19248371"))
        Thread.Sleep(20)
    End Sub

End Class