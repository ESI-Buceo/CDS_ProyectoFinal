Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos
Imports System.Threading

<TestClass()> Public Class TestModeloPaciente2
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim p As New ModeloPaciente(usrGestor, usrGestor)
    Dim Resultado As Boolean

    <TestMethod()> Public Sub TestGuardarDatosPaciente()
        Dim Telefono As New List(Of String)
        Telefono.Add("097654978")
        Telefono.Add("097789456")

        p.Documento = "31256542"
        p.Email = "nuevo@paciente.com"
        p.Nombres = "Maria"
        p.Apellidos = "De los Dolores"
        p.Calle = "Quebrada"
        p.Numero = "123"
        p.Barrio = "El tropezón"
        p.Esquina = ""
        p.Apartamento = "4"
        p.FechaNacimiento = "1966-10-25"
        p.Telefonos = Telefono

        Try
            p.GuardarDatosPaciente()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestbuscarPacientePorDocumento()
        Try
            p.buscarPacientePorDocumento(usrPaciente)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub


    <TestMethod()> Public Sub TestBuscarPaciente()
        Try
            p.BuscarPaciente("p.Apellidos LIKE '%bazzi%'AND p.nombres LIKE '%Andrea%' AND p.docidentidad =" & usrPaciente)
            Resultado = True
        Catch ex As Exception
            Resultado = False
        End Try
        Assert.IsTrue(Resultado)
        Thread.Sleep(20)
    End Sub

    <TestMethod()> Public Sub TestEliminarUsuarioBD()
        'Se comenta porque no se puede probar en la escuela
        'p.RangoIpPaciente = "%"
        'Try
        '    p.EliminarUsuarioBD("54895632")
        '    Resultado = True
        'Catch ex As Odbc.OdbcException
        '    Resultado = False
        'End Try
        'Assert.IsTrue(Resultado)
        'Thread.Sleep(20)
    End Sub

End Class