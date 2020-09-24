Imports System.Data.Odbc

Public Class ModeloChat
    Inherits ModeloConexion

    Public idSesion As String
    Public docidentidadPaciente As String
    Public docidentidadMedico As String
    Public emisor As String
    Public mensaje As String
    Public TablaChat As New DataTable

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function enviarMensaje()
        Comando.CommandText = "INSERT INTO chat (docidentidadPaciente, docidentidadMedico, idSesion, emisor, mensaje) VALUES (" & Me.docidentidadPaciente & "," & Me.docidentidadMedico & ", " & Me.idSesion & ",'" & Me.emisor & "', '" & Me.mensaje & "')"
        Comando.ExecuteNonQuery()
        CerrarConexion()
        Return True
    End Function

    Public Function RecibirMensajes(ByVal emisor As String)
        Dim tablaMensajes As New DataTable
        Comando.CommandText = "SELECT * FROM chat WHERE idSesion = " & ModeloDiagnostico.CodigoDiagnostico & " AND leido = 0 AND emisor <> '" & emisor & "'"
        Reader = Comando.ExecuteReader
        tablaMensajes.Load(Reader)
        CerrarConexion()
        Return tablaMensajes
    End Function

    Public Function RecibirMensajes(ByVal idSesion As String, emisor As String)
        'Lo utiliza la app del paciente
        Dim tablaMensajes As New DataTable
        Comando.CommandText = "SELECT * FROM chat WHERE idSesion = " & idSesion & " AND leido = 0 AND emisor <> '" & emisor & "'"
        Reader = Comando.ExecuteReader
        tablaMensajes.Load(Reader)
        CerrarConexion()
        Return tablaMensajes
    End Function

    Public Function RecibirTodosMensajes(ByVal idSesion As String)
        Dim tablaMensajes As New DataTable
        Comando.CommandText = "SELECT * FROM chat WHERE idSesion = " & idSesion
        Reader = Comando.ExecuteReader
        tablaMensajes.Load(Reader)
        CerrarConexion()
        Return tablaMensajes
    End Function

    Public Sub MarcarMensajeLeido(ByVal id As String)
        Comando.CommandText = "UPDATE chat SET leido = 1 WHERE id =" & id
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function ListaHistoricaChatPaciente(ByVal idPaciente As String)
        'Lista el historico de chat del paciente
        Comando.CommandText = "SELECT DISTINCT(s.idSesion ) sesion, s.fechaHoraInicioSesion FechaHora, p.apellidos, p.nombres from chat c 
                                JOIN sesion s ON s.idSesion = c.idSesion
                                JOIN persona p ON p.docidentidad = c.docidentidadMedico 
                                WHERE c.docidentidadPaciente =" & idPaciente & " ORDER BY FechaHora DESC"
        Reader = Comando.ExecuteReader()
        TablaChat.Load(Reader)
        conexion.Close()
        Return TablaChat
    End Function

    Public Function CantidadDeChats(ByVal docidentidad As String)
        'Muestra la cantida de chat iniciados por el documento ingresado
        Comando.CommandText = "SELECT count(DISTINCT(idSesion )) cant FROM chat WHEre docidentidadPaciente=" & docidentidad
        Reader = Comando.ExecuteReader
        Reader.Read()
        Return Reader("cant").ToString
    End Function

End Class
