<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatologia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatologia))
        Me.picEncabezado = New System.Windows.Forms.PictureBox()
        Me.toolsMenuPatologia = New System.Windows.Forms.ToolStrip()
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
        Me.mnuBtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.tabDatosPatologia = New System.Windows.Forms.TabControl()
        Me.tabDatos = New System.Windows.Forms.TabPage()
        Me.chkActiva = New System.Windows.Forms.CheckBox()
        Me.lblActiva = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregarSigno = New System.Windows.Forms.Button()
        Me.lblSignos = New System.Windows.Forms.Label()
        Me.dgvSignosPatologia = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSintomas = New System.Windows.Forms.Label()
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.dgvSintomasPatologia = New System.Windows.Forms.DataGridView()
        Me.txtPatologiaDescipcion = New System.Windows.Forms.TextBox()
        Me.lblPatologiaDescripcion = New System.Windows.Forms.Label()
        Me.cbPatologiaPonderacion = New System.Windows.Forms.ComboBox()
        Me.lblPatologiaPonderacion = New System.Windows.Forms.Label()
        Me.txtPatologiaNombre = New System.Windows.Forms.TextBox()
        Me.lblPatologiaNombre = New System.Windows.Forms.Label()
        Me.txtPatologiaID = New System.Windows.Forms.TextBox()
        Me.lblPatologiaID = New System.Windows.Forms.Label()
        Me.tabPatologiaBusqueda = New System.Windows.Forms.TabPage()
        Me.dgvListaDePatologias = New System.Windows.Forms.DataGridView()
        Me.lblUrgenciaMenor = New System.Windows.Forms.Label()
        Me.lblUrgencia = New System.Windows.Forms.Label()
        Me.lblEmergencia = New System.Windows.Forms.Label()
        Me.lblSinUrgencia = New System.Windows.Forms.Label()
        Me.tttPonderacion = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolsMenuPatologia.SuspendLayout()
        Me.tabDatosPatologia.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSignosPatologia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSintomasPatologia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPatologiaBusqueda.SuspendLayout()
        CType(Me.dgvListaDePatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEncabezado
        '
        Me.picEncabezado.Image = CType(resources.GetObject("picEncabezado.Image"), System.Drawing.Image)
        Me.picEncabezado.Location = New System.Drawing.Point(-3, 1)
        Me.picEncabezado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picEncabezado.Name = "picEncabezado"
        Me.picEncabezado.Size = New System.Drawing.Size(943, 79)
        Me.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEncabezado.TabIndex = 2
        Me.picEncabezado.TabStop = False
        '
        'toolsMenuPatologia
        '
        Me.toolsMenuPatologia.AutoSize = False
        Me.toolsMenuPatologia.Dock = System.Windows.Forms.DockStyle.None
        Me.toolsMenuPatologia.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolsMenuPatologia.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolsMenuPatologia.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.toolsMenuPatologia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBtnAgregar, Me.tabSeparador, Me.mnuBtnGuardar, Me.tabSeparador1, Me.mnuBtnCancelar, Me.tabSeperador2, Me.mnuBtnNueva, Me.ToolStripSeparator1, Me.mnuBtnBuscar, Me.tabSeparador3, Me.mnuBtnBorrar, Me.tabSeparador4, Me.mnuBtnModificar})
        Me.toolsMenuPatologia.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolsMenuPatologia.Location = New System.Drawing.Point(9, 82)
        Me.toolsMenuPatologia.Name = "toolsMenuPatologia"
        Me.toolsMenuPatologia.Size = New System.Drawing.Size(931, 44)
        Me.toolsMenuPatologia.TabIndex = 3
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
        'tabDatosPatologia
        '
        Me.tabDatosPatologia.Controls.Add(Me.tabDatos)
        Me.tabDatosPatologia.Controls.Add(Me.tabPatologiaBusqueda)
        Me.tabDatosPatologia.Font = New System.Drawing.Font("Arial", 10.2!)
        Me.tabDatosPatologia.Location = New System.Drawing.Point(12, 140)
        Me.tabDatosPatologia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatosPatologia.Name = "tabDatosPatologia"
        Me.tabDatosPatologia.SelectedIndex = 0
        Me.tabDatosPatologia.Size = New System.Drawing.Size(875, 510)
        Me.tabDatosPatologia.TabIndex = 4
        '
        'tabDatos
        '
        Me.tabDatos.BackColor = System.Drawing.Color.Gainsboro
        Me.tabDatos.Controls.Add(Me.chkActiva)
        Me.tabDatos.Controls.Add(Me.lblActiva)
        Me.tabDatos.Controls.Add(Me.Panel1)
        Me.tabDatos.Controls.Add(Me.txtPatologiaDescipcion)
        Me.tabDatos.Controls.Add(Me.lblPatologiaDescripcion)
        Me.tabDatos.Controls.Add(Me.cbPatologiaPonderacion)
        Me.tabDatos.Controls.Add(Me.lblPatologiaPonderacion)
        Me.tabDatos.Controls.Add(Me.txtPatologiaNombre)
        Me.tabDatos.Controls.Add(Me.lblPatologiaNombre)
        Me.tabDatos.Controls.Add(Me.txtPatologiaID)
        Me.tabDatos.Controls.Add(Me.lblPatologiaID)
        Me.tabDatos.Location = New System.Drawing.Point(4, 28)
        Me.tabDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDatos.Size = New System.Drawing.Size(867, 478)
        Me.tabDatos.TabIndex = 0
        Me.tabDatos.Text = "Datos"
        '
        'chkActiva
        '
        Me.chkActiva.AutoSize = True
        Me.chkActiva.Checked = True
        Me.chkActiva.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActiva.Location = New System.Drawing.Point(160, 420)
        Me.chkActiva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkActiva.Name = "chkActiva"
        Me.chkActiva.Size = New System.Drawing.Size(18, 17)
        Me.chkActiva.TabIndex = 14
        Me.chkActiva.UseVisualStyleBackColor = True
        '
        'lblActiva
        '
        Me.lblActiva.AutoSize = True
        Me.lblActiva.Location = New System.Drawing.Point(73, 420)
        Me.lblActiva.Name = "lblActiva"
        Me.lblActiva.Size = New System.Drawing.Size(72, 19)
        Me.lblActiva.TabIndex = 13
        Me.lblActiva.Text = "ACTIVA:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAgregarSigno)
        Me.Panel1.Controls.Add(Me.lblSignos)
        Me.Panel1.Controls.Add(Me.dgvSignosPatologia)
        Me.Panel1.Controls.Add(Me.lblSintomas)
        Me.Panel1.Controls.Add(Me.btnAgregarSintoma)
        Me.Panel1.Controls.Add(Me.dgvSintomasPatologia)
        Me.Panel1.Location = New System.Drawing.Point(5, 190)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 219)
        Me.Panel1.TabIndex = 12
        '
        'btnAgregarSigno
        '
        Me.btnAgregarSigno.Enabled = False
        Me.btnAgregarSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSigno.ForeColor = System.Drawing.Color.Green
        Me.btnAgregarSigno.Location = New System.Drawing.Point(561, 170)
        Me.btnAgregarSigno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarSigno.Name = "btnAgregarSigno"
        Me.btnAgregarSigno.Size = New System.Drawing.Size(105, 39)
        Me.btnAgregarSigno.TabIndex = 29
        Me.btnAgregarSigno.Text = "Agregar"
        Me.btnAgregarSigno.UseVisualStyleBackColor = True
        '
        'lblSignos
        '
        Me.lblSignos.AutoSize = True
        Me.lblSignos.Location = New System.Drawing.Point(475, 15)
        Me.lblSignos.Name = "lblSignos"
        Me.lblSignos.Size = New System.Drawing.Size(76, 19)
        Me.lblSignos.TabIndex = 28
        Me.lblSignos.Text = "SIGNOS:"
        '
        'dgvSignosPatologia
        '
        Me.dgvSignosPatologia.AllowUserToAddRows = False
        Me.dgvSignosPatologia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSignosPatologia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvSignosPatologia.Enabled = False
        Me.dgvSignosPatologia.Location = New System.Drawing.Point(561, 2)
        Me.dgvSignosPatologia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvSignosPatologia.Name = "dgvSignosPatologia"
        Me.dgvSignosPatologia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgvSignosPatologia.RowTemplate.Height = 24
        Me.dgvSignosPatologia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSignosPatologia.Size = New System.Drawing.Size(269, 161)
        Me.dgvSignosPatologia.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'lblSintomas
        '
        Me.lblSintomas.AutoSize = True
        Me.lblSintomas.Location = New System.Drawing.Point(43, 15)
        Me.lblSintomas.Name = "lblSintomas"
        Me.lblSintomas.Size = New System.Drawing.Size(97, 19)
        Me.lblSintomas.TabIndex = 26
        Me.lblSintomas.Text = "SINTOMAS:"
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.Enabled = False
        Me.btnAgregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSintoma.ForeColor = System.Drawing.Color.Green
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(156, 170)
        Me.btnAgregarSintoma.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(105, 39)
        Me.btnAgregarSintoma.TabIndex = 25
        Me.btnAgregarSintoma.Text = "Agregar"
        Me.tttPonderacion.SetToolTip(Me.btnAgregarSintoma, "Habilita el ingreso de sintomas asociados")
        Me.btnAgregarSintoma.UseVisualStyleBackColor = True
        '
        'dgvSintomasPatologia
        '
        Me.dgvSintomasPatologia.AllowUserToAddRows = False
        Me.dgvSintomasPatologia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasPatologia.Location = New System.Drawing.Point(155, 2)
        Me.dgvSintomasPatologia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvSintomasPatologia.Name = "dgvSintomasPatologia"
        Me.dgvSintomasPatologia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgvSintomasPatologia.RowTemplate.Height = 24
        Me.dgvSintomasPatologia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSintomasPatologia.Size = New System.Drawing.Size(273, 161)
        Me.dgvSintomasPatologia.TabIndex = 24
        '
        'txtPatologiaDescipcion
        '
        Me.txtPatologiaDescipcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatologiaDescipcion.Location = New System.Drawing.Point(163, 69)
        Me.txtPatologiaDescipcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPatologiaDescipcion.Multiline = True
        Me.txtPatologiaDescipcion.Name = "txtPatologiaDescipcion"
        Me.txtPatologiaDescipcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPatologiaDescipcion.Size = New System.Drawing.Size(675, 114)
        Me.txtPatologiaDescipcion.TabIndex = 7
        '
        'lblPatologiaDescripcion
        '
        Me.lblPatologiaDescripcion.AutoSize = True
        Me.lblPatologiaDescripcion.Location = New System.Drawing.Point(19, 69)
        Me.lblPatologiaDescripcion.Name = "lblPatologiaDescripcion"
        Me.lblPatologiaDescripcion.Size = New System.Drawing.Size(127, 19)
        Me.lblPatologiaDescripcion.TabIndex = 6
        Me.lblPatologiaDescripcion.Text = "DESCRIPCION:"
        '
        'cbPatologiaPonderacion
        '
        Me.cbPatologiaPonderacion.FormattingEnabled = True
        Me.cbPatologiaPonderacion.Items.AddRange(New Object() {"10", "20", "30", "40", " "})
        Me.cbPatologiaPonderacion.Location = New System.Drawing.Point(747, 22)
        Me.cbPatologiaPonderacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPatologiaPonderacion.Name = "cbPatologiaPonderacion"
        Me.cbPatologiaPonderacion.Size = New System.Drawing.Size(93, 27)
        Me.cbPatologiaPonderacion.TabIndex = 5
        '
        'lblPatologiaPonderacion
        '
        Me.lblPatologiaPonderacion.AutoSize = True
        Me.lblPatologiaPonderacion.Location = New System.Drawing.Point(599, 26)
        Me.lblPatologiaPonderacion.Name = "lblPatologiaPonderacion"
        Me.lblPatologiaPonderacion.Size = New System.Drawing.Size(133, 19)
        Me.lblPatologiaPonderacion.TabIndex = 4
        Me.lblPatologiaPonderacion.Text = "PONDERACION:"
        '
        'txtPatologiaNombre
        '
        Me.txtPatologiaNombre.Location = New System.Drawing.Point(379, 22)
        Me.txtPatologiaNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPatologiaNombre.Name = "txtPatologiaNombre"
        Me.txtPatologiaNombre.Size = New System.Drawing.Size(199, 27)
        Me.txtPatologiaNombre.TabIndex = 3
        '
        'lblPatologiaNombre
        '
        Me.lblPatologiaNombre.AutoSize = True
        Me.lblPatologiaNombre.Location = New System.Drawing.Point(277, 26)
        Me.lblPatologiaNombre.Name = "lblPatologiaNombre"
        Me.lblPatologiaNombre.Size = New System.Drawing.Size(83, 19)
        Me.lblPatologiaNombre.TabIndex = 2
        Me.lblPatologiaNombre.Text = "NOMBRE:"
        '
        'txtPatologiaID
        '
        Me.txtPatologiaID.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtPatologiaID.Location = New System.Drawing.Point(160, 22)
        Me.txtPatologiaID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPatologiaID.Name = "txtPatologiaID"
        Me.txtPatologiaID.ReadOnly = True
        Me.txtPatologiaID.Size = New System.Drawing.Size(104, 27)
        Me.txtPatologiaID.TabIndex = 1
        Me.txtPatologiaID.Text = "0"
        Me.txtPatologiaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPatologiaID
        '
        Me.lblPatologiaID.AutoSize = True
        Me.lblPatologiaID.Location = New System.Drawing.Point(115, 26)
        Me.lblPatologiaID.Name = "lblPatologiaID"
        Me.lblPatologiaID.Size = New System.Drawing.Size(31, 19)
        Me.lblPatologiaID.TabIndex = 0
        Me.lblPatologiaID.Text = "ID:"
        '
        'tabPatologiaBusqueda
        '
        Me.tabPatologiaBusqueda.Controls.Add(Me.dgvListaDePatologias)
        Me.tabPatologiaBusqueda.Location = New System.Drawing.Point(4, 28)
        Me.tabPatologiaBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabPatologiaBusqueda.Name = "tabPatologiaBusqueda"
        Me.tabPatologiaBusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabPatologiaBusqueda.Size = New System.Drawing.Size(867, 478)
        Me.tabPatologiaBusqueda.TabIndex = 1
        Me.tabPatologiaBusqueda.Text = "Busqueda"
        Me.tabPatologiaBusqueda.UseVisualStyleBackColor = True
        '
        'dgvListaDePatologias
        '
        Me.dgvListaDePatologias.AllowUserToAddRows = False
        Me.dgvListaDePatologias.AllowUserToDeleteRows = False
        Me.dgvListaDePatologias.AllowUserToOrderColumns = True
        Me.dgvListaDePatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaDePatologias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaDePatologias.Location = New System.Drawing.Point(3, 2)
        Me.dgvListaDePatologias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvListaDePatologias.Name = "dgvListaDePatologias"
        Me.dgvListaDePatologias.ReadOnly = True
        Me.dgvListaDePatologias.RowTemplate.Height = 24
        Me.dgvListaDePatologias.Size = New System.Drawing.Size(861, 474)
        Me.dgvListaDePatologias.TabIndex = 0
        '
        'lblUrgenciaMenor
        '
        Me.lblUrgenciaMenor.BackColor = System.Drawing.Color.Green
        Me.lblUrgenciaMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrgenciaMenor.ForeColor = System.Drawing.Color.White
        Me.lblUrgenciaMenor.Location = New System.Drawing.Point(889, 226)
        Me.lblUrgenciaMenor.Name = "lblUrgenciaMenor"
        Me.lblUrgenciaMenor.Size = New System.Drawing.Size(37, 30)
        Me.lblUrgenciaMenor.TabIndex = 11
        Me.lblUrgenciaMenor.Text = "20"
        Me.lblUrgenciaMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUrgencia
        '
        Me.lblUrgencia.BackColor = System.Drawing.Color.Yellow
        Me.lblUrgencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrgencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUrgencia.Location = New System.Drawing.Point(889, 197)
        Me.lblUrgencia.Name = "lblUrgencia"
        Me.lblUrgencia.Size = New System.Drawing.Size(37, 30)
        Me.lblUrgencia.TabIndex = 10
        Me.lblUrgencia.Text = "30"
        Me.lblUrgencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmergencia
        '
        Me.lblEmergencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergencia.ForeColor = System.Drawing.Color.White
        Me.lblEmergencia.Location = New System.Drawing.Point(889, 167)
        Me.lblEmergencia.Name = "lblEmergencia"
        Me.lblEmergencia.Size = New System.Drawing.Size(37, 30)
        Me.lblEmergencia.TabIndex = 9
        Me.lblEmergencia.Text = "40"
        Me.lblEmergencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSinUrgencia
        '
        Me.lblSinUrgencia.BackColor = System.Drawing.Color.Teal
        Me.lblSinUrgencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinUrgencia.ForeColor = System.Drawing.Color.White
        Me.lblSinUrgencia.Location = New System.Drawing.Point(889, 255)
        Me.lblSinUrgencia.Name = "lblSinUrgencia"
        Me.lblSinUrgencia.Size = New System.Drawing.Size(37, 30)
        Me.lblSinUrgencia.TabIndex = 12
        Me.lblSinUrgencia.Text = "10"
        Me.lblSinUrgencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tttPonderacion
        '
        Me.tttPonderacion.ToolTipTitle = "Informacion de Patologia"
        '
        'frmPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 661)
        Me.Controls.Add(Me.lblSinUrgencia)
        Me.Controls.Add(Me.lblUrgenciaMenor)
        Me.Controls.Add(Me.lblUrgencia)
        Me.Controls.Add(Me.lblEmergencia)
        Me.Controls.Add(Me.tabDatosPatologia)
        Me.Controls.Add(Me.toolsMenuPatologia)
        Me.Controls.Add(Me.picEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPatologia"
        Me.Text = "PATOLOGIA"
        CType(Me.picEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolsMenuPatologia.ResumeLayout(False)
        Me.toolsMenuPatologia.PerformLayout()
        Me.tabDatosPatologia.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.tabDatos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSignosPatologia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSintomasPatologia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPatologiaBusqueda.ResumeLayout(False)
        CType(Me.dgvListaDePatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEncabezado As PictureBox
    Friend WithEvents toolsMenuPatologia As ToolStrip
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
    Friend WithEvents tabDatosPatologia As TabControl
    Friend WithEvents tabDatos As TabPage
    Friend WithEvents tabPatologiaBusqueda As TabPage
    Friend WithEvents txtPatologiaID As TextBox
    Friend WithEvents lblPatologiaID As Label
    Friend WithEvents txtPatologiaNombre As TextBox
    Friend WithEvents lblPatologiaNombre As Label
    Friend WithEvents cbPatologiaPonderacion As ComboBox
    Friend WithEvents lblPatologiaPonderacion As Label
    Friend WithEvents txtPatologiaDescipcion As TextBox
    Friend WithEvents lblPatologiaDescripcion As Label
    Friend WithEvents dgvListaDePatologias As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAgregarSigno As Button
    Friend WithEvents lblSignos As Label
    Public WithEvents dgvSignosPatologia As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents lblSintomas As Label
    Friend WithEvents btnAgregarSintoma As Button
    Public WithEvents dgvSintomasPatologia As DataGridView
    Friend WithEvents chkActiva As CheckBox
    Friend WithEvents lblActiva As Label

    Friend WithEvents lblUrgenciaMenor As Label
    Friend WithEvents lblUrgencia As Label
    Friend WithEvents lblEmergencia As Label
    Friend WithEvents lblSinUrgencia As Label
    Friend WithEvents tttPonderacion As ToolTip
End Class
