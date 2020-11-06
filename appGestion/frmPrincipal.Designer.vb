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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmAdministrativos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAdministrativo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmListaAdministrativos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmParametros = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCambioPass = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmMedicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmMedico = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmListaMedicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPaciente = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmListaPacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDiagnosticos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPatologias = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmListaPatologias = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmSintomas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmListaSintomas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmImportarDatosCSV = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmInformes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSintomasNSeleccionados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRankingPat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInformeDiagnosticos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInformeDeChat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInformeChatMeses = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInformechatMes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmVerAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAcercade = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnVerMedico = New System.Windows.Forms.ToolStripButton()
        Me.BtnVerUsuario = New System.Windows.Forms.ToolStripButton()
        Me.btnVerPatologia = New System.Windows.Forms.ToolStripButton()
        Me.btnVerInforme = New System.Windows.Forms.ToolStripButton()
        Me.barraEstado = New System.Windows.Forms.StatusStrip()
        Me.tssLabelEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssLabelGestor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssLabelServidor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssServidorIp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssDBaseLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssBaseDeDatos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.barraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAdministrativos, Me.tsmMedicos, Me.tsmPacientes, Me.tsmDiagnosticos, Me.tsmInformes, Me.tsmAyuda})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1014, 31)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'tsmAdministrativos
        '
        Me.tsmAdministrativos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAdministrativo, Me.tsmListaAdministrativos, Me.tsmParametros, Me.tsmCambioPass, Me.ToolStripSeparator1, Me.tsmSalir})
        Me.tsmAdministrativos.Name = "tsmAdministrativos"
        Me.tsmAdministrativos.Size = New System.Drawing.Size(136, 27)
        Me.tsmAdministrativos.Text = "&Administrativo"
        '
        'tsmAdministrativo
        '
        Me.tsmAdministrativo.Image = CType(resources.GetObject("tsmAdministrativo.Image"), System.Drawing.Image)
        Me.tsmAdministrativo.Name = "tsmAdministrativo"
        Me.tsmAdministrativo.Size = New System.Drawing.Size(266, 28)
        Me.tsmAdministrativo.Text = "Administrativo"
        '
        'tsmListaAdministrativos
        '
        Me.tsmListaAdministrativos.Image = Global.appGestion.My.Resources.Resources.listarTodos
        Me.tsmListaAdministrativos.Name = "tsmListaAdministrativos"
        Me.tsmListaAdministrativos.Size = New System.Drawing.Size(266, 28)
        Me.tsmListaAdministrativos.Text = "Listar Administrativos"
        '
        'tsmParametros
        '
        Me.tsmParametros.Image = CType(resources.GetObject("tsmParametros.Image"), System.Drawing.Image)
        Me.tsmParametros.Name = "tsmParametros"
        Me.tsmParametros.Size = New System.Drawing.Size(266, 28)
        Me.tsmParametros.Text = "Parametros del sistema"
        '
        'tsmCambioPass
        '
        Me.tsmCambioPass.Image = CType(resources.GetObject("tsmCambioPass.Image"), System.Drawing.Image)
        Me.tsmCambioPass.Name = "tsmCambioPass"
        Me.tsmCambioPass.Size = New System.Drawing.Size(266, 28)
        Me.tsmCambioPass.Text = "Cambio de contraseña"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(263, 6)
        '
        'tsmSalir
        '
        Me.tsmSalir.Image = CType(resources.GetObject("tsmSalir.Image"), System.Drawing.Image)
        Me.tsmSalir.Name = "tsmSalir"
        Me.tsmSalir.Size = New System.Drawing.Size(266, 28)
        Me.tsmSalir.Text = "Salir"
        '
        'tsmMedicos
        '
        Me.tsmMedicos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmMedico, Me.tsmListaMedicos})
        Me.tsmMedicos.Name = "tsmMedicos"
        Me.tsmMedicos.Size = New System.Drawing.Size(87, 27)
        Me.tsmMedicos.Text = "&Medicos"
        '
        'tsmMedico
        '
        Me.tsmMedico.Image = CType(resources.GetObject("tsmMedico.Image"), System.Drawing.Image)
        Me.tsmMedico.Name = "tsmMedico"
        Me.tsmMedico.Size = New System.Drawing.Size(196, 28)
        Me.tsmMedico.Text = "Medico"
        '
        'tsmListaMedicos
        '
        Me.tsmListaMedicos.Image = CType(resources.GetObject("tsmListaMedicos.Image"), System.Drawing.Image)
        Me.tsmListaMedicos.Name = "tsmListaMedicos"
        Me.tsmListaMedicos.Size = New System.Drawing.Size(196, 28)
        Me.tsmListaMedicos.Text = "Listar medicos"
        '
        'tsmPacientes
        '
        Me.tsmPacientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmPaciente, Me.tsmListaPacientes})
        Me.tsmPacientes.Name = "tsmPacientes"
        Me.tsmPacientes.Size = New System.Drawing.Size(95, 27)
        Me.tsmPacientes.Text = "&Pacientes"
        '
        'tsmPaciente
        '
        Me.tsmPaciente.Image = CType(resources.GetObject("tsmPaciente.Image"), System.Drawing.Image)
        Me.tsmPaciente.Name = "tsmPaciente"
        Me.tsmPaciente.Size = New System.Drawing.Size(205, 28)
        Me.tsmPaciente.Text = "Paciente"
        '
        'tsmListaPacientes
        '
        Me.tsmListaPacientes.Image = CType(resources.GetObject("tsmListaPacientes.Image"), System.Drawing.Image)
        Me.tsmListaPacientes.Name = "tsmListaPacientes"
        Me.tsmListaPacientes.Size = New System.Drawing.Size(205, 28)
        Me.tsmListaPacientes.Text = "Listar pacientes"
        '
        'tsmDiagnosticos
        '
        Me.tsmDiagnosticos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmPatologias, Me.tsmListaPatologias, Me.ToolStripSeparator2, Me.tsmSintomas, Me.tsmListaSintomas, Me.ToolStripSeparator3, Me.tsmImportarDatosCSV, Me.ToolStripSeparator4})
        Me.tsmDiagnosticos.Name = "tsmDiagnosticos"
        Me.tsmDiagnosticos.Size = New System.Drawing.Size(121, 27)
        Me.tsmDiagnosticos.Text = "&Diagnosticos"
        '
        'tsmPatologias
        '
        Me.tsmPatologias.Image = CType(resources.GetObject("tsmPatologias.Image"), System.Drawing.Image)
        Me.tsmPatologias.Name = "tsmPatologias"
        Me.tsmPatologias.Size = New System.Drawing.Size(251, 28)
        Me.tsmPatologias.Text = "Patologias"
        '
        'tsmListaPatologias
        '
        Me.tsmListaPatologias.Image = CType(resources.GetObject("tsmListaPatologias.Image"), System.Drawing.Image)
        Me.tsmListaPatologias.Name = "tsmListaPatologias"
        Me.tsmListaPatologias.Size = New System.Drawing.Size(251, 28)
        Me.tsmListaPatologias.Text = "Listar patologias"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(248, 6)
        '
        'tsmSintomas
        '
        Me.tsmSintomas.Image = CType(resources.GetObject("tsmSintomas.Image"), System.Drawing.Image)
        Me.tsmSintomas.Name = "tsmSintomas"
        Me.tsmSintomas.Size = New System.Drawing.Size(251, 28)
        Me.tsmSintomas.Text = "Sintomas"
        '
        'tsmListaSintomas
        '
        Me.tsmListaSintomas.Image = CType(resources.GetObject("tsmListaSintomas.Image"), System.Drawing.Image)
        Me.tsmListaSintomas.Name = "tsmListaSintomas"
        Me.tsmListaSintomas.Size = New System.Drawing.Size(251, 28)
        Me.tsmListaSintomas.Text = "Listar sintomas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(248, 6)
        '
        'tsmImportarDatosCSV
        '
        Me.tsmImportarDatosCSV.Name = "tsmImportarDatosCSV"
        Me.tsmImportarDatosCSV.Size = New System.Drawing.Size(251, 28)
        Me.tsmImportarDatosCSV.Text = "Importar archivo CVS"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(248, 6)
        '
        'tsmInformes
        '
        Me.tsmInformes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSintomasNSeleccionados, Me.tsmRankingPat, Me.tsmInformeDiagnosticos, Me.tsmInformeDeChat})
        Me.tsmInformes.Name = "tsmInformes"
        Me.tsmInformes.Size = New System.Drawing.Size(93, 27)
        Me.tsmInformes.Text = "&Informes"
        '
        'tsmSintomasNSeleccionados
        '
        Me.tsmSintomasNSeleccionados.Image = Global.appGestion.My.Resources.Resources.list
        Me.tsmSintomasNSeleccionados.Name = "tsmSintomasNSeleccionados"
        Me.tsmSintomasNSeleccionados.Size = New System.Drawing.Size(319, 28)
        Me.tsmSintomasNSeleccionados.Text = "Sintomas nunca seleccionados"
        '
        'tsmRankingPat
        '
        Me.tsmRankingPat.Image = CType(resources.GetObject("tsmRankingPat.Image"), System.Drawing.Image)
        Me.tsmRankingPat.Name = "tsmRankingPat"
        Me.tsmRankingPat.Size = New System.Drawing.Size(319, 28)
        Me.tsmRankingPat.Text = "Ranking de patologias "
        '
        'tsmInformeDiagnosticos
        '
        Me.tsmInformeDiagnosticos.Image = Global.appGestion.My.Resources.Resources.grafico
        Me.tsmInformeDiagnosticos.Name = "tsmInformeDiagnosticos"
        Me.tsmInformeDiagnosticos.Size = New System.Drawing.Size(319, 28)
        Me.tsmInformeDiagnosticos.Text = "Diagnosticos otorgados"
        '
        'tsmInformeDeChat
        '
        Me.tsmInformeDeChat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmInformeChatMeses, Me.tsmInformechatMes})
        Me.tsmInformeDeChat.Image = Global.appGestion.My.Resources.Resources.grafico
        Me.tsmInformeDeChat.Name = "tsmInformeDeChat"
        Me.tsmInformeDeChat.Size = New System.Drawing.Size(319, 28)
        Me.tsmInformeDeChat.Text = "Cantidad de chat"
        '
        'tsmInformeChatMeses
        '
        Me.tsmInformeChatMeses.Image = Global.appGestion.My.Resources.Resources.grafico
        Me.tsmInformeChatMeses.Name = "tsmInformeChatMeses"
        Me.tsmInformeChatMeses.Size = New System.Drawing.Size(286, 28)
        Me.tsmInformeChatMeses.Text = "Ultimos 12 meses moviles"
        '
        'tsmInformechatMes
        '
        Me.tsmInformechatMes.Image = Global.appGestion.My.Resources.Resources.grafico
        Me.tsmInformechatMes.Name = "tsmInformechatMes"
        Me.tsmInformechatMes.Size = New System.Drawing.Size(286, 28)
        Me.tsmInformechatMes.Text = "Por Mes"
        '
        'tsmAyuda
        '
        Me.tsmAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmVerAyuda, Me.tsmAcercade})
        Me.tsmAyuda.Name = "tsmAyuda"
        Me.tsmAyuda.Size = New System.Drawing.Size(71, 27)
        Me.tsmAyuda.Text = "&Ayuda"
        '
        'tsmVerAyuda
        '
        Me.tsmVerAyuda.Name = "tsmVerAyuda"
        Me.tsmVerAyuda.Size = New System.Drawing.Size(176, 28)
        Me.tsmVerAyuda.Text = "Ayuda"
        '
        'tsmAcercade
        '
        Me.tsmAcercade.Name = "tsmAcercade"
        Me.tsmAcercade.Size = New System.Drawing.Size(176, 28)
        Me.tsmAcercade.Text = "Acerca de..."
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnVerMedico, Me.BtnVerUsuario, Me.btnVerPatologia, Me.btnVerInforme})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 31)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1014, 77)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'btnVerMedico
        '
        Me.btnVerMedico.Image = CType(resources.GetObject("btnVerMedico.Image"), System.Drawing.Image)
        Me.btnVerMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnVerMedico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerMedico.Name = "btnVerMedico"
        Me.btnVerMedico.Size = New System.Drawing.Size(88, 74)
        Me.btnVerMedico.Text = "Ver Medico"
        Me.btnVerMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnVerUsuario
        '
        Me.BtnVerUsuario.Image = CType(resources.GetObject("BtnVerUsuario.Image"), System.Drawing.Image)
        Me.BtnVerUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVerUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnVerUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnVerUsuario.Name = "BtnVerUsuario"
        Me.BtnVerUsuario.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.BtnVerUsuario.Size = New System.Drawing.Size(88, 74)
        Me.BtnVerUsuario.Text = "Ver Usuario"
        Me.BtnVerUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnVerPatologia
        '
        Me.btnVerPatologia.Image = CType(resources.GetObject("btnVerPatologia.Image"), System.Drawing.Image)
        Me.btnVerPatologia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnVerPatologia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerPatologia.Name = "btnVerPatologia"
        Me.btnVerPatologia.Size = New System.Drawing.Size(101, 74)
        Me.btnVerPatologia.Text = "Ver Patologia"
        Me.btnVerPatologia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVerPatologia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnVerInforme
        '
        Me.btnVerInforme.Image = CType(resources.GetObject("btnVerInforme.Image"), System.Drawing.Image)
        Me.btnVerInforme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnVerInforme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerInforme.Name = "btnVerInforme"
        Me.btnVerInforme.Size = New System.Drawing.Size(84, 74)
        Me.btnVerInforme.Text = "Informes"
        Me.btnVerInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'barraEstado
        '
        Me.barraEstado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.barraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLabelEstado, Me.tssLabelGestor, Me.tssLabelServidor, Me.tssServidorIp, Me.tssDBaseLabel, Me.tssBaseDeDatos})
        Me.barraEstado.Location = New System.Drawing.Point(0, 637)
        Me.barraEstado.Name = "barraEstado"
        Me.barraEstado.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.barraEstado.Size = New System.Drawing.Size(1014, 25)
        Me.barraEstado.TabIndex = 7
        Me.barraEstado.Text = "StatusStrip"
        '
        'tssLabelEstado
        '
        Me.tssLabelEstado.Name = "tssLabelEstado"
        Me.tssLabelEstado.Size = New System.Drawing.Size(62, 20)
        Me.tssLabelEstado.Text = "Usuario:"
        '
        'tssLabelGestor
        '
        Me.tssLabelGestor.Name = "tssLabelGestor"
        Me.tssLabelGestor.Size = New System.Drawing.Size(0, 20)
        '
        'tssLabelServidor
        '
        Me.tssLabelServidor.AutoSize = False
        Me.tssLabelServidor.Name = "tssLabelServidor"
        Me.tssLabelServidor.Size = New System.Drawing.Size(150, 20)
        Me.tssLabelServidor.Text = "Servidor"
        Me.tssLabelServidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tssServidorIp
        '
        Me.tssServidorIp.Name = "tssServidorIp"
        Me.tssServidorIp.Size = New System.Drawing.Size(0, 20)
        '
        'tssDBaseLabel
        '
        Me.tssDBaseLabel.AutoSize = False
        Me.tssDBaseLabel.Name = "tssDBaseLabel"
        Me.tssDBaseLabel.Size = New System.Drawing.Size(150, 20)
        Me.tssDBaseLabel.Text = "Base de datos"
        Me.tssDBaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tssBaseDeDatos
        '
        Me.tssBaseDeDatos.Name = "tssBaseDeDatos"
        Me.tssBaseDeDatos.Size = New System.Drawing.Size(0, 20)
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1014, 662)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.barraEstado)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrincipal"
        Me.Text = "TRIAGE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.barraEstado.ResumeLayout(False)
        Me.barraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents barraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmAdministrativos As ToolStripMenuItem
    Friend WithEvents tsmAdministrativo As ToolStripMenuItem
    Friend WithEvents tsmParametros As ToolStripMenuItem
    Friend WithEvents tsmCambioPass As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmSalir As ToolStripMenuItem
    Friend WithEvents tsmMedicos As ToolStripMenuItem
    Friend WithEvents tsmPacientes As ToolStripMenuItem
    Friend WithEvents tsmDiagnosticos As ToolStripMenuItem
    Friend WithEvents tsmInformes As ToolStripMenuItem
    Friend WithEvents tsmAyuda As ToolStripMenuItem
    Friend WithEvents tsmMedico As ToolStripMenuItem
    Friend WithEvents tsmListaMedicos As ToolStripMenuItem
    Friend WithEvents tsmPaciente As ToolStripMenuItem
    Friend WithEvents tsmListaPacientes As ToolStripMenuItem
    Friend WithEvents tsmPatologias As ToolStripMenuItem
    Friend WithEvents tsmListaPatologias As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmSintomas As ToolStripMenuItem
    Friend WithEvents tsmListaSintomas As ToolStripMenuItem
    Friend WithEvents btnVerMedico As ToolStripButton
    Friend WithEvents BtnVerUsuario As ToolStripButton
    Friend WithEvents btnVerPatologia As ToolStripButton
    Friend WithEvents btnVerInforme As ToolStripButton
    Friend WithEvents tsmRankingPat As ToolStripMenuItem
    Friend WithEvents tsmInformeDiagnosticos As ToolStripMenuItem
    Friend WithEvents tsmAcercade As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsmImportarDatosCSV As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tssLabelGestor As ToolStripStatusLabel
    Friend WithEvents tsmInformeDeChat As ToolStripMenuItem
    Friend WithEvents tsmInformeChatMeses As ToolStripMenuItem
    Friend WithEvents tsmInformechatMes As ToolStripMenuItem
    Friend WithEvents tsmVerAyuda As ToolStripMenuItem
    Friend WithEvents tsmListaAdministrativos As ToolStripMenuItem
    Friend WithEvents tssLabelServidor As ToolStripStatusLabel
    Friend WithEvents tssServidorIp As ToolStripStatusLabel
    Friend WithEvents tssDBaseLabel As ToolStripStatusLabel
    Friend WithEvents tssBaseDeDatos As ToolStripStatusLabel
    Friend WithEvents tssLabelEstado As ToolStripStatusLabel
    Friend WithEvents tsmSintomasNSeleccionados As ToolStripMenuItem
End Class
