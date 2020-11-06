Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica

<TestClass()> Public Class TestControladorSintomas
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestListarSintomas()
        Try
            ListarSintomas("40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestListarSintomasPorNombre()
        Try
            ListarSintomas("Tos", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestGuardarSintomas()
        Try
            GuardarSintomas("99", "Dolor de cosito", "1", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestBorrarSintomas()
        Try
            BorrarSintomas("99", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestListarSintomasDePatologia()
        Try
            ListarSintomasDePatologia("2", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestListarSintomasPorEstado()
        Dim Estado As Integer = 0
        Try
            ListarSintomas(Estado, "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestListarTodosLosSintomas()
        Try
            ListarTodosLosSintomas("40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestExportarDatosADB()
        Dim Datos As New DataTable
        Try
            ControladorSintomas.ExportarDatosADB("40713841", "40713841", Datos)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
    End Sub

End Class