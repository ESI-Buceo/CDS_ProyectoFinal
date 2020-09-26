<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.PanelMedico = New System.Windows.Forms.Panel()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.picEstado = New System.Windows.Forms.PictureBox()
        Me.lblNombreMedico = New System.Windows.Forms.Label()
        Me.picFotoMedico = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mtsMenuPrincipal = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCambiarIdioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiEspanol = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiIngles = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.flpChatPendientes = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblChatVacio = New System.Windows.Forms.Label()
        Me.flpChatenEspera = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblEspera = New System.Windows.Forms.Label()
        Me.panelCabeceraChatActivo = New System.Windows.Forms.Panel()
        Me.lblSintomasIngresadosConsulta = New System.Windows.Forms.Label()
        Me.flpSintomas = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblEmailPaciente = New System.Windows.Forms.Label()
        Me.lblNombrePaciente = New System.Windows.Forms.Label()
        Me.picAvatarPaciente = New System.Windows.Forms.PictureBox()
        Me.panelOpcionesChat = New System.Windows.Forms.Panel()
        Me.panelMensajes = New System.Windows.Forms.Panel()
        Me.txtMensajes = New System.Windows.Forms.RichTextBox()
        Me.btnEnviarMensaje = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.mnuChat = New System.Windows.Forms.MenuStrip()
        Me.tsmBtnVerChat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmBtnVerPaciente = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmBtnPonerEspera = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmBtnFinalizarChat = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelChatActivo = New System.Windows.Forms.Panel()
        Me.timerChkMensajes = New System.Windows.Forms.Timer(Me.components)
        Me.timeChequearNuevasSesiones = New System.Windows.Forms.Timer(Me.components)
        Me.panelDatosPaciente = New System.Windows.Forms.Panel()
        Me.flpPreExistentes = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblPreExistentes = New System.Windows.Forms.Label()
        Me.txtFechaRegistro = New System.Windows.Forms.TextBox()
        Me.txtEsquinaPaciente = New System.Windows.Forms.TextBox()
        Me.txtBarrioPaciente = New System.Windows.Forms.TextBox()
        Me.txtCalleApto = New System.Windows.Forms.TextBox()
        Me.txtCalleNumeroPaciente = New System.Windows.Forms.TextBox()
        Me.txtCallePaciente = New System.Windows.Forms.TextBox()
        Me.txtFechaNacPaciente = New System.Windows.Forms.TextBox()
        Me.txtDocIdentidadPaciente = New System.Windows.Forms.TextBox()
        Me.txtApellidosPaciente = New System.Windows.Forms.TextBox()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.lblfechaRegistro = New System.Windows.Forms.Label()
        Me.lblApto = New System.Windows.Forms.Label()
        Me.lblEsquina = New System.Windows.Forms.Label()
        Me.lblBarrio = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblDocIdentidad = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.timeEstadoDeSesion = New System.Windows.Forms.Timer(Me.components)
        Me.ttMensajePonderacion = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelMedico.SuspendLayout()
        CType(Me.picEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFotoMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.flpChatPendientes.SuspendLayout()
        Me.panelCabeceraChatActivo.SuspendLayout()
        CType(Me.picAvatarPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOpcionesChat.SuspendLayout()
        Me.panelMensajes.SuspendLayout()
        Me.mnuChat.SuspendLayout()
        Me.panelDatosPaciente.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMedico
        '
        Me.PanelMedico.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PanelMedico.Controls.Add(Me.lblEstado)
        Me.PanelMedico.Controls.Add(Me.picEstado)
        Me.PanelMedico.Controls.Add(Me.lblNombreMedico)
        Me.PanelMedico.Controls.Add(Me.picFotoMedico)
        Me.PanelMedico.Controls.Add(Me.MenuStrip1)
        Me.PanelMedico.Location = New System.Drawing.Point(0, 3)
        Me.PanelMedico.Name = "PanelMedico"
        Me.PanelMedico.Size = New System.Drawing.Size(371, 100)
        Me.PanelMedico.TabIndex = 0
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblEstado.Location = New System.Drawing.Point(108, 50)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(54, 17)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "OnLine"
        '
        'picEstado
        '
        Me.picEstado.Image = Global.appMedico.My.Resources.Resources.online
        Me.picEstado.Location = New System.Drawing.Point(83, 50)
        Me.picEstado.Name = "picEstado"
        Me.picEstado.Size = New System.Drawing.Size(20, 20)
        Me.picEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEstado.TabIndex = 2
        Me.picEstado.TabStop = False
        '
        'lblNombreMedico
        '
        Me.lblNombreMedico.AutoSize = True
        Me.lblNombreMedico.ForeColor = System.Drawing.Color.White
        Me.lblNombreMedico.Location = New System.Drawing.Point(80, 23)
        Me.lblNombreMedico.Name = "lblNombreMedico"
        Me.lblNombreMedico.Size = New System.Drawing.Size(138, 18)
        Me.lblNombreMedico.TabIndex = 1
        Me.lblNombreMedico.Text = "Nombre del medico"
        '
        'picFotoMedico
        '
        Me.picFotoMedico.Image = Global.appMedico.My.Resources.Resources.docMas
        Me.picFotoMedico.Location = New System.Drawing.Point(22, 23)
        Me.picFotoMedico.Name = "picFotoMedico"
        Me.picFotoMedico.Size = New System.Drawing.Size(50, 50)
        Me.picFotoMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFotoMedico.TabIndex = 0
        Me.picFotoMedico.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsMenuPrincipal})
        Me.MenuStrip1.Location = New System.Drawing.Point(331, 2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(40, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mtsMenuPrincipal
        '
        Me.mtsMenuPrincipal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mtsMenuPrincipal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCambiarIdioma, Me.tsmCerrarSesion, Me.ToolStripSeparator2, Me.tsmSalir})
        Me.mtsMenuPrincipal.Image = Global.appMedico.My.Resources.Resources.menu
        Me.mtsMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtsMenuPrincipal.Name = "mtsMenuPrincipal"
        Me.mtsMenuPrincipal.Size = New System.Drawing.Size(32, 24)
        '
        'tsmCambiarIdioma
        '
        Me.tsmCambiarIdioma.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiEspanol, Me.tmiIngles})
        Me.tsmCambiarIdioma.Name = "tsmCambiarIdioma"
        Me.tsmCambiarIdioma.Size = New System.Drawing.Size(180, 22)
        Me.tsmCambiarIdioma.Text = "Cambiar Idioma"
        '
        'tmiEspanol
        '
        Me.tmiEspanol.Name = "tmiEspanol"
        Me.tmiEspanol.Size = New System.Drawing.Size(180, 22)
        Me.tmiEspanol.Text = "Español"
        '
        'tmiIngles
        '
        Me.tmiIngles.Name = "tmiIngles"
        Me.tmiIngles.Size = New System.Drawing.Size(180, 22)
        Me.tmiIngles.Text = "Ingles"
        '
        'tsmCerrarSesion
        '
        Me.tsmCerrarSesion.Name = "tsmCerrarSesion"
        Me.tsmCerrarSesion.Size = New System.Drawing.Size(180, 22)
        Me.tsmCerrarSesion.Text = "Cerrar Sesion"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'tsmSalir
        '
        Me.tsmSalir.Name = "tsmSalir"
        Me.tsmSalir.Size = New System.Drawing.Size(180, 22)
        Me.tsmSalir.Text = "Salir"
        '
        'flpChatPendientes
        '
        Me.flpChatPendientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpChatPendientes.AutoScroll = True
        Me.flpChatPendientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpChatPendientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.flpChatPendientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpChatPendientes.Controls.Add(Me.lblChatVacio)
        Me.flpChatPendientes.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.flpChatPendientes.Location = New System.Drawing.Point(0, 100)
        Me.flpChatPendientes.Name = "flpChatPendientes"
        Me.flpChatPendientes.Size = New System.Drawing.Size(371, 402)
        Me.flpChatPendientes.TabIndex = 1
        '
        'lblChatVacio
        '
        Me.lblChatVacio.Location = New System.Drawing.Point(5, 10)
        Me.lblChatVacio.Margin = New System.Windows.Forms.Padding(5, 10, 3, 0)
        Me.lblChatVacio.Name = "lblChatVacio"
        Me.lblChatVacio.Size = New System.Drawing.Size(352, 24)
        Me.lblChatVacio.TabIndex = 0
        Me.lblChatVacio.Text = "No hay solicitudes de chat"
        '
        'flpChatenEspera
        '
        Me.flpChatenEspera.AutoScroll = True
        Me.flpChatenEspera.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.flpChatenEspera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpChatenEspera.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.flpChatenEspera.Location = New System.Drawing.Point(0, 530)
        Me.flpChatenEspera.Name = "flpChatenEspera"
        Me.flpChatenEspera.Size = New System.Drawing.Size(371, 188)
        Me.flpChatenEspera.TabIndex = 2
        '
        'lblEspera
        '
        Me.lblEspera.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblEspera.ForeColor = System.Drawing.Color.White
        Me.lblEspera.Location = New System.Drawing.Point(0, 502)
        Me.lblEspera.Margin = New System.Windows.Forms.Padding(5, 10, 3, 0)
        Me.lblEspera.Name = "lblEspera"
        Me.lblEspera.Size = New System.Drawing.Size(371, 31)
        Me.lblEspera.TabIndex = 0
        Me.lblEspera.Text = " EN ESPERA"
        Me.lblEspera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelCabeceraChatActivo
        '
        Me.panelCabeceraChatActivo.BackColor = System.Drawing.Color.White
        Me.panelCabeceraChatActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelCabeceraChatActivo.Controls.Add(Me.lblSintomasIngresadosConsulta)
        Me.panelCabeceraChatActivo.Controls.Add(Me.flpSintomas)
        Me.panelCabeceraChatActivo.Controls.Add(Me.lblEmailPaciente)
        Me.panelCabeceraChatActivo.Controls.Add(Me.lblNombrePaciente)
        Me.panelCabeceraChatActivo.Controls.Add(Me.picAvatarPaciente)
        Me.panelCabeceraChatActivo.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.panelCabeceraChatActivo.Location = New System.Drawing.Point(374, 5)
        Me.panelCabeceraChatActivo.Name = "panelCabeceraChatActivo"
        Me.panelCabeceraChatActivo.Size = New System.Drawing.Size(807, 98)
        Me.panelCabeceraChatActivo.TabIndex = 3
        Me.panelCabeceraChatActivo.Visible = False
        '
        'lblSintomasIngresadosConsulta
        '
        Me.lblSintomasIngresadosConsulta.AutoSize = True
        Me.lblSintomasIngresadosConsulta.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSintomasIngresadosConsulta.Location = New System.Drawing.Point(454, 3)
        Me.lblSintomasIngresadosConsulta.Name = "lblSintomasIngresadosConsulta"
        Me.lblSintomasIngresadosConsulta.Size = New System.Drawing.Size(240, 18)
        Me.lblSintomasIngresadosConsulta.TabIndex = 4
        Me.lblSintomasIngresadosConsulta.Text = "Sintomas Ingresador en la consulta"
        '
        'flpSintomas
        '
        Me.flpSintomas.Location = New System.Drawing.Point(454, 22)
        Me.flpSintomas.Name = "flpSintomas"
        Me.flpSintomas.Size = New System.Drawing.Size(346, 70)
        Me.flpSintomas.TabIndex = 3
        '
        'lblEmailPaciente
        '
        Me.lblEmailPaciente.AutoSize = True
        Me.lblEmailPaciente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEmailPaciente.Location = New System.Drawing.Point(92, 47)
        Me.lblEmailPaciente.Name = "lblEmailPaciente"
        Me.lblEmailPaciente.Size = New System.Drawing.Size(147, 18)
        Me.lblEmailPaciente.TabIndex = 2
        Me.lblEmailPaciente.Text = "email@paciente.com"
        '
        'lblNombrePaciente
        '
        Me.lblNombrePaciente.AutoSize = True
        Me.lblNombrePaciente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNombrePaciente.Location = New System.Drawing.Point(93, 22)
        Me.lblNombrePaciente.Name = "lblNombrePaciente"
        Me.lblNombrePaciente.Size = New System.Drawing.Size(116, 18)
        Me.lblNombrePaciente.TabIndex = 1
        Me.lblNombrePaciente.Text = "nombrePaciente"
        '
        'picAvatarPaciente
        '
        Me.picAvatarPaciente.Image = Global.appMedico.My.Resources.Resources.usuario
        Me.picAvatarPaciente.Location = New System.Drawing.Point(14, 14)
        Me.picAvatarPaciente.Name = "picAvatarPaciente"
        Me.picAvatarPaciente.Size = New System.Drawing.Size(73, 68)
        Me.picAvatarPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAvatarPaciente.TabIndex = 0
        Me.picAvatarPaciente.TabStop = False
        '
        'panelOpcionesChat
        '
        Me.panelOpcionesChat.BackColor = System.Drawing.Color.White
        Me.panelOpcionesChat.Controls.Add(Me.panelMensajes)
        Me.panelOpcionesChat.Controls.Add(Me.btnEnviarMensaje)
        Me.panelOpcionesChat.Controls.Add(Me.txtMensaje)
        Me.panelOpcionesChat.Controls.Add(Me.mnuChat)
        Me.panelOpcionesChat.Location = New System.Drawing.Point(374, 137)
        Me.panelOpcionesChat.Name = "panelOpcionesChat"
        Me.panelOpcionesChat.Size = New System.Drawing.Size(807, 579)
        Me.panelOpcionesChat.TabIndex = 7
        Me.panelOpcionesChat.Visible = False
        '
        'panelMensajes
        '
        Me.panelMensajes.Controls.Add(Me.txtMensajes)
        Me.panelMensajes.Location = New System.Drawing.Point(9, 36)
        Me.panelMensajes.Name = "panelMensajes"
        Me.panelMensajes.Size = New System.Drawing.Size(789, 478)
        Me.panelMensajes.TabIndex = 4
        '
        'txtMensajes
        '
        Me.txtMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensajes.Location = New System.Drawing.Point(6, 3)
        Me.txtMensajes.Name = "txtMensajes"
        Me.txtMensajes.ReadOnly = True
        Me.txtMensajes.Size = New System.Drawing.Size(780, 459)
        Me.txtMensajes.TabIndex = 1
        Me.txtMensajes.Text = ""
        '
        'btnEnviarMensaje
        '
        Me.btnEnviarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviarMensaje.Location = New System.Drawing.Point(632, 532)
        Me.btnEnviarMensaje.Name = "btnEnviarMensaje"
        Me.btnEnviarMensaje.Size = New System.Drawing.Size(115, 29)
        Me.btnEnviarMensaje.TabIndex = 2
        Me.btnEnviarMensaje.Text = "Enviar"
        Me.btnEnviarMensaje.UseVisualStyleBackColor = True
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(9, 532)
        Me.txtMensaje.MaxLength = 80
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(610, 24)
        Me.txtMensaje.TabIndex = 1
        '
        'mnuChat
        '
        Me.mnuChat.AutoSize = False
        Me.mnuChat.BackColor = System.Drawing.Color.White
        Me.mnuChat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuChat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuChat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBtnVerChat, Me.tsmBtnVerPaciente, Me.tsmBtnPonerEspera, Me.tsmBtnFinalizarChat})
        Me.mnuChat.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.mnuChat.Location = New System.Drawing.Point(0, 0)
        Me.mnuChat.Name = "mnuChat"
        Me.mnuChat.Size = New System.Drawing.Size(807, 33)
        Me.mnuChat.TabIndex = 3
        '
        'tsmBtnVerChat
        '
        Me.tsmBtnVerChat.Enabled = False
        Me.tsmBtnVerChat.Image = Global.appMedico.My.Resources.Resources.chat
        Me.tsmBtnVerChat.Name = "tsmBtnVerChat"
        Me.tsmBtnVerChat.Size = New System.Drawing.Size(103, 24)
        Me.tsmBtnVerChat.Text = "Ver chat   "
        '
        'tsmBtnVerPaciente
        '
        Me.tsmBtnVerPaciente.Image = Global.appMedico.My.Resources.Resources.datosusuariochat
        Me.tsmBtnVerPaciente.Name = "tsmBtnVerPaciente"
        Me.tsmBtnVerPaciente.Size = New System.Drawing.Size(154, 24)
        Me.tsmBtnVerPaciente.Text = "Ver datos paciente"
        '
        'tsmBtnPonerEspera
        '
        Me.tsmBtnPonerEspera.Image = Global.appMedico.My.Resources.Resources.esperachat
        Me.tsmBtnPonerEspera.Name = "tsmBtnPonerEspera"
        Me.tsmBtnPonerEspera.Size = New System.Drawing.Size(143, 24)
        Me.tsmBtnPonerEspera.Text = "Poner en espera "
        '
        'tsmBtnFinalizarChat
        '
        Me.tsmBtnFinalizarChat.Image = Global.appMedico.My.Resources.Resources.salidaChat
        Me.tsmBtnFinalizarChat.Name = "tsmBtnFinalizarChat"
        Me.tsmBtnFinalizarChat.Size = New System.Drawing.Size(123, 24)
        Me.tsmBtnFinalizarChat.Text = "Finalizar Chat"
        '
        'panelChatActivo
        '
        Me.panelChatActivo.BackgroundImage = Global.appMedico.My.Resources.Resources.bg_medico
        Me.panelChatActivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.panelChatActivo.Location = New System.Drawing.Point(374, 137)
        Me.panelChatActivo.Name = "panelChatActivo"
        Me.panelChatActivo.Size = New System.Drawing.Size(807, 579)
        Me.panelChatActivo.TabIndex = 4
        '
        'timerChkMensajes
        '
        Me.timerChkMensajes.Interval = 5000
        '
        'timeChequearNuevasSesiones
        '
        Me.timeChequearNuevasSesiones.Interval = 5000
        '
        'panelDatosPaciente
        '
        Me.panelDatosPaciente.Controls.Add(Me.flpPreExistentes)
        Me.panelDatosPaciente.Controls.Add(Me.lblPreExistentes)
        Me.panelDatosPaciente.Controls.Add(Me.txtFechaRegistro)
        Me.panelDatosPaciente.Controls.Add(Me.txtEsquinaPaciente)
        Me.panelDatosPaciente.Controls.Add(Me.txtBarrioPaciente)
        Me.panelDatosPaciente.Controls.Add(Me.txtCalleApto)
        Me.panelDatosPaciente.Controls.Add(Me.txtCalleNumeroPaciente)
        Me.panelDatosPaciente.Controls.Add(Me.txtCallePaciente)
        Me.panelDatosPaciente.Controls.Add(Me.txtFechaNacPaciente)
        Me.panelDatosPaciente.Controls.Add(Me.txtDocIdentidadPaciente)
        Me.panelDatosPaciente.Controls.Add(Me.txtApellidosPaciente)
        Me.panelDatosPaciente.Controls.Add(Me.txtNombrePaciente)
        Me.panelDatosPaciente.Controls.Add(Me.lblfechaRegistro)
        Me.panelDatosPaciente.Controls.Add(Me.lblApto)
        Me.panelDatosPaciente.Controls.Add(Me.lblEsquina)
        Me.panelDatosPaciente.Controls.Add(Me.lblBarrio)
        Me.panelDatosPaciente.Controls.Add(Me.lblNumero)
        Me.panelDatosPaciente.Controls.Add(Me.lblCalle)
        Me.panelDatosPaciente.Controls.Add(Me.lblFechaNac)
        Me.panelDatosPaciente.Controls.Add(Me.lblDocIdentidad)
        Me.panelDatosPaciente.Controls.Add(Me.lblApellidos)
        Me.panelDatosPaciente.Controls.Add(Me.lblNombres)
        Me.panelDatosPaciente.Location = New System.Drawing.Point(374, 169)
        Me.panelDatosPaciente.Name = "panelDatosPaciente"
        Me.panelDatosPaciente.Size = New System.Drawing.Size(806, 546)
        Me.panelDatosPaciente.TabIndex = 8
        Me.panelDatosPaciente.Visible = False
        '
        'flpPreExistentes
        '
        Me.flpPreExistentes.Location = New System.Drawing.Point(58, 247)
        Me.flpPreExistentes.Name = "flpPreExistentes"
        Me.flpPreExistentes.Size = New System.Drawing.Size(439, 106)
        Me.flpPreExistentes.TabIndex = 23
        '
        'lblPreExistentes
        '
        Me.lblPreExistentes.AutoSize = True
        Me.lblPreExistentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPreExistentes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblPreExistentes.Location = New System.Drawing.Point(54, 225)
        Me.lblPreExistentes.Name = "lblPreExistentes"
        Me.lblPreExistentes.Size = New System.Drawing.Size(203, 18)
        Me.lblPreExistentes.TabIndex = 22
        Me.lblPreExistentes.Text = "Enfermedades Pre Existentes"
        '
        'txtFechaRegistro
        '
        Me.txtFechaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaRegistro.Location = New System.Drawing.Point(500, 187)
        Me.txtFechaRegistro.Name = "txtFechaRegistro"
        Me.txtFechaRegistro.ReadOnly = True
        Me.txtFechaRegistro.Size = New System.Drawing.Size(207, 17)
        Me.txtFechaRegistro.TabIndex = 20
        '
        'txtEsquinaPaciente
        '
        Me.txtEsquinaPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEsquinaPaciente.Location = New System.Drawing.Point(500, 146)
        Me.txtEsquinaPaciente.Name = "txtEsquinaPaciente"
        Me.txtEsquinaPaciente.ReadOnly = True
        Me.txtEsquinaPaciente.Size = New System.Drawing.Size(284, 17)
        Me.txtEsquinaPaciente.TabIndex = 19
        '
        'txtBarrioPaciente
        '
        Me.txtBarrioPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBarrioPaciente.Location = New System.Drawing.Point(132, 146)
        Me.txtBarrioPaciente.Name = "txtBarrioPaciente"
        Me.txtBarrioPaciente.ReadOnly = True
        Me.txtBarrioPaciente.Size = New System.Drawing.Size(284, 17)
        Me.txtBarrioPaciente.TabIndex = 18
        '
        'txtCalleApto
        '
        Me.txtCalleApto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCalleApto.Location = New System.Drawing.Point(676, 108)
        Me.txtCalleApto.Name = "txtCalleApto"
        Me.txtCalleApto.ReadOnly = True
        Me.txtCalleApto.Size = New System.Drawing.Size(108, 17)
        Me.txtCalleApto.TabIndex = 17
        '
        'txtCalleNumeroPaciente
        '
        Me.txtCalleNumeroPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCalleNumeroPaciente.Location = New System.Drawing.Point(500, 108)
        Me.txtCalleNumeroPaciente.Name = "txtCalleNumeroPaciente"
        Me.txtCalleNumeroPaciente.ReadOnly = True
        Me.txtCalleNumeroPaciente.Size = New System.Drawing.Size(119, 17)
        Me.txtCalleNumeroPaciente.TabIndex = 16
        '
        'txtCallePaciente
        '
        Me.txtCallePaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCallePaciente.Location = New System.Drawing.Point(132, 108)
        Me.txtCallePaciente.Name = "txtCallePaciente"
        Me.txtCallePaciente.ReadOnly = True
        Me.txtCallePaciente.Size = New System.Drawing.Size(284, 17)
        Me.txtCallePaciente.TabIndex = 15
        '
        'txtFechaNacPaciente
        '
        Me.txtFechaNacPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaNacPaciente.Location = New System.Drawing.Point(500, 70)
        Me.txtFechaNacPaciente.Name = "txtFechaNacPaciente"
        Me.txtFechaNacPaciente.ReadOnly = True
        Me.txtFechaNacPaciente.Size = New System.Drawing.Size(207, 17)
        Me.txtFechaNacPaciente.TabIndex = 14
        '
        'txtDocIdentidadPaciente
        '
        Me.txtDocIdentidadPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocIdentidadPaciente.Location = New System.Drawing.Point(132, 70)
        Me.txtDocIdentidadPaciente.Name = "txtDocIdentidadPaciente"
        Me.txtDocIdentidadPaciente.ReadOnly = True
        Me.txtDocIdentidadPaciente.Size = New System.Drawing.Size(207, 17)
        Me.txtDocIdentidadPaciente.TabIndex = 13
        '
        'txtApellidosPaciente
        '
        Me.txtApellidosPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellidosPaciente.Location = New System.Drawing.Point(500, 32)
        Me.txtApellidosPaciente.Name = "txtApellidosPaciente"
        Me.txtApellidosPaciente.ReadOnly = True
        Me.txtApellidosPaciente.Size = New System.Drawing.Size(284, 17)
        Me.txtApellidosPaciente.TabIndex = 12
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombrePaciente.Location = New System.Drawing.Point(132, 32)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.ReadOnly = True
        Me.txtNombrePaciente.Size = New System.Drawing.Size(284, 17)
        Me.txtNombrePaciente.TabIndex = 11
        '
        'lblfechaRegistro
        '
        Me.lblfechaRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblfechaRegistro.Location = New System.Drawing.Point(348, 187)
        Me.lblfechaRegistro.Name = "lblfechaRegistro"
        Me.lblfechaRegistro.Size = New System.Drawing.Size(150, 18)
        Me.lblfechaRegistro.TabIndex = 9
        Me.lblfechaRegistro.Text = "Fecha de Registro:"
        Me.lblfechaRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApto
        '
        Me.lblApto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblApto.Location = New System.Drawing.Point(628, 108)
        Me.lblApto.Name = "lblApto"
        Me.lblApto.Size = New System.Drawing.Size(42, 18)
        Me.lblApto.TabIndex = 8
        Me.lblApto.Text = "Apto:"
        Me.lblApto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEsquina
        '
        Me.lblEsquina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblEsquina.Location = New System.Drawing.Point(417, 146)
        Me.lblEsquina.Name = "lblEsquina"
        Me.lblEsquina.Size = New System.Drawing.Size(79, 18)
        Me.lblEsquina.TabIndex = 7
        Me.lblEsquina.Text = "Esquina:"
        Me.lblEsquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBarrio
        '
        Me.lblBarrio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblBarrio.Location = New System.Drawing.Point(18, 146)
        Me.lblBarrio.Name = "lblBarrio"
        Me.lblBarrio.Size = New System.Drawing.Size(110, 18)
        Me.lblBarrio.TabIndex = 6
        Me.lblBarrio.Text = "Barrio:"
        Me.lblBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumero
        '
        Me.lblNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblNumero.Location = New System.Drawing.Point(422, 108)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(74, 18)
        Me.lblNumero.TabIndex = 5
        Me.lblNumero.Text = "Numero:"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCalle
        '
        Me.lblCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblCalle.Location = New System.Drawing.Point(15, 108)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(111, 18)
        Me.lblCalle.TabIndex = 4
        Me.lblCalle.Text = "Calle:"
        Me.lblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaNac
        '
        Me.lblFechaNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblFechaNac.Location = New System.Drawing.Point(345, 70)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(152, 18)
        Me.lblFechaNac.TabIndex = 3
        Me.lblFechaNac.Text = "Fecha de Nacimiento:"
        Me.lblFechaNac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDocIdentidad
        '
        Me.lblDocIdentidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblDocIdentidad.Location = New System.Drawing.Point(9, 70)
        Me.lblDocIdentidad.Name = "lblDocIdentidad"
        Me.lblDocIdentidad.Size = New System.Drawing.Size(116, 18)
        Me.lblDocIdentidad.TabIndex = 2
        Me.lblDocIdentidad.Text = "Doc. Identidad:"
        Me.lblDocIdentidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellidos
        '
        Me.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblApellidos.Location = New System.Drawing.Point(414, 32)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(79, 18)
        Me.lblApellidos.TabIndex = 1
        Me.lblApellidos.Text = "Apellidos:"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombres
        '
        Me.lblNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblNombres.Location = New System.Drawing.Point(9, 32)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(119, 18)
        Me.lblNombres.TabIndex = 0
        Me.lblNombres.Text = "Nombres:"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'timeEstadoDeSesion
        '
        Me.timeEstadoDeSesion.Interval = 5000
        '
        'frmPrincipal
        '
        Me.AcceptButton = Me.btnEnviarMensaje
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1187, 721)
        Me.Controls.Add(Me.panelDatosPaciente)
        Me.Controls.Add(Me.lblEspera)
        Me.Controls.Add(Me.panelOpcionesChat)
        Me.Controls.Add(Me.panelChatActivo)
        Me.Controls.Add(Me.panelCabeceraChatActivo)
        Me.Controls.Add(Me.flpChatenEspera)
        Me.Controls.Add(Me.flpChatPendientes)
        Me.Controls.Add(Me.PanelMedico)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIAGE"
        Me.PanelMedico.ResumeLayout(False)
        Me.PanelMedico.PerformLayout()
        CType(Me.picEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFotoMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.flpChatPendientes.ResumeLayout(False)
        Me.panelCabeceraChatActivo.ResumeLayout(False)
        Me.panelCabeceraChatActivo.PerformLayout()
        CType(Me.picAvatarPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOpcionesChat.ResumeLayout(False)
        Me.panelOpcionesChat.PerformLayout()
        Me.panelMensajes.ResumeLayout(False)
        Me.mnuChat.ResumeLayout(False)
        Me.mnuChat.PerformLayout()
        Me.panelDatosPaciente.ResumeLayout(False)
        Me.panelDatosPaciente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMedico As Panel
    Friend WithEvents flpChatPendientes As FlowLayoutPanel
    Friend WithEvents flpChatenEspera As FlowLayoutPanel
    Friend WithEvents panelCabeceraChatActivo As Panel
    Friend WithEvents panelChatActivo As Panel
    Friend WithEvents lblChatVacio As Label
    Friend WithEvents lblEspera As Label
    Friend WithEvents picFotoMedico As PictureBox
    Friend WithEvents picEstado As PictureBox
    Friend WithEvents lblNombreMedico As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mtsMenuPrincipal As ToolStripMenuItem
    Friend WithEvents tsmSalir As ToolStripMenuItem
    Friend WithEvents picAvatarPaciente As PictureBox
    Friend WithEvents lblEmailPaciente As Label
    Friend WithEvents lblNombrePaciente As Label
    Friend WithEvents flpSintomas As FlowLayoutPanel
    Friend WithEvents panelOpcionesChat As Panel
    Friend WithEvents btnEnviarMensaje As Button
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents mnuChat As MenuStrip
    Friend WithEvents tsmBtnPonerEspera As ToolStripMenuItem
    Friend WithEvents tsmBtnVerPaciente As ToolStripMenuItem
    Friend WithEvents tsmBtnFinalizarChat As ToolStripMenuItem
    Friend WithEvents tsmBtnVerChat As ToolStripMenuItem
    Friend WithEvents panelMensajes As Panel
    Friend WithEvents txtMensajes As RichTextBox
    Friend WithEvents timerChkMensajes As Timer
    Friend WithEvents timeChequearNuevasSesiones As Timer
    Friend WithEvents panelDatosPaciente As Panel
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblDocIdentidad As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblApto As Label
    Friend WithEvents lblEsquina As Label
    Friend WithEvents lblBarrio As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblfechaRegistro As Label
    Friend WithEvents txtFechaRegistro As TextBox
    Friend WithEvents txtEsquinaPaciente As TextBox
    Friend WithEvents txtBarrioPaciente As TextBox
    Friend WithEvents txtCalleApto As TextBox
    Friend WithEvents txtCalleNumeroPaciente As TextBox
    Friend WithEvents txtCallePaciente As TextBox
    Friend WithEvents txtFechaNacPaciente As TextBox
    Friend WithEvents txtDocIdentidadPaciente As TextBox
    Friend WithEvents txtApellidosPaciente As TextBox
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents lblPreExistentes As Label
    Friend WithEvents flpPreExistentes As FlowLayoutPanel
    Friend WithEvents lblSintomasIngresadosConsulta As Label
    Friend WithEvents timeEstadoDeSesion As Timer
    Friend WithEvents tsmCerrarSesion As ToolStripMenuItem
    Friend WithEvents ttMensajePonderacion As ToolTip
    Friend WithEvents tsmCambiarIdioma As ToolStripMenuItem
    Friend WithEvents tmiEspanol As ToolStripMenuItem
    Friend WithEvents tmiIngles As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
