Imports System.Data
Imports capaDatos

Public Module ControladorConfiguracion
    Public Function cargarConfiguracion(ByVal drive As String, ip As String, dbase As String)
        If drive IsNot Nothing And ip IsNot Nothing Then
            ModeloConexion.Driver = drive
            ModeloConexion.ipServer = ip
            ModeloConexion.Database = dbase
            Return True
        End If
        Return False
    End Function

    Public Function LeerConfiguracion(ByVal uid As String, pwd As String)
        Dim c As New ModeloConfiguracion(uid, pwd)
        Return c.LeerConfiguracion()
    End Function

    Public Sub GuardarConfiguracion(ByVal uid As String, pwd As String, cantSintomas As String,
                                    ipGestion As String, ipMedicos As String, ipPacienes As String,
                                    emailContacto As String, emailPuertoSmtp As String, emailServidorStmp As String,
                                    emailSSL As String, emailCredencial As String)
        'Guarda la configuracion de las aplicaciones
        Dim c As New ModeloConfiguracion(uid, pwd)
        c.CantidadSintomas = cantSintomas
        c.IpGestion = ipGestion
        c.IpMedicos = ipMedicos
        c.IpPacientes = ipPacienes
        c.EmailContacto = emailContacto
        c.PuertoSTMP = CInt(emailPuertoSmtp)
        c.ServidorSMTP = emailServidorStmp
        c.EmailSSL = emailSSL
        c.EmailCredencial = emailCredencial
        c.Docidentidad = uid
        c.GuardarConfiguracion()
    End Sub

    Public Function leerRangoIpGestion(ByVal uid As String, pwd As String)
        Dim c As New ModeloConfiguracion(uid, pwd)
        Return c.LeerRangoIpGestion()
    End Function

    Public Function LeerRangoIpMedicos(ByVal uid As String, pwd As String)
        Dim c As New ModeloConfiguracion(uid, pwd)
        Return c.LeerRangoIpMedicos()
    End Function

    Public Function LeerRangoIpPacientes(ByVal uid As String, pwd As String)
        Dim c As New ModeloConfiguracion(uid, pwd)
        Return c.LeerRangoIpPacientes()
    End Function

    Public Function LeerCantSintomas(ByVal uid As String, pwd As String)
        Dim c As New ModeloConfiguracion(uid, pwd)
        Return c.LeerCantSintomas()
    End Function
End Module
