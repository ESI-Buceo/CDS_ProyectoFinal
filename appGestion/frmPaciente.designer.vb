<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaciente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabOpcionesPaciente = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.btnRestPass = New System.Windows.Forms.Button()
        Me.btnEliminarEnfermedad = New System.Windows.Forms.Button()
        Me.btnAgregarEnfermedad = New System.Windows.Forms.Button()
        Me.dgvListaPreExistentes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEnfermedades = New System.Windows.Forms.Label()
        Me.btnEliminarTelefono = New System.Windows.Forms.Button()
        Me.btnAgregarTelefono = New System.Windows.Forms.Button()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.dgvListaTelefonos = New System.Windows.Forms.DataGridView()
        Me.colTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtEsquina = New System.Windows.Forms.TextBox()
        Me.txtApto = New System.Windows.Forms.TextBox()
        Me.txtNumeroCalle = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblOtrosDatos = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtFechaRegistro = New System.Windows.Forms.TextBox()
        Me.txtDocIdentidad = New System.Windows.Forms.TextBox()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.lblEmailM = New System.Windows.Forms.Label()
        Me.lblFechaNacM = New System.Windows.Forms.Label()
        Me.lblBarrioM = New System.Windows.Forms.Label()
        Me.lblEsquinaM = New System.Windows.Forms.Label()
        Me.lblAptoM = New System.Windows.Forms.Label()
        Me.lblNumeroCalleM = New System.Windows.Forms.Label()
        Me.lblDireccionM = New System.Windows.Forms.Label()
        Me.lblApellidosM = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblFechaReg = New System.Windows.Forms.Label()
        Me.lblDocIdentidad = New System.Windows.Forms.Label()
        Me.tabBusqueda = New System.Windows.Forms.TabPage()
        Me.dgvListaPacientes = New System.Windows.Forms.DataGridView()
        Me.colDocIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabHistoria = New System.Windows.Forms.TabPage()
        Me.gbVerChat = New System.Windows.Forms.GroupBox()
        Me.rtbMensajes = New System.Windows.Forms.RichTextBox()
        Me.gbHistoricoChats = New System.Windows.Forms.GroupBox()
        Me.dgvHistoriaChat = New System.Windows.Forms.DataGridView()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDSesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbEstadisticas = New System.Windows.Forms.GroupBox()
        Me.txtCantChat = New System.Windows.Forms.TextBox()
        Me.lblDetChatRealizados = New System.Windows.Forms.Label()
        Me.lblChats = New System.Windows.Forms.Label()
        Me.txtCantDiag = New System.Windows.Forms.TextBox()
        Me.lblDescCantDiag = New System.Windows.Forms.Label()
        Me.lblDiagnosticos = New System.Windows.Forms.Label()
        Me.toolsMenuPaciente = New System.Windows.Forms.ToolStrip()
        Me.mnuBtnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeperador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnNueva = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tabSeparador4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBtnReactivar = New System.Windows.Forms.ToolStripButton()
        Me.mnuBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.tabOpcionesPaciente.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        CType(Me.dgvListaPreExistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBusqueda.SuspendLayout()
        CType(Me.dgvListaPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistoria.SuspendLayout()
        Me.gbVerChat.SuspendLayout()
        Me.gbHistoricoChats.SuspendLayout()
        CType(Me.dgvHistoriaChat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEstadisticas.SuspendLayout()
        Me.toolsMenuPaciente.SuspendLayout()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabOpcionesPaciente
        '
        Me.tabOpcionesPaciente.Controls.Add(Me.tabDatos)
        Me.tabOpcionesPaciente.Controls.Add(Me.tabBusqueda)
        Me.tabOpcionesPaciente.Controls.Add(Me.tabHistoria)
        Me.tabOpcionesPaciente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOpcionesPaciente.Location = New System.Drawing.Point(27, 127)
        Me.tabOpcionesPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabOpcionesPaciente.Name = "tabOpcionesPaciente"
        Me.tabOpcionesPaciente.SelectedIndex = 0
        Me.tabOpcionesPaciente.Size = New System.Drawing.Size(956, 537)
        Me.tabOpcionesPaciente.TabIndex = 7
        '
        'tabDatos
        '
        Me.tabDatos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabDatos.Controls.Add(Me.btnRestPass)
        Me.tabDatos.Controls.Add(Me.btnEliminarEnfermedad)
        Me.tabDatos.Controls.Add(Me.btnAgregarEnfermedad)
        Me.tabDatos.Controls.Add(Me.dgvListaPreExistentes)
        Me.tabDatos.Controls.Add(Me.lblEnfermedades)
        Me.tabDatos.Controls.Add(Me.btnEliminarTelefono)
        Me.tabDatos.Controls.Add(Me.btnAgregarTelefono)
        Me.tabDatos.Controls.Add(Me.chkActivo)
        Me.tabDatos.Controls.Add(Me.dtpFechaNac)
        Me.tabDatos.Controls.Add(Me.dgvListaTelefonos)
        Me.tabDatos.Controls.Add(Me.txtBarrio)
        Me.tabDatos.Controls.Add(Me.txtEsquina)
        Me.tabDatos.Controls.Add(Me.txtApto)
        Me.tabDatos.Controls.Add(Me.txtNumeroCalle)
        Me.tabDatos.Controls.Add(Me.txtCalle)
        Me.tabDatos.Controls.Add(Me.lblOtrosDatos)
        Me.tabDatos.Controls.Add(Me.txtEmail)
        Me.tabDatos.Controls.Add(Me.txtApellidos)
        Me.tabDatos.Controls.Add(Me.txtNombres)
        Me.tabDatos.Controls.Add(Me.txtFechaRegistro)
        Me.tabDatos.Controls.Add(Me.txtDocIdentidad)
        Me.tabDatos.Controls.Add(Me.lblTelefonos)
        Me.tabDatos.Controls.Add(Me.lblEmailM)
        Me.tabDatos.Controls.Add(Me.lblFechaNacM)
        Me.tabDatos.Controls.Add(Me.lblBarrioM)
        Me.tabDatos.Controls.Add(Me.lblEsquinaM)
        Me.tabDatos.Controls.Add(Me.lblAptoM)
        Me.tabDatos.Controls.Add(Me.lblNumeroCalleM)
        Me.tabDatos.Controls.Add(Me.lblDireccionM)
        Me.tabDatos.Controls.Add(Me.lblApellidosM)
        Me.tabDatos.Controls.Add(Me.lblNombres)
        Me.tabDatos.Controls.Add(Me.lblFechaReg)
        Me.tabDatos.Controls.Add(Me.lblDocIdentidad)
        Me.tabDatos.Location = New System.Drawing.Point(4, 28)
        Me.tabDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Size = New System.Drawing.Size(948, 505)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Datos"
        '
        'btnRestPass
        '
        Me.btnRestPass.Enabled = False
        Me.btnRestPass.Image = CType(resources.GetObject("btnRestPass.Image"), System.Drawing.Image)
        Me.btnRestPass.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRestPass.Location = New System.Drawing.Point(5, 338)
        Me.btnRestPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRestPass.Name = "btnRestPass"
        Me.btnRestPass.Size = New System.Drawing.Size(157, 89)
        Me.btnRestPass.TabIndex = 85
        Me.btnRestPass.Text = "Restablecer contraseña"
        Me.btnRestPass.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRestPass.UseVisualStyleBackColor = True
        '
        'btnEliminarEnfermedad
        '
        Me.btnEliminarEnfermedad.Enabled = False
        Me.btnEliminarEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarEnfermedad.ForeColor = System.Drawing.Color.Transparent
        Me.btnEliminarEnfermedad.Image = Global.appGestion.My.Resources.Resources.delTel1
        Me.btnEliminarEnfermedad.Location = New System.Drawing.Point(607, 457)
        Me.btnEliminarEnfermedad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarEnfermedad.Name = "btnEliminarEnfermedad"
        Me.btnEliminarEnfermedad.Padding = New System.Windows.Forms.Padding(5)
        Me.btnEliminarEnfermedad.Size = New System.Drawing.Size(44, 37)
        Me.btnEliminarEnfermedad.TabIndex = 27
        Me.btnEliminarEnfermedad.UseVisualStyleBackColor = True
        '
        'btnAgregarEnfermedad
        '
        Me.btnAgregarEnfermedad.Enabled = False
        Me.btnAgregarEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarEnfermedad.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgregarEnfermedad.Image = Global.appGestion.My.Resources.Resources.addTel1
        Me.btnAgregarEnfermedad.Location = New System.Drawing.Point(557, 457)
        Me.btnAgregarEnfermedad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarEnfermedad.Name = "btnAgregarEnfermedad"
        Me.btnAgregarEnfermedad.Padding = New System.Windows.Forms.Padding(5)
        Me.btnAgregarEnfermedad.Size = New System.Drawing.Size(44, 37)
        Me.btnAgregarEnfermedad.TabIndex = 26
        Me.btnAgregarEnfermedad.UseVisualStyleBackColor = True
        '
        'dgvListaPreExistentes
        '
        Me.dgvListaPreExistentes.AllowUserToAddRows = False
        Me.dgvListaPreExistentes.AllowUserToDeleteRows = False
        Me.dgvListaPreExistentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListaPreExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPreExistentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.dgvListaPreExistentes.Location = New System.Drawing.Point(555, 338)
        Me.dgvListaPreExistentes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListaPreExistentes.Name = "dgvListaPreExistentes"
        Me.dgvListaPreExistentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListaPreExistentes.Size = New System.Drawing.Size(353, 112)
        Me.dgvListaPreExistentes.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "preExistentes"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "PRE-EXISTENTES"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'lblEnfermedades
        '
        Me.lblEnfermedades.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfermedades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblEnfermedades.Location = New System.Drawing.Point(553, 306)
        Me.lblEnfermedades.Name = "lblEnfermedades"
        Me.lblEnfermedades.Size = New System.Drawing.Size(355, 21)
        Me.lblEnfermedades.TabIndex = 24
        Me.lblEnfermedades.Text = "ENFERMEDADES"
        Me.lblEnfermedades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEliminarTelefono
        '
        Me.btnEliminarTelefono.Enabled = False
        Me.btnEliminarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarTelefono.ForeColor = System.Drawing.Color.Transparent
        Me.btnEliminarTelefono.Image = Global.appGestion.My.Resources.Resources.delTel1
        Me.btnEliminarTelefono.Location = New System.Drawing.Point(221, 457)
        Me.btnEliminarTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarTelefono.Name = "btnEliminarTelefono"
        Me.btnEliminarTelefono.Padding = New System.Windows.Forms.Padding(5)
        Me.btnEliminarTelefono.Size = New System.Drawing.Size(44, 37)
        Me.btnEliminarTelefono.TabIndex = 23
        Me.btnEliminarTelefono.UseVisualStyleBackColor = True
        '
        'btnAgregarTelefono
        '
        Me.btnAgregarTelefono.Enabled = False
        Me.btnAgregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarTelefono.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgregarTelefono.Image = Global.appGestion.My.Resources.Resources.addTel1
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(171, 457)
        Me.btnAgregarTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Padding = New System.Windows.Forms.Padding(5)
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(44, 37)
        Me.btnAgregarTelefono.TabIndex = 22
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Enabled = False
        Me.chkActivo.Location = New System.Drawing.Point(23, 457)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(75, 23)
        Me.chkActivo.TabIndex = 21
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        Me.chkActivo.Visible = False
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpFechaNac.CalendarMonthBackground = System.Drawing.SystemColors.Highlight
        Me.dtpFechaNac.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpFechaNac.CalendarTrailingForeColor = System.Drawing.Color.Gray
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(780, 15)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(137, 27)
        Me.dtpFechaNac.TabIndex = 3
        '
        'dgvListaTelefonos
        '
        Me.dgvListaTelefonos.AllowUserToAddRows = False
        Me.dgvListaTelefonos.AllowUserToDeleteRows = False
        Me.dgvListaTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListaTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTelefono})
        Me.dgvListaTelefonos.Location = New System.Drawing.Point(171, 338)
        Me.dgvListaTelefonos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListaTelefonos.Name = "dgvListaTelefonos"
        Me.dgvListaTelefonos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListaTelefonos.Size = New System.Drawing.Size(353, 112)
        Me.dgvListaTelefonos.TabIndex = 12
        '
        'colTelefono
        '
        Me.colTelefono.DataPropertyName = "Telefono"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTelefono.DefaultCellStyle = DataGridViewCellStyle2
        Me.colTelefono.HeaderText = "TELEFONOS"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Width = 200
        '
        'txtBarrio
        '
        Me.txtBarrio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBarrio.Location = New System.Drawing.Point(171, 262)
        Me.txtBarrio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBarrio.MaxLength = 30
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(421, 27)
        Me.txtBarrio.TabIndex = 11
        '
        'txtEsquina
        '
        Me.txtEsquina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEsquina.Location = New System.Drawing.Point(453, 224)
        Me.txtEsquina.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEsquina.MaxLength = 40
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.Size = New System.Drawing.Size(455, 27)
        Me.txtEsquina.TabIndex = 10
        '
        'txtApto
        '
        Me.txtApto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApto.Location = New System.Drawing.Point(171, 224)
        Me.txtApto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApto.MaxLength = 11
        Me.txtApto.Name = "txtApto"
        Me.txtApto.Size = New System.Drawing.Size(129, 27)
        Me.txtApto.TabIndex = 9
        Me.txtApto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumeroCalle
        '
        Me.txtNumeroCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNumeroCalle.Location = New System.Drawing.Point(780, 183)
        Me.txtNumeroCalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumeroCalle.MaxLength = 11
        Me.txtNumeroCalle.Name = "txtNumeroCalle"
        Me.txtNumeroCalle.Size = New System.Drawing.Size(129, 27)
        Me.txtNumeroCalle.TabIndex = 8
        Me.txtNumeroCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCalle
        '
        Me.txtCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCalle.Location = New System.Drawing.Point(171, 183)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCalle.MaxLength = 40
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(505, 27)
        Me.txtCalle.TabIndex = 7
        '
        'lblOtrosDatos
        '
        Me.lblOtrosDatos.AutoSize = True
        Me.lblOtrosDatos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtrosDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.lblOtrosDatos.Location = New System.Drawing.Point(47, 149)
        Me.lblOtrosDatos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOtrosDatos.Name = "lblOtrosDatos"
        Me.lblOtrosDatos.Size = New System.Drawing.Size(151, 22)
        Me.lblOtrosDatos.TabIndex = 20
        Me.lblOtrosDatos.Text = "OTROS DATOS"
        '
        'txtEmail
        '
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(171, 95)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(501, 27)
        Me.txtEmail.TabIndex = 6
        '
        'txtApellidos
        '
        Me.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApellidos.Location = New System.Drawing.Point(611, 57)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellidos.MaxLength = 25
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(299, 27)
        Me.txtApellidos.TabIndex = 5
        '
        'txtNombres
        '
        Me.txtNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombres.Location = New System.Drawing.Point(171, 57)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombres.MaxLength = 25
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(299, 27)
        Me.txtNombres.TabIndex = 4
        '
        'txtFechaRegistro
        '
        Me.txtFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaRegistro.Location = New System.Drawing.Point(479, 15)
        Me.txtFechaRegistro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFechaRegistro.MaxLength = 65535
        Me.txtFechaRegistro.Name = "txtFechaRegistro"
        Me.txtFechaRegistro.ReadOnly = True
        Me.txtFechaRegistro.Size = New System.Drawing.Size(139, 27)
        Me.txtFechaRegistro.TabIndex = 1
        Me.txtFechaRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDocIdentidad
        '
        Me.txtDocIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocIdentidad.Enabled = False
        Me.txtDocIdentidad.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocIdentidad.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDocIdentidad.Location = New System.Drawing.Point(171, 15)
        Me.txtDocIdentidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDocIdentidad.MaxLength = 8
        Me.txtDocIdentidad.Name = "txtDocIdentidad"
        Me.txtDocIdentidad.Size = New System.Drawing.Size(159, 27)
        Me.txtDocIdentidad.TabIndex = 0
        Me.txtDocIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTelefonos
        '
        Me.lblTelefonos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTelefonos.Location = New System.Drawing.Point(167, 306)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(357, 21)
        Me.lblTelefonos.TabIndex = 12
        Me.lblTelefonos.Text = "TELEFONOS"
        Me.lblTelefonos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmailM
        '
        Me.lblEmailM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblEmailM.Location = New System.Drawing.Point(19, 96)
        Me.lblEmailM.Name = "lblEmailM"
        Me.lblEmailM.Size = New System.Drawing.Size(145, 25)
        Me.lblEmailM.TabIndex = 10
        Me.lblEmailM.Text = "EMAIL:"
        Me.lblEmailM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaNacM
        '
        Me.lblFechaNacM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblFechaNacM.Location = New System.Drawing.Point(629, 16)
        Me.lblFechaNacM.Name = "lblFechaNacM"
        Me.lblFechaNacM.Size = New System.Drawing.Size(145, 25)
        Me.lblFechaNacM.TabIndex = 9
        Me.lblFechaNacM.Text = "FECHA NAC.:"
        Me.lblFechaNacM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBarrioM
        '
        Me.lblBarrioM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarrioM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblBarrioM.Location = New System.Drawing.Point(19, 263)
        Me.lblBarrioM.Name = "lblBarrioM"
        Me.lblBarrioM.Size = New System.Drawing.Size(145, 25)
        Me.lblBarrioM.TabIndex = 8
        Me.lblBarrioM.Text = "BARRIO:"
        Me.lblBarrioM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEsquinaM
        '
        Me.lblEsquinaM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsquinaM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblEsquinaM.Location = New System.Drawing.Point(303, 225)
        Me.lblEsquinaM.Name = "lblEsquinaM"
        Me.lblEsquinaM.Size = New System.Drawing.Size(145, 25)
        Me.lblEsquinaM.TabIndex = 7
        Me.lblEsquinaM.Text = "ESQUINA:"
        Me.lblEsquinaM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAptoM
        '
        Me.lblAptoM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAptoM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblAptoM.Location = New System.Drawing.Point(19, 225)
        Me.lblAptoM.Name = "lblAptoM"
        Me.lblAptoM.Size = New System.Drawing.Size(145, 25)
        Me.lblAptoM.TabIndex = 6
        Me.lblAptoM.Text = "APTO:"
        Me.lblAptoM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumeroCalleM
        '
        Me.lblNumeroCalleM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCalleM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNumeroCalleM.Location = New System.Drawing.Point(692, 185)
        Me.lblNumeroCalleM.Name = "lblNumeroCalleM"
        Me.lblNumeroCalleM.Size = New System.Drawing.Size(83, 22)
        Me.lblNumeroCalleM.TabIndex = 5
        Me.lblNumeroCalleM.Text = "Nº:"
        Me.lblNumeroCalleM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDireccionM
        '
        Me.lblDireccionM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblDireccionM.Location = New System.Drawing.Point(19, 185)
        Me.lblDireccionM.Name = "lblDireccionM"
        Me.lblDireccionM.Size = New System.Drawing.Size(145, 25)
        Me.lblDireccionM.TabIndex = 4
        Me.lblDireccionM.Text = "DIRECCION:"
        Me.lblDireccionM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellidosM
        '
        Me.lblApellidosM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblApellidosM.Location = New System.Drawing.Point(471, 58)
        Me.lblApellidosM.Name = "lblApellidosM"
        Me.lblApellidosM.Size = New System.Drawing.Size(140, 25)
        Me.lblApellidosM.TabIndex = 3
        Me.lblApellidosM.Text = "APELLIDOS:"
        Me.lblApellidosM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombres
        '
        Me.lblNombres.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNombres.Location = New System.Drawing.Point(19, 58)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(145, 25)
        Me.lblNombres.TabIndex = 2
        Me.lblNombres.Text = "NOMBRES:"
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaReg
        '
        Me.lblFechaReg.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblFechaReg.Location = New System.Drawing.Point(333, 16)
        Me.lblFechaReg.Name = "lblFechaReg"
        Me.lblFechaReg.Size = New System.Drawing.Size(145, 25)
        Me.lblFechaReg.TabIndex = 1
        Me.lblFechaReg.Text = "FECHA:"
        Me.lblFechaReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDocIdentidad
        '
        Me.lblDocIdentidad.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocIdentidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblDocIdentidad.Location = New System.Drawing.Point(19, 16)
        Me.lblDocIdentidad.Name = "lblDocIdentidad"
        Me.lblDocIdentidad.Size = New System.Drawing.Size(145, 25)
        Me.lblDocIdentidad.TabIndex = 0
        Me.lblDocIdentidad.Text = "DOCUMENTO:"
        Me.lblDocIdentidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabBusqueda
        '
        Me.tabBusqueda.BackColor = System.Drawing.Color.Gainsboro
        Me.tabBusqueda.Controls.Add(Me.dgvListaPacientes)
        Me.tabBusqueda.Location = New System.Drawing.Point(4, 28)
        Me.tabBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabBusqueda.Name = "tabBusqueda"
        Me.tabBusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabBusqueda.Size = New System.Drawing.Size(948, 505)
        Me.tabBusqueda.TabIndex = 1
        Me.tabBusqueda.Text = "Busqueda"
        '
        'dgvListaPacientes
        '
        Me.dgvListaPacientes.AllowUserToAddRows = False
        Me.dgvListaPacientes.AllowUserToDeleteRows = False
        Me.dgvListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDocIdentidad, Me.colNombres, Me.colApellidos, Me.colEmail, Me.colFechRegistro, Me.colActivo})
        Me.dgvListaPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaPacientes.Location = New System.Drawing.Point(3, 2)
        Me.dgvListaPacientes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListaPacientes.MultiSelect = False
        Me.dgvListaPacientes.Name = "dgvListaPacientes"
        Me.dgvListaPacientes.ReadOnly = True
        Me.dgvListaPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaPacientes.Size = New System.Drawing.Size(942, 501)
        Me.dgvListaPacientes.TabIndex = 0
        '
        'colDocIdentidad
        '
        Me.colDocIdentidad.DataPropertyName = "DOCUMENTO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDocIdentidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDocIdentidad.HeaderText = "DOCUMENTO"
        Me.colDocIdentidad.Name = "colDocIdentidad"
        Me.colDocIdentidad.ReadOnly = True
        '
        'colNombres
        '
        Me.colNombres.DataPropertyName = "NOMBRES"
        Me.colNombres.HeaderText = "NOMBRES"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.ReadOnly = True
        Me.colNombres.Width = 150
        '
        'colApellidos
        '
        Me.colApellidos.DataPropertyName = "APELLIDOS"
        Me.colApellidos.HeaderText = "APELLIDOS"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.ReadOnly = True
        Me.colApellidos.Width = 150
        '
        'colEmail
        '
        Me.colEmail.DataPropertyName = "EMAIL"
        DataGridViewCellStyle4.NullValue = "yes"
        Me.colEmail.DefaultCellStyle = DataGridViewCellStyle4
        Me.colEmail.HeaderText = "EMAIL"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Width = 200
        '
        'colFechRegistro
        '
        Me.colFechRegistro.DataPropertyName = "FECHREG"
        Me.colFechRegistro.HeaderText = "FECHA REGISTRO"
        Me.colFechRegistro.Name = "colFechRegistro"
        Me.colFechRegistro.ReadOnly = True
        Me.colFechRegistro.Width = 180
        '
        'colActivo
        '
        Me.colActivo.DataPropertyName = "ACTIVO"
        Me.colActivo.HeaderText = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.ReadOnly = True
        Me.colActivo.Visible = False
        '
        'tabHistoria
        '
        Me.tabHistoria.Controls.Add(Me.gbVerChat)
        Me.tabHistoria.Controls.Add(Me.gbHistoricoChats)
        Me.tabHistoria.Controls.Add(Me.gbEstadisticas)
        Me.tabHistoria.Location = New System.Drawing.Point(4, 28)
        Me.tabHistoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabHistoria.Name = "tabHistoria"
        Me.tabHistoria.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabHistoria.Size = New System.Drawing.Size(948, 505)
        Me.tabHistoria.TabIndex = 2
        Me.tabHistoria.Text = "Registros Historicos"
        Me.tabHistoria.UseVisualStyleBackColor = True
        '
        'gbVerChat
        '
        Me.gbVerChat.Controls.Add(Me.rtbMensajes)
        Me.gbVerChat.Location = New System.Drawing.Point(412, 33)
        Me.gbVerChat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbVerChat.Name = "gbVerChat"
        Me.gbVerChat.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbVerChat.Size = New System.Drawing.Size(507, 463)
        Me.gbVerChat.TabIndex = 7
        Me.gbVerChat.TabStop = False
        Me.gbVerChat.Text = "Ver chat"
        '
        'rtbMensajes
        '
        Me.rtbMensajes.BackColor = System.Drawing.Color.White
        Me.rtbMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbMensajes.Location = New System.Drawing.Point(11, 25)
        Me.rtbMensajes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtbMensajes.Name = "rtbMensajes"
        Me.rtbMensajes.Size = New System.Drawing.Size(480, 431)
        Me.rtbMensajes.TabIndex = 0
        Me.rtbMensajes.Text = ""
        '
        'gbHistoricoChats
        '
        Me.gbHistoricoChats.Controls.Add(Me.dgvHistoriaChat)
        Me.gbHistoricoChats.Location = New System.Drawing.Point(17, 212)
        Me.gbHistoricoChats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbHistoricoChats.Name = "gbHistoricoChats"
        Me.gbHistoricoChats.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbHistoricoChats.Size = New System.Drawing.Size(389, 278)
        Me.gbHistoricoChats.TabIndex = 5
        Me.gbHistoricoChats.TabStop = False
        Me.gbHistoricoChats.Text = "Historico de Chats"
        '
        'dgvHistoriaChat
        '
        Me.dgvHistoriaChat.AllowUserToAddRows = False
        Me.dgvHistoriaChat.AllowUserToDeleteRows = False
        Me.dgvHistoriaChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistoriaChat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFecha, Me.colIDSesion, Me.colMedico, Me.colNombre})
        Me.dgvHistoriaChat.Location = New System.Drawing.Point(12, 28)
        Me.dgvHistoriaChat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvHistoriaChat.MultiSelect = False
        Me.dgvHistoriaChat.Name = "dgvHistoriaChat"
        Me.dgvHistoriaChat.ReadOnly = True
        Me.dgvHistoriaChat.RowTemplate.Height = 24
        Me.dgvHistoriaChat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistoriaChat.Size = New System.Drawing.Size(365, 242)
        Me.dgvHistoriaChat.TabIndex = 0
        '
        'colFecha
        '
        Me.colFecha.DataPropertyName = "FechaHora"
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        Me.colFecha.Width = 150
        '
        'colIDSesion
        '
        Me.colIDSesion.DataPropertyName = "Sesion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colIDSesion.DefaultCellStyle = DataGridViewCellStyle5
        Me.colIDSesion.HeaderText = "Sesion"
        Me.colIDSesion.Name = "colIDSesion"
        Me.colIDSesion.ReadOnly = True
        '
        'colMedico
        '
        Me.colMedico.DataPropertyName = "apellidos"
        Me.colMedico.HeaderText = "Medico"
        Me.colMedico.Name = "colMedico"
        Me.colMedico.ReadOnly = True
        Me.colMedico.Width = 180
        '
        'colNombre
        '
        Me.colNombre.DataPropertyName = "nombres"
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Visible = False
        '
        'gbEstadisticas
        '
        Me.gbEstadisticas.Controls.Add(Me.txtCantChat)
        Me.gbEstadisticas.Controls.Add(Me.lblDetChatRealizados)
        Me.gbEstadisticas.Controls.Add(Me.lblChats)
        Me.gbEstadisticas.Controls.Add(Me.txtCantDiag)
        Me.gbEstadisticas.Controls.Add(Me.lblDescCantDiag)
        Me.gbEstadisticas.Controls.Add(Me.lblDiagnosticos)
        Me.gbEstadisticas.Location = New System.Drawing.Point(17, 21)
        Me.gbEstadisticas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbEstadisticas.Name = "gbEstadisticas"
        Me.gbEstadisticas.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbEstadisticas.Size = New System.Drawing.Size(389, 177)
        Me.gbEstadisticas.TabIndex = 4
        Me.gbEstadisticas.TabStop = False
        Me.gbEstadisticas.Text = "Datos estadisticos"
        '
        'txtCantChat
        '
        Me.txtCantChat.Enabled = False
        Me.txtCantChat.Location = New System.Drawing.Point(304, 103)
        Me.txtCantChat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCantChat.Name = "txtCantChat"
        Me.txtCantChat.Size = New System.Drawing.Size(72, 27)
        Me.txtCantChat.TabIndex = 5
        Me.txtCantChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDetChatRealizados
        '
        Me.lblDetChatRealizados.AutoSize = True
        Me.lblDetChatRealizados.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetChatRealizados.Location = New System.Drawing.Point(19, 113)
        Me.lblDetChatRealizados.Name = "lblDetChatRealizados"
        Me.lblDetChatRealizados.Size = New System.Drawing.Size(189, 17)
        Me.lblDetChatRealizados.TabIndex = 4
        Me.lblDetChatRealizados.Text = "Cantidad de chat realizados"
        '
        'lblChats
        '
        Me.lblChats.AutoSize = True
        Me.lblChats.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChats.Location = New System.Drawing.Point(19, 90)
        Me.lblChats.Name = "lblChats"
        Me.lblChats.Size = New System.Drawing.Size(55, 19)
        Me.lblChats.TabIndex = 3
        Me.lblChats.Text = "Chats"
        '
        'txtCantDiag
        '
        Me.txtCantDiag.Enabled = False
        Me.txtCantDiag.Location = New System.Drawing.Point(304, 44)
        Me.txtCantDiag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCantDiag.Name = "txtCantDiag"
        Me.txtCantDiag.Size = New System.Drawing.Size(72, 27)
        Me.txtCantDiag.TabIndex = 2
        Me.txtCantDiag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDescCantDiag
        '
        Me.lblDescCantDiag.AutoSize = True
        Me.lblDescCantDiag.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescCantDiag.Location = New System.Drawing.Point(19, 54)
        Me.lblDescCantDiag.Name = "lblDescCantDiag"
        Me.lblDescCantDiag.Size = New System.Drawing.Size(235, 17)
        Me.lblDescCantDiag.TabIndex = 1
        Me.lblDescCantDiag.Text = "Cantidad de diagnosticos recibidos"
        '
        'lblDiagnosticos
        '
        Me.lblDiagnosticos.AutoSize = True
        Me.lblDiagnosticos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnosticos.Location = New System.Drawing.Point(19, 32)
        Me.lblDiagnosticos.Name = "lblDiagnosticos"
        Me.lblDiagnosticos.Size = New System.Drawing.Size(111, 19)
        Me.lblDiagnosticos.TabIndex = 0
        Me.lblDiagnosticos.Text = "Diagnosticos"
        '
        'toolsMenuPaciente
        '
        Me.toolsMenuPaciente.AutoSize = False
        Me.toolsMenuPaciente.Dock = System.Windows.Forms.DockStyle.None
        Me.toolsMenuPaciente.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolsMenuPaciente.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolsMenuPaciente.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.toolsMenuPaciente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBtnAgregar, Me.tabSeparador, Me.mnuBtnGuardar, Me.tabSeparador1, Me.mnuBtnCancelar, Me.tabSeperador2, Me.mnuBtnNueva, Me.ToolStripSeparator1, Me.mnuBtnBuscar, Me.tabSeparador3, Me.mnuBtnBorrar, Me.tabSeparador4, Me.mnuBtnReactivar, Me.mnuBtnModificar})
        Me.toolsMenuPaciente.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolsMenuPaciente.Location = New System.Drawing.Point(5, 81)
        Me.toolsMenuPaciente.Name = "toolsMenuPaciente"
        Me.toolsMenuPaciente.Size = New System.Drawing.Size(1065, 44)
        Me.toolsMenuPaciente.TabIndex = 8
        '
        'mnuBtnAgregar
        '
        Me.mnuBtnAgregar.Image = CType(resources.GetObject("mnuBtnAgregar.Image"), System.Drawing.Image)
        Me.mnuBtnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnAgregar.Name = "mnuBtnAgregar"
        Me.mnuBtnAgregar.Size = New System.Drawing.Size(97, 29)
        Me.mnuBtnAgregar.Text = "Agregar"
        Me.mnuBtnAgregar.ToolTipText = "Habilita el ingreso de una nueva patologia"
        '
        'tabSeparador
        '
        Me.tabSeparador.Name = "tabSeparador"
        Me.tabSeparador.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnGuardar
        '
        Me.mnuBtnGuardar.Enabled = False
        Me.mnuBtnGuardar.Image = CType(resources.GetObject("mnuBtnGuardar.Image"), System.Drawing.Image)
        Me.mnuBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnGuardar.Name = "mnuBtnGuardar"
        Me.mnuBtnGuardar.Size = New System.Drawing.Size(98, 29)
        Me.mnuBtnGuardar.Text = "Guardar"
        Me.mnuBtnGuardar.ToolTipText = "Guarda los cambios"
        '
        'tabSeparador1
        '
        Me.tabSeparador1.Name = "tabSeparador1"
        Me.tabSeparador1.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnCancelar
        '
        Me.mnuBtnCancelar.Enabled = False
        Me.mnuBtnCancelar.Image = CType(resources.GetObject("mnuBtnCancelar.Image"), System.Drawing.Image)
        Me.mnuBtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnCancelar.Name = "mnuBtnCancelar"
        Me.mnuBtnCancelar.Size = New System.Drawing.Size(104, 29)
        Me.mnuBtnCancelar.Text = "Cancelar"
        Me.mnuBtnCancelar.ToolTipText = "Cancela los cambios"
        '
        'tabSeperador2
        '
        Me.tabSeperador2.Name = "tabSeperador2"
        Me.tabSeperador2.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnNueva
        '
        Me.mnuBtnNueva.Image = CType(resources.GetObject("mnuBtnNueva.Image"), System.Drawing.Image)
        Me.mnuBtnNueva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnNueva.Name = "mnuBtnNueva"
        Me.mnuBtnNueva.Size = New System.Drawing.Size(83, 29)
        Me.mnuBtnNueva.Text = "Nueva"
        Me.mnuBtnNueva.ToolTipText = "Inicia una nueva busqueda"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnBuscar
        '
        Me.mnuBtnBuscar.Enabled = False
        Me.mnuBtnBuscar.Image = CType(resources.GetObject("mnuBtnBuscar.Image"), System.Drawing.Image)
        Me.mnuBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnBuscar.Name = "mnuBtnBuscar"
        Me.mnuBtnBuscar.Size = New System.Drawing.Size(90, 29)
        Me.mnuBtnBuscar.Text = "Buscar"
        Me.mnuBtnBuscar.ToolTipText = "Buscar por el nombre ingresado"
        '
        'tabSeparador3
        '
        Me.tabSeparador3.Name = "tabSeparador3"
        Me.tabSeparador3.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnBorrar
        '
        Me.mnuBtnBorrar.Enabled = False
        Me.mnuBtnBorrar.Image = CType(resources.GetObject("mnuBtnBorrar.Image"), System.Drawing.Image)
        Me.mnuBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnBorrar.Name = "mnuBtnBorrar"
        Me.mnuBtnBorrar.Size = New System.Drawing.Size(85, 29)
        Me.mnuBtnBorrar.Text = "Borrar"
        Me.mnuBtnBorrar.ToolTipText = "Borrar el registro en pantalla"
        '
        'tabSeparador4
        '
        Me.tabSeparador4.Name = "tabSeparador4"
        Me.tabSeparador4.Size = New System.Drawing.Size(6, 23)
        '
        'mnuBtnReactivar
        '
        Me.mnuBtnReactivar.AutoSize = False
        Me.mnuBtnReactivar.Enabled = False
        Me.mnuBtnReactivar.Image = CType(resources.GetObject("mnuBtnReactivar.Image"), System.Drawing.Image)
        Me.mnuBtnReactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnReactivar.Name = "mnuBtnReactivar"
        Me.mnuBtnReactivar.Size = New System.Drawing.Size(106, 29)
        Me.mnuBtnReactivar.Text = "Reactivar"
        Me.mnuBtnReactivar.ToolTipText = "Reactiva el registro a la vista"
        '
        'mnuBtnModificar
        '
        Me.mnuBtnModificar.Enabled = False
        Me.mnuBtnModificar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBtnModificar.Image = CType(resources.GetObject("mnuBtnModificar.Image"), System.Drawing.Image)
        Me.mnuBtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnModificar.Name = "mnuBtnModificar"
        Me.mnuBtnModificar.Size = New System.Drawing.Size(106, 29)
        Me.mnuBtnModificar.Text = "Modificar"
        Me.mnuBtnModificar.ToolTipText = "Habilita la modificacion de una patologia"
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(5, 0)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(1065, 79)
        Me.picEncabezado.TabIndex = 5
        Me.picEncabezado.TabStop = False
        '
        'frmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 674)
        Me.Controls.Add(Me.toolsMenuPaciente)
        Me.Controls.Add(Me.tabOpcionesPaciente)
        Me.Controls.Add(Me.picEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPaciente"
        Me.Text = "PACIENTE"
        Me.tabOpcionesPaciente.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        CType(Me.dgvListaPreExistentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListaTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBusqueda.ResumeLayout(False)
        CType(Me.dgvListaPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistoria.ResumeLayout(False)
        Me.gbVerChat.ResumeLayout(False)
        Me.gbHistoricoChats.ResumeLayout(False)
        CType(Me.dgvHistoriaChat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEstadisticas.ResumeLayout(False)
        Me.gbEstadisticas.PerformLayout()
        Me.toolsMenuPaciente.ResumeLayout(False)
        Me.toolsMenuPaciente.PerformLayout()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents tabOpcionesPaciente As TabControl
    Friend WithEvents tabDatos As TabPage
    Friend WithEvents btnEliminarTelefono As Button
    Friend WithEvents btnAgregarTelefono As Button
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents dgvListaTelefonos As DataGridView
    Friend WithEvents colTelefono As DataGridViewTextBoxColumn
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents txtEsquina As TextBox
    Friend WithEvents txtApto As TextBox
    Friend WithEvents txtNumeroCalle As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents lblOtrosDatos As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtFechaRegistro As TextBox
    Friend WithEvents txtDocIdentidad As TextBox
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents lblEmailM As Label
    Friend WithEvents lblFechaNacM As Label
    Friend WithEvents lblBarrioM As Label
    Friend WithEvents lblEsquinaM As Label
    Friend WithEvents lblAptoM As Label
    Friend WithEvents lblNumeroCalleM As Label
    Friend WithEvents lblDireccionM As Label
    Friend WithEvents lblApellidosM As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblFechaReg As Label
    Friend WithEvents lblDocIdentidad As Label
    Friend WithEvents tabBusqueda As TabPage
    Friend WithEvents dgvListaPacientes As DataGridView
    Friend WithEvents colDocIdentidad As DataGridViewTextBoxColumn
    Friend WithEvents colNombres As DataGridViewTextBoxColumn
    Friend WithEvents colApellidos As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colFechRegistro As DataGridViewTextBoxColumn
    Friend WithEvents colActivo As DataGridViewTextBoxColumn
    Friend WithEvents lblEnfermedades As Label
    Friend WithEvents dgvListaPreExistentes As DataGridView
    Friend WithEvents btnEliminarEnfermedad As Button
    Friend WithEvents btnAgregarEnfermedad As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents tabHistoria As TabPage
    Friend WithEvents gbVerChat As GroupBox
    Friend WithEvents gbHistoricoChats As GroupBox
    Friend WithEvents dgvHistoriaChat As DataGridView
    Friend WithEvents colFecha As DataGridViewTextBoxColumn
    Friend WithEvents colIDSesion As DataGridViewTextBoxColumn
    Friend WithEvents colMedico As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents gbEstadisticas As GroupBox
    Friend WithEvents txtCantChat As TextBox
    Friend WithEvents lblDetChatRealizados As Label
    Friend WithEvents lblChats As Label
    Friend WithEvents txtCantDiag As TextBox
    Friend WithEvents lblDescCantDiag As Label
    Friend WithEvents lblDiagnosticos As Label
    Friend WithEvents rtbMensajes As RichTextBox
    Friend WithEvents toolsMenuPaciente As ToolStrip
    Friend WithEvents mnuBtnAgregar As ToolStripButton
    Friend WithEvents tabSeparador As ToolStripSeparator
    Friend WithEvents mnuBtnGuardar As ToolStripButton
    Friend WithEvents tabSeparador1 As ToolStripSeparator
    Friend WithEvents mnuBtnCancelar As ToolStripButton
    Friend WithEvents tabSeperador2 As ToolStripSeparator
    Friend WithEvents mnuBtnNueva As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuBtnBuscar As ToolStripButton
    Friend WithEvents tabSeparador3 As ToolStripSeparator
    Friend WithEvents mnuBtnBorrar As ToolStripButton
    Friend WithEvents tabSeparador4 As ToolStripSeparator
    Friend WithEvents mnuBtnReactivar As ToolStripButton
    Friend WithEvents mnuBtnModificar As ToolStripButton
    Friend WithEvents btnRestPass As Button
End Class
