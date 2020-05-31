Imports capaDatos
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class ModeloSintoma

    Public ID As Integer
    Public Nombre As String
    Public Estado As Boolean
    Public listaSintomas As New List(Of ModeloSintoma)
    Public ListaFiltradaSintomas As New List(Of ModeloSintoma)
    Public SintomasSeleccionados As New List(Of ModeloSintoma)

    Public Function guardarSintoma() As Boolean
        'envia solicitud de guardar
        Return True
    End Function

    Public Function eliminarSintoma(ByVal id As Integer) As Boolean
        'elimina sintoma o lo marca como 0 - inhabilitado
        Return True
    End Function

    Public Function listarSintomas() As List(Of ModeloSintoma)
        TraeDatosSintomasDeBD()
        Return listaSintomas
    End Function

    Public Function listarSintomasFiltrados(nombre As String) As List(Of ModeloSintoma)
        'busca y retorna lista con los sintomas resultantes de la busqueda
        TraeDatosSintomasDeBD()
        ListaFiltradaSintomas.Clear()
        For Each sintoma In listaSintomas
            If sintoma.Nombre.Contains(nombre) Then
                ListaFiltradaSintomas.Add(sintoma)
            End If
        Next
        Return ListaFiltradaSintomas
    End Function

    Public Sub TraeDatosSintomasDeBD()
        listaSintomas.Clear()
        Try
            Dim conexion As New ModeloConexion
            Dim sintomaAdapter As MySqlDataAdapter
            Dim sintomaDataSet As New DataSet
            Dim sintomaSQL As String

            sintomaSQL = "SELECT * FROM sintoma WHERE activo = 1 "
            sintomaAdapter = New MySqlDataAdapter(sintomaSQL, conexion.Abrir)
            sintomaAdapter.Fill(sintomaDataSet, "sintoma")

            For Each sintoma In sintomaDataSet.Tables("sintoma").Rows
                CargarListaSintomas(sintoma)
            Next
            conexion.Cerrar()
        Catch ex As Exception
            mostrarExepcion(ex)
        End Try
    End Sub

    Public Sub CargarListaSintomas(ByRef sintoma As DataRow)
        listaSintomas.Add(New ModeloSintoma With {.ID = sintoma("id"), .Nombre = sintoma("nombre"), .Estado = sintoma("activo")})
    End Sub

    Private Sub mostrarExepcion(ByVal exeption As Exception)
        MsgBox(exeption.Message)
    End Sub

End Class
