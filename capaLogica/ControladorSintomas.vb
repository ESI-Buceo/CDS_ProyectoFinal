Imports System.Data
Imports capaDatos
Public Module ControladorSintomas

    Public Function ListarSintomas(ByVal uid As String, pwd As String) As DataTable
        ' Lista los sintomas que estan en la base de datos
        Dim s As New ModeloSintoma(uid, pwd)
        Return s.TraeDatosSintomasDeBD()
    End Function

    Public Function ListarSintomas(nombre As String, uid As String, pwd As String) As DataTable
        'Busca los sintomas por nombre
        Dim s As New ModeloSintoma(uid, pwd)
        Return s.TraeDatosSintomasDeBD(nombre)
    End Function

    Public Sub GuardarSintomas(ID As String, Nombre As String, Estado As Boolean, uid As String, pwd As String)
        'Guarda los datos de un sintoma
        Dim s As New ModeloSintoma(uid, pwd)
        s.ID = ID
        s.Nombre = Nombre
        s.Estado = Estado
        s.GuardarSintoma()
    End Sub

    Public Sub BorrarSintomas(Id As String, uid As String, pwd As String)
        'Eliminacion logica de un sintoma
        Dim s As New ModeloSintoma(uid, pwd)
        s.ID = Id
        s.BorrarSintoma()
    End Sub

    Public Function ListarSintomasDePatologia(ByVal idPatologia As String, uid As String, pwd As String)
        Dim s As New ModeloSintoma(uid, pwd)
        Return s.ListarSintomasXPatologia(idPatologia)
    End Function

    Public Function ListarSintomas(ByVal estado As Integer, uid As String, pwd As String)
        Dim s As New ModeloSintoma(uid, pwd)
        Return s.ListarSintomas(estado)
    End Function

    Public Function ListarTodosLosSintomas(ByVal uid As String, pwd As String)
        Dim s As New ModeloSintoma(uid, pwd)
        Return s.ListarTodosLosSintomas
    End Function
End Module
