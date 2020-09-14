Public Class ModeloConfiguracion
    Inherits ModeloConexion

    Public CantidadSintomas As Integer
    Public IdSetting As Integer
    Public IpGestion As String
    Public IpMedicos As String
    Public IpPacientes As String
    Public EmailContacto As String
    Public PuertoSTMP As Integer
    Public ServidorSMTP As String
    Public EmailSSL As Boolean
    Public EmailCredencial As String
    Public Docidentidad As String
    Public TablaConfiuracion As New DataTable

    Public Sub New(ByVal uid As String, pwd As String)
        MyBase.New(uid, pwd)
    End Sub

    Public Function LeerConfiguracion()
        Comando.CommandText = "SELECT * FROM setting"
        Reader = Comando.ExecuteReader
        TablaConfiuracion.Load(Reader)
        CerrarConexion()
        Return TablaConfiuracion
    End Function

    Public Sub GuardarConfiguracion()
        idSetting = 1
        Comando.CommandText = "INSERT INTO setting 
                                (id, cantSintomas,ipGestion, ipMedicos, ipPacientes,emailContacto,emailPuertoSMTP,emailServidorSMPT,emailSSL, emailCredencial,docIdentidad) 
                                VALUES(" & Me.IdSetting & "," & Me.CantidadSintomas & ",'" & Me.IpGestion & "','" & Me.IpMedicos & "','" & Me.IpPacientes & "', '" & Me.EmailContacto & "',  " & Me.PuertoSTMP & ", '" & Me.ServidorSMTP & "', " & Me.EmailSSL & ",'" & Me.EmailCredencial & "','" & Me.Docidentidad & "') 
                                ON DUPLICATE KEY UPDATE cantSintomas =" & Me.CantidadSintomas & ", ipGestion='" & Me.IpGestion & "', ipMedicos='" & Me.IpMedicos & "', ipPacientes ='" & Me.IpPacientes & "',
                                emailContacto='" & Me.EmailContacto & "', emailPuertoSMTP=" & Me.PuertoSTMP & ",emailServidorSMPT='" & Me.ServidorSMTP & "',  emailSSL=" & Me.EmailSSL & ",emailCredencial='" & Me.EmailCredencial & "', 
                                docidentidad='" & Me.Docidentidad & "'"
        Comando.ExecuteNonQuery()
        CerrarConexion()
    End Sub

    Public Function LeerRangoIpGestion()
        Comando.CommandText = "SELECT ipGestion FROM setting"
        Reader = Comando.ExecuteReader()
        Reader.Read()
        Return Reader(0).ToString
    End Function

    Public Function LeerRangoIpMedicos()
        Comando.CommandText = "SELECT ipMedicos FROM setting"
        Reader = Comando.ExecuteReader()
        Reader.Read()
        Return Reader(0).ToString
    End Function

    Public Function LeerRangoIpPacientes()
        Comando.CommandText = "SELECT ipPacientes FROM setting"
        Reader = Comando.ExecuteReader()
        Reader.Read()
        Return Reader(0).ToString
    End Function

    Public Function LeerCantSintomas()
        Comando.CommandText = "SELECT cantSintomas FROM setting"
        Reader = Comando.ExecuteReader()
        Reader.Read()
        Return Reader(0).ToString
    End Function
End Class
