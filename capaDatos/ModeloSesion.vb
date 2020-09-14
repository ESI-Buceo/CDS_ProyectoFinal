Public Class ModeloSesion
    Inherits ModeloConexion

    Public IdSesion As String = ModeloDiagnostico.CodigoDiagnostico
    Public Prioridad As String = ModeloDiagnostico.Ponderacion
    Public Estado As String

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function GuardarSesion()
        'Guarda el inicio de una sesion con su prioridad
        Comando.CommandText = "INSERT INTO sesion (idSesion, prioridad) VALUES(" & Me.IdSesion & ", " & Me.Prioridad & ")"
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return Me.IdSesion
    End Function

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

    Public Function MostrarSesionesEnEspera(ByVal idMedico As String)
        'Muestra las sesiones en espera
        Dim tablaSesion As New DataTable
        Comando.CommandText = "SELECT DISTINCT(s.idSesion) SESION, s.fechaHoraInicioSesion HORA, p.docidentidad DOC, pe.nombres NOMBRES, pe.apellidos APELLIDOS, s.prioridad PRIORIDAD, s.estado ESTADO
                                FROM sesion s JOIN recibe r ON r.idDiagnostico = s.idSesion JOIN paciente p ON p.docidentidad = r.idPaciente 
                                JOIN persona pe ON pe.docidentidad = p.docidentidad JOIN chat ch ON ch.docidentidadMedico = '" & idMedico & "' WHERE s.estado ='2' ORDER BY s.prioridad DESC "
        Reader = Comando.ExecuteReader
        tablaSesion.Load(Reader)
        CerrarConexion()
        Return tablaSesion
    End Function

    Public Function MostrarSesionesFinalizadas() As DataTable
        'Muestra las sesiones finalizadas
        Dim tablaSesion As New DataTable
        Comando.CommandText = "SELECT s.idSesion SESION, p.docidentidad DOC, pe.nombres NOMBRES, pe.apellidos APELLIDOS, s.prioridad PRIORIDAD, s.estado ESTADO
                                FROM sesion s JOIN recibe r ON r.idDiagnostico = s.idSesion JOIN paciente p ON p.docidentidad = r.idPaciente 
                                JOIN persona pe ON pe.docidentidad = p.docidentidad  WHERE s.estado = '3'"
        Reader = Comando.ExecuteReader
        tablaSesion.Load(Reader)
        CerrarConexion()
        Return tablaSesion
    End Function

    Public Function MostrarSesionesCanceladasUsuarios() As DataTable
        'Muestra las sesiones canceladas por el usuario
        Dim tablaSesion As New DataTable
        Comando.CommandText = "SELECT s.idSesion SESION, p.docidentidad DOC, pe.nombres NOMBRES, pe.apellidos APELLIDOS, s.prioridad PRIORIDAD, s.estado ESTADO 
                                FROM sesion s JOIN recibe r ON r.idDiagnostico = s.idSesion JOIN paciente p ON p.docidentidad = r.idPaciente 
                                JOIN persona pe ON pe.docidentidad = p.docidentidad  WHERE s.estado = '4'"
        Reader = Comando.ExecuteReader
        tablaSesion.Load(Reader)
        CerrarConexion()
        Return tablaSesion
    End Function

    Public Function VerificarEstadoSesion()
        'devuelve el estado de la sesion
        Comando.CommandText = "SELECT estado FROM sesion WHERE idSesion =" & ModeloDiagnostico.CodigoDiagnostico
        Reader = Comando.ExecuteReader
        Reader.Read()
        Return Reader(0).ToString
    End Function


    Public Function DevolverNombreApellidoMedico()
        'Devuelce los datos del medico que esta en el chat
        Dim tablaDatosMedico As New DataTable
        Comando.CommandText = "SELECT p.nombres NOMBRE, p.apellidos APELLIDO, p.docidentidad DOCUMENTO 
                                FROM chat c 
                                JOIN medico m ON m.docidentidad = c.docidentidadMedico 
                                JOIN persona p ON p.docidentidad = m.docidentidad 
                                WHERE c.idSesion =" & ModeloDiagnostico.CodigoDiagnostico
        Reader = Comando.ExecuteReader()
        tablaDatosMedico.Load(Reader)
        CerrarConexion()
        Return tablaDatosMedico
    End Function

    Public Sub GuardarEstado(ByVal idSesion As String, ByVal estado As String)
        'Guarda el estado de la sesion cuando esta no fue cancelada por el usuario
        Comando.CommandText = "UPDATE sesion SET estado = '" & estado & "' WHERE idSesion =" & idSesion & " AND estado <> 4"
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Sub GuardarEstado(ByVal estado As String)
        'Guarda el estado de la sesion cuando esta no fue cancelada por el usuario
        Comando.CommandText = "UPDATE sesion SET estado = '" & estado & "' WHERE idSesion =" & Me.IdSesion & " AND estado <> 4"
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function VerificarEstadoSesion(ByVal idSesion As String) As Integer
        'devuelve el estado de la sesion
        Dim estado As Integer
        Comando.CommandText = "SELECT estado FROM sesion WHERE idSesion =" & idSesion
        Reader = Comando.ExecuteReader
        Reader.Read()
        estado = Reader(0).ToString
        CerrarConexion()
        Return estado
    End Function

End Class
