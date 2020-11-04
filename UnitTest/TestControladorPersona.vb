Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Text.RegularExpressions

<TestClass()> Public Class TestControladorPersona

    <TestMethod()> Public Sub TestgenerarPassword()
        Dim Contrasena As String
        Contrasena = ControladorPersona.generarPassword()
        Assert.IsTrue(Regex.IsMatch(Contrasena, "[A-Z]+[a-z]+[.]+"))
    End Sub

    <TestMethod()> Public Sub TestCambiarPassword()
        Dim Resultado As Boolean
        Try
            CambiarPassword("19266171", "Me.19266171", "%", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

End Class