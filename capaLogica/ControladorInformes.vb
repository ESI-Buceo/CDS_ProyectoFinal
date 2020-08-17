Imports capaDatos

Public Module ControladorInformes
    Public Function RankingPatologias(ByVal uid As String, pwd As String)
        Dim i As New ModeloInformes(uid, pwd)
        Return i.RankigPatologias(formarCadenaMesesDeConsulta)
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
End Module