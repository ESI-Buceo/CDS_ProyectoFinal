Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Threading

<TestClass()> Public Class TestControladorPatologia

    <TestMethod()> Public Sub TestAltaPatologia()
        Dim ListaDeSintomas As New List(Of Integer)
        Assert.IsTrue(AltaPatologia("100", "Dolor de cosito", "40", "Cuando te duele algo que no sabes que es", "1",
                                       ListaDeSintomas, "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcambiarEstadoPatologia()
        Assert.IsTrue(cambiarEstadoPatologia("2", "1", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPatologias()
        Assert.IsNotNull(ListarPatologias("Dolor de cosito", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCargarSintomaPorPatologia()
        Dim sintomasDePatologia As New DataTable
        Assert.IsNotNull(CargarSintomaPorPatologia("2", sintomasDePatologia, "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestCrearDataTableSintomasXPatologia()
        Dim sintomasDePatologia As New DataTable
        Assert.IsNotNull(CrearDataTableSintomasXPatologia(sintomasDePatologia))
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
        Assert.IsNotNull(ListaDePatologias("11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListaDePatologiasSegunEstado()
        Assert.IsNotNull(ListaDePatologias("1", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestExportarDatosADB()
        Dim datos As New DataTable
        Assert.IsTrue(ControladorPatologias.ExportarDatosADB("11111111", "Ge.11111111", datos))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPatologiasPorDiagnostico()
        Assert.IsNotNull(ListarPatologiasPorDiagnostico("11111111", "Ge.11111111", "109354173"))
        Thread.Sleep(20)
    End Sub

End Class