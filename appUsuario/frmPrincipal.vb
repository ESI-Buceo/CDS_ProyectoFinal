Imports capaLogica
Public Class frmPrincipal
    Public panelActivo As Panel
    Public ListaSintomasSeleccionados As New List(Of Integer)
    Public sintomaSeleccionado As Boolean = False

    Private Sub btnIniciarAutenticado_Click(sender As Object, e As EventArgs) Handles btnIniciarAutenticado.Click
        frmLoginRegistrado.ShowDialog()
    End Sub

    Private Sub btnIngresarInvitado_Click(sender As Object, e As EventArgs)
        frmLoginInvitado.ShowDialog()
    End Sub

    Private Sub btnHistoria_Click(sender As Object, e As EventArgs) Handles btnHistoria.Click
        cambiarPanel(panelHistoria)
        clickBotonHistoria()
    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        cambiarPanel(panelChat)
        clickBotonChat()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        cambiarPanel(PanelDeConsulta)
        clickBotonConsulta()
    End Sub

    Private Sub cambiarPanel(ByRef panel As Panel)
        panelActivo.Visible = False
        panelActivo = panel
        panelActivo.Visible = True
    End Sub

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        iniciarConsulta()
    End Sub

    Private Sub txtSintoma_GotFocus(sender As Object, e As EventArgs) Handles txtSintoma.GotFocus
        txtSintoma.Text = ""
        txtSintoma.ForeColor = Color.Gray
    End Sub

    Private Sub btnSiguienteSintoma_Click(sender As Object, e As EventArgs) Handles btnSiguienteSintoma.Click
        If sintomaSeleccionado Then
            opcionIngresarMasSintomas()
        Else
            frmListaSintomas.ShowDialog()
        End If
    End Sub

    Private Sub opcionIngresarMasSintomas()
        If ListaSintomasSeleccionados.Count >= ControladorConfiguracion.LeerCantSintomas(USUARIO, PASSWD) Then
            lblPregunta.Text = VDeseasIngresarUnNuevoSintomas
            preguntarPorNuevoSintoma()
        Else
            nuevaPregunta()
        End If
    End Sub

    Private Sub nuevaPregunta()
        lblPregunta.Text = NuevoMensaje()
        txtSintoma.Select()
        sintomaSeleccionado = False
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        lblPregunta.Width = 370
        lblPregunta.Height = 200
        lblPregunta.AutoSize = False
        lblPregunta.Text = VPresionaParaVerInforme
        panelBotonSiNo.Visible = False
        btnVerInforme.Visible = True
    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        seguirIngresandoSintomas()
        nuevaPregunta()
    End Sub

    Private Sub preguntarPorNuevoSintoma()
        panelBotonSiNo.Visible = True
        txtSintoma.Visible = False
        lblLine.Visible = False
        btnSiguienteSintoma.Visible = False
    End Sub

    Private Sub seguirIngresandoSintomas()
        panelBotonSiNo.Visible = False
        txtSintoma.Visible = True
        lblLine.Visible = True
        btnSiguienteSintoma.Visible = True
    End Sub

    Private Sub linkSaberMas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSaberMas.LinkClicked
        frmSobreElCliente.ShowDialog()
    End Sub

    Private Sub btnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        iniciarConsulta()
    End Sub

    Private Sub btnVerInforme_Click_1(sender As Object, e As EventArgs) Handles btnVerInforme.Click
        mensajeDeEsperaProcesoDeDiagnostico()
    End Sub

    Private Sub mensajeDeEsperaProcesoDeDiagnostico()
        lblPregunta.Text = VAguardaPreparamosInforme
        btnVerInforme.Visible = False
        Me.Refresh()
        crearInformeDiagnostico()
    End Sub

    Private Sub crearInformeDiagnostico()
        'Evalua resultado informe de diagnostico
        Try
            evaluarExitenciaPatologias(ControladorDiagnostico.CrearInformeDiagnostico(ListaSintomasSeleccionados, USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoErrorAccesoDatos)
        End Try

    End Sub

    Private Sub evaluarExitenciaPatologias(ByVal patologiasParaDiagnostico As DataTable)
        'Evalua si existen un diagnostico de acuerdo a los sintomas ingresados
        If patologiasParaDiagnostico.Rows.Count = 0 Then
            lblPregunta.Text = VNoExistenPatologias
            btnVerInforme.Visible = False
            btnNuevaConsulta.Visible = True
            btnIniciarChat.Visible = True
            Me.Refresh()
        Else
            mostrarInformeDiagnostico(patologiasParaDiagnostico)
        End If
    End Sub

    Private Sub mostrarInformeDiagnostico(ByRef patologiaParaDiagnostico As DataTable)
        'Muestra el informe de diagostico
        lblPregunta.Text = VHemosPreparadoInforme
        flPanelDiagnostico.Visible = True
        For Each patologias As DataRow In patologiaParaDiagnostico.Rows
            Dim panel As New PanelPatologia With {.nombre = patologias("nombre"), .descipcion = patologias("descripcion")}
            flPanelDiagnostico.Controls.Add(panel.CrearPanelPatologia)
        Next
        botonesMostrarDiagnostico()
    End Sub

    Private Sub botonesMostrarDiagnostico()
        btnVerInforme.Visible = False
        btnNuevaConsulta.Visible = True
        btnIniciarChat.Visible = True
    End Sub

    Private Sub clickBotonConsulta()
        PanelDeConsulta.Visible = True
        btnConsulta.Image = My.Resources.btnConsultaSelect
        btnChat.Image = My.Resources.btnChat
        btnHistoria.Image = My.Resources.btnReloj
        btnConsulta.ForeColor = Color.FromArgb(44, 55, 137)
        btnChat.ForeColor = Color.FromArgb(127, 127, 127)
        btnHistoria.ForeColor = Color.FromArgb(127, 127, 127)
    End Sub

    Private Sub clickBotonChat()
        btnChat.Image = My.Resources.btnChatSelect
        btnHistoria.Image = My.Resources.btnReloj
        btnConsulta.Image = My.Resources.btnConsulta
        btnChat.ForeColor = Color.FromArgb(44, 55, 137)
        btnConsulta.ForeColor = Color.FromArgb(127, 127, 127)
        btnHistoria.ForeColor = Color.FromArgb(127, 127, 127)
    End Sub

    Private Sub clickBotonHistoria()
        btnHistoria.Image = My.Resources.btnRelojSelect
        btnChat.Image = My.Resources.btnChat
        btnConsulta.Image = My.Resources.btnConsulta
        btnHistoria.ForeColor = Color.FromArgb(44, 55, 137)
        btnChat.ForeColor = Color.FromArgb(127, 127, 127)
        btnConsulta.ForeColor = Color.FromArgb(127, 127, 127)
    End Sub

    Private Sub iniciarConsulta()
        lblPregunta.Text = VCualEsTuPrincipalSintoma
        panelDeSintomas.Visible = True
        flPanelDiagnostico.Visible = False
        lblMensaje.Visible = False
        btnComenzar.Visible = False
        btnChat.Enabled = False
        lblPregunta.Visible = True
        btnSiguienteSintoma.Visible = True
        txtSintoma.Visible = True
        btnNuevaConsulta.Visible = False
        lblLine.Visible = True
        sintomaSeleccionado = False
        flPanelDiagnostico.Controls.Clear()
        PanelPatologia.id = 0
        txtSintoma.Select()
        ListaSintomasSeleccionados.Clear()
        PanelDeConsulta.Visible = True
        btnIniciarChat.Visible = False
        txtSintoma.Text = ""

    End Sub

    Private Sub btnIniciarChat_Click(sender As Object, e As EventArgs) Handles btnIniciarChat.Click
        limpiarVentanaDeMensajes()
        mostrarPanelDeChat()
        estadoBotonesAlIniciarchat()
        activarControladorTiempoEstado()
        ocultarInformacionDelMedico()
        guardarSesionDeChat()
        cargarformLoading()
    End Sub

    Private Sub ocultarInformacionDelMedico()
        panelInfoMedico.Visible = False
    End Sub

    Private Sub mostrarPanelDeChat()
        panelChat.Visible = True
        panelActivo = panelChat
        PanelDeConsulta.Visible = False
    End Sub

    Private Sub guardarSesionDeChat()
        'Guada la sesion de chat
        Try
            IDSESION = ControladorSesion.GuardarSesionDeChat(USUARIO, PASSWD)
        Catch ex As Exception
            MsgBox(VErrorGuardarSesionChat, vbCritical, VError)
        End Try
    End Sub

    Private Sub estadoBotonesAlIniciarchat()
        btnChat.Enabled = True
        btnChat.Select()
        btnNuevaConsulta.Visible = False
        btnIniciarChat.Visible = False
        clickBotonChat()
    End Sub

    Private Sub activarControladorTiempoEstado()
        TimerChequearEstado.Enabled = True
        TimerChequearEstado.Start()
    End Sub

    Private Sub desactivarControladorTiempoEstado()
        TimerChequearEstado.Enabled = False
        TimerChequearEstado.Stop()
    End Sub

    Private Sub cargarformLoading()
        frmLoading.ShowDialog()
    End Sub

    Private Sub TimerChequearEstado_Tick(sender As Object, e As EventArgs) Handles TimerChequearEstado.Tick
        'Chequea el estado de la sesion activa
        If estadoDeSesion() = 1 Then
            medicoInicioSesion()
            frmLoading.Dispose()
        ElseIf estadoDeSesion() = 3 Then
            medicoCanceloSesion()
        End If
    End Sub

    Private Function estadoDeSesion()
        'Verifica el estado de la sesion
        Try
            Return ControladorSesion.VerificarEstadoDeSesion(USUARIO, PASSWD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VErrorDatosAcceso)
        End Try
    End Function

    Private Sub medicoInicioSesion()
        establecerInicioDeChat()
    End Sub

    Private Sub medicoCanceloSesion()
        TimerChequearEstado.Enabled = False
        TimerChequearEstado.Stop()
        MsgBox(VElMedicoCerroSesin, vbExclamation, VAvisoCierreSesion)
        restablecerAPanelDeConsulta()
        frmLoading.Dispose()
    End Sub

    Private Sub establecerInicioDeChat()
        'Ajusta los controles para el inicio del chat
        lblEstado.Text = VOnline
        datosDelMedico()
        activarChat()
    End Sub

    Private Sub datosDelMedico()
        'Busca la informacion del medico que inicio la sesion
        Try
            mostrarDatosDelMedico(ControladorSesion.DatosDelMedicoSesion(USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoErrorAccesoDatos)
        End Try
    End Sub

    Private Sub mostrarDatosDelMedico(ByVal tablaDatosMedico As DataTable)
        'Muestra los datos del medico
        panelInfoMedico.Visible = True
        picMedico.Image = My.Resources.docMas
        lblNombreMedico.Text = tablaDatosMedico.Rows(0).Item("NOMBRE") & " " & tablaDatosMedico.Rows(0).Item("APELLIDO")
        IDMEDICO = tablaDatosMedico.Rows(0).Item("DOCUMENTO")
    End Sub

    Private Sub limpiarVentanaDeMensajes()
        txtMensajes.Clear()
        txtMensaje.Clear()
    End Sub

    Private Sub activarChat()
        tiempoMensaje.Enabled = True
        tiempoMensaje.Start()
    End Sub

    Private Sub btnEnviarMensaje_Click(sender As Object, e As EventArgs) Handles btnEnviarMensaje.Click
        'Verifica si hay mensaje 
        If txtMensaje.Text.Length > 0 Then
            enviarMensaje()
            limpiarCampoDeTexto()
        End If
    End Sub

    Private Sub enviarMensaje()
        'Envia el mensaje
        Try
            ControladorChat.EnviarMensajePaciente(txtMensaje.Text, ControladorDiagnostico.devolverIdSesion, USUARIO, PASSWD, IDMEDICO)
            identifiarColorearMensaje("P", txtMensaje.Text)
            recibirMensajes()
        Catch ex As Exception
            MsgBox(VErrorAlEnviarMensaje, vbCritical, VError)
        End Try
    End Sub

    Private Sub limpiarCampoDeTexto()
        'Limpia y selecciona el campo de texto
        txtMensaje.Text = ""
        txtMensaje.Select()
    End Sub

    Private Sub recibirMensajes()
        'Recupera los mensajes recibidos
        Try
            recorreMensajesRecibidos(ControladorChat.RecibirMensajes("P", USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VErrorDatosAcceso)
        End Try
    End Sub

    Private Sub recorreMensajesRecibidos(ByVal tablaMensajes As DataTable)
        'recorre los mensajes recividos
        For i = 0 To tablaMensajes.Rows.Count - 1
            identifiarColorearMensaje(tablaMensajes(i)("emisor"), tablaMensajes(i)("mensaje"))
            marcarMensajeLeido(tablaMensajes, i)
        Next
    End Sub

    Private Sub marcarMensajeLeido(ByVal tablaMensajes As DataTable, indice As Integer)
        'Marca el mensaje como leido
        Try
            ControladorChat.MarcarMensajeLeido(tablaMensajes.Rows(indice)("id"), USUARIO, PASSWD)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VErrorDatosAcceso)
        End Try
    End Sub

    Private Sub identifiarColorearMensaje(ByVal emisor As String, mensaje As String)
        'Muestra y colorea los mensajes dependiente de origen y destino
        If emisor.Equals("P") Then
            txtMensajes.SelectionColor = Color.FromArgb(110, 196, 167)
            txtMensajes.AppendText(Vtu & " ->  " & mensaje & vbNewLine)
        ElseIf emisor.Equals("M") Then
            txtMensajes.SelectionColor = Color.FromArgb(69, 75, 84)
            txtMensajes.AppendText(VDoctor & " -> " & mensaje & vbNewLine)
        End If
    End Sub

    Private Sub tiempoMensaje_Tick(sender As Object, e As EventArgs) Handles tiempoMensaje.Tick
        'Control que cheque nuevos mensajes cada 10 segundos
        recibirMensajes()
    End Sub

    Private Sub btnFinalizarChat_Click(sender As Object, e As EventArgs) Handles btnFinalizarChat.Click
        'Boton que finaliza la sesion de chat
        FinalizarSesionDechat()
    End Sub

    Public Sub FinalizarSesionDechat()
        'Proceso de cierre de sesion de chat
        Dim finalizar As Integer
        finalizar = MsgBox(VSeguroDeCerrarSesion, vbQuestion & vbYesNo, VAvisoCierreSesion)
        If finalizar = 6 Then
            cancelarSesionDeChat()
        End If
    End Sub

    Private Sub cancelarSesionDeChat()
        'Cancela la solicitud de chat
        Try
            ControladorSesion.CancelarSesionDeChat(USUARIO, PASSWD)
            restablecerAPanelDeConsulta()
        Catch ex As Exception
            MsgBox(VErrorCancelarChat, vbOK Or vbInformation, VAvisoCierreSesion)
        End Try
    End Sub

    Public Sub restablecerAPanelDeConsulta()
        cambiarPanel(PanelDeConsulta)
        PanelDeConsulta.Visible = False
        clickBotonConsulta()
        iniciarConsulta()
        TimerChequearEstado.Enabled = False
        TimerChequearEstado.Stop()
        tiempoMensaje.Enabled = False
        tiempoMensaje.Stop()
    End Sub

    Public Sub TraerDiagnosticos()
        'Recupera los diagnosticos recibidos por el paciente
        Try
            cargarFichaDiagnosticos(ControladorDiagnostico.TraerDiagnosticos(USUARIO, PASSWD, USUARIO))
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoErrorAccesoDatos)
        End Try
    End Sub

    Private Sub cargarFichaDiagnosticos(ByVal datos As DataTable)
        'Muestra los diagnosticos que ha recibido el paciente
        flpDiagnosticos.Controls.Clear()
        For Each diagnostico As DataRow In datos.Rows
            Dim d As New classFichaDiagnostico
            d.idDiagnostico = diagnostico("id").ToString
            d.fechaDiagnostico = diagnostico("fechahora").ToString
            d.Ponderacion = diagnostico("prioridad").ToString
            d.ListarPatologiasDelDiagnostico(cargarPatologiasDeDiagnostico(diagnostico("id").ToString))
            flpDiagnosticos.Controls.Add(d.crearFichaChat)
        Next
    End Sub

    Private Function cargarPatologiasDeDiagnostico(ByVal id As String)
        'Traer las patologias del diagnostico
        Try
            Return ControladorPatologias.ListarPatologiasPorDiagnostico(USUARIO, PASSWD, id)
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoErrorAccesoDatos)
        End Try
    End Function

    Public Sub TraerRegistroDeChat()
        'Trae la lista de chat historica del paciente
        flpChats.Controls.Clear()
        Try
            mostrarHistoricoDeChat(ControladorChat.ListaHistoricaChatPaciente(USUARIO, PASSWD, USUARIO))
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoErrorAccesoDatos)
        End Try
    End Sub

    Private Sub mostrarHistoricoDeChat(ByVal tablaChats As DataTable)
        For Each chats As DataRow In tablaChats.Rows
            Dim c As New classFichaChat
            c.Id = chats("sesion")
            c.Fecha = chats("FechaHora")
            c.DocNombre = chats("apellidos") & ", " & chats("nombres")
            flpChats.Controls.Add(c.crarFichaChat())
        Next
    End Sub

    Public Sub CargarDatosDePaciente()
        'Carga la informacion del paciente logeado
        Try
            cargarDatosPaciente(controladorPacientes.buscarPacientePorDocumento(USUARIO, USUARIO, PASSWD))
            CargarEnfermedadesDelPaciente()
            marcarIdioma()
        Catch ex As Exception
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoErrorAccesoDatos)
        End Try
    End Sub

    Private Sub cargarDatosPaciente(ByVal datos As DataTable)
        txtDocumento.Text = datos.Rows(0)("documento")
        txtFechaReg.Text = datos.Rows(0)("fechReg")
        txtNombres.Text = datos.Rows(0)("nombres")
        txtApellidos.Text = datos.Rows(0)("apellidos")
        txtDireccion.Text = datos.Rows(0)("calle")
        txtNumero.Text = datos.Rows(0)("numero")
        txtApto.Text = datos.Rows(0)("apto")
        txtEsquina.Text = datos.Rows(0)("esquina")
        txtBarrio.Text = datos.Rows(0)("barrio")
        txtEmail.Text = datos.Rows(0)("mail")
        cargarTelefonos(datos)
    End Sub

    Private Sub cargarTelefonos(ByVal datos As DataTable)
        'Recorre los telefonos del paciente
        flpTelefonos.Controls.Clear()
        For i = 0 To datos.Rows.Count - 1
            If datos(i).Item("telefono").ToString <> "" Then
                mostrarTelefono(datos(i).Item("telefono"))
            End If
        Next
    End Sub

    Private Sub mostrarTelefono(ByVal telefono As String)
        Dim t As New Label
        t.Text = telefono
        t.Padding = New Padding(2)
        t.BackColor = Color.FromArgb(69, 75, 84)
        t.ForeColor = Color.White
        t.TextAlign = ContentAlignment.MiddleCenter
        flpTelefonos.Controls.Add(t)
    End Sub

    Private Sub CargarEnfermedadesDelPaciente()
        'Carga las enfermedades del paciente
        Try
            recorrerEnfermadades(controladorPacientes.CargarEnfermedadesPreExistentes(USUARIO, USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(VErrorRecuperarDatos, vbCritical, VAvisoErrorAccesoDatos)
        End Try
    End Sub

    Private Sub recorrerEnfermadades(ByVal datos As DataTable)
        'Recorre las enfermedades
        For Each enfermedad As DataRow In datos.Rows
            mostrarEnfermedades(enfermedad("PREEXISTENTE"))
        Next
    End Sub

    Private Sub mostrarEnfermedades(ByVal enfermedad As String)
        'Muestra las enfermedades pre existentes
        Dim e As New Label
        e.Text = enfermedad
        e.TextAlign = ContentAlignment.MiddleCenter
        e.BackColor = Color.FromArgb(110, 196, 167)
        e.ForeColor = Color.White
        flpEnfermedades.Controls.Add(e)
    End Sub

    Private Sub marcarIdioma()
        'Marca el radio button correspondiente al idioma registrado
        If My.Settings.lenguaje.Equals("es") Then
            rbLangEs.Checked = True
        Else
            rbLangEn.Checked = True
        End If
    End Sub

    Private Sub confirmarCambioIdioma(ByVal idioma As String)
        Dim respuesta As Integer
        respuesta = MsgBox(VCambioRequiereReiniciar, vbQuestion + vbYesNo, VCambioDeIdioma)
        If respuesta = 6 Then
            My.Settings.lenguaje = idioma
            My.Settings.Save()
            End
        Else
            marcarIdioma()
        End If
    End Sub

    Private Sub rbLangEs_Click(sender As Object, e As EventArgs) Handles rbLangEs.Click
        If rbLangEs.Checked Then
            confirmarCambioIdioma("es")
        End If
    End Sub

    Private Sub rbLangEn_Click(sender As Object, e As EventArgs) Handles rbLangEn.Click
        If rbLangEn.Checked Then
            confirmarCambioIdioma("en")
        End If
    End Sub

    Private Sub llblEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblEmail.LinkClicked
        Dim para As String = EMAIL
        Dim subject As String = VDatosPersonales
        Process.Start(String.Format("mailto:{0}?subject={1}", para, subject))
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarIdioma()
        cargarTextos()
    End Sub

    Public Function NuevoMensaje() As String
        'Genera un numero aleatorio del 1 al 4 para luego mostrar mensajes diferentes.
        Dim Random As New Random()
        Dim numero As Integer = Random.Next(1, 4)
        Return mensaje(numero)
    End Function

    Private Function mensaje(id As Integer) As String
        Dim txtMensaje As String
        Select Case id
            Case 1
                txtMensaje = VSitienesOtroSintoma
            Case 2
                txtMensaje = VTienesOtroSintoma
            Case 3
                txtMensaje = VQueOtroSintomaTienes
            Case 4
                txtMensaje = VSientesOtroSintoma
            Case Else
                txtMensaje = "default"
        End Select
        Return txtMensaje
    End Function

    Private Sub cargarTextos()
        lblLeyenda.Text = VLeyendaInicial
        btnIniciarAutenticado.Text = VUsuarioRegistrado
        lblMensaje.Text = VMensajeInicial
        btnConsulta.Text = VConsulta
        btnChat.Text = VChat
        btnHistoria.Text = VHistoria
        btnComenzar.Text = VIniciarConsulta
        btnSiguienteSintoma.Text = VSiguiente
        linkSaberMas.Text = VsaberMas
        btnSi.Text = VSi
        btnNo.Text = VNo
        btnVerInforme.Text = VVerInforme
        btnNuevaConsulta.Text = VNuevaConsulta
        btnIniciarChat.Text = VIniciarChat
        lblEstadoChat.Text = VEstado.ToUpper
        lblEstado.Text = VEnEspera
        gbDatosPaciente.Text = VDatos
        lblDocumento.Text = VDocumentoIdentidad
        lblNombres.Text = VNombre
        lblApellidos.Text = VApellidos
        lblDireccion.Text = VDireccion
        lblNumero.Text = VNro
        lblApto.Text = VApto
        lblBarrio.Text = VBarrio
        lblEsquina.Text = VEsquina
        lblEmail.Text = VEmail
        lblFechaReg.Text = VFechaRegistro
        gbTelefonos.Text = VTelefonos
        gbPreexistentes.Text = VPatologiasPreExistentes
        gbIdioma.Text = VLenguaje
        rbLangEs.Text = VEspanol
        rbLangEn.Text = VIngles
        lblInfoContacto.Text = VComunicateConNosotros
        tabDiagnosticos.Text = VDiagnosticosRecibidos
        tabChats.Text = VHistoricoChat

    End Sub

    Private Sub confirmarCierre()
        Dim respuesta As Integer
        respuesta = MsgBox(VSeguroCerrarAplicacion, vbQuestion + vbYesNo, VAvisoConfirmacion)
        If respuesta = 6 Then
            mensajeDeCierre()
            End
        End If
    End Sub

    Private Sub mensajeDeCierre()
        Try
            ControladorChat.EnviarMensajePaciente(VElPacienteSalioDelChat, IDSESION, USUARIO, PASSWD, IDMEDICO)
        Catch ex As Exception
            MsgBox(VErrorAlEnviarMensaje, vbCritical, VError)
        End Try
    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If panelChat.Visible Then
            confirmarCierre()
        End If
    End Sub

    Private Sub panelCabecera_Paint(sender As Object, e As PaintEventArgs) Handles panelCabecera.Paint

    End Sub
End Class