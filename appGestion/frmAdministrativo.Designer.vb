<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministrativo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrativo))
        Me.tabOpcionAdmin = New System.Windows.Forms.TabControl()
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
        Me.txtNumAdmin = New System.Windows.Forms.TextBox()
        Me.txtDocIdentidad = New System.Windows.Forms.TextBox()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.lblNumeroEmpleado = New System.Windows.Forms.Label()
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
        Me.tabBusqueda = New System.Windows.Forms.TabPage()
        Me.dgvListaAdministrador = New System.Windows.Forms.DataGridView()
        Me.colDocIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.toolsMenuAdmin = New System.Windows.Forms.ToolStrip()
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
        Me.tabOpcionAdmin.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        CType(Me.dgvListaTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBusqueda.SuspendLayout()
        CType(Me.dgvListaAdministrador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolsMenuAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabOpcionAdmin
        '
        Me.tabOpcionAdmin.Controls.Add(Me.tabDatos)
        Me.tabOpcionAdmin.Controls.Add(Me.tabBusqueda)
        Me.tabOpcionAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabOpcionAdmin.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOpcionAdmin.Location = New System.Drawing.Point(40, 135)
        Me.tabOpcionAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabOpcionAdmin.Name = "tabOpcionAdmin"
        Me.tabOpcionAdmin.SelectedIndex = 0
        Me.tabOpcionAdmin.Size = New System.Drawing.Size(944, 496)
        Me.tabOpcionAdmin.TabIndex = 2
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
        Me.tabDatos.Controls.Add(Me.txtNumAdmin)
        Me.tabDatos.Controls.Add(Me.txtDocIdentidad)
        Me.tabDatos.Controls.Add(Me.lblTelefonos)
        Me.tabDatos.Controls.Add(Me.lblNumeroEmpleado)
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
        Me.tabDatos.Location = New System.Drawing.Point(4, 28)
        Me.tabDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Size = New System.Drawing.Size(936, 464)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Datos"
        '
        'btnRestPass
        '
        Me.btnRestPass.Enabled = False
        Me.btnRestPass.Image = Global.appGestion.My.Resources.Resources.pass
        Me.btnRestPass.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRestPass.Location = New System.Drawing.Point(748, 338)
        Me.btnRestPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRestPass.Name = "btnRestPass"
        Me.btnRestPass.Size = New System.Drawing.Size(157, 89)
        Me.btnRestPass.TabIndex = 84
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
        Me.btnEliminarTelefono.Location = New System.Drawing.Point(527, 379)
        Me.btnEliminarTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarTelefono.Name = "btnEliminarTelefono"
        Me.btnEliminarTelefono.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnEliminarTelefono.Size = New System.Drawing.Size(44, 37)
        Me.btnEliminarTelefono.TabIndex = 83
        Me.btnEliminarTelefono.UseVisualStyleBackColor = True
        '
        'btnAgregarTelefono
        '
        Me.btnAgregarTelefono.Enabled = False
        Me.btnAgregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarTelefono.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgregarTelefono.Image = Global.appGestion.My.Resources.Resources.addTel1
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(527, 338)
        Me.btnAgregarTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(44, 37)
        Me.btnAgregarTelefono.TabIndex = 82
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(829, 427)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(75, 25)
        Me.chkActivo.TabIndex = 81
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
        Me.dtpFechaNac.CustomFormat = ""
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(768, 53)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(137, 27)
        Me.dtpFechaNac.TabIndex = 60
        '
        'dgvListaTelefonos
        '
        Me.dgvListaTelefonos.AllowUserToAddRows = False
        Me.dgvListaTelefonos.AllowUserToDeleteRows = False
        Me.dgvListaTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListaTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTelefono})
        Me.dgvListaTelefonos.Enabled = False
        Me.dgvListaTelefonos.Location = New System.Drawing.Point(167, 338)
        Me.dgvListaTelefonos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvListaTelefonos.Name = "dgvListaTelefonos"
        Me.dgvListaTelefonos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListaTelefonos.Size = New System.Drawing.Size(353, 112)
        Me.dgvListaTelefonos.TabIndex = 79
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
        Me.txtBarrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarrio.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarrio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBarrio.Location = New System.Drawing.Point(167, 294)
        Me.txtBarrio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBarrio.MaxLength = 30
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(421, 27)
        Me.txtBarrio.TabIndex = 77
        '
        'txtEsquina
        '
        Me.txtEsquina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEsquina.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEsquina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEsquina.Location = New System.Drawing.Point(400, 256)
        Me.txtEsquina.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEsquina.MaxLength = 40
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.Size = New System.Drawing.Size(505, 27)
        Me.txtEsquina.TabIndex = 74
        '
        'txtApto
        '
        Me.txtApto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApto.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApto.Location = New System.Drawing.Point(167, 256)
        Me.txtApto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApto.MaxLength = 11
        Me.txtApto.Name = "txtApto"
        Me.txtApto.Size = New System.Drawing.Size(129, 27)
        Me.txtApto.TabIndex = 72
        Me.txtApto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumeroCalle
        '
        Me.txtNumeroCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroCalle.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNumeroCalle.Location = New System.Drawing.Point(776, 215)
        Me.txtNumeroCalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumeroCalle.MaxLength = 11
        Me.txtNumeroCalle.Name = "txtNumeroCalle"
        Me.txtNumeroCalle.Size = New System.Drawing.Size(129, 27)
        Me.txtNumeroCalle.TabIndex = 70
        Me.txtNumeroCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCalle
        '
        Me.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalle.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCalle.Location = New System.Drawing.Point(167, 215)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCalle.MaxLength = 40
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(505, 27)
        Me.txtCalle.TabIndex = 68
        '
        'lblOtrosDatos
        '
        Me.lblOtrosDatos.AutoSize = True
        Me.lblOtrosDatos.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtrosDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.lblOtrosDatos.Location = New System.Drawing.Point(43, 181)
        Me.lblOtrosDatos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOtrosDatos.Name = "lblOtrosDatos"
        Me.lblOtrosDatos.Size = New System.Drawing.Size(122, 23)
        Me.lblOtrosDatos.TabIndex = 80
        Me.lblOtrosDatos.Text = "OTROS DATOS"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(167, 127)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(501, 27)
        Me.txtEmail.TabIndex = 66
        '
        'txtApellidos
        '
        Me.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApellidos.Location = New System.Drawing.Point(607, 89)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellidos.MaxLength = 25
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(299, 27)
        Me.txtApellidos.TabIndex = 64
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombres.Location = New System.Drawing.Point(167, 89)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombres.MaxLength = 25
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(299, 27)
        Me.txtNombres.TabIndex = 63
        '
        'txtFechaRegistro
        '
        Me.txtFechaRegistro.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFechaRegistro.Location = New System.Drawing.Point(767, 15)
        Me.txtFechaRegistro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFechaRegistro.MaxLength = 65535
        Me.txtFechaRegistro.Name = "txtFechaRegistro"
        Me.txtFechaRegistro.ReadOnly = True
        Me.txtFechaRegistro.Size = New System.Drawing.Size(139, 27)
        Me.txtFechaRegistro.TabIndex = 57
        Me.txtFechaRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumAdmin
        '
        Me.txtNumAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumAdmin.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNumAdmin.Location = New System.Drawing.Point(167, 52)
        Me.txtNumAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumAdmin.MaxLength = 11
        Me.txtNumAdmin.Name = "txtNumAdmin"
        Me.txtNumAdmin.Size = New System.Drawing.Size(111, 27)
        Me.txtNumAdmin.TabIndex = 58
        Me.txtNumAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDocIdentidad
        '
        Me.txtDocIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocIdentidad.Enabled = False
        Me.txtDocIdentidad.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocIdentidad.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtDocIdentidad.Location = New System.Drawing.Point(167, 15)
        Me.txtDocIdentidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDocIdentidad.MaxLength = 8
        Me.txtDocIdentidad.Name = "txtDocIdentidad"
        Me.txtDocIdentidad.Size = New System.Drawing.Size(159, 27)
        Me.txtDocIdentidad.TabIndex = 55
        Me.txtDocIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTelefonos.Location = New System.Drawing.Point(37, 343)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(95, 21)
        Me.lblTelefonos.TabIndex = 78
        Me.lblTelefonos.Text = "TELEFONOS:"
        '
        'lblNumeroEmpleado
        '
        Me.lblNumeroEmpleado.AutoSize = True
        Me.lblNumeroEmpleado.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNumeroEmpleado.Location = New System.Drawing.Point(23, 55)
        Me.lblNumeroEmpleado.Name = "lblNumeroEmpleado"
        Me.lblNumeroEmpleado.Size = New System.Drawing.Size(115, 21)
        Me.lblNumeroEmpleado.TabIndex = 76
        Me.lblNumeroEmpleado.Text = "Nº EMPLEADO:"
        '
        'lblEmailM
        '
        Me.lblEmailM.AutoSize = True
        Me.lblEmailM.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblEmailM.Location = New System.Drawing.Point(85, 130)
        Me.lblEmailM.Name = "lblEmailM"
        Me.lblEmailM.Size = New System.Drawing.Size(59, 21)
        Me.lblEmailM.TabIndex = 75
        Me.lblEmailM.Text = "EMAIL:"
        '
        'lblFechaNacM
        '
        Me.lblFechaNacM.AutoSize = True
        Me.lblFechaNacM.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblFechaNacM.Location = New System.Drawing.Point(639, 55)
        Me.lblFechaNacM.Name = "lblFechaNacM"
        Me.lblFechaNacM.Size = New System.Drawing.Size(99, 21)
        Me.lblFechaNacM.TabIndex = 73
        Me.lblFechaNacM.Text = "FECHA NAC.:"
        '
        'lblBarrioM
        '
        Me.lblBarrioM.AutoSize = True
        Me.lblBarrioM.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarrioM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblBarrioM.Location = New System.Drawing.Point(73, 298)
        Me.lblBarrioM.Name = "lblBarrioM"
        Me.lblBarrioM.Size = New System.Drawing.Size(67, 21)
        Me.lblBarrioM.TabIndex = 71
        Me.lblBarrioM.Text = "BARRIO:"
        '
        'lblEsquinaM
        '
        Me.lblEsquinaM.AutoSize = True
        Me.lblEsquinaM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsquinaM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblEsquinaM.Location = New System.Drawing.Point(304, 260)
        Me.lblEsquinaM.Name = "lblEsquinaM"
        Me.lblEsquinaM.Size = New System.Drawing.Size(86, 19)
        Me.lblEsquinaM.TabIndex = 69
        Me.lblEsquinaM.Text = "ESQUINA:"
        '
        'lblAptoM
        '
        Me.lblAptoM.AutoSize = True
        Me.lblAptoM.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAptoM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblAptoM.Location = New System.Drawing.Point(91, 260)
        Me.lblAptoM.Name = "lblAptoM"
        Me.lblAptoM.Size = New System.Drawing.Size(53, 21)
        Me.lblAptoM.TabIndex = 67
        Me.lblAptoM.Text = "APTO:"
        '
        'lblNumeroCalleM
        '
        Me.lblNumeroCalleM.AutoSize = True
        Me.lblNumeroCalleM.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCalleM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNumeroCalleM.Location = New System.Drawing.Point(740, 219)
        Me.lblNumeroCalleM.Name = "lblNumeroCalleM"
        Me.lblNumeroCalleM.Size = New System.Drawing.Size(30, 19)
        Me.lblNumeroCalleM.TabIndex = 65
        Me.lblNumeroCalleM.Text = "Nº:"
        '
        'lblDireccionM
        '
        Me.lblDireccionM.AutoSize = True
        Me.lblDireccionM.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblDireccionM.Location = New System.Drawing.Point(43, 219)
        Me.lblDireccionM.Name = "lblDireccionM"
        Me.lblDireccionM.Size = New System.Drawing.Size(90, 21)
        Me.lblDireccionM.TabIndex = 62
        Me.lblDireccionM.Text = "DIRECCION:"
        '
        'lblApellidosM
        '
        Me.lblApellidosM.AutoSize = True
        Me.lblApellidosM.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblApellidosM.Location = New System.Drawing.Point(488, 92)
        Me.lblApellidosM.Name = "lblApellidosM"
        Me.lblApellidosM.Size = New System.Drawing.Size(89, 21)
        Me.lblApellidosM.TabIndex = 61
        Me.lblApellidosM.Text = "APELLIDOS:"
        '
        'lblNombreM
        '
        Me.lblNombreM.AutoSize = True
        Me.lblNombreM.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNombreM.Location = New System.Drawing.Point(53, 92)
        Me.lblNombreM.Name = "lblNombreM"
        Me.lblNombreM.Size = New System.Drawing.Size(86, 21)
        Me.lblNombreM.TabIndex = 59
        Me.lblNombreM.Text = "NOMBRES:"
        '
        'lblFechaReg
        '
        Me.lblFechaReg.AutoSize = True
        Me.lblFechaReg.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblFechaReg.Location = New System.Drawing.Point(685, 18)
        Me.lblFechaReg.Name = "lblFechaReg"
        Me.lblFechaReg.Size = New System.Drawing.Size(61, 21)
        Me.lblFechaReg.TabIndex = 56
        Me.lblFechaReg.Text = "FECHA:"
        '
        'lblDocIdentidad
        '
        Me.lblDocIdentidad.AutoSize = True
        Me.lblDocIdentidad.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocIdentidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblDocIdentidad.Location = New System.Drawing.Point(31, 18)
        Me.lblDocIdentidad.Name = "lblDocIdentidad"
        Me.lblDocIdentidad.Size = New System.Drawing.Size(109, 21)
        Me.lblDocIdentidad.TabIndex = 54
        Me.lblDocIdentidad.Text = "DOCUMENTO:"
        '
        'tabBusqueda
        '
        Me.tabBusqueda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabBusqueda.Controls.Add(Me.dgvListaAdministrador)
        Me.tabBusqueda.Location = New System.Drawing.Point(4, 28)
        Me.tabBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabBusqueda.Name = "tabBusqueda"
        Me.tabBusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabBusqueda.Size = New System.Drawing.Size(936, 464)
        Me.tabBusqueda.TabIndex = 1
        Me.tabBusqueda.Text = "Busqueda"
        '
        'dgvListaAdministrador
        '
        Me.dgvListaAdministrador.AllowUserToAddRows = False
        Me.dgvListaAdministrador.AllowUserToDeleteRows = False
        Me.dgvListaAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaAdministrador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDocIdentidad, Me.colNMedico, Me.colNombres, Me.colApellidos, Me.colEmail, Me.colFechRegistro, Me.colActivo})
        Me.dgvListaAdministrador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaAdministrador.Location = New System.Drawing.Point(3, 2)
        Me.dgvListaAdministrador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvListaAdministrador.MultiSelect = False
        Me.dgvListaAdministrador.Name = "dgvListaAdministrador"
        Me.dgvListaAdministrador.ReadOnly = True
        Me.dgvListaAdministrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaAdministrador.Size = New System.Drawing.Size(930, 460)
        Me.dgvListaAdministrador.TabIndex = 1
        '
        'colDocIdentidad
        '
        Me.colDocIdentidad.DataPropertyName = "DOCUMENTO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDocIdentidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDocIdentidad.HeaderText = "DOCUMENTO"
        Me.colDocIdentidad.Name = "colDocIdentidad"
        Me.colDocIdentidad.ReadOnly = True
        Me.colDocIdentidad.Width = 120
        '
        'colNMedico
        '
        Me.colNMedico.DataPropertyName = "NEMPLEADO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colNMedico.DefaultCellStyle = DataGridViewCellStyle3
        Me.colNMedico.HeaderText = "Nº EMPLEADO"
        Me.colNMedico.Name = "colNMedico"
        Me.colNMedico.ReadOnly = True
        Me.colNMedico.Width = 150
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
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-12, 1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(1025, 79)
        Me.picEncabezado.TabIndex = 4
        Me.picEncabezado.TabStop = False
        '
        'toolsMenuAdmin
        '
        Me.toolsMenuAdmin.AutoSize = False
        Me.toolsMenuAdmin.Dock = System.Windows.Forms.DockStyle.None
        Me.toolsMenuAdmin.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolsMenuAdmin.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolsMenuAdmin.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.toolsMenuAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBtnAgregar, Me.tabSeparador, Me.mnuBtnGuardar, Me.tabSeparador1, Me.mnuBtnCancelar, Me.tabSeperador2, Me.mnuBtnNueva, Me.ToolStripSeparator1, Me.mnuBtnBuscar, Me.tabSeparador3, Me.mnuBtnBorrar, Me.tabSeparador4, Me.mnuBtnReactivar, Me.mnuBtnModificar})
        Me.toolsMenuAdmin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolsMenuAdmin.Location = New System.Drawing.Point(5, 82)
        Me.toolsMenuAdmin.Name = "toolsMenuAdmin"
        Me.toolsMenuAdmin.Size = New System.Drawing.Size(1007, 44)
        Me.toolsMenuAdmin.TabIndex = 5
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
        Me.mnuBtnReactivar.Image = Global.appGestion.My.Resources.Resources.reactivar
        Me.mnuBtnReactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBtnReactivar.Name = "mnuBtnReactivar"
        Me.mnuBtnReactivar.Size = New System.Drawing.Size(106, 29)
        Me.mnuBtnReactivar.Text = "Reactivar"
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
        'frmAdministrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 642)
        Me.Controls.Add(Me.toolsMenuAdmin)
        Me.Controls.Add(Me.picEncabezado)
        Me.Controls.Add(Me.tabOpcionAdmin)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAdministrativo"
        Me.Text = "Administrativo"
        Me.tabOpcionAdmin.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        CType(Me.dgvListaTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBusqueda.ResumeLayout(False)
        CType(Me.dgvListaAdministrador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolsMenuAdmin.ResumeLayout(False)
        Me.toolsMenuAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabOpcionAdmin As TabControl
    Friend WithEvents tabDatos As TabPage
    Friend WithEvents tabBusqueda As TabPage
    Friend WithEvents picEncabezado As PictureBox
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
    Friend WithEvents txtNumAdmin As TextBox
    Friend WithEvents txtDocIdentidad As TextBox
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents lblNumeroEmpleado As Label
    Friend WithEvents lblEmailM As Label
    Friend WithEvents lblFechaNacM As Label
    Friend WithEvents lblBarrioM As Label
    Friend WithEvents lblEsquinaM As Label
    Friend WithEvents lblAptoM As Label
    Friend WithEvents lblNumeroCalleM As Label
    Friend WithEvents lblDireccionM As Label
    Friend WithEvents lblApellidosM As Label
    Friend WithEvents lblNombreM As Label
    Friend WithEvents lblFechaReg As Label
    Friend WithEvents lblDocIdentidad As Label
    Friend WithEvents dgvListaAdministrador As DataGridView
    Friend WithEvents toolsMenuAdmin As ToolStrip
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
    Friend WithEvents mnuBtnReactivar As ToolStripButton
    Friend WithEvents colDocIdentidad As DataGridViewTextBoxColumn
    Friend WithEvents colNMedico As DataGridViewTextBoxColumn
    Friend WithEvents colNombres As DataGridViewTextBoxColumn
    Friend WithEvents colApellidos As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colFechRegistro As DataGridViewTextBoxColumn
    Friend WithEvents colActivo As DataGridViewTextBoxColumn
    Friend WithEvents btnRestPass As Button
End Class
