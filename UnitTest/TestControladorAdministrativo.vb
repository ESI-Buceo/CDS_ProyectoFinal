Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Windows.Forms
Imports System.Threading

<TestClass()> Public Class TestControladorAdministrativo

    <TestMethod()> Public Sub TestVerificarDocumentoDeIdentidad()
        Assert.IsNotNull(controladorAdministrativo.VerificarDocumentoDeIdentidad("11111111", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    '<TestMethod()> Public Sub TestGuardarDatosAdmin()
    '    Dim Telefonos As DataGridView
    '    Dim row(1) As String
    '    Telefonos.ColumnCount = 1
    '    Telefonos.Columns(0).Name = "Telefono"

    '    row(0) = "097055621"
    '    Dim Telefono As String() = New String() {row(1), row(2)}
    '    Telefonos.Rows.Add(row)




    '    Assert.IsNotNull(controladorAdministrativo.GuardarDatosAdmin("12345678", "nuevo@admincontrolador.com",
    '                                                                 "Cacho", "Castaña", "Argentina", "1234",
    '                                                                 "La Boca", "Tanguito", "", "1950-10-10", Telefonos,
    '                                                                 "3288", "11111111", "Ge.11111111"))
    'End Sub

    <TestMethod()> Public Sub TestCrearUsuarioBD()
        Dim Resultado As Boolean
        Try
            controladorAdministrativo.CrearUsuarioBD("12345678", "11111111", "Ge.11111111")
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestcrearCadenaDeBusquedaAdministrativo()
        Assert.IsNotNull(controladorAdministrativo.crearCadenaDeBusquedaAdministrativo("txtDocIdentidad", "11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarAdministrativo()
        Assert.IsNotNull(controladorAdministrativo.buscarAdministrativo("77777777", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestBuscarAdministrativoPorDocumento()
        Assert.IsNotNull(controladorAdministrativo.BuscarAdministrativoPorDocumento("77777777", "11111111", "Ge.11111111"))
        Thread.Sleep(20)
    End Sub

End Class