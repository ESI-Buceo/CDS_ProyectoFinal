Imports System.Data
Imports capaDatos
Imports System.Windows.Forms

Public Module ControladorPatologias

    Public Sub AltaPatologia(id As String, nombre As String, ponderacion As Integer, descripcion As String, activo As Integer, ListaDeSintomas As DataGridView)
        'Guarda los datos de la patologia
        Dim p As New ModeloPatologia
        p.Id = id
        p.Nombre = nombre
        p.Ponderacion = ponderacion
        p.Descripcion = descripcion
        p.Activo = activo
        p.ListaDeSintomasAsociados = formatearListaDeSintomas(ListaDeSintomas)
        p.GuaradrPatologia()
    End Sub

    Public Sub BorrarPatologia(id As Integer)
        'ELimina logicamene la patologia
        Dim p As New ModeloPatologia
        p.Id = id
        p.EliminarPatologia()

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

    Public Function VerPatologia(ByVal id As String) As ModeloPatologia
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

    Public Function CargarSintomaPorPatologia(ByVal id As String, sintomasDePatologia As DataTable) As DataTable
        ' Carga los sintomas vinculados a una patologia
        Dim s As New ModeloSintoma
        sintomasDePatologia = s.ListarSintomasXPatologia(id)
        Return sintomasDePatologia
    End Function

    Public Function CrearDataTableSintomasXPatologia(ByVal sintomasDePatologia As DataTable)
        'Da formato al datatable que llena la lista de sintomas por patologia
        sintomasDePatologia.Rows.Clear()
        sintomasDePatologia.Columns.Clear()
        sintomasDePatologia.Columns.Add("idSintoma")
        sintomasDePatologia.Columns.Add("Nombre")
        Return sintomasDePatologia
    End Function

    Public Function ValidarIngresoDeSintomaEnPatologia(id As String, sintomasDePatologia As DataTable)
        'Verifica si el sistoma que se va a relacionar con la patologia no existe ya en la lista
        For Each sintoma As DataRow In sintomasDePatologia.Rows
            If sintoma("IdSintoma").ToString.Equals(id) Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function

    Public Function AgregarSintomaAPatologia(id As String, nombre As String, sintomasDePatologia As DataTable)
        ' Agregara al databale de los sintomas en la patologia, el nuevo sintoma seleccionado
        Dim fila As DataRow
        fila = sintomasDePatologia.NewRow
        fila("idSintoma") = id
        fila("Nombre") = nombre
        sintomasDePatologia.Rows.Add(fila)
        Return sintomasDePatologia
    End Function

End Module

