Imports System.Text
Imports System.Threading
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports capaDatos

<TestClass()> Public Class TestModeloMedico2
    Dim usrGestor As String = "40713841"
    Dim usrMedico As String = "19266172"
    Dim usrPaciente As String = "19248378"

    Dim m As New ModeloMedico(usrGestor, usrGestor)

    <TestMethod()> Public Sub TestGuardarDatosMedico()
        Dim Resultado As Boolean
        Dim Telefono As New List(Of String)
        Telefono.Add("097650602")
        Telefono.Add("099451212")

        m.Documento = "36512328"
        m.Email = "nuevo@medico.com"
        m.Nombres = "Carlitos"
        m.Apellidos = "Hacelaplancha"
        m.Calle = "Atahualpa"
        m.Numero = "1245"
        m.Barrio = "Yupanqui"
        m.Esquina = "Del Infinito"
        m.Apartamento = "3"
        m.FechaNacimiento = "1986-12-20"
        m.NumeroMedico = "4598"
        m.Telefonos = Telefono


        Try
            m.GuardarDatosMedico()
            Resultado = True
        Catch ex As Odbc.OdbcException
            Resultado = False
        End Try

        Assert.IsTrue(Resultado)
        Thread.Sleep(50)

    End Sub

End Class