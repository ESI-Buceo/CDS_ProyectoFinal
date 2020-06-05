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
End Module
