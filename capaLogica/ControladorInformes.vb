Imports System.Data
Imports capaDatos

Public Module ControladorInformes

    Public Function RankingPatologias(ByVal uid As String, pwd As String)
        'Ranking de patologias 
        Dim i As New ModeloInformes(uid, pwd)
        Return i.RankigPatologias(formarCadenaMesesDeConsulta)
    End Function

    Public Function DiagnosticosBrindados(ByVal uid As String, pwd As String)
        'Diagnosticos brindados en los ultimos doce meses moviles
        Dim i As New ModeloInformes(uid, pwd)
        Return cargaTablaConDatosMeses(i.DiagnosticosBrindados(formarCadenaMesesDeConsulta))
    End Function

    Public Function CantidadDeChatMeses(ByVal uid As String, pwd As String)
        'Cantidad de chat en los ultimos 12 meses moviles
        Dim i As New ModeloInformes(uid, pwd)
        Return cargaTablaConDatosMeses(i.CantidadChat(formarCadenaMesesDeConsulta))
    End Function

    Public Function CantidadDeChatMes(ByVal uid As String, pwd As String, ano As String, mes As String)
        'Cantidad de chat en un mes especifico
        Dim i As New ModeloInformes(uid, pwd)
        Return cargarTablaConDatosMes(i.CantidadChatMes(mes, ano), ano, mes)
    End Function

    Public Function SintomasNuncaSeleccionados(ByVal uid As String, pwd As String)
        Dim i As New ModeloInformes(uid, pwd)
        Return i.SintomasNuncaSeleccionados
    End Function

    Public Function SesionesPorMedico(ByVal uid As String, pwd As String, docidentidad As String)
        Dim s As New ModeloSesion(uid, pwd)
        Return cargaTablaConDatosMeses(s.SesionesPorMedico(formarCadenaMesesDeConsulta, docidentidad))
    End Function

    Private Function formarCadenaMesesDeConsulta()
        'Genera el string de busqueda de 12 meses moviles
        Dim cadenaDeConsulta As String
        cadenaDeConsulta = DateTime.Now.ToString("MM")

        For i As Integer = 1 To 11
            cadenaDeConsulta += "," & DateTime.Now.AddMonths(-i).ToString("MM")
        Next
        Return cadenaDeConsulta
    End Function

    Private Function cargaTablaConDatosMeses(ByVal datos As DataTable)
        'Carga la tabla con los datos de la consulta
        Dim tablaDeDatos As New DataTable
        tablaDeDatos = crearTablaMeses()

        For Each meses As DataRow In tablaDeDatos.Rows
            For Each informe As DataRow In datos.Rows
                If meses("Mes").ToString = informe("mes").ToString Then
                    meses("Cantidad") = informe("cant").ToString
                    Exit For
                End If
            Next
        Next
        Return tablaDeDatos
    End Function

    Private Function cargarTablaConDatosMes(ByVal datos As DataTable, ano As String, mes As String)
        'Carga la tabla con los datos de la consulta
        Dim tablaDeDatos As New DataTable
        tablaDeDatos = crearTablaDias(ano, mes)

        For Each dia As DataRow In tablaDeDatos.Rows
            For Each info As DataRow In datos.Rows
                If dia("dia").ToString = info("dia").ToString Then
                    dia("Cantidad") = info("cant").ToString
                    Exit For
                End If
            Next
        Next
        Return tablaDeDatos
    End Function

    Private Function crearTablaMeses() As DataTable
        'Crea la tabla con las columnas correspondientes a los meses
        Dim tablaMeses As New DataTable
        Dim mesActual As Integer
        Dim m As Integer

        tablaMeses.Columns.Add("item")
        tablaMeses.Columns.Add("Mes")
        tablaMeses.Columns.Add("Cantidad")
        m = 11

        For i = 0 To 11
            mesActual = DateTime.Now.AddMonths(-m).ToString("MM")
            tablaMeses.Rows.Add()
            tablaMeses.Rows.Item(i)("item") = i
            tablaMeses.Rows.Item(i)("Mes") = mesActual
            tablaMeses.Rows.Item(i)("Cantidad") = 0
            m -= 1
        Next
        Return tablaMeses
    End Function

    Private Function crearTablaDias(ByVal ano As String, mes As String) As DataTable
        'Crea la tabla con las columnas correspondientes a los dias del mes en cuestion
        Dim tablaDias As New DataTable
        Dim diasDelMes As Integer = DateTime.DaysInMonth(ano, mes)
        Dim diaActual As Integer

        tablaDias.Columns.Add("item")
        tablaDias.Columns.Add("Dia")
        tablaDias.Columns.Add("Cantidad")

        For i = 0 To diasDelMes - 1
            diaActual += 1
            tablaDias.Rows.Add()
            tablaDias.Rows(i).Item("item") = i
            tablaDias.Rows(i).Item("Dia") = diaActual
            tablaDias.Rows(i).Item("Cantidad") = 0
        Next
        Return tablaDias
    End Function

End Module
