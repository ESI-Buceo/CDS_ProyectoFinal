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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedico))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolsMenuMedico = New System.Windows.Forms.ToolStrip()
        Me.tabSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.tabSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabSeperador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabSeparador3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabSeparador4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabOpcionesMedico = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
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
        Me.lnlNumeroMedico = New System.Windows.Forms.Label()
        Me.lblEmailM = New System.Windows.Forms.Label()
        Me.lblFechaNacM = New System.Windows.Forms.Label()
        Me.lblBarrioM = New System.Windows.Forms.Label()
        Me.lblEsquinaM = New System.Windows.Forms.Label()
        Me.lblAptoM = New System.Windows.Forms.Label()
        Me.lblNumeroCalleM = New System.Windows.Forms.Label()
        Me.lblDireccionM = New System.Windows.Forms.Label()
        Me.lblApellidosM = New System.Windows.Forms.Label()
        Me.lnlNombreM = New System.Windows.Forms.Label()
        Me.lblFechaReg = New System.Windows.Forms.Label()
        Me.lblDocIdentidad = New System.Windows.Forms.Label()
        Me.tabMedicoBusqueda = New System.Windows.Forms.TabPage()
        Me.dgvListaMedicos = New System.Windows.Forms.DataGridView()
        Me.btnEliminarTelefono = New System.Windows.Forms.Button()
        Me.btnAgregarTelefono = New System.Windows.Forms.Button()
        Me.mnuBtnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.mnuBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.mnuBtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.mnuBtnNueva = New System.Windows.Forms.ToolStripButton()
        Me.mnuBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.mnuBtnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.mnuBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.tttTelefono = New System.Windows.Forms.ToolTip(Me.components)
        Me.colDocIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolsMenuMedico.SuspendLayout()
        Me.tabOpcionesMedico.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        CType(Me.dgvListaTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMedicoBusqueda.SuspendLayout()
        CType(Me.dgvListaMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.toolsMenuMedico.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBtnAgregar, Me.tabSeparador, Me.mnuBtnGuardar, Me.tabSeparador1, Me.mnuBtnCancelar, Me.tabSeperador2, Me.mnuBtnNueva, Me.ToolStripSeparator1, Me.mnuBtnBuscar, Me.tabSeparador3, Me.mnuBtnBorrar, Me.tabSeparador4, Me.mnuBtnModificar})
        Me.toolsMenuMedico.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolsMenuMedico.Location = New System.Drawing.Point(15, 80)
        Me.toolsMenuMedico.Name = "toolsMenuMedico"
        Me.toolsMenuMedico.Size = New System.Drawing.Size(981, 44)
        Me.toolsMenuMedico.TabIndex = 4
        '
        'tabSeparador
        '
        Me.tabSeparador.Name = "tabSeparador"
        Me.tabSeparador.Size = New System.Drawing.Size(6, 23)
        '
        'tabSeparador1
        '
        Me.tabSeparador1.Name = "tabSeparador1"
        Me.tabSeparador1.Size = New System.Drawing.Size(6, 23)
        '
        'tabSeperador2
        '
        Me.tabSeperador2.Name = "tabSeperador2"
        Me.tabSeperador2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'tabSeparador3
        '
        Me.tabSeparador3.Name = "tabSeparador3"
        Me.tabSeparador3.Size = New System.Drawing.Size(6, 23)
        '
        'tabSeparador4
        '
        Me.tabSeparador4.Name = "tabSeparador4"
        Me.tabSeparador4.Size = New System.Drawing.Size(6, 23)
        '
        'tabOpcionesMedico
        '
        Me.tabOpcionesMedico.Controls.Add(Me.tabDatos)
        Me.tabOpcionesMedico.Controls.Add(Me.tabMedicoBusqueda)
        Me.tabOpcionesMedico.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOpcionesMedico.Location = New System.Drawing.Point(11, 127)
        Me.tabOpcionesMedico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabOpcionesMedico.Name = "tabOpcionesMedico"
        Me.tabOpcionesMedico.SelectedIndex = 0
        Me.tabOpcionesMedico.Size = New System.Drawing.Size(956, 536)
        Me.tabOpcionesMedico.TabIndex = 5
        '
        'tabDatos
        '
        Me.tabDatos.BackColor = System.Drawing.Color.Gainsboro
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
        Me.tabDatos.Controls.Add(Me.lnlNumeroMedico)
        Me.tabDatos.Controls.Add(Me.lblEmailM)
        Me.tabDatos.Controls.Add(Me.lblFechaNacM)
        Me.tabDatos.Controls.Add(Me.lblBarrioM)
        Me.tabDatos.Controls.Add(Me.lblEsquinaM)
        Me.tabDatos.Controls.Add(Me.lblAptoM)
        Me.tabDatos.Controls.Add(Me.lblNumeroCalleM)
        Me.tabDatos.Controls.Add(Me.lblDireccionM)
        Me.tabDatos.Controls.Add(Me.lblApellidosM)
        Me.tabDatos.Controls.Add(Me.lnlNombreM)
        Me.tabDatos.Controls.Add(Me.lblFechaReg)
        Me.tabDatos.Controls.Add(Me.lblDocIdentidad)
        Me.tabDatos.Location = New System.Drawing.Point(4, 28)
        Me.tabDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Size = New System.Drawing.Size(948, 504)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Datos"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Enabled = False
        Me.chkActivo.Location = New System.Drawing.Point(834, 427)
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
        Me.dtpFechaNac.Location = New System.Drawing.Point(772, 53)
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
        Me.dgvListaTelefonos.Enabled = False
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTelefono.DefaultCellStyle = DataGridViewCellStyle5
        Me.colTelefono.HeaderText = "TELEFONOS"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Width = 200
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(171, 294)
        Me.txtBarrio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBarrio.MaxLength = 30
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(421, 27)
        Me.txtBarrio.TabIndex = 11
        '
        'txtEsquina
        '
        Me.txtEsquina.Location = New System.Drawing.Point(404, 256)
        Me.txtEsquina.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEsquina.MaxLength = 40
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.Size = New System.Drawing.Size(505, 27)
        Me.txtEsquina.TabIndex = 10
        '
        'txtApto
        '
        Me.txtApto.Location = New System.Drawing.Point(171, 256)
        Me.txtApto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApto.MaxLength = 11
        Me.txtApto.Name = "txtApto"
        Me.txtApto.Size = New System.Drawing.Size(129, 27)
        Me.txtApto.TabIndex = 9
        Me.txtApto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumeroCalle
        '
        Me.txtNumeroCalle.Location = New System.Drawing.Point(780, 215)
        Me.txtNumeroCalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumeroCalle.MaxLength = 11
        Me.txtNumeroCalle.Name = "txtNumeroCalle"
        Me.txtNumeroCalle.Size = New System.Drawing.Size(129, 27)
        Me.txtNumeroCalle.TabIndex = 8
        Me.txtNumeroCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(171, 215)
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
        Me.lblOtrosDatos.Location = New System.Drawing.Point(47, 181)
        Me.lblOtrosDatos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOtrosDatos.Name = "lblOtrosDatos"
        Me.lblOtrosDatos.Size = New System.Drawing.Size(151, 22)
        Me.lblOtrosDatos.TabIndex = 20
        Me.lblOtrosDatos.Text = "OTROS DATOS"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(171, 127)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(501, 27)
        Me.txtEmail.TabIndex = 6
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(611, 89)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellidos.MaxLength = 25
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(299, 27)
        Me.txtApellidos.TabIndex = 5
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(171, 89)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombres.MaxLength = 25
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(299, 27)
        Me.txtNombres.TabIndex = 4
        '
        'txtFechaRegistro
        '
        Me.txtFechaRegistro.Location = New System.Drawing.Point(771, 15)
        Me.txtFechaRegistro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFechaRegistro.MaxLength = 65535
        Me.txtFechaRegistro.Name = "txtFechaRegistro"
        Me.txtFechaRegistro.ReadOnly = True
        Me.txtFechaRegistro.Size = New System.Drawing.Size(139, 27)
        Me.txtFechaRegistro.TabIndex = 1
        Me.txtFechaRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumMedico
        '
        Me.txtNumMedico.Location = New System.Drawing.Point(171, 52)
        Me.txtNumMedico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumMedico.MaxLength = 11
        Me.txtNumMedico.Name = "txtNumMedico"
        Me.txtNumMedico.Size = New System.Drawing.Size(111, 27)
        Me.txtNumMedico.TabIndex = 2
        Me.txtNumMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDocIdentidad
        '
        Me.txtDocIdentidad.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.txtDocIdentidad.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDocIdentidad.Location = New System.Drawing.Point(171, 15)
        Me.txtDocIdentidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDocIdentidad.MaxLength = 11
        Me.txtDocIdentidad.Name = "txtDocIdentidad"
        Me.txtDocIdentidad.ReadOnly = True
        Me.txtDocIdentidad.Size = New System.Drawing.Size(159, 27)
        Me.txtDocIdentidad.TabIndex = 0
        Me.txtDocIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTelefonos.Location = New System.Drawing.Point(41, 343)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(110, 19)
        Me.lblTelefonos.TabIndex = 12
        Me.lblTelefonos.Text = "TELEFONOS:"
        '
        'lnlNumeroMedico
        '
        Me.lnlNumeroMedico.AutoSize = True
        Me.lnlNumeroMedico.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlNumeroMedico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lnlNumeroMedico.Location = New System.Drawing.Point(57, 55)
        Me.lnlNumeroMedico.Name = "lnlNumeroMedico"
        Me.lnlNumeroMedico.Size = New System.Drawing.Size(100, 19)
        Me.lnlNumeroMedico.TabIndex = 11
        Me.lnlNumeroMedico.Text = "Nº MEDICO:"
        '
        'lblEmailM
        '
        Me.lblEmailM.AutoSize = True
        Me.lblEmailM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblEmailM.Location = New System.Drawing.Point(100, 130)
        Me.lblEmailM.Name = "lblEmailM"
        Me.lblEmailM.Size = New System.Drawing.Size(63, 19)
        Me.lblEmailM.TabIndex = 10
        Me.lblEmailM.Text = "EMAIL:"
        '
        'lblFechaNacM
        '
        Me.lblFechaNacM.AutoSize = True
        Me.lblFechaNacM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblFechaNacM.Location = New System.Drawing.Point(643, 55)
        Me.lblFechaNacM.Name = "lblFechaNacM"
        Me.lblFechaNacM.Size = New System.Drawing.Size(112, 19)
        Me.lblFechaNacM.TabIndex = 9
        Me.lblFechaNacM.Text = "FECHA NAC.:"
        '
        'lblBarrioM
        '
        Me.lblBarrioM.AutoSize = True
        Me.lblBarrioM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarrioM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblBarrioM.Location = New System.Drawing.Point(84, 298)
        Me.lblBarrioM.Name = "lblBarrioM"
        Me.lblBarrioM.Size = New System.Drawing.Size(75, 19)
        Me.lblBarrioM.TabIndex = 8
        Me.lblBarrioM.Text = "BARRIO:"
        '
        'lblEsquinaM
        '
        Me.lblEsquinaM.AutoSize = True
        Me.lblEsquinaM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsquinaM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblEsquinaM.Location = New System.Drawing.Point(308, 260)
        Me.lblEsquinaM.Name = "lblEsquinaM"
        Me.lblEsquinaM.Size = New System.Drawing.Size(86, 19)
        Me.lblEsquinaM.TabIndex = 7
        Me.lblEsquinaM.Text = "ESQUINA:"
        '
        'lblAptoM
        '
        Me.lblAptoM.AutoSize = True
        Me.lblAptoM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAptoM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblAptoM.Location = New System.Drawing.Point(99, 260)
        Me.lblAptoM.Name = "lblAptoM"
        Me.lblAptoM.Size = New System.Drawing.Size(57, 19)
        Me.lblAptoM.TabIndex = 6
        Me.lblAptoM.Text = "APTO:"
        '
        'lblNumeroCalleM
        '
        Me.lblNumeroCalleM.AutoSize = True
        Me.lblNumeroCalleM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCalleM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNumeroCalleM.Location = New System.Drawing.Point(744, 219)
        Me.lblNumeroCalleM.Name = "lblNumeroCalleM"
        Me.lblNumeroCalleM.Size = New System.Drawing.Size(30, 19)
        Me.lblNumeroCalleM.TabIndex = 5
        Me.lblNumeroCalleM.Text = "Nº:"
        '
        'lblDireccionM
        '
        Me.lblDireccionM.AutoSize = True
        Me.lblDireccionM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblDireccionM.Location = New System.Drawing.Point(53, 219)
        Me.lblDireccionM.Name = "lblDireccionM"
        Me.lblDireccionM.Size = New System.Drawing.Size(105, 19)
        Me.lblDireccionM.TabIndex = 4
        Me.lblDireccionM.Text = "DIRECCION:"
        '
        'lblApellidosM
        '
        Me.lblApellidosM.AutoSize = True
        Me.lblApellidosM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblApellidosM.Location = New System.Drawing.Point(492, 92)
        Me.lblApellidosM.Name = "lblApellidosM"
        Me.lblApellidosM.Size = New System.Drawing.Size(105, 19)
        Me.lblApellidosM.TabIndex = 3
        Me.lblApellidosM.Text = "APELLIDOS:"
        '
        'lnlNombreM
        '
        Me.lnlNombreM.AutoSize = True
        Me.lnlNombreM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlNombreM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lnlNombreM.Location = New System.Drawing.Point(63, 92)
        Me.lnlNombreM.Name = "lnlNombreM"
        Me.lnlNombreM.Size = New System.Drawing.Size(94, 19)
        Me.lnlNombreM.TabIndex = 2
        Me.lnlNombreM.Text = "NOMBRES:"
        '
        'lblFechaReg
        '
        Me.lblFechaReg.AutoSize = True
        Me.lblFechaReg.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblFechaReg.Location = New System.Drawing.Point(689, 18)
        Me.lblFechaReg.Name = "lblFechaReg"
        Me.lblFechaReg.Size = New System.Drawing.Size(69, 19)
        Me.lblFechaReg.TabIndex = 1
        Me.lblFechaReg.Text = "FECHA:"
        '
        'lblDocIdentidad
        '
        Me.lblDocIdentidad.AutoSize = True
        Me.lblDocIdentidad.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocIdentidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblDocIdentidad.Location = New System.Drawing.Point(35, 18)
        Me.lblDocIdentidad.Name = "lblDocIdentidad"
        Me.lblDocIdentidad.Size = New System.Drawing.Size(117, 19)
        Me.lblDocIdentidad.TabIndex = 0
        Me.lblDocIdentidad.Text = "DOCUMENTO:"
        '
        'tabMedicoBusqueda
        '
        Me.tabMedicoBusqueda.BackColor = System.Drawing.Color.Gainsboro
        Me.tabMedicoBusqueda.Controls.Add(Me.dgvListaMedicos)
        Me.tabMedicoBusqueda.Location = New System.Drawing.Point(4, 28)
        Me.tabMedicoBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabMedicoBusqueda.Name = "tabMedicoBusqueda"
        Me.tabMedicoBusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabMedicoBusqueda.Size = New System.Drawing.Size(948, 504)
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
        Me.dgvListaMedicos.Location = New System.Drawing.Point(3, 2)
        Me.dgvListaMedicos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListaMedicos.Name = "dgvListaMedicos"
        Me.dgvListaMedicos.ReadOnly = True
        Me.dgvListaMedicos.Size = New System.Drawing.Size(942, 500)
        Me.dgvListaMedicos.TabIndex = 0
        '
        'btnEliminarTelefono
        '
        Me.btnEliminarTelefono.Enabled = False
        Me.btnEliminarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarTelefono.ForeColor = System.Drawing.Color.Transparent
        Me.btnEliminarTelefono.Image = Global.appGestion.My.Resources.Resources.delTel1
        Me.btnEliminarTelefono.Location = New System.Drawing.Point(531, 379)
        Me.btnEliminarTelefono.Name = "btnEliminarTelefono"
        Me.btnEliminarTelefono.Padding = New System.Windows.Forms.Padding(5)
        Me.btnEliminarTelefono.Size = New System.Drawing.Size(44, 37)
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
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(531, 338)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Padding = New System.Windows.Forms.Padding(5)
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(44, 37)
        Me.btnAgregarTelefono.TabIndex = 22
        Me.tttTelefono.SetToolTip(Me.btnAgregarTelefono, "Permite el ingreso de un nuevo telefono")
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
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
        Me.picEncabezado.Location = New System.Drawing.Point(0, -1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(985, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 3
        Me.picEncabezado.TabStop = False
        '
        'tttTelefono
        '
        Me.tttTelefono.ToolTipTitle = "Opciones de Telefonos"
        '
        'colDocIdentidad
        '
        Me.colDocIdentidad.DataPropertyName = "DOCUMENTO"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDocIdentidad.DefaultCellStyle = DataGridViewCellStyle6
        Me.colDocIdentidad.HeaderText = "DOCUMENTO"
        Me.colDocIdentidad.Name = "colDocIdentidad"
        Me.colDocIdentidad.ReadOnly = True
        '
        'colNMedico
        '
        Me.colNMedico.DataPropertyName = "NMEDICO"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colNMedico.DefaultCellStyle = DataGridViewCellStyle7
        Me.colNMedico.HeaderText = "Nº MEDICO"
        Me.colNMedico.Name = "colNMedico"
        Me.colNMedico.ReadOnly = True
        Me.colNMedico.Width = 110
        '
        'colNombres
        '
        Me.colNombres.DataPropertyName = "NOMBRES"
        Me.colNombres.HeaderText = "NOMBRES"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.ReadOnly = True
        '
        'colApellidos
        '
        Me.colApellidos.DataPropertyName = "APELLIDOS"
        Me.colApellidos.HeaderText = "APELLIDOS"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.ReadOnly = True
        '
        'colEmail
        '
        Me.colEmail.DataPropertyName = "EMAIL"
        DataGridViewCellStyle8.NullValue = "yes"
        Me.colEmail.DefaultCellStyle = DataGridViewCellStyle8
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
        'frmMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 674)
        Me.Controls.Add(Me.tabOpcionesMedico)
        Me.Controls.Add(Me.toolsMenuMedico)
        Me.Controls.Add(Me.picEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents lnlNombreM As Label
    Friend WithEvents lblDireccionM As Label
    Friend WithEvents lblNumeroCalleM As Label
    Friend WithEvents lblAptoM As Label
    Friend WithEvents lblBarrioM As Label
    Friend WithEvents lblEsquinaM As Label
    Friend WithEvents lblEmailM As Label
    Friend WithEvents lblFechaNacM As Label
    Friend WithEvents lnlNumeroMedico As Label
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
    Friend WithEvents colDocIdentidad As DataGridViewTextBoxColumn
    Friend WithEvents colNMedico As DataGridViewTextBoxColumn
    Friend WithEvents colNombres As DataGridViewTextBoxColumn
    Friend WithEvents colApellidos As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colFechRegistro As DataGridViewTextBoxColumn
    Friend WithEvents colActivo As DataGridViewTextBoxColumn
End Class
