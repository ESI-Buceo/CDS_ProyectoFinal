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

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnHistoria_Click(sender As Object, e As EventArgs) Handles btnHistoria.Click
        cambiarPanel(PanelDeConsulta)
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
        If ListaSintomasSeleccionados.Count > 1 Then
            lblPregunta.Text = "Deseas ingresar un nuevo sintoma?"
            preguntarPorNuevoSintoma()
        Else
            nuevaPregunta()
        End If
    End Sub

    Private Sub nuevaPregunta()
        lblPregunta.Text = ControladorDiagnostico.NuevoMensaje()
        txtSintoma.Select()
        sintomaSeleccionado = False
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        lblPregunta.Width = 370
        lblPregunta.Height = 200
        lblPregunta.AutoSize = False
        lblPregunta.Text = "Presiona Ver Informe para que podamos generarte un diagnostico de acuerdo a los sintomas que has ingresado. No dejes de consultara tu medico via chat, recuerda que este diagnostico no sustituye la consulta a un profesional."
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
        lblPregunta.Text = "Aguarda mientras preparamos tu informe..."
        btnVerInforme.Visible = False
        Me.Refresh()
        crearInformeDiagnostico()
    End Sub

    Private Sub crearInformeDiagnostico()
        'Evalua resultado informe de diagnostico
        Try
            evaluarExitenciaPatologias(ControladorDiagnostico.CrearInformeDiagnostico(ListaSintomasSeleccionados, USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox("Error al buscar las patologias", vbOK Or vbInformation, "Error")
        End Try

    End Sub

    Private Sub evaluarExitenciaPatologias(ByVal patologiasParaDiagnostico As DataTable)
        'Evalua si existen patologias
        If patologiasParaDiagnostico.Rows.Count = 0 Then
            lblPregunta.Text = "No existen patologias con los sintomas que has ingresado !"
            btnVerInforme.Visible = False
            btnNuevaConsulta.Visible = True
            Me.Refresh()
        Else
            mostrarInformeDiagnostico(patologiasParaDiagnostico)
        End If
    End Sub

    Private Sub mostrarInformeDiagnostico(ByRef patologiaParaDiagnostico As DataTable)
        'Muestra el informe de diagostico
        lblPregunta.Text = "Hemos preparado el siguiente informe para ti de acuerdo a los sintomas que has ingresado. Por favor inicia una conversacion por chat con el medico."
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
        lblPregunta.Text = "Cuentanos cual es tu princial sintoma...?"
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
            ControladorSesion.GuardarSesionDeChat(USUARIO, PASSWD)
        Catch ex As Exception
            MsgBox("Error al guardar la sesion de chat", vbInformation, "Error")
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
            MsgBox("Error al conectarse al servidor de chat", vbOK Or vbInformation, "Error")
        End Try
    End Function


    Private Sub medicoInicioSesion()
        establecerInicioDeChat()
    End Sub

    Private Sub medicoCanceloSesion()
        MsgBox("El Medico finalizo la sesion de chat", vbExclamation, "Cierre de Sesion")
        TimerChequearEstado.Enabled = False
        TimerChequearEstado.Stop()
        restablecerAPanelDeConsulta()
        frmLoading.Dispose()
    End Sub

    Private Sub establecerInicioDeChat()
        'Ajusta los controles para el inicio del chat
        lblEstado.Text = "On Line"
        datosDelMedico()
        activarChat()
    End Sub

    Private Sub datosDelMedico()
        'Busca la informacion del medico que inicio la sesion
        Try
            mostrarDatosDelMedico(ControladorSesion.DatosDelMedicoSesion(USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox("Error al recuperar datos del medico", vbOK Or vbInformation, "Error")
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
    End Sub

    Private Sub activarChat()
        tiempoMensaje.Enabled = True
        tiempoMensaje.Start()
    End Sub

    Private Sub enviarMensaje()
        'Envia el mensaje
        Try
            ControladorChat.EnviarMensajePaciente(txtMensaje.Text, ControladorDiagnostico.devolverIdSesion, USUARIO, PASSWD, IDMEDICO)
            identifiarColorearMensaje("P", txtMensaje.Text)
            recibirMensajes()
        Catch ex As Exception
            MsgBox("Hubo un error al enviar el mensaje, intenta nuevamente", vbOK Or vbInformation, "Error")
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
            MsgBox("Error al leer los mensajes recibidos", vbOK Or vbInformation, "Error")
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
            MsgBox("Error al marcar el mensaje", vbInformation, "Error")
        End Try
    End Sub

    Private Sub identifiarColorearMensaje(ByVal emisor As String, mensaje As String)
        'Muestra y colorea los mensajes dependiente de origen y destino
        If emisor.Equals("P") Then
            txtMensajes.SelectionColor = Color.FromArgb(110, 196, 167)
            txtMensajes.AppendText("Tu ->  " & mensaje & vbNewLine)
        ElseIf emisor.Equals("M") Then
            txtMensajes.SelectionColor = Color.FromArgb(69, 75, 84)
            txtMensajes.AppendText("Doctor -> " & mensaje & vbNewLine)
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
        finalizar = MsgBox("Seguro de cerrar la sesion de chat? ", vbYesNo Or vbExclamation, "Cerrar Sesion")
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
            MsgBox("Error al intentar cancelar cerrar la sesion de chat", vbOK Or vbInformation, "Cierre de Sesion")
        End Try
    End Sub

    Public Sub restablecerAPanelDeConsulta()
        cambiarPanel(PanelDeConsulta)
        PanelDeConsulta.Visible = False
        clickBotonConsulta()
        iniciarConsulta()
        TimerChequearEstado.Enabled = False
        TimerChequearEstado.Stop()
    End Sub

    Private Sub btnEnviarMensaje_Click(sender As Object, e As EventArgs) Handles btnEnviarMensaje.Click
        'Verifica si hay mensaje 
        If txtMensaje.Text.Length > 0 Then
            enviarMensaje()
            limpiarCampoDeTexto()
        End If
    End Sub
End Class