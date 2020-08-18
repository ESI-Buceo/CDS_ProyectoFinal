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

    Public Sub EnviarMensajePaciente(ByVal mensaje As String, idSesion As String, uid As String, pwd As String, idmedico As String)
        Dim c As New ModeloChat(uid, pwd)
        c.idSesion = idSesion
        c.mensaje = mensaje
        c.emisor = "P"
        c.docidentidadMedico = idmedico
        c.docidentidadPaciente = uid
        c.enviarMensaje()
    End Sub

    Public Sub EnviarMensajeMedico(ByVal mensaje As String, idSesion As String, uid As String, pwd As String, idpaciente As String)
        Dim c As New ModeloChat(uid, pwd)
        c.idSesion = idSesion
        c.mensaje = mensaje
        c.emisor = "M"
        c.docidentidadPaciente = idpaciente
        c.docidentidadMedico = uid
        c.enviarMensaje()
    End Sub

    Public Sub MarcarMensajeLeido(ByVal id As String, uid As String, pwd As String)
        Dim c As New ModeloChat(uid, pwd)
        c.MarcarMensajeLeido(id)
    End Sub

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

    Public Sub MarcarEnProceso(ByVal idSesion As String, estado As String, uid As String, pwd As String)
        'Marca la sesion en proceso
        Dim s As New ModeloSesion(uid, pwd)
        s.GuardarEstado(idSesion, estado)
    End Sub

    Public Sub EnviarChatAEspera(ByVal idSesion As String, uid As String, pwd As String)
        'pone la sesion en espera
        Dim c As New ModeloSesion(uid, pwd)
        c.GuardarEstado(idSesion, "2")
    End Sub

    Public Sub MensajeInicioDeSesion(ByVal IdSesion As String, uid As String, pwd As String, idpaciente As String)
        'Si es la primera vez que abre sesion manda mensaje de inicio
        Dim s As New ModeloSesion(uid, pwd)
        If s.VerificarEstadoSesion(IdSesion) = 0 Then
            enviarMensajeDeEspera(IdSesion, uid, pwd, idpaciente)
        End If
        marcarchatEnProceso(IdSesion, uid, pwd)
    End Sub

    Private Sub marcarchatEnProceso(ByVal idSesion As String, uid As String, pwd As String)
        'Marca el estado del chat en proceso
        ControladorChat.MarcarEnProceso(idSesion, "1", uid, pwd)
    End Sub

    Private Sub enviarMensajeDeEspera(ByVal idSesion As String, uid As String, pwd As String, idpaciente As String)
        Dim c As New ModeloChat(uid, pwd) With {
        .mensaje = "El medico ha iniciado sesion, aguarda por favor...",
        .emisor = "M",
        .docidentidadPaciente = idpaciente,
        .docidentidadMedico = uid,
        .idSesion = idSesion
        }
        c.enviarMensaje()
    End Sub
End Module
