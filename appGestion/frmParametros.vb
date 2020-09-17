Imports capaLogica

Public Class frmParametros

    Private Sub frmParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga la informacion de configuracion almacenada
        cargarTextos()
        cargarConfiguracion()
        chkConfigurarEmail.CheckState = My.Settings.configurarEmail
    End Sub

    Private Sub cargarConfiguracion()
        'Trae la informacion de configuracion
        Try
            mostrarConfiguracion(ControladorConfiguracion.LeerConfiguracion(USUARIO, PASSWORD))
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoError)
        End Try
    End Sub

    Private Sub mostrarConfiguracion(ByVal tablaDatos As DataTable)
        'Muestra la informacion de configuracion
        txtCantSintomas.Text = tablaDatos.Rows(0).Item("cantsintomas")
        txtIpGestion.Text = tablaDatos.Rows(0).Item("ipGestion")
        txtIpMedicos.Text = tablaDatos.Rows(0).Item("ipMedicos")
        txtIpPacientes.Text = tablaDatos.Rows(0).Item("ipPacientes")
        txtEmailContacto.Text = tablaDatos.Rows(0).Item("emailContacto")
        txtEmailPuerto.Text = tablaDatos.Rows(0).Item("emailPuertoSMTP")
        txtServidorSMTP.Text = tablaDatos.Rows(0).Item("emailServidorSMPT")
        chkEmailSSL.CheckState = tablaDatos.Rows(0).Item("emailSSL")
        txtEmailCredencial.Text = tablaDatos.Rows(0).Item("emailCredencial")
    End Sub

    Private Sub cargarTextos()
        'Carga los textos en el idioma que corresponda
        Me.Text = VParametrosSistema.ToUpper
        gbParametros.Text = VParametrosSistema
        btnCerrar.Text = VCerrar
        lblLengSistema.Text = VIdiomaSistema
        lblDescIdiomaSistema.Text = VDescIdiomaSistema
        lblLenguaje.Text = VLenguaje
        cbLenguaje.Items.Clear()
        cbLenguaje.Items.Add(VEspanol)
        cbLenguaje.Items.Add(VIngles)
        btnAplicar.Text = VAplicar
        lblTituloCantSintomas.Text = VSintomas
        lblSubTitleCantSintomas.Text = VSubTituloSintomas
        lblCantidad.Text = VCantidad
        lblTituloIP.Text = VConexiones
        lblIPConexiones.Text = VSubTituloConexiones
        lblIpGestor.Text = VIpGestion
        lblIRangoMedicos.Text = VIpMedicos
        lblIpAppPaciente.Text = VIpPacientes
        chkConfigurarEmail.Text = VConfigurarEmail
        gbEmail.Text = VDatosEmail
        lblSubTituloEmail.Text = VSubTituloEmail
        lblEmailContacto.Text = VEmailDeContacto
        lblEmailPuerto.Text = VPuertoSMTP
        lblEmailServidorSMTP.Text = VServidorSMTP
        lblEmailCredencial.Text = VCredencial
        mostrarIdiomaActual()
    End Sub

    Private Sub mostrarIdiomaActual()
        'Modifica el idioma del sistema
        If My.Settings.lenguaje.Equals("es") Then
            cbLenguaje.SelectedItem = VEspanol
        Else
            cbLenguaje.SelectedItem = VIngles
        End If
    End Sub

    Private Sub cbLenguaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLenguaje.SelectedIndexChanged
        'verifica si efectivamente se cambia el idioma
        If cbLenguaje.Text <> idiomaCorto(My.Settings.lenguaje) Then
            confirmarCambioDeIdioma()
        End If

    End Sub

    Private Sub confirmarCambioDeIdioma()
        'Selecciona el idioma del sistema
        Dim respuesta As Integer

        respuesta = MsgBox(VEstecambioRequiereReiniciarLaAplicacion, vbQuestion & vbYesNo, VAviso)
        If respuesta = 6 Then
            guardarIdioma()
        Else
            cbLenguaje.SelectedText = My.Settings.lenguaje
        End If
    End Sub

    Private Sub guardarIdioma()
        'Guarda la configuracion
        lang.GuardarIdioma(cbLenguaje.Text)
        End
    End Sub

    Private Function idiomaCorto(ByVal idioma As String)
        'Muestra el idioma seleccionado
        Select Case idioma
            Case "es" : Return VEspanol
            Case "en" : Return VIngles
        End Select
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        'Aplica los cambios en la configuracion del sistema
        If validarCantidadSintomas() And verificarSiSeConfiguraEmail() Then
            ControladorConfiguracion.GuardarConfiguracion(USUARIO, PASSWORD, txtCantSintomas.Text, txtIpGestion.Text, txtIpMedicos.Text,
                                                          txtIpPacientes.Text, txtEmailContacto.Text, txtEmailPuerto.Text, txtServidorSMTP.Text,
                                                          chkEmailSSL.CheckState, txtEmailCredencial.Text)
            MsgBox(VSeGuardoLaConfiguracion, vbInformation, VConfiguracion)
            configurarEmail()
        Else
            MsgBox(VErrorConfiguracion, vbCritical, VAvisoError)
        End If
    End Sub

    Private Function validarCantidadSintomas()
        'Valida si la cantidad de sintomas es un numero
        If ControladorValidaciones.validarNumero(txtCantSintomas.Text) Then
            Return True
        Else
            MsgBox(VCantidadSintomasIncorrecto, vbInformation, VAviso)
            txtCantSintomas.Select()
        End If
        Return False
    End Function

    Private Function verificarSiSeConfiguraEmail()
        'Verifica si se confugraron los datos el email cuando corresponda
        If chkConfigurarEmail.CheckState Then
            Return validarConfiguracionEmail()
        Else
            Return True
        End If
        Return False
    End Function

    Private Function validarConfiguracionEmail()
        'Valida la configuracion del email
        If ValidarEmail(txtEmailContacto.Text) And validarNumero(txtEmailPuerto.Text) And
            ValidarCampoVacio(txtServidorSMTP.Text) And ValidarCampoVacio(txtEmailCredencial.Text) Then
            Return True
        Else
            MsgBox(VAlgoEnLaConfiguracionNoEstaBien, vbExclamation, VAviso)
        End If
        Return False
    End Function

    Private Sub estadoConfigurarEmail()
        'Verifica si se debe o no configurar el email
        My.Settings.configurarEmail = chkConfigurarEmail.CheckState
        My.Settings.Save()
    End Sub

    Private Sub chkConfigurarEmail_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfigurarEmail.CheckedChanged
        habilitarConfEmail()
    End Sub

    Private Sub configurarEmail()
        My.Settings.configurarEmail = chkConfigurarEmail.CheckState
        My.Settings.Save()
    End Sub

    Private Sub habilitarConfEmail()
        If chkConfigurarEmail.CheckState Then
            gbEmail.Enabled = True
            txtEmailContacto.Select()
        Else
            gbEmail.Enabled = False
        End If
    End Sub

End Class