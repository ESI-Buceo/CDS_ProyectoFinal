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
        Me.PanelInicio = New System.Windows.Forms.Panel()
        Me.PanelDeConsulta = New System.Windows.Forms.Panel()
        Me.flPanelDiagnostico = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblNoResultado = New System.Windows.Forms.Label()
        Me.picLogoCliente = New System.Windows.Forms.PictureBox()
        Me.panelDeSintomas = New System.Windows.Forms.Panel()
        Me.btnIniciarChat = New System.Windows.Forms.Button()
        Me.btnVerInforme = New System.Windows.Forms.Button()
        Me.btnNuevaConsulta = New System.Windows.Forms.Button()
        Me.panelBotonSiNo = New System.Windows.Forms.Panel()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.btnSiguienteSintoma = New System.Windows.Forms.Button()
        Me.txtSintoma = New System.Windows.Forms.TextBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.linkSaberMas = New System.Windows.Forms.LinkLabel()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.picMsVidaSana = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLeyenda = New System.Windows.Forms.Label()
        Me.btnIniciarAutenticado = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.btnHistoria = New System.Windows.Forms.Button()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.lblPacienteNombre = New System.Windows.Forms.Label()
        Me.picFotoUsuario = New System.Windows.Forms.PictureBox()
        Me.tiempoMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.panelChat = New System.Windows.Forms.Panel()
        Me.txtMensajes = New System.Windows.Forms.RichTextBox()
        Me.btnFinalizarChat = New System.Windows.Forms.Button()
        Me.btnEnviarMensaje = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.panelChatOpciones = New System.Windows.Forms.Panel()
        Me.panelInfoMedico = New System.Windows.Forms.Panel()
        Me.lblNombreMedico = New System.Windows.Forms.Label()
        Me.picMedico = New System.Windows.Forms.PictureBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblEstadoChat = New System.Windows.Forms.Label()
        Me.TimerChequearEstado = New System.Windows.Forms.Timer(Me.components)
        Me.PanelInicio.SuspendLayout()
        Me.PanelDeConsulta.SuspendLayout()
        Me.flPanelDiagnostico.SuspendLayout()
        CType(Me.picLogoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDeSintomas.SuspendLayout()
        Me.panelBotonSiNo.SuspendLayout()
        CType(Me.picMsVidaSana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCabecera.SuspendLayout()
        CType(Me.picFotoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelChat.SuspendLayout()
        Me.panelChatOpciones.SuspendLayout()
        Me.panelInfoMedico.SuspendLayout()
        CType(Me.picMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelInicio
        '
        Me.PanelInicio.Controls.Add(Me.PanelDeConsulta)
        Me.PanelInicio.Controls.Add(Me.PictureBox1)
        Me.PanelInicio.Controls.Add(Me.lblLeyenda)
        Me.PanelInicio.Controls.Add(Me.btnIniciarAutenticado)
        Me.PanelInicio.Controls.Add(Me.picLogo)
        Me.PanelInicio.Location = New System.Drawing.Point(1, 42)
        Me.PanelInicio.Name = "PanelInicio"
        Me.PanelInicio.Size = New System.Drawing.Size(1145, 614)
        Me.PanelInicio.TabIndex = 0
        '
        'PanelDeConsulta
        '
        Me.PanelDeConsulta.Controls.Add(Me.flPanelDiagnostico)
        Me.PanelDeConsulta.Controls.Add(Me.picLogoCliente)
        Me.PanelDeConsulta.Controls.Add(Me.panelDeSintomas)
        Me.PanelDeConsulta.Controls.Add(Me.linkSaberMas)
        Me.PanelDeConsulta.Controls.Add(Me.btnComenzar)
        Me.PanelDeConsulta.Controls.Add(Me.lblMensaje)
        Me.PanelDeConsulta.Controls.Add(Me.picMsVidaSana)
        Me.PanelDeConsulta.Location = New System.Drawing.Point(2, 30)
        Me.PanelDeConsulta.Name = "PanelDeConsulta"
        Me.PanelDeConsulta.Size = New System.Drawing.Size(1143, 594)
        Me.PanelDeConsulta.TabIndex = 1
        Me.PanelDeConsulta.Visible = False
        '
        'flPanelDiagnostico
        '
        Me.flPanelDiagnostico.AutoScroll = True
        Me.flPanelDiagnostico.BackColor = System.Drawing.SystemColors.Control
        Me.flPanelDiagnostico.Controls.Add(Me.lblNoResultado)
        Me.flPanelDiagnostico.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flPanelDiagnostico.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.flPanelDiagnostico.Location = New System.Drawing.Point(819, 12)
        Me.flPanelDiagnostico.Name = "flPanelDiagnostico"
        Me.flPanelDiagnostico.Padding = New System.Windows.Forms.Padding(2)
        Me.flPanelDiagnostico.Size = New System.Drawing.Size(321, 572)
        Me.flPanelDiagnostico.TabIndex = 6
        Me.flPanelDiagnostico.Visible = False
        '
        'lblNoResultado
        '
        Me.lblNoResultado.AutoSize = True
        Me.lblNoResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNoResultado.Location = New System.Drawing.Point(5, 2)
        Me.lblNoResultado.Name = "lblNoResultado"
        Me.lblNoResultado.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.lblNoResultado.Size = New System.Drawing.Size(161, 44)
        Me.lblNoResultado.TabIndex = 0
        Me.lblNoResultado.Text = "No hay resultados"
        '
        'picLogoCliente
        '
        Me.picLogoCliente.Image = Global.appUsuario.My.Resources.Resources.vidasana
        Me.picLogoCliente.Location = New System.Drawing.Point(67, 468)
        Me.picLogoCliente.Name = "picLogoCliente"
        Me.picLogoCliente.Size = New System.Drawing.Size(150, 48)
        Me.picLogoCliente.TabIndex = 5
        Me.picLogoCliente.TabStop = False
        '
        'panelDeSintomas
        '
        Me.panelDeSintomas.Controls.Add(Me.btnIniciarChat)
        Me.panelDeSintomas.Controls.Add(Me.btnVerInforme)
        Me.panelDeSintomas.Controls.Add(Me.btnNuevaConsulta)
        Me.panelDeSintomas.Controls.Add(Me.panelBotonSiNo)
        Me.panelDeSintomas.Controls.Add(Me.btnSiguienteSintoma)
        Me.panelDeSintomas.Controls.Add(Me.txtSintoma)
        Me.panelDeSintomas.Controls.Add(Me.lblLine)
        Me.panelDeSintomas.Controls.Add(Me.lblPregunta)
        Me.panelDeSintomas.Location = New System.Drawing.Point(365, 47)
        Me.panelDeSintomas.Name = "panelDeSintomas"
        Me.panelDeSintomas.Size = New System.Drawing.Size(418, 537)
        Me.panelDeSintomas.TabIndex = 4
        Me.panelDeSintomas.Visible = False
        '
        'btnIniciarChat
        '
        Me.btnIniciarChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarChat.ForeColor = System.Drawing.Color.Green
        Me.btnIniciarChat.Location = New System.Drawing.Point(216, 405)
        Me.btnIniciarChat.Name = "btnIniciarChat"
        Me.btnIniciarChat.Size = New System.Drawing.Size(171, 44)
        Me.btnIniciarChat.TabIndex = 10
        Me.btnIniciarChat.Text = "Iniciar Chat"
        Me.btnIniciarChat.UseVisualStyleBackColor = True
        Me.btnIniciarChat.Visible = False
        '
        'btnVerInforme
        '
        Me.btnVerInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerInforme.ForeColor = System.Drawing.Color.Maroon
        Me.btnVerInforme.Location = New System.Drawing.Point(216, 355)
        Me.btnVerInforme.Name = "btnVerInforme"
        Me.btnVerInforme.Size = New System.Drawing.Size(171, 44)
        Me.btnVerInforme.TabIndex = 9
        Me.btnVerInforme.Text = "Ver informe"
        Me.btnVerInforme.UseVisualStyleBackColor = True
        Me.btnVerInforme.Visible = False
        '
        'btnNuevaConsulta
        '
        Me.btnNuevaConsulta.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnNuevaConsulta.Location = New System.Drawing.Point(216, 355)
        Me.btnNuevaConsulta.Name = "btnNuevaConsulta"
        Me.btnNuevaConsulta.Size = New System.Drawing.Size(171, 44)
        Me.btnNuevaConsulta.TabIndex = 8
        Me.btnNuevaConsulta.Text = "Nueva consulta"
        Me.btnNuevaConsulta.UseVisualStyleBackColor = True
        Me.btnNuevaConsulta.Visible = False
        '
        'panelBotonSiNo
        '
        Me.panelBotonSiNo.Controls.Add(Me.btnNo)
        Me.panelBotonSiNo.Controls.Add(Me.btnSi)
        Me.panelBotonSiNo.Location = New System.Drawing.Point(201, 305)
        Me.panelBotonSiNo.Name = "panelBotonSiNo"
        Me.panelBotonSiNo.Size = New System.Drawing.Size(202, 67)
        Me.panelBotonSiNo.TabIndex = 6
        Me.panelBotonSiNo.Visible = False
        '
        'btnNo
        '
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.ForeColor = System.Drawing.Color.Orange
        Me.btnNo.Location = New System.Drawing.Point(25, 18)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(83, 43)
        Me.btnNo.TabIndex = 1
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnSi
        '
        Me.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSi.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSi.Location = New System.Drawing.Point(114, 18)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(83, 43)
        Me.btnSi.TabIndex = 0
        Me.btnSi.Text = "SI"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'btnSiguienteSintoma
        '
        Me.btnSiguienteSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguienteSintoma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnSiguienteSintoma.Location = New System.Drawing.Point(201, 305)
        Me.btnSiguienteSintoma.Name = "btnSiguienteSintoma"
        Me.btnSiguienteSintoma.Size = New System.Drawing.Size(171, 44)
        Me.btnSiguienteSintoma.TabIndex = 5
        Me.btnSiguienteSintoma.Text = "Siguiente..."
        Me.btnSiguienteSintoma.UseVisualStyleBackColor = True
        '
        'txtSintoma
        '
        Me.txtSintoma.BackColor = System.Drawing.Color.White
        Me.txtSintoma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSintoma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSintoma.Location = New System.Drawing.Point(75, 241)
        Me.txtSintoma.Name = "txtSintoma"
        Me.txtSintoma.Size = New System.Drawing.Size(288, 22)
        Me.txtSintoma.TabIndex = 4
        Me.txtSintoma.Text = "Ingresa un sintoma"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblLine.Location = New System.Drawing.Point(70, 249)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(387, 20)
        Me.lblLine.TabIndex = 3
        Me.lblLine.Text = "__________________________________________"
        '
        'lblPregunta
        '
        Me.lblPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblPregunta.Location = New System.Drawing.Point(11, 176)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPregunta.Size = New System.Drawing.Size(440, 52)
        Me.lblPregunta.TabIndex = 2
        Me.lblPregunta.Text = "Cuentanos cual es tu principal malestar... ?"
        '
        'linkSaberMas
        '
        Me.linkSaberMas.AutoSize = True
        Me.linkSaberMas.LinkColor = System.Drawing.Color.SteelBlue
        Me.linkSaberMas.Location = New System.Drawing.Point(63, 519)
        Me.linkSaberMas.Name = "linkSaberMas"
        Me.linkSaberMas.Size = New System.Drawing.Size(115, 24)
        Me.linkSaberMas.TabIndex = 3
        Me.linkSaberMas.TabStop = True
        Me.linkSaberMas.Text = "Saber mas..."
        '
        'btnComenzar
        '
        Me.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComenzar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnComenzar.Location = New System.Drawing.Point(594, 306)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(243, 49)
        Me.btnComenzar.TabIndex = 2
        Me.btnComenzar.Text = "Comencemos..."
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(376, 158)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Padding = New System.Windows.Forms.Padding(5)
        Me.lblMensaje.Size = New System.Drawing.Size(470, 100)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.Text = "Hola, gracias por utilizar Triage. Trataremos de orientarte para que luego consul" &
    "tes a tu medico. Comencemos a hacer una evaluacion"
        '
        'picMsVidaSana
        '
        Me.picMsVidaSana.Image = Global.appUsuario.My.Resources.Resources.doc
        Me.picMsVidaSana.Location = New System.Drawing.Point(67, 47)
        Me.picMsVidaSana.Name = "picMsVidaSana"
        Me.picMsVidaSana.Size = New System.Drawing.Size(290, 276)
        Me.picMsVidaSana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMsVidaSana.TabIndex = 0
        Me.picMsVidaSana.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.appUsuario.My.Resources.Resources.vidasana
        Me.PictureBox1.Location = New System.Drawing.Point(277, 374)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblLeyenda
        '
        Me.lblLeyenda.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeyenda.ForeColor = System.Drawing.Color.Teal
        Me.lblLeyenda.Location = New System.Drawing.Point(272, 422)
        Me.lblLeyenda.Name = "lblLeyenda"
        Me.lblLeyenda.Size = New System.Drawing.Size(547, 106)
        Me.lblLeyenda.TabIndex = 6
        Me.lblLeyenda.Text = "Mas de 80 años apostando a la saludar de nuestros afiliados. Una gran familia te " &
    "protege."
        '
        'btnIniciarAutenticado
        '
        Me.btnIniciarAutenticado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarAutenticado.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnIniciarAutenticado.Location = New System.Drawing.Point(412, 245)
        Me.btnIniciarAutenticado.Name = "btnIniciarAutenticado"
        Me.btnIniciarAutenticado.Size = New System.Drawing.Size(322, 75)
        Me.btnIniciarAutenticado.TabIndex = 2
        Me.btnIniciarAutenticado.Text = "Usuario registrado"
        Me.btnIniciarAutenticado.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = Global.appUsuario.My.Resources.Resources.logo_App
        Me.picLogo.Location = New System.Drawing.Point(300, 32)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(530, 147)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.Gainsboro
        Me.panelCabecera.Controls.Add(Me.btnChat)
        Me.panelCabecera.Controls.Add(Me.btnHistoria)
        Me.panelCabecera.Controls.Add(Me.btnConsulta)
        Me.panelCabecera.Controls.Add(Me.lblPacienteNombre)
        Me.panelCabecera.Controls.Add(Me.picFotoUsuario)
        Me.panelCabecera.Location = New System.Drawing.Point(2, 2)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(1143, 66)
        Me.panelCabecera.TabIndex = 2
        Me.panelCabecera.Visible = False
        '
        'btnChat
        '
        Me.btnChat.Enabled = False
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnChat.Image = Global.appUsuario.My.Resources.Resources.btnChat
        Me.btnChat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChat.Location = New System.Drawing.Point(873, 2)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(104, 62)
        Me.btnChat.TabIndex = 5
        Me.btnChat.Text = "Chat"
        Me.btnChat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'btnHistoria
        '
        Me.btnHistoria.FlatAppearance.BorderSize = 0
        Me.btnHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnHistoria.Image = Global.appUsuario.My.Resources.Resources.btnReloj
        Me.btnHistoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHistoria.Location = New System.Drawing.Point(977, 2)
        Me.btnHistoria.Name = "btnHistoria"
        Me.btnHistoria.Size = New System.Drawing.Size(104, 62)
        Me.btnHistoria.TabIndex = 4
        Me.btnHistoria.Text = "Historia"
        Me.btnHistoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHistoria.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.FlatAppearance.BorderSize = 0
        Me.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnConsulta.Image = Global.appUsuario.My.Resources.Resources.btnConsultaSelect
        Me.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsulta.Location = New System.Drawing.Point(769, 2)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(104, 62)
        Me.btnConsulta.TabIndex = 2
        Me.btnConsulta.Text = "Consulta"
        Me.btnConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'lblPacienteNombre
        '
        Me.lblPacienteNombre.AutoSize = True
        Me.lblPacienteNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblPacienteNombre.Location = New System.Drawing.Point(76, 26)
        Me.lblPacienteNombre.Name = "lblPacienteNombre"
        Me.lblPacienteNombre.Size = New System.Drawing.Size(184, 24)
        Me.lblPacienteNombre.TabIndex = 1
        Me.lblPacienteNombre.Text = "nombre del paciente"
        '
        'picFotoUsuario
        '
        Me.picFotoUsuario.Image = Global.appUsuario.My.Resources.Resources.bg_foto
        Me.picFotoUsuario.Location = New System.Drawing.Point(23, 11)
        Me.picFotoUsuario.Name = "picFotoUsuario"
        Me.picFotoUsuario.Size = New System.Drawing.Size(47, 43)
        Me.picFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFotoUsuario.TabIndex = 0
        Me.picFotoUsuario.TabStop = False
        '
        'tiempoMensaje
        '
        '
        'panelChat
        '
        Me.panelChat.Controls.Add(Me.txtMensajes)
        Me.panelChat.Controls.Add(Me.btnFinalizarChat)
        Me.panelChat.Controls.Add(Me.btnEnviarMensaje)
        Me.panelChat.Controls.Add(Me.txtMensaje)
        Me.panelChat.Controls.Add(Me.panelChatOpciones)
        Me.panelChat.Location = New System.Drawing.Point(1, 72)
        Me.panelChat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.panelChat.Name = "panelChat"
        Me.panelChat.Size = New System.Drawing.Size(1142, 581)
        Me.panelChat.TabIndex = 5
        Me.panelChat.Visible = False
        '
        'txtMensajes
        '
        Me.txtMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensajes.Location = New System.Drawing.Point(246, 59)
        Me.txtMensajes.Name = "txtMensajes"
        Me.txtMensajes.ReadOnly = True
        Me.txtMensajes.Size = New System.Drawing.Size(886, 463)
        Me.txtMensajes.TabIndex = 8
        Me.txtMensajes.Text = ""
        '
        'btnFinalizarChat
        '
        Me.btnFinalizarChat.AutoSize = True
        Me.btnFinalizarChat.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFinalizarChat.FlatAppearance.BorderSize = 0
        Me.btnFinalizarChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizarChat.Image = Global.appUsuario.My.Resources.Resources.salidaChat
        Me.btnFinalizarChat.Location = New System.Drawing.Point(1030, 15)
        Me.btnFinalizarChat.Name = "btnFinalizarChat"
        Me.btnFinalizarChat.Size = New System.Drawing.Size(100, 43)
        Me.btnFinalizarChat.TabIndex = 9
        Me.btnFinalizarChat.UseVisualStyleBackColor = True
        '
        'btnEnviarMensaje
        '
        Me.btnEnviarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEnviarMensaje.Location = New System.Drawing.Point(1025, 531)
        Me.btnEnviarMensaje.Name = "btnEnviarMensaje"
        Me.btnEnviarMensaje.Size = New System.Drawing.Size(105, 28)
        Me.btnEnviarMensaje.TabIndex = 7
        Me.btnEnviarMensaje.Text = "Enviar"
        Me.btnEnviarMensaje.UseVisualStyleBackColor = True
        '
        'txtMensaje
        '
        Me.txtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMensaje.Location = New System.Drawing.Point(246, 530)
        Me.txtMensaje.MaxLength = 60
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(773, 28)
        Me.txtMensaje.TabIndex = 6
        '
        'panelChatOpciones
        '
        Me.panelChatOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panelChatOpciones.Controls.Add(Me.panelInfoMedico)
        Me.panelChatOpciones.Controls.Add(Me.lblEstado)
        Me.panelChatOpciones.Controls.Add(Me.lblEstadoChat)
        Me.panelChatOpciones.Location = New System.Drawing.Point(1, 0)
        Me.panelChatOpciones.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.panelChatOpciones.Name = "panelChatOpciones"
        Me.panelChatOpciones.Size = New System.Drawing.Size(239, 581)
        Me.panelChatOpciones.TabIndex = 0
        '
        'panelInfoMedico
        '
        Me.panelInfoMedico.Controls.Add(Me.lblNombreMedico)
        Me.panelInfoMedico.Controls.Add(Me.picMedico)
        Me.panelInfoMedico.Location = New System.Drawing.Point(29, 192)
        Me.panelInfoMedico.Name = "panelInfoMedico"
        Me.panelInfoMedico.Size = New System.Drawing.Size(180, 196)
        Me.panelInfoMedico.TabIndex = 3
        Me.panelInfoMedico.Visible = False
        '
        'lblNombreMedico
        '
        Me.lblNombreMedico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombreMedico.Location = New System.Drawing.Point(12, 146)
        Me.lblNombreMedico.Name = "lblNombreMedico"
        Me.lblNombreMedico.Size = New System.Drawing.Size(162, 22)
        Me.lblNombreMedico.TabIndex = 1
        Me.lblNombreMedico.Text = "nombreMedico"
        Me.lblNombreMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picMedico
        '
        Me.picMedico.Image = Global.appUsuario.My.Resources.Resources.docMas
        Me.picMedico.Location = New System.Drawing.Point(30, 13)
        Me.picMedico.Name = "picMedico"
        Me.picMedico.Size = New System.Drawing.Size(121, 120)
        Me.picMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMedico.TabIndex = 0
        Me.picMedico.TabStop = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEstado.Location = New System.Drawing.Point(19, 68)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(97, 24)
        Me.lblEstado.TabIndex = 1
        Me.lblEstado.Text = "En espera"
        '
        'lblEstadoChat
        '
        Me.lblEstadoChat.AutoSize = True
        Me.lblEstadoChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblEstadoChat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEstadoChat.Location = New System.Drawing.Point(18, 35)
        Me.lblEstadoChat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstadoChat.Name = "lblEstadoChat"
        Me.lblEstadoChat.Size = New System.Drawing.Size(88, 24)
        Me.lblEstadoChat.TabIndex = 0
        Me.lblEstadoChat.Text = "ESTADO"
        '
        'TimerChequearEstado
        '
        Me.TimerChequearEstado.Interval = 10000
        '
        'frmPrincipal
        '
        Me.AcceptButton = Me.btnEnviarMensaje
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1146, 658)
        Me.Controls.Add(Me.panelChat)
        Me.Controls.Add(Me.panelCabecera)
        Me.Controls.Add(Me.PanelInicio)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIAGE"
        Me.PanelInicio.ResumeLayout(False)
        Me.PanelDeConsulta.ResumeLayout(False)
        Me.PanelDeConsulta.PerformLayout()
        Me.flPanelDiagnostico.ResumeLayout(False)
        Me.flPanelDiagnostico.PerformLayout()
        CType(Me.picLogoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDeSintomas.ResumeLayout(False)
        Me.panelDeSintomas.PerformLayout()
        Me.panelBotonSiNo.ResumeLayout(False)
        CType(Me.picMsVidaSana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        CType(Me.picFotoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelChat.ResumeLayout(False)
        Me.panelChat.PerformLayout()
        Me.panelChatOpciones.ResumeLayout(False)
        Me.panelChatOpciones.PerformLayout()
        Me.panelInfoMedico.ResumeLayout(False)
        CType(Me.picMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelInicio As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnIniciarAutenticado As Button
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents btnHistoria As Button
    Friend WithEvents btnConsulta As Button
    Friend WithEvents lblPacienteNombre As Label
    Friend WithEvents picFotoUsuario As PictureBox
    Friend WithEvents PanelDeConsulta As Panel
    Friend WithEvents btnChat As Button
    Friend WithEvents panelDeSintomas As Panel
    Friend WithEvents linkSaberMas As LinkLabel
    Friend WithEvents btnComenzar As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents picMsVidaSana As PictureBox
    Friend WithEvents lblPregunta As Label
    Friend WithEvents lblLine As Label
    Friend WithEvents txtSintoma As TextBox
    Friend WithEvents picLogoCliente As PictureBox
    Friend WithEvents btnSiguienteSintoma As Button
    Friend WithEvents panelBotonSiNo As Panel
    Friend WithEvents btnNo As Button
    Friend WithEvents btnSi As Button
    Friend WithEvents flPanelDiagnostico As FlowLayoutPanel
    Friend WithEvents btnNuevaConsulta As Button
    Friend WithEvents btnVerInforme As Button
    Friend WithEvents lblNoResultado As Label
    Friend WithEvents tiempoMensaje As Timer
    Friend WithEvents btnIniciarChat As Button
    Friend WithEvents panelChat As Panel
    Friend WithEvents panelChatOpciones As Panel
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblEstadoChat As Label
    Friend WithEvents TimerChequearEstado As Timer
    Friend WithEvents panelInfoMedico As Panel
    Friend WithEvents lblNombreMedico As Label
    Friend WithEvents picMedico As PictureBox
    Friend WithEvents btnFinalizarChat As Button
    Friend WithEvents txtMensajes As RichTextBox
    Friend WithEvents btnEnviarMensaje As Button
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLeyenda As Label
End Class
