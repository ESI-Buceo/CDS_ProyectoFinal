Imports System.Data
Imports capaDatos

Public Module ControladorPatologias

    Public Sub AltaPatologia(nombre As String, ponderacion As Integer, descripcion As String, activo As Integer)
        Dim p As New ModeloPatologia
        p.Nombre = nombre
        p.Ponderacion = ponderacion
        p.Descripcion = descripcion
        p.activo = activo
        p.GuaradrPatologia()

    End Sub

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
