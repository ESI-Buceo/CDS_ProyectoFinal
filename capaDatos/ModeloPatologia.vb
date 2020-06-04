Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ModeloPatologia
    Public Id As Integer
    Public Nombre As String
    Public Ponderacion As Integer
    Public Descripcion As String
    Public activo As Integer

    Public ListaSintomasPatologia As New List(Of ModeloSintoma)
    Public ListaSignosPatologia As New List(Of ModeloSignos)
    Public ListaPatologias As New List(Of ModeloPatologia)
    Public ListaBusquedaPatologias As New List(Of ModeloPatologia)


    Public Function GuaradrPatologia() As Boolean
        ' guarda nueva patologia
        Return True
    End Function

    Public Function eliminarPatologia(id As Integer)
        'elimina la patologa con el id
        Return True
    End Function

    Public Function ListarPatologias() As List(Of ModeloPatologia)
        'lista todas las patologias
        TraeDatosPatologiasDeBD()
        Return ListaPatologias
    End Function

    Public Function listarPatologiasFiltradas(nombre As String) As List(Of ModeloPatologia)
        'busca y retorna lista con los patologias resultantes de la busqueda
        For Each patologia In ListaPatologias
            If patologia.Nombre.Contains(nombre) Then
                ListaBusquedaPatologias.Add(patologia)
            End If
        Next
        Return ListaBusquedaPatologias
    End Function

    Private Function validarNombre() As Boolean
        'valida que el nombre no tenga caracteres raros
        Return True
    End Function

    Private Function validarDescripcion() As Boolean
        'valida que la descripcion no tenga codigos raros
        Return True
    End Function

    Private Function validarPonderacion() As Boolean
        'valida que la ponderacion sea numerica
        Return True
    End Function

    Private Function validarEstado() As Boolean
        'valida que el esado true o false
        Return True
    End Function

    Public Sub TraeDatosPatologiasDeBD()
        'trae de la base de datos las patolgias registadas
        ListaPatologias.Clear()
        Try
            Dim conexion As New ModeloConexion
            Dim patologiasAdapter As System.Data.Odbc.OdbcDataAdapter
            Dim patologiasDataSet As New DataSet
            Dim patologiaSQL As String

            patologiaSQL = "SELECT * FROM patologia WHERE activo = 1 "
            patologiasAdapter = New System.Data.Odbc.OdbcDataAdapter(patologiaSQL, conexion.Abrir)
            patologiasAdapter.Fill(patologiasDataSet, "patologia")

            For Each patologia In patologiasDataSet.Tables("patologia").Rows
                cargarListaPatologias(patologia)
            Next
            conexion.Cerrar()
        Catch ex As Exception
            mostrarExepcion(ex)
        End Try
    End Sub

    Public Sub cargarListaPatologias(ByRef patologias As DataRow)
        'carga la lista de patologias
        ListaPatologias.Add(New ModeloPatologia With {.Id = patologias("id"), .Nombre = patologias("nombre"),
                            .Ponderacion = patologias("ponderacion"), .Descripcion = patologias("descripcion"),
                            .activo = patologias("activo")})
    End Sub

    Public Function BuscarPatologiaPorID(ByVal id As Integer)
        Try
            Dim conexion As New ModeloConexion
            Dim patologiasAdapter As System.Data.Odbc.OdbcDataAdapter
            Dim patologiasDataSet As New DataSet
            Dim patologiaSQL As String

            patologiaSQL = "SELECT * FROM patologia WHERE id = " & id
            patologiasAdapter = New System.Data.Odbc.OdbcDataAdapter(patologiaSQL, conexion.Abrir)
            patologiasAdapter.Fill(patologiasDataSet, "patologia")

            conexion.Cerrar()
            Return crearObjetoPatologia(patologiasDataSet.Tables("patologia").Rows.Item(0))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return vbNull
    End Function

    Private Function crearObjetoPatologia(ByRef patologia As DataRow) As ModeloPatologia
        Dim datosPatologia As New ModeloPatologia
        datosPatologia.Id = patologia("id")
        datosPatologia.Nombre = patologia("nombre")
        datosPatologia.Descripcion = patologia("descripcion")
        datosPatologia.Ponderacion = patologia("ponderacion")
        Return datosPatologia
    End Function

    Private Sub mostrarExepcion(ByVal exeption As Exception)
        MsgBox(exeption.Message)
    End Sub
End Class
