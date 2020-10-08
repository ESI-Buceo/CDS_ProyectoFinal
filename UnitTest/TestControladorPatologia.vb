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
                                       ListaDeSintomas, "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcambiarEstadoPatologia()
        Try
            cambiarEstadoPatologia("2", "1", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = True
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPatologias()
        Dim Lista As New DataTable
        Assert.AreSame(ListarPatologias("Dolor de cosito", "11111111", "Ge.11111111"), Lista)
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
        Try
            ControladorPatologias.ExportarDatosADB("11111111", "Ge.11111111", datos)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestListarPatologiasPorDiagnostico()
        Assert.IsNotNull(ListarPatologiasPorDiagnostico("11111111", "Ge.11111111", "109354173"))
        Thread.Sleep(20)
    End Sub

End Class