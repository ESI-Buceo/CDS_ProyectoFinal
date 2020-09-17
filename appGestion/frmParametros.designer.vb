<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.gbParametros = New System.Windows.Forms.GroupBox()
        Me.lblIpAppPaciente = New System.Windows.Forms.Label()
        Me.lblIRangoMedicos = New System.Windows.Forms.Label()
        Me.lblIpGestor = New System.Windows.Forms.Label()
        Me.lblIPConexiones = New System.Windows.Forms.Label()
        Me.lblTituloIP = New System.Windows.Forms.Label()
        Me.txtCantSintomas = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblSubTitleCantSintomas = New System.Windows.Forms.Label()
        Me.lblTituloCantSintomas = New System.Windows.Forms.Label()
        Me.cbLenguaje = New System.Windows.Forms.ComboBox()
        Me.lblLenguaje = New System.Windows.Forms.Label()
        Me.lblDescIdiomaSistema = New System.Windows.Forms.Label()
        Me.lblLengSistema = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.gbEmail = New System.Windows.Forms.GroupBox()
        Me.txtEmailCredencial = New System.Windows.Forms.TextBox()
        Me.lblEmailCredencial = New System.Windows.Forms.Label()
        Me.chkEmailSSL = New System.Windows.Forms.CheckBox()
        Me.txtServidorSMTP = New System.Windows.Forms.TextBox()
        Me.lblEmailServidorSMTP = New System.Windows.Forms.Label()
        Me.txtEmailPuerto = New System.Windows.Forms.TextBox()
        Me.lblEmailPuerto = New System.Windows.Forms.Label()
        Me.txtEmailContacto = New System.Windows.Forms.TextBox()
        Me.lblEmailContacto = New System.Windows.Forms.Label()
        Me.lblSubTituloEmail = New System.Windows.Forms.Label()
        Me.chkConfigurarEmail = New System.Windows.Forms.CheckBox()
        Me.txtIpGestion = New System.Windows.Forms.TextBox()
        Me.txtIpMedicos = New System.Windows.Forms.TextBox()
        Me.txtIpPacientes = New System.Windows.Forms.TextBox()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbParametros.SuspendLayout()
        Me.gbEmail.SuspendLayout()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-11, -1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(799, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 4
        Me.picEncabezado.TabStop = False
        '
        'gbParametros
        '
        Me.gbParametros.Controls.Add(Me.txtIpPacientes)
        Me.gbParametros.Controls.Add(Me.txtIpMedicos)
        Me.gbParametros.Controls.Add(Me.txtIpGestion)
        Me.gbParametros.Controls.Add(Me.lblIpAppPaciente)
        Me.gbParametros.Controls.Add(Me.lblIRangoMedicos)
        Me.gbParametros.Controls.Add(Me.lblIpGestor)
        Me.gbParametros.Controls.Add(Me.lblIPConexiones)
        Me.gbParametros.Controls.Add(Me.lblTituloIP)
        Me.gbParametros.Controls.Add(Me.txtCantSintomas)
        Me.gbParametros.Controls.Add(Me.lblCantidad)
        Me.gbParametros.Controls.Add(Me.lblSubTitleCantSintomas)
        Me.gbParametros.Controls.Add(Me.lblTituloCantSintomas)
        Me.gbParametros.Controls.Add(Me.cbLenguaje)
        Me.gbParametros.Controls.Add(Me.lblLenguaje)
        Me.gbParametros.Controls.Add(Me.lblDescIdiomaSistema)
        Me.gbParametros.Controls.Add(Me.lblLengSistema)
        Me.gbParametros.Location = New System.Drawing.Point(21, 86)
        Me.gbParametros.Name = "gbParametros"
        Me.gbParametros.Size = New System.Drawing.Size(744, 370)
        Me.gbParametros.TabIndex = 5
        Me.gbParametros.TabStop = False
        Me.gbParametros.Text = "Opciones de Configuracion"
        '
        'lblIpAppPaciente
        '
        Me.lblIpAppPaciente.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblIpAppPaciente.Location = New System.Drawing.Point(6, 329)
        Me.lblIpAppPaciente.Name = "lblIpAppPaciente"
        Me.lblIpAppPaciente.Size = New System.Drawing.Size(151, 20)
        Me.lblIpAppPaciente.TabIndex = 26
        Me.lblIpAppPaciente.Text = "IP APP Paciente"
        Me.lblIpAppPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIRangoMedicos
        '
        Me.lblIRangoMedicos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblIRangoMedicos.Location = New System.Drawing.Point(336, 295)
        Me.lblIRangoMedicos.Name = "lblIRangoMedicos"
        Me.lblIRangoMedicos.Size = New System.Drawing.Size(147, 20)
        Me.lblIRangoMedicos.TabIndex = 21
        Me.lblIRangoMedicos.Text = "IP APP Medicos"
        Me.lblIRangoMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIpGestor
        '
        Me.lblIpGestor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblIpGestor.Location = New System.Drawing.Point(16, 295)
        Me.lblIpGestor.Name = "lblIpGestor"
        Me.lblIpGestor.Size = New System.Drawing.Size(141, 20)
        Me.lblIpGestor.TabIndex = 16
        Me.lblIpGestor.Text = "IP Gestion"
        Me.lblIpGestor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIPConexiones
        '
        Me.lblIPConexiones.Location = New System.Drawing.Point(20, 259)
        Me.lblIPConexiones.Name = "lblIPConexiones"
        Me.lblIPConexiones.Size = New System.Drawing.Size(702, 30)
        Me.lblIPConexiones.TabIndex = 15
        Me.lblIPConexiones.Text = "Configuracion de direcciones IP de conexion para las difentes aplicaciones"
        '
        'lblTituloIP
        '
        Me.lblTituloIP.AutoSize = True
        Me.lblTituloIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloIP.Location = New System.Drawing.Point(20, 232)
        Me.lblTituloIP.Name = "lblTituloIP"
        Me.lblTituloIP.Size = New System.Drawing.Size(122, 24)
        Me.lblTituloIP.TabIndex = 14
        Me.lblTituloIP.Text = "Conexiones"
        '
        'txtCantSintomas
        '
        Me.txtCantSintomas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCantSintomas.Location = New System.Drawing.Point(114, 192)
        Me.txtCantSintomas.Name = "txtCantSintomas"
        Me.txtCantSintomas.Size = New System.Drawing.Size(91, 27)
        Me.txtCantSintomas.TabIndex = 13
        Me.txtCantSintomas.Text = "0"
        Me.txtCantSintomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCantidad
        '
        Me.lblCantidad.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCantidad.Location = New System.Drawing.Point(23, 192)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(80, 20)
        Me.lblCantidad.TabIndex = 12
        Me.lblCantidad.Text = "Cantidad:"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTitleCantSintomas
        '
        Me.lblSubTitleCantSintomas.Location = New System.Drawing.Point(20, 162)
        Me.lblSubTitleCantSintomas.Name = "lblSubTitleCantSintomas"
        Me.lblSubTitleCantSintomas.Size = New System.Drawing.Size(702, 30)
        Me.lblSubTitleCantSintomas.TabIndex = 11
        Me.lblSubTitleCantSintomas.Text = "Cantidad minima de sintomas que debe indicar un paciente para recibir un diagnost" &
    "ico"
        '
        'lblTituloCantSintomas
        '
        Me.lblTituloCantSintomas.AutoSize = True
        Me.lblTituloCantSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloCantSintomas.Location = New System.Drawing.Point(20, 136)
        Me.lblTituloCantSintomas.Name = "lblTituloCantSintomas"
        Me.lblTituloCantSintomas.Size = New System.Drawing.Size(95, 24)
        Me.lblTituloCantSintomas.TabIndex = 10
        Me.lblTituloCantSintomas.Text = "Sintomas"
        '
        'cbLenguaje
        '
        Me.cbLenguaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLenguaje.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cbLenguaje.FormattingEnabled = True
        Me.cbLenguaje.Location = New System.Drawing.Point(114, 88)
        Me.cbLenguaje.Name = "cbLenguaje"
        Me.cbLenguaje.Size = New System.Drawing.Size(93, 28)
        Me.cbLenguaje.TabIndex = 7
        '
        'lblLenguaje
        '
        Me.lblLenguaje.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblLenguaje.Location = New System.Drawing.Point(21, 92)
        Me.lblLenguaje.Name = "lblLenguaje"
        Me.lblLenguaje.Size = New System.Drawing.Size(82, 20)
        Me.lblLenguaje.TabIndex = 6
        Me.lblLenguaje.Text = "Lenguaje:"
        Me.lblLenguaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescIdiomaSistema
        '
        Me.lblDescIdiomaSistema.Location = New System.Drawing.Point(20, 60)
        Me.lblDescIdiomaSistema.Name = "lblDescIdiomaSistema"
        Me.lblDescIdiomaSistema.Size = New System.Drawing.Size(702, 30)
        Me.lblDescIdiomaSistema.TabIndex = 5
        Me.lblDescIdiomaSistema.Text = "Idioma del sistema, este cambio requiere reiniciar la aplicacion."
        '
        'lblLengSistema
        '
        Me.lblLengSistema.AutoSize = True
        Me.lblLengSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLengSistema.Location = New System.Drawing.Point(20, 33)
        Me.lblLengSistema.Name = "lblLengSistema"
        Me.lblLengSistema.Size = New System.Drawing.Size(186, 24)
        Me.lblLengSistema.TabIndex = 4
        Me.lblLengSistema.Text = "Idioma del Sistema"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(631, 674)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(134, 47)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Button1"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(21, 677)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(134, 47)
        Me.btnAplicar.TabIndex = 7
        Me.btnAplicar.Text = "Button1"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'gbEmail
        '
        Me.gbEmail.Controls.Add(Me.txtEmailCredencial)
        Me.gbEmail.Controls.Add(Me.lblEmailCredencial)
        Me.gbEmail.Controls.Add(Me.chkEmailSSL)
        Me.gbEmail.Controls.Add(Me.txtServidorSMTP)
        Me.gbEmail.Controls.Add(Me.lblEmailServidorSMTP)
        Me.gbEmail.Controls.Add(Me.txtEmailPuerto)
        Me.gbEmail.Controls.Add(Me.lblEmailPuerto)
        Me.gbEmail.Controls.Add(Me.txtEmailContacto)
        Me.gbEmail.Controls.Add(Me.lblEmailContacto)
        Me.gbEmail.Controls.Add(Me.lblSubTituloEmail)
        Me.gbEmail.Enabled = False
        Me.gbEmail.Location = New System.Drawing.Point(21, 492)
        Me.gbEmail.Name = "gbEmail"
        Me.gbEmail.Size = New System.Drawing.Size(744, 175)
        Me.gbEmail.TabIndex = 8
        Me.gbEmail.TabStop = False
        Me.gbEmail.Text = "GroupBox1"
        '
        'txtEmailCredencial
        '
        Me.txtEmailCredencial.Location = New System.Drawing.Point(423, 133)
        Me.txtEmailCredencial.Name = "txtEmailCredencial"
        Me.txtEmailCredencial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmailCredencial.Size = New System.Drawing.Size(198, 27)
        Me.txtEmailCredencial.TabIndex = 52
        '
        'lblEmailCredencial
        '
        Me.lblEmailCredencial.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblEmailCredencial.Location = New System.Drawing.Point(292, 133)
        Me.lblEmailCredencial.Name = "lblEmailCredencial"
        Me.lblEmailCredencial.Size = New System.Drawing.Size(122, 20)
        Me.lblEmailCredencial.TabIndex = 51
        Me.lblEmailCredencial.Text = "Credencial"
        Me.lblEmailCredencial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkEmailSSL
        '
        Me.chkEmailSSL.AutoSize = True
        Me.chkEmailSSL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEmailSSL.ForeColor = System.Drawing.SystemColors.Highlight
        Me.chkEmailSSL.Location = New System.Drawing.Point(117, 133)
        Me.chkEmailSSL.Name = "chkEmailSSL"
        Me.chkEmailSSL.Size = New System.Drawing.Size(88, 24)
        Me.chkEmailSSL.TabIndex = 50
        Me.chkEmailSSL.Text = "SSL     "
        Me.chkEmailSSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEmailSSL.UseVisualStyleBackColor = True
        '
        'txtServidorSMTP
        '
        Me.txtServidorSMTP.Location = New System.Drawing.Point(423, 98)
        Me.txtServidorSMTP.Name = "txtServidorSMTP"
        Me.txtServidorSMTP.Size = New System.Drawing.Size(198, 27)
        Me.txtServidorSMTP.TabIndex = 49
        '
        'lblEmailServidorSMTP
        '
        Me.lblEmailServidorSMTP.AutoSize = True
        Me.lblEmailServidorSMTP.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblEmailServidorSMTP.Location = New System.Drawing.Point(292, 101)
        Me.lblEmailServidorSMTP.Name = "lblEmailServidorSMTP"
        Me.lblEmailServidorSMTP.Size = New System.Drawing.Size(122, 20)
        Me.lblEmailServidorSMTP.TabIndex = 48
        Me.lblEmailServidorSMTP.Text = "Servidor SMTP"
        '
        'txtEmailPuerto
        '
        Me.txtEmailPuerto.Location = New System.Drawing.Point(188, 98)
        Me.txtEmailPuerto.Name = "txtEmailPuerto"
        Me.txtEmailPuerto.Size = New System.Drawing.Size(70, 27)
        Me.txtEmailPuerto.TabIndex = 47
        Me.txtEmailPuerto.Text = "0"
        Me.txtEmailPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmailPuerto
        '
        Me.lblEmailPuerto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblEmailPuerto.Location = New System.Drawing.Point(20, 101)
        Me.lblEmailPuerto.Name = "lblEmailPuerto"
        Me.lblEmailPuerto.Size = New System.Drawing.Size(143, 20)
        Me.lblEmailPuerto.TabIndex = 46
        Me.lblEmailPuerto.Text = "Puerto STMP"
        Me.lblEmailPuerto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmailContacto
        '
        Me.txtEmailContacto.Location = New System.Drawing.Point(187, 63)
        Me.txtEmailContacto.Name = "txtEmailContacto"
        Me.txtEmailContacto.Size = New System.Drawing.Size(434, 27)
        Me.txtEmailContacto.TabIndex = 45
        '
        'lblEmailContacto
        '
        Me.lblEmailContacto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblEmailContacto.Location = New System.Drawing.Point(12, 66)
        Me.lblEmailContacto.Name = "lblEmailContacto"
        Me.lblEmailContacto.Size = New System.Drawing.Size(151, 20)
        Me.lblEmailContacto.TabIndex = 44
        Me.lblEmailContacto.Text = "Email de contacto"
        Me.lblEmailContacto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTituloEmail
        '
        Me.lblSubTituloEmail.Location = New System.Drawing.Point(15, 28)
        Me.lblSubTituloEmail.Name = "lblSubTituloEmail"
        Me.lblSubTituloEmail.Size = New System.Drawing.Size(702, 30)
        Me.lblSubTituloEmail.TabIndex = 43
        Me.lblSubTituloEmail.Text = "Guarda la configuaracion necesaria para el envio de Email desde la app medico"
        '
        'chkConfigurarEmail
        '
        Me.chkConfigurarEmail.AutoSize = True
        Me.chkConfigurarEmail.Location = New System.Drawing.Point(22, 462)
        Me.chkConfigurarEmail.Name = "chkConfigurarEmail"
        Me.chkConfigurarEmail.Size = New System.Drawing.Size(156, 24)
        Me.chkConfigurarEmail.TabIndex = 9
        Me.chkConfigurarEmail.Text = "Configurar Email"
        Me.chkConfigurarEmail.UseVisualStyleBackColor = True
        '
        'txtIpGestion
        '
        Me.txtIpGestion.Location = New System.Drawing.Point(173, 292)
        Me.txtIpGestion.MaxLength = 15
        Me.txtIpGestion.Name = "txtIpGestion"
        Me.txtIpGestion.Size = New System.Drawing.Size(143, 27)
        Me.txtIpGestion.TabIndex = 27
        Me.txtIpGestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIpMedicos
        '
        Me.txtIpMedicos.Location = New System.Drawing.Point(499, 292)
        Me.txtIpMedicos.MaxLength = 15
        Me.txtIpMedicos.Name = "txtIpMedicos"
        Me.txtIpMedicos.Size = New System.Drawing.Size(143, 27)
        Me.txtIpMedicos.TabIndex = 28
        Me.txtIpMedicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIpPacientes
        '
        Me.txtIpPacientes.Location = New System.Drawing.Point(173, 329)
        Me.txtIpPacientes.MaxLength = 15
        Me.txtIpPacientes.Name = "txtIpPacientes"
        Me.txtIpPacientes.Size = New System.Drawing.Size(143, 27)
        Me.txtIpPacientes.TabIndex = 29
        Me.txtIpPacientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 731)
        Me.Controls.Add(Me.chkConfigurarEmail)
        Me.Controls.Add(Me.gbEmail)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbParametros)
        Me.Controls.Add(Me.picEncabezado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmParametros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmParametros"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbParametros.ResumeLayout(False)
        Me.gbParametros.PerformLayout()
        Me.gbEmail.ResumeLayout(False)
        Me.gbEmail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents gbParametros As GroupBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblLengSistema As Label
    Friend WithEvents lblDescIdiomaSistema As Label
    Friend WithEvents lblLenguaje As Label
    Friend WithEvents cbLenguaje As ComboBox
    Friend WithEvents lblIPConexiones As Label
    Friend WithEvents lblTituloIP As Label
    Friend WithEvents txtCantSintomas As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblSubTitleCantSintomas As Label
    Friend WithEvents lblTituloCantSintomas As Label
    Friend WithEvents lblIpGestor As Label
    Friend WithEvents lblIRangoMedicos As Label
    Friend WithEvents lblIpAppPaciente As Label
    Friend WithEvents btnAplicar As Button
    Friend WithEvents gbEmail As GroupBox
    Friend WithEvents txtEmailCredencial As TextBox
    Friend WithEvents lblEmailCredencial As Label
    Friend WithEvents chkEmailSSL As CheckBox
    Friend WithEvents txtServidorSMTP As TextBox
    Friend WithEvents lblEmailServidorSMTP As Label
    Friend WithEvents txtEmailPuerto As TextBox
    Friend WithEvents lblEmailPuerto As Label
    Friend WithEvents txtEmailContacto As TextBox
    Friend WithEvents lblEmailContacto As Label
    Friend WithEvents lblSubTituloEmail As Label
    Friend WithEvents chkConfigurarEmail As CheckBox
    Friend WithEvents txtIpPacientes As TextBox
    Friend WithEvents txtIpMedicos As TextBox
    Friend WithEvents txtIpGestion As TextBox
End Class
