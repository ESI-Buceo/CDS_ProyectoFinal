Imports System.Data
Imports capaDatos
Public Module ControladorSintomas
    Public Function listarSintomas() As DataTable
         Dim s As New ModeloSintoma
        Return s.TraeDatosSintomasDeBD()
    End Function

    Public Function listarSintomas(sintoma As String) As DataTable
        Dim s As New ModeloSintoma
        Return s.TraeDatosSintomasDeBD(sintoma)
    End Function

    Public Sub GuardarSintomas(Nombre As String, Estado As Boolean)

        Dim s As New ModeloSintoma
        s.Nombre = Nombre
        s.Estado = Estado
        s.GuardarSintoma()

    End Sub

    Public Sub ModificarSintomas(Nombre As String, Estado As Boolean, Id As String)

        Dim s As New ModeloSintoma
        s.ID = Id
        s.Nombre = Nombre
        s.Estado = Estado
        s.ModificarSintoma()

    End Sub


End Module
