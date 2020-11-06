Imports capaDatos

Public Module ControladorSesion
    Public Function GuardarSesionDeChat(ByVal uid As String, pwd As String)
        'Guarda el id de la sesion cuando el paciente desea iniciar un chat
        Dim Sesion As New ModeloSesion(uid, pwd)
        Return Sesion.GuardarSesion()
    End Function

    Public Function ChequearSesionesPendientes(ByVal uid As String, pwd As String)
        'Verifica sesiones pendientes
        Dim sesion As New ModeloSesion(uid, pwd)
        Return sesion.MostrarSesionesPendientes
    End Function

    Public Function chequearSesionesEnEspera(ByVal idMedico As String, pwd As String)
        'Verifica sesiones en espera
        Dim sesion As New ModeloSesion(idMedico, pwd)
        Return sesion.MostrarSesionesEnEspera(idMedico)
    End Function

    Public Function VerificarEstadoDeSesion(ByVal idSesion As String, uid As String, pwd As String)
        'Verifia si el medico ya abrio su chat
        Dim s As New ModeloSesion(uid, pwd)
        Return s.VerificarEstadoSesion(idSesion)
    End Function

    Public Function VerificarEstadoDeSesion(ByVal uid As String, pwd As String)
        'Verifia si el medico ya abrio su chat
        Dim s As New ModeloSesion(uid, pwd)
        Return s.VerificarEstadoSesion()
    End Function

    Public Function DatosDelMedicoSesion(ByVal uid As String, pwd As String)
        'Devuelve el nombre y apellido del medico que chatea
        Dim s As New ModeloSesion(uid, pwd)
        Return s.DevolverNombreApellidoMedico
    End Function

    Public Sub CancelarSesionDeChat(ByVal uid As String, pwd As String)
        'Guarda el estado cuando el paciente cancela el chat
        Dim s As New ModeloSesion(uid, pwd)
        s.GuardarEstado("4")
    End Sub

    Public Sub GuardarEstadoSesion(ByVal idSesion As String, uid As String, pwd As String)
        'Guarda el estado de finalizacion por parte del medico - Estado 3
        Dim s As New ModeloSesion(uid, pwd)
        s.GuardarEstado(idSesion, 3)
    End Sub

End Module
