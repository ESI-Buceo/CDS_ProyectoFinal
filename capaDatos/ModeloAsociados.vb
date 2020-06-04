Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ModeloAsociados
    Public IdPatologia As Integer
    Public IdSintoma As Integer
    Public IdSigno As Integer
    Public incluida As Boolean
    Public ListaRelacionPatologiaSintoma As New List(Of ModeloAsociados)


    Public Sub CargarListaAsociadosBD()
        'carga la lista de la tabla asociados donde se vinculan patologias, sintomas y signos
        Try
            Dim conexion As New ModeloConexion
            Dim asociadosAdatador As System.Data.Odbc.OdbcDataAdapter
            Dim asociadosDataSet As New DataSet
            Dim asociadosSQL As String = "SELECT DISTINCT(a.idPatologia), a.idPatologia, a.idSintoma, a.idSigno FROM asociados a JOIN patologia p ON p.activo = 1"
            asociadosAdatador = New System.Data.Odbc.OdbcDataAdapter(asociadosSQL, conexion.Abrir)
            asociadosAdatador.Fill(asociadosDataSet, "asociados")
            cargarListaAsociados(asociadosDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cargarListaAsociados(ByRef asociadosDataSet As DataSet)
        'carga la lista de ListaPatologiasXSintomas con la informacion de la BD
        ListaRelacionPatologiaSintoma.Clear()
        For Each asociados In asociadosDataSet.Tables("asociados").Rows
            ListaRelacionPatologiaSintoma.Add(New ModeloAsociados With {.IdPatologia = asociados("idPatologia"), .IdSintoma = asociados("idSintoma"), .IdSigno = asociados("idSigno")})
        Next
    End Sub

End Class
