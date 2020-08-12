Imports System.Data.Odbc

Public Class ModeloAsociados
    Inherits ModeloConexion

    Public IdPatologia As Integer
    Public IdSintoma As Integer

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function FiltrarPatologiasPorSintomas(ByVal sqlSintomas As String, cantidadSintomas As Integer)
        'carga la lista de la tabla asociados donde se vinculan patologias, sintomas y signos
        Dim tabla As New DataTable
        Comando.CommandText = "SELECT a.idPatologia, p2.nombre , p2.descripcion , p2.ponderacion FROM asociados a join patologia p2 on p2.id = a.idPatologia and p2.activo = 1 JOIN sintoma s ON s.id = a.IdSintoma  AND s.activo WHERE a.IdSintoma IN (" & sqlSintomas & ") GROUP BY a.idPatologia HAVING count(a.idPatologia ) >='" & cantidadSintomas & "'"
        Reader = Comando.ExecuteReader()
        tabla.Load(Reader)
        CerrarConexion()
        Return tabla
    End Function
End Class
