Imports System.Data
Imports capaDatos
Public Module ControladorSintomas
    Public Function listarSintomas() As DataTable
        Dim s As New ModeloSintoma
        Dim tablaSintomas As New DataTable
        tablaSintomas.Columns.Add("ID")
        tablaSintomas.Columns.Add("Nombre")
        tablaSintomas.Columns.Add("Activo")
        For Each sintomas In s.listarSintomas()
            tablaSintomas.Rows.Add(sintomas.ID, sintomas.Nombre, sintomas.Estado)
        Next
        Return tablaSintomas
    End Function

    Public Function listarSintomas(sintoma As String) As DataTable
        Dim s As New ModeloSintoma
        Dim tablaSintomas As New DataTable
        tablaSintomas.Columns.Add("ID")
        tablaSintomas.Columns.Add("Nombre")
        tablaSintomas.Columns.Add("Activo")
        For Each sintomas In s.listarSintomasFiltrados(sintoma)
            tablaSintomas.Rows.Add(sintomas.ID, sintomas.Nombre, sintomas.Estado)
        Next
        Return tablaSintomas
    End Function
End Module
