<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedico))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolsMenuMedico = New System.Windows.Forms.ToolStrip()
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
        Me.mnuReactivar = New System.Windows.Forms.ToolStripButton()
        Me.mnuBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.tabOpcionesMedico = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.btnRestPass = New System.Windows.Forms.Button()
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
        Me.txtNumMedico = New System.Windows.Forms.TextBox()
        Me.txtDocIdentidad = New System.Windows.Forms.TextBox()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.lblNumeroMedico = New System.Windows.Forms.Label()
        Me.lblEmailM = New System.Windows.Forms.Label()
        Me.lblFechaNacM = New System.Windows.Forms.Label()
        Me.lblBarrioM = New System.Windows.Forms.Label()
        Me.lblEsquinaM = New System.Windows.Forms.Label()
        Me.lblAptoM = New System.Windows.Forms.Label()
        Me.lblNumeroCalleM = New System.Windows.Forms.Label()
        Me.lblDireccionM = New System.Windows.Forms.Label()
        Me.lblApellidosM = New System.Windows.Forms.Label()
        Me.lblNombreM = New System.Windows.Forms.Label()
        Me.lblFechaReg = New System.Windows.Forms.Label()
        Me.lblDocIdentidad = New System.Windows.Forms.Label()
        Me.tabMedicoBusqueda = New System.Windows.Forms.TabPage()
        Me.dgvListaMedicos = New System.Windows.Forms.DataGridView()
        Me.colDocIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabActividad = New System.Windows.Forms.TabPage()
        Me.gbActividad = New System.Windows.Forms.GroupBox()
        Me.chartActMedico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.gbSesiones = New System.Windows.Forms.GroupBox()
        Me.dgvSesionesMedico = New System.Windows.Forms.DataGridView()
        Me.colSesion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPonderacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tttTelefono = New System.Windows.Forms.ToolTip(Me.components)
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.toolsMenuMedico.SuspendLayout()
        Me.tabOpcionesMedico.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        CType(Me.dgvListaTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMedicoBusqueda.SuspendLayout()
        CType(Me.dgvListaMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabActividad.SuspendLayout()
        Me.gbActividad.SuspendLayout()
        CType(Me.chartActMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSesiones.SuspendLayout()
        CType(Me.dgvSesionesMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolsMenuMedico
        '
        Me.toolsMenuMedico.AutoSize = False
        Me.toolsMenuMedico.Dock = System.Windows.Forms.DockStyle.None
        Me.toolsMenuMedico.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolsMenuMedico.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolsMenuMedico.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.toolsMenuMedico.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBtnAgregar, Me.tabSeparador, Me.mnuBtnGuardar, Me.tabSeparador1, Me.mnuBtnCancelar, Me.tabSeperador2, Me.mnuBtnNueva, Me.ToolStripSeparator1, Me.mnuBtnBuscar, Me.tabSeparador3, Me.mnuBtnBorrar, Me.tabSeparador4, Me.mnuReactivar, Me.mnuBtnModificar})
        Me.toolsMenuMedico.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolsMenuMedico.Location = New System.Drawing.Point(11, 65)
        Me.toolsMenuMedico.Name = "toolsMenuMedico"
        Me.toolsMenuMedico.Size = New System.Drawing.Size(754, 36)
        Me.toolsMenuMedico.TabIndex = 4
        '
        'mnuBtnAgregar
        '
        Me.mnuBtnAgregar.Image = CType(resources.GetObject("mnuBtnAgregar.Image"), System.Drawing.Image)
        Me.mnuBtnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnAgregar.Name = "mnuBtnAgregar"
        Me.mnuBtnAgregar.Size = New System.Drawing.Size(88, 29)
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
        Me.mnuBtnGuardar.Size = New System.Drawing.Size(90, 29)
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
        Me.mnuBtnCancelar.Size = New System.Drawing.Size(94, 29)
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
        Me.mnuBtnNueva.Size = New System.Drawing.Size(77, 29)
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
        Me.mnuBtnBuscar.Size = New System.Drawing.Size(81, 29)
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
        Me.mnuBtnBorrar.Size = New System.Drawing.Size(77, 29)
        Me.mnuBtnBorrar.Text = "Borrar"
        Me.mnuBtnBorrar.ToolTipText = "Borrar el registro en pantalla"
        '
        'tabSeparador4
        '
        Me.tabSeparador4.Name = "tabSeparador4"
        Me.tabSeparador4.Size = New System.Drawing.Size(6, 23)
        '
        'mnuReactivar
        '
        Me.mnuReactivar.AutoSize = False
        Me.mnuReactivar.Enabled = False
        Me.mnuReactivar.Image = CType(resources.GetObject("mnuReactivar.Image"), System.Drawing.Image)
        Me.mnuReactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuReactivar.Name = "mnuReactivar"
        Me.mnuReactivar.Size = New System.Drawing.Size(106, 29)
        Me.mnuReactivar.Text = "Reactivar"
        Me.mnuReactivar.ToolTipText = "Reactiva el registro a la vista"
        '
        'mnuBtnModificar
        '
        Me.mnuBtnModificar.Enabled = False
        Me.mnuBtnModificar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBtnModificar.Image = CType(resources.GetObject("mnuBtnModificar.Image"), System.Drawing.Image)
        Me.mnuBtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnModificar.Name = "mnuBtnModificar"
        Me.mnuBtnModificar.Size = New System.Drawing.Size(94, 29)
        Me.mnuBtnModificar.Text = "Modificar"
        Me.mnuBtnModificar.ToolTipText = "Habilita la modificacion de una patologia"
        '
        'tabOpcionesMedico
        '
        Me.tabOpcionesMedico.Controls.Add(Me.tabDatos)
        Me.tabOpcionesMedico.Controls.Add(Me.tabMedicoBusqueda)
        Me.tabOpcionesMedico.Controls.Add(Me.tabActividad)
        Me.tabOpcionesMedico.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOpcionesMedico.Location = New System.Drawing.Point(25, 103)
        Me.tabOpcionesMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.tabOpcionesMedico.Name = "tabOpcionesMedico"
        Me.tabOpcionesMedico.SelectedIndex = 0
        Me.tabOpcionesMedico.Size = New System.Drawing.Size(717, 414)
        Me.tabOpcionesMedico.TabIndex = 5
        '
        'tabDatos
        '
        Me.tabDatos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabDatos.Controls.Add(Me.btnRestPass)
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
        Me.tabDatos.Controls.Add(Me.txtNumMedico)
        Me.tabDatos.Controls.Add(Me.txtDocIdentidad)
        Me.tabDatos.Controls.Add(Me.lblTelefonos)
        Me.tabDatos.Controls.Add(Me.lblNumeroMedico)
        Me.tabDatos.Controls.Add(Me.lblEmailM)
        Me.tabDatos.Controls.Add(Me.lblFechaNacM)
        Me.tabDatos.Controls.Add(Me.lblBarrioM)
        Me.tabDatos.Controls.Add(Me.lblEsquinaM)
        Me.tabDatos.Controls.Add(Me.lblAptoM)
        Me.tabDatos.Controls.Add(Me.lblNumeroCalleM)
        Me.tabDatos.Controls.Add(Me.lblDireccionM)
        Me.tabDatos.Controls.Add(Me.lblApellidosM)
        Me.tabDatos.Controls.Add(Me.lblNombreM)
        Me.tabDatos.Controls.Add(Me.lblFechaReg)
        Me.tabDatos.Controls.Add(Me.lblDocIdentidad)
        Me.tabDatos.Location = New System.Drawing.Point(4, 25)
        Me.tabDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(2)
        Me.tabDatos.Size = New System.Drawing.Size(709, 385)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Datos"
        '
        'btnRestPass
        '
        Me.btnRestPass.Enabled = False
        Me.btnRestPass.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestPass.Image = CType(resources.GetObject("btnRestPass.Image"), System.Drawing.Image)
        Me.btnRestPass.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRestPass.Location = New System.Drawing.Point(564, 275)
        Me.btnRestPass.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestPass.Name = "btnRestPass"
        Me.btnRestPass.Size = New System.Drawing.Size(118, 72)
        Me.btnRestPass.TabIndex = 85
        Me.btnRestPass.Text = "Restablecer contraseña"
        Me.btnRestPass.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRestPass.UseVisualStyleBackColor = True
        '
        'btnEliminarTelefono
        '
        Me.btnEliminarTelefono.Enabled = False
        Me.btnEliminarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarTelefono.ForeColor = System.Drawing.Color.Transparent
        Me.btnEliminarTelefono.Image = Global.appGestion.My.Resources.Resources.delTel1
        Me.btnEliminarTelefono.Location = New System.Drawing.Point(398, 308)
        Me.btnEliminarTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarTelefono.Name = "btnEliminarTelefono"
        Me.btnEliminarTelefono.Padding = New System.Windows.Forms.Padding(4)
        Me.btnEliminarTelefono.Size = New System.Drawing.Size(33, 30)
        Me.btnEliminarTelefono.TabIndex = 23
        Me.tttTelefono.SetToolTip(Me.btnEliminarTelefono, "Elimina el telefono seleccionado en la lista")
        Me.btnEliminarTelefono.UseVisualStyleBackColor = True
        '
        'btnAgregarTelefono
        '
        Me.btnAgregarTelefono.Enabled = False
        Me.btnAgregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarTelefono.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgregarTelefono.Image = Global.appGestion.My.Resources.Resources.addTel1
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(398, 275)
        Me.btnAgregarTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Padding = New System.Windows.Forms.Padding(4)
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(33, 30)
        Me.btnAgregarTelefono.TabIndex = 22
        Me.tttTelefono.SetToolTip(Me.btnAgregarTelefono, "Permite el ingreso de un nuevo telefono")
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Enabled = False
        Me.chkActivo.Location = New System.Drawing.Point(626, 347)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(2)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(65, 20)
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
        Me.dtpFechaNac.Location = New System.Drawing.Point(579, 43)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(104, 23)
        Me.dtpFechaNac.TabIndex = 3
        '
        'dgvListaTelefonos
        '
        Me.dgvListaTelefonos.AllowUserToAddRows = False
        Me.dgvListaTelefonos.AllowUserToDeleteRows = False
        Me.dgvListaTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListaTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTelefono})
        Me.dgvListaTelefonos.Enabled = False
        Me.dgvListaTelefonos.Location = New System.Drawing.Point(128, 275)
        Me.dgvListaTelefonos.Name = "dgvListaTelefonos"
        Me.dgvListaTelefonos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListaTelefonos.Size = New System.Drawing.Size(265, 91)
        Me.dgvListaTelefonos.TabIndex = 12
        '
        'colTelefono
        '
        Me.colTelefono.DataPropertyName = "Telefono"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTelefono.DefaultCellStyle = DataGridViewCellStyle1
        Me.colTelefono.HeaderText = "TELEFONOS"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Width = 200
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(128, 239)
        Me.txtBarrio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBarrio.MaxLength = 30
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(317, 23)
        Me.txtBarrio.TabIndex = 11
        '
        'txtEsquina
        '
        Me.txtEsquina.Location = New System.Drawing.Point(303, 208)
        Me.txtEsquina.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEsquina.MaxLength = 40
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.Size = New System.Drawing.Size(380, 23)
        Me.txtEsquina.TabIndex = 10
        '
        'txtApto
        '
        Me.txtApto.Location = New System.Drawing.Point(128, 208)
        Me.txtApto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApto.MaxLength = 11
        Me.txtApto.Name = "txtApto"
        Me.txtApto.Size = New System.Drawing.Size(98, 23)
        Me.txtApto.TabIndex = 9
        Me.txtApto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumeroCalle
        '
        Me.txtNumeroCalle.Location = New System.Drawing.Point(585, 175)
        Me.txtNumeroCalle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroCalle.MaxLength = 11
        Me.txtNumeroCalle.Name = "txtNumeroCalle"
        Me.txtNumeroCalle.Size = New System.Drawing.Size(98, 23)
        Me.txtNumeroCalle.TabIndex = 8
        Me.txtNumeroCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(128, 175)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCalle.MaxLength = 40
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(380, 23)
        Me.txtCalle.TabIndex = 7
        '
        'lblOtrosDatos
        '
        Me.lblOtrosDatos.AutoSize = True
        Me.lblOtrosDatos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtrosDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.lblOtrosDatos.Location = New System.Drawing.Point(35, 147)
        Me.lblOtrosDatos.Name = "lblOtrosDatos"
        Me.lblOtrosDatos.Size = New System.Drawing.Size(118, 18)
        Me.lblOtrosDatos.TabIndex = 20
        Me.lblOtrosDatos.Text = "OTROS DATOS"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(128, 103)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(377, 23)
        Me.txtEmail.TabIndex = 6
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(458, 72)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidos.MaxLength = 25
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(225, 23)
        Me.txtApellidos.TabIndex = 5
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(128, 72)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombres.MaxLength = 25
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(225, 23)
        Me.txtNombres.TabIndex = 4
        '
        'txtFechaRegistro
        '
        Me.txtFechaRegistro.Location = New System.Drawing.Point(578, 12)
        Me.txtFechaRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaRegistro.MaxLength = 65535
        Me.txtFechaRegistro.Name = "txtFechaRegistro"
        Me.txtFechaRegistro.ReadOnly = True
        Me.txtFechaRegistro.Size = New System.Drawing.Size(105, 23)
        Me.txtFechaRegistro.TabIndex = 1
        Me.txtFechaRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumMedico
        '
        Me.txtNumMedico.Location = New System.Drawing.Point(128, 42)
        Me.txtNumMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumMedico.MaxLength = 11
        Me.txtNumMedico.Name = "txtNumMedico"
        Me.txtNumMedico.Size = New System.Drawing.Size(84, 23)
        Me.txtNumMedico.TabIndex = 2
        Me.txtNumMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDocIdentidad
        '
        Me.txtDocIdentidad.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.txtDocIdentidad.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDocIdentidad.Location = New System.Drawing.Point(128, 12)
        Me.txtDocIdentidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocIdentidad.MaxLength = 11
        Me.txtDocIdentidad.Name = "txtDocIdentidad"
        Me.txtDocIdentidad.Size = New System.Drawing.Size(120, 23)
        Me.txtDocIdentidad.TabIndex = 0
        Me.txtDocIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTelefonos
        '
        Me.lblTelefonos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTelefonos.Location = New System.Drawing.Point(11, 279)
        Me.lblTelefonos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(107, 15)
        Me.lblTelefonos.TabIndex = 12
        Me.lblTelefonos.Text = "TELEFONOS:"
        Me.lblTelefonos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumeroMedico
        '
        Me.lblNumeroMedico.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroMedico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNumeroMedico.Location = New System.Drawing.Point(8, 45)
        Me.lblNumeroMedico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroMedico.Name = "lblNumeroMedico"
        Me.lblNumeroMedico.Size = New System.Drawing.Size(110, 15)
        Me.lblNumeroMedico.TabIndex = 11
        Me.lblNumeroMedico.Text = "Nº MEDICO:"
        Me.lblNumeroMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmailM
        '
        Me.lblEmailM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblEmailM.Location = New System.Drawing.Point(14, 105)
        Me.lblEmailM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailM.Name = "lblEmailM"
        Me.lblEmailM.Size = New System.Drawing.Size(104, 15)
        Me.lblEmailM.TabIndex = 10
        Me.lblEmailM.Text = "EMAIL:"
        Me.lblEmailM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaNacM
        '
        Me.lblFechaNacM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblFechaNacM.Location = New System.Drawing.Point(464, 45)
        Me.lblFechaNacM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaNacM.Name = "lblFechaNacM"
        Me.lblFechaNacM.Size = New System.Drawing.Size(102, 15)
        Me.lblFechaNacM.TabIndex = 9
        Me.lblFechaNacM.Text = "FECHA NAC.:"
        Me.lblFechaNacM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBarrioM
        '
        Me.lblBarrioM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarrioM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblBarrioM.Location = New System.Drawing.Point(11, 242)
        Me.lblBarrioM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBarrioM.Name = "lblBarrioM"
        Me.lblBarrioM.Size = New System.Drawing.Size(107, 15)
        Me.lblBarrioM.TabIndex = 8
        Me.lblBarrioM.Text = "BARRIO:"
        Me.lblBarrioM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEsquinaM
        '
        Me.lblEsquinaM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsquinaM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblEsquinaM.Location = New System.Drawing.Point(230, 211)
        Me.lblEsquinaM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEsquinaM.Name = "lblEsquinaM"
        Me.lblEsquinaM.Size = New System.Drawing.Size(72, 15)
        Me.lblEsquinaM.TabIndex = 7
        Me.lblEsquinaM.Text = "ESQUINA:"
        Me.lblEsquinaM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAptoM
        '
        Me.lblAptoM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAptoM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblAptoM.Location = New System.Drawing.Point(14, 211)
        Me.lblAptoM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAptoM.Name = "lblAptoM"
        Me.lblAptoM.Size = New System.Drawing.Size(104, 15)
        Me.lblAptoM.TabIndex = 6
        Me.lblAptoM.Text = "APTO:"
        Me.lblAptoM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumeroCalleM
        '
        Me.lblNumeroCalleM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCalleM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNumeroCalleM.Location = New System.Drawing.Point(535, 178)
        Me.lblNumeroCalleM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroCalleM.Name = "lblNumeroCalleM"
        Me.lblNumeroCalleM.Size = New System.Drawing.Size(46, 15)
        Me.lblNumeroCalleM.TabIndex = 5
        Me.lblNumeroCalleM.Text = "Nº:"
        Me.lblNumeroCalleM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDireccionM
        '
        Me.lblDireccionM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblDireccionM.Location = New System.Drawing.Point(11, 178)
        Me.lblDireccionM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccionM.Name = "lblDireccionM"
        Me.lblDireccionM.Size = New System.Drawing.Size(107, 15)
        Me.lblDireccionM.TabIndex = 4
        Me.lblDireccionM.Text = "DIRECCION:"
        Me.lblDireccionM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellidosM
        '
        Me.lblApellidosM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblApellidosM.Location = New System.Drawing.Point(357, 75)
        Me.lblApellidosM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellidosM.Name = "lblApellidosM"
        Me.lblApellidosM.Size = New System.Drawing.Size(94, 15)
        Me.lblApellidosM.TabIndex = 3
        Me.lblApellidosM.Text = "APELLIDOS:"
        Me.lblApellidosM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombreM
        '
        Me.lblNombreM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNombreM.Location = New System.Drawing.Point(11, 75)
        Me.lblNombreM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreM.Name = "lblNombreM"
        Me.lblNombreM.Size = New System.Drawing.Size(107, 15)
        Me.lblNombreM.TabIndex = 2
        Me.lblNombreM.Text = "NOMBRES:"
        Me.lblNombreM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaReg
        '
        Me.lblFechaReg.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblFechaReg.Location = New System.Drawing.Point(467, 15)
        Me.lblFechaReg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaReg.Name = "lblFechaReg"
        Me.lblFechaReg.Size = New System.Drawing.Size(101, 15)
        Me.lblFechaReg.TabIndex = 1
        Me.lblFechaReg.Text = "FECHA:"
        Me.lblFechaReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDocIdentidad
        '
        Me.lblDocIdentidad.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocIdentidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblDocIdentidad.Location = New System.Drawing.Point(5, 15)
        Me.lblDocIdentidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDocIdentidad.Name = "lblDocIdentidad"
        Me.lblDocIdentidad.Size = New System.Drawing.Size(113, 15)
        Me.lblDocIdentidad.TabIndex = 0
        Me.lblDocIdentidad.Text = "DOCUMENTO:"
        Me.lblDocIdentidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabMedicoBusqueda
        '
        Me.tabMedicoBusqueda.BackColor = System.Drawing.Color.Gainsboro
        Me.tabMedicoBusqueda.Controls.Add(Me.dgvListaMedicos)
        Me.tabMedicoBusqueda.Location = New System.Drawing.Point(4, 25)
        Me.tabMedicoBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.tabMedicoBusqueda.Name = "tabMedicoBusqueda"
        Me.tabMedicoBusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.tabMedicoBusqueda.Size = New System.Drawing.Size(709, 407)
        Me.tabMedicoBusqueda.TabIndex = 1
        Me.tabMedicoBusqueda.Text = "Busqueda"
        '
        'dgvListaMedicos
        '
        Me.dgvListaMedicos.AllowUserToAddRows = False
        Me.dgvListaMedicos.AllowUserToDeleteRows = False
        Me.dgvListaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaMedicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDocIdentidad, Me.colNMedico, Me.colNombres, Me.colApellidos, Me.colEmail, Me.colFechRegistro, Me.colActivo})
        Me.dgvListaMedicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaMedicos.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaMedicos.MultiSelect = False
        Me.dgvListaMedicos.Name = "dgvListaMedicos"
        Me.dgvListaMedicos.ReadOnly = True
        Me.dgvListaMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaMedicos.Size = New System.Drawing.Size(705, 403)
        Me.dgvListaMedicos.TabIndex = 0
        '
        'colDocIdentidad
        '
        Me.colDocIdentidad.DataPropertyName = "DOCUMENTO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDocIdentidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDocIdentidad.HeaderText = "DOCUMENTO"
        Me.colDocIdentidad.Name = "colDocIdentidad"
        Me.colDocIdentidad.ReadOnly = True
        '
        'colNMedico
        '
        Me.colNMedico.DataPropertyName = "NMEDICO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colNMedico.DefaultCellStyle = DataGridViewCellStyle3
        Me.colNMedico.HeaderText = "Nº MEDICO"
        Me.colNMedico.Name = "colNMedico"
        Me.colNMedico.ReadOnly = True
        Me.colNMedico.Width = 130
        '
        'colNombres
        '
        Me.colNombres.DataPropertyName = "NOMBRES"
        Me.colNombres.HeaderText = "NOMBRES"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.ReadOnly = True
        Me.colNombres.Width = 120
        '
        'colApellidos
        '
        Me.colApellidos.DataPropertyName = "APELLIDOS"
        Me.colApellidos.HeaderText = "APELLIDOS"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.ReadOnly = True
        Me.colApellidos.Width = 120
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
        'tabActividad
        '
        Me.tabActividad.Controls.Add(Me.gbActividad)
        Me.tabActividad.Controls.Add(Me.gbSesiones)
        Me.tabActividad.Location = New System.Drawing.Point(4, 25)
        Me.tabActividad.Margin = New System.Windows.Forms.Padding(2)
        Me.tabActividad.Name = "tabActividad"
        Me.tabActividad.Padding = New System.Windows.Forms.Padding(2)
        Me.tabActividad.Size = New System.Drawing.Size(709, 407)
        Me.tabActividad.TabIndex = 2
        Me.tabActividad.Text = "Actividad"
        Me.tabActividad.UseVisualStyleBackColor = True
        '
        'gbActividad
        '
        Me.gbActividad.Controls.Add(Me.chartActMedico)
        Me.gbActividad.Location = New System.Drawing.Point(256, 16)
        Me.gbActividad.Margin = New System.Windows.Forms.Padding(2)
        Me.gbActividad.Name = "gbActividad"
        Me.gbActividad.Padding = New System.Windows.Forms.Padding(2)
        Me.gbActividad.Size = New System.Drawing.Size(438, 371)
        Me.gbActividad.TabIndex = 1
        Me.gbActividad.TabStop = False
        Me.gbActividad.Text = "Actividad ultimos 12 meses moviles"
        '
        'chartActMedico
        '
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.Name = "ChartArea1"
        Me.chartActMedico.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend1"
        Me.chartActMedico.Legends.Add(Legend1)
        Me.chartActMedico.Location = New System.Drawing.Point(7, 26)
        Me.chartActMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.chartActMedico.Name = "chartActMedico"
        Me.chartActMedico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Sesiones"
        Me.chartActMedico.Series.Add(Series1)
        Me.chartActMedico.Size = New System.Drawing.Size(421, 332)
        Me.chartActMedico.TabIndex = 0
        Me.chartActMedico.Text = "Chart1"
        '
        'gbSesiones
        '
        Me.gbSesiones.Controls.Add(Me.dgvSesionesMedico)
        Me.gbSesiones.Location = New System.Drawing.Point(15, 16)
        Me.gbSesiones.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSesiones.Name = "gbSesiones"
        Me.gbSesiones.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSesiones.Size = New System.Drawing.Size(232, 372)
        Me.gbSesiones.TabIndex = 0
        Me.gbSesiones.TabStop = False
        Me.gbSesiones.Text = "Sesiones"
        '
        'dgvSesionesMedico
        '
        Me.dgvSesionesMedico.AllowUserToAddRows = False
        Me.dgvSesionesMedico.AllowUserToDeleteRows = False
        Me.dgvSesionesMedico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvSesionesMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSesionesMedico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSesion, Me.colFecha, Me.colPonderacion, Me.colDoc})
        Me.dgvSesionesMedico.Location = New System.Drawing.Point(8, 20)
        Me.dgvSesionesMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSesionesMedico.Name = "dgvSesionesMedico"
        Me.dgvSesionesMedico.ReadOnly = True
        Me.dgvSesionesMedico.RowTemplate.Height = 24
        Me.dgvSesionesMedico.ShowRowErrors = False
        Me.dgvSesionesMedico.Size = New System.Drawing.Size(218, 339)
        Me.dgvSesionesMedico.TabIndex = 0
        '
        'colSesion
        '
        Me.colSesion.DataPropertyName = "idSesion"
        Me.colSesion.HeaderText = "Sesion"
        Me.colSesion.Name = "colSesion"
        Me.colSesion.ReadOnly = True
        '
        'colFecha
        '
        Me.colFecha.DataPropertyName = "fechaHoraInicioSesion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFecha.DefaultCellStyle = DataGridViewCellStyle5
        Me.colFecha.HeaderText = "Fecha y hora"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        Me.colFecha.Width = 120
        '
        'colPonderacion
        '
        Me.colPonderacion.DataPropertyName = "prioridad"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPonderacion.DefaultCellStyle = DataGridViewCellStyle6
        Me.colPonderacion.HeaderText = "Ponderacion"
        Me.colPonderacion.Name = "colPonderacion"
        Me.colPonderacion.ReadOnly = True
        Me.colPonderacion.Width = 80
        '
        'colDoc
        '
        Me.colDoc.DataPropertyName = "docidentidadMedico"
        Me.colDoc.HeaderText = "documento"
        Me.colDoc.Name = "colDoc"
        Me.colDoc.ReadOnly = True
        Me.colDoc.Visible = False
        '
        'tttTelefono
        '
        Me.tttTelefono.ToolTipTitle = "Opciones de Telefonos"
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(0, -1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(765, 64)
        Me.picEncabezado.TabIndex = 3
        Me.picEncabezado.TabStop = False
        '
        'frmMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 525)
        Me.Controls.Add(Me.tabOpcionesMedico)
        Me.Controls.Add(Me.toolsMenuMedico)
        Me.Controls.Add(Me.picEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMedico"
        Me.Text = "MEDICO"
        Me.toolsMenuMedico.ResumeLayout(False)
        Me.toolsMenuMedico.PerformLayout()
        Me.tabOpcionesMedico.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        CType(Me.dgvListaTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMedicoBusqueda.ResumeLayout(False)
        CType(Me.dgvListaMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabActividad.ResumeLayout(False)
        Me.gbActividad.ResumeLayout(False)
        CType(Me.chartActMedico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSesiones.ResumeLayout(False)
        CType(Me.dgvSesionesMedico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents toolsMenuMedico As ToolStrip
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
    Friend WithEvents mnuBtnModificar As ToolStripButton
    Friend WithEvents tabOpcionesMedico As TabControl
    Friend WithEvents tabDatos As TabPage
    Friend WithEvents tabMedicoBusqueda As TabPage
    Friend WithEvents lblDocIdentidad As Label
    Friend WithEvents lblFechaReg As Label
    Friend WithEvents lblApellidosM As Label
    Friend WithEvents lblNombreM As Label
    Friend WithEvents lblDireccionM As Label
    Friend WithEvents lblNumeroCalleM As Label
    Friend WithEvents lblAptoM As Label
    Friend WithEvents lblBarrioM As Label
    Friend WithEvents lblEsquinaM As Label
    Friend WithEvents lblEmailM As Label
    Friend WithEvents lblFechaNacM As Label
    Friend WithEvents lblNumeroMedico As Label
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents txtDocIdentidad As TextBox
    Friend WithEvents txtFechaRegistro As TextBox
    Friend WithEvents txtNumMedico As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNumeroCalle As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents lblOtrosDatos As Label
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents txtEsquina As TextBox
    Friend WithEvents txtApto As TextBox
    Friend WithEvents dgvListaTelefonos As DataGridView
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents dgvListaMedicos As DataGridView
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents colTelefono As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregarTelefono As Button
    Friend WithEvents btnEliminarTelefono As Button
    Friend WithEvents tttTelefono As ToolTip
    Friend WithEvents mnuReactivar As ToolStripButton
    Friend WithEvents tabActividad As TabPage
    Friend WithEvents gbActividad As GroupBox
    Friend WithEvents gbSesiones As GroupBox
    Friend WithEvents dgvSesionesMedico As DataGridView
    Friend WithEvents chartActMedico As DataVisualization.Charting.Chart
    Friend WithEvents colDocIdentidad As DataGridViewTextBoxColumn
    Friend WithEvents colNMedico As DataGridViewTextBoxColumn
    Friend WithEvents colNombres As DataGridViewTextBoxColumn
    Friend WithEvents colApellidos As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colFechRegistro As DataGridViewTextBoxColumn
    Friend WithEvents colActivo As DataGridViewTextBoxColumn
    Friend WithEvents colSesion As DataGridViewTextBoxColumn
    Friend WithEvents colFecha As DataGridViewTextBoxColumn
    Friend WithEvents colPonderacion As DataGridViewTextBoxColumn
    Friend WithEvents colDoc As DataGridViewTextBoxColumn
    Friend WithEvents btnRestPass As Button
End Class
