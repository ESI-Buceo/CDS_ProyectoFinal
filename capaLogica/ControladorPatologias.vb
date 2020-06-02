Imports System.Data
Imports capaDatos

Public Module ControladorPatologias

    Public Function ListarPatologias() As DataTable
        Dim tablaPatologias As New DataTable
        Dim p As New ModeloPatologia
        tablaPatologias.Columns.Add("ID")
        tablaPatologias.Columns.Add("NOMBRE")
        tablaPatologias.Columns.Add("DESCRIPCION")
        tablaPatologias.Columns.Add("PONDERACION")
        tablaPatologias.Columns.Add("ACTIVO")

        For Each patologia In p.ListarPatologias()
            tablaPatologias.Rows.Add(patologia.Id, patologia.Nombre, patologia.Descripcion, patologia.Ponderacion, patologia.activo)
        Next
        Return tablaPatologias
    End Function

    Public Function ListarPatologias(ByVal nombre As String) As DataTable
        Dim tablaPatologias As New DataTable
        Dim p As New ModeloPatologia
        tablaPatologias.Columns.Add("ID")
        tablaPatologias.Columns.Add("NOMBRE")
        tablaPatologias.Columns.Add("DESCRIPCION")
        tablaPatologias.Columns.Add("PONDERACION")
        tablaPatologias.Columns.Add("ACTIVO")

        For Each patologia In p.listarPatologiasFiltradas(nombre)
            tablaPatologias.Rows.Add(patologia.Id, patologia.Nombre, patologia.Descripcion, patologia.Ponderacion, patologia.activo)
        Next
        Return tablaPatologias
    End Function
End Module
