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


End Module
