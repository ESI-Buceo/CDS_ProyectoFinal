Imports System.Data
Imports capaDatos
Public Module ControladorSintomas

    Public Function listarSintomas() As DataTable
        Dim s As New ModeloSintoma
        s.cargarListaSintomas()
        Dim tablaSintomas As New DataTable
        tablaSintomas.Columns.Add("ID")
        tablaSintomas.Columns.Add("NOMBRE")
        For i = 0 To s.listarSintomas().Count - 1
            tablaSintomas.Rows.Add(s.listarSintomas.Item(i).ID, s.listarSintomas.Item(i).Nombre)
        Next
        Return tablaSintomas
    End Function

    Public Function listarSintomas(sintoma As String) As DataTable
        Dim s As New ModeloSintoma
        s.cargarListaSintomas()
        Dim tablaSintomas As New DataTable
        tablaSintomas.Columns.Add("ID")
        tablaSintomas.Columns.Add("NOMBRE")
        For i = 0 To s.listarSintomas(sintoma).Count - 1
            tablaSintomas.Rows.Add(s.listarSintomas.Item(i).ID, s.listarSintomas.Item(i).Nombre)
        Next
        Return tablaSintomas
    End Function
End Module
