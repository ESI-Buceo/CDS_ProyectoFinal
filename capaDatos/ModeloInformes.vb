Public Class ModeloInformes
    Inherits ModeloConexion

    Public tablaInformes As New DataTable

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function RankigPatologias(ByVal listaDeMeses As String)
        'Ranquea las 10 patologias mas diagnosticadas en los ultimos 12 meses moviles
        Comando.CommandText = "SELECT count(DISTINCT (t.idDiagnostico) ) cantidad, p.nombre nombre, p.id 
                                FROM recibe r 
                                JOIN diagnostico d ON d.id  = r.idDiagnostico 
                                JOIN tiene t ON t.idDiagnostico  = d.id 
                                JOIN patologia p ON p.id = t.idPatologia
                                WHERE MONTH(r.fechaHora) in (" & listaDeMeses & ")
                                GROUP BY p.nombre, p.id 
                                ORDER BY cantidad DESC
                                LIMIT 10"
        Reader = Comando.ExecuteReader()
        tablaInformes.Load(Reader)
        CerrarConexion()
        Return tablaInformes
    End Function

    Public Function DiagnosticosBrindados(ByVal listaDeMeses As String)
        'Resumen de la cantidad e diagnosticos brindados 
        Comando.CommandText = "SELECT  MONTH(r.fechaHora ) mes, count(*) as cant
                                FROM recibe r 
                                WHERE MONTH(r.fechaHora) in (" & listaDeMeses & ") 
                                GROUP BY MONTH(r.fechaHora )"
        Reader = Comando.ExecuteReader
        tablaInformes.Load(Reader)
        CerrarConexion()
        Return tablaInformes
    End Function

    Public Function CantidadChat(ByVal listaDeMeses As String)
        'Resume la cantidad de chat en los 12  meses moviles
        Comando.CommandText = "SELECT COUNT(DISTINCT(s.idSesion) ) cant, MONTH(s.fechaHoraInicioSesion ) mes
                                FROM sesion s 
                                JOIN chat c2 ON c2.idSesion = s.idSesion 
                                WHERE MONTH(s.fechaHoraInicioSesion ) IN (" & listaDeMeses & ")
                                GROUP BY MONTH(s.fechaHoraInicioSesion ) "
        Reader = Comando.ExecuteReader
        tablaInformes.Load(Reader)
        CerrarConexion()
        Return tablaInformes
    End Function

    Public Function CantidadChatMes(ByVal mes As String, ano As String)
        'Informe de cantidad de chat en el mes y ano indicado
        Comando.CommandText = "SELECT COUNT(DISTINCT(s.idSesion) ) cant, DAY(s.fechaHoraInicioSesion ) dia
                                FROM sesion s 
                                JOIN chat c2 ON c2.idSesion = s.idSesion 
                                WHERE MONTH(s.fechaHoraInicioSesion ) IN (" & mes & ") AND 
                                YEAR(s.fechaHoraInicioSesion) = " & ano & "
                                GROUP BY DAY (s.fechaHoraInicioSesion ) "
        Reader = Comando.ExecuteReader
        tablaInformes.Load(Reader)
        CerrarConexion()
        Return tablaInformes
    End Function

    Public Function SintomasNuncaSeleccionados()
        Comando.CommandText = "Select s.id ID, s.nombre Nombre
                                From sintoma s 
                                WHERE NOT EXISTS(SELECT NULL
                                From tiene t
                                WHERE t.idSintoma = s.id ) And s.activo"
        Reader = Comando.ExecuteReader
        tablaInformes.Load(Reader)
        CerrarConexion()
        Return tablaInformes
    End Function

End Class
