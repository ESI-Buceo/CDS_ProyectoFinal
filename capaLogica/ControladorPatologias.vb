Imports System.Data
Imports capaDatos
Imports System.Windows.Forms

Public Module ControladorPatologias

    Public Sub AltaPatologia(id As String, nombre As String, ponderacion As Integer, descripcion As String, activo As Integer,
                             ListaDeSintomas As DataGridView, uid As String, pwd As String)
        'Guarda los datos de la patologia
        Dim p As New ModeloPatologia(uid, pwd)
        p.Id = id
        p.Nombre = nombre
        p.Ponderacion = ponderacion
        p.Descripcion = descripcion
        p.Activo = activo
        p.ListaDeSintomasAsociados = formatearListaDeSintomas(ListaDeSintomas, uid, pwd)
        p.GuaradrPatologia()
    End Sub

    Public Sub cambiarEstadoPatologia(id As Integer, estado As String, uid As String, pwd As String)
        'ELimina logicamene la patologia
        Dim p As New ModeloPatologia(uid, pwd)
        p.CambiarEstadoPatologia(id, estado)
    End Sub

    Public Function ListarPatologias(ByVal nombre As String, uid As String, pwd As String) As DataTable
        'Busca la patologia por nombre
        Dim p As New ModeloPatologia(uid, pwd)
        Return p.BuscarPatologiaPorNombre(nombre)
    End Function

    Private Function formatearListaDeSintomas(ByRef listaSintomas As DataGridView, uid As String, pwd As String)
        'recorre la lista de sintomas y las formatea para enviar a guardar
        Dim listaFormateadaDeSintomas As New List(Of Integer)
        For s = 0 To listaSintomas.Rows.Count - 1
            listaFormateadaDeSintomas.Add(listaSintomas.Item(0, s).Value)
        Next
        Return listaFormateadaDeSintomas
    End Function

    Public Function CargarSintomaPorPatologia(ByVal id As String, sintomasDePatologia As DataTable, uid As String, pwd As String) As DataTable
        ' Carga los sintomas vinculados a una patologia
        Dim s As New ModeloSintoma(uid, pwd)
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

    Public Function ListaDePatologias(ByVal uid As String, pwd As String)
        Dim p As New ModeloPatologia(uid, pwd)
        Return p.listarPatologias
    End Function

    Public Function ListaDePatologias(ByVal activo As String, uid As String, pwd As String)
        Dim p As New ModeloPatologia(uid, pwd)
        Return p.listarPatologias(activo)
    End Function

    Public Sub ExportarDatosADB(ByVal uid As String, pwd As String, datos As DataGridView)
        'Guarda informacion en la base de datos
        Dim p As New ModeloPatologia(uid, pwd)
        For f = 0 To datos.Rows.Count - 1
            p.Id = 0
            p.Nombre = datos.Item(0, f).Value.ToString
            p.Ponderacion = datos(1, f).Value.ToString
            p.Descripcion = datos(2, f).Value.ToString
            p.GuaradrPatologia()
        Next
    End Sub

    Public Function ListarPatologiasPorDiagnostico(ByVal uid As String, pwd As String, idDiagnostico As String)
        'Recuepera las patologias quue conforman un diagnostico
        Dim p As New ModeloPatologia(uid, pwd)
        Return p.ListarPatologiasDeDiagnostico(idDiagnostico)
    End Function
End Module
