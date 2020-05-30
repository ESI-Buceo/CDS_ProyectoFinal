Public Class ModeloSesion
    Public IDChat As String
    Public Estado As Integer
    Public FechaHoraInicio As String
    Public FechaHoraFin As String
    Public Prioridad As Integer

    Private Function generarNuevaSesion()
        'Genera un numero de sesion aletorio como ID uni de chat
        Return IDChat
    End Function

    Public Function GuardarSesionChat()
        'Guarda la sesion de chat
        Return True
    End Function

End Class
