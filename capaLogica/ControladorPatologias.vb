Imports System.Data
Imports capaDatos
Imports System.Windows.Forms

Public Module ControladorPatologias
    Dim ListaFormateadaDeSintomas As List(Of ModeloSintoma)


    Public Sub AltaPatologia(id As String, nombre As String, ponderacion As Integer, descripcion As String, activo As Integer, ListaDeSintomas As DataGridView)
        Dim p As New ModeloPatologia
        p.Id = id
        p.Nombre = nombre
        p.Ponderacion = ponderacion
        p.Descripcion = descripcion
        p.activo = activo
        p.ListaDeSintomasAsociados = formatearListaDeSintomas(ListaDeSintomas)
        p.GuaradrPatologia()

    End Sub


    Public Sub BorrarPatologia(id As Integer)
        Dim p As New ModeloPatologia
        p.Id = id
        p.eliminarPatologia()

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


    Private Function formatearListaDeSintomas(ByRef listaSintomas As DataGridView) As List(Of ModeloSintoma)
        'recorre la lista de sintomas y las formatea para enviar a guardar
        Dim listaFormateadaDeSintomas As New List(Of ModeloSintoma)

        For s = 0 To listaSintomas.Rows.Count - 1
            listaFormateadaDeSintomas.Add(New ModeloSintoma With
                                          {
                                          .ID = listaSintomas.Item(0, s).Value
                                          })
        Next
        Return listaFormateadaDeSintomas
    End Function


End Module
