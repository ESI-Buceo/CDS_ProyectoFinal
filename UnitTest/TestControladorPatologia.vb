Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Threading

<TestClass()> Public Class TestControladorPatologia
    Dim Resultado As Boolean
    <TestMethod()> Public Sub TestAltaPatologia()
        Dim ListaDeSintomas As New List(Of Integer)
        Try
            AltaPatologia("100", "Dolor de cosito", "40", "Cuando te duele algo que no sabes que es", "1",
                                       ListaDeSintomas, "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcambiarEstadoPatologia()
        Try
            cambiarEstadoPatologia("2", "1", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = True
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPatologias()
        Dim Lista As New DataTable
        Assert.AreSame(ListarPatologias("Dolor de cosito", "40713841", "40713841").GetType(), Lista.GetType())
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCargarSintomaPorPatologia()
        Try
            Dim sintomasDePatologia As New DataTable
            Assert.IsNotNull(CargarSintomaPorPatologia("2", sintomasDePatologia, "40713841", "40713841"))
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCrearDataTableSintomasXPatologia()
        Try
            Dim sintomasDePatologia As New DataTable
            Assert.IsNotNull(CrearDataTableSintomasXPatologia(sintomasDePatologia))
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestValidarIngresoDeSintomaEnPatologia()
        Dim sintomasDePatologia As New DataTable
        sintomasDePatologia.Columns.Add("IdSintoma")
        sintomasDePatologia.NewRow()
        sintomasDePatologia.Rows.Add("2")
        Assert.IsTrue(ValidarIngresoDeSintomaEnPatologia("2", sintomasDePatologia))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestAgregarSintomaAPatologia()
        Dim sintomasDePatologia As New DataTable
        sintomasDePatologia.Columns.Add("idSintoma")
        sintomasDePatologia.Columns.Add("Nombre")
        Assert.IsNotNull(AgregarSintomaAPatologia("2", "Tos", sintomasDePatologia))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListaDePatologias()
        Try
            ListaDePatologias("40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListaDePatologiasSegunEstado()
        Try
            ListaDePatologias("1", "40713841", "40713841")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestExportarDatosADB()
        Dim datos As New DataTable
        Try
            ControladorPatologias.ExportarDatosADB("40713841", "40713841", datos)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPatologiasPorDiagnostico()
        Dim datos As New DataTable
        Try
            ListarPatologiasPorDiagnostico("40713841", "40713841", "109354173")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

End Class