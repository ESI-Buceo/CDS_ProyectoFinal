Public Class ModeloSesion
    Inherits ModeloConexion

    Public IdSesion As String = ModeloDiagnostico.CodigoDiagnostico
    Public Prioridad As String = ModeloDiagnostico.Ponderacion
    Public Estado As String

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Sub GuardarSesion()
        'Guarda el inicio de una sesion con su prioridad
        Comando.CommandText = "INSERT INTO sesion (idSesion, prioridad) VALUES(" & Me.IdSesion & ", " & Me.Prioridad & ")"
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function MostrarSesionesPendientes() As DataTable
        'Muestra las sesiones pendientes de inicio ordenadas por prioridad
        Dim tablaSesion As New DataTable
        Comando.CommandText = "SELECT s.idSesion SESION, s.fechaHoraInicioSesion HORA, p.docidentidad DOC, pe.nombres NOMBRES, pe.apellidos APELLIDOS, s.prioridad PRIORIDAD, s.estado ESTADO 
                                FROM sesion s JOIN recibe r ON r.idDiagnostico = s.idSesion JOIN paciente p ON p.docidentidad = r.idPaciente 
                                JOIN persona pe ON pe.docidentidad = p.docidentidad  WHERE s.estado = '0' ORDER BY s.prioridad DESC"
        Reader = Comando.ExecuteReader
        tablaSesion.Load(Reader)
        CerrarConexion()
        Return tablaSesion
    End Function

    Public Function MostrarSesionesEnProceso() As DataTable
        'Muestra las sesiones en proceso
        Dim tablaSesion As New DataTable
        Comando.CommandText = "SELECT s.idSesion SESION, p.docidentidad DOC, pe.nombres NOMBRES, pe.apellidos APELLIDOS, s.prioridad PRIORIDAD, s.estado ESTADO
                                FROM sesion s JOIN recibe r ON r.idDiagnostico = s.idSesion JOIN paciente p ON p.docidentidad = r.idPaciente 
                                JOIN persona pe ON pe.docidentidad = p.docidentidad  WHERE s.estado = '1'"
        Reader = Comando.ExecuteReader
        tablaSesion.Load(Reader)
        CerrarConexion()
        Return tablaSesion
    End Function

End Class
