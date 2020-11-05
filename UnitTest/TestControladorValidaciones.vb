Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaLogica
Imports System.Windows.Forms

<TestClass()> Public Class TestControladorValidaciones

    <TestMethod()> Public Sub TestValidarFormatoDocumento()
        Assert.IsTrue(ValidarFormatoDocumento(12345678))
        Assert.IsFalse(ValidarFormatoDocumento(3))
    End Sub

    <TestMethod()> Public Sub TestValidarCampoVacio()
        Assert.IsTrue(ValidarCampoVacio("Algo"))
        Assert.IsFalse(ValidarCampoVacio(""))
    End Sub

    <TestMethod()> Public Sub TestValidarNombres()
        Assert.IsTrue(ValidarNombres("NombreBien Escrito"))
    End Sub

    <TestMethod()> Public Sub TestValidarApellidos()
        Assert.IsTrue(ValidarApellidos("NombreBien Escrito"))
    End Sub

    <TestMethod()> Public Sub TestValidarEmail()
        Assert.IsFalse(ValidarEmail(""))
        Assert.IsFalse(ValidarEmail("maildeformaincorrecta"))
        Assert.IsTrue(ValidarEmail("maildeforma@correcta.com"))
    End Sub

    <TestMethod()> Public Sub TestValidarNumeroMedico()
        Assert.IsTrue(ValidarNumeroMedico(""))
        Assert.IsFalse(ValidarNumeroMedico("Tendria que dar error"))
        Assert.IsTrue(ValidarNumeroMedico("123456"))
    End Sub

    <TestMethod()> Public Sub TestValidarFechaNacimiento()
        Assert.IsTrue(ValidarFechaNacimiento("10-02-1987"))
        Assert.IsFalse(ValidarFechaNacimiento("11-01-2011"))
    End Sub

    <TestMethod()> Public Sub TestValidarPonderacion()
        Assert.IsTrue(ValidarPonderacion("30"))
        Assert.IsFalse(ValidarPonderacion(""))
    End Sub

    <TestMethod()> Public Sub TestValidarListaCargada()
        Dim dgvVacio As New DataGridView
        Assert.IsFalse(ValidarListaCargada(dgvVacio))
    End Sub

    <TestMethod()> Public Sub TestValidarPassYRePass()
        Assert.IsTrue(ValidarPassYRePass("Esto tiene que ser igual", "Esto tiene que ser igual"))
        Assert.IsFalse(ValidarPassYRePass("Esto tiene que ser diferente", "A este así da error"))
    End Sub

    <TestMethod()> Public Sub TestValidarDatosAExportar()
        Dim dgv As New DataGridView
        Assert.IsTrue(ValidarDatosAExportar(dgv))
    End Sub

    <TestMethod()> Public Sub TestValidarCantidadCamposPatologias()
        Dim dato As New DataTable
        Dim datobien As New DataTable
        datobien.Columns.Add("colum1")
        datobien.Columns.Add("colum2")
        datobien.Columns.Add("colum3")
        Assert.IsTrue(ValidarCantidadCamposPatologias(datobien))
        Assert.IsFalse(ValidarCantidadCamposPatologias(dato))
    End Sub

    <TestMethod()> Public Sub TestValidarCantidadCamposSintomas()
        Dim data As New DataGridView
        Assert.IsFalse(ValidarCantidadCamposSintomas(data))
    End Sub

    <TestMethod()> Public Sub TestvalidarNumero()
        Assert.IsFalse(validarNumero("tiene que dar error"))
        Assert.IsFalse(validarNumero(""))
        Assert.IsTrue(validarNumero("123"))
    End Sub

End Class