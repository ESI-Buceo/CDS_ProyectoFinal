Imports System.ComponentModel
Imports capaLogica

Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMensajesEnElChat()
        activarControlDeSesiones()
    End Sub

    Private Sub cargarMensajesEnElChat()
        'Cheque si existen mensajes pendientes o en espera
        Try
            cargarListaDeChatPendientes(ControladorSesion.chequearSesionesPendientes())
            cargarListaChatEnEspera(ControladorSesion.chequearSesionesEnEspera(USUARIO))
        Catch ex As Exception
            MsgBox("Error al chequear mensajes")
        End Try
    End Sub

    Private Sub activarControlDeSesiones()
        'Activa el control timer para verificar sesiones cada 10''
        timeChequearSesion.Enabled = True
        timeChequearSesion.Start()
    End Sub

    Private Sub cargarListaDeChatPendientes(ByVal tablaPendientes As DataTable)
        'Carga la lista de chat pendientes
        For Each sesion As DataRow In tablaPendientes.Rows
            flpChatPendientes.Controls.Add(crearFichaSesiones(sesion))
        Next
    End Sub

    Private Sub cargarListaChatEnEspera(ByVal tablaEnEspera As DataTable)
        'Carga la lista de chat en espera
        For Each sesion As DataRow In tablaEnEspera.Rows
            flpChatenEspera.Controls.Add(crearFichaSesiones(sesion))
        Next
    End Sub

    Private Function crearFichaSesiones(ByVal sesion As DataRow) As Panel
        'Genera una ficha para cada sesion del chat
        Dim ficha As New claseFichaChat
        ficha.idChat = sesion("SESION").ToString
        ficha.Foto = "vacia"
        ficha.Nombre = sesion("NOMBRES").ToString & sesion("APELLIDOS").ToString
        ficha.Mensaje = "Chat activo"
        ficha.Ponderacion = sesion("PRIORIDAD")
        ficha.Minutos = Format(CDate(sesion("HORA")), "HH:mm")
        Return ficha.crearFichaChat()
    End Function

    Public Sub cargarDatosDelPaciente()
        'Trae los datos del paciente
        mostrarDatosDelPaciente(DatosPaciente(IDSESION))
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
            mostrarEnfermedadesPreExistentes(CargarEnfermedadesPreExistentes(docIdentidad))
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
            recorrerSintomasPaciente(MostrarSintomasPaciente(IDSESION))
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

    Private Sub recibirMensajes()
        'Trae los mensajes recibidos
        Try
            diferenciarOrigenDeLosMensaje(ControladorChat.RecibirMensajes(IDSESION))
        Catch ex As Exception
            MsgBox("Error al cargar los mensajes recibidos")
        End Try
    End Sub

    Private Sub diferenciarOrigenDeLosMensaje(ByVal tablaMensajes As DataTable)
        'Identifica los destinatario
        txtMensajes.Clear()
        For Each mensaje In tablaMensajes.Rows
            identifiarColorearMensaje(mensaje("emisor"), mensaje("mensaje"))
        Next
    End Sub

    Private Sub btnEnviarMensaje_Click(sender As Object, e As EventArgs) Handles btnEnviarMensaje.Click
        'Envia un mensaje
        If txtMensaje.Text.Length > 0 Then
            Try
                ControladorChat.EnviarMensaje(txtMensaje.Text, "M", IDSESION)
                txtMensaje.Text = ""
                recibirMensajes()
                chequearMensajesRecibidos()
            Catch ex As Exception
                MsgBox("Error al enviar el mensaje")
            End Try
        End If
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

    Private Sub chequearMensajesRecibidos()
        timerChkMensajes.Enabled = True
        timerChkMensajes.Start()
    End Sub

    Private Sub timerChkMensajes_Tick(sender As Object, e As EventArgs) Handles timerChkMensajes.Tick
        recibirMensajes()
    End Sub

    Private Sub timeChequearSesion_Tick(sender As Object, e As EventArgs) Handles timeChequearSesion.Tick
        cargarMensajesEnElChat()
    End Sub

    Private Sub tsmBtnVerChat_Click(sender As Object, e As EventArgs) Handles tsmBtnVerChat.Click
        panelMensajes.Visible = True
        panelDatosPaciente.Visible = False
        verFichaChat()
    End Sub

    Private Sub tsmBtnVerPaciente_Click(sender As Object, e As EventArgs) Handles tsmBtnVerPaciente.Click
        panelMensajes.Visible = False
        panelDatosPaciente.Visible = False
        verDatosPaciente()
    End Sub

    Private Sub tsmBtnPonerEspera_Click(sender As Object, e As EventArgs) Handles tsmBtnPonerEspera.Click
        ControladorChat.EnviarChatAEspera(IDSESION)
        ocultarControlesDatosDePacientes()
        OcultarPanelMensajes()
        OcultarPanelDatosPaciente()
        HabilitarPanelPendientes()
        chequearSesionesEnEspera()
    End Sub

    Public Sub OcultarPanelDatosPaciente()
        panelDatosPaciente.Visible = False
    End Sub

    Public Sub MostrarPanelDatosPaciente()
        panelDatosPaciente.Visible = True
    End Sub


    Public Sub OcultarPanelMensajes()
        panelOpcionesChat.Visible = False
    End Sub

    Public Sub MostrarPanelMensajes()
        panelOpcionesChat.Visible = True
    End Sub

    Public Sub HabilitarPanelPendientes()
        flpChatPendientes.Enabled = True
    End Sub

    Public Sub DeshabilitarPanelPendientes()
        flpChatPendientes.Enabled = False
    End Sub


    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If panelCabeceraChatActivo.Visible Then
            MsgBox("No puede cerrar la aplicacion si existe un chat en proceso !", vbInformation & vbOK, "ALERTA DE CIERRE")
            e.Cancel = True
        End If
    End Sub

    Private Sub tsmBtnFinalizarChat_Click(sender As Object, e As EventArgs) Handles tsmBtnFinalizarChat.Click
        'Antes de finalizar el chat guarda en el estado de la sesion
        ControladorSesion.GuardarEstadoSesion(IDSESION)
        confirmarEnvioDeEmailDeChat()
        restablecerVentanaChat()
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
        panelCabeceraChatActivo.Visible = False
        panelOpcionesChat.Visible = False
        flpChatPendientes.Enabled = True
    End Sub

    Private Sub verFichaChat()
        tsmBtnVerPaciente.Enabled = True
        tsmBtnVerChat.Enabled = False
        panelDatosPaciente.Visible = False
        panelChatActivo.Visible = True
    End Sub

    Private Sub verDatosPaciente()
        tsmBtnVerPaciente.Enabled = False
        tsmBtnVerChat.Enabled = True
        panelDatosPaciente.Visible = True
        panelChatActivo.Visible = False
    End Sub

End Class
