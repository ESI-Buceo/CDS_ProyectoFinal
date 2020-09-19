Imports capaDatos
Imports System.Data

Public Module ControladorChat
    Public Function RecibirMensajes(ByVal emisor As String, uid As String, pwd As String)
        'muestra los mensajes del usuario logeado
        Dim c As New ModeloChat(uid, pwd)
        Return c.RecibirMensajes(emisor)
    End Function

    Public Function RecibirMensajes(ByVal idSesion As String, emisor As String, uid As String, pwd As String)
        'Muestra los mensajes recibidos por id
        Dim c As New ModeloChat(uid, pwd)
        Return c.RecibirMensajes(idSesion, emisor)
    End Function

    Public Function RecibirTodosMensajes(ByVal idSesion As String, uid As String, pwd As String)
        'Muestra los mensajes recibidos por id
        Dim c As New ModeloChat(uid, pwd)
        Return c.RecibirTodosMensajes(idSesion)
    End Function

    Public Function EnviarMensajePaciente(ByVal mensaje As String, idSesion As String, uid As String, pwd As String, idmedico As String)
        Try
            Dim c As New ModeloChat(uid, pwd)
            c.idSesion = idSesion
            c.mensaje = mensaje
            c.emisor = "P"
            c.docidentidadMedico = idmedico
            c.docidentidadPaciente = uid
            c.enviarMensaje()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function EnviarMensajeMedico(ByVal mensaje As String, idSesion As String, uid As String, pwd As String, idpaciente As String)
        Try
            Dim c As New ModeloChat(uid, pwd)
            c.idSesion = idSesion
            c.mensaje = mensaje
            c.emisor = "M"
            c.docidentidadPaciente = idpaciente
            c.docidentidadMedico = uid
            c.enviarMensaje()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function MarcarMensajeLeido(ByVal id As String, uid As String, pwd As String)
        Try
            Dim c As New ModeloChat(uid, pwd)
            c.MarcarMensajeLeido(id)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function DatosPaciente(ByVal idSesion As String, uid As String, pwd As String)
        'retorna los datos del paciente que solicito el chat
        Dim p As New ModeloPaciente(uid, pwd)
        Return p.DatosPaciente(idSesion)
    End Function

    Public Function MostrarSintomasPaciente(ByVal idSesion As String, uid As String, pwd As String)
        'Muestra el nombre de los sintomas ingresados por el paciente
        Dim s As New ModeloSintoma(uid, pwd)
        Return s.SintomasIngresadosPorPaciente(idSesion)
    End Function

    Public Function MarcarEnProceso(ByVal idSesion As String, estado As String, uid As String, pwd As String)
        Try
            'Marca la sesion en proceso
            Dim s As New ModeloSesion(uid, pwd)
            s.GuardarEstado(idSesion, estado)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function EnviarChatAEspera(ByVal idSesion As String, uid As String, pwd As String)
        Try
            'pone la sesion en espera
            Dim c As New ModeloSesion(uid, pwd)
            c.GuardarEstado(idSesion, "2")
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function MensajeInicioDeSesion(ByVal IdSesion As String, uid As String, pwd As String, idpaciente As String)
        Try
            'Si es la primera vez que abre sesion manda mensaje de inicio
            Dim s As New ModeloSesion(uid, pwd)
            If s.VerificarEstadoSesion(IdSesion) = 0 Then
                enviarMensajeDeEspera(IdSesion, uid, pwd, idpaciente)
            End If
            marcarchatEnProceso(IdSesion, uid, pwd)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function marcarchatEnProceso(ByVal idSesion As String, uid As String, pwd As String)
        Try
            'Marca el estado del chat en proceso
            ControladorChat.MarcarEnProceso(idSesion, "1", uid, pwd)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function enviarMensajeDeEspera(ByVal idSesion As String, uid As String, pwd As String, idpaciente As String)
        Try
            Dim c As New ModeloChat(uid, pwd) With {
        .mensaje = "El medico ha iniciado sesion, aguarda por favor...",
        .emisor = "M",
        .docidentidadPaciente = idpaciente,
        .docidentidadMedico = uid,
        .idSesion = idSesion
        }
            c.enviarMensaje()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function ListaHistoricaChatPaciente(ByVal uid As String, pwd As String, docidentidad As String)
        'Trae la lista de chat del paciente
        Dim c As New ModeloChat(uid, pwd)
        Return c.ListaHistoricaChatPaciente(docidentidad)
    End Function

    Public Function CantidadDeChats(ByVal uid As String, pwd As String, documento As String)
        Dim c As New ModeloChat(uid, pwd)
        Return c.CantidadDeChats(documento)
    End Function

End Module
