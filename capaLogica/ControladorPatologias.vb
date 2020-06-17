Imports System.Data
Imports capaDatos
Imports System.Windows.Forms

Public Module ControladorPatologias

    Dim SintomasDePatologia As New DataTable

    Public Sub AltaPatologia(id As String, nombre As String, ponderacion As Integer, descripcion As String, activo As Integer, ListaDeSintomas As DataGridView)
        'Guarda los datos de la patologia
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
        'ELimina logicamene la patologia
        Dim p As New ModeloPatologia
        p.Id = id
        p.eliminarPatologia()

    End Sub


    Public Function ListarPatologias() As DataTable
        'Lista las patologias 
        Dim p As New ModeloPatologia
        Return p.TraeDatosPatologiasDeBD()
    End Function


    Public Function ListarPatologias(ByVal nombre As String) As DataTable
        'Busca la patologia por nombre
        Dim p As New ModeloPatologia
        Return p.BuscarPatologiaPorNombre(nombre)
    End Function


    Public Function verPatologia(ByVal id As String) As ModeloPatologia
        'Muestra los datos de una patologia
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


    Public Function cargarSintomaPorPatologia(ByVal id As String) As DataTable
        ' Carga los sintomas vinculados a una patologia
        Dim s As New ModeloSintoma
        SintomasDePatologia = s.listarSintomasXPatologia(id)
        Return SintomasDePatologia
    End Function


    Public Function crearDataTableSintomasXPatologia()
        'Da formato al datatable que llena la lista de sintomas por patologia
        SintomasDePatologia.Columns.Clear()
        SintomasDePatologia.Columns.Add("idSintoma")
        SintomasDePatologia.Columns.Add("nombre")
        Return SintomasDePatologia
    End Function


    Public Function agregarSintomaAPatologia(id As String, nombre As String)
        ' Agregara al databale de los sintomas en la patologia, el nuevo sintoma seleccionado
        Dim fila As DataRow
        fila = SintomasDePatologia.NewRow
        fila("idSintoma") = id
        fila("nombre") = nombre
        SintomasDePatologia.Rows.Add(fila)
        Return SintomasDePatologia
    End Function


End Module
