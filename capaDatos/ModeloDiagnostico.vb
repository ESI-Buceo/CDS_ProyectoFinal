Imports System.Data.Odbc

Public Class ModeloDiagnostico
    Inherits ModeloConexion

    Public Shared CodigoDiagnostico As String
    Public Shared Ponderacion As String
    Public TablaDatos As New DataTable

    Public Sub New(ByRef uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function GuardarDiagnostico() As Boolean
        'codigo para guardar el diagnostico en la base de datos
        Comando.CommandText = "INSERT INTO diagnostico VALUES (" & CodigoDiagnostico & ", " & Ponderacion & ")"
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function

    Public Function TraerDiagnosticos(ByVal documento As String)
        'Recupera los diagnosticos del usuario que inicio sesion
        Comando.CommandText = "SELECT DISTINCT(d.id) id, r.fechaHora fechahora, d.prioridad prioridad
                                FROM recibe r 
                                JOIN diagnostico d ON d.id = r.idDiagnostico
                                JOIN tiene t ON t.idDiagnostico = d.id 
                                WHERE r.idPaciente =" & documento & " ORDER BY d.prioridad DESC"
        Reader = Comando.ExecuteReader()
        TablaDatos.Load(Reader)
        conexion.Close()
        Return TablaDatos
    End Function

    Public Function cantidadDeDiagnosticos(ByVal docidentidad As String)
        'Muestra la cantidad de diagnosticos del documento indicado
        Comando.CommandText = "SELECT COUNT(*) cant FROM recibe WHERE  idPaciente =" & docidentidad
        Reader = Comando.ExecuteReader
        Reader.Read()
        Return Reader("cant").ToString
    End Function
End Class
