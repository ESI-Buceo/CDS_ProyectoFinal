Public Class ModeloInformes
    Inherits ModeloConexion

    Public tablaInformes As New DataTable

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function RankigPatologias(ByVal listaDeMeses As String)
        Comando.CommandText = "SELECT count(DISTINCT(t.idDiagnostico )) Patologia, p.nombre, MONTH(r.fechaHora ) mes  
                                FROM recibe r 
                                JOIN diagnostico d ON d.id = r.idDiagnostico
                                JOIN tiene t ON t.idDiagnostico = d.id  
                                JOIN patologia p ON p.id = t.idPatologia
                                WHERE MONTH(r.fechaHora) IN (" & listaDeMeses & ")
                                GROUP BY MONTH(r.fechaHora ), t.idPatologia"
        Reader = Comando.ExecuteReader()
        tablaInformes.Load(Reader)
        Return tablaInformes
    End Function
End Class