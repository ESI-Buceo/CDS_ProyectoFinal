Imports System.Data
Imports capaDatos

Public Module ControladorPatologias

    Public Function ListarPatologias() As DataTable
        Dim p As New ModeloPatologia
        Return p.TraeDatosPatologiasDeBD()
    End Function

    Public Function ListarPatologias(ByVal nombre As String) As DataTable
        Dim p As New ModeloPatologia
        Return p.BuscarPatologiaPorNombre(nombre)
    End Function

    Public Function verPatologia(ByVal id As String) As ModeloPatologia
        Dim p As New ModeloPatologia
        Return p.BuscarPatologiaPorID(id)
    End Function
End Module
