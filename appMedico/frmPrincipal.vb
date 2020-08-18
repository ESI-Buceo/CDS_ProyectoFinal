Imports System.ComponentModel
Imports capaLogica

Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerificarNuevasSolicitudesDeChat()
        activarControlDeSesiones()
    End Sub

    Private Sub VerificarNuevasSolicitudesDeChat()
        'Cheque si existen mensajes pendientes o en espera
        Try
            cargarListaDeChatPendientes(ControladorSesion.ChequearSesionesPendientes(USUARIO, PASSWD))
            cargarListaChatEnEspera(ControladorSesion.chequearSesionesEnEspera(USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al chequear mensajes")
        End Try
    End Sub

    Private Sub activarControlDeSesiones()
        'Activa el control timer para verificar sesiones cada 10''
        timeChequearNuevasSesiones.Enabled = True
        timeChequearNuevasSesiones.Start()
    End Sub

    Private Sub cargarListaDeChatPendientes(ByVal tablaPendientes As DataTable)
        'Carga la lista de chat pendientes
        flpChatPendientes.Controls.Clear()
        For Each sesion As DataRow In tablaPendientes.Rows
            flpChatPendientes.Controls.Add(crearFichaSesiones(sesion))
        Next
    End Sub

    Private Sub cargarListaChatEnEspera(ByVal tablaEnEspera As DataTable)
        'Carga la lista de chat en espera
        flpChatenEspera.Controls.Clear()
        For Each sesion As DataRow In tablaEnEspera.Rows
            flpChatenEspera.Controls.Add(crearFichaSesiones(sesion))
        Next
    End Sub

    Private Function crearFichaSesiones(ByVal sesion As DataRow) As Panel
        'Genera una ficha para cada sesion del chat
        Dim ficha As New claseFichaChat
        ficha.IdChat = sesion("SESION").ToString
        ficha.Foto = "vacia"
        ficha.Nombre = sesion("NOMBRES").ToString & " " & sesion("APELLIDOS").ToString
        ficha.Mensaje = "Chat activo"
        ficha.Ponderacion = sesion("PRIORIDAD")
        ficha.Minutos = Format(CDate(sesion("HORA")), "HH:mm")
        ficha.IdPaciente = sesion("DOC").ToString
        ficha.estado = sesion("ESTADO").ToString
        Return ficha.crearFichaChat()
    End Function

    Public Sub cargarDatosDelPaciente()
        'Trae los datos del paciente
        Try
            mostrarDatosDelPaciente(ControladorChat.DatosPaciente(IDSESION, USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox("Error al traer los datos del paciente", vbCritical, "Error")
        End Try

    End Sub

    Private Sub mostrarDatosDelPaciente(ByVal tablaDatosPaciente As DataTable)
        'Muestra los datos del paciente
        mostrarControlesDatosDePacientes()
        lblNombrePaciente.Text = tablaDatosPaciente.Rows(0).Item("NOMBRE").ToString & " " & tablaDatosPaciente.Rows(0).Item("APELLIDO").ToString
        lblEmailPaciente.Text = tablaDatosPaciente.Rows(0).Item("EMAIL").ToString
        txtNombrePaciente.Text = tablaDatosPaciente.Rows(0).Item("NOMBRE").ToString
        txtApellidosPaciente.Text = tablaDatosPaciente(0).Item("APELLIDO").ToString
        txtDocIdentidadPaciente.Text = tablaDatosPaciente(0).Item("DOC").ToString
        txtFechaNacPaciente.Text = Format(tablaDatosPaciente(0).Item("FECHANAC"), "dd/MM/yyyy").ToString
        txtCallePaciente.Text = tablaDatosPaciente(0).Item("CALLE").ToString
        txtCalleNumeroPaciente.Text = tablaDatosPaciente(0).Item("NUM").ToString
        txtCalleApto.Text = tablaDatosPaciente(0).Item("APTO").ToString
        txtBarrioPaciente.Text = tablaDatosPaciente(0).Item("BARRIO").ToString
        txtEsquinaPaciente.Text = tablaDatosPaciente(0).Item("ESQUINA").ToString
        txtFechaRegistro.Text = Format(tablaDatosPaciente(0).Item("FECHREGISTRO"), "dd/MM/yyyy HH:mm:ss").ToString
        mostrarSintomasDelPaciente()
        verificarEnfermedadesPreExistentes(tablaDatosPaciente(0).Item("DOC").ToString)
        evaluarPanelAMostrar()
        controlarEstadoDeSesion()
    End Sub

    Private Sub controlarEstadoDeSesion()
        'Habilita el timer que controla el estado de la sesion
        timeEstadoDeSesion.Enabled = True
        timeEstadoDeSesion.Start()
    End Sub

    Private Sub DeshabilitarControlDeEstadoDeSesion()
        'Deshabilita el timer que controla el estado de la sesion
        timeEstadoDeSesion.Enabled = False
        timeEstadoDeSesion.Stop()
    End Sub
    Private Sub evaluarPanelAMostrar()
        'Evalua el panel que se encuentra activo para definir los datos a mostrar
        If tsmBtnVerChat.Enabled Then
            panelMensajes.Visible = False
            panelDatosPaciente.Visible = True
            verDatosPaciente()
        ElseIf tsmBtnVerPaciente.Enabled Then
            panelMensajes.Visible = True
            panelDatosPaciente.Visible = False
            verFichaChat()
        End If
    End Sub

    Private Sub verificarEnfermedadesPreExistentes(ByVal docIdentidad As String)
        'Carga las enfermedades preexistentes del paciente
        Try
            mostrarEnfermedadesPreExistentes(controladorPacientes.CargarEnfermedadesPreExistentes(docIdentidad, USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox("Error al cargar enfermedades pre Existentes!")
        End Try
    End Sub

    Private Sub mostrarEnfermedadesPreExistentes(ByVal tablaPreExistentes As DataTable)
        'Muestra las enfermedades pre existentes
        flpPreExistentes.Controls.Clear()
        For Each preExistentes In tablaPreExistentes.Rows
            flpPreExistentes.Controls.Add(crearFichaDeEnfermedadPreExistente(preExistentes))
        Next
    End Sub

    Private Function crearFichaDeEnfermedadPreExistente(ByVal preExistente As DataRow)
        'Muestra las enfermedades pre existentes del paciente cargadas
        Dim etiqueta As New Label
        etiqueta.Text = preExistente("PREEXISTENTE").ToString
        etiqueta.ForeColor = Color.White
        etiqueta.Padding = New Padding(2)
        etiqueta.BackColor = Color.FromArgb(110, 196, 167)
        Return etiqueta
    End Function

    Private Sub mostrarControlesDatosDePacientes()
        'Muestra la cabecera del chat 
        panelCabeceraChatActivo.Visible = True
    End Sub

    Private Sub ocultarControlesDatosDePacientes()
        'Oculta la cabecera del chat
        panelCabeceraChatActivo.Visible = False
    End Sub

    Private Sub mostrarSintomasDelPaciente()
        'Verificar sintomas ingresados por el paciente
        Try
            recorrerSintomasPaciente(MostrarSintomasPaciente(IDSESION, USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox("No se pudieron cargar los sintomas del paciente !")
        End Try
    End Sub

    Private Sub recorrerSintomasPaciente(ByVal tablaSintomasPaciente As DataTable)
        'Recorre los sintomas que ingreso el paciente
        flpSintomas.Controls.Clear()
        For Each sintoma In tablaSintomasPaciente.Rows
            mostrarDatossintoma(sintoma)
        Next
    End Sub

    Private Sub mostrarDatossintoma(ByVal sintoma As DataRow)
        'crea la ficha de cada sintoma
        Dim s As New claseTabSintoma
        s.Nombresintoma = sintoma("NOMBRE")
        flpSintomas.Controls.Add(s.FichaSintoma)
    End Sub

    Public Sub recibirMensajes()
        'Trae los mensajes recibidos
        Try
            recorreMensajesRecibidos(ControladorChat.RecibirMensajes(IDSESION, "M", USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al cargar los mensajes recibidos")
        End Try
    End Sub

    Sub recibirTodosLosMensajes()
        'Trae los mensajes recibidos
        Try
            recorreMensajesRecibidos(ControladorChat.RecibirTodosMensajes(IDSESION, USUARIO, PASSWD))
        Catch ex As Exception
            MsgBox("Error al cargar los mensajes recibidos")
        End Try
    End Sub

    Private Sub recorreMensajesRecibidos(ByVal tablaMensajes As DataTable)
        'Identifica los destinatario
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
            MsgBox("Error al intentar marcar mensaje", vbInformation, "Error")
        End Try
    End Sub

    Private Sub btnEnviarMensaje_Click(sender As Object, e As EventArgs) Handles btnEnviarMensaje.Click
        'Valida si hay mensaje para enviar
        If txtMensaje.Text.Length > 0 Then
            enviarMensaje()
        End If
    End Sub

    Private Sub enviarMensaje()
        'Envia el mensaje
        Try
            ControladorChat.EnviarMensajeMedico(txtMensaje.Text, IDSESION, USUARIO, PASSWD, IDPACIENTE)
            identifiarColorearMensaje("M", txtMensaje.Text)
            limpiarCampoDeTexto()
            recibirMensajes()
            ChequearMensajesRecibidos()
        Catch ex As Exception
            MsgBox("Error al enviar el mensaje", vbCritical, "Error")
        End Try
    End Sub

    Private Sub limpiarCampoDeTexto()
        'limpia el campo de texto que envia mensje
        txtMensaje.Text = ""
    End Sub

    Private Sub identifiarColorearMensaje(ByVal emisor As String, mensaje As String)
        'colorea el mensaje segun el emisor
        If emisor.Equals("P") Then
            txtMensajes.SelectionColor = Color.FromArgb(92, 160, 136)
            txtMensajes.AppendText("Paciente ->  " & mensaje & vbNewLine)
        ElseIf emisor.Equals("M") Then
            txtMensajes.SelectionColor = Color.FromArgb(69, 75, 84)
            txtMensajes.AppendText("Tu -> " & mensaje & vbNewLine)
        End If
    End Sub

    Public Sub ChequearMensajesRecibidos()
        'Activa el timer que controla los mensajes nuevos
        timerChkMensajes.Enabled = True
        timerChkMensajes.Start()
    End Sub

    Private Sub timerChkMensajes_Tick(sender As Object, e As EventArgs) Handles timerChkMensajes.Tick
        'Control timer que verifca nuevos mensajes
        recibirMensajes()
    End Sub

    Private Sub timeChequearNuevasSesiones_Tick(sender As Object, e As EventArgs) Handles timeChequearNuevasSesiones.Tick
        'Verifica las nuevas solicitudes de chat
        VerificarNuevasSolicitudesDeChat()
    End Sub

    Private Sub tsmBtnVerChat_Click(sender As Object, e As EventArgs) Handles tsmBtnVerChat.Click
        'Muestra el panel de chat
        panelMensajes.Visible = True
        panelDatosPaciente.Visible = False
        verFichaChat()
    End Sub

    Private Sub tsmBtnVerPaciente_Click(sender As Object, e As EventArgs) Handles tsmBtnVerPaciente.Click
        'Muestra el panel de datos del paciente
        panelMensajes.Visible = False
        panelDatosPaciente.Visible = False
        verDatosPaciente()
    End Sub

    Private Sub tsmBtnPonerEspera_Click(sender As Object, e As EventArgs) Handles tsmBtnPonerEspera.Click
        'Pone en espera un chat
        enviarChatAEspera()
        ocultarControlesDatosDePacientes()
        OcultarPanelMensajes()
        OcultarPanelDatosPaciente()
        HabilitarPanelPendientes()
        HabilitarPanelEnEspera()
        restablecerVentanaChat()
        chequearSesionEnEspera()
    End Sub

    Private Sub enviarChatAEspera()
        'Registra el estado del chat en espera
        Try
            ControladorChat.EnviarChatAEspera(IDSESION, USUARIO, PASSWD)
        Catch ex As Exception
            MsgBox("Error al enviar el chat a espera", vbCritical, "Error")
        End Try

    End Sub

    Private Sub chequearSesionEnEspera()
        'Verifica las sesiones en espera
        Try
            ControladorSesion.chequearSesionesEnEspera(USUARIO, PASSWD)
        Catch ex As Exception
            MsgBox("Error al verificar sesiones en espera", vbCritical, "Error")
        End Try
    End Sub

    Public Sub OcultarPanelDatosPaciente()
        'Oculta el panel de datos del paciente
        panelDatosPaciente.Visible = False
    End Sub

    Public Sub MostrarPanelDatosPaciente()
        'Muestra el panel de datos del paciente
        panelDatosPaciente.Visible = True
    End Sub

    Public Sub OcultarPanelMensajes()
        'Oculta el panel de mensjes del chat
        panelOpcionesChat.Visible = False
    End Sub

    Public Sub MostrarPanelMensajes()
        'Muestra el panel de mensjes del chat
        panelOpcionesChat.Visible = True
    End Sub

    Public Sub HabilitarPanelPendientes()
        'Habilita el panel de pendientes para poder seleccionar otro
        flpChatPendientes.Enabled = True
    End Sub

    Public Sub DeshabilitarPanelPendientes()
        'Deshabilita el panel de pendientes mientras tiene un chat abierto
        flpChatPendientes.Enabled = False
    End Sub

    Public Sub DeshabilitarPanelEnEspera()
        'Deshabilita el panel de pendientes mientras esta con un chat abierto
        flpChatenEspera.Enabled = False
    End Sub

    Public Sub HabilitarPanelEnEspera()
        'Habilita el panel de pendientes para selecciona una sesion
        flpChatenEspera.Enabled = True
    End Sub

    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Si hay chat abiertos no se puede cerrar la aplicacion
        If validarCierreDeLaAplicacion() = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub tsmBtnFinalizarChat_Click(sender As Object, e As EventArgs) Handles tsmBtnFinalizarChat.Click
        'Antes de finalizar el chat guarda en el estado de la sesion
        Dim respuesta As Integer
        respuesta = MsgBox("Estas seguro de finalizar el chat?", vbQuestion & vbYesNo, "Fianlizar Chat")
        If respuesta = 6 Then
            finalizarSesionDeChat()
        End If
    End Sub

    Private Sub finalizarSesionDeChat()
        'Pide confirmacion de cierre del chat
        Try
            ControladorSesion.GuardarEstadoSesion(IDSESION, USUARIO, PASSWD)
            confirmarEnvioDeEmailDeChat()
            restablecerVentanaChat()
        Catch ex As Exception
            MsgBox("Error al registrar el cierre del chat")
        End Try
    End Sub

    Private Sub confirmarEnvioDeEmailDeChat()
        'Consulta sobre el envio del email al usuario
        Dim respuesta As Integer
        respuesta = MsgBox("Desea enviar ua copia del chat al email del paciente?", vbYesNo, "AVISO ANTES DE CIERRE")
        If respuesta = 6 Then
            MsgBox("Enviar Email")
        End If
    End Sub

    Private Sub restablecerVentanaChat()
        'Restablece la ventana de chat
        panelCabeceraChatActivo.Visible = False
        panelOpcionesChat.Visible = False
        panelChatActivo.Visible = True
        flpChatPendientes.Enabled = True
        flpChatenEspera.Enabled = True
    End Sub

    Private Sub verFichaChat()
        'Muestra la ventana de chat
        tsmBtnVerPaciente.Enabled = True
        tsmBtnVerChat.Enabled = False
        panelDatosPaciente.Visible = False
        panelChatActivo.Visible = True
    End Sub

    Private Sub verDatosPaciente()
        'Muestra la ventana con los datos del paciente
        tsmBtnVerPaciente.Enabled = False
        tsmBtnVerChat.Enabled = True
        panelDatosPaciente.Visible = True
        panelChatActivo.Visible = False
    End Sub

    Private Sub frmPrincipal_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        'Finaliza la aplicacion
        End
    End Sub

    Private Sub timeEstadoDeSesion_Tick(sender As Object, e As EventArgs) Handles timeEstadoDeSesion.Tick
        'Control que verifica el estado de la sesion activa
        Try
            informarEstadoDeSesion(ControladorSesion.VerificarEstadoDeSesion(IDSESION, USUARIO, PASSWD))
        Catch ex As Exception
            timeEstadoDeSesion.Enabled = False
            timeEstadoDeSesion.Stop()
            MsgBox(ex.Message)
            MsgBox("Error al verificar el estado de la sesion", vbCritical, "Error")
        End Try

    End Sub

    Private Sub informarEstadoDeSesion(ByVal estado As String)
        'Si la sesion fue cerrada por el paciente, advierte al medico
        If estado = "4" Then
            DeshabilitarControlDeEstadoDeSesion()
            MsgBox("El paciente ha cerrado la sesion de chat", vbInformation, "Aviso")
            txtMensaje.Enabled = False
        End If
    End Sub

    Private Sub tsmCerrarSesion_Click(sender As Object, e As EventArgs) Handles tsmCerrarSesion.Click
        'Cierre la sesion y permite inicar una nueva
        If validarCierreDeLaAplicacion() Then
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub tsmSalir_Click(sender As Object, e As EventArgs) Handles tsmSalir.Click
        'Otra opcion para salir de la app
        If validarCierreDeLaAplicacion() Then
            End
        End If
    End Sub

    Private Function validarCierreDeLaAplicacion()
        'Verifica si no hay chat abiertos para poder cerrar la app
        If panelCabeceraChatActivo.Visible Then
            MsgBox("No puede cerrar la aplicacion si existe un chat en proceso !", vbInformation & vbOK, "ALERTA DE CIERRE")
            Return False
        End If
        Return True
    End Function
End Class
