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

End Module
