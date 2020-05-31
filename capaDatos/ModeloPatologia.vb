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

    Public Function buscarPatologia(nombre As String) As List(Of ModeloPatologia)
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

    'hay que borrar estas lineas, fueron creadas para cargar patologias de pruebas
    Public Sub TraeDatosPatologiasDeBD()
        ListaPatologias.Clear()
        Try
            Dim conexion As New ModeloConexion
            Dim patologiasAdapter As MySqlDataAdapter
            Dim patologiasDataSet As New DataSet
            Dim patologiaSQL As String

            patologiaSQL = "SELECT * FROM patologia WHERE activo = 1 "
            patologiasAdapter = New MySqlDataAdapter(patologiaSQL, conexion.Abrir)
            patologiasAdapter.Fill(patologiasDataSet, "patologia")

            For Each patologia In patologiasDataSet.Tables("patologia").Rows
                cargarListaPatologias(patologia)
            Next
            conexion.Cerrar()
        Catch ex As Exception
            mostrarExepcion(ex)
        End Try
    End Sub

    Public Sub cargarListaPatologias(ByRef patologia As DataRow)
        ListaPatologias.Add(New ModeloPatologia With {.Id = patologia("id"), .Nombre = patologia("nombre"),
                            .Ponderacion = patologia("ponderacion"), .Descripcion = patologia("descripcion"),
                            .activo = patologia("activo")})
    End Sub

    Private Sub mostrarExepcion(ByVal exeption As Exception)
        MsgBox(exeption.Message)
    End Sub
End Class
